namespace SunriseLibrary.Forms
{
    partial class frmDangNhap
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
            this.grpThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkGhiNhoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.rdoQuanTriVien = new System.Windows.Forms.RadioButton();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.rdoBanDoc = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTinDangNhap
            // 
            this.grpThongTinDangNhap.Controls.Add(this.btnThoat);
            this.grpThongTinDangNhap.Controls.Add(this.btnDangNhap);
            this.grpThongTinDangNhap.Controls.Add(this.chkGhiNhoTaiKhoan);
            this.grpThongTinDangNhap.Controls.Add(this.rdoQuanTriVien);
            this.grpThongTinDangNhap.Controls.Add(this.rdoNhanVien);
            this.grpThongTinDangNhap.Controls.Add(this.rdoBanDoc);
            this.grpThongTinDangNhap.Controls.Add(this.txtMatKhau);
            this.grpThongTinDangNhap.Controls.Add(this.txtTenDangNhap);
            this.grpThongTinDangNhap.Controls.Add(this.lblVaiTro);
            this.grpThongTinDangNhap.Controls.Add(this.lblMatKhau);
            this.grpThongTinDangNhap.Controls.Add(this.lblTenDangNhap);
            this.grpThongTinDangNhap.Controls.Add(this.lblTieuDe);
            this.grpThongTinDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTinDangNhap.Location = new System.Drawing.Point(164, 68);
            this.grpThongTinDangNhap.Name = "grpThongTinDangNhap";
            this.grpThongTinDangNhap.Size = new System.Drawing.Size(612, 380);
            this.grpThongTinDangNhap.TabIndex = 0;
            this.grpThongTinDangNhap.TabStop = false;
            this.grpThongTinDangNhap.Text = "Thông tin đăng nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(329, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 38);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(177, 280);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(131, 38);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkGhiNhoTaiKhoan
            // 
            this.chkGhiNhoTaiKhoan.AutoSize = true;
            this.chkGhiNhoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.chkGhiNhoTaiKhoan.Location = new System.Drawing.Point(177, 225);
            this.chkGhiNhoTaiKhoan.Name = "chkGhiNhoTaiKhoan";
            this.chkGhiNhoTaiKhoan.Size = new System.Drawing.Size(211, 31);
            this.chkGhiNhoTaiKhoan.TabIndex = 9;
            this.chkGhiNhoTaiKhoan.Text = "Ghi nhớ tài khoản";
            this.chkGhiNhoTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // rdoQuanTriVien
            // 
            this.rdoQuanTriVien.AutoSize = true;
            this.rdoQuanTriVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rdoQuanTriVien.Location = new System.Drawing.Point(431, 188);
            this.rdoQuanTriVien.Name = "rdoQuanTriVien";
            this.rdoQuanTriVien.Size = new System.Drawing.Size(163, 31);
            this.rdoQuanTriVien.TabIndex = 8;
            this.rdoQuanTriVien.Text = "Quản trị viên";
            this.rdoQuanTriVien.UseVisualStyleBackColor = true;
            // 
            // rdoNhanVien
            // 
            this.rdoNhanVien.AutoSize = true;
            this.rdoNhanVien.Checked = true;
            this.rdoNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rdoNhanVien.Location = new System.Drawing.Point(289, 188);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(136, 31);
            this.rdoNhanVien.TabIndex = 7;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân viên";
            this.rdoNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdoBanDoc
            // 
            this.rdoBanDoc.AutoSize = true;
            this.rdoBanDoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rdoBanDoc.Location = new System.Drawing.Point(166, 188);
            this.rdoBanDoc.Name = "rdoBanDoc";
            this.rdoBanDoc.Size = new System.Drawing.Size(117, 31);
            this.rdoBanDoc.TabIndex = 6;
            this.rdoBanDoc.Text = "Bạn đọc";
            this.rdoBanDoc.UseVisualStyleBackColor = true;
            this.rdoBanDoc.CheckedChanged += new System.EventHandler(this.rdoBanDoc_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(237, 140);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(245, 35);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(237, 98);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(245, 35);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblVaiTro.Location = new System.Drawing.Point(77, 190);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(75, 27);
            this.lblVaiTro.TabIndex = 3;
            this.lblVaiTro.Text = "Vai trò";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMatKhau.Location = new System.Drawing.Point(98, 143);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(104, 27);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTenDangNhap.Location = new System.Drawing.Point(77, 98);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(154, 27);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(50, 37);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(535, 55);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Sunrise-Quản lý thư viện";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(944, 560);
            this.Controls.Add(this.grpThongTinDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmĐăngNhập - Đăng nhập hệ thống";
            this.grpThongTinDangNhap.ResumeLayout(false);
            this.grpThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpThongTinDangNhap;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.RadioButton rdoBanDoc;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private System.Windows.Forms.RadioButton rdoQuanTriVien;
        private System.Windows.Forms.CheckBox chkGhiNhoTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
    }
}
