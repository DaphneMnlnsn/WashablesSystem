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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series61 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series62 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series63 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea39 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend39 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbTimeSales = new WashablesSystem.CustomComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTimeKilos = new WashablesSystem.CustomComboBox();
            this.cbMachine = new WashablesSystem.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartKgs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTimeServices = new WashablesSystem.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartServices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSeeAll = new System.Windows.Forms.Label();
            this.activityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.customButton1 = new WashablesSystem.CustomButton();
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
            chartArea37.BackColor = System.Drawing.Color.Transparent;
            chartArea37.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea37);
            legend37.Enabled = false;
            legend37.Name = "Legend1";
            this.chartSales.Legends.Add(legend37);
            this.chartSales.Location = new System.Drawing.Point(-13, 36);
            this.chartSales.Margin = new System.Windows.Forms.Padding(2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series61.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series61.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series61.ChartArea = "ChartArea1";
            series61.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series61.Legend = "Legend1";
            series61.Name = "Series1";
            this.chartSales.Series.Add(series61);
            this.chartSales.Size = new System.Drawing.Size(495, 187);
            this.chartSales.TabIndex = 16;
            this.chartSales.Text = "chart1";
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
            "This Year",
            "This Month",
            "This Week",
            "Today"});
            this.cbTimeSales.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeSales.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeSales.Location = new System.Drawing.Point(321, 7);
            this.cbTimeSales.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeSales.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbTimeSales.Name = "cbTimeSales";
            this.cbTimeSales.Size = new System.Drawing.Size(140, 25);
            this.cbTimeSales.TabIndex = 15;
            this.cbTimeSales.Texts = "This Month";
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
            this.panel2.Controls.Add(this.cbTimeKilos);
            this.panel2.Controls.Add(this.cbMachine);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chartKgs);
            this.panel2.Location = new System.Drawing.Point(21, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 224);
            this.panel2.TabIndex = 4;
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
            "This Year",
            "This Month",
            "This Week",
            "Today"});
            this.cbTimeKilos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeKilos.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeKilos.Location = new System.Drawing.Point(345, 10);
            this.cbTimeKilos.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeKilos.MinimumSize = new System.Drawing.Size(113, 20);
            this.cbTimeKilos.Name = "cbTimeKilos";
            this.cbTimeKilos.Size = new System.Drawing.Size(127, 25);
            this.cbTimeKilos.TabIndex = 17;
            this.cbTimeKilos.Texts = "This Week";
            // 
            // cbMachine
            // 
            this.cbMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbMachine.BorderSize = 0;
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMachine.ForeColor = System.Drawing.Color.Black;
            this.cbMachine.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbMachine.Items.AddRange(new object[] {
            "Dryer",
            "Iron"});
            this.cbMachine.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMachine.ListTextColor = System.Drawing.Color.Black;
            this.cbMachine.Location = new System.Drawing.Point(244, 10);
            this.cbMachine.Margin = new System.Windows.Forms.Padding(2);
            this.cbMachine.MinimumSize = new System.Drawing.Size(100, 20);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Size = new System.Drawing.Size(100, 25);
            this.cbMachine.TabIndex = 16;
            this.cbMachine.Texts = "Washer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kilograms Handled by Units";
            // 
            // chartKgs
            // 
            this.chartKgs.BackColor = System.Drawing.Color.Transparent;
            this.chartKgs.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea38.BackColor = System.Drawing.Color.Transparent;
            chartArea38.Name = "ChartArea1";
            chartArea38.Position.Auto = false;
            chartArea38.Position.Height = 94F;
            chartArea38.Position.Width = 78F;
            chartArea38.Position.X = 3F;
            chartArea38.Position.Y = 3F;
            this.chartKgs.ChartAreas.Add(chartArea38);
            legend38.BackColor = System.Drawing.Color.Transparent;
            legend38.BorderWidth = 0;
            legend38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend38.IsTextAutoFit = false;
            legend38.ItemColumnSpacing = 20;
            legend38.Name = "Legend1";
            legend38.Position.Auto = false;
            legend38.Position.Height = 33.10104F;
            legend38.Position.Width = 17.60753F;
            legend38.Position.X = 80.39247F;
            legend38.Position.Y = 3F;
            legend38.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartKgs.Legends.Add(legend38);
            this.chartKgs.Location = new System.Drawing.Point(-11, 36);
            this.chartKgs.Margin = new System.Windows.Forms.Padding(2);
            this.chartKgs.Name = "chartKgs";
            this.chartKgs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series62.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series62.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series62.ChartArea = "ChartArea1";
            series62.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series62.Legend = "Legend1";
            series62.Name = "Unit I";
            series63.ChartArea = "ChartArea1";
            series63.Legend = "Legend1";
            series63.Name = "Unit II";
            series64.ChartArea = "ChartArea1";
            series64.Legend = "Legend1";
            series64.Name = "Unit III";
            this.chartKgs.Series.Add(series62);
            this.chartKgs.Series.Add(series63);
            this.chartKgs.Series.Add(series64);
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
            "This Year",
            "This Month",
            "This Week",
            "Today"});
            this.cbTimeServices.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbTimeServices.ListTextColor = System.Drawing.Color.Black;
            this.cbTimeServices.Location = new System.Drawing.Point(318, 7);
            this.cbTimeServices.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeServices.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbTimeServices.Name = "cbTimeServices";
            this.cbTimeServices.Size = new System.Drawing.Size(133, 25);
            this.cbTimeServices.TabIndex = 16;
            this.cbTimeServices.Texts = "This Week";
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
            chartArea39.BackColor = System.Drawing.Color.Transparent;
            chartArea39.Name = "ChartArea1";
            this.chartServices.ChartAreas.Add(chartArea39);
            legend39.BackColor = System.Drawing.Color.Transparent;
            legend39.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend39.IsTextAutoFit = false;
            legend39.Name = "Legend1";
            this.chartServices.Legends.Add(legend39);
            this.chartServices.Location = new System.Drawing.Point(2, 24);
            this.chartServices.Margin = new System.Windows.Forms.Padding(2);
            this.chartServices.Name = "chartServices";
            this.chartServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series65.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series65.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series65.ChartArea = "ChartArea1";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series65.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series65.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series65.IsValueShownAsLabel = true;
            series65.Legend = "Legend1";
            series65.Name = "Series1";
            this.chartServices.Series.Add(series65);
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
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 6;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(813, 8);
            this.customButton1.Margin = new System.Windows.Forms.Padding(2);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(159, 31);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Generate Report";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.customButton1);
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
        private CustomButton customButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomComboBox cbTimeSales;
        private CustomComboBox cbMachine;
        private CustomComboBox cbTimeKilos;
        private CustomComboBox cbTimeServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel activityPanel;
        private System.Windows.Forms.Label btnSeeAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKgs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartServices;
    }
}