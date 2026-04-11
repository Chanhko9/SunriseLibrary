using System;
using System.Windows.Forms;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            string vaiTro = rdoBanDoc.Checked ? "BanDoc"
                           : rdoNhanVien.Checked ? "NhanVien"
                           : "QuanTriVien";

            var authService = new AuthService();
            bool ketQua = authService.DangNhap(txtTenDangNhap.Text.Trim(), txtMatKhau.Text.Trim(), vaiTro);

            if (!ketQua)
            {
                MessageBox.Show("Sai thông tin đăng nhập hoặc vai trò.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmMain frm = new frmMain();
            frm.Show();
            Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoBanDoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
