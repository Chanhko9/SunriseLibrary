using System;

namespace SunriseLibrary.Models
{
    public class BanDocChiTiet
    {
        public int MaBanDoc { get; set; }
        public int MaTaiKhoan { get; set; }
        public string MaThe { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgayHetHanThe { get; set; }
        public string TrangThaiThe { get; set; }
        public string LoaiBanDoc { get; set; }
    }
}
