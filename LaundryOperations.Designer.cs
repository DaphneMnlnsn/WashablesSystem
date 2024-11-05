namespace WashablesSystem
{
    partial class LaundryOperations
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
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.lblNotAvailable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.laundryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnInProg = new System.Windows.Forms.Button();
            this.btnAddCustomer = new WashablesSystem.CustomButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMachinePanel = new System.Windows.Forms.Panel();
            this.machinePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainMachinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(28, 31);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(91, 39);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Units";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(417, 40);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(107, 26);
            this.lblAvailable.TabIndex = 5;
            this.lblAvailable.Text = "Available";
            // 
            // lblOccupied
            // 
            this.lblOccupied.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupied.Location = new System.Drawing.Point(606, 40);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(106, 26);
            this.lblOccupied.TabIndex = 7;
            this.lblOccupied.Text = "Occupied";
            // 
            // lblNotAvailable
            // 
            this.lblNotAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotAvailable.AutoSize = true;
            this.lblNotAvailable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAvailable.Location = new System.Drawing.Point(795, 40);
            this.lblNotAvailable.Name = "lblNotAvailable";
            this.lblNotAvailable.Size = new System.Drawing.Size(150, 26);
            this.lblNotAvailable.TabIndex = 9;
            this.lblNotAvailable.Text = "Not Available";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.laundryContainer);
            this.panel1.Controls.Add(this.btnPending);
            this.panel1.Controls.Add(this.btnInProg);
            this.panel1.Location = new System.Drawing.Point(986, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 805);
            this.panel1.TabIndex = 10;
            // 
            // laundryContainer
            // 
            this.laundryContainer.BackColor = System.Drawing.SystemColors.Control;
            this.laundryContainer.Location = new System.Drawing.Point(20, 78);
            this.laundryContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.laundryContainer.Name = "laundryContainer";
            this.laundryContainer.Size = new System.Drawing.Size(474, 706);
            this.laundryContainer.TabIndex = 13;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnPending.Location = new System.Drawing.Point(168, 40);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(148, 38);
            this.btnPending.TabIndex = 12;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnInProg
            // 
            this.btnInProg.BackColor = System.Drawing.SystemColors.Control;
            this.btnInProg.FlatAppearance.BorderSize = 0;
            this.btnInProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProg.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnInProg.Location = new System.Drawing.Point(20, 40);
            this.btnInProg.Name = "btnInProg";
            this.btnInProg.Size = new System.Drawing.Size(148, 38);
            this.btnInProg.TabIndex = 11;
            this.btnInProg.Text = "In-Progress";
            this.btnInProg.UseVisualStyleBackColor = false;
            this.btnInProg.Click += new System.EventHandler(this.btnInProg_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.BorderRadius = 6;
            this.btnAddCustomer.BorderSize = 0;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Location = new System.Drawing.Point(672, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(216, 48);
            this.btnAddCustomer.TabIndex = 17;
            this.btnAddCustomer.Text = "+ Add Laundry";
            this.btnAddCustomer.TextColor = System.Drawing.Color.Black;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WashablesSystem.Properties.Resources.Ellipse_4;
            this.pictureBox3.Location = new System.Drawing.Point(766, 45);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WashablesSystem.Properties.Resources.Ellipse_3;
            this.pictureBox2.Location = new System.Drawing.Point(578, 45);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WashablesSystem.Properties.Resources.Ellipse_2;
            this.pictureBox1.Location = new System.Drawing.Point(388, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainMachinePanel
            // 
            this.mainMachinePanel.AutoSize = true;
            this.mainMachinePanel.Controls.Add(this.btnAddCustomer);
            this.mainMachinePanel.Controls.Add(this.machinePanel);
            this.mainMachinePanel.Location = new System.Drawing.Point(34, 86);
            this.mainMachinePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMachinePanel.Name = "mainMachinePanel";
            this.mainMachinePanel.Size = new System.Drawing.Size(924, 865);
            this.mainMachinePanel.TabIndex = 11;
            // 
            // machinePanel
            // 
            this.machinePanel.AutoSize = true;
            this.machinePanel.Location = new System.Drawing.Point(14, 11);
            this.machinePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.machinePanel.Name = "machinePanel";
            this.machinePanel.Size = new System.Drawing.Size(898, 426);
            this.machinePanel.TabIndex = 18;
            // 
            // LaundryOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1498, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNotAvailable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblOccupied);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.mainMachinePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaundryOperations";
            this.Text = "v";
            this.Load += new System.EventHandler(this.LaundryOperations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainMachinePanel.ResumeLayout(false);
            this.mainMachinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNotAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInProg;
        private System.Windows.Forms.FlowLayoutPanel laundryContainer;
        private System.Windows.Forms.Button btnPending;
        private CustomButton btnAddCustomer;
        private System.Windows.Forms.Panel mainMachinePanel;
        private System.Windows.Forms.Panel machinePanel;
    }
}