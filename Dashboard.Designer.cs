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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.panel1.Location = new System.Drawing.Point(32, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 346);
            this.panel1.TabIndex = 3;
            // 
            // chartSales
            // 
            this.chartSales.BackColor = System.Drawing.Color.Transparent;
            this.chartSales.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chartSales.Legends.Add(legend10);
            this.chartSales.Location = new System.Drawing.Point(-20, 55);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series16.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series16.ChartArea = "ChartArea1";
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartSales.Series.Add(series16);
            this.chartSales.Size = new System.Drawing.Size(742, 288);
            this.chartSales.TabIndex = 16;
            this.chartSales.Text = "chart1";
            // 
            // cbTimeSales
            // 
            this.cbTimeSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeSales.BorderSize = 1;
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
            this.cbTimeSales.Location = new System.Drawing.Point(481, 11);
            this.cbTimeSales.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTimeSales.Name = "cbTimeSales";
            this.cbTimeSales.Padding = new System.Windows.Forms.Padding(1);
            this.cbTimeSales.Size = new System.Drawing.Size(211, 38);
            this.cbTimeSales.TabIndex = 15;
            this.cbTimeSales.Texts = "This Month";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(3, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(81, 38);
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
            this.panel2.Location = new System.Drawing.Point(32, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 344);
            this.panel2.TabIndex = 4;
            // 
            // cbTimeKilos
            // 
            this.cbTimeKilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeKilos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeKilos.BorderSize = 1;
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
            this.cbTimeKilos.Location = new System.Drawing.Point(536, 15);
            this.cbTimeKilos.MinimumSize = new System.Drawing.Size(170, 30);
            this.cbTimeKilos.Name = "cbTimeKilos";
            this.cbTimeKilos.Padding = new System.Windows.Forms.Padding(1);
            this.cbTimeKilos.Size = new System.Drawing.Size(170, 38);
            this.cbTimeKilos.TabIndex = 17;
            this.cbTimeKilos.Texts = "This Week";
            // 
            // cbMachine
            // 
            this.cbMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbMachine.BorderSize = 1;
            this.cbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMachine.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMachine.ForeColor = System.Drawing.Color.Black;
            this.cbMachine.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbMachine.Items.AddRange(new object[] {
            "Dryer",
            "Iron"});
            this.cbMachine.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMachine.ListTextColor = System.Drawing.Color.Black;
            this.cbMachine.Location = new System.Drawing.Point(383, 15);
            this.cbMachine.MinimumSize = new System.Drawing.Size(150, 30);
            this.cbMachine.Name = "cbMachine";
            this.cbMachine.Padding = new System.Windows.Forms.Padding(1);
            this.cbMachine.Size = new System.Drawing.Size(150, 38);
            this.cbMachine.TabIndex = 16;
            this.cbMachine.Texts = "Washer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kilograms Handled by Units";
            // 
            // chartKgs
            // 
            this.chartKgs.BackColor = System.Drawing.Color.Transparent;
            this.chartKgs.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            chartArea11.Position.Auto = false;
            chartArea11.Position.Height = 94F;
            chartArea11.Position.Width = 78F;
            chartArea11.Position.X = 3F;
            chartArea11.Position.Y = 3F;
            this.chartKgs.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.BorderWidth = 0;
            legend11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend11.IsTextAutoFit = false;
            legend11.ItemColumnSpacing = 20;
            legend11.Name = "Legend1";
            legend11.Position.Auto = false;
            legend11.Position.Height = 33.10104F;
            legend11.Position.Width = 17.60753F;
            legend11.Position.X = 80.39247F;
            legend11.Position.Y = 3F;
            legend11.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartKgs.Legends.Add(legend11);
            this.chartKgs.Location = new System.Drawing.Point(-17, 56);
            this.chartKgs.Name = "chartKgs";
            this.chartKgs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series17.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series17.Legend = "Legend1";
            series17.Name = "Unit I";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Unit II";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Unit III";
            this.chartKgs.Series.Add(series17);
            this.chartKgs.Series.Add(series18);
            this.chartKgs.Series.Add(series19);
            this.chartKgs.Size = new System.Drawing.Size(745, 288);
            this.chartKgs.TabIndex = 17;
            this.chartKgs.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.cbTimeServices);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chartServices);
            this.panel3.Location = new System.Drawing.Point(750, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 346);
            this.panel3.TabIndex = 4;
            // 
            // cbTimeServices
            // 
            this.cbTimeServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeServices.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbTimeServices.BorderSize = 1;
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
            this.cbTimeServices.Location = new System.Drawing.Point(477, 11);
            this.cbTimeServices.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbTimeServices.Name = "cbTimeServices";
            this.cbTimeServices.Padding = new System.Windows.Forms.Padding(1);
            this.cbTimeServices.Size = new System.Drawing.Size(211, 38);
            this.cbTimeServices.TabIndex = 16;
            this.cbTimeServices.Texts = "This Week";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Most Availed Services";
            // 
            // chartServices
            // 
            this.chartServices.BackColor = System.Drawing.Color.Transparent;
            this.chartServices.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartServices.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.chartServices.Legends.Add(legend12);
            this.chartServices.Location = new System.Drawing.Point(3, 37);
            this.chartServices.Name = "chartServices";
            this.chartServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series20.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            series20.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series20.IsValueShownAsLabel = true;
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chartServices.Series.Add(series20);
            this.chartServices.Size = new System.Drawing.Size(701, 322);
            this.chartServices.TabIndex = 17;
            this.chartServices.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.btnSeeAll);
            this.panel4.Controls.Add(this.activityPanel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(750, 425);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 344);
            this.panel4.TabIndex = 5;
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeeAll.AutoSize = true;
            this.btnSeeAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnSeeAll.Location = new System.Drawing.Point(606, 15);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(82, 30);
            this.btnSeeAll.TabIndex = 51;
            this.btnSeeAll.Text = "See All";
            // 
            // activityPanel
            // 
            this.activityPanel.Location = new System.Drawing.Point(16, 59);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(672, 266);
            this.activityPanel.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
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
            this.customButton1.Location = new System.Drawing.Point(1219, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(238, 47);
            this.customButton1.TabIndex = 2;
            this.customButton1.Text = "Generate Report";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 804);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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