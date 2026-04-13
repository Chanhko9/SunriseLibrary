using System;
using System.Windows.Forms;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmCapTheThuVien : Form
    {
        private readonly CapTheThuVienService _service = new CapTheThuVienService();
        private CapTheSinhVienItem _sinhVienDangChon;
        private bool _chiLayChuaCap = true;

        public frmCapTheThuVien()
        {
            InitializeComponent();
        }

        private void frmCapTheThuVien_Load(object sender, EventArgs e)
        {
            cboLoaiThe.SelectedIndex = 0;
            dtpNgayKichHoat.Value = DateTime.Today;
            NapDanhSach();
        }

        private void NapDanhSach()
        {
            dgvSinhVien.DataSource = _service.LayDanhSachSinhVienChoCapThe(_chiLayChuaCap);
            lblTrangThaiDongBo.Text = _chiLayChuaCap
                ? "Trạng thái đồng bộ: Chỉ hiển thị sinh viên chưa cấp thẻ"
                : "Trạng thái đồng bộ: Hiển thị toàn bộ danh sách";
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSinhVien.Rows[e.RowIndex].DataBoundItem as CapTheSinhVienItem;
            if (row == null) return;

            _sinhVienDangChon = row;
            txtMSSV.Text = row.MSSV;
            txtHoTen.Text = row.HoTen;
            dtpNgaySinh.Value = row.NgaySinh ?? new DateTime(2004, 1, 1);
            txtEmail.Text = row.Email;
            txtSoDienThoai.Text = row.SoDienThoai;
        }

        private void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                _service.NapDuLieuTuPhongDaoTao();
                NapDanhSach();
                MessageBox.Show("Đã đồng bộ dữ liệu sinh viên từ Phòng Đào tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            _chiLayChuaCap = !_chiLayChuaCap;
            NapDanhSach();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaChonSinhVien()) return;
            var user = _service.TaoTenDangNhap(_sinhVienDangChon.MSSV);
            MessageBox.Show($"Tài khoản dự kiến:\n- Tên đăng nhập: {user}\n- Mật khẩu mặc định: 123", "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapMaThe_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaChonSinhVien()) return;
            var maThe = _service.TaoMaTheMoi();
            MessageBox.Show($"Mã thẻ dự kiến: {maThe}", "Cấp mã thẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDaChonSinhVien()) return;

            try
            {
                var maThe = _service.CapTheChoSinhVien(_sinhVienDangChon.MaSinhVienCho, cboLoaiThe.Text, dtpNgayKichHoat.Value.Date);
                MessageBox.Show($"Cấp thẻ thành công.\nMã thẻ: {maThe}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiThongTin();
                NapDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KiemTraDaChonSinhVien()
        {
            if (_sinhVienDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_sinhVienDangChon.DaCapThe)
            {
                MessageBox.Show("Sinh viên này đã được cấp thẻ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void LamMoiThongTin()
        {
            _sinhVienDangChon = null;
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cboLoaiThe.SelectedIndex = 0;
            dtpNgayKichHoat.Value = DateTime.Today;
        }
    }
}
