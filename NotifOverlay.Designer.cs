namespace WashablesSystem
{
    partial class NotifOverlay
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
            this.btnSeeAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeeAll.AutoSize = true;
            this.btnSeeAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnSeeAll.Location = new System.Drawing.Point(145, 374);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(56, 20);
            this.btnSeeAll.TabIndex = 52;
            this.btnSeeAll.Text = "See All";
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 53;
            this.label1.Text = "Notifications";
            // 
            // notifPanel
            // 
            this.notifPanel.Location = new System.Drawing.Point(3, 36);
            this.notifPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notifPanel.MaximumSize = new System.Drawing.Size(349, 422);
            this.notifPanel.Name = "notifPanel";
            this.notifPanel.Size = new System.Drawing.Size(345, 335);
            this.notifPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Image = global::WashablesSystem.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(323, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 54;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NotifOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.notifPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(349, 400);
            this.Name = "NotifOverlay";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Size = new System.Drawing.Size(349, 400);
            this.Load += new System.EventHandler(this.NotifOverlay_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifOverlay_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label btnSeeAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel notifPanel;
        private System.Windows.Forms.PictureBox btnClose;
    }
}
