using System.Data.Linq.Mapping;

namespace SunriseLibrary.Models
{
    [Table(Name = "dbo.phan_quyen_tai_khoan")]
    public class PhanQuyenTaiKhoan
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int ma_phan_quyen { get; set; }

        [Column]
        public int ma_tai_khoan { get; set; }

        [Column]
        public bool xem_du_lieu { get; set; }

        [Column]
        public bool them_sua_xoa { get; set; }

        [Column]
        public bool quan_ly_tai_khoan { get; set; }

        [Column]
        public bool xem_bao_cao { get; set; }
    }
}
