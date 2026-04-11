using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.ban_sao_tai_lieu")]
    public class BanSaoTaiLieu
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_ban_sao { get; set; }

        [Column]
        public int ma_tai_lieu { get; set; }

        [Column]
        public string ma_vach { get; set; }

        [Column]
        public string vi_tri_kho { get; set; }

        [Column]
        public string trang_thai { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_nhap_kho { get; set; }

        [Column(CanBeNull = true)]
        public string ghi_chu { get; set; }
    }
}
