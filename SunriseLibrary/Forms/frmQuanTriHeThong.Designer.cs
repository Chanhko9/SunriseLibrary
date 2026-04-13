namespace SunriseLibrary.Forms
{
    partial class frmQuanTriHeThong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpQuanLyQuyen = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuQuyen = new System.Windows.Forms.Button();
            this.chkXemBaoCao = new System.Windows.Forms.CheckBox();
            this.chkQuanLyTaiKhoan = new System.Windows.Forms.CheckBox();
            this.chkThemSuaXoa = new System.Windows.Forms.CheckBox();
            this.chkXemDuLieu = new System.Windows.Forms.CheckBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpQuanLyQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpQuanLyQuyen
            // 
            this.grpQuanLyQuyen.Controls.Add(this.btnLamMoi);
            this.grpQuanLyQuyen.Controls.Add(this.btnLuuQuyen);
            this.grpQuanLyQuyen.Controls.Add(this.chkXemBaoCao);
            this.grpQuanLyQuyen.Controls.Add(this.chkQuanLyTaiKhoan);
            this.grpQuanLyQuyen.Controls.Add(this.chkThemSuaXoa);
            this.grpQuanLyQuyen.Controls.Add(this.chkXemDuLieu);
            this.grpQuanLyQuyen.Controls.Add(this.dgvTaiKhoan);
            this.grpQuanLyQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpQuanLyQuyen.Location = new System.Drawing.Point(12, 12);
            this.grpQuanLyQuyen.Name = "grpQuanLyQuyen";
            this.grpQuanLyQuyen.Size = new System.Drawing.Size(887, 569);
            this.grpQuanLyQuyen.TabIndex = 0;
            this.grpQuanLyQuyen.TabStop = false;
            this.grpQuanLyQuyen.Text = "Quản lý tài khoản / phân quyền";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(589, 505);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(129, 40);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Location = new System.Drawing.Point(436, 505);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(135, 40);
            this.btnLuuQuyen.TabIndex = 5;
            this.btnLuuQuyen.Text = "Lưu quyền";
            this.btnLuuQuyen.UseVisualStyleBackColor = true;
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // chkXemBaoCao
            // 
            this.chkXemBaoCao.AutoSize = true;
            this.chkXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkXemBaoCao.Location = new System.Drawing.Point(36, 479);
            this.chkXemBaoCao.Name = "chkXemBaoCao";
            this.chkXemBaoCao.Size = new System.Drawing.Size(165, 31);
            this.chkXemBaoCao.TabIndex = 4;
            this.chkXemBaoCao.Text = "Xem báo cáo";
            this.chkXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // chkQuanLyTaiKhoan
            // 
            this.chkQuanLyTaiKhoan.AutoSize = true;
            this.chkQuanLyTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkQuanLyTaiKhoan.Location = new System.Drawing.Point(36, 442);
            this.chkQuanLyTaiKhoan.Name = "chkQuanLyTaiKhoan";
            this.chkQuanLyTaiKhoan.Size = new System.Drawing.Size(209, 31);
            this.chkQuanLyTaiKhoan.TabIndex = 3;
            this.chkQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.chkQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // chkThemSuaXoa
            // 
            this.chkThemSuaXoa.AutoSize = true;
            this.chkThemSuaXoa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkThemSuaXoa.Location = new System.Drawing.Point(36, 405);
            this.chkThemSuaXoa.Name = "chkThemSuaXoa";
            this.chkThemSuaXoa.Size = new System.Drawing.Size(199, 31);
            this.chkThemSuaXoa.TabIndex = 2;
            this.chkThemSuaXoa.Text = "Thêm / sửa / xóa";
            this.chkThemSuaXoa.UseVisualStyleBackColor = true;
            // 
            // chkXemDuLieu
            // 
            this.chkXemDuLieu.AutoSize = true;
            this.chkXemDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkXemDuLieu.Location = new System.Drawing.Point(36, 368);
            this.chkXemDuLieu.Name = "chkXemDuLieu";
            this.chkXemDuLieu.Size = new System.Drawing.Size(156, 31);
            this.chkXemDuLieu.TabIndex = 1;
            this.chkXemDuLieu.Text = "Xem dữ liệu";
            this.chkXemDuLieu.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colHoTen,
            this.colVaiTro,
            this.colTrangThai});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(24, 42);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(843, 303);
            this.dgvTaiKhoan.TabIndex = 0;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.MinimumWidth = 8;
            this.colUser.Name = "colUser";
            this.colUser.Width = 150;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 220;
            // 
            // colVaiTro
            // 
            this.colVaiTro.HeaderText = "Vai trò";
            this.colVaiTro.MinimumWidth = 8;
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.Width = 160;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 140;
            // 
            // frmQuanTriHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 593);
            this.Controls.Add(this.grpQuanLyQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanTriHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanTriHeThong - Quản trị hệ thống";
            this.grpQuanLyQuyen.ResumeLayout(false);
            this.grpQuanLyQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpQuanLyQuyen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuuQuyen;
        private System.Windows.Forms.CheckBox chkXemBaoCao;
        private System.Windows.Forms.CheckBox chkQuanLyTaiKhoan;
        private System.Windows.Forms.CheckBox chkThemSuaXoa;
        private System.Windows.Forms.CheckBox chkXemDuLieu;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
