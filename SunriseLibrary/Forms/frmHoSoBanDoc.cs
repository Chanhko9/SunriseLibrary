using System;
using System.Linq;
using System.Windows.Forms;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmHoSoBanDoc : Form
    {
        private readonly BanDocService _service = new BanDocService();
        private readonly CapTheThuVienService _capTheService = new CapTheThuVienService();

        private int _maBanDocDangChon;
        private bool _dangThemMoi;

        public frmHoSoBanDoc()
        {
            InitializeComponent();
            GanSuKienPhu();
        }

        private void frmHoSoBanDoc_Load(object sender, EventArgs e)
        {
            try
            {
                if (cboGioiTinh.Items.Count > 0)
                {
                    cboGioiTinh.SelectedIndex = 0;
                }

                DatCheDoThemMoi(false);
                XoaForm();
                NapDanhSach(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi tạo form hồ sơ bạn đọc.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GanSuKienPhu()
        {
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            dgvBanDoc.DataBindingComplete += dgvBanDoc_DataBindingComplete;
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;
            btnTim.PerformClick();
        }

        private void dgvBanDoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvBanDoc.Rows.Count <= 0) return;

            foreach (DataGridViewRow row in dgvBanDoc.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            NapDanhSach(true);
        }

        private void NapDanhSach(bool tuDongChonDongDau)
        {
            var danhSach = _service.TimBanDoc(txtTimKiem.Text.Trim());

            dgvBanDoc.DataSource = null;
            dgvBanDoc.DataSource = danhSach;

            if (tuDongChonDongDau && danhSach.Count > 0)
            {
                dgvBanDoc.ClearSelection();
                dgvBanDoc.Rows[0].Selected = true;
                dgvBanDoc.CurrentCell = dgvBanDoc.Rows[0].Cells[0];

                var item = dgvBanDoc.Rows[0].DataBoundItem as BanDocListItem;
                if (item != null)
                {
                    _maBanDocDangChon = item.MaBanDoc;
                    TaiChiTietLenForm();
                }
            }
            else if (danhSach.Count == 0)
            {
                _maBanDocDangChon = 0;
                XoaForm();
            }
        }

        private void dgvBanDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvBanDoc.Rows[e.RowIndex].DataBoundItem as BanDocListItem;
            if (item == null) return;

            DatCheDoThemMoi(false);
            _maBanDocDangChon = item.MaBanDoc;
            TaiChiTietLenForm();
        }

        private void TaiChiTietLenForm()
        {
            if (_maBanDocDangChon <= 0)
            {
                XoaForm();
                return;
            }

            var chiTiet = _service.LayChiTietBanDoc(_maBanDocDangChon);
            if (chiTiet == null)
            {
                XoaForm();
                return;
            }

            GanThongTinLenForm(chiTiet);
            dgvLichSuGiaoDich.DataSource = null;
            dgvLichSuGiaoDich.DataSource = _service.LayLichSuGiaoDich(_maBanDocDangChon);
        }

        private void GanThongTinLenForm(BanDocChiTiet chiTiet)
        {
            SetMaTheText(chiTiet.MaThe);
            lblTrangThaiValue.Text = ChuyenTrangThai(chiTiet.TrangThaiThe);

            txtHoTen.Text = chiTiet.HoTen ?? string.Empty;
            dtpNgaySinh.Value = chiTiet.NgaySinh ?? DateTime.Today;
            cboGioiTinh.Text = string.IsNullOrWhiteSpace(chiTiet.GioiTinh) ? "Nam" : chiTiet.GioiTinh;
            txtDiaChi.Text = chiTiet.DiaChi ?? string.Empty;
            txtEmail.Text = chiTiet.Email ?? string.Empty;
            txtSoDienThoai.Text = chiTiet.SoDienThoai ?? string.Empty;
            dtpNgayHetHan.Value = chiTiet.NgayHetHanThe ?? DateTime.Today.AddYears(1);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_dangThemMoi)
                {
                    DatCheDoThemMoi(true);
                    _maBanDocDangChon = 0;
                    XoaForm();
                    txtHoTen.Focus();

                    MessageBox.Show("Nhập thông tin bạn đọc rồi bấm 'Lưu mới' để tạo hồ sơ.",
                        "Thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!KiemTraDuLieuNhap()) return;

                var model = TaoModelTuForm();
                model.MaThe = _capTheService.TaoMaTheMoi();
                model.TrangThaiThe = "HoatDong";
                model.LoaiBanDoc = "SinhVien";

                var maMoi = _service.ThemMoiBanDoc(model);

                DatCheDoThemMoi(false);
                _maBanDocDangChon = maMoi;

                NapDanhSach(false);
                ChonDongTheoMaBanDoc(maMoi);
                TaiChiTietLenForm();

                MessageBox.Show("Đã tạo hồ sơ bạn đọc mới.\nMã thẻ: " + GetMaTheText(),
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_dangThemMoi)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới. Hãy bấm 'Lưu mới' trước hoặc chọn lại bạn đọc cần sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_maBanDocDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn bạn đọc cần cập nhật.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraDuLieuNhap()) return;

            try
            {
                var model = TaoModelTuForm();
                model.MaBanDoc = _maBanDocDangChon;
                model.MaThe = GetMaTheText();
                model.TrangThaiThe = lblTrangThaiValue.Text == "Tạm khóa" ? "TamKhoa" : "HoatDong";

                _service.CapNhatBanDoc(model);

                NapDanhSach(false);
                ChonDongTheoMaBanDoc(_maBanDocDangChon);
                TaiChiTietLenForm();

                MessageBox.Show("Đã cập nhật hồ sơ bạn đọc.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoaThe_Click(object sender, EventArgs e)
        {
            if (_dangThemMoi)
            {
                MessageBox.Show("Bạn đang thêm mới hồ sơ, chưa thể khóa thẻ.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_maBanDocDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn bạn đọc trước.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var message = _service.KhoaHoacMoThe(_maBanDocDangChon);

                NapDanhSach(false);
                ChonDongTheoMaBanDoc(_maBanDocDangChon);
                TaiChiTietLenForm();

                MessageBox.Show(message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private BanDocChiTiet TaoModelTuForm()
        {
            return new BanDocChiTiet
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cboGioiTinh.Text,
                DiaChi = txtDiaChi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayHetHanThe = dtpNgayHetHan.Value.Date
            };
        }

        private bool KiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống.",
                    "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không đúng định dạng.",
                    "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) &&
                txtSoDienThoai.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số.",
                    "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            if (dtpNgayHetHan.Value.Date < DateTime.Today.Date)
            {
                var result = MessageBox.Show(
                    "Ngày hết hạn nhỏ hơn ngày hiện tại. Bạn vẫn muốn tiếp tục?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    dtpNgayHetHan.Focus();
                    return false;
                }
            }

            return true;
        }

        private void DatCheDoThemMoi(bool dangThemMoi)
        {
            _dangThemMoi = dangThemMoi;
            btnThemMoi.Text = dangThemMoi ? "Lưu mới" : "Thêm mới";
        }

        private void XoaForm()
        {
            SetMaTheText("(sẽ tự sinh)");
            lblTrangThaiValue.Text = "Hoạt động";

            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();

            if (cboGioiTinh.Items.Count > 0)
            {
                cboGioiTinh.SelectedIndex = 0;
            }

            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayHetHan.Value = DateTime.Today.AddYears(1);

            dgvLichSuGiaoDich.DataSource = null;
        }

        private void ChonDongTheoMaBanDoc(int maBanDoc)
        {
            foreach (DataGridViewRow row in dgvBanDoc.Rows)
            {
                var item = row.DataBoundItem as BanDocListItem;
                if (item == null) continue;

                if (item.MaBanDoc == maBanDoc)
                {
                    dgvBanDoc.ClearSelection();
                    row.Selected = true;
                    dgvBanDoc.CurrentCell = row.Cells[0];
                    return;
                }
            }
        }

        private string ChuyenTrangThai(string trangThai)
        {
            switch (trangThai)
            {
                case "HoatDong":
                    return "Hoạt động";
                case "TamKhoa":
                    return "Tạm khóa";
                case "HetHan":
                    return "Hết hạn";
                default:
                    return string.IsNullOrWhiteSpace(trangThai) ? "Hoạt động" : trangThai;
            }
        }

        private void SetMaTheText(string value)
        {
            var txtMaThe = TimControlDeQuy(this, "txtMaThe") as TextBox;
            if (txtMaThe != null)
            {
                txtMaThe.Text = value;
                return;
            }

            var lblMaTheValue = TimControlDeQuy(this, "lblMaTheValue") as Label;
            if (lblMaTheValue != null)
            {
                lblMaTheValue.Text = value;
            }
        }

        private string GetMaTheText()
        {
            var txtMaThe = TimControlDeQuy(this, "txtMaThe") as TextBox;
            if (txtMaThe != null)
            {
                return txtMaThe.Text.Trim();
            }

            var lblMaTheValue = TimControlDeQuy(this, "lblMaTheValue") as Label;
            if (lblMaTheValue != null)
            {
                return lblMaTheValue.Text.Trim();
            }

            return string.Empty;
        }

        private Control TimControlDeQuy(Control parent, string tenControl)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == tenControl)
                {
                    return control;
                }

                if (control.Controls.Count > 0)
                {
                    var ketQua = TimControlDeQuy(control, tenControl);
                    if (ketQua != null)
                    {
                        return ketQua;
                    }
                }
            }

            return null;
        }

        private void txtMaThe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}