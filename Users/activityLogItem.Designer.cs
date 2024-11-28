namespace WashablesSystem
{
    partial class activityLogItem
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
            this.activityText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // activityText
            // 
            this.activityText.AutoSize = true;
            this.activityText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.activityText.Location = new System.Drawing.Point(13, 5);
            this.activityText.MaximumSize = new System.Drawing.Size(427, 20);
            this.activityText.Name = "activityText";
            this.activityText.Size = new System.Drawing.Size(55, 19);
            this.activityText.TabIndex = 0;
            this.activityText.Text = "activity";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(-3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 23);
            this.panel1.TabIndex = 1;
            // 
            // activityLogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.activityText);
            this.MaximumSize = new System.Drawing.Size(448, 0);
            this.MinimumSize = new System.Drawing.Size(448, 32);
            this.Name = "activityLogItem";
            this.Size = new System.Drawing.Size(448, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activityText;
        private System.Windows.Forms.Panel panel1;
    }
}