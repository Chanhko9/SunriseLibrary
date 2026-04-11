using System;
using System.Windows.Forms;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmTraCuuTaiLieu : Form
    {
        public frmTraCuuTaiLieu()
        {
            InitializeComponent();
        }

        private void frmTraCuuTaiLieu_Load(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            var service = new TaiLieuService();
            dgvKetQua.DataSource = service.TimKiem(txtTenSach.Text.Trim(), txtTacGia.Text.Trim(), txtChuDe.Text.Trim(), txtMaTaiLieu.Text.Trim());
            CaiDatTieuDeLuoi();
        }

        private void CaiDatTieuDeLuoi()
        {
            if (dgvKetQua.Columns.Count == 0) return;

            if (dgvKetQua.Columns["MaTaiLieu"] != null) dgvKetQua.Columns["MaTaiLieu"].Visible = false;
            if (dgvKetQua.Columns["MaDoc"] != null) dgvKetQua.Columns["MaDoc"].HeaderText = "Mã TL";
            if (dgvKetQua.Columns["NhanDe"] != null) dgvKetQua.Columns["NhanDe"].HeaderText = "Nhan đề";
            if (dgvKetQua.Columns["TacGia"] != null) dgvKetQua.Columns["TacGia"].HeaderText = "Tác giả";
            if (dgvKetQua.Columns["TinhTrang"] != null) dgvKetQua.Columns["TinhTrang"].HeaderText = "Tình trạng";
            if (dgvKetQua.Columns["Kho"] != null) dgvKetQua.Columns["Kho"].HeaderText = "Kho";
            if (dgvKetQua.Columns["NhaXuatBan"] != null) dgvKetQua.Columns["NhaXuatBan"].Visible = false;
            if (dgvKetQua.Columns["TheLoai"] != null) dgvKetQua.Columns["TheLoai"].Visible = false;
            if (dgvKetQua.Columns["DuongDanFile"] != null) dgvKetQua.Columns["DuongDanFile"].Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtChuDe.Clear();
            txtMaTaiLieu.Clear();
            dgvKetQua.DataSource = null;
            XoaThongTinChiTiet();
            NapDuLieu();
        }

        private void XoaThongTinChiTiet()
        {
            lblNhanDeValue.Text = "";
            lblTacGiaValue.Text = "";
            lblNhaXuatBanValue.Text = "";
            lblTheLoaiValue.Text = "";
            lblViTriKhoValue.Text = "";
            lblTaiLieuSoValue.Text = "";
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKetQua.Rows[e.RowIndex];

            lblNhanDeValue.Text = row.Cells["NhanDe"].Value?.ToString();
            lblTacGiaValue.Text = row.Cells["TacGia"].Value?.ToString();
            lblNhaXuatBanValue.Text = row.Cells["NhaXuatBan"].Value?.ToString();
            lblTheLoaiValue.Text = row.Cells["TheLoai"].Value?.ToString();
            lblViTriKhoValue.Text = row.Cells["Kho"].Value?.ToString();
            string duongDanFile = row.Cells["DuongDanFile"].Value?.ToString();
            lblTaiLieuSoValue.Text = string.IsNullOrWhiteSpace(duongDanFile) ? "Không" : "Có";
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thể mở rộng form chi tiết tài liệu ở sprint sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDatMuon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đặt mượn chưa triển khai trong sprint đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTacGiaValue_Click(object sender, EventArgs e)
        {

        }

        private void lblTacGiaCT_Click(object sender, EventArgs e)
        {

        }
    }
}
