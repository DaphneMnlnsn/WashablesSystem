namespace WashablesSystem
{
    partial class SelectableUnitList
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
            this.btnUnit = new WashablesSystem.CustomButton();
            this.lblUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(238)))), ((int)(((byte)(131)))));
            this.btnUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(238)))), ((int)(((byte)(131)))));
            this.btnUnit.BorderColor = System.Drawing.Color.Black;
            this.btnUnit.BorderRadius = 15;
            this.btnUnit.BorderSize = 1;
            this.btnUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnit.FlatAppearance.BorderSize = 0;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.Color.Black;
            this.btnUnit.Location = new System.Drawing.Point(0, 0);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(320, 30);
            this.btnUnit.TabIndex = 31;
            this.btnUnit.Text = "Unit";
            this.btnUnit.TextColor = System.Drawing.Color.Black;
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.25F);
            this.lblUnit.Location = new System.Drawing.Point(301, 22);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(15, 6);
            this.lblUnit.TabIndex = 32;
            this.lblUnit.Text = "unitid";
            this.lblUnit.Visible = false;
            // 
            // SelectableUnitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.btnUnit);
            this.MaximumSize = new System.Drawing.Size(320, 30);
            this.Name = "SelectableUnitList";
            this.Size = new System.Drawing.Size(320, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnUnit;
        private System.Windows.Forms.Label lblUnit;
    }
}
