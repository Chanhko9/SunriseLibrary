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
            GanSuKienMoForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblNguoiDung.Text = $"Người dùng: {UserSession.TenDangNhap} ({UserSession.TenVaiTro})";
            lblNgayLamViec.Text = "Ngày làm việc: " + DateTime.Now.ToString("dd/MM/yyyy");
            PhanQuyenGiaoDien();
        }

        private void GanSuKienMoForm()
        {
            btnNhapPhanLoai.Click -= ChuaTrienKhai;
            btnKiemKeKho.Click -= ChuaTrienKhai;
            btnBaoCaoThongKe.Click -= ChuaTrienKhai;
            btnQuanTriHeThong.Click -= ChuaTrienKhai;
            btnTileNhapSach.Click -= ChuaTrienKhai;
            btnTileKiemKe.Click -= ChuaTrienKhai;

            btnNhapPhanLoai.Click += btnNhapPhanLoai_Click;
            btnKiemKeKho.Click += btnKiemKeKho_Click;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            btnQuanTriHeThong.Click += btnQuanTriHeThong_Click;

            btnTileNhapSach.Click += btnNhapPhanLoai_Click;
            btnTileKiemKe.Click += btnKiemKeKho_Click;
        }

        private void PhanQuyenGiaoDien()
        {
            bool xemDuLieu = UserSession.XemDuLieu;
            bool themSuaXoa = UserSession.ThemSuaXoa;
            bool quanLyTaiKhoan = UserSession.QuanLyTaiKhoan;
            bool xemBaoCao = UserSession.XemBaoCao;

            btnTraCuuTaiLieu.Visible = xemDuLieu;
            btnTileTraCuu.Visible = xemDuLieu;

            btnMuonTraSach.Visible = themSuaXoa;
            btnCapTheThuVien.Visible = themSuaXoa;
            btnHoSoBanDoc.Visible = themSuaXoa;
            btnNhapPhanLoai.Visible = themSuaXoa;
            btnKiemKeKho.Visible = themSuaXoa;

            btnTileMuonTra.Visible = themSuaXoa;
            btnTileCapThe.Visible = themSuaXoa;
            btnTileHoSo.Visible = themSuaXoa;
            btnTileNhapSach.Visible = themSuaXoa;
            btnTileKiemKe.Visible = themSuaXoa;

            btnBaoCaoThongKe.Visible = xemBaoCao;
            btnQuanTriHeThong.Visible = quanLyTaiKhoan;
        }

        private void btnTraCuuTaiLieu_Click(object sender, EventArgs e)
        {
            new frmTraCuuTaiLieu().ShowDialog();
        }

        private void btnTileTraCuu_Click(object sender, EventArgs e)
        {
            new frmTraCuuTaiLieu().ShowDialog();
        }

        private void btnNhapPhanLoai_Click(object sender, EventArgs e)
        {
            new frmNhapPhanLoaiTaiLieu().ShowDialog();
        }

        private void btnKiemKeKho_Click(object sender, EventArgs e)
        {
            new frmKiemKeKho().ShowDialog();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            new frmBaoCaoThongKe().ShowDialog();
        }

        private void btnQuanTriHeThong_Click(object sender, EventArgs e)
        {
            new frmQuanTriHeThong().ShowDialog();
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
