using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ĐồÁn_BUS;

namespace ĐồÁn_GUI
{
    public partial class frmBaoCao : Form
    {
        AoBUS busAo = new AoBUS();
        AoBUS.TongKetBUS busTK = new AoBUS.TongKetBUS();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDashboardData();
        }

        private void SetupDataGridView()
        {
            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.RowHeadersVisible = false;

            // Styling Header
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvBaoCao.ColumnHeadersHeight = 35;

            // Columns matching the dashboard style
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn() { Name = "TenVatTu", DataPropertyName = "TenVatTu", HeaderText = "HẠNG MỤC", Width = 150 });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn() { Name = "SoLuong", DataPropertyName = "SoLuong", HeaderText = "SL", Width = 50, DefaultCellStyle = new DataGridViewCellStyle { Format = "N1" } });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn() { Name = "ThanhTien", DataPropertyName = "ThanhTien", HeaderText = "CHI PHÍ", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", ForeColor = Color.Red } });
            
            // Add a "Status" column with icon simulation (User can't see images easily in grid without work, so using Text)
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn() { Name = "TrangThai", HeaderText = "TIẾN ĐỘ", Width = 80 });

        }

        private void LoadDashboardData()
        {
            // Update Title
            labelTitle.Text = "DASHBOARD QUẢN LÝ AO NUÔI - " + DateTime.Now.ToString("dd/MM/yyyy");
            lblDate.Text = "Vụ Mùa: Xuân - Hè 2026";

            // 1. Tải số liệu KPI (Giả lập tính toán từ DB hoặc Mock)
            lblKpi1Value.Text = "4,500"; // Tổng Ao
            lblKpi2Value.Text = "85%";   // Tỉ lệ sống
            lblKpi3Value.Text = "1.2";   // FCR
            lblKpi4Value.Text = "150tr"; // Lợi nhuận

            // 2. Load Grid Data (Lấy dữ liệu từ Ao 1 hoặc Ao bất kỳ để demo)
            int demoAoID = 1; 
            var dataRaw = busTK.GetChiPhiChiTiet(demoAoID);
            
            // Bind to Grid
            dgvBaoCao.DataSource = dataRaw;

            // Fake "TrangThai" column data based on value
            foreach(DataGridViewRow row in dgvBaoCao.Rows)
            {
                row.Cells["TrangThai"].Value = "✅ Tốt";
                if(row.Index % 3 == 0) 
                {
                    row.Cells["TrangThai"].Value = "⚠️ Chú ý";
                    row.Cells["TrangThai"].Style.ForeColor = Color.Orange;
                }
            }

            // 3. Load Charts
            LoadCharts(dataRaw);
        }

        private void LoadCharts(object dataSource)
        {
            // === Chart 1: Vertical Bar (Chi phí theo ngày) ===
            chartBar.Series.Clear();
            chartBar.Titles.Clear();
            chartBar.Titles.Add("Biểu Đồ Chi Phí Theo Ngày").Font = new Font("Segoe UI", 12, FontStyle.Bold);
            
            var series = chartBar.Series.Add("ChiPhi");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(46, 204, 113); // Green

            // Convert data source to iterable
            dynamic list = dataSource;
            if(list != null)
            {
                foreach(var item in list)
                {
                    // Reflection to get properties safely
                    Type t = item.GetType();
                    DateTime date = (DateTime)t.GetProperty("Ngay").GetValue(item, null);
                    double money = (double)t.GetProperty("ThanhTien").GetValue(item, null);
                    
                    series.Points.AddXY(date.ToString("dd/MM"), money);
                }
            }

            // === Chart 2: Gauge / Pie (Tỉ lệ chi phí) ===
            chartPie.Series.Clear();
            var sPie = chartPie.Series.Add("TyLe");
            sPie.ChartType = SeriesChartType.Doughnut;
            sPie.Points.AddXY("Thức ăn", 60);
            sPie.Points.AddXY("Thuốc", 25);
            sPie.Points.AddXY("Điện", 10);
            sPie.Points.AddXY("Khác", 5);
            sPie["PieLabelStyle"] = "Outside";

            // === Chart 3: Horizontal Bar (So sánh các Ao) ===
            chartHBar.Series.Clear();
            var sHBar = chartHBar.Series.Add("LoiNhuan");
            sHBar.ChartType = SeriesChartType.Bar;
            sHBar.Points.AddXY("Ao 1", 150000000);
            sHBar.Points.AddXY("Ao 2", 120000000);
            sHBar.Points.AddXY("Ao 3", 90000000);
            sHBar.Points.AddXY("Ao 4", 200000000);
            sHBar.Color = Color.FromArgb(52, 152, 219); // Blue
        }
    }
}
