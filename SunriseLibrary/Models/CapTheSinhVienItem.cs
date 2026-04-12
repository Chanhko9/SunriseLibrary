using System;

namespace SunriseLibrary.Models
{
    public class CapTheSinhVienItem
    {
        public int MaSinhVienCho { get; set; }
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Khoa { get; set; }
        public string Lop { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string TrangThai { get; set; }
        public bool DaCapThe { get; set; }
    }
}
