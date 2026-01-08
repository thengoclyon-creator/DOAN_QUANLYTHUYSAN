namespace ĐồÁn_GUI
{
    partial class frmTangTruong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVuNuoi = new System.Windows.Forms.ComboBox();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartGrowth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(30, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(395, 45);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "THEO DÕI TĂNG TRƯỞNG";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.groupBoxLog);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.cboVuNuoi);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 80);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 520);
            this.panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Ao/Vụ:";
            // 
            // cboVuNuoi
            // 
            this.cboVuNuoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVuNuoi.FormattingEnabled = true;
            this.cboVuNuoi.Location = new System.Drawing.Point(16, 50);
            this.cboVuNuoi.Name = "cboVuNuoi";
            this.cboVuNuoi.Size = new System.Drawing.Size(240, 25);
            this.cboVuNuoi.TabIndex = 0;
            this.cboVuNuoi.SelectedIndexChanged += new System.EventHandler(this.cboVuNuoi_SelectedIndexChanged);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLog.Controls.Add(this.dgvNhatKy);
            this.groupBoxLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxLog.Location = new System.Drawing.Point(12, 100);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(256, 408);
            this.groupBoxLog.TabIndex = 3;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Nhật Ký Tăng Trưởng";
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhatKy.Location = new System.Drawing.Point(3, 21);
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.Size = new System.Drawing.Size(250, 384);
            this.dgvNhatKy.TabIndex = 1;
            this.dgvNhatKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhatKy_CellContentClick);
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartGrowth);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(280, 80);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(10);
            this.panelChart.Size = new System.Drawing.Size(720, 520);
            this.panelChart.TabIndex = 2;
            // 
            // chartGrowth
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGrowth.ChartAreas.Add(chartArea4);
            this.chartGrowth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartGrowth.Legends.Add(legend4);
            this.chartGrowth.Location = new System.Drawing.Point(10, 10);
            this.chartGrowth.Name = "chartGrowth";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGrowth.Series.Add(series4);
            this.chartGrowth.Size = new System.Drawing.Size(700, 500);
            this.chartGrowth.TabIndex = 2;
            this.chartGrowth.Text = "chart1";
            this.chartGrowth.Click += new System.EventHandler(this.chartGrowth_Click);
            // 
            // frmTangTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmTangTruong";
            this.Text = "Theo Dõi Tăng Trưởng";
            this.Load += new System.EventHandler(this.frmTangTruong_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGrowth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ComboBox cboVuNuoi;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrowth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.Panel panelChart;
    }
}