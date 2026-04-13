using System;
using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class BanDocService
    {
        public List<BanDocListItem> TimBanDoc(string tuKhoa)
        {
            using (var db = new SunriseDataContext())
            {
                var query = from bd in db.BanDocs
                            join tk in db.TaiKhoans on bd.ma_tai_khoan equals tk.ma_tai_khoan
                            select new { bd, tk };

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    var lower = tuKhoa.Trim().ToLower();
                    query = query.Where(x =>
                        x.bd.ma_the.ToLower().Contains(lower) ||
                        x.bd.ho_ten.ToLower().Contains(lower) ||
                        (x.bd.mssv ?? "").ToLower().Contains(lower) ||
                        (x.tk.email ?? "").ToLower().Contains(lower));
                }

                return query
                    .OrderBy(x => x.bd.ho_ten)
                    .ToList()
                    .Select(x => new BanDocListItem
                    {
                        MaBanDoc = x.bd.ma_ban_doc,
                        MaThe = x.bd.ma_the,
                        HoTen = x.bd.ho_ten,
                        TrangThai = ChuyenTrangThaiThe(x.bd.trang_thai_the)
                    })
                    .ToList();
            }
        }

        public BanDocChiTiet LayChiTietBanDoc(int maBanDoc)
        {
            using (var db = new SunriseDataContext())
            {
                var item = (from bd in db.BanDocs
                            join tk in db.TaiKhoans on bd.ma_tai_khoan equals tk.ma_tai_khoan
                            where bd.ma_ban_doc == maBanDoc
                            select new BanDocChiTiet
                            {
                                MaBanDoc = bd.ma_ban_doc,
                                MaTaiKhoan = bd.ma_tai_khoan,
                                MaThe = bd.ma_the,
                                HoTen = bd.ho_ten,
                                NgaySinh = bd.ngay_sinh,
                                GioiTinh = bd.gioi_tinh,
                                DiaChi = bd.dia_chi,
                                Email = tk.email,
                                SoDienThoai = bd.so_dien_thoai,
                                NgayHetHanThe = bd.ngay_het_han,
                                TrangThaiThe = bd.trang_thai_the,
                                LoaiBanDoc = bd.loai_ban_doc
                            }).SingleOrDefault();

                if (item == null)
                {
                    throw new InvalidOperationException("Không tìm thấy hồ sơ bạn đọc.");
                }

                return item;
            }
        }

        public List<LichSuGiaoDichItem> LayLichSuGiaoDich(int maBanDoc)
        {
            using (var db = new SunriseDataContext())
            {
                return (from p in db.PhieuMuonTras
                        join bs in db.BanSaoTaiLieus on p.ma_ban_sao equals bs.ma_ban_sao
                        join tl in db.TaiLieus on bs.ma_tai_lieu equals tl.ma_tai_lieu
                        where p.ma_ban_doc == maBanDoc
                        orderby p.ngay_muon descending
                        select new LichSuGiaoDichItem
                        {
                            Ngay = p.ngay_tra ?? p.ngay_muon,
                            LoaiGiaoDich = p.ngay_tra.HasValue ? "Trả" : "Mượn",
                            TaiLieu = tl.ten_tai_lieu,
                            GhiChu = p.ghi_chu
                        }).ToList();
            }
        }

        public int ThemMoiBanDoc(BanDocChiTiet model)
        {
            using (var db = new SunriseDataContext())
            {
                if (string.IsNullOrWhiteSpace(model.MaThe))
                {
                    throw new InvalidOperationException("Mã thẻ không được để trống.");
                }

                if (string.IsNullOrWhiteSpace(model.HoTen))
                {
                    throw new InvalidOperationException("Họ tên không được để trống.");
                }

                if (db.BanDocs.Any(x => x.ma_the == model.MaThe.Trim()))
                {
                    throw new InvalidOperationException("Mã thẻ đã tồn tại.");
                }

                var vaiTroBanDoc = db.VaiTros.SingleOrDefault(x => x.ten_vai_tro == "BanDoc");
                if (vaiTroBanDoc == null)
                {
                    throw new InvalidOperationException("Thiếu vai trò bạn đọc trong CSDL.");
                }

                var username = model.MaThe.Trim().ToLower();
                var suffix = 1;
                while (db.TaiKhoans.Any(x => x.ten_dang_nhap == username))
                {
                    username = model.MaThe.Trim().ToLower() + suffix;
                    suffix++;
                }

                var email = string.IsNullOrWhiteSpace(model.Email)
                    ? username + "@sunrise.local"
                    : model.Email.Trim();

                if (db.TaiKhoans.Any(x => x.email == email))
                {
                    email = username + "." + DateTime.Now.ToString("HHmmss") + "@sunrise.local";
                }

                var tk = new TaiKhoan
                {
                    ma_vai_tro = vaiTroBanDoc.ma_vai_tro,
                    ten_dang_nhap = username,
                    mat_khau = "123",
                    email = email,
                    trang_thai = "HoatDong",
                    ngay_tao = DateTime.Now
                };
                db.TaiKhoans.InsertOnSubmit(tk);
                db.SubmitChanges();

                var bd = new BanDoc
                {
                    ma_tai_khoan = tk.ma_tai_khoan,
                    ma_the = model.MaThe.Trim(),
                    ho_ten = model.HoTen.Trim(),
                    ngay_sinh = model.NgaySinh,
                    gioi_tinh = model.GioiTinh,
                    so_dien_thoai = model.SoDienThoai,
                    dia_chi = model.DiaChi,
                    loai_ban_doc = string.IsNullOrWhiteSpace(model.LoaiBanDoc) ? "SinhVien" : model.LoaiBanDoc,
                    ngay_cap_the = DateTime.Today,
                    ngay_het_han = model.NgayHetHanThe ?? DateTime.Today.AddYears(1),
                    trang_thai_the = string.IsNullOrWhiteSpace(model.TrangThaiThe) ? "HoatDong" : model.TrangThaiThe,
                    mssv = null,
                    khoa = null,
                    lop = null
                };
                db.BanDocs.InsertOnSubmit(bd);
                db.SubmitChanges();
                return bd.ma_ban_doc;
            }
        }

        public void CapNhatBanDoc(BanDocChiTiet model)
        {
            using (var db = new SunriseDataContext())
            {
                var bd = db.BanDocs.SingleOrDefault(x => x.ma_ban_doc == model.MaBanDoc);
                if (bd == null)
                {
                    throw new InvalidOperationException("Không tìm thấy bạn đọc cần cập nhật.");
                }

                var tk = db.TaiKhoans.Single(x => x.ma_tai_khoan == bd.ma_tai_khoan);

                bd.ho_ten = model.HoTen?.Trim();
                bd.ngay_sinh = model.NgaySinh;
                bd.gioi_tinh = model.GioiTinh;
                bd.dia_chi = model.DiaChi;
                bd.so_dien_thoai = model.SoDienThoai;
                bd.ngay_het_han = model.NgayHetHanThe;
                if (!string.IsNullOrWhiteSpace(model.TrangThaiThe))
                {
                    bd.trang_thai_the = model.TrangThaiThe;
                }

                if (!string.IsNullOrWhiteSpace(model.Email))
                {
                    var email = model.Email.Trim();
                    if (db.TaiKhoans.Any(x => x.email == email && x.ma_tai_khoan != tk.ma_tai_khoan))
                    {
                        throw new InvalidOperationException("Email đã được tài khoản khác sử dụng.");
                    }
                    tk.email = email;
                }

                db.SubmitChanges();
            }
        }

        public string KhoaHoacMoThe(int maBanDoc)
        {
            using (var db = new SunriseDataContext())
            {
                var bd = db.BanDocs.SingleOrDefault(x => x.ma_ban_doc == maBanDoc);
                if (bd == null)
                {
                    throw new InvalidOperationException("Không tìm thấy bạn đọc.");
                }

                var dangMuon = db.PhieuMuonTras.Any(x => x.ma_ban_doc == maBanDoc && x.trang_thai_phieu == "DangMuon");
                if (dangMuon && bd.trang_thai_the == "HoatDong")
                {
                    throw new InvalidOperationException("Bạn đọc còn sách chưa trả, không thể khóa thẻ.");
                }

                bd.trang_thai_the = bd.trang_thai_the == "TamKhoa" ? "HoatDong" : "TamKhoa";
                db.SubmitChanges();
                return bd.trang_thai_the == "TamKhoa" ? "Đã khóa thẻ." : "Đã mở lại thẻ.";
            }
        }

        private string ChuyenTrangThaiThe(string trangThai)
        {
            switch (trangThai)
            {
                case "HoatDong": return "Hoạt động";
                case "TamKhoa": return "Tạm khóa";
                case "HetHan": return "Hết hạn";
                default: return trangThai;
            }
        }
    }
}
