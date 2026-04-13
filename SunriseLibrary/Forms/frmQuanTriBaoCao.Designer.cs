namespace SunriseLibrary.Forms
{
    partial class frmQuanTriBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvChiTieu = new System.Windows.Forms.DataGridView();
            this.colChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.txtLoaiBaoCao = new System.Windows.Forms.TextBox();
            this.txtDenNgay = new System.Windows.Forms.TextBox();
            this.txtTuNgay = new System.Windows.Forms.TextBox();
            this.lblLoaiBaoCao = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.grpQuanLyQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.grpBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
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
            this.grpQuanLyQuyen.Location = new System.Drawing.Point(12, 9);
            this.grpQuanLyQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuanLyQuyen.Name = "grpQuanLyQuyen";
            this.grpQuanLyQuyen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpQuanLyQuyen.Size = new System.Drawing.Size(616, 593);
            this.grpQuanLyQuyen.TabIndex = 0;
            this.grpQuanLyQuyen.TabStop = false;
            this.grpQuanLyQuyen.Text = "Quản lý tài khoản / phân quyền";
            this.grpQuanLyQuyen.Enter += new System.EventHandler(this.grpQuanLyQuyen_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(500, 523);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 34);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuQuyen
            // 
            this.btnLuuQuyen.Location = new System.Drawing.Point(382, 523);
            this.btnLuuQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuQuyen.Name = "btnLuuQuyen";
            this.btnLuuQuyen.Size = new System.Drawing.Size(100, 34);
            this.btnLuuQuyen.TabIndex = 5;
            this.btnLuuQuyen.Text = "Lưu quyền";
            this.btnLuuQuyen.UseVisualStyleBackColor = true;
            this.btnLuuQuyen.Click += new System.EventHandler(this.btnLuuQuyen_Click);
            // 
            // chkXemBaoCao
            // 
            this.chkXemBaoCao.AutoSize = true;
            this.chkXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkXemBaoCao.Location = new System.Drawing.Point(28, 376);
            this.chkXemBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.chkQuanLyTaiKhoan.Location = new System.Drawing.Point(28, 347);
            this.chkQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.chkThemSuaXoa.Location = new System.Drawing.Point(28, 317);
            this.chkThemSuaXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkThemSuaXoa.Name = "chkThemSuaXoa";
            this.chkThemSuaXoa.Size = new System.Drawing.Size(207, 31);
            this.chkThemSuaXoa.TabIndex = 2;
            this.chkThemSuaXoa.Text = "Thêm / Sửa / Xóa";
            this.chkThemSuaXoa.UseVisualStyleBackColor = true;
            // 
            // chkXemDuLieu
            // 
            this.chkXemDuLieu.AutoSize = true;
            this.chkXemDuLieu.Checked = true;
            this.chkXemDuLieu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXemDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkXemDuLieu.Location = new System.Drawing.Point(28, 287);
            this.chkXemDuLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkXemDuLieu.Name = "chkXemDuLieu";
            this.chkXemDuLieu.Size = new System.Drawing.Size(156, 31);
            this.chkXemDuLieu.TabIndex = 1;
            this.chkXemDuLieu.Text = "Xem dữ liệu";
            this.chkXemDuLieu.UseVisualStyleBackColor = true;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colHoTen,
            this.colVaiTro,
            this.colTrangThai});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(28, 47);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(560, 236);
            this.dgvTaiKhoan.TabIndex = 0;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.MinimumWidth = 8;
            this.colUser.Name = "colUser";
            this.colUser.Width = 110;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 8;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colVaiTro
            // 
            this.colVaiTro.HeaderText = "Vai trò";
            this.colVaiTro.MinimumWidth = 8;
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.Width = 120;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 120;
            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Controls.Add(this.dgvChiTieu);
            this.grpBaoCao.Controls.Add(this.pnlBieuDo);
            this.grpBaoCao.Controls.Add(this.btnXemBaoCao);
            this.grpBaoCao.Controls.Add(this.txtLoaiBaoCao);
            this.grpBaoCao.Controls.Add(this.txtDenNgay);
            this.grpBaoCao.Controls.Add(this.txtTuNgay);
            this.grpBaoCao.Controls.Add(this.lblLoaiBaoCao);
            this.grpBaoCao.Controls.Add(this.lblDenNgay);
            this.grpBaoCao.Controls.Add(this.lblTuNgay);
            this.grpBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpBaoCao.Location = new System.Drawing.Point(650, 11);
            this.grpBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBaoCao.Size = new System.Drawing.Size(693, 705);
            this.grpBaoCao.TabIndex = 1;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = "Báo cáo thống kê";
            this.grpBaoCao.Enter += new System.EventHandler(this.grpBaoCao_Enter);
            // 
            // dgvChiTieu
            // 
            this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChiTieu,
            this.colGiaTri});
            this.dgvChiTieu.Location = new System.Drawing.Point(19, 508);
            this.dgvChiTieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTieu.Name = "dgvChiTieu";
            this.dgvChiTieu.RowHeadersWidth = 62;
            this.dgvChiTieu.RowTemplate.Height = 28;
            this.dgvChiTieu.Size = new System.Drawing.Size(566, 165);
            this.dgvChiTieu.TabIndex = 8;
            this.dgvChiTieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieu_CellContentClick);
            // 
            // colChiTieu
            // 
            this.colChiTieu.HeaderText = "Chỉ tiêu";
            this.colChiTieu.MinimumWidth = 8;
            this.colChiTieu.Name = "colChiTieu";
            this.colChiTieu.Width = 220;
            // 
            // colGiaTri
            // 
            this.colGiaTri.HeaderText = "Giá trị";
            this.colGiaTri.MinimumWidth = 8;
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.Width = 130;
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBieuDo.Location = new System.Drawing.Point(19, 164);
            this.pnlBieuDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(566, 323);
            this.pnlBieuDo.TabIndex = 7;
            this.pnlBieuDo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBieuDo_Paint);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(315, 96);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(86, 40);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "Xem";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // txtLoaiBaoCao
            // 
            this.txtLoaiBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLoaiBaoCao.Location = new System.Drawing.Point(156, 96);
            this.txtLoaiBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiBaoCao.Name = "txtLoaiBaoCao";
            this.txtLoaiBaoCao.Size = new System.Drawing.Size(129, 35);
            this.txtLoaiBaoCao.TabIndex = 5;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDenNgay.Location = new System.Drawing.Point(156, 64);
            this.txtDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(129, 35);
            this.txtDenNgay.TabIndex = 3;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTuNgay.Location = new System.Drawing.Point(156, 31);
            this.txtTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(129, 35);
            this.txtTuNgay.TabIndex = 1;
            // 
            // lblLoaiBaoCao
            // 
            this.lblLoaiBaoCao.AutoSize = true;
            this.lblLoaiBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoaiBaoCao.Location = new System.Drawing.Point(16, 97);
            this.lblLoaiBaoCao.Name = "lblLoaiBaoCao";
            this.lblLoaiBaoCao.Size = new System.Drawing.Size(137, 27);
            this.lblLoaiBaoCao.TabIndex = 4;
            this.lblLoaiBaoCao.Text = "Loại báo cáo";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDenNgay.Location = new System.Drawing.Point(14, 65);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(104, 27);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTuNgay.Location = new System.Drawing.Point(14, 32);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(91, 27);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // frmQuanTriBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 740);
            this.Controls.Add(this.grpBaoCao);
            this.Controls.Add(this.grpQuanLyQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanTriBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanTriBaoCao - Quản trị hệ thống & báo cáo";
            this.Load += new System.EventHandler(this.frmQuanTriBaoCao_Load);
            this.grpQuanLyQuyen.ResumeLayout(false);
            this.grpQuanLyQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.grpBaoCao.ResumeLayout(false);
            this.grpBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.TextBox txtLoaiBaoCao;
        private System.Windows.Forms.TextBox txtDenNgay;
        private System.Windows.Forms.TextBox txtTuNgay;
        private System.Windows.Forms.Label lblLoaiBaoCao;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
    }
}
