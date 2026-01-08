using System;
using System.Drawing;
using System.Windows.Forms;

namespace ĐồÁn_GUI
{
    public partial class frmChiTietAo : Form
    {
        string TenAo;
        string DienTich;

        // Constructor nhận tên ao và diện tích từ Form chính truyền sang
        public frmChiTietAo(string tenAo, string dienTich)
        {
            InitializeComponent();
            this.TenAo = tenAo;
            this.DienTich = dienTich;
        }

        private void frmChiTietAo_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "CHI TIẾT: " + TenAo.ToUpper();

            // --- GIẢ LẬP SỐ LIỆU (SAU NÀY BẠN LẤY TỪ DB) ---
            Random rd = new Random();

            // 1. Nhiệt độ (25 - 32 độ)
            double temp = rd.Next(25, 33) + rd.NextDouble();
            lblNhietDo.Text = $"🌡 Nhiệt độ hồ: {temp:F1}°C";
            if (temp > 31) lblNhietDo.ForeColor = Color.Red; // Cảnh báo nóng

            // 2. Độ ẩm & Ngưỡng
            lblDoAm.Text = $"💧 Độ ẩm: {rd.Next(60, 90)}%";
            lblNguyHiem.Text = $"⚠ Ngưỡng nguy hiểm: {(temp > 30 ? "CAO" : "THẤP")}";

            // 3. Số lượng tôm cá (< diện tích hồ)
            // Giả sử mật độ 80-100 con/m2
            double dt = double.Parse(DienTich);
            int soLuong = (int)(dt * rd.Next(80, 100));
            lblTomCa.Text = $"🐟 Số lượng ước tính:\n~{soLuong:N0} con (Mật độ an toàn)";

            // 4. Lịch (Cố định hoặc random giờ)
            lblLich.Text = $"📅 Lịch hoạt động hôm nay:\n" +
                           $"- Cho ăn: 07:00, 11:00, 16:00\n" +
                           $"- Bơm nước: 05:00 - 06:00\n" +
                           $"- Xả nước: 18:00\n" +
                           $"- Chạy mô tưa: Liên tục (Auto)";

            // --- GIẢ LẬP CAMERA (Dùng WebBrowser phát Video Youtube) ---
            // Cam 1: Video cá bơi
            WebBrowser webCam1 = new WebBrowser();
            webCam1.ScriptErrorsSuppressed = true;
            webCam1.Dock = DockStyle.Fill;
            // Link video Youtube dạng Embed (tự động chạy, tắt tiếng)
            webCam1.Navigate("https://img.thuthuatphanmem.vn/uploads/2018/10/26/anh-gif-ca-dep_054756475.gif");
            pnlCam1.Controls.Add(webCam1);
            webCam1.SendToBack(); // Để chữ REC hiện lên trên

            // Cam 2: Video mặt hồ
            WebBrowser webCam2 = new WebBrowser();
            webCam1.ScriptErrorsSuppressed = true;
            webCam2.Dock = DockStyle.Fill;
            webCam2.Navigate("https://i.makeagif.com/media/9-12-2015/hj_gwY.gif");
            pnlCam2.Controls.Add(webCam2);
            webCam2.SendToBack();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}