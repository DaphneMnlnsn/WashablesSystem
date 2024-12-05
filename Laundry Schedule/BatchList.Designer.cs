namespace WashablesSystem.Laundry_Schedule
{
    partial class BatchList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.UnitUsed = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.Label();
            this.Weights = new System.Windows.Forms.Label();
            this.ORNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ActualTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.ScheduleTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.actualTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 2F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(903, -37);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(14, 4);
            this.lblStatus.TabIndex = 96;
            this.lblStatus.Text = "Playing";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(824, 5);
            this.TimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(0, 17);
            this.TimeLeft.TabIndex = 84;
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitUsed
            // 
            this.UnitUsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitUsed.AutoSize = true;
            this.UnitUsed.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.UnitUsed.Location = new System.Drawing.Point(171, 7);
            this.UnitUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnitUsed.Name = "UnitUsed";
            this.UnitUsed.Size = new System.Drawing.Size(57, 13);
            this.UnitUsed.TabIndex = 78;
            this.UnitUsed.Text = "Unit Used";
            this.UnitUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Services
            // 
            this.Services.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Services.AutoSize = true;
            this.Services.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.Services.Location = new System.Drawing.Point(261, 7);
            this.Services.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(48, 13);
            this.Services.TabIndex = 79;
            this.Services.Text = "Services";
            this.Services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weights
            // 
            this.Weights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weights.AutoSize = true;
            this.Weights.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.Weights.Location = new System.Drawing.Point(341, 7);
            this.Weights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weights.Name = "Weights";
            this.Weights.Size = new System.Drawing.Size(68, 13);
            this.Weights.TabIndex = 82;
            this.Weights.Text = "Weight (kg)";
            this.Weights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ORNo
            // 
            this.ORNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ORNo.AutoSize = true;
            this.ORNo.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.ORNo.Location = new System.Drawing.Point(6, 7);
            this.ORNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ORNo.Name = "ORNo";
            this.ORNo.Size = new System.Drawing.Size(25, 13);
            this.ORNo.TabIndex = 77;
            this.ORNo.Text = "No.";
            this.ORNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Controls.Add(this.ActualTime, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.UnitUsed, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPause, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLeft, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScheduleTime, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Weights, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Services, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ORNo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-4, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(929, 0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(929, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 27);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // ActualTime
            // 
            this.ActualTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualTime.AutoSize = true;
            this.ActualTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualTime.Location = new System.Drawing.Point(617, 5);
            this.ActualTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActualTime.Name = "ActualTime";
            this.ActualTime.Size = new System.Drawing.Size(0, 17);
            this.ActualTime.TabIndex = 87;
            this.ActualTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.Image = global::WashablesSystem.Properties.Resources.Pause;
            this.btnPause.Location = new System.Drawing.Point(871, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(28, 27);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 85;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleTime.AutoSize = true;
            this.ScheduleTime.Font = new System.Drawing.Font("Segoe UI Semibold", 7.75F, System.Drawing.FontStyle.Bold);
            this.ScheduleTime.Location = new System.Drawing.Point(447, 7);
            this.ScheduleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.Size = new System.Drawing.Size(87, 13);
            this.ScheduleTime.TabIndex = 81;
            this.ScheduleTime.Text = "Scheduled Time";
            this.ScheduleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________________";
            // 
            // timeLeftTimer
            // 
            this.timeLeftTimer.Enabled = true;
            this.timeLeftTimer.Interval = 1000;
            this.timeLeftTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // actualTimeTimer
            // 
            this.actualTimeTimer.Interval = 1000;
            this.actualTimeTimer.Tick += new System.EventHandler(this.actualTimeTimer_Tick);
            // 
            // BatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(940, 0);
            this.Name = "BatchList";
            this.Size = new System.Drawing.Size(929, 32);
            this.Load += new System.EventHandler(this.InProgressList_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label UnitUsed;
        private System.Windows.Forms.Label Services;
        private System.Windows.Forms.Label Weights;
        private System.Windows.Forms.Label ORNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ActualTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeLeftTimer;
        private System.Windows.Forms.Timer actualTimeTimer;
        private System.Windows.Forms.Label ScheduleTime;
    }
}