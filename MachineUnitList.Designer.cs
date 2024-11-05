namespace WashablesSystem
{
    partial class MachineUnitList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnAvailability = new WashablesSystem.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WashablesSystem.Properties.Resources.Washing_Machine;
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(86, 223);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(80, 39);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unit";
            // 
            // btnAvailability
            // 
            this.btnAvailability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAvailability.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAvailability.BorderColor = System.Drawing.Color.Transparent;
            this.btnAvailability.BorderRadius = 15;
            this.btnAvailability.BorderSize = 0;
            this.btnAvailability.FlatAppearance.BorderSize = 0;
            this.btnAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailability.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailability.ForeColor = System.Drawing.Color.Black;
            this.btnAvailability.Location = new System.Drawing.Point(28, 266);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(216, 37);
            this.btnAvailability.TabIndex = 18;
            this.btnAvailability.Text = "Available";
            this.btnAvailability.TextColor = System.Drawing.Color.Black;
            this.btnAvailability.UseVisualStyleBackColor = false;
            // 
            // MachineUnitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MachineUnitList";
            this.Size = new System.Drawing.Size(273, 354);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUnit;
        private CustomButton btnAvailability;
    }
}