using System;
using System.Drawing;
using System.Windows.Forms;

namespace SunriseLibrary.Forms
{
    public partial class frmQuanTriBaoCao : Form
    {
        public frmQuanTriBaoCao()
        {
            InitializeComponent();
            NapDuLieuMau();
        }

        private void NapDuLieuMau()
        {
            dgvTaiKhoan.Rows.Add("admin", "Quản trị hệ thống", "Quản trị viên", "Hoạt động");
            dgvTaiKhoan.Rows.Add("thuvien01", "Nhân viên thư viện", "Nhân viên", "Hoạt động");
            dgvTaiKhoan.Rows.Add("bandoc01", "Bạn đọc mẫu", "Bạn đọc", "Khóa");

            dgvChiTieu.Rows.Add("Tổng lượt mượn", "128");
            dgvChiTieu.Rows.Add("Tổng lượt trả", "117");
            dgvChiTieu.Rows.Add("Bạn đọc mới", "23");
            dgvChiTieu.Rows.Add("Tài liệu quá hạn", "11");
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lọc báo cáo theo điều kiện đã chọn (mẫu giao diện).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu thiết lập quyền (mẫu giao diện).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void pnlBieuDo_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);
            using (var pen = new Pen(Color.Black, 2))
            {
                var points = new[]
                {
                    new Point(20, 170),
                    new Point(120, 70),
                    new Point(220, 110),
                    new Point(320, 40)
                };
                g.DrawLines(pen, points);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuNgay.Clear();
            txtDenNgay.Clear();
            txtLoaiBaoCao.Clear();
            chkXemDuLieu.Checked = true;
            chkThemSuaXoa.Checked = false;
            chkQuanLyTaiKhoan.Checked = false;
            chkXemBaoCao.Checked = false;
        }

        private void grpBaoCao_Enter(object sender, EventArgs e)
        {

        }

        private void dgvChiTieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpQuanLyQuyen_Enter(object sender, EventArgs e)
        {

        }

        private void frmQuanTriBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
