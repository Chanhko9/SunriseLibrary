using System;
using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.phieu_muon_tra")]
    public class PhieuMuonTra
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_phieu { get; set; }

        [Column]
        public int ma_ban_doc { get; set; }

        [Column]
        public int ma_ban_sao { get; set; }

        [Column]
        public DateTime ngay_muon { get; set; }

        [Column]
        public DateTime han_tra { get; set; }

        [Column(CanBeNull = true)]
        public DateTime? ngay_tra { get; set; }

        [Column]
        public string trang_thai_phieu { get; set; }

        [Column]
        public decimal tien_phat { get; set; }

        [Column(CanBeNull = true)]
        public string ghi_chu { get; set; }
    }
}
