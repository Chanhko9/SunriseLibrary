using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SunriseLibrary.Models;
using SunriseLibrary.Services;

namespace SunriseLibrary.Forms
{
    public partial class frmBaoCaoThongKe : Form
    {
        private readonly BaoCaoThongKeService _service = new BaoCaoThongKeService();

        public frmBaoCaoThongKe()
        {
            InitializeComponent();
            Load += frmBaoCaoThongKe_Load;
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            cboLoaiBaoCao.Items.Clear();
            cboLoaiBaoCao.Items.Add("Sách được mượn nhiều nhất");
            cboLoaiBaoCao.Items.Add("Bạn đọc mượn sách nhiều nhất");
            cboLoaiBaoCao.SelectedIndex = 0;
            dtpTuNgay.Value = DateTime.Now.AddMonths(-3);
            dtpDenNgay.Value = DateTime.Now;
            TaiBaoCao();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            TaiBaoCao();
        }

        private void TaiBaoCao()
        {
            List<BaoCaoTopItem> items;
            var tuNgay = dtpTuNgay.Value.Date;
            var denNgay = dtpDenNgay.Value.Date;

            if (cboLoaiBaoCao.SelectedIndex == 1)
                items = _service.LayTopBanDocMuonNhieuNhat(tuNgay, denNgay);
            else
                items = _service.LayTopSachMuonNhieuNhat(tuNgay, denNgay);

            dgvChiTiet.Rows.Clear();
            foreach (var item in items)
                dgvChiTiet.Rows.Add(item.Nhan, item.SoLuong);

            VeBieuDo(items);
        }

        private void VeBieuDo(List<BaoCaoTopItem> items)
        {
            chartBaoCao.Series.Clear();
            chartBaoCao.Titles.Clear();
            var series = new Series("ThongKe")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P0}",
                LegendText = "#AXISLABEL (#VAL)"
            };

            foreach (var item in items)
                series.Points.AddXY(item.Nhan, item.SoLuong);

            chartBaoCao.Series.Add(series);
            chartBaoCao.Titles.Add(cboLoaiBaoCao.Text);
        }
    }
}
