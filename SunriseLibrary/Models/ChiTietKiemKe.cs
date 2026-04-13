using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.chi_tiet_kiem_ke")]
    public class ChiTietKiemKe
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_chi_tiet { get; set; }

        [Column]
        public int ma_dot_kiem_ke { get; set; }

        [Column]
        public int ma_ban_sao { get; set; }

        [Column(CanBeNull = true)]
        public string tt_he_thong { get; set; }

        [Column(CanBeNull = true)]
        public string thuc_te { get; set; }

        [Column(CanBeNull = true)]
        public string chenh_lech { get; set; }

        [Column(CanBeNull = true)]
        public string xu_ly { get; set; }
    }
}
