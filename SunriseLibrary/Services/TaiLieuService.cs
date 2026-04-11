using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class TaiLieuService
    {
        public List<TaiLieuSearchItem> TimKiem(string tenSach, string tacGia, string chuDe, string maTaiLieu)
        {
            using (var db = new SunriseDataContext())
            {
                var raw = (from tl in db.TaiLieus
                           join pl in db.PhanLoaiTaiLieus on tl.ma_phan_loai equals pl.ma_phan_loai
                           join bs in db.BanSaoTaiLieus on tl.ma_tai_lieu equals bs.ma_tai_lieu into gbs
                           from bs in gbs.DefaultIfEmpty()
                           select new
                           {
                               tl.ma_tai_lieu,
                               tl.ma_doc,
                               tl.ten_tai_lieu,
                               tl.tac_gia,
                               tl.nha_xuat_ban,
                               TheLoai = pl.ten_phan_loai,
                               TuKhoa = pl.tu_khoa,
                               ViTriKho = bs != null ? bs.vi_tri_kho : "",
                               TinhTrang = bs != null ? bs.trang_thai : "ChuaCoBanSao",
                               tl.duong_dan_file
                           }).ToList();

                if (!string.IsNullOrWhiteSpace(tenSach))
                    raw = raw.Where(x => (x.ten_tai_lieu ?? "").ToLower().Contains(tenSach.ToLower())).ToList();

                if (!string.IsNullOrWhiteSpace(tacGia))
                    raw = raw.Where(x => (x.tac_gia ?? "").ToLower().Contains(tacGia.ToLower())).ToList();

                if (!string.IsNullOrWhiteSpace(maTaiLieu))
                    raw = raw.Where(x => (x.ma_doc ?? "").ToLower().Contains(maTaiLieu.ToLower())).ToList();

                if (!string.IsNullOrWhiteSpace(chuDe))
                    raw = raw.Where(x =>
                        (x.TheLoai ?? "").ToLower().Contains(chuDe.ToLower()) ||
                        (x.TuKhoa ?? "").ToLower().Contains(chuDe.ToLower()))
                        .ToList();

                var ketQua = raw
                    .GroupBy(x => new
                    {
                        x.ma_tai_lieu,
                        x.ma_doc,
                        x.ten_tai_lieu,
                        x.tac_gia,
                        x.nha_xuat_ban,
                        x.TheLoai,
                        x.duong_dan_file
                    })
                    .Select(g => new TaiLieuSearchItem
                    {
                        MaTaiLieu = g.Key.ma_tai_lieu,
                        MaDoc = g.Key.ma_doc,
                        NhanDe = g.Key.ten_tai_lieu,
                        TacGia = g.Key.tac_gia,
                        NhaXuatBan = g.Key.nha_xuat_ban,
                        TheLoai = g.Key.TheLoai,
                        TinhTrang = g.Any(x => x.TinhTrang == "Con") ? "Con" : g.FirstOrDefault()?.TinhTrang,
                        Kho = string.Join(", ", g.Where(x => !string.IsNullOrWhiteSpace(x.ViTriKho)).Select(x => x.ViTriKho).Distinct()),
                        DuongDanFile = g.Key.duong_dan_file
                    })
                    .OrderBy(x => x.NhanDe)
                    .ToList();

                return ketQua;
            }
        }
    }
}
