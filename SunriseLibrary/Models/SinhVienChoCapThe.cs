using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.sinh_vien_cho_cap_the")]
    public class SinhVienChoCapThe
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_sinh_vien_cho { get; set; }

        [Column]
        public string mssv { get; set; }

        [Column]
        public string ho_ten { get; set; }

        [Column(CanBeNull = true)]
        public string khoa { get; set; }

        [Column(CanBeNull = true)]
        public string lop { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_sinh { get; set; }

        [Column(CanBeNull = true)]
        public string email { get; set; }

        [Column(CanBeNull = true)]
        public string so_dien_thoai { get; set; }

        [Column]
        public string trang_thai_dong_bo { get; set; }

        [Column]
        public bool da_cap_the { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_tao { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_cap_nhat { get; set; }
    }
}
