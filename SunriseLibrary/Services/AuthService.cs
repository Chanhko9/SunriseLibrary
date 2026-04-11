using System;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Helpers;

namespace SunriseLibrary.Services
{
    public class AuthService
    {
        public bool DangNhap(string tenDangNhap, string matKhau, string tenVaiTro)
        {
            using (var db = new SunriseDataContext())
            {
                var taiKhoan = (from tk in db.TaiKhoans
                                join vt in db.VaiTros on tk.ma_vai_tro equals vt.ma_vai_tro
                                where tk.ten_dang_nhap == tenDangNhap
                                      && tk.mat_khau == matKhau
                                      && tk.trang_thai == "HoatDong"
                                      && vt.ten_vai_tro == tenVaiTro
                                select new
                                {
                                    tk.ma_tai_khoan,
                                    tk.ten_dang_nhap,
                                    TenVaiTro = vt.ten_vai_tro
                                }).FirstOrDefault();

                if (taiKhoan == null)
                    return false;

                if (tenVaiTro == "BanDoc")
                {
                    var banDoc = db.BanDocs.FirstOrDefault(x =>
                        x.ma_tai_khoan == taiKhoan.ma_tai_khoan &&
                        x.trang_thai_the == "HoatDong");

                    if (banDoc == null)
                        return false;
                }

                var taiKhoanCapNhat = db.TaiKhoans.FirstOrDefault(x => x.ma_tai_khoan == taiKhoan.ma_tai_khoan);
                if (taiKhoanCapNhat != null)
                {
                    taiKhoanCapNhat.lan_dang_nhap_cuoi = DateTime.Now;
                    db.SubmitChanges();
                }

                UserSession.MaTaiKhoan = taiKhoan.ma_tai_khoan;
                UserSession.TenDangNhap = taiKhoan.ten_dang_nhap;
                UserSession.TenVaiTro = taiKhoan.TenVaiTro;
                UserSession.DaDangNhap = true;

                return true;
            }
        }
    }
}
