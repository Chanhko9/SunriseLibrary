using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.vai_tro")]
    public class VaiTro
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_vai_tro { get; set; }

        [Column]
        public string ten_vai_tro { get; set; }

        [Column]
        public string mo_ta { get; set; }
    }
}
