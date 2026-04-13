namespace SunriseLibrary.Forms
{
    partial class frmBaoCaoThongKe
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblLoaiBaoCao = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.grpBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Controls.Add(this.dgvChiTiet);
            this.grpBaoCao.Controls.Add(this.chartBaoCao);
            this.grpBaoCao.Controls.Add(this.btnXemBaoCao);
            this.grpBaoCao.Controls.Add(this.cboLoaiBaoCao);
            this.grpBaoCao.Controls.Add(this.dtpDenNgay);
            this.grpBaoCao.Controls.Add(this.dtpTuNgay);
            this.grpBaoCao.Controls.Add(this.lblLoaiBaoCao);
            this.grpBaoCao.Controls.Add(this.lblDenNgay);
            this.grpBaoCao.Controls.Add(this.lblTuNgay);
            this.grpBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.grpBaoCao.Location = new System.Drawing.Point(12, 12);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Size = new System.Drawing.Size(1014, 720);
            this.grpBaoCao.TabIndex = 0;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = "Báo cáo thống kê";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNhan,
            this.colSoLuong});
            this.dgvChiTiet.Location = new System.Drawing.Point(19, 470);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 62;
            this.dgvChiTiet.RowTemplate.Height = 28;
            this.dgvChiTiet.Size = new System.Drawing.Size(968, 244);
            this.dgvChiTiet.TabIndex = 8;
            // 
            // colNhan
            // 
            this.colNhan.HeaderText = "Tên";
            this.colNhan.MinimumWidth = 8;
            this.colNhan.Name = "colNhan";
            this.colNhan.Width = 700;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượt";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 150;
            // 
            // chartBaoCao
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBaoCao.Legends.Add(legend1);
            this.chartBaoCao.Location = new System.Drawing.Point(19, 116);
            this.chartBaoCao.Name = "chartBaoCao";
            this.chartBaoCao.Size = new System.Drawing.Size(968, 329);
            this.chartBaoCao.TabIndex = 7;
            this.chartBaoCao.Text = "chart1";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(721, 41);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(101, 35);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "Xem";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(530, 41);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(166, 34);
            this.cboLoaiBaoCao.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(307, 41);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(158, 35);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(87, 41);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(158, 35);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblLoaiBaoCao
            // 
            this.lblLoaiBaoCao.AutoSize = true;
            this.lblLoaiBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLoaiBaoCao.Location = new System.Drawing.Point(471, 44);
            this.lblLoaiBaoCao.Name = "lblLoaiBaoCao";
            this.lblLoaiBaoCao.Size = new System.Drawing.Size(56, 27);
            this.lblLoaiBaoCao.TabIndex = 4;
            this.lblLoaiBaoCao.Text = "Loại";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblDenNgay.Location = new System.Drawing.Point(251, 44);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(52, 27);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblTuNgay.Location = new System.Drawing.Point(31, 44);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(39, 27);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ";
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 758);
            this.Controls.Add(this.grpBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoThongKe - Báo cáo thống kê";
            this.grpBaoCao.ResumeLayout(false);
            this.grpBaoCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblLoaiBaoCao;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}
