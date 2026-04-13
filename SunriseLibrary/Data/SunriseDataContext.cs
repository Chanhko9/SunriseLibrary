using System.Configuration;
using System.Data.Linq;
using SunriseLibrary.Models;

namespace SunriseLibrary.Data
{
    public class SunriseDataContext : DataContext
    {
        public SunriseDataContext() : base(ConnectionString)
        {
        }

        public static string ConnectionString => ConfigurationManager.ConnectionStrings["SunriseConnection"].ConnectionString;

        public Table<VaiTro> VaiTros => GetTable<VaiTro>();
        public Table<TaiKhoan> TaiKhoans => GetTable<TaiKhoan>();
        public Table<BanDoc> BanDocs => GetTable<BanDoc>();
        public Table<SinhVienChoCapThe> SinhVienChoCapThes => GetTable<SinhVienChoCapThe>();
        public Table<PhanLoaiTaiLieu> PhanLoaiTaiLieus => GetTable<PhanLoaiTaiLieu>();
        public Table<TaiLieu> TaiLieus => GetTable<TaiLieu>();
        public Table<BanSaoTaiLieu> BanSaoTaiLieus => GetTable<BanSaoTaiLieu>();
        public Table<PhieuMuonTra> PhieuMuonTras => GetTable<PhieuMuonTra>();
        public Table<PhanQuyenTaiKhoan> PhanQuyenTaiKhoans => GetTable<PhanQuyenTaiKhoan>();
        public Table<DotKiemKe> DotKiemKes => GetTable<DotKiemKe>();
        public Table<ChiTietKiemKe> ChiTietKiemKes => GetTable<ChiTietKiemKe>();
    }
}
