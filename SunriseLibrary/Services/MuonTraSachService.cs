using System;
using System.Collections.Generic;
using System.Linq;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Services
{
    public class MuonTraSachService
    {
        private const int GioiHanMuon = 5;
        private const int SoNgayMuonMacDinh = 14;
        private const decimal MucPhatMoiNgay = 1000m;

        public ThongTinBanDocMuonTra KiemTraThe(string maThe)
        {
            using (var db = new SunriseDataContext())
            {
                var item = db.BanDocs.SingleOrDefault(x => x.ma_the == maThe.Trim());
                if (item == null)
                {
                    throw new InvalidOperationException("Không tìm thấy mã thẻ.");
                }

                var soDangMuon = db.PhieuMuonTras.Count(x => x.ma_ban_doc == item.ma_ban_doc && x.trang_thai_phieu == "DangMuon");
                var tinhTrang = item.trang_thai_the;
                if (item.ngay_het_han.HasValue && item.ngay_het_han.Value.Date < DateTime.Today)
                {
                    tinhTrang = "HetHan";
                }

                return new ThongTinBanDocMuonTra
                {
                    MaBanDoc = item.ma_ban_doc,
                    MaThe = item.ma_the,
                    HoTen = item.ho_ten,
                    LopKhoa = string.Format("{0} / {1}", item.lop ?? "-", item.khoa ?? "-"),
                    TinhTrangThe = ChuyenTinhTrangThe(tinhTrang),
                    SoSachDangMuon = soDangMuon
                };
            }
        }

        public List<SachDangMuonItem> LaySachDangMuon(int maBanDoc)
        {
            using (var db = new SunriseDataContext())
            {
                return (from p in db.PhieuMuonTras
                        join bs in db.BanSaoTaiLieus on p.ma_ban_sao equals bs.ma_ban_sao
                        join tl in db.TaiLieus on bs.ma_tai_lieu equals tl.ma_tai_lieu
                        where p.ma_ban_doc == maBanDoc && p.trang_thai_phieu == "DangMuon"
                        orderby p.han_tra
                        select new SachDangMuonItem
                        {
                            MaPhieu = p.ma_phieu,
                            MaSach = bs.ma_vach,
                            NhanDe = tl.ten_tai_lieu,
                            NgayMuon = p.ngay_muon,
                            HanTra = p.han_tra,
                            TrangThaiBanSao = bs.trang_thai
                        }).ToList();
            }
        }

        public List<StatusChangePreviewItem> XemTruocTrangThai(int maBanDoc, string maTaiLieu, bool laMuon)
        {
            using (var db = new SunriseDataContext())
            {
                if (laMuon)
                {
                    var banSao = TimBanSaoCoSan(db, maTaiLieu);
                    if (banSao == null)
                    {
                        throw new InvalidOperationException("Không tìm thấy tài liệu sẵn sàng để mượn.");
                    }

                    return new List<StatusChangePreviewItem>
                    {
                        new StatusChangePreviewItem
                        {
                            MaSach = banSao.ma_vach,
                            TTCu = banSao.trang_thai,
                            TTMoi = "DangMuon"
                        }
                    };
                }

                var phieu = TimPhieuDangMuon(db, maBanDoc, maTaiLieu);
                if (phieu == null)
                {
                    throw new InvalidOperationException("Bạn đọc không có tài liệu này trong danh sách đang mượn.");
                }

                var copy = db.BanSaoTaiLieus.Single(x => x.ma_ban_sao == phieu.ma_ban_sao);
                return new List<StatusChangePreviewItem>
                {
                    new StatusChangePreviewItem
                    {
                        MaSach = copy.ma_vach,
                        TTCu = copy.trang_thai,
                        TTMoi = "Con"
                    }
                };
            }
        }

        public string MuonSach(int maBanDoc, string maTaiLieu, DateTime ngayGiaoDich, bool capNhatNgay)
        {
            using (var db = new SunriseDataContext())
            {
                var banDoc = db.BanDocs.SingleOrDefault(x => x.ma_ban_doc == maBanDoc);
                if (banDoc == null)
                {
                    throw new InvalidOperationException("Không tìm thấy bạn đọc.");
                }

                if (banDoc.trang_thai_the == "TamKhoa")
                {
                    throw new InvalidOperationException("Thẻ đang bị khóa, không thể mượn sách.");
                }

                if (banDoc.ngay_het_han.HasValue && banDoc.ngay_het_han.Value.Date < ngayGiaoDich.Date)
                {
                    throw new InvalidOperationException("Thẻ đã hết hạn, không thể mượn sách.");
                }

                var soDangMuon = db.PhieuMuonTras.Count(x => x.ma_ban_doc == maBanDoc && x.trang_thai_phieu == "DangMuon");
                if (soDangMuon >= GioiHanMuon)
                {
                    throw new InvalidOperationException("Bạn đọc đã mượn tối đa số lượng sách cho phép.");
                }

                var banSao = TimBanSaoCoSan(db, maTaiLieu);
                if (banSao == null)
                {
                    throw new InvalidOperationException("Tài liệu không ở trạng thái có sẵn.");
                }

                var phieu = new PhieuMuonTra
                {
                    ma_ban_doc = maBanDoc,
                    ma_ban_sao = banSao.ma_ban_sao,
                    ngay_muon = ngayGiaoDich.Date,
                    han_tra = ngayGiaoDich.Date.AddDays(SoNgayMuonMacDinh),
                    ngay_tra = null,
                    trang_thai_phieu = "DangMuon",
                    tien_phat = 0,
                    ghi_chu = "Mượn sách tại quầy"
                };
                db.PhieuMuonTras.InsertOnSubmit(phieu);

                if (capNhatNgay)
                {
                    banSao.trang_thai = "DangMuon";
                }
                else
                {
                    banSao.trang_thai = "DangMuon";
                }

                db.SubmitChanges();
                return string.Format("Mượn thành công sách {0}. Hạn trả: {1:dd/MM/yyyy}.", banSao.ma_vach, phieu.han_tra);
            }
        }

        public string TraSach(int maBanDoc, string maTaiLieu, DateTime ngayGiaoDich, bool capNhatNgay)
        {
            using (var db = new SunriseDataContext())
            {
                var phieu = TimPhieuDangMuon(db, maBanDoc, maTaiLieu);
                if (phieu == null)
                {
                    throw new InvalidOperationException("Không tìm thấy phiếu mượn phù hợp để trả sách.");
                }

                var banSao = db.BanSaoTaiLieus.Single(x => x.ma_ban_sao == phieu.ma_ban_sao);
                phieu.ngay_tra = ngayGiaoDich.Date;
                phieu.trang_thai_phieu = "DaTra";

                var soNgayTre = (ngayGiaoDich.Date - phieu.han_tra.Date).Days;
                if (soNgayTre > 0)
                {
                    phieu.tien_phat = soNgayTre * MucPhatMoiNgay;
                    phieu.ghi_chu = string.Format("Trả trễ {0} ngày", soNgayTre);
                }
                else
                {
                    phieu.tien_phat = 0;
                    phieu.ghi_chu = "Trả đúng hạn";
                }

                if (capNhatNgay)
                {
                    banSao.trang_thai = "Con";
                }
                else
                {
                    banSao.trang_thai = "Con";
                }

                db.SubmitChanges();
                return phieu.tien_phat > 0
                    ? string.Format("Trả sách thành công. Tiền phạt: {0:N0} VNĐ.", phieu.tien_phat)
                    : "Trả sách thành công. Không phát sinh tiền phạt.";
            }
        }

        private BanSaoTaiLieu TimBanSaoCoSan(SunriseDataContext db, string maTaiLieu)
        {
            maTaiLieu = (maTaiLieu ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(maTaiLieu))
            {
                return null;
            }

            var theoMaVach = db.BanSaoTaiLieus.SingleOrDefault(x => x.ma_vach == maTaiLieu && x.trang_thai == "Con");
            if (theoMaVach != null)
            {
                return theoMaVach;
            }

            var query = from bs in db.BanSaoTaiLieus
                        join tl in db.TaiLieus on bs.ma_tai_lieu equals tl.ma_tai_lieu
                        where tl.ma_doc == maTaiLieu && bs.trang_thai == "Con"
                        orderby bs.ma_ban_sao
                        select bs;
            return query.FirstOrDefault();
        }

        private PhieuMuonTra TimPhieuDangMuon(SunriseDataContext db, int maBanDoc, string maTaiLieu)
        {
            maTaiLieu = (maTaiLieu ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(maTaiLieu))
            {
                return null;
            }

            var theoMaVach = (from p in db.PhieuMuonTras
                              join bs in db.BanSaoTaiLieus on p.ma_ban_sao equals bs.ma_ban_sao
                              where p.ma_ban_doc == maBanDoc && p.trang_thai_phieu == "DangMuon" && bs.ma_vach == maTaiLieu
                              select p).FirstOrDefault();
            if (theoMaVach != null)
            {
                return theoMaVach;
            }

            return (from p in db.PhieuMuonTras
                    join bs in db.BanSaoTaiLieus on p.ma_ban_sao equals bs.ma_ban_sao
                    join tl in db.TaiLieus on bs.ma_tai_lieu equals tl.ma_tai_lieu
                    where p.ma_ban_doc == maBanDoc && p.trang_thai_phieu == "DangMuon" && tl.ma_doc == maTaiLieu
                    orderby p.ngay_muon descending
                    select p).FirstOrDefault();
        }

        private string ChuyenTinhTrangThe(string trangThai)
        {
            switch (trangThai)
            {
                case "HoatDong": return "Hoạt động";
                case "TamKhoa": return "Tạm khóa";
                case "HetHan": return "Hết hạn";
                default: return trangThai;
            }
        }
    }
}
