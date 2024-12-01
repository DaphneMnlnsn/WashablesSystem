namespace WashablesSystem
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chartKgs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartServices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSeeAll = new System.Windows.Forms.Label();
            this.activityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimeServices = new WashablesSystem.CustomComboBox();
            this.cbMachine = new WashablesSystem.CustomComboBox();
            this.cbTimeKilos = new WashablesSystem.CustomComboBox();
            this.cbTimeSales = new WashablesSystem.CustomComboBox();
            this.btnReport = new WashablesSystem.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKgs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartServices)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.chartSales);
            this.panel1.Controls.Add(this.cbTimeSales);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(21, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 225);
            this.panel1.TabIndex = 3;
            // 
            // chartSales
            // 
            this.chartSales.BackColor = System.Drawing.Color.Transparent;
            this.chartSales.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea22.BackColor = System.Drawing.Color.Transparent;
            chartArea22.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea22);
            legend22.Enabled = false;
            legend22.Name = "Legend1";
            this.chartSales.Legends.Add(legend22);
            this.chartSales.Location = new System.Drawing.Point(-13, 36);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series36.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series36.ChartArea = "ChartArea1";
            series36.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series36.Legend = "Legend1";
            series36.Name = "Series1";
            this.chartSales.Series.Add(series36);
            this.chartSales.Size = new System.Drawing.Size(495, 187);
            this.chartSales.TabIndex = 16;
            this.chartSales.Text = "chart1";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(2, 4);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(55, 25);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Sales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.cbMachine);
            this.panel2.Controls.Add(this.cbTimeKilos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chartKgs);
            this.panel2.Location = new System.Drawing.Point(21, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 224);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kilograms Handled by Units";
            // 
            // chartKgs
            // 
            this.chartKgs.BackColor = System.Drawing.Color.Transparent;
            this.chartKgs.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea23.BackColor = System.Drawing.Color.Transparent;
            chartArea23.Name = "ChartArea1";
            chartArea23.Position.Auto = false;
            chartArea23.Position.Height = 94F;
            chartArea23.Position.Width = 78F;
            chartArea23.Position.X = 3F;
            chartArea23.Position.Y = 3F;
            this.chartKgs.ChartAreas.Add(chartArea23);
            legend23.BackColor = System.Drawing.Color.Transparent;
            legend23.BorderWidth = 0;
            legend23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend23.IsTextAutoFit = false;
            legend23.ItemColumnSpacing = 20;
            legend23.Name = "Legend1";
            legend23.Position.Auto = false;
            legend23.Position.Height = 33.10104F;
            legend23.Position.Width = 17.60753F;
            legend23.Position.X = 80.39247F;
            legend23.Position.Y = 3F;
            legend23.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartKgs.Legends.Add(legend23);
            this.chartKgs.Location = new System.Drawing.Point(-11, 36);
            this.chartKgs.Margin = new System.Windows.Forms.Padding(2);
            this.chartKgs.Name = "chartKgs";
            this.chartKgs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series37.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series37.ChartArea = "ChartArea1";
            series37.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series37.Legend = "Legend1";
            series37.Name = "Unit I";
            series38.ChartArea = "ChartArea1";
            series38.Legend = "Legend1";
            series38.Name = "Unit II";
            series39.ChartArea = "ChartArea1";
            series39.Legend = "Legend1";
            series39.Name = "Unit III";
            this.chartKgs.Series.Add(series37);
            this.chartKgs.Series.Add(series38);
            this.chartKgs.Series.Add(series39);
            this.chartKgs.Size = new System.Drawing.Size(497, 187);
            this.chartKgs.TabIndex = 17;
            this.chartKgs.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.cbTimeServices);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chartServices);
            this.panel3.Location = new System.Drawing.Point(500, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 225);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Most Availed Services";
            // 
            // chartServices
            // 
            this.chartServices.BackColor = System.Drawing.Color.Transparent;
            this.chartServices.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea24.BackColor = System.Drawing.Color.Transparent;
            chartArea24.Name = "ChartArea1";
            this.chartServices.ChartAreas.Add(chartArea24);
            legend24.BackColor = System.Drawing.Color.Transparent;
            legend24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend24.IsTextAutoFit = false;
            legend24.Name = "Legend1";
            this.chartServices.Legends.Add(legend24);
            this.chartServices.Location = new System.Drawing.Point(2, 24);
            this.chartServices.Margin = new System.Windows.Forms.Padding(2);
            this.chartServices.Name = "chartServices";
            this.chartServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series40.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series40.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series40.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series40.IsValueShownAsLabel = true;
            series40.Legend = "Legend1";
            series40.Name = "Series1";
            this.chartServices.Series.Add(series40);
            this.chartServices.Size = new System.Drawing.Size(467, 209);
            this.chartServices.TabIndex = 17;
            this.chartServices.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.btnSeeAll);
            this.panel4.Controls.Add(this.activityPanel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(500, 276);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 224);
            this.panel4.TabIndex = 5;
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeeAll.AutoSize = true;
            this.btnSeeAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnSeeAll.Location = new System.Drawing.Point(404, 10);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(56, 20);
            this.btnSeeAll.TabIndex = 51;
            this.btnSeeAll.Text = "See All";
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // activityPanel
            // 
            this.activityPanel.Location = new System.Drawing.Point(11, 38);
            this.activityPanel.Margin = new System.Windows.Forms.Padding(2);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(448, 173);
            this.activityPanel.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Activity Log";
            // 
            // cbTimeServices
            // 
            this.cbTimeServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeServices.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeServices.BorderSize = 0;
            this.cbTimeServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeServices.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeServices.ForeColor = System.Drawing.Color.Black;
            this.cbTimeServices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbTimeServices.Items.AddRange(new object[] {
            "This Week",
            "This Month",
            "This Year"});
            this.cbTimeServices.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeServices.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeServices.Location = new System.Drawing.Point(318, 7);
            this.cbTimeServices.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeServices.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbTimeServices.Name = "cbTimeServices";
            this.cbTimeServices.Size = new System.Drawing.Size(133, 25);
            this.cbTimeServices.TabIndex = 16;
            this.cbTimeServices.Texts = "This Week";
            this.cbTimeServices.OnSelectedIndexChanged += new System.EventHandler(this.cbTimeServices_OnSelectedIndexChanged);
            // 
            // cbMachine
            // 
            this.cbMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbMachine.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMachine.BorderSize = 0;
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMachine.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.cbMachine.ForeColor = System.Drawing.Color.Black;
            this.cbMachine.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbMachine.Items.AddRange(new object[] {
            "Washer",
            "Dryer",
            "Iron"});
            this.cbMachine.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMachine.ListTextColor = System.Drawing.Color.Black;
            this.cbMachine.Location = new System.Drawing.Point(227, 10);
            this.cbMachine.MinimumSize = new System.Drawing.Size(113, 20);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(113, 25);
            this.cbMachine.TabIndex = 18;
            this.cbMachine.Texts = "Washer";
            this.cbMachine.OnSelectedIndexChanged += new System.EventHandler(this.cbMachine_OnSelectedIndexChanged);
            // 
            // cbTimeKilos
            // 
            this.cbTimeKilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeKilos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeKilos.BorderSize = 0;
            this.cbTimeKilos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeKilos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeKilos.ForeColor = System.Drawing.Color.Black;
            this.cbTimeKilos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbTimeKilos.Items.AddRange(new object[] {
            "This Week",
            "This Month",
            "This Year"});
            this.cbTimeKilos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeKilos.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeKilos.Location = new System.Drawing.Point(345, 10);
            this.cbTimeKilos.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeKilos.MinimumSize = new System.Drawing.Size(113, 20);
            this.cbTimeKilos.Name = "cbTimeKilos";
            this.cbTimeKilos.Size = new System.Drawing.Size(127, 25);
            this.cbTimeKilos.TabIndex = 17;
            this.cbTimeKilos.Texts = "This Week";
            this.cbTimeKilos.OnSelectedIndexChanged += new System.EventHandler(this.cbMachine_OnSelectedIndexChanged);
            // 
            // cbTimeSales
            // 
            this.cbTimeSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeSales.BorderSize = 0;
            this.cbTimeSales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeSales.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeSales.ForeColor = System.Drawing.Color.Black;
            this.cbTimeSales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbTimeSales.Items.AddRange(new object[] {
            "This Week",
            "This Month",
            "This Year"});
            this.cbTimeSales.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeSales.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeSales.Location = new System.Drawing.Point(321, 7);
            this.cbTimeSales.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeSales.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbTimeSales.Name = "cbTimeSales";
            this.cbTimeSales.Size = new System.Drawing.Size(140, 25);
            this.cbTimeSales.TabIndex = 15;
            this.cbTimeSales.Texts = "This Week";
            this.cbTimeSales.OnSelectedIndexChanged += new System.EventHandler(this.cbTimeSales_OnSelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderRadius = 6;
            this.btnReport.BorderSize = 0;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(813, 8);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(159, 31);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Generate Report";
            this.btnReport.TextColor = System.Drawing.Color.Black;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKgs)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartServices)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComboBox cbTimeServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel activityPanel;
        private System.Windows.Forms.Label btnSeeAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKgs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartServices;
        private CustomComboBox cbTimeSales;
        private CustomComboBox cbMachine;
        private CustomComboBox cbTimeKilos;
    }
}