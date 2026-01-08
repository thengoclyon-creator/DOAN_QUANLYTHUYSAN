namespace ĐồÁn_GUI
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKpi1Value = new System.Windows.Forms.Label();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKpi2Value = new System.Windows.Forms.Label();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKpi3Value = new System.Windows.Forms.Label();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKpi4Value = new System.Windows.Forms.Label();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPie = new System.Windows.Forms.Panel();
            this.labelPieTitle = new System.Windows.Forms.Label();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHBar = new System.Windows.Forms.Panel();
            this.labelHBarTitle = new System.Windows.Forms.Label();
            this.chartHBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanelContent.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.panelPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.panelHBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(434, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DASHBOARD CÔNG NGHỆ CAO - AO 1";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(900, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(272, 32);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tháng 01 / 2026";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 120);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.lblKpi1Value);
            this.panel1.Controls.Add(this.lblKpi1Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblKpi1Value
            // 
            this.lblKpi1Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpi1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblKpi1Value.Location = new System.Drawing.Point(0, 35);
            this.lblKpi1Value.Name = "lblKpi1Value";
            this.lblKpi1Value.Size = new System.Drawing.Size(271, 45);
            this.lblKpi1Value.TabIndex = 1;
            this.lblKpi1Value.Text = "390";
            this.lblKpi1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi1Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblKpi1Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(271, 30);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "TỔNG SẢN LƯỢNG (KG)";
            this.lblKpi1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.lblKpi2Value);
            this.panel2.Controls.Add(this.lblKpi2Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(311, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 80);
            this.panel2.TabIndex = 1;
            // 
            // lblKpi2Value
            // 
            this.lblKpi2Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpi2Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblKpi2Value.Location = new System.Drawing.Point(0, 35);
            this.lblKpi2Value.Name = "lblKpi2Value";
            this.lblKpi2Value.Size = new System.Drawing.Size(271, 45);
            this.lblKpi2Value.TabIndex = 2;
            this.lblKpi2Value.Text = "55.1";
            this.lblKpi2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi2Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblKpi2Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(271, 30);
            this.lblKpi2Title.TabIndex = 1;
            this.lblKpi2Title.Text = "TỈ LỆ SỐNG TB";
            this.lblKpi2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.lblKpi3Value);
            this.panel3.Controls.Add(this.lblKpi3Title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(602, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 80);
            this.panel3.TabIndex = 2;
            // 
            // lblKpi3Value
            // 
            this.lblKpi3Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpi3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblKpi3Value.Location = new System.Drawing.Point(0, 35);
            this.lblKpi3Value.Name = "lblKpi3Value";
            this.lblKpi3Value.Size = new System.Drawing.Size(271, 45);
            this.lblKpi3Value.TabIndex = 2;
            this.lblKpi3Value.Text = "17.4%";
            this.lblKpi3Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi3Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblKpi3Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(271, 30);
            this.lblKpi3Title.TabIndex = 1;
            this.lblKpi3Title.Text = "HỆ SỐ FCR";
            this.lblKpi3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.lblKpi4Value);
            this.panel4.Controls.Add(this.lblKpi4Title);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(893, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 80);
            this.panel4.TabIndex = 3;
            // 
            // lblKpi4Value
            // 
            this.lblKpi4Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpi4Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblKpi4Value.Location = new System.Drawing.Point(0, 35);
            this.lblKpi4Value.Name = "lblKpi4Value";
            this.lblKpi4Value.Size = new System.Drawing.Size(271, 45);
            this.lblKpi4Value.TabIndex = 2;
            this.lblKpi4Value.Text = "0.103";
            this.lblKpi4Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi4Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblKpi4Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(271, 30);
            this.lblKpi4Title.TabIndex = 1;
            this.lblKpi4Title.Text = "LỢI NHUẬN / AO";
            this.lblKpi4Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 2;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelContent.Controls.Add(this.panelGrid, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.chartBar, 1, 0);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 180);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelContent.RowCount = 1;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(1184, 300);
            this.tableLayoutPanelContent.TabIndex = 2;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvBaoCao);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(13, 13);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelGrid.Size = new System.Drawing.Size(460, 274);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 0);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.Size = new System.Drawing.Size(450, 274);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // chartBar
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea1);
            this.chartBar.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBar.Legends.Add(legend1);
            this.chartBar.Location = new System.Drawing.Point(479, 13);
            this.chartBar.Name = "chartBar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cost";
            this.chartBar.Series.Add(series1);
            this.chartBar.Size = new System.Drawing.Size(692, 274);
            this.chartBar.TabIndex = 1;
            this.chartBar.Text = "chart1";
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.Controls.Add(this.panelPie);
            this.flowLayoutPanelBottom.Controls.Add(this.panelHBar);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 480);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(1184, 281);
            this.flowLayoutPanelBottom.TabIndex = 3;
            // 
            // panelPie
            // 
            this.panelPie.BackColor = System.Drawing.Color.White;
            this.panelPie.Controls.Add(this.labelPieTitle);
            this.panelPie.Controls.Add(this.chartPie);
            this.panelPie.Location = new System.Drawing.Point(13, 13);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(460, 250);
            this.panelPie.TabIndex = 0;
            // 
            // labelPieTitle
            // 
            this.labelPieTitle.AutoSize = true;
            this.labelPieTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPieTitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelPieTitle.Location = new System.Drawing.Point(14, 11);
            this.labelPieTitle.Name = "labelPieTitle";
            this.labelPieTitle.Size = new System.Drawing.Size(126, 21);
            this.labelPieTitle.TabIndex = 2;
            this.labelPieTitle.Text = "ĐIỂM HÀI LÒNG";
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(18, 49);
            this.chartPie.Name = "chartPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(439, 198);
            this.chartPie.TabIndex = 1;
            this.chartPie.Text = "chart2";
            // 
            // panelHBar
            // 
            this.panelHBar.BackColor = System.Drawing.Color.White;
            this.panelHBar.Controls.Add(this.labelHBarTitle);
            this.panelHBar.Controls.Add(this.chartHBar);
            this.panelHBar.Location = new System.Drawing.Point(479, 13);
            this.panelHBar.Name = "panelHBar";
            this.panelHBar.Size = new System.Drawing.Size(692, 250);
            this.panelHBar.TabIndex = 1;
            // 
            // labelHBarTitle
            // 
            this.labelHBarTitle.AutoSize = true;
            this.labelHBarTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHBarTitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelHBarTitle.Location = new System.Drawing.Point(18, 11);
            this.labelHBarTitle.Name = "labelHBarTitle";
            this.labelHBarTitle.Size = new System.Drawing.Size(248, 21);
            this.labelHBarTitle.TabIndex = 3;
            this.labelHBarTitle.Text = "THỐNG KÊ CHI PHÍ VẬT TƯ (Top)";
            // 
            // chartHBar
            // 
            chartArea3.Name = "ChartArea1";
            this.chartHBar.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHBar.Legends.Add(legend3);
            this.chartHBar.Location = new System.Drawing.Point(22, 49);
            this.chartHBar.Name = "chartHBar";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartHBar.Series.Add(series3);
            this.chartHBar.Size = new System.Drawing.Size(648, 198);
            this.chartHBar.TabIndex = 2;
            this.chartHBar.Text = "chart3";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.flowLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tổng Hợp Dashboard";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.panelPie.ResumeLayout(false);
            this.panelPie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.panelHBar.ResumeLayout(false);
            this.panelHBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblKpi1Value;
        private System.Windows.Forms.Label lblKpi1Title;
        private System.Windows.Forms.Label lblKpi2Value;
        private System.Windows.Forms.Label lblKpi2Title;
        private System.Windows.Forms.Label lblKpi3Value;
        private System.Windows.Forms.Label lblKpi3Title;
        private System.Windows.Forms.Label lblKpi4Value;
        private System.Windows.Forms.Label lblKpi4Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Panel panelHBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHBar;
        private System.Windows.Forms.Label labelPieTitle;
        private System.Windows.Forms.Label labelHBarTitle;
    }
}
