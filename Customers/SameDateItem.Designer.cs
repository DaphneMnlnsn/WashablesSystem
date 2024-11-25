﻿namespace WashablesSystem
{
    partial class SameDateItem
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
            this.lblCust = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCust
            // 
            this.lblCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.Color.Black;
            this.lblCust.Location = new System.Drawing.Point(14, 18);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(174, 30);
            this.lblCust.TabIndex = 99;
            this.lblCust.Text = "Customer Name";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.Black;
            this.lblUnit.Location = new System.Drawing.Point(14, 60);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(153, 30);
            this.lblUnit.TabIndex = 100;
            this.lblUnit.Text = "Machine Used";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(154, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(211, 30);
            this.lblDate.TabIndex = 101;
            this.lblDate.Text = "10/14/2024 11:30AM";
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetails.Image = global::WashablesSystem.Properties.Resources.More_Details;
            this.btnDetails.Location = new System.Drawing.Point(387, 23);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(60, 60);
            this.btnDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDetails.TabIndex = 102;
            this.btnDetails.TabStop = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 100);
            this.panel1.TabIndex = 103;
            // 
            // SameDateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.panel1);
            this.Name = "SameDateItem";
            this.Size = new System.Drawing.Size(457, 110);
            ((System.ComponentModel.ISupportInitialize)(this.btnDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox btnDetails;
        private System.Windows.Forms.Panel panel1;
    }
}