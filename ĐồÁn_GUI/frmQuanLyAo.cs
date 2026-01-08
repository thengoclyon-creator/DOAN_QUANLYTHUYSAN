using System;
using System.Collections.Generic;
using System.Drawing; // Để dùng Color, Point, Size
using System.Windows.Forms;
using System.Diagnostics; // Để dùng Process.Start mở web
using ĐồÁn_BUS; // Đảm bảo dòng này đúng tên Project BUS của bạn

namespace ĐồÁn_GUI
{
    public partial class frmQuanLyAo : Form
    {
        // 1. KHAI BÁO BIẾN DÙNG CHUNG
        AoBUS aoBus = new AoBUS();
        int currentAoID = -1;

        public frmQuanLyAo()
        {
            InitializeComponent();
        }

        // 2. KHI FORM VỪA CHẠY
        private void frmQuanLyAo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // 3. HÀM TẢI DỮ LIỆU TỪ DB
        private void LoadData()
        {
            flpDanhSachAo.Controls.Clear();

            // Dùng dynamic để tránh lỗi namespace DTO
            dynamic danhSach = aoBus.LayDanhSach();

            if (danhSach != null)
            {
                foreach (var item in danhSach)
                {
                    TaoTheAo(item);
                }
            }
        }

        // 4. HÀM MỞ GOOGLE MAP (DÙNG CHUNG)
        private void MoGoogleMap(string diaChi)
        {
            if (string.IsNullOrEmpty(diaChi)) return;
            try
            {
                // Link chuẩn tìm kiếm Google Map
                string url = "http://googleusercontent.com/maps.google.com/search?q=" + Uri.EscapeDataString(diaChi);
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Bắt buộc true để mở trình duyệt trên .NET mới
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở trình duyệt: " + ex.Message);
            }
        }

        // 5. HÀM VẼ THẺ AO (QUAN TRỌNG NHẤT - ĐÃ SỬA LỖI NGOẶC)
        private void TaoTheAo(dynamic item)
        {
            // --- A. LẤY DỮ LIỆU ---
            int id = item.AoID;
            string ten = item.TenAo;
            string dienTich = item.DienTich.ToString();
            string loai = item.LoaiAo;
            string viTri = "";
            try { viTri = item.ViTri.ToString(); } catch { }

            // --- B. TẠO KHUNG THẺ (PANEL) ---
            Panel pnlCard = new Panel();
            pnlCard.Width = 220; // Rộng hơn chút để chứa 2 nút
            pnlCard.Height = 200;
            pnlCard.Margin = new Padding(10);
            pnlCard.BackColor = Color.FromArgb(135, 206, 250); // Màu xanh nhạt
            pnlCard.BorderStyle = BorderStyle.None;
            pnlCard.Cursor = Cursors.Hand;

            // --- C. TẠO TIÊU ĐỀ ---
            Label lblHeader = new Label();
            lblHeader.Text = ten;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Height = 35;
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Font = new Font("Arial", 12, FontStyle.Bold);
            lblHeader.BackColor = Color.FromArgb(0, 191, 255); // Màu xanh đậm
            lblHeader.ForeColor = Color.Black;

            // --- D. TẠO NỘI DUNG ---
            Label lblInfo = new Label();
            lblInfo.Text = $"Loại: {loai}\nDT: {dienTich} m²\nĐ/c: {viTri}";
            lblInfo.Dock = DockStyle.Top;
            lblInfo.Height = 120; // Chiều cao vùng chữ
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblInfo.Padding = new Padding(10, 5, 0, 0);
            lblInfo.Font = new Font("Arial", 10, FontStyle.Regular);

            // --- E. TẠO NÚT BẢN ĐỒ (Bên trái) ---
            Button btnMap = new Button();
            btnMap.Text = "🗺 Map";
            btnMap.Size = new Size(80, 30);
            btnMap.Location = new Point(15, 160);
            btnMap.BackColor = Color.White;
            btnMap.ForeColor = Color.DarkBlue;
            btnMap.Cursor = Cursors.Hand;

            btnMap.Click += (s, e) =>
            {
                if (string.IsNullOrEmpty(viTri)) MessageBox.Show("Ao này chưa có vị trí!");
                else MoGoogleMap(viTri);
            };

            // --- F. TẠO NÚT CHI TIẾT (Bên phải) ---
            Button btnDetail = new Button();
            btnDetail.Text = "ℹ Chi tiết";
            btnDetail.Size = new Size(80, 30);
            btnDetail.Location = new Point(125, 160);
            btnDetail.BackColor = Color.DarkSlateGray;
            btnDetail.ForeColor = Color.White;
            btnDetail.Cursor = Cursors.Hand;

            // Sự kiện mở Form Chi Tiết
            btnDetail.Click += (s, e) =>
            {
                // Mở Form chi tiết và truyền Tên + Diện tích sang
                // Đảm bảo bạn đã tạo frmChiTietAo như hướng dẫn trước
                frmChiTietAo f = new frmChiTietAo(ten, dienTich);
                f.ShowDialog();
            };

            // --- G. SỰ KIỆN CLICK VÀO THẺ (ĐỂ CHỌN AO) ---
            EventHandler suKienClick = (s, e) =>
            {
                currentAoID = id;
                txtTenAo.Text = ten;
                txtDienTich.Text = dienTich;
                txtViTri.Text = viTri;
                cboLoaiAo.Text = loai;

                // Hiệu ứng Highlight màu vàng
                foreach (Control c in flpDanhSachAo.Controls)
                {
                    if (c is Panel p) p.BackColor = Color.FromArgb(135, 206, 250);
                }
                pnlCard.BackColor = Color.Yellow;
            };

            // Gán sự kiện click cho Panel và Label (TRỪ 2 nút bấm ra)
            pnlCard.Click += suKienClick;
            lblHeader.Click += suKienClick;
            lblInfo.Click += suKienClick;

            // --- H. THÊM CONTROL VÀO PANEL ---
            pnlCard.Controls.Add(btnDetail);
            pnlCard.Controls.Add(btnMap);
            pnlCard.Controls.Add(lblInfo);
            pnlCard.Controls.Add(lblHeader);

            flpDanhSachAo.Controls.Add(pnlCard);
        }

        // 6. SỰ KIỆN NÚT "CHECK MAP" (NẾU CÓ)
        // Nếu bên Designer bạn chưa tạo nút btnCheckMap thì có thể xóa hàm này đi để tránh lỗi
        private void btnCheckMap_Click(object sender, EventArgs e)
        {
            string diaChi = txtViTri.Text.Trim();
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ vào ô Vị Trí!");
                return;
            }
            MoGoogleMap(diaChi);
        }

        // 7. CÁC NÚT CHỨC NĂNG CƠ BẢN
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = aoBus.Them(txtTenAo.Text, double.Parse(txtDienTich.Text), txtViTri.Text, cboLoaiAo.Text);
                MessageBox.Show(msg);
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nhập liệu: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentAoID == -1) { MessageBox.Show("Vui lòng chọn ao cần sửa!"); return; }
            try
            {
                string msg = aoBus.Sua(currentAoID, txtTenAo.Text, double.Parse(txtDienTich.Text), txtViTri.Text, cboLoaiAo.Text);
                MessageBox.Show(msg);
                LoadData();
                currentAoID = -1;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentAoID == -1) { MessageBox.Show("Vui lòng chọn ao cần xóa!"); return; }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string res = aoBus.Xoa(currentAoID);
                MessageBox.Show(res);
                LoadData();
                txtTenAo.Clear(); txtDienTich.Clear(); txtViTri.Clear();
                currentAoID = -1;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.ShowDialog();
        }
    }
}