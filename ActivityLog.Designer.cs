namespace WashablesSystem
{
    partial class ActivityLog
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_no = new System.Windows.Forms.Label();
            this.activityContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.customDatePicker1 = new WashablesSystem.CustomDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.customButton1 = new WashablesSystem.CustomButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(21, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(167, 38);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "Activity Log";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 397F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 622F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.employee_no, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-2, 81);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1422, 57);
            this.tableLayoutPanel2.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1048, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 79;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 78;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employee_no
            // 
            this.employee_no.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employee_no.AutoSize = true;
            this.employee_no.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_no.Location = new System.Drawing.Point(163, 15);
            this.employee_no.Name = "employee_no";
            this.employee_no.Size = new System.Drawing.Size(74, 26);
            this.employee_no.TabIndex = 77;
            this.employee_no.Text = "Name";
            this.employee_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activityContainer
            // 
            this.activityContainer.AutoScroll = true;
            this.activityContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.activityContainer.Location = new System.Drawing.Point(-2, 141);
            this.activityContainer.Name = "activityContainer";
            this.activityContainer.Size = new System.Drawing.Size(1422, 480);
            this.activityContainer.TabIndex = 91;
            // 
            // customDatePicker1
            // 
            this.customDatePicker1.BorderColor = System.Drawing.Color.Black;
            this.customDatePicker1.BorderSize = 1;
            this.customDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDatePicker1.Location = new System.Drawing.Point(1028, 25);
            this.customDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.customDatePicker1.Name = "customDatePicker1";
            this.customDatePicker1.Size = new System.Drawing.Size(177, 35);
            this.customDatePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customDatePicker1.TabIndex = 92;
            this.customDatePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 93;
            this.label3.Text = "Filter by Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.customButton1.BorderColor = System.Drawing.Color.Black;
            this.customButton1.BorderRadius = 6;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(1219, 21);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(175, 39);
            this.customButton1.TabIndex = 94;
            this.customButton1.Text = "Print Log";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // ActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1419, 619);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customDatePicker1);
            this.Controls.Add(this.activityContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityLog";
            this.Text = "CustomerInfo";
            this.Load += new System.EventHandler(this.ActivityLog_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label employee_no;
        private System.Windows.Forms.FlowLayoutPanel activityContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomDatePicker customDatePicker1;
        private System.Windows.Forms.Label label3;
        private CustomButton customButton1;
    }
}