using System;
using System.Windows.Forms;
using SunriseLibrary.Helpers;

namespace SunriseLibrary.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = $"Người dùng: {UserSession.TenDangNhap} ({UserSession.TenVaiTro})";
            lblNgayLamViec.Text = "Ngày làm việc: " + DateTime.Now.ToString("dd/MM/yyyy");
            PhanQuyenGiaoDien();
        }

        private void PhanQuyenGiaoDien()
        {
            string vaiTro = UserSession.TenVaiTro;

            if (vaiTro == "BanDoc")
            {
                btnMuonTraSach.Visible = false;
                btnCapTheThuVien.Visible = false;
                btnHoSoBanDoc.Visible = false;
                btnNhapPhanLoai.Visible = false;
                btnKiemKeKho.Visible = false;
                btnBaoCaoThongKe.Visible = false;
                btnQuanTriHeThong.Visible = false;
            }
            else if (vaiTro == "NhanVien")
            {
                btnQuanTriHeThong.Visible = false;
            }
        }

        private void btnTraCuuTaiLieu_Click(object sender, EventArgs e)
        {
            new frmTraCuuTaiLieu().ShowDialog();
        }

        private void btnTileTraCuu_Click(object sender, EventArgs e)
        {
            new frmTraCuuTaiLieu().ShowDialog();
        }

        private void btnMuonTraSach_Click(object sender, EventArgs e)
        {
            new frmMuonTraSach().ShowDialog();
        }

        private void btnCapTheThuVien_Click(object sender, EventArgs e)
        {
            new frmCapTheThuVien().ShowDialog();
        }

        private void btnHoSoBanDoc_Click(object sender, EventArgs e)
        {
            new frmHoSoBanDoc().ShowDialog();
        }

        private void btnTileMuonTra_Click(object sender, EventArgs e)
        {
            new frmMuonTraSach().ShowDialog();
        }

        private void btnTileCapThe_Click(object sender, EventArgs e)
        {
            new frmCapTheThuVien().ShowDialog();
        }

        private void btnTileHoSo_Click(object sender, EventArgs e)
        {
            new frmHoSoBanDoc().ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            var frm = new frmDangNhap();
            frm.Show();
            Close();
        }

        private void ChuaTrienKhai(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được nhóm phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
