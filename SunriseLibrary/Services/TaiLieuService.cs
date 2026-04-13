using System;
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
                // B1: lấy dữ liệu đơn giản từ DB để tránh lỗi LINQ to SQL không translate được
                var dsTaiLieu = (
                    from tl in db.TaiLieus
                    join pl in db.PhanLoaiTaiLieus on tl.ma_phan_loai equals pl.ma_phan_loai
                    where tl.hien_thi_tra_cuu
                    select new
                    {
                        tl.ma_tai_lieu,
                        tl.ma_doc,
                        tl.ten_tai_lieu,
                        tl.tac_gia,
                        tl.nha_xuat_ban,
                        tl.the_loai,
                        tl.duong_dan_file,
                        TenPhanLoai = pl.ten_phan_loai,
                        TuKhoa = pl.tu_khoa
                    }
                ).ToList();

                var dsBanSao = db.BanSaoTaiLieus
                    .Select(bs => new
                    {
                        bs.ma_tai_lieu,
                        bs.vi_tri_kho,
                        bs.trang_thai
                    })
                    .ToList();

                // B2: lọc từ khóa ở bộ nhớ cho an toàn
                if (!string.IsNullOrWhiteSpace(tenSach))
                {
                    var kw = tenSach.Trim().ToLower();
                    dsTaiLieu = dsTaiLieu
                        .Where(x => (x.ten_tai_lieu ?? string.Empty).ToLower().Contains(kw))
                        .ToList();
                }

                if (!string.IsNullOrWhiteSpace(tacGia))
                {
                    var kw = tacGia.Trim().ToLower();
                    dsTaiLieu = dsTaiLieu
                        .Where(x => (x.tac_gia ?? string.Empty).ToLower().Contains(kw))
                        .ToList();
                }

                if (!string.IsNullOrWhiteSpace(maTaiLieu))
                {
                    var kw = maTaiLieu.Trim().ToLower();
                    dsTaiLieu = dsTaiLieu
                        .Where(x => (x.ma_doc ?? string.Empty).ToLower().Contains(kw))
                        .ToList();
                }

                if (!string.IsNullOrWhiteSpace(chuDe))
                {
                    var kw = chuDe.Trim().ToLower();
                    dsTaiLieu = dsTaiLieu
                        .Where(x =>
                            (x.the_loai ?? string.Empty).ToLower().Contains(kw) ||
                            (x.TenPhanLoai ?? string.Empty).ToLower().Contains(kw) ||
                            (x.TuKhoa ?? string.Empty).ToLower().Contains(kw))
                        .ToList();
                }

                // B3: ghép trạng thái/kho ở bộ nhớ
                var ketQua = dsTaiLieu
                    .Select(t =>
                    {
                        var cacBanSao = dsBanSao.Where(bs => bs.ma_tai_lieu == t.ma_tai_lieu).ToList();
                        var tinhTrang = "ChuaCoBanSao";

                        if (cacBanSao.Any())
                        {
                            if (cacBanSao.Any(x => string.Equals(x.trang_thai, "Con", StringComparison.OrdinalIgnoreCase)))
                                tinhTrang = "Con";
                            else
                                tinhTrang = cacBanSao.First().trang_thai;
                        }

                        return new TaiLieuSearchItem
                        {
                            MaTaiLieu = t.ma_tai_lieu,
                            MaDoc = t.ma_doc,
                            NhanDe = t.ten_tai_lieu,
                            TacGia = t.tac_gia,
                            NhaXuatBan = t.nha_xuat_ban,
                            TheLoai = !string.IsNullOrWhiteSpace(t.the_loai) ? t.the_loai : t.TenPhanLoai,
                            TinhTrang = tinhTrang,
                            Kho = string.Join(", ", cacBanSao
                                .Select(x => x.vi_tri_kho)
                                .Where(x => !string.IsNullOrWhiteSpace(x))
                                .Distinct()),
                            DuongDanFile = t.duong_dan_file
                        };
                    })
                    .OrderBy(x => x.NhanDe)
                    .ToList();

                return ketQua;
            }
        }
    }
}
