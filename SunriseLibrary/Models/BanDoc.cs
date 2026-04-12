using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.ban_doc")]
    public class BanDoc
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_ban_doc { get; set; }

        [Column]
        public int ma_tai_khoan { get; set; }

        [Column]
        public string ma_the { get; set; }

        [Column]
        public string ho_ten { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_sinh { get; set; }

        [Column(CanBeNull = true)]
        public string gioi_tinh { get; set; }

        [Column(CanBeNull = true)]
        public string so_dien_thoai { get; set; }

        [Column(CanBeNull = true)]
        public string dia_chi { get; set; }

        [Column]
        public string loai_ban_doc { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_cap_the { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_het_han { get; set; }

        [Column]
        public string trang_thai_the { get; set; }

        [Column(CanBeNull = true)]
        public string mssv { get; set; }

        [Column(CanBeNull = true)]
        public string khoa { get; set; }

        [Column(CanBeNull = true)]
        public string lop { get; set; }
    }
}
