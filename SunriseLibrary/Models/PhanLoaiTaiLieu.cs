using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.phan_loai_tai_lieu")]
    public class PhanLoaiTaiLieu
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_phan_loai { get; set; }

        [Column]
        public string ten_phan_loai { get; set; }

        [Column(CanBeNull = true)]
        public string ky_hieu { get; set; }

        [Column(CanBeNull = true)]
        public string mo_ta { get; set; }

        [Column(CanBeNull = true)]
        public string tu_khoa { get; set; }
    }
}
