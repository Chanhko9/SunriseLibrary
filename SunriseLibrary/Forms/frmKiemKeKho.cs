using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmKiemKeKho : Form
    {
        private readonly KiemKeKhoService _service = new KiemKeKhoService();
        private int _maDotKiemKe = 0;

        public frmKiemKeKho()
        {
            InitializeComponent();
            txtNgayBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtNguoiPhuTrach.Text = Helpers.UserSession.TenDangNhap;
            dgvDoiSoat.CellEndEdit += dgvDoiSoat_CellEndEdit;
        }

        private void btnTaoDot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDot.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đợt kiểm kê.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dot = _service.TaoDot(txtMaDot.Text.Trim(), txtKho.Text.Trim(), DateTime.Now, txtNguoiPhuTrach.Text.Trim());
                _maDotKiemKe = dot.ma_dot_kiem_ke;
                NapDanhSach();
                MessageBox.Show("Đã tạo đợt kiểm kê và nạp danh sách đối soát.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo đợt kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NapDanhSach()
        {
            dgvDoiSoat.Rows.Clear();
            if (_maDotKiemKe <= 0) return;

            var items = _service.LayChiTietDot(_maDotKiemKe);
            foreach (var item in items)
            {
                var rowIndex = dgvDoiSoat.Rows.Add(item.MaSach, item.TTHeThong, item.ThucTe, item.ChenhLech, item.XuLy);
                dgvDoiSoat.Rows[rowIndex].Tag = item.MaBanSao;
            }
            CapNhatTongHop();
        }

        private void dgvDoiSoat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDoiSoat.Rows[e.RowIndex];
            var heThong = Convert.ToString(row.Cells[1].Value) ?? string.Empty;
            var thucTe = Convert.ToString(row.Cells[2].Value) ?? string.Empty;

            row.Cells[3].Value = TinhChenhLech(heThong, thucTe);
            CapNhatTongHop();
        }

        private string TinhChenhLech(string heThong, string thucTe)
        {
            if (string.IsNullOrWhiteSpace(thucTe)) return string.Empty;

            var value = thucTe.Trim().ToLower();
            if (value == heThong.Trim().ToLower()) return "Khớp";
            if (value.Contains("thieu")) return "Thiếu";
            if (value.Contains("du")) return "Dư";
            if (value.Contains("sai")) return "Sai vị trí";
            return "Khác trạng thái";
        }

        private void CapNhatTongHop()
        {
            var rows = dgvDoiSoat.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
            txtTongDauSach.Text = rows.Count.ToString();
            txtDaKiem.Text = rows.Count(r => !string.IsNullOrWhiteSpace(Convert.ToString(r.Cells[2].Value))).ToString();
            txtThieu.Text = rows.Count(r => Convert.ToString(r.Cells[3].Value) == "Thiếu").ToString();
            txtDu.Text = rows.Count(r => Convert.ToString(r.Cells[3].Value) == "Dư").ToString();
            txtSaiViTri.Text = rows.Count(r => Convert.ToString(r.Cells[3].Value) == "Sai vị trí").ToString();
        }

        private void btnNhapKetQua_Click(object sender, EventArgs e)
        {
            if (_maDotKiemKe <= 0)
            {
                MessageBox.Show("Vui lòng tạo đợt kiểm kê trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var items = new List<KiemKeDoiSoatItem>();
            foreach (DataGridViewRow row in dgvDoiSoat.Rows)
            {
                if (row.IsNewRow || row.Tag == null) continue;
                items.Add(new KiemKeDoiSoatItem
                {
                    MaBanSao = Convert.ToInt32(row.Tag),
                    MaSach = Convert.ToString(row.Cells[0].Value),
                    TTHeThong = Convert.ToString(row.Cells[1].Value),
                    ThucTe = Convert.ToString(row.Cells[2].Value),
                    ChenhLech = Convert.ToString(row.Cells[3].Value),
                    XuLy = Convert.ToString(row.Cells[4].Value)
                });
            }

            _service.LuuKetQua(_maDotKiemKe, items);
            CapNhatTongHop();
            MessageBox.Show("Đã lưu kết quả kiểm kê vào cơ sở dữ liệu.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXuatBienBan_Click(object sender, EventArgs e)
        {
            if (dgvDoiSoat.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"BienBanKiemKe_{txtMaDot.Text.Trim()}.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                var sb = new StringBuilder();
                sb.AppendLine("MaSach,TTHeThong,ThucTe,ChenhLech,XuLy");
                foreach (DataGridViewRow row in dgvDoiSoat.Rows)
                {
                    if (row.IsNewRow) continue;
                    var cells = Enumerable.Range(0, 5).Select(i => Convert.ToString(row.Cells[i].Value)?.Replace(',', ';'));
                    sb.AppendLine(string.Join(",", cells));
                }
                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Đã xuất biên bản kiểm kê.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKetThucDot_Click(object sender, EventArgs e)
        {
            if (_maDotKiemKe <= 0)
            {
                Close();
                return;
            }

            _service.KetThucDot(_maDotKiemKe);
            MessageBox.Show("Đã kết thúc đợt kiểm kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtNguoiPhuTrach_TextChanged(object sender, EventArgs e) { }
        private void grpDanhSach_Enter(object sender, EventArgs e) { }
        private void grpDotKiemKe_Enter(object sender, EventArgs e) { }
        private void grpTongHop_Enter(object sender, EventArgs e) { }
        private void txtTongDauSach_TextChanged(object sender, EventArgs e) { }
    }
}
