using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.dot_kiem_ke")]
    public class DotKiemKe
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_dot_kiem_ke { get; set; }

        [Column]
        public string ma_dot { get; set; }

        [Column(CanBeNull = true)]
        public string kho { get; set; }

        [Column]
        public DateTime ngay_bat_dau { get; set; }

        [Column(CanBeNull = true)]
        public string nguoi_phu_trach { get; set; }

        [Column]
        public string trang_thai { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_ket_thuc { get; set; }
    }
}
