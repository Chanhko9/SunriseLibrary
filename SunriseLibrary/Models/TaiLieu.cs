using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.tai_lieu")]
    public class TaiLieu
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_tai_lieu { get; set; }

        [Column]
        public int ma_phan_loai { get; set; }

        [Column]
        public string ma_doc { get; set; }

        [Column]
        public string ten_tai_lieu { get; set; }

        [Column]
        public string tac_gia { get; set; }

        [Column(CanBeNull = true)]
        public string nha_xuat_ban { get; set; }

        [Column(CanBeNull = true)]
        public int? nam_xuat_ban { get; set; }

        [Column]
        public string loai_tai_lieu { get; set; }

        [Column(CanBeNull = true)]
        public string the_loai { get; set; }

        [Column(CanBeNull = true)]
        public string dinh_dang { get; set; }

        [Column(CanBeNull = true)]
        public string mo_ta { get; set; }

        [Column(CanBeNull = true)]
        public string duong_dan_file { get; set; }

        [Column]
        public string quyen_truy_cap { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_nhap { get; set; }

        [Column]
        public bool hien_thi_tra_cuu { get; set; }
    }
}
