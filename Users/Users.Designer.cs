namespace WashablesSystem
{
    partial class Users
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
            this.btnUserAccount = new System.Windows.Forms.Button();
            this.btnUserArchive = new System.Windows.Forms.Button();
            this.btnActivityLog = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage User Accounts";
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnUserAccount.FlatAppearance.BorderSize = 0;
            this.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAccount.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnUserAccount.Location = new System.Drawing.Point(23, 60);
            this.btnUserAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(119, 32);
            this.btnUserAccount.TabIndex = 4;
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.UseVisualStyleBackColor = false;
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // btnUserArchive
            // 
            this.btnUserArchive.BackColor = System.Drawing.Color.Transparent;
            this.btnUserArchive.FlatAppearance.BorderSize = 0;
            this.btnUserArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserArchive.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnUserArchive.Location = new System.Drawing.Point(141, 60);
            this.btnUserArchive.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserArchive.Name = "btnUserArchive";
            this.btnUserArchive.Size = new System.Drawing.Size(128, 32);
            this.btnUserArchive.TabIndex = 5;
            this.btnUserArchive.Text = "Archive";
            this.btnUserArchive.UseVisualStyleBackColor = false;
            this.btnUserArchive.Click += new System.EventHandler(this.btnUserArchive_Click);
            // 
            // btnActivityLog
            // 
            this.btnActivityLog.BackColor = System.Drawing.Color.Transparent;
            this.btnActivityLog.FlatAppearance.BorderSize = 0;
            this.btnActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityLog.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnActivityLog.Location = new System.Drawing.Point(269, 60);
            this.btnActivityLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivityLog.Name = "btnActivityLog";
            this.btnActivityLog.Size = new System.Drawing.Size(132, 32);
            this.btnActivityLog.TabIndex = 6;
            this.btnActivityLog.Text = "Activity Log";
            this.btnActivityLog.UseVisualStyleBackColor = false;
            this.btnActivityLog.Click += new System.EventHandler(this.btnActivityLog_Click);
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.btnActivityLog);
            this.Controls.Add(this.btnUserArchive);
            this.Controls.Add(this.btnUserAccount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Users";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserAccount;
        private System.Windows.Forms.Button btnUserArchive;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Panel panelTab;
        private CustomTextbox txtBoxSearch;
        private System.Windows.Forms.PictureBox btnSearch;
    }
}