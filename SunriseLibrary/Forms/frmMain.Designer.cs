namespace SunriseLibrary.Forms
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanTriHeThong = new System.Windows.Forms.Button();
            this.btnBaoCaoThongKe = new System.Windows.Forms.Button();
            this.btnKiemKeKho = new System.Windows.Forms.Button();
            this.btnNhapPhanLoai = new System.Windows.Forms.Button();
            this.btnHoSoBanDoc = new System.Windows.Forms.Button();
            this.btnCapTheThuVien = new System.Windows.Forms.Button();
            this.btnMuonTraSach = new System.Windows.Forms.Button();
            this.btnTraCuuTaiLieu = new System.Windows.Forms.Button();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNgayLamViec = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.grpKhuVucLamViec = new System.Windows.Forms.GroupBox();
            this.btnTileKiemKe = new System.Windows.Forms.Button();
            this.btnTileNhapSach = new System.Windows.Forms.Button();
            this.btnTileHoSo = new System.Windows.Forms.Button();
            this.btnTileCapThe = new System.Windows.Forms.Button();
            this.btnTileMuonTra = new System.Windows.Forms.Button();
            this.btnTileTraCuu = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpKhuVucLamViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnQuanTriHeThong);
            this.pnlMenu.Controls.Add(this.btnBaoCaoThongKe);
            this.pnlMenu.Controls.Add(this.btnKiemKeKho);
            this.pnlMenu.Controls.Add(this.btnNhapPhanLoai);
            this.pnlMenu.Controls.Add(this.btnHoSoBanDoc);
            this.pnlMenu.Controls.Add(this.btnCapTheThuVien);
            this.pnlMenu.Controls.Add(this.btnMuonTraSach);
            this.pnlMenu.Controls.Add(this.btnTraCuuTaiLieu);
            this.pnlMenu.Controls.Add(this.lblDanhMuc);
            this.pnlMenu.Location = new System.Drawing.Point(24, 50);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 470);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(29, 375);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(160, 34);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanTriHeThong
            // 
            this.btnQuanTriHeThong.Location = new System.Drawing.Point(29, 335);
            this.btnQuanTriHeThong.Name = "btnQuanTriHeThong";
            this.btnQuanTriHeThong.Size = new System.Drawing.Size(167, 34);
            this.btnQuanTriHeThong.TabIndex = 8;
            this.btnQuanTriHeThong.Text = "Quản trị hệ thống";
            this.btnQuanTriHeThong.UseVisualStyleBackColor = true;
            this.btnQuanTriHeThong.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.Location = new System.Drawing.Point(29, 295);
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.Size = new System.Drawing.Size(160, 34);
            this.btnBaoCaoThongKe.TabIndex = 7;
            this.btnBaoCaoThongKe.Text = "Báo cáo thống kê";
            this.btnBaoCaoThongKe.UseVisualStyleBackColor = true;
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnKiemKeKho
            // 
            this.btnKiemKeKho.Location = new System.Drawing.Point(29, 255);
            this.btnKiemKeKho.Name = "btnKiemKeKho";
            this.btnKiemKeKho.Size = new System.Drawing.Size(160, 34);
            this.btnKiemKeKho.TabIndex = 6;
            this.btnKiemKeKho.Text = "Kiểm kê kho";
            this.btnKiemKeKho.UseVisualStyleBackColor = true;
            this.btnKiemKeKho.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnNhapPhanLoai
            // 
            this.btnNhapPhanLoai.Location = new System.Drawing.Point(29, 215);
            this.btnNhapPhanLoai.Name = "btnNhapPhanLoai";
            this.btnNhapPhanLoai.Size = new System.Drawing.Size(160, 34);
            this.btnNhapPhanLoai.TabIndex = 5;
            this.btnNhapPhanLoai.Text = "Nhập && phân loại";
            this.btnNhapPhanLoai.UseVisualStyleBackColor = true;
            this.btnNhapPhanLoai.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnHoSoBanDoc
            // 
            this.btnHoSoBanDoc.Location = new System.Drawing.Point(29, 175);
            this.btnHoSoBanDoc.Name = "btnHoSoBanDoc";
            this.btnHoSoBanDoc.Size = new System.Drawing.Size(160, 34);
            this.btnHoSoBanDoc.TabIndex = 4;
            this.btnHoSoBanDoc.Text = "Hồ sơ bạn đọc";
            this.btnHoSoBanDoc.UseVisualStyleBackColor = true;
            this.btnHoSoBanDoc.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnCapTheThuVien
            // 
            this.btnCapTheThuVien.Location = new System.Drawing.Point(29, 135);
            this.btnCapTheThuVien.Name = "btnCapTheThuVien";
            this.btnCapTheThuVien.Size = new System.Drawing.Size(160, 34);
            this.btnCapTheThuVien.TabIndex = 3;
            this.btnCapTheThuVien.Text = "Cấp thẻ thư viện";
            this.btnCapTheThuVien.UseVisualStyleBackColor = true;
            this.btnCapTheThuVien.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnMuonTraSach
            // 
            this.btnMuonTraSach.Location = new System.Drawing.Point(29, 95);
            this.btnMuonTraSach.Name = "btnMuonTraSach";
            this.btnMuonTraSach.Size = new System.Drawing.Size(160, 34);
            this.btnMuonTraSach.TabIndex = 2;
            this.btnMuonTraSach.Text = "Mượn / Trả sách";
            this.btnMuonTraSach.UseVisualStyleBackColor = true;
            this.btnMuonTraSach.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTraCuuTaiLieu
            // 
            this.btnTraCuuTaiLieu.Location = new System.Drawing.Point(29, 55);
            this.btnTraCuuTaiLieu.Name = "btnTraCuuTaiLieu";
            this.btnTraCuuTaiLieu.Size = new System.Drawing.Size(160, 34);
            this.btnTraCuuTaiLieu.TabIndex = 1;
            this.btnTraCuuTaiLieu.Text = "Tra cứu tài liệu";
            this.btnTraCuuTaiLieu.UseVisualStyleBackColor = true;
            this.btnTraCuuTaiLieu.Click += new System.EventHandler(this.btnTraCuuTaiLieu_Click);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.Location = new System.Drawing.Point(7, 14);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(227, 26);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục chức năng";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblNgayLamViec);
            this.pnlTop.Controls.Add(this.lblNguoiDung);
            this.pnlTop.Location = new System.Drawing.Point(285, 50);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(632, 58);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // lblNgayLamViec
            // 
            this.lblNgayLamViec.AutoSize = true;
            this.lblNgayLamViec.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNgayLamViec.Location = new System.Drawing.Point(353, 20);
            this.lblNgayLamViec.Name = "lblNgayLamViec";
            this.lblNgayLamViec.Size = new System.Drawing.Size(156, 27);
            this.lblNgayLamViec.TabIndex = 1;
            this.lblNgayLamViec.Text = "Ngày làm việc:";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.Location = new System.Drawing.Point(16, 20);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(140, 26);
            this.lblNguoiDung.TabIndex = 0;
            this.lblNguoiDung.Text = "Người dùng:";
            // 
            // grpKhuVucLamViec
            // 
            this.grpKhuVucLamViec.Controls.Add(this.btnTileKiemKe);
            this.grpKhuVucLamViec.Controls.Add(this.btnTileNhapSach);
            this.grpKhuVucLamViec.Controls.Add(this.btnTileHoSo);
            this.grpKhuVucLamViec.Controls.Add(this.btnTileCapThe);
            this.grpKhuVucLamViec.Controls.Add(this.btnTileMuonTra);
            this.grpKhuVucLamViec.Controls.Add(this.btnTileTraCuu);
            this.grpKhuVucLamViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpKhuVucLamViec.Location = new System.Drawing.Point(285, 124);
            this.grpKhuVucLamViec.Name = "grpKhuVucLamViec";
            this.grpKhuVucLamViec.Size = new System.Drawing.Size(632, 396);
            this.grpKhuVucLamViec.TabIndex = 2;
            this.grpKhuVucLamViec.TabStop = false;
            this.grpKhuVucLamViec.Text = "Khu vực làm việc";
            // 
            // btnTileKiemKe
            // 
            this.btnTileKiemKe.Location = new System.Drawing.Point(458, 215);
            this.btnTileKiemKe.Name = "btnTileKiemKe";
            this.btnTileKiemKe.Size = new System.Drawing.Size(162, 89);
            this.btnTileKiemKe.TabIndex = 5;
            this.btnTileKiemKe.Text = "Kiểm kê";
            this.btnTileKiemKe.UseVisualStyleBackColor = true;
            this.btnTileKiemKe.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTileNhapSach
            // 
            this.btnTileNhapSach.Location = new System.Drawing.Point(260, 215);
            this.btnTileNhapSach.Name = "btnTileNhapSach";
            this.btnTileNhapSach.Size = new System.Drawing.Size(162, 89);
            this.btnTileNhapSach.TabIndex = 4;
            this.btnTileNhapSach.Text = "Nhập sách";
            this.btnTileNhapSach.UseVisualStyleBackColor = true;
            this.btnTileNhapSach.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTileHoSo
            // 
            this.btnTileHoSo.Location = new System.Drawing.Point(62, 215);
            this.btnTileHoSo.Name = "btnTileHoSo";
            this.btnTileHoSo.Size = new System.Drawing.Size(162, 89);
            this.btnTileHoSo.TabIndex = 3;
            this.btnTileHoSo.Text = "Hồ sơ";
            this.btnTileHoSo.UseVisualStyleBackColor = true;
            this.btnTileHoSo.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTileCapThe
            // 
            this.btnTileCapThe.Location = new System.Drawing.Point(458, 85);
            this.btnTileCapThe.Name = "btnTileCapThe";
            this.btnTileCapThe.Size = new System.Drawing.Size(162, 89);
            this.btnTileCapThe.TabIndex = 2;
            this.btnTileCapThe.Text = "Cấp thẻ";
            this.btnTileCapThe.UseVisualStyleBackColor = true;
            this.btnTileCapThe.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTileMuonTra
            // 
            this.btnTileMuonTra.Location = new System.Drawing.Point(260, 85);
            this.btnTileMuonTra.Name = "btnTileMuonTra";
            this.btnTileMuonTra.Size = new System.Drawing.Size(162, 89);
            this.btnTileMuonTra.TabIndex = 1;
            this.btnTileMuonTra.Text = "Mượn/Trả";
            this.btnTileMuonTra.UseVisualStyleBackColor = true;
            this.btnTileMuonTra.Click += new System.EventHandler(this.ChuaTrienKhai);
            // 
            // btnTileTraCuu
            // 
            this.btnTileTraCuu.Location = new System.Drawing.Point(62, 85);
            this.btnTileTraCuu.Name = "btnTileTraCuu";
            this.btnTileTraCuu.Size = new System.Drawing.Size(162, 89);
            this.btnTileTraCuu.TabIndex = 0;
            this.btnTileTraCuu.Text = "Tra cứu";
            this.btnTileTraCuu.UseVisualStyleBackColor = true;
            this.btnTileTraCuu.Click += new System.EventHandler(this.btnTileTraCuu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 560);
            this.Controls.Add(this.grpKhuVucLamViec);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain - Trang chủ hệ thống";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpKhuVucLamViec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Button btnTraCuuTaiLieu;
        private System.Windows.Forms.Button btnMuonTraSach;
        private System.Windows.Forms.Button btnCapTheThuVien;
        private System.Windows.Forms.Button btnHoSoBanDoc;
        private System.Windows.Forms.Button btnNhapPhanLoai;
        private System.Windows.Forms.Button btnKiemKeKho;
        private System.Windows.Forms.Button btnBaoCaoThongKe;
        private System.Windows.Forms.Button btnQuanTriHeThong;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblNgayLamViec;
        private System.Windows.Forms.GroupBox grpKhuVucLamViec;
        private System.Windows.Forms.Button btnTileTraCuu;
        private System.Windows.Forms.Button btnTileMuonTra;
        private System.Windows.Forms.Button btnTileCapThe;
        private System.Windows.Forms.Button btnTileHoSo;
        private System.Windows.Forms.Button btnTileNhapSach;
        private System.Windows.Forms.Button btnTileKiemKe;
    }
}
