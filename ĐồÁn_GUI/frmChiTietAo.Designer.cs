namespace ĐồÁn_GUI
{
    partial class frmChiTietAo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblLich = new System.Windows.Forms.Label();
            this.lblTomCa = new System.Windows.Forms.Label();
            this.lblNguyHiem = new System.Windows.Forms.Label();
            this.lblDoAm = new System.Windows.Forms.Label();
            this.lblNhietDo = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pnlCam2 = new System.Windows.Forms.Panel();
            this.lblCam2 = new System.Windows.Forms.Label();
            this.pnlCam1 = new System.Windows.Forms.Panel();
            this.lblCam1 = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.pnlCam2.SuspendLayout();
            this.pnlCam1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT AO NUÔI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft (Chứa thông số - Dock bên trái)
            // 
            this.panelLeft.Controls.Add(this.groupBoxInfo);
            this.panelLeft.Controls.Add(this.btnDong);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 60);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(350, 540);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblLich);
            this.groupBoxInfo.Controls.Add(this.lblTomCa);
            this.groupBoxInfo.Controls.Add(this.lblNguyHiem);
            this.groupBoxInfo.Controls.Add(this.lblDoAm);
            this.groupBoxInfo.Controls.Add(this.lblNhietDo);
            this.groupBoxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.Location = new System.Drawing.Point(10, 10);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(330, 450);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông số môi trường";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Firebrick;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(10, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(330, 50);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng cửa sổ";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Các Label (Giữ nguyên logic cũ)
            // 
            this.lblLich.Location = new System.Drawing.Point(15, 260);
            this.lblLich.Name = "lblLich";
            this.lblLich.Size = new System.Drawing.Size(300, 150);
            this.lblLich.TabIndex = 4;
            this.lblLich.Text = "📅 Lịch hoạt động:...";
            // 
            // lblTomCa
            // 
            this.lblTomCa.Location = new System.Drawing.Point(15, 180);
            this.lblTomCa.Name = "lblTomCa";
            this.lblTomCa.Size = new System.Drawing.Size(300, 60);
            this.lblTomCa.TabIndex = 3;
            this.lblTomCa.Text = "🐟 Số lượng:...";
            // 
            // lblNguyHiem
            // 
            this.lblNguyHiem.Location = new System.Drawing.Point(15, 130);
            this.lblNguyHiem.Name = "lblNguyHiem";
            this.lblNguyHiem.Size = new System.Drawing.Size(300, 30);
            this.lblNguyHiem.ForeColor = System.Drawing.Color.Red;
            this.lblNguyHiem.TabIndex = 2;
            this.lblNguyHiem.Text = "⚠ Ngưỡng:...";
            // 
            // lblDoAm
            // 
            this.lblDoAm.Location = new System.Drawing.Point(15, 90);
            this.lblDoAm.Name = "lblDoAm";
            this.lblDoAm.Size = new System.Drawing.Size(300, 30);
            this.lblDoAm.TabIndex = 1;
            this.lblDoAm.Text = "💧 Độ ẩm:...";
            // 
            // lblNhietDo
            // 
            this.lblNhietDo.Location = new System.Drawing.Point(15, 50);
            this.lblNhietDo.Name = "lblNhietDo";
            this.lblNhietDo.Size = new System.Drawing.Size(300, 30);
            this.lblNhietDo.TabIndex = 0;
            this.lblNhietDo.Text = "🌡 Nhiệt độ:...";
            // 
            // panelRight (Chứa 2 Camera - Dock Lấp đầy phần còn lại)
            // 
            this.panelRight.Controls.Add(this.pnlCam2);
            this.panelRight.Controls.Add(this.pnlCam1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(650, 540);
            this.panelRight.TabIndex = 2;
            // 
            // pnlCam2
            // 
            this.pnlCam2.BackColor = System.Drawing.Color.Black;
            this.pnlCam2.Controls.Add(this.lblCam2);
            this.pnlCam2.Dock = System.Windows.Forms.DockStyle.Fill; // Lấp đầy phần dưới
            this.pnlCam2.Location = new System.Drawing.Point(10, 270);
            this.pnlCam2.Name = "pnlCam2";
            this.pnlCam2.Size = new System.Drawing.Size(630, 260);
            this.pnlCam2.TabIndex = 1;
            // 
            // lblCam2
            // 
            this.lblCam2.AutoSize = true;
            this.lblCam2.BackColor = System.Drawing.Color.Transparent;
            this.lblCam2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCam2.ForeColor = System.Drawing.Color.Red;
            this.lblCam2.Location = new System.Drawing.Point(10, 10);
            this.lblCam2.Name = "lblCam2";
            this.lblCam2.Size = new System.Drawing.Size(127, 16);
            this.lblCam2.TabIndex = 0;
            this.lblCam2.Text = "🔴 CAM 02 - LIVE";
            // 
            // pnlCam1
            // 
            this.pnlCam1.BackColor = System.Drawing.Color.Black;
            this.pnlCam1.Controls.Add(this.lblCam1);
            this.pnlCam1.Dock = System.Windows.Forms.DockStyle.Top; // Dính lên trên
            this.pnlCam1.Location = new System.Drawing.Point(10, 10);
            this.pnlCam1.Name = "pnlCam1";
            this.pnlCam1.Size = new System.Drawing.Size(630, 260); // Chiều cao = 1/2
            this.pnlCam1.TabIndex = 0;
            // 
            // lblCam1
            // 
            this.lblCam1.AutoSize = true;
            this.lblCam1.BackColor = System.Drawing.Color.Transparent;
            this.lblCam1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCam1.ForeColor = System.Drawing.Color.Red;
            this.lblCam1.Location = new System.Drawing.Point(10, 10);
            this.lblCam1.Name = "lblCam1";
            this.lblCam1.Size = new System.Drawing.Size(127, 16);
            this.lblCam1.TabIndex = 0;
            this.lblCam1.Text = "🔴 CAM 01 - LIVE";
            // 
            // frmChiTietAo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmChiTietAo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Ao Nuôi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; // <--- TỰ ĐỘNG FULL MÀN HÌNH
            this.Load += new System.EventHandler(this.frmChiTietAo_Load);
            
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.pnlCam2.ResumeLayout(false);
            this.pnlCam2.PerformLayout();
            this.pnlCam1.ResumeLayout(false);
            this.pnlCam1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblNhietDo;
        private System.Windows.Forms.Label lblDoAm;
        private System.Windows.Forms.Label lblNguyHiem;
        private System.Windows.Forms.Label lblTomCa;
        private System.Windows.Forms.Label lblLich;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel pnlCam1;
        private System.Windows.Forms.Label lblCam1;
        private System.Windows.Forms.Panel pnlCam2;
        private System.Windows.Forms.Label lblCam2;
    }
}