namespace SunriseLibrary.Forms
{
    partial class frmTraCuuTaiLieu
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
            this.grpDieuKienTimKiem = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaTaiLieu = new System.Windows.Forms.TextBox();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblMaTaiLieu = new System.Windows.Forms.Label();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.grpKetQuaTraCuu = new System.Windows.Forms.GroupBox();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.grpThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.btnDatMuon = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.lblTaiLieuSoValue = new System.Windows.Forms.Label();
            this.lblViTriKhoValue = new System.Windows.Forms.Label();
            this.lblTheLoaiValue = new System.Windows.Forms.Label();
            this.lblNhaXuatBanValue = new System.Windows.Forms.Label();
            this.lblTacGiaValue = new System.Windows.Forms.Label();
            this.lblNhanDeValue = new System.Windows.Forms.Label();
            this.lblTaiLieuSo = new System.Windows.Forms.Label();
            this.lblViTriKho = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblTacGiaCT = new System.Windows.Forms.Label();
            this.lblNhanDe = new System.Windows.Forms.Label();
            this.grpDieuKienTimKiem.SuspendLayout();
            this.grpKetQuaTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.grpThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDieuKienTimKiem
            // 
            this.grpDieuKienTimKiem.Controls.Add(this.btnLamMoi);
            this.grpDieuKienTimKiem.Controls.Add(this.btnTimKiem);
            this.grpDieuKienTimKiem.Controls.Add(this.txtMaTaiLieu);
            this.grpDieuKienTimKiem.Controls.Add(this.txtChuDe);
            this.grpDieuKienTimKiem.Controls.Add(this.txtTacGia);
            this.grpDieuKienTimKiem.Controls.Add(this.txtTenSach);
            this.grpDieuKienTimKiem.Controls.Add(this.lblMaTaiLieu);
            this.grpDieuKienTimKiem.Controls.Add(this.lblChuDe);
            this.grpDieuKienTimKiem.Controls.Add(this.lblTacGia);
            this.grpDieuKienTimKiem.Controls.Add(this.lblTenSach);
            this.grpDieuKienTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpDieuKienTimKiem.Location = new System.Drawing.Point(18, 16);
            this.grpDieuKienTimKiem.Name = "grpDieuKienTimKiem";
            this.grpDieuKienTimKiem.Size = new System.Drawing.Size(888, 108);
            this.grpDieuKienTimKiem.TabIndex = 0;
            this.grpDieuKienTimKiem.TabStop = false;
            this.grpDieuKienTimKiem.Text = "Điều kiện tìm kiếm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(686, 62);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 32);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(686, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 32);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaTaiLieu
            // 
            this.txtMaTaiLieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaTaiLieu.Location = new System.Drawing.Point(481, 67);
            this.txtMaTaiLieu.Name = "txtMaTaiLieu";
            this.txtMaTaiLieu.Size = new System.Drawing.Size(162, 35);
            this.txtMaTaiLieu.TabIndex = 7;
            // 
            // txtChuDe
            // 
            this.txtChuDe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtChuDe.Location = new System.Drawing.Point(481, 26);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.Size = new System.Drawing.Size(162, 35);
            this.txtChuDe.TabIndex = 6;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTacGia.Location = new System.Drawing.Point(121, 66);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(182, 35);
            this.txtTacGia.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenSach.Location = new System.Drawing.Point(121, 28);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(182, 35);
            this.txtTenSach.TabIndex = 4;
            // 
            // lblMaTaiLieu
            // 
            this.lblMaTaiLieu.AutoSize = true;
            this.lblMaTaiLieu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblMaTaiLieu.Location = new System.Drawing.Point(360, 69);
            this.lblMaTaiLieu.Name = "lblMaTaiLieu";
            this.lblMaTaiLieu.Size = new System.Drawing.Size(115, 27);
            this.lblMaTaiLieu.TabIndex = 3;
            this.lblMaTaiLieu.Text = "Mã tài liệu";
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblChuDe.Location = new System.Drawing.Point(360, 31);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(81, 27);
            this.lblChuDe.TabIndex = 2;
            this.lblChuDe.Text = "Chủ đề";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTacGia.Location = new System.Drawing.Point(20, 69);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(82, 27);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "Tác giả";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTenSach.Location = new System.Drawing.Point(20, 31);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(98, 27);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách";
            // 
            // grpKetQuaTraCuu
            // 
            this.grpKetQuaTraCuu.Controls.Add(this.dgvKetQua);
            this.grpKetQuaTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpKetQuaTraCuu.Location = new System.Drawing.Point(18, 140);
            this.grpKetQuaTraCuu.Name = "grpKetQuaTraCuu";
            this.grpKetQuaTraCuu.Size = new System.Drawing.Size(530, 388);
            this.grpKetQuaTraCuu.TabIndex = 1;
            this.grpKetQuaTraCuu.TabStop = false;
            this.grpKetQuaTraCuu.Text = "Kết quả tra cứu";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(18, 28);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.RowTemplate.Height = 25;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(495, 340);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellClick);
            // 
            // grpThongTinChiTiet
            // 
            this.grpThongTinChiTiet.Controls.Add(this.btnDatMuon);
            this.grpThongTinChiTiet.Controls.Add(this.btnXemChiTiet);
            this.grpThongTinChiTiet.Controls.Add(this.lblTaiLieuSoValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblViTriKhoValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblTheLoaiValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblNhaXuatBanValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblTacGiaValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblNhanDeValue);
            this.grpThongTinChiTiet.Controls.Add(this.lblTaiLieuSo);
            this.grpThongTinChiTiet.Controls.Add(this.lblViTriKho);
            this.grpThongTinChiTiet.Controls.Add(this.lblTheLoai);
            this.grpThongTinChiTiet.Controls.Add(this.lblNhaXuatBan);
            this.grpThongTinChiTiet.Controls.Add(this.lblTacGiaCT);
            this.grpThongTinChiTiet.Controls.Add(this.lblNhanDe);
            this.grpThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpThongTinChiTiet.Location = new System.Drawing.Point(567, 140);
            this.grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            this.grpThongTinChiTiet.Size = new System.Drawing.Size(339, 388);
            this.grpThongTinChiTiet.TabIndex = 2;
            this.grpThongTinChiTiet.TabStop = false;
            this.grpThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnDatMuon
            // 
            this.btnDatMuon.Location = new System.Drawing.Point(176, 311);
            this.btnDatMuon.Name = "btnDatMuon";
            this.btnDatMuon.Size = new System.Drawing.Size(143, 34);
            this.btnDatMuon.TabIndex = 13;
            this.btnDatMuon.Text = "Đặt mượn";
            this.btnDatMuon.UseVisualStyleBackColor = true;
            this.btnDatMuon.Click += new System.EventHandler(this.btnDatMuon_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(26, 311);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(144, 34);
            this.btnXemChiTiet.TabIndex = 12;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // lblTaiLieuSoValue
            // 
            this.lblTaiLieuSoValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaiLieuSoValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTaiLieuSoValue.Location = new System.Drawing.Point(151, 243);
            this.lblTaiLieuSoValue.Name = "lblTaiLieuSoValue";
            this.lblTaiLieuSoValue.Size = new System.Drawing.Size(168, 26);
            this.lblTaiLieuSoValue.TabIndex = 11;
            // 
            // lblViTriKhoValue
            // 
            this.lblViTriKhoValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViTriKhoValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblViTriKhoValue.Location = new System.Drawing.Point(151, 201);
            this.lblViTriKhoValue.Name = "lblViTriKhoValue";
            this.lblViTriKhoValue.Size = new System.Drawing.Size(168, 26);
            this.lblViTriKhoValue.TabIndex = 10;
            // 
            // lblTheLoaiValue
            // 
            this.lblTheLoaiValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTheLoaiValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTheLoaiValue.Location = new System.Drawing.Point(151, 155);
            this.lblTheLoaiValue.Name = "lblTheLoaiValue";
            this.lblTheLoaiValue.Size = new System.Drawing.Size(168, 26);
            this.lblTheLoaiValue.TabIndex = 9;
            // 
            // lblNhaXuatBanValue
            // 
            this.lblNhaXuatBanValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhaXuatBanValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNhaXuatBanValue.Location = new System.Drawing.Point(151, 114);
            this.lblNhaXuatBanValue.Name = "lblNhaXuatBanValue";
            this.lblNhaXuatBanValue.Size = new System.Drawing.Size(168, 26);
            this.lblNhaXuatBanValue.TabIndex = 8;
            // 
            // lblTacGiaValue
            // 
            this.lblTacGiaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTacGiaValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTacGiaValue.Location = new System.Drawing.Point(151, 67);
            this.lblTacGiaValue.Name = "lblTacGiaValue";
            this.lblTacGiaValue.Size = new System.Drawing.Size(168, 26);
            this.lblTacGiaValue.TabIndex = 7;
            this.lblTacGiaValue.Click += new System.EventHandler(this.lblTacGiaValue_Click);
            // 
            // lblNhanDeValue
            // 
            this.lblNhanDeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNhanDeValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNhanDeValue.Location = new System.Drawing.Point(151, 28);
            this.lblNhanDeValue.Name = "lblNhanDeValue";
            this.lblNhanDeValue.Size = new System.Drawing.Size(168, 26);
            this.lblNhanDeValue.TabIndex = 6;
            // 
            // lblTaiLieuSo
            // 
            this.lblTaiLieuSo.AutoSize = true;
            this.lblTaiLieuSo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTaiLieuSo.Location = new System.Drawing.Point(6, 244);
            this.lblTaiLieuSo.Name = "lblTaiLieuSo";
            this.lblTaiLieuSo.Size = new System.Drawing.Size(117, 27);
            this.lblTaiLieuSo.TabIndex = 5;
            this.lblTaiLieuSo.Text = "Tài liệu số:";
            // 
            // lblViTriKho
            // 
            this.lblViTriKho.AutoSize = true;
            this.lblViTriKho.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblViTriKho.Location = new System.Drawing.Point(6, 201);
            this.lblViTriKho.Name = "lblViTriKho";
            this.lblViTriKho.Size = new System.Drawing.Size(109, 27);
            this.lblViTriKho.TabIndex = 4;
            this.lblViTriKho.Text = "Vị trí kho:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTheLoai.Location = new System.Drawing.Point(6, 156);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(96, 27);
            this.lblTheLoai.TabIndex = 3;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNhaXuatBan.Location = new System.Drawing.Point(6, 113);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(147, 27);
            this.lblNhaXuatBan.TabIndex = 2;
            this.lblNhaXuatBan.Text = "Nhà xuất bản:";
            // 
            // lblTacGiaCT
            // 
            this.lblTacGiaCT.AutoSize = true;
            this.lblTacGiaCT.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTacGiaCT.Location = new System.Drawing.Point(6, 68);
            this.lblTacGiaCT.Name = "lblTacGiaCT";
            this.lblTacGiaCT.Size = new System.Drawing.Size(88, 27);
            this.lblTacGiaCT.TabIndex = 1;
            this.lblTacGiaCT.Text = "Tác giả:";
            this.lblTacGiaCT.Click += new System.EventHandler(this.lblTacGiaCT_Click);
            // 
            // lblNhanDe
            // 
            this.lblNhanDe.AutoSize = true;
            this.lblNhanDe.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNhanDe.Location = new System.Drawing.Point(6, 31);
            this.lblNhanDe.Name = "lblNhanDe";
            this.lblNhanDe.Size = new System.Drawing.Size(99, 27);
            this.lblNhanDe.TabIndex = 0;
            this.lblNhanDe.Text = "Nhan đề:";
            // 
            // frmTraCuuTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 548);
            this.Controls.Add(this.grpThongTinChiTiet);
            this.Controls.Add(this.grpKetQuaTraCuu);
            this.Controls.Add(this.grpDieuKienTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuTaiLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraCuuTaiLieu - Tra cứu && xem tình trạng sách";
            this.Load += new System.EventHandler(this.frmTraCuuTaiLieu_Load);
            this.grpDieuKienTimKiem.ResumeLayout(false);
            this.grpDieuKienTimKiem.PerformLayout();
            this.grpKetQuaTraCuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.grpThongTinChiTiet.ResumeLayout(false);
            this.grpThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpDieuKienTimKiem;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblChuDe;
        private System.Windows.Forms.Label lblMaTaiLieu;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtChuDe;
        private System.Windows.Forms.TextBox txtMaTaiLieu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpKetQuaTraCuu;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.GroupBox grpThongTinChiTiet;
        private System.Windows.Forms.Label lblNhanDe;
        private System.Windows.Forms.Label lblTacGiaCT;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblViTriKho;
        private System.Windows.Forms.Label lblTaiLieuSo;
        private System.Windows.Forms.Label lblNhanDeValue;
        private System.Windows.Forms.Label lblTacGiaValue;
        private System.Windows.Forms.Label lblNhaXuatBanValue;
        private System.Windows.Forms.Label lblTheLoaiValue;
        private System.Windows.Forms.Label lblViTriKhoValue;
        private System.Windows.Forms.Label lblTaiLieuSoValue;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnDatMuon;
    }
}
