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
            this.unitPicture = new System.Windows.Forms.PictureBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnAvailability = new WashablesSystem.CustomButton();
            this.machineType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unitPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // unitPicture
            // 
            this.unitPicture.Image = global::WashablesSystem.Properties.Resources.Washing_Machine;
            this.unitPicture.Location = new System.Drawing.Point(30, 15);
            this.unitPicture.Name = "unitPicture";
            this.unitPicture.Size = new System.Drawing.Size(124, 127);
            this.unitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unitPicture.TabIndex = 0;
            this.unitPicture.TabStop = false;
            this.unitPicture.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(57, 145);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 26);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unit";
            this.lblUnit.Click += new System.EventHandler(this.btnAvailability_Click);
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
            this.btnAvailability.Location = new System.Drawing.Point(19, 173);
            this.btnAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(144, 24);
            this.btnAvailability.TabIndex = 18;
            this.btnAvailability.Text = "Available";
            this.btnAvailability.TextColor = System.Drawing.Color.Black;
            this.btnAvailability.UseVisualStyleBackColor = false;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // machineType
            // 
            this.machineType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.machineType.AutoSize = true;
            this.machineType.Font = new System.Drawing.Font("Berlin Sans FB", 2F);
            this.machineType.Location = new System.Drawing.Point(163, 215);
            this.machineType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.machineType.Name = "machineType";
            this.machineType.Size = new System.Drawing.Size(0, 4);
            this.machineType.TabIndex = 19;
            this.machineType.Visible = false;
            // 
            // MachineUnitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.machineType);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.unitPicture);
            this.Name = "MachineUnitList";
            this.Size = new System.Drawing.Size(182, 230);
            this.Click += new System.EventHandler(this.btnAvailability_Click);
            ((System.ComponentModel.ISupportInitialize)(this.unitPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox unitPicture;
        private System.Windows.Forms.Label lblUnit;
        private CustomButton btnAvailability;
        private System.Windows.Forms.Label machineType;
    }
}