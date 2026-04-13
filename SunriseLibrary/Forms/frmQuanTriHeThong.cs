using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmQuanTriHeThong : Form
    {
        private readonly QuanTriHeThongService _service = new QuanTriHeThongService();
        private List<TaiKhoanPhanQuyenItem> _items = new List<TaiKhoanPhanQuyenItem>();

        public frmQuanTriHeThong()
        {
            InitializeComponent();
            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;
            Load += frmQuanTriHeThong_Load;
        }

        private void frmQuanTriHeThong_Load(object sender, EventArgs e)
        {
            NapDanhSach();
        }

        private void NapDanhSach()
        {
            _items = _service.LayDanhSachTaiKhoan();
            dgvTaiKhoan.Rows.Clear();
            foreach (var item in _items)
            {
                var idx = dgvTaiKhoan.Rows.Add(item.User, item.HoTen, item.VaiTro, item.TrangThai);
                dgvTaiKhoan.Rows[idx].Tag = item.MaTaiKhoan;
            }

            if (dgvTaiKhoan.Rows.Count > 0)
                dgvTaiKhoan.Rows[0].Selected = true;
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null || dgvTaiKhoan.CurrentRow.Tag == null) return;
            var maTaiKhoan = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Tag);
            var item = _items.FirstOrDefault(x => x.MaTaiKhoan == maTaiKhoan);
            if (item == null) return;

            chkXemDuLieu.Checked = item.XemDuLieu;
            chkThemSuaXoa.Checked = item.ThemSuaXoa;
            chkQuanLyTaiKhoan.Checked = item.QuanLyTaiKhoan;
            chkXemBaoCao.Checked = item.XemBaoCao;
        }

        private void btnLuuQuyen_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null || dgvTaiKhoan.CurrentRow.Tag == null) return;

            var maTaiKhoan = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Tag);
            var item = _items.First(x => x.MaTaiKhoan == maTaiKhoan);
            item.VaiTro = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells[2].Value) ?? item.VaiTro;
            item.TrangThai = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells[3].Value) ?? item.TrangThai;
            item.XemDuLieu = chkXemDuLieu.Checked;
            item.ThemSuaXoa = chkThemSuaXoa.Checked;
            item.QuanLyTaiKhoan = chkQuanLyTaiKhoan.Checked;
            item.XemBaoCao = chkXemBaoCao.Checked;

            _service.LuuTaiKhoanVaPhanQuyen(item);
            MessageBox.Show("Đã lưu quản lý tài khoản và phân quyền.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NapDanhSach();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NapDanhSach();
        }
    }
}
