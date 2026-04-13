using System;
using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class KiemKeKhoService
    {
        public DotKiemKe TaoDot(string maDot, string kho, DateTime ngayBatDau, string nguoiPhuTrach)
        {
            using (var db = new SunriseDataContext())
            {
                var dot = new DotKiemKe
                {
                    ma_dot = maDot,
                    kho = kho,
                    ngay_bat_dau = ngayBatDau,
                    nguoi_phu_trach = nguoiPhuTrach,
                    trang_thai = "DangMo"
                };
                db.DotKiemKes.InsertOnSubmit(dot);
                db.SubmitChanges();

                var banSaoList = db.BanSaoTaiLieus
                    .Where(x => string.IsNullOrWhiteSpace(kho) || x.vi_tri_kho.Contains(kho))
                    .ToList();

                foreach (var bs in banSaoList)
                {
                    db.ChiTietKiemKes.InsertOnSubmit(new ChiTietKiemKe
                    {
                        ma_dot_kiem_ke = dot.ma_dot_kiem_ke,
                        ma_ban_sao = bs.ma_ban_sao,
                        tt_he_thong = bs.trang_thai,
                        thuc_te = null,
                        chenh_lech = null,
                        xu_ly = null
                    });
                }

                db.SubmitChanges();
                return dot;
            }
        }

        public List<KiemKeDoiSoatItem> LayChiTietDot(int maDotKiemKe)
        {
            using (var db = new SunriseDataContext())
            {
                return (from ct in db.ChiTietKiemKes
                        join bs in db.BanSaoTaiLieus on ct.ma_ban_sao equals bs.ma_ban_sao
                        where ct.ma_dot_kiem_ke == maDotKiemKe
                        orderby bs.ma_vach
                        select new KiemKeDoiSoatItem
                        {
                            MaBanSao = bs.ma_ban_sao,
                            MaSach = bs.ma_vach,
                            TTHeThong = ct.tt_he_thong,
                            ThucTe = ct.thuc_te,
                            ChenhLech = ct.chenh_lech,
                            XuLy = ct.xu_ly
                        }).ToList();
            }
        }

        public void LuuKetQua(int maDotKiemKe, List<KiemKeDoiSoatItem> items)
        {
            using (var db = new SunriseDataContext())
            {
                foreach (var item in items)
                {
                    var ct = db.ChiTietKiemKes.First(x => x.ma_dot_kiem_ke == maDotKiemKe && x.ma_ban_sao == item.MaBanSao);
                    ct.thuc_te = item.ThucTe;
                    ct.chenh_lech = item.ChenhLech;
                    ct.xu_ly = item.XuLy;
                }
                db.SubmitChanges();
            }
        }

        public void KetThucDot(int maDotKiemKe)
        {
            using (var db = new SunriseDataContext())
            {
                var dot = db.DotKiemKes.First(x => x.ma_dot_kiem_ke == maDotKiemKe);
                dot.trang_thai = "DaDong";
                dot.ngay_ket_thuc = DateTime.Now;
                db.SubmitChanges();
            }
        }
    }
}
