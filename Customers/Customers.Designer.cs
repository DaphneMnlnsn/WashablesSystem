namespace WashablesSystem
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnCustomerArchive = new System.Windows.Forms.Button();
            this.panelTab = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new WashablesSystem.CustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Customer Information";
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCustomerInfo.FlatAppearance.BorderSize = 0;
            this.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInfo.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnCustomerInfo.Location = new System.Drawing.Point(23, 60);
            this.btnCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(99, 32);
            this.btnCustomerInfo.TabIndex = 4;
            this.btnCustomerInfo.Text = "Customers";
            this.btnCustomerInfo.UseVisualStyleBackColor = false;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // btnComplaints
            // 
            this.btnComplaints.BackColor = System.Drawing.Color.Transparent;
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaints.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnComplaints.Location = new System.Drawing.Point(121, 60);
            this.btnComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(179, 32);
            this.btnComplaints.TabIndex = 5;
            this.btnComplaints.Text = "Customer Complaints";
            this.btnComplaints.UseVisualStyleBackColor = false;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnCustomerArchive
            // 
            this.btnCustomerArchive.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerArchive.FlatAppearance.BorderSize = 0;
            this.btnCustomerArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerArchive.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnCustomerArchive.Location = new System.Drawing.Point(300, 60);
            this.btnCustomerArchive.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerArchive.Name = "btnCustomerArchive";
            this.btnCustomerArchive.Size = new System.Drawing.Size(99, 32);
            this.btnCustomerArchive.TabIndex = 6;
            this.btnCustomerArchive.Text = "Archive";
            this.btnCustomerArchive.UseVisualStyleBackColor = false;
            this.btnCustomerArchive.Click += new System.EventHandler(this.btnCustomerArchive_Click);
            // 
            // panelTab
            // 
            this.panelTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTab.Location = new System.Drawing.Point(23, 91);
            this.panelTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(947, 403);
            this.panelTab.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::WashablesSystem.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(940, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TabStop = false;
            this.btnSearch.Visible = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearch.BorderColor = System.Drawing.Color.Black;
            this.txtBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxSearch.BorderRadius = 15;
            this.txtBoxSearch.BorderSize = 1;
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.Location = new System.Drawing.Point(691, 60);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxSearch.PasswordChar = false;
            this.txtBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(279, 26);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.UnderlinedStyle = false;
            this.txtBoxSearch.Visible = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.btnCustomerArchive);
            this.Controls.Add(this.btnComplaints);
            this.Controls.Add(this.btnCustomerInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnComplaints;
        private System.Windows.Forms.Button btnCustomerArchive;
        private System.Windows.Forms.Panel panelTab;
        private CustomTextbox txtBoxSearch;
        private System.Windows.Forms.PictureBox btnSearch;
    }
}