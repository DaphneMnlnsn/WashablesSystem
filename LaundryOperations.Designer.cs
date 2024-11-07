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
            this.cbSort = new WashablesSystem.CustomComboBox();
            this.laundryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnInProg = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.machinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddLaundry = new WashablesSystem.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(19, 23);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(62, 26);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Units";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(129, 27);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(70, 18);
            this.lblAvailable.TabIndex = 5;
            this.lblAvailable.Text = "Available";
            // 
            // lblOccupied
            // 
            this.lblOccupied.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupied.Location = new System.Drawing.Point(245, 28);
            this.lblOccupied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(69, 18);
            this.lblOccupied.TabIndex = 7;
            this.lblOccupied.Text = "Occupied";
            // 
            // lblNotAvailable
            // 
            this.lblNotAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotAvailable.AutoSize = true;
            this.lblNotAvailable.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAvailable.Location = new System.Drawing.Point(364, 28);
            this.lblNotAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotAvailable.Name = "lblNotAvailable";
            this.lblNotAvailable.Size = new System.Drawing.Size(98, 18);
            this.lblNotAvailable.TabIndex = 9;
            this.lblNotAvailable.Text = "Not Available";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.laundryContainer);
            this.panel1.Controls.Add(this.btnPending);
            this.panel1.Controls.Add(this.btnInProg);
            this.panel1.Location = new System.Drawing.Point(657, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 523);
            this.panel1.TabIndex = 10;
            // 
            // cbSort
            // 
            this.cbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbSort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.cbSort.BorderSize = 0;
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.ForeColor = System.Drawing.Color.Black;
            this.cbSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbSort.Items.AddRange(new object[] {
            "Priority",
            "Time Schedule (Asc)",
            "Time Schedule (Desc)",
            "Pick-up Date (Asc)",
            "Pick-up Date (Desc)"});
            this.cbSort.ListBackColor = System.Drawing.Color.White;
            this.cbSort.ListTextColor = System.Drawing.Color.Black;
            this.cbSort.Location = new System.Drawing.Point(165, 58);
            this.cbSort.Margin = new System.Windows.Forms.Padding(2);
            this.cbSort.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(156, 25);
            this.cbSort.TabIndex = 96;
            this.cbSort.Texts = "Sort by...";
            // 
            // laundryContainer
            // 
            this.laundryContainer.AutoScroll = true;
            this.laundryContainer.BackColor = System.Drawing.SystemColors.Control;
            this.laundryContainer.Location = new System.Drawing.Point(13, 51);
            this.laundryContainer.Name = "laundryContainer";
            this.laundryContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.laundryContainer.Size = new System.Drawing.Size(316, 459);
            this.laundryContainer.TabIndex = 13;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnPending.Location = new System.Drawing.Point(112, 26);
            this.btnPending.Margin = new System.Windows.Forms.Padding(2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(99, 25);
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
            this.btnInProg.Location = new System.Drawing.Point(13, 26);
            this.btnInProg.Margin = new System.Windows.Forms.Padding(2);
            this.btnInProg.Name = "btnInProg";
            this.btnInProg.Size = new System.Drawing.Size(99, 25);
            this.btnInProg.TabIndex = 11;
            this.btnInProg.Text = "In-Progress";
            this.btnInProg.UseVisualStyleBackColor = false;
            this.btnInProg.Click += new System.EventHandler(this.btnInProg_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WashablesSystem.Properties.Resources.Ellipse_4;
            this.pictureBox3.Location = new System.Drawing.Point(345, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WashablesSystem.Properties.Resources.Ellipse_3;
            this.pictureBox2.Location = new System.Drawing.Point(226, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WashablesSystem.Properties.Resources.Ellipse_2;
            this.pictureBox1.Location = new System.Drawing.Point(110, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // machinePanel
            // 
            this.machinePanel.AutoScroll = true;
            this.machinePanel.Location = new System.Drawing.Point(29, 63);
            this.machinePanel.MaximumSize = new System.Drawing.Size(599, 447);
            this.machinePanel.Name = "machinePanel";
            this.machinePanel.Size = new System.Drawing.Size(599, 447);
            this.machinePanel.TabIndex = 18;
            // 
            // btnAddLaundry
            // 
            this.btnAddLaundry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddLaundry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddLaundry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddLaundry.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddLaundry.BorderRadius = 6;
            this.btnAddLaundry.BorderSize = 0;
            this.btnAddLaundry.FlatAppearance.BorderSize = 0;
            this.btnAddLaundry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLaundry.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLaundry.ForeColor = System.Drawing.Color.Black;
            this.btnAddLaundry.Location = new System.Drawing.Point(483, 20);
            this.btnAddLaundry.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLaundry.Name = "btnAddLaundry";
            this.btnAddLaundry.Size = new System.Drawing.Size(144, 31);
            this.btnAddLaundry.TabIndex = 17;
            this.btnAddLaundry.Text = "+ Add Laundry";
            this.btnAddLaundry.TextColor = System.Drawing.Color.Black;
            this.btnAddLaundry.UseVisualStyleBackColor = false;
            this.btnAddLaundry.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // LaundryOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.btnAddLaundry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNotAvailable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblOccupied);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.machinePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LaundryOperations";
            this.Text = "v";
            this.Load += new System.EventHandler(this.LaundryOperations_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private CustomButton btnAddLaundry;
        private CustomComboBox cbSort;
        private System.Windows.Forms.FlowLayoutPanel machinePanel;
    }
}