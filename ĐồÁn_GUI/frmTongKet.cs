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

namespace ĐồÁn_GUI
{
    public partial class frmTongKet : Form
    {
        // Khởi tạo các lớp BUS cần thiết
        // Vì TongKetBUS nằm trong AoBUS nên ta gọi qua AoBUS
        AoBUS.TongKetBUS busTK = new AoBUS.TongKetBUS();
        AoBUS busAo = new AoBUS();
        public frmTongKet()
        {
            InitializeComponent();
        }

        private void frmTongKet_Load(object sender, EventArgs e)
        {
            // Đổ danh sách Ao vào ComboBox khi mở Form
            LoadComboBoxAo();
        }
        private void LoadComboBoxAo()
        {
            var dsAo = busAo.LayDanhSach();
            cboVuNuoi.DataSource = dsAo;
            cboVuNuoi.DisplayMember = "TenAo";
            cboVuNuoi.ValueMember = "AoID";
        }

        private void cboVuNuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mỗi khi chọn Ao khác, tự động lấy Chi phí và Sản lượng từ SQL lên
            HienThiDuLieuMacDinh();
        }
        private void HienThiDuLieuMacDinh()
        {
            if (cboVuNuoi.SelectedValue != null && int.TryParse(cboVuNuoi.SelectedValue.ToString(), out int idAo))
            {
                // 1. Lấy tổng chi phí từ BUS
                double chiPhi = busTK.GetChiPhi(idAo);
                lblTongChiPhi.Text = "Tổng chi phí: " + chiPhi.ToString("N0") + " VNĐ";

                // 2. Lấy sản lượng thực tế
                double sanLuongSQL = busTK.LaySanLuongTuSQL(idAo);
                txtSanLuong.Text = sanLuongSQL.ToString();

                // 3. [NEW] Lấy thông tin chi tiết Vụ Nuôi (Ngày thả, giống, v.v...)
                var info = busTK.GetThongTinVuNuoi(idAo);
                if (info != null)
                {
                lblNgayTha.Text = info.NgayTha != null ? info.NgayTha.Value.ToString("dd/MM/yyyy") : "...";
                    lblNgayThu.Text = info.NgayThu != null ? info.NgayThu.Value.ToString("dd/MM/yyyy") : "...";
                    lblGiong.Text = info.TenGiong ?? "...";
                    lblSoLuong.Text = info.SoLuongTha != null ? info.SoLuongTha.ToString() : "0";
                }
                else
                {
                    lblNgayTha.Text = "...";
                    lblNgayThu.Text = "...";
                    lblGiong.Text = "...";
                    lblSoLuong.Text = "...";
                }

                // 4. [NEW] Đổ dữ liệu vào bảng chi tiết chi phí và thêm dòng TỔNG CỘNG
                var listData = busTK.GetChiPhiChiTiet(idAo);

                // Convert to DataTable to add footer row
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Ngay", typeof(DateTime));
                dt.Columns.Add("TenVatTu", typeof(string));
                dt.Columns.Add("SoLuong", typeof(double));
                dt.Columns.Add("DonGia", typeof(decimal));
                dt.Columns.Add("ThanhTien", typeof(double));

                double totalThanhTien = 0;

                System.Collections.IEnumerable enumerable = listData as System.Collections.IEnumerable;
                if (enumerable != null)
                {
                    foreach (object item in enumerable)
                    {
                        var row = dt.NewRow();
                        // Use reflection to get properties from anonymous types
                        System.Type type = item.GetType();
                        
                        // Handle formatting or nulls safely
                        var pNgay = type.GetProperty("Ngay");
                        var pTen = type.GetProperty("TenVatTu");
                        var pSL = type.GetProperty("SoLuong");
                        var pDonGia = type.GetProperty("DonGia");
                        var pThanhTien = type.GetProperty("ThanhTien");

                        var valNgay = pNgay?.GetValue(item, null);
                        if (valNgay != null) row["Ngay"] = valNgay;
                        
                        row["TenVatTu"] = pTen?.GetValue(item, null) ?? "";
                        row["SoLuong"] = pSL?.GetValue(item, null) ?? 0.0;
                        row["DonGia"] = pDonGia?.GetValue(item, null) ?? 0m;
                        
                        double tt = 0;
                        var valTT = pThanhTien?.GetValue(item, null);
                        if (valTT != null) double.TryParse(valTT.ToString(), out tt);
                        
                        row["ThanhTien"] = tt;
                        totalThanhTien += tt;

                        dt.Rows.Add(row);
                    }
                }

                // Add Total Row
                var totalRow = dt.NewRow();
                totalRow["TenVatTu"] = "TỔNG CỘNG";
                totalRow["ThanhTien"] = totalThanhTien;
                dt.Rows.Add(totalRow);

                dgvChiPhi.DataSource = dt;
                
                // Định dạng hiển thị Grid
                if (dgvChiPhi.Columns["ThanhTien"] != null)
                    dgvChiPhi.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                if (dgvChiPhi.Columns["DonGia"] != null)
                    dgvChiPhi.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                if (dgvChiPhi.Columns["Ngay"] != null)
                    dgvChiPhi.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                
                // Highlight Total Row
                if (dgvChiPhi.Rows.Count > 0)
                {
                    var lastRow = dgvChiPhi.Rows[dgvChiPhi.Rows.Count - 1]; // Because AllowUserToAddRows might be false or true. 
                    // Better to find it by index since we just bound it.
                    // If AllowUserToAddRows is true, last row is new row. DataTable bound -> usually AllowUserToAddRows becomes user setting.
                    // Let's rely on DataTable row count.
                    
                    // Actually, let's format it in DataBindingComplete or just change style here if possible
                    // But rows are created.
                     dgvChiPhi.Rows[dt.Rows.Count - 1].DefaultCellStyle.Font = new Font(dgvChiPhi.Font, FontStyle.Bold);
                     dgvChiPhi.Rows[dt.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightYellow;
                }

                dgvChiPhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                double sanLuong = 0;
                double.TryParse(txtSanLuong.Text, out sanLuong);
                
                double giaBan = 0;
                double.TryParse(txtGiaBan.Text, out giaBan);

                // Lấy lại chi phí hiện tại
                int idAo = (int)cboVuNuoi.SelectedValue;
                double chiPhi = busTK.GetChiPhi(idAo);

                // 1. Tính Doanh thu
                double doanhThu = sanLuong * giaBan;
                lblDoanhThu.Text = "Doanh thu: " + doanhThu.ToString("N0") + " VNĐ";

                // 2. Gọi BUS tính Lợi nhuận
                double loiNhuan = busTK.TinhToanLoiNhuan(sanLuong, giaBan, chiPhi);
                lblLoiNhuan.Text = "Lợi nhuận: " + loiNhuan.ToString("N0") + " VNĐ";

                // Thay đổi màu sắc nhãn lợi nhuận (Xanh nếu lãi, Đỏ nếu lỗ)
                if (loiNhuan >= 0)
                    lblLoiNhuan.ForeColor = Color.Green;
                else
                    lblLoiNhuan.ForeColor = Color.Red;
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập (Sản lượng và Giá bán phải là số).", "Thông báo");
            }
        }

        private void btnGiaThiTruong_Click(object sender, EventArgs e)
        {
            // Mở trang web giá cả thị trường (Ví dụ Tepbac hoặc trang nào đó)
            try
            {
                System.Diagnostics.Process.Start("https://tepbac.com/gia-tom-ca");
            }
            catch(Exception)
            {
                MessageBox.Show("Không thể mở trình duyệt web.", "Lỗi");
            }
        }
    }
}
