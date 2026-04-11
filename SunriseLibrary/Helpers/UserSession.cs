namespace SunriseLibrary.Helpers
{
    public static class UserSession
    {
        public static int MaTaiKhoan { get; set; }
        public static string TenDangNhap { get; set; }
        public static string TenVaiTro { get; set; }
        public static bool DaDangNhap { get; set; }

        public static void Clear()
        {
            MaTaiKhoan = 0;
            TenDangNhap = string.Empty;
            TenVaiTro = string.Empty;
            DaDangNhap = false;
        }
    }
}
