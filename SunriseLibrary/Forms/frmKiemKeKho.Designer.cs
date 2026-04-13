namespace SunriseLibrary.Forms
{
    partial class frmKiemKeKho
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
            this.grpDotKiemKe = new System.Windows.Forms.GroupBox();
            this.btnTaoDot = new System.Windows.Forms.Button();
            this.txtNguoiPhuTrach = new System.Windows.Forms.TextBox();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtMaDot = new System.Windows.Forms.TextBox();
            this.lblNguoiPhuTrach = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblKho = new System.Windows.Forms.Label();
            this.lblMaDot = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDoiSoat = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTHeThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChenhLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXuLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTongHop = new System.Windows.Forms.GroupBox();
            this.btnKetThucDot = new System.Windows.Forms.Button();
            this.btnXuatBienBan = new System.Windows.Forms.Button();
            this.btnNhapKetQua = new System.Windows.Forms.Button();
            this.txtSaiViTri = new System.Windows.Forms.TextBox();
            this.txtDu = new System.Windows.Forms.TextBox();
            this.txtThieu = new System.Windows.Forms.TextBox();
            this.txtDaKiem = new System.Windows.Forms.TextBox();
            this.txtTongDauSach = new System.Windows.Forms.TextBox();
            this.lblSaiViTri = new System.Windows.Forms.Label();
            this.lblDu = new System.Windows.Forms.Label();
            this.lblThieu = new System.Windows.Forms.Label();
            this.lblDaKiem = new System.Windows.Forms.Label();
            this.lblTongDauSach = new System.Windows.Forms.Label();
            this.grpDotKiemKe.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiSoat)).BeginInit();
            this.grpTongHop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDotKiemKe
            // 
            this.grpDotKiemKe.Controls.Add(this.btnTaoDot);
            this.grpDotKiemKe.Controls.Add(this.txtNguoiPhuTrach);
            this.grpDotKiemKe.Controls.Add(this.txtNgayBatDau);
            this.grpDotKiemKe.Controls.Add(this.txtKho);
            this.grpDotKiemKe.Controls.Add(this.txtMaDot);
            this.grpDotKiemKe.Controls.Add(this.lblNguoiPhuTrach);
            this.grpDotKiemKe.Controls.Add(this.lblNgayBatDau);
            this.grpDotKiemKe.Controls.Add(this.lblKho);
            this.grpDotKiemKe.Controls.Add(this.lblMaDot);
            this.grpDotKiemKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpDotKiemKe.Location = new System.Drawing.Point(14, 10);
            this.grpDotKiemKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDotKiemKe.Name = "grpDotKiemKe";
            this.grpDotKiemKe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDotKiemKe.Size = new System.Drawing.Size(949, 102);
            this.grpDotKiemKe.TabIndex = 0;
            this.grpDotKiemKe.TabStop = false;
            this.grpDotKiemKe.Text = "Đợt kiểm kê";
            this.grpDotKiemKe.Enter += new System.EventHandler(this.grpDotKiemKe_Enter);
            // 
            // btnTaoDot
            // 
            this.btnTaoDot.Location = new System.Drawing.Point(786, 30);
            this.btnTaoDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDot.Name = "btnTaoDot";
            this.btnTaoDot.Size = new System.Drawing.Size(126, 50);
            this.btnTaoDot.TabIndex = 8;
            this.btnTaoDot.Text = "Tạo đợt";
            this.btnTaoDot.UseVisualStyleBackColor = true;
            this.btnTaoDot.Click += new System.EventHandler(this.btnTaoDot_Click);
            // 
            // txtNguoiPhuTrach
            // 
            this.txtNguoiPhuTrach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNguoiPhuTrach.Location = new System.Drawing.Point(560, 61);
            this.txtNguoiPhuTrach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNguoiPhuTrach.Name = "txtNguoiPhuTrach";
            this.txtNguoiPhuTrach.Size = new System.Drawing.Size(199, 35);
            this.txtNguoiPhuTrach.TabIndex = 7;
            this.txtNguoiPhuTrach.TextChanged += new System.EventHandler(this.txtNguoiPhuTrach_TextChanged);
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNgayBatDau.Location = new System.Drawing.Point(560, 28);
            this.txtNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(199, 35);
            this.txtNgayBatDau.TabIndex = 5;
            // 
            // txtKho
            // 
            this.txtKho.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtKho.Location = new System.Drawing.Point(187, 61);
            this.txtKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(176, 35);
            this.txtKho.TabIndex = 3;
            // 
            // txtMaDot
            // 
            this.txtMaDot.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaDot.Location = new System.Drawing.Point(187, 28);
            this.txtMaDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDot.Name = "txtMaDot";
            this.txtMaDot.Size = new System.Drawing.Size(176, 35);
            this.txtMaDot.TabIndex = 1;
            // 
            // lblNguoiPhuTrach
            // 
            this.lblNguoiPhuTrach.AutoSize = true;
            this.lblNguoiPhuTrach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNguoiPhuTrach.Location = new System.Drawing.Point(388, 64);
            this.lblNguoiPhuTrach.Name = "lblNguoiPhuTrach";
            this.lblNguoiPhuTrach.Size = new System.Drawing.Size(175, 27);
            this.lblNguoiPhuTrach.TabIndex = 6;
            this.lblNguoiPhuTrach.Text = "Người phụ trách:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNgayBatDau.Location = new System.Drawing.Point(388, 31);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(146, 27);
            this.lblNgayBatDau.TabIndex = 4;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblKho
            // 
            this.lblKho.AutoSize = true;
            this.lblKho.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblKho.Location = new System.Drawing.Point(93, 64);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(59, 27);
            this.lblKho.TabIndex = 2;
            this.lblKho.Text = "Kho:";
            // 
            // lblMaDot
            // 
            this.lblMaDot.AutoSize = true;
            this.lblMaDot.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaDot.Location = new System.Drawing.Point(93, 31);
            this.lblMaDot.Name = "lblMaDot";
            this.lblMaDot.Size = new System.Drawing.Size(88, 27);
            this.lblMaDot.TabIndex = 0;
            this.lblMaDot.Text = "Mã đợt:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvDoiSoat);
            this.grpDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(14, 124);
            this.grpDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDanhSach.Size = new System.Drawing.Size(684, 407);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách đối soát";
            this.grpDanhSach.Enter += new System.EventHandler(this.grpDanhSach_Enter);
            // 
            // dgvDoiSoat
            // 
            this.dgvDoiSoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiSoat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTTHeThong,
            this.colThucTe,
            this.colChenhLech,
            this.colXuLy});
            this.dgvDoiSoat.Location = new System.Drawing.Point(6, 67);
            this.dgvDoiSoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoiSoat.Name = "dgvDoiSoat";
            this.dgvDoiSoat.RowHeadersWidth = 62;
            this.dgvDoiSoat.RowTemplate.Height = 28;
            this.dgvDoiSoat.Size = new System.Drawing.Size(650, 310);
            this.dgvDoiSoat.TabIndex = 0;
            // 
            // colMaSach
            // 
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 8;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Width = 120;
            // 
            // colTTHeThong
            // 
            this.colTTHeThong.HeaderText = "TT hệ thống";
            this.colTTHeThong.MinimumWidth = 8;
            this.colTTHeThong.Name = "colTTHeThong";
            this.colTTHeThong.Width = 120;
            // 
            // colThucTe
            // 
            this.colThucTe.HeaderText = "Thực tế";
            this.colThucTe.MinimumWidth = 8;
            this.colThucTe.Name = "colThucTe";
            this.colThucTe.Width = 110;
            // 
            // colChenhLech
            // 
            this.colChenhLech.HeaderText = "Chênh lệch";
            this.colChenhLech.MinimumWidth = 8;
            this.colChenhLech.Name = "colChenhLech";
            this.colChenhLech.Width = 120;
            // 
            // colXuLy
            // 
            this.colXuLy.HeaderText = "Xử lý";
            this.colXuLy.MinimumWidth = 8;
            this.colXuLy.Name = "colXuLy";
            this.colXuLy.Width = 120;
            // 
            // grpTongHop
            // 
            this.grpTongHop.Controls.Add(this.btnKetThucDot);
            this.grpTongHop.Controls.Add(this.btnXuatBienBan);
            this.grpTongHop.Controls.Add(this.btnNhapKetQua);
            this.grpTongHop.Controls.Add(this.txtSaiViTri);
            this.grpTongHop.Controls.Add(this.txtDu);
            this.grpTongHop.Controls.Add(this.txtThieu);
            this.grpTongHop.Controls.Add(this.txtDaKiem);
            this.grpTongHop.Controls.Add(this.txtTongDauSach);
            this.grpTongHop.Controls.Add(this.lblSaiViTri);
            this.grpTongHop.Controls.Add(this.lblDu);
            this.grpTongHop.Controls.Add(this.lblThieu);
            this.grpTongHop.Controls.Add(this.lblDaKiem);
            this.grpTongHop.Controls.Add(this.lblTongDauSach);
            this.grpTongHop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpTongHop.Location = new System.Drawing.Point(737, 124);
            this.grpTongHop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTongHop.Name = "grpTongHop";
            this.grpTongHop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTongHop.Size = new System.Drawing.Size(346, 407);
            this.grpTongHop.TabIndex = 2;
            this.grpTongHop.TabStop = false;
            this.grpTongHop.Text = "Tổng hợp";
            this.grpTongHop.Enter += new System.EventHandler(this.grpTongHop_Enter);
            // 
            // btnKetThucDot
            // 
            this.btnKetThucDot.Location = new System.Drawing.Point(25, 332);
            this.btnKetThucDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetThucDot.Name = "btnKetThucDot";
            this.btnKetThucDot.Size = new System.Drawing.Size(283, 47);
            this.btnKetThucDot.TabIndex = 12;
            this.btnKetThucDot.Text = "Kết thúc đợt kiểm kê";
            this.btnKetThucDot.UseVisualStyleBackColor = true;
            this.btnKetThucDot.Click += new System.EventHandler(this.btnKetThucDot_Click);
            // 
            // btnXuatBienBan
            // 
            this.btnXuatBienBan.Location = new System.Drawing.Point(174, 257);
            this.btnXuatBienBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatBienBan.Name = "btnXuatBienBan";
            this.btnXuatBienBan.Size = new System.Drawing.Size(166, 43);
            this.btnXuatBienBan.TabIndex = 11;
            this.btnXuatBienBan.Text = "Xuất biên bản";
            this.btnXuatBienBan.UseVisualStyleBackColor = true;
            this.btnXuatBienBan.Click += new System.EventHandler(this.btnXuatBienBan_Click);
            // 
            // btnNhapKetQua
            // 
            this.btnNhapKetQua.Location = new System.Drawing.Point(6, 257);
            this.btnNhapKetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapKetQua.Name = "btnNhapKetQua";
            this.btnNhapKetQua.Size = new System.Drawing.Size(163, 43);
            this.btnNhapKetQua.TabIndex = 10;
            this.btnNhapKetQua.Text = "Nhập kết quả";
            this.btnNhapKetQua.UseVisualStyleBackColor = true;
            this.btnNhapKetQua.Click += new System.EventHandler(this.btnNhapKetQua_Click);
            // 
            // txtSaiViTri
            // 
            this.txtSaiViTri.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSaiViTri.Location = new System.Drawing.Point(174, 180);
            this.txtSaiViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaiViTri.Name = "txtSaiViTri";
            this.txtSaiViTri.Size = new System.Drawing.Size(148, 35);
            this.txtSaiViTri.TabIndex = 9;
            // 
            // txtDu
            // 
            this.txtDu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDu.Location = new System.Drawing.Point(174, 147);
            this.txtDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDu.Name = "txtDu";
            this.txtDu.Size = new System.Drawing.Size(148, 35);
            this.txtDu.TabIndex = 7;
            // 
            // txtThieu
            // 
            this.txtThieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtThieu.Location = new System.Drawing.Point(174, 115);
            this.txtThieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThieu.Name = "txtThieu";
            this.txtThieu.Size = new System.Drawing.Size(148, 35);
            this.txtThieu.TabIndex = 5;
            // 
            // txtDaKiem
            // 
            this.txtDaKiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDaKiem.Location = new System.Drawing.Point(174, 82);
            this.txtDaKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDaKiem.Name = "txtDaKiem";
            this.txtDaKiem.Size = new System.Drawing.Size(148, 35);
            this.txtDaKiem.TabIndex = 3;
            // 
            // txtTongDauSach
            // 
            this.txtTongDauSach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTongDauSach.Location = new System.Drawing.Point(174, 50);
            this.txtTongDauSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDauSach.Name = "txtTongDauSach";
            this.txtTongDauSach.Size = new System.Drawing.Size(148, 35);
            this.txtTongDauSach.TabIndex = 1;
            this.txtTongDauSach.TextChanged += new System.EventHandler(this.txtTongDauSach_TextChanged);
            // 
            // lblSaiViTri
            // 
            this.lblSaiViTri.AutoSize = true;
            this.lblSaiViTri.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSaiViTri.Location = new System.Drawing.Point(22, 185);
            this.lblSaiViTri.Name = "lblSaiViTri";
            this.lblSaiViTri.Size = new System.Drawing.Size(98, 27);
            this.lblSaiViTri.TabIndex = 8;
            this.lblSaiViTri.Text = "Sai vị trí:";
            // 
            // lblDu
            // 
            this.lblDu.AutoSize = true;
            this.lblDu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDu.Location = new System.Drawing.Point(22, 152);
            this.lblDu.Name = "lblDu";
            this.lblDu.Size = new System.Drawing.Size(48, 27);
            this.lblDu.TabIndex = 6;
            this.lblDu.Text = "Dư:";
            // 
            // lblThieu
            // 
            this.lblThieu.AutoSize = true;
            this.lblThieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblThieu.Location = new System.Drawing.Point(22, 119);
            this.lblThieu.Name = "lblThieu";
            this.lblThieu.Size = new System.Drawing.Size(73, 27);
            this.lblThieu.TabIndex = 4;
            this.lblThieu.Text = "Thiếu:";
            // 
            // lblDaKiem
            // 
            this.lblDaKiem.AutoSize = true;
            this.lblDaKiem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDaKiem.Location = new System.Drawing.Point(22, 86);
            this.lblDaKiem.Name = "lblDaKiem";
            this.lblDaKiem.Size = new System.Drawing.Size(99, 27);
            this.lblDaKiem.TabIndex = 2;
            this.lblDaKiem.Text = "Đã kiểm:";
            // 
            // lblTongDauSach
            // 
            this.lblTongDauSach.AutoSize = true;
            this.lblTongDauSach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTongDauSach.Location = new System.Drawing.Point(22, 53);
            this.lblTongDauSach.Name = "lblTongDauSach";
            this.lblTongDauSach.Size = new System.Drawing.Size(157, 27);
            this.lblTongDauSach.TabIndex = 0;
            this.lblTongDauSach.Text = "Tổng đầu sách:";
            // 
            // frmKiemKeKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 570);
            this.Controls.Add(this.grpTongHop);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpDotKiemKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKiemKeKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKiểmKêKho - Kiểm kê & đối soát dữ liệu";
            this.grpDotKiemKe.ResumeLayout(false);
            this.grpDotKiemKe.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiSoat)).EndInit();
            this.grpTongHop.ResumeLayout(false);
            this.grpTongHop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpDotKiemKe;
        private System.Windows.Forms.Button btnTaoDot;
        private System.Windows.Forms.TextBox txtNguoiPhuTrach;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtMaDot;
        private System.Windows.Forms.Label lblNguoiPhuTrach;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.Label lblMaDot;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvDoiSoat;
        private System.Windows.Forms.GroupBox grpTongHop;
        private System.Windows.Forms.Button btnKetThucDot;
        private System.Windows.Forms.Button btnXuatBienBan;
        private System.Windows.Forms.Button btnNhapKetQua;
        private System.Windows.Forms.TextBox txtSaiViTri;
        private System.Windows.Forms.TextBox txtDu;
        private System.Windows.Forms.TextBox txtThieu;
        private System.Windows.Forms.TextBox txtDaKiem;
        private System.Windows.Forms.TextBox txtTongDauSach;
        private System.Windows.Forms.Label lblSaiViTri;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.Label lblThieu;
        private System.Windows.Forms.Label lblDaKiem;
        private System.Windows.Forms.Label lblTongDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTHeThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChenhLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXuLy;
    }
}
