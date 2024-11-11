namespace WashablesSystem
{
    partial class FinishedList

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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerName = new System.Windows.Forms.Label();
            this.ORNo = new System.Windows.Forms.Label();
            this.Weights = new System.Windows.Forms.Label();
            this.PickUpDate = new System.Windows.Forms.Label();
            this.ScheduleTime = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.Services = new System.Windows.Forms.Label();
            this.UnitUsed = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Controls.Add(this.CustomerName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ORNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Weights, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.PickUpDate, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScheduleTime, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.TimeLeft, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Services, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.UnitUsed, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBill, 8, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-4, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(948, 77);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(59, 30);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(107, 17);
            this.CustomerName.TabIndex = 80;
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ORNo
            // 
            this.ORNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ORNo.AutoSize = true;
            this.ORNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORNo.Location = new System.Drawing.Point(9, 30);
            this.ORNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ORNo.Name = "ORNo";
            this.ORNo.Size = new System.Drawing.Size(29, 17);
            this.ORNo.TabIndex = 77;
            this.ORNo.Text = "No.";
            this.ORNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weights
            // 
            this.Weights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weights.AutoSize = true;
            this.Weights.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weights.Location = new System.Drawing.Point(409, 30);
            this.Weights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weights.Name = "Weights";
            this.Weights.Size = new System.Drawing.Size(79, 17);
            this.Weights.TabIndex = 82;
            this.Weights.Text = "Weight (kg)";
            this.Weights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PickUpDate
            // 
            this.PickUpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PickUpDate.AutoSize = true;
            this.PickUpDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickUpDate.Location = new System.Drawing.Point(713, 21);
            this.PickUpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Size = new System.Drawing.Size(52, 34);
            this.PickUpDate.TabIndex = 83;
            this.PickUpDate.Text = "Pick up Date";
            this.PickUpDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScheduleTime
            // 
            this.ScheduleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleTime.AutoSize = true;
            this.ScheduleTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleTime.Location = new System.Drawing.Point(543, 30);
            this.ScheduleTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScheduleTime.Name = "ScheduleTime";
            this.ScheduleTime.Size = new System.Drawing.Size(103, 17);
            this.ScheduleTime.TabIndex = 81;
            this.ScheduleTime.Text = "Scheduled Time";
            this.ScheduleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeft.Location = new System.Drawing.Point(797, 30);
            this.TimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(80, 17);
            this.TimeLeft.TabIndex = 84;
            this.TimeLeft.Text = "Finished On";
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Services
            // 
            this.Services.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Services.AutoSize = true;
            this.Services.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(319, 30);
            this.Services.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(57, 17);
            this.Services.TabIndex = 79;
            this.Services.Text = "Services";
            this.Services.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitUsed
            // 
            this.UnitUsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitUsed.AutoSize = true;
            this.UnitUsed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitUsed.Location = new System.Drawing.Point(201, 30);
            this.UnitUsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnitUsed.Name = "UnitUsed";
            this.UnitUsed.Size = new System.Drawing.Size(67, 17);
            this.UnitUsed.TabIndex = 78;
            this.UnitUsed.Text = "Unit Used";
            this.UnitUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBill
            // 
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBill.Image = global::WashablesSystem.Properties.Resources.Bill;
            this.btnBill.Location = new System.Drawing.Point(897, 25);
            this.btnBill.Margin = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(30, 27);
            this.btnBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBill.TabIndex = 85;
            this.btnBill.TabStop = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________________";
            // 
            // FinishedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FinishedList";
            this.Size = new System.Drawing.Size(941, 85);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ORNo;
        private System.Windows.Forms.Label ScheduleTime;
        private System.Windows.Forms.Label Weights;
        private System.Windows.Forms.Label PickUpDate;
        private System.Windows.Forms.Label UnitUsed;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label Services;
        private System.Windows.Forms.PictureBox btnBill;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label label1;
    }
}