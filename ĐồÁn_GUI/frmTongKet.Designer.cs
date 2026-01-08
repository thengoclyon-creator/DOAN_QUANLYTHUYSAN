namespace ĐồÁn_GUI
{
    partial class frmTongKet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVuNuoi = new System.Windows.Forms.ComboBox();
            this.btnGiaThiTruong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblGiong = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNgayThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNgayTha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxFinance = new System.Windows.Forms.GroupBox();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.txtSanLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.dgvChiPhi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxFinance.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboVuNuoi);
            this.panel1.Controls.Add(this.btnGiaThiTruong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Ao/Vụ:";
            // 
            // cboVuNuoi
            // 
            this.cboVuNuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVuNuoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVuNuoi.FormattingEnabled = true;
            this.cboVuNuoi.Location = new System.Drawing.Point(16, 145);
            this.cboVuNuoi.Name = "cboVuNuoi";
            this.cboVuNuoi.Size = new System.Drawing.Size(165, 25);
            this.cboVuNuoi.TabIndex = 0;
            this.cboVuNuoi.SelectedIndexChanged += new System.EventHandler(this.cboVuNuoi_SelectedIndexChanged);
            // 
            // btnGiaThiTruong
            // 
            this.btnGiaThiTruong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnGiaThiTruong.FlatAppearance.BorderSize = 0;
            this.btnGiaThiTruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaThiTruong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGiaThiTruong.ForeColor = System.Drawing.Color.White;
            this.btnGiaThiTruong.Location = new System.Drawing.Point(16, 200);
            this.btnGiaThiTruong.Name = "btnGiaThiTruong";
            this.btnGiaThiTruong.Size = new System.Drawing.Size(165, 45);
            this.btnGiaThiTruong.TabIndex = 2;
            this.btnGiaThiTruong.Text = "Tra Cứu Giá Thị Trường";
            this.btnGiaThiTruong.UseVisualStyleBackColor = false;
            this.btnGiaThiTruong.Click += new System.EventHandler(this.btnGiaThiTruong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 80);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "TỔNG KẾT VỤ NUÔI";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblGiong);
            this.groupBoxInfo.Controls.Add(this.label8);
            this.groupBoxInfo.Controls.Add(this.lblSoLuong);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.lblNgayThu);
            this.groupBoxInfo.Controls.Add(this.label5);
            this.groupBoxInfo.Controls.Add(this.lblNgayTha);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(220, 100);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(360, 180);
            this.groupBoxInfo.TabIndex = 2;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông Tin Đầu Vào/Ra";
            // 
            // lblGiong
            // 
            this.lblGiong.AutoSize = true;
            this.lblGiong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiong.Location = new System.Drawing.Point(120, 140);
            this.lblGiong.Name = "lblGiong";
            this.lblGiong.Size = new System.Drawing.Size(20, 19);
            this.lblGiong.TabIndex = 7;
            this.lblGiong.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giống Nuôi:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSoLuong.Location = new System.Drawing.Point(120, 105);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(20, 19);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Lượng Con:";
            // 
            // lblNgayThu
            // 
            this.lblNgayThu.AutoSize = true;
            this.lblNgayThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayThu.Location = new System.Drawing.Point(120, 70);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(20, 19);
            this.lblNgayThu.TabIndex = 3;
            this.lblNgayThu.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Thu:";
            // 
            // lblNgayTha
            // 
            this.lblNgayTha.AutoSize = true;
            this.lblNgayTha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayTha.Location = new System.Drawing.Point(120, 35);
            this.lblNgayTha.Name = "lblNgayTha";
            this.lblNgayTha.Size = new System.Drawing.Size(20, 19);
            this.lblNgayTha.TabIndex = 1;
            this.lblNgayTha.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Thả:";
            // 
            // groupBoxFinance
            // 
            this.groupBoxFinance.Controls.Add(this.btnTinhToan);
            this.groupBoxFinance.Controls.Add(this.lblLoiNhuan);
            this.groupBoxFinance.Controls.Add(this.lblDoanhThu);
            this.groupBoxFinance.Controls.Add(this.lblTongChiPhi);
            this.groupBoxFinance.Controls.Add(this.txtSanLuong);
            this.groupBoxFinance.Controls.Add(this.txtGiaBan);
            this.groupBoxFinance.Controls.Add(this.label9);
            this.groupBoxFinance.Controls.Add(this.label10);
            this.groupBoxFinance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxFinance.Location = new System.Drawing.Point(600, 100);
            this.groupBoxFinance.Name = "groupBoxFinance";
            this.groupBoxFinance.Size = new System.Drawing.Size(380, 250);
            this.groupBoxFinance.TabIndex = 3;
            this.groupBoxFinance.TabStop = false;
            this.groupBoxFinance.Text = "Tính Toán Lợi Nhuận";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTinhToan.FlatAppearance.BorderSize = 0;
            this.btnTinhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhToan.ForeColor = System.Drawing.Color.White;
            this.btnTinhToan.Location = new System.Drawing.Point(135, 204);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(120, 35);
            this.btnTinhToan.TabIndex = 4;
            this.btnTinhToan.Text = "TÍNH TOÁN";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoiNhuan.Location = new System.Drawing.Point(20, 160);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(93, 21);
            this.lblLoiNhuan.TabIndex = 6;
            this.lblLoiNhuan.Text = "Lợi nhuận: ";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoanhThu.Location = new System.Drawing.Point(20, 130);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(84, 19);
            this.lblDoanhThu.TabIndex = 5;
            this.lblDoanhThu.Text = "Doanh thu: 0";
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongChiPhi.Location = new System.Drawing.Point(20, 100);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(95, 19);
            this.lblTongChiPhi.TabIndex = 4;
            this.lblTongChiPhi.Text = "Tổng chi phí: 0";
            // 
            // txtSanLuong
            // 
            this.txtSanLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSanLuong.Location = new System.Drawing.Point(135, 60);
            this.txtSanLuong.Name = "txtSanLuong";
            this.txtSanLuong.Size = new System.Drawing.Size(150, 25);
            this.txtSanLuong.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaBan.Location = new System.Drawing.Point(135, 25);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(150, 25);
            this.txtGiaBan.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sản Lượng (kg):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giá Bán (VNĐ):";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.dgvChiPhi);
            this.groupBoxDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxDetails.Location = new System.Drawing.Point(220, 360);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(760, 228);
            this.groupBoxDetails.TabIndex = 4;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Bảng Chi Tiết Chi Phí";
            // 
            // dgvChiPhi
            // 
            this.dgvChiPhi.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiPhi.Location = new System.Drawing.Point(3, 21);
            this.dgvChiPhi.Name = "dgvChiPhi";
            this.dgvChiPhi.Size = new System.Drawing.Size(754, 204);
            this.dgvChiPhi.TabIndex = 0;
            // 
            // frmTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxFinance);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTongKet";
            this.Text = "Tổng Kết Vụ Nuôi";
            this.Load += new System.EventHandler(this.frmTongKet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxFinance.ResumeLayout(false);
            this.groupBoxFinance.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVuNuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiaThiTruong;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblNgayTha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGiong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNgayThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxFinance;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.TextBox txtSanLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.DataGridView dgvChiPhi;
    }
}