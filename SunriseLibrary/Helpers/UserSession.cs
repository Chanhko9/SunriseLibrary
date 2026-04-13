namespace SunriseLibrary.Helpers
{
    public static class UserSession
    {
        public static int MaTaiKhoan { get; set; }
        public static string TenDangNhap { get; set; }
        public static string TenVaiTro { get; set; }
        public static bool DaDangNhap { get; set; }

        public static bool XemDuLieu { get; set; }
        public static bool ThemSuaXoa { get; set; }
        public static bool QuanLyTaiKhoan { get; set; }
        public static bool XemBaoCao { get; set; }

        public static void Clear()
        {
            MaTaiKhoan = 0;
            TenDangNhap = string.Empty;
            TenVaiTro = string.Empty;
            DaDangNhap = false;
            XemDuLieu = false;
            ThemSuaXoa = false;
            QuanLyTaiKhoan = false;
            XemBaoCao = false;
        }
    }
}
