namespace WashablesSystem
{
    partial class MissingItem
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
            this.sameDateContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLaundry = new WashablesSystem.CustomDatePicker();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.btnResolve = new WashablesSystem.CustomButton();
            this.SuspendLayout();
            // 
            // sameDateContainer
            // 
            this.sameDateContainer.AutoScroll = true;
            this.sameDateContainer.BackColor = System.Drawing.Color.Transparent;
            this.sameDateContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sameDateContainer.Location = new System.Drawing.Point(25, 157);
            this.sameDateContainer.Margin = new System.Windows.Forms.Padding(2);
            this.sameDateContainer.Name = "sameDateContainer";
            this.sameDateContainer.Size = new System.Drawing.Size(332, 150);
            this.sameDateContainer.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "Laundries on the Same Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "Date of Laundry";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(16, 20);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(146, 21);
            this.lblHeader.TabIndex = 94;
            this.lblHeader.Text = "Find Missing Item";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "___________________________________________";
            // 
            // dateLaundry
            // 
            this.dateLaundry.BorderColor = System.Drawing.Color.Silver;
            this.dateLaundry.BorderSize = 1;
            this.dateLaundry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLaundry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLaundry.Location = new System.Drawing.Point(25, 89);
            this.dateLaundry.Margin = new System.Windows.Forms.Padding(2);
            this.dateLaundry.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateLaundry.Name = "dateLaundry";
            this.dateLaundry.Size = new System.Drawing.Size(332, 35);
            this.dateLaundry.SkinColor = System.Drawing.SystemColors.Control;
            this.dateLaundry.TabIndex = 39;
            this.dateLaundry.TextColor = System.Drawing.Color.Black;
            this.dateLaundry.ValueChanged += new System.EventHandler(this.dateLaundry_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(211, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnResolve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnResolve.BorderColor = System.Drawing.Color.Transparent;
            this.btnResolve.BorderRadius = 15;
            this.btnResolve.BorderSize = 0;
            this.btnResolve.FlatAppearance.BorderSize = 0;
            this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolve.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.ForeColor = System.Drawing.Color.White;
            this.btnResolve.Location = new System.Drawing.Point(57, 321);
            this.btnResolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(150, 29);
            this.btnResolve.TabIndex = 30;
            this.btnResolve.Text = "Mark as Solved";
            this.btnResolve.TextColor = System.Drawing.Color.White;
            this.btnResolve.UseVisualStyleBackColor = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // MissingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sameDateContainer);
            this.Controls.Add(this.dateLaundry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResolve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MissingItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MissingItem_FormClosed);
            this.Load += new System.EventHandler(this.MissingItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton btnResolve;
        private CustomButton btnCancel;
        private CustomDatePicker dateLaundry;
        private System.Windows.Forms.FlowLayoutPanel sameDateContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
    }
}
