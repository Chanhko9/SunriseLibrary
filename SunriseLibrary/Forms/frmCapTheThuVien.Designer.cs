namespace SunriseLibrary.Forms
{
    partial class frmCapTheThuVien
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
            this.grpDongBo = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnNapDuLieu = new System.Windows.Forms.Button();
            this.lblTrangThaiDongBo = new System.Windows.Forms.Label();
            this.lblNguonDuLieu = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapMaThe = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.dtpNgayKichHoat = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiThe = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblNgayKichHoat = new System.Windows.Forms.Label();
            this.lblLoaiThe = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.grpDongBo.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDongBo
            // 
            this.grpDongBo.Controls.Add(this.btnLoc);
            this.grpDongBo.Controls.Add(this.btnNapDuLieu);
            this.grpDongBo.Controls.Add(this.lblTrangThaiDongBo);
            this.grpDongBo.Controls.Add(this.lblNguonDuLieu);
            this.grpDongBo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpDongBo.Location = new System.Drawing.Point(26, 20);
            this.grpDongBo.Name = "grpDongBo";
            this.grpDongBo.Size = new System.Drawing.Size(930, 102);
            this.grpDongBo.TabIndex = 0;
            this.grpDongBo.TabStop = false;
            this.grpDongBo.Text = "Đồng bộ dữ liệu sinh viên";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(834, 44);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 34);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnNapDuLieu
            // 
            this.btnNapDuLieu.Location = new System.Drawing.Point(672, 44);
            this.btnNapDuLieu.Name = "btnNapDuLieu";
            this.btnNapDuLieu.Size = new System.Drawing.Size(152, 34);
            this.btnNapDuLieu.TabIndex = 2;
            this.btnNapDuLieu.Text = "Nạp dữ liệu";
            this.btnNapDuLieu.UseVisualStyleBackColor = true;
            this.btnNapDuLieu.Click += new System.EventHandler(this.btnNapDuLieu_Click);
            // 
            // lblTrangThaiDongBo
            // 
            this.lblTrangThaiDongBo.AutoSize = true;
            this.lblTrangThaiDongBo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTrangThaiDongBo.Location = new System.Drawing.Point(338, 48);
            this.lblTrangThaiDongBo.Name = "lblTrangThaiDongBo";
            this.lblTrangThaiDongBo.Size = new System.Drawing.Size(285, 27);
            this.lblTrangThaiDongBo.TabIndex = 1;
            this.lblTrangThaiDongBo.Text = "Trạng thái đồng bộ: Đã nhận";
            // 
            // lblNguonDuLieu
            // 
            this.lblNguonDuLieu.AutoSize = true;
            this.lblNguonDuLieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNguonDuLieu.Location = new System.Drawing.Point(20, 48);
            this.lblNguonDuLieu.Name = "lblNguonDuLieu";
            this.lblNguonDuLieu.Size = new System.Drawing.Size(303, 27);
            this.lblNguonDuLieu.TabIndex = 0;
            this.lblNguonDuLieu.Text = "Nguồn dữ liệu: Phòng Đào tạo";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvSinhVien);
            this.grpDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(26, 140);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(470, 386);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách sinh viên chờ cấp thẻ";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(14, 34);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 20;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(442, 334);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnLuu);
            this.grpThongTin.Controls.Add(this.btnCapMaThe);
            this.grpThongTin.Controls.Add(this.btnTaoTaiKhoan);
            this.grpThongTin.Controls.Add(this.dtpNgayKichHoat);
            this.grpThongTin.Controls.Add(this.cboLoaiThe);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.txtMSSV);
            this.grpThongTin.Controls.Add(this.lblNgayKichHoat);
            this.grpThongTin.Controls.Add(this.lblLoaiThe);
            this.grpThongTin.Controls.Add(this.lblSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.lblMSSV);
            this.grpThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(495, 140);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(430, 386);
            this.grpThongTin.TabIndex = 2;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin cấp thẻ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(322, 323);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 36);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapMaThe
            // 
            this.btnCapMaThe.Location = new System.Drawing.Point(174, 323);
            this.btnCapMaThe.Name = "btnCapMaThe";
            this.btnCapMaThe.Size = new System.Drawing.Size(138, 36);
            this.btnCapMaThe.TabIndex = 15;
            this.btnCapMaThe.Text = "Cấp mã thẻ";
            this.btnCapMaThe.UseVisualStyleBackColor = true;
            this.btnCapMaThe.Click += new System.EventHandler(this.btnCapMaThe_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(7, 323);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(161, 36);
            this.btnTaoTaiKhoan.TabIndex = 14;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // dtpNgayKichHoat
            // 
            this.dtpNgayKichHoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpNgayKichHoat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKichHoat.Location = new System.Drawing.Point(189, 250);
            this.dtpNgayKichHoat.Name = "dtpNgayKichHoat";
            this.dtpNgayKichHoat.Size = new System.Drawing.Size(231, 35);
            this.dtpNgayKichHoat.TabIndex = 13;
            // 
            // cboLoaiThe
            // 
            this.cboLoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboLoaiThe.FormattingEnabled = true;
            this.cboLoaiThe.Items.AddRange(new object[] {
            "SinhVien",
            "GiangVien",
            "NoiBo"});
            this.cboLoaiThe.Location = new System.Drawing.Point(189, 209);
            this.cboLoaiThe.Name = "cboLoaiThe";
            this.cboLoaiThe.Size = new System.Drawing.Size(231, 35);
            this.cboLoaiThe.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(189, 92);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(231, 35);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(189, 168);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(231, 35);
            this.txtSoDienThoai.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEmail.Location = new System.Drawing.Point(189, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 35);
            this.txtEmail.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(189, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(231, 35);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMSSV.Location = new System.Drawing.Point(189, 22);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(231, 35);
            this.txtMSSV.TabIndex = 7;
            // 
            // lblNgayKichHoat
            // 
            this.lblNgayKichHoat.AutoSize = true;
            this.lblNgayKichHoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNgayKichHoat.Location = new System.Drawing.Point(23, 254);
            this.lblNgayKichHoat.Name = "lblNgayKichHoat";
            this.lblNgayKichHoat.Size = new System.Drawing.Size(164, 27);
            this.lblNgayKichHoat.TabIndex = 6;
            this.lblNgayKichHoat.Text = "Ngày kích hoạt:";
            // 
            // lblLoaiThe
            // 
            this.lblLoaiThe.AutoSize = true;
            this.lblLoaiThe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoaiThe.Location = new System.Drawing.Point(23, 212);
            this.lblLoaiThe.Name = "lblLoaiThe";
            this.lblLoaiThe.Size = new System.Drawing.Size(98, 27);
            this.lblLoaiThe.TabIndex = 5;
            this.lblLoaiThe.Text = "Loại thẻ:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSoDienThoai.Location = new System.Drawing.Point(23, 171);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(143, 27);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblEmail.Location = new System.Drawing.Point(23, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 27);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNgaySinh.Location = new System.Drawing.Point(23, 96);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(114, 27);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblHoTen.Location = new System.Drawing.Point(23, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(83, 27);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMSSV.Location = new System.Drawing.Point(23, 30);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(77, 27);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // frmCapTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 552);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpDongBo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapTheThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCấpThẻThưViện - Cấp thẻ cho sinh viên mới";
            this.Load += new System.EventHandler(this.frmCapTheThuVien_Load);
            this.grpDongBo.ResumeLayout(false);
            this.grpDongBo.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpDongBo;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.Label lblTrangThaiDongBo;
        private System.Windows.Forms.Label lblNguonDuLieu;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapMaThe;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.DateTimePicker dtpNgayKichHoat;
        private System.Windows.Forms.ComboBox cboLoaiThe;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblNgayKichHoat;
        private System.Windows.Forms.Label lblLoaiThe;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
