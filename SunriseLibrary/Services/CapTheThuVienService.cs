using System;
using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class CapTheThuVienService
    {
        public List<CapTheSinhVienItem> LayDanhSachSinhVienChoCapThe(bool chiLayChuaCap)
        {
            using (var db = new SunriseDataContext())
            {
                var query = db.SinhVienChoCapThes.AsQueryable();
                if (chiLayChuaCap)
                {
                    query = query.Where(x => !x.da_cap_the);
                }

                return query
                    .OrderBy(x => x.da_cap_the)
                    .ThenBy(x => x.mssv)
                    .ToList()
                    .Select(x => new CapTheSinhVienItem
                    {
                        MaSinhVienCho = x.ma_sinh_vien_cho,
                        MSSV = x.mssv,
                        HoTen = x.ho_ten,
                        Khoa = x.khoa,
                        Lop = x.lop,
                        NgaySinh = x.ngay_sinh,
                        Email = x.email,
                        SoDienThoai = x.so_dien_thoai,
                        TrangThai = x.da_cap_the ? "Đã cấp thẻ" : (x.trang_thai_dong_bo == "DaNhan" ? "Đã nhận" : "Chưa nhận"),
                        DaCapThe = x.da_cap_the
                    })
                    .ToList();
            }
        }

        public void NapDuLieuTuPhongDaoTao()
        {
            using (var db = new SunriseDataContext())
            {
                var ds = db.SinhVienChoCapThes.Where(x => x.trang_thai_dong_bo != "DaNhan").ToList();
                foreach (var item in ds)
                {
                    item.trang_thai_dong_bo = "DaNhan";
                    item.ngay_cap_nhat = DateTime.Now;
                }
                db.SubmitChanges();
            }
        }

        public string TaoTenDangNhap(string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv))
            {
                mssv = "user";
            }

            using (var db = new SunriseDataContext())
            {
                var baseUser = mssv.Trim().ToLower();
                var username = baseUser;
                var index = 1;
                while (db.TaiKhoans.Any(x => x.ten_dang_nhap == username))
                {
                    username = baseUser + index;
                    index++;
                }
                return username;
            }
        }

        public string TaoMaTheMoi()
        {
            using (var db = new SunriseDataContext())
            {
                var currentMax = db.BanDocs
                    .Where(x => x.ma_the.StartsWith("THE"))
                    .Select(x => x.ma_the)
                    .ToList()
                    .Select(x =>
                    {
                        int number;
                        return int.TryParse(x.Replace("THE", string.Empty), out number) ? number : 0;
                    })
                    .DefaultIfEmpty(0)
                    .Max();

                return "THE" + (currentMax + 1).ToString("000");
            }
        }

        public string CapTheChoSinhVien(int maSinhVienCho, string loaiThe, DateTime ngayKichHoat)
        {
            using (var db = new SunriseDataContext())
            {
                var sinhVien = db.SinhVienChoCapThes.SingleOrDefault(x => x.ma_sinh_vien_cho == maSinhVienCho);
                if (sinhVien == null)
                {
                    throw new InvalidOperationException("Không tìm thấy sinh viên cần cấp thẻ.");
                }

                if (sinhVien.da_cap_the)
                {
                    throw new InvalidOperationException("Sinh viên này đã được cấp thẻ.");
                }

                if (string.IsNullOrWhiteSpace(loaiThe))
                {
                    throw new InvalidOperationException("Vui lòng chọn loại thẻ.");
                }

                var vaiTroBanDoc = db.VaiTros.SingleOrDefault(x => x.ten_vai_tro == "BanDoc");
                if (vaiTroBanDoc == null)
                {
                    throw new InvalidOperationException("Thiếu dữ liệu vai trò bạn đọc trong CSDL.");
                }

                var username = TaoTenDangNhapNoiBo(db, sinhVien.mssv);
                var maTheMoi = TaoMaTheMoiNoiBo(db);
                var email = string.IsNullOrWhiteSpace(sinhVien.email)
                    ? username + "@sunrise.local"
                    : sinhVien.email.Trim();
                if (db.TaiKhoans.Any(x => x.email == email))
                {
                    email = username + "." + DateTime.Now.ToString("HHmmss") + "@sunrise.local";
                }

                var taiKhoan = new TaiKhoan
                {
                    ma_vai_tro = vaiTroBanDoc.ma_vai_tro,
                    ten_dang_nhap = username,
                    mat_khau = "123",
                    email = email,
                    trang_thai = "HoatDong",
                    ngay_tao = DateTime.Now
                };
                db.TaiKhoans.InsertOnSubmit(taiKhoan);
                db.SubmitChanges();

                var banDoc = new BanDoc
                {
                    ma_tai_khoan = taiKhoan.ma_tai_khoan,
                    ma_the = maTheMoi,
                    ho_ten = sinhVien.ho_ten,
                    ngay_sinh = sinhVien.ngay_sinh,
                    gioi_tinh = null,
                    so_dien_thoai = sinhVien.so_dien_thoai,
                    dia_chi = null,
                    loai_ban_doc = loaiThe,
                    ngay_cap_the = ngayKichHoat.Date,
                    ngay_het_han = ngayKichHoat.Date.AddYears(1),
                    trang_thai_the = "HoatDong",
                    mssv = sinhVien.mssv,
                    khoa = sinhVien.khoa,
                    lop = sinhVien.lop
                };
                db.BanDocs.InsertOnSubmit(banDoc);

                sinhVien.da_cap_the = true;
                sinhVien.trang_thai_dong_bo = "DaNhan";
                sinhVien.ngay_cap_nhat = DateTime.Now;

                db.SubmitChanges();
                return maTheMoi;
            }
        }

        private string TaoTenDangNhapNoiBo(SunriseDataContext db, string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv))
            {
                mssv = "user";
            }

            var baseUser = mssv.Trim().ToLower();
            var username = baseUser;
            var index = 1;
            while (db.TaiKhoans.Any(x => x.ten_dang_nhap == username))
            {
                username = baseUser + index;
                index++;
            }
            return username;
        }

        private string TaoMaTheMoiNoiBo(SunriseDataContext db)
        {
            var currentMax = db.BanDocs
                .Where(x => x.ma_the.StartsWith("THE"))
                .Select(x => x.ma_the)
                .ToList()
                .Select(x =>
                {
                    int number;
                    return int.TryParse(x.Replace("THE", string.Empty), out number) ? number : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            return "THE" + (currentMax + 1).ToString("000");
        }
    }
}
