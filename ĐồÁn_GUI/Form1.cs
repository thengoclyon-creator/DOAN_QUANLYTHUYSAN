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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyAo_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form mới
            frmQuanLyAo f = new frmQuanLyAo();
            // Hiển thị Form theo dạng cửa sổ riêng biệt
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form Tăng trưởng
            frmTangTruong f = new frmTangTruong();

            // Hiển thị Form (ShowDialog để bắt buộc xử lý xong form này mới về form chính)
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo đối tượng Form Tổng kết
            frmTongKet f = new frmTongKet();

            // 2. Hiển thị Form dưới dạng hội thoại (người dùng xử lý xong mới quay lại được form chính)
            f.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            f.ShowDialog();
        }
    }
}
