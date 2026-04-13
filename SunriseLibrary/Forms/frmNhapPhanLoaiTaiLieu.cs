using System;
using System.Linq;
using System.Windows.Forms;
using SunriseLibrary.Data;
using SunriseLibrary.Models;

namespace SunriseLibrary.Forms
{
    public partial class frmNhapPhanLoaiTaiLieu : Form
    {
        public frmNhapPhanLoaiTaiLieu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTaiLieu.Text) || string.IsNullOrWhiteSpace(txtNhanDe.Text) ||
                string.IsNullOrWhiteSpace(txtTacGia.Text) || string.IsNullOrWhiteSpace(txtMaPhanLoai.Text) ||
                string.IsNullOrWhiteSpace(txtChuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc: Mã tài liệu, Nhan đề, Tác giả, Mã phân loại, Chủ đề.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNamXuatBan.Text) && !int.TryParse(txtNamXuatBan.Text.Trim(), out _))
            {
                MessageBox.Show("Năm xuất bản phải là số hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkTaiLieuSo.Checked && string.IsNullOrWhiteSpace(txtDuongDanTep.Text))
            {
                MessageBox.Show("Tài liệu số / đa phương tiện cần chọn tệp đính kèm.", "Thiếu tệp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new SunriseDataContext())
            {
                var maDoc = txtMaTaiLieu.Text.Trim();
                if (db.TaiLieus.Any(x => x.ma_doc == maDoc))
                {
                    MessageBox.Show("Mã tài liệu đã tồn tại.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var phanLoai = db.PhanLoaiTaiLieus.FirstOrDefault(x => x.ky_hieu == txtMaPhanLoai.Text.Trim());
                if (phanLoai == null)
                {
                    phanLoai = new PhanLoaiTaiLieu
                    {
                        ky_hieu = txtMaPhanLoai.Text.Trim(),
                        ten_phan_loai = txtChuDe.Text.Trim(),
                        mo_ta = txtTheLoai.Text.Trim(),
                        tu_khoa = txtTuKhoa.Text.Trim()
                    };
                    db.PhanLoaiTaiLieus.InsertOnSubmit(phanLoai);
                    db.SubmitChanges();
                }
                else
                {
                    phanLoai.ten_phan_loai = txtChuDe.Text.Trim();
                    phanLoai.mo_ta = txtTheLoai.Text.Trim();
                    phanLoai.tu_khoa = txtTuKhoa.Text.Trim();
                    db.SubmitChanges();
                }

                int? namXB = null;
                if (int.TryParse(txtNamXuatBan.Text.Trim(), out var year))
                    namXB = year;

                var taiLieu = new TaiLieu
                {
                    ma_phan_loai = phanLoai.ma_phan_loai,
                    ma_doc = maDoc,
                    ten_tai_lieu = txtNhanDe.Text.Trim(),
                    tac_gia = txtTacGia.Text.Trim(),
                    nha_xuat_ban = txtNhaXuatBan.Text.Trim(),
                    nam_xuat_ban = namXB,
                    loai_tai_lieu = chkTaiLieuSo.Checked ? "TaiLieuSo" : "SachIn",
                    the_loai = txtTheLoai.Text.Trim(),
                    dinh_dang = txtDinhDang.Text.Trim(),
                    mo_ta = $"Chủ đề: {txtChuDe.Text.Trim()}; Từ khóa: {txtTuKhoa.Text.Trim()}",
                    duong_dan_file = txtDuongDanTep.Text.Trim(),
                    quyen_truy_cap = string.IsNullOrWhiteSpace(txtQuyenTruyCap.Text) ? "CongKhai" : txtQuyenTruyCap.Text.Trim(),
                    ngay_nhap = DateTime.Now,
                    hien_thi_tra_cuu = chkHienThiTraCuu.Checked
                };
                db.TaiLieus.InsertOnSubmit(taiLieu);
                db.SubmitChanges();

                if (!string.IsNullOrWhiteSpace(txtViTriKho.Text))
                {
                    var banSao = new BanSaoTaiLieu
                    {
                        ma_tai_lieu = taiLieu.ma_tai_lieu,
                        ma_vach = $"{maDoc}-{DateTime.Now:HHmmss}",
                        vi_tri_kho = txtViTriKho.Text.Trim(),
                        trang_thai = "Con",
                        ngay_nhap_kho = DateTime.Now,
                        ghi_chu = chkTaiLieuSo.Checked ? "Bản ghi từ form tài liệu số" : "Bản ghi nhập mới"
                    };
                    db.BanSaoTaiLieus.InsertOnSubmit(banSao);
                    db.SubmitChanges();
                }
            }

            MessageBox.Show("Đã lưu thông tin tài liệu vào cơ sở dữ liệu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNhapMoi_Click(sender, e);
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaTaiLieu.Clear();
            txtNhanDe.Clear();
            txtTacGia.Clear();
            txtNhaXuatBan.Clear();
            txtNamXuatBan.Clear();
            txtTheLoai.Clear();
            txtTuKhoa.Clear();
            txtViTriKho.Clear();
            txtMaPhanLoai.Clear();
            txtChuDe.Clear();
            txtDinhDang.Clear();
            txtQuyenTruyCap.Clear();
            txtDuongDanTep.Clear();
            chkTaiLieuSo.Checked = false;
            chkHienThiTraCuu.Checked = false;
            txtMaTaiLieu.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChonTep_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn tệp tài liệu";
                dialog.Filter = "Tất cả tệp|*.*|PDF|*.pdf|Word|*.doc;*.docx|Video|*.mp4;*.avi|Hình ảnh|*.png;*.jpg;*.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDuongDanTep.Text = dialog.FileName;
                }
            }
        }

        private void grpThongTinTaiLieu_Enter(object sender, EventArgs e) { }
        private void grpTepTin_Enter(object sender, EventArgs e) { }
        private void chkTaiLieuSo_CheckedChanged(object sender, EventArgs e)
        {
            txtDuongDanTep.Enabled = chkTaiLieuSo.Checked;
            btnChonTep.Enabled = chkTaiLieuSo.Checked;
        }
        private void grpPhanLoai_Enter(object sender, EventArgs e) { }
    }
}
