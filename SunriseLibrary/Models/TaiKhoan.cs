using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.tai_khoan")]
    public class TaiKhoan
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_tai_khoan { get; set; }

        [Column]
        public int ma_vai_tro { get; set; }

        [Column]
        public string ten_dang_nhap { get; set; }

        [Column]
        public string mat_khau { get; set; }

        [Column]
        public string email { get; set; }

        [Column]
        public string trang_thai { get; set; }

        [Column]
        public DateTime ngay_tao { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? lan_dang_nhap_cuoi { get; set; }
    }
}
