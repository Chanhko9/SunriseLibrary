using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmMuonTraSach : Form
    {
        private readonly MuonTraSachService _service = new MuonTraSachService();
        private ThongTinBanDocMuonTra _banDocDangChon;
        private string _noiDungPhieuCuoi = string.Empty;

        public frmMuonTraSach()
        {
            InitializeComponent();
        }

        private void frmMuonTraSach_Load(object sender, EventArgs e)
        {
            rdoMuon.Checked = true;
            chkCapNhatTrangThaiNgay.Checked = true;
            dtpNgayGiaoDich.Value = DateTime.Today;
        }

        private void btnKiemTraThe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaThe.Text))
            {
                MessageBox.Show("Vui lòng nhập mã thẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _banDocDangChon = _service.KiemTraThe(txtMaThe.Text.Trim());
                HienThiThongTinBanDoc();
                NapSachDangMuon();
                CapNhatXemTruoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                XoaThongTinBanDoc();
            }
        }

        private void HienThiThongTinBanDoc()
        {
            lblHoTenValue.Text = _banDocDangChon.HoTen;
            lblLopKhoaValue.Text = _banDocDangChon.LopKhoa;
            lblTinhTrangTheValue.Text = _banDocDangChon.TinhTrangThe;
            lblSoSachDangMuonValue.Text = _banDocDangChon.SoSachDangMuon.ToString();
        }

        private void NapSachDangMuon()
        {
            if (_banDocDangChon == null) return;
            dgvSachDangMuon.DataSource = _service.LaySachDangMuon(_banDocDangChon.MaBanDoc);
            lblSoSachDangMuonValue.Text = _service.LaySachDangMuon(_banDocDangChon.MaBanDoc).Count.ToString();
        }

        private void txtMaTaiLieu_TextChanged(object sender, EventArgs e)
        {
            CapNhatXemTruoc();
        }

        private void rdoMuon_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatXemTruoc();
        }

        private void rdoTra_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatXemTruoc();
        }

        private void CapNhatXemTruoc()
        {
            if (_banDocDangChon == null || string.IsNullOrWhiteSpace(txtMaTaiLieu.Text))
            {
                dgvTrangThaiSach.DataSource = null;
                return;
            }

            try
            {
                List<StatusChangePreviewItem> ds = _service.XemTruocTrangThai(_banDocDangChon.MaBanDoc, txtMaTaiLieu.Text.Trim(), rdoMuon.Checked);
                dgvTrangThaiSach.DataSource = ds;
            }
            catch
            {
                dgvTrangThaiSach.DataSource = null;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_banDocDangChon == null)
            {
                MessageBox.Show("Vui lòng kiểm tra thẻ trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaTaiLieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã tài liệu hoặc mã sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (rdoMuon.Checked)
                {
                    _noiDungPhieuCuoi = _service.MuonSach(_banDocDangChon.MaBanDoc, txtMaTaiLieu.Text.Trim(), dtpNgayGiaoDich.Value.Date, chkCapNhatTrangThaiNgay.Checked);
                }
                else
                {
                    _noiDungPhieuCuoi = _service.TraSach(_banDocDangChon.MaBanDoc, txtMaTaiLieu.Text.Trim(), dtpNgayGiaoDich.Value.Date, chkCapNhatTrangThaiNgay.Checked);
                }

                MessageBox.Show(_noiDungPhieuCuoi, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _banDocDangChon = _service.KiemTraThe(txtMaThe.Text.Trim());
                HienThiThongTinBanDoc();
                NapSachDangMuon();
                txtMaTaiLieu.Clear();
                dgvTrangThaiSach.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_noiDungPhieuCuoi))
            {
                MessageBox.Show("Chưa có giao dịch nào để in phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(_noiDungPhieuCuoi, "Phiếu giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTaiLieu.Clear();
            dtpNgayGiaoDich.Value = DateTime.Today;
            rdoMuon.Checked = true;
            chkCapNhatTrangThaiNgay.Checked = true;
            dgvTrangThaiSach.DataSource = null;
        }

        private void XoaThongTinBanDoc()
        {
            _banDocDangChon = null;
            lblHoTenValue.Text = string.Empty;
            lblLopKhoaValue.Text = string.Empty;
            lblTinhTrangTheValue.Text = string.Empty;
            lblSoSachDangMuonValue.Text = string.Empty;
            dgvSachDangMuon.DataSource = null;
            dgvTrangThaiSach.DataSource = null;
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }
    }
}
