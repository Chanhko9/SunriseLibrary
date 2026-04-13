using System;
using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class BaoCaoThongKeService
    {
        public List<BaoCaoTopItem> LayTopSachMuonNhieuNhat(DateTime tuNgay, DateTime denNgay)
        {
            using (var db = new SunriseDataContext())
            {
                return (from p in db.PhieuMuonTras
                        join bs in db.BanSaoTaiLieus on p.ma_ban_sao equals bs.ma_ban_sao
                        join tl in db.TaiLieus on bs.ma_tai_lieu equals tl.ma_tai_lieu
                        where p.ngay_muon >= tuNgay.Date && p.ngay_muon < denNgay.Date.AddDays(1)
                        group p by tl.ten_tai_lieu into g
                        orderby g.Count() descending, g.Key
                        select new BaoCaoTopItem
                        {
                            Nhan = g.Key,
                            SoLuong = g.Count()
                        }).Take(5).ToList();
            }
        }

        public List<BaoCaoTopItem> LayTopBanDocMuonNhieuNhat(DateTime tuNgay, DateTime denNgay)
        {
            using (var db = new SunriseDataContext())
            {
                return (from p in db.PhieuMuonTras
                        join bd in db.BanDocs on p.ma_ban_doc equals bd.ma_ban_doc
                        where p.ngay_muon >= tuNgay.Date && p.ngay_muon < denNgay.Date.AddDays(1)
                        group p by bd.ho_ten into g
                        orderby g.Count() descending, g.Key
                        select new BaoCaoTopItem
                        {
                            Nhan = g.Key,
                            SoLuong = g.Count()
                        }).Take(5).ToList();
            }
        }
    }
}
