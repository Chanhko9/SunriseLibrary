using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class QuanTriHeThongService
    {
        public List<TaiKhoanPhanQuyenItem> LayDanhSachTaiKhoan()
        {
            using (var db = new SunriseDataContext())
            {
                var raw = (from tk in db.TaiKhoans
                           join vt in db.VaiTros on tk.ma_vai_tro equals vt.ma_vai_tro
                           join pq in db.PhanQuyenTaiKhoans on tk.ma_tai_khoan equals pq.ma_tai_khoan into gpq
                           from pq in gpq.DefaultIfEmpty()
                           join bd in db.BanDocs on tk.ma_tai_khoan equals bd.ma_tai_khoan into gbd
                           from bd in gbd.DefaultIfEmpty()
                           orderby tk.ten_dang_nhap
                           select new
                           {
                               tk.ma_tai_khoan,
                               tk.ten_dang_nhap,
                               tk.trang_thai,
                               TenVaiTro = vt.ten_vai_tro,
                               HoTen = bd != null ? bd.ho_ten : null,
                               XemDuLieu = pq != null ? (bool?)pq.xem_du_lieu : null,
                               ThemSuaXoa = pq != null ? (bool?)pq.them_sua_xoa : null,
                               QuanLyTaiKhoan = pq != null ? (bool?)pq.quan_ly_tai_khoan : null,
                               XemBaoCao = pq != null ? (bool?)pq.xem_bao_cao : null
                           }).ToList();

                return raw.Select(x => new TaiKhoanPhanQuyenItem
                {
                    MaTaiKhoan = x.ma_tai_khoan,
                    User = x.ten_dang_nhap,
                    HoTen = !string.IsNullOrWhiteSpace(x.HoTen) ? x.HoTen : x.TenVaiTro == "NhanVien" ? "Nhân viên thư viện" : "Quản trị hệ thống",
                    VaiTro = x.TenVaiTro,
                    TrangThai = x.trang_thai,
                    XemDuLieu = x.XemDuLieu ?? false,
                    ThemSuaXoa = x.ThemSuaXoa ?? false,
                    QuanLyTaiKhoan = x.QuanLyTaiKhoan ?? false,
                    XemBaoCao = x.XemBaoCao ?? false
                }).ToList();
            }
        }

        public void LuuTaiKhoanVaPhanQuyen(TaiKhoanPhanQuyenItem item)
        {
            using (var db = new SunriseDataContext())
            {
                var tk = db.TaiKhoans.First(x => x.ma_tai_khoan == item.MaTaiKhoan);
                var vt = db.VaiTros.FirstOrDefault(x => x.ten_vai_tro == item.VaiTro);
                if (vt != null)
                    tk.ma_vai_tro = vt.ma_vai_tro;
                tk.trang_thai = item.TrangThai;

                var pq = db.PhanQuyenTaiKhoans.FirstOrDefault(x => x.ma_tai_khoan == item.MaTaiKhoan);
                if (pq == null)
                {
                    pq = new PhanQuyenTaiKhoan { ma_tai_khoan = item.MaTaiKhoan };
                    db.PhanQuyenTaiKhoans.InsertOnSubmit(pq);
                }

                pq.xem_du_lieu = item.XemDuLieu;
                pq.them_sua_xoa = item.ThemSuaXoa;
                pq.quan_ly_tai_khoan = item.QuanLyTaiKhoan;
                pq.xem_bao_cao = item.XemBaoCao;

                db.SubmitChanges();
            }
        }
    }
}
