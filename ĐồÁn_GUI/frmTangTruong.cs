using ĐồÁn_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ĐồÁn_BUS.AoBUS;

namespace ĐồÁn_GUI
{
    public partial class frmTangTruong : Form
    {
        TangTruongBUS busTT = new TangTruongBUS();
        public frmTangTruong()
        {
            InitializeComponent();
        }

        private void chartGrowth_Click(object sender, EventArgs e)
        {

        }
        private void VeBieuDo(int idVu)
        {
            var data = busTT.LayDS(idVu);

            chartGrowth.Series.Clear();
            if (data == null || data.Count == 0) return;

            Series series = new Series("Tốc độ tăng trưởng");
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.BorderWidth = 3;

            foreach (var item in data)
            {
                string labelNgay = item.NgayDo.HasValue ? item.NgayDo.Value.ToString("dd/MM") : "N/A";
                series.Points.AddXY(labelNgay, item.TrongLuongBinhQuan);
            }
            chartGrowth.Series.Add(series);
        }

        private void cboVuNuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVuNuoi.SelectedValue != null && int.TryParse(cboVuNuoi.SelectedValue.ToString(), out int idAoChon))
            {
                // 1. Vẽ biểu đồ
                VeBieuDo(idAoChon);

                // 2. Hiện dữ liệu lên DataGridView
                LoadNhatKy(idAoChon);
            }
        }

        private void frmTangTruong_Load(object sender, EventArgs e)
        {
            AoBUS aoBus = new AoBUS();
            var ds = aoBus.LayDanhSach();

            // Thiết lập thuộc tính trước
            cboVuNuoi.DisplayMember = "TenAo";
            cboVuNuoi.ValueMember = "AoID";

            // Gán dữ liệu sau cùng
            cboVuNuoi.DataSource = ds;
        }
        private void LoadNhatKy(int idVu)
        {
            var data = busTT.LayDS(idVu);
            dgvNhatKy.DataSource = data;

            // Định dạng DataGridView
            if (dgvNhatKy.Columns.Count > 0)
            {
                // Ẩn các cột không cần thiết (tên cột phải khớp với Model trong DAL)
                if (dgvNhatKy.Columns["ID"] != null) dgvNhatKy.Columns["ID"].Visible = false;
                if (dgvNhatKy.Columns["VuNuoiID"] != null) dgvNhatKy.Columns["VuNuoiID"].Visible = false;
                if (dgvNhatKy.Columns["VuNuois"] != null) dgvNhatKy.Columns["VuNuois"].Visible = false;

                // Đặt tiêu đề
                if (dgvNhatKy.Columns["NgayDo"] != null)
                {
                    dgvNhatKy.Columns["NgayDo"].HeaderText = "Ngày Đo";
                    dgvNhatKy.Columns["NgayDo"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvNhatKy.Columns["TrongLuongBinhQuan"] != null)
                {
                    dgvNhatKy.Columns["TrongLuongBinhQuan"].HeaderText = "Trọng Lượng (g)";
                }

                dgvNhatKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgvNhatKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }
        // Tạo 1 hàm chung để gọi cả Biểu đồ và Grid cho gọn
        private void CapNhatGiaoDien(int idVu)
        {
            VeBieuDo(idVu);
            LoadNhatKy(idVu);
        }

    }
}
