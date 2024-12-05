namespace WashablesSystem
{
    partial class PendingLaundryList
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
            this.lblOR = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lbltimeSched = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.serviceType = new System.Windows.Forms.Label();
            this.lblPickup = new System.Windows.Forms.Label();
            this.lblButton = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.timeScheduled = new System.Windows.Forms.Label();
            this.pickup = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.lblOR.Location = new System.Drawing.Point(2, 2);
            this.lblOR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(48, 21);
            this.lblOR.TabIndex = 5;
            this.lblOR.Text = "OR#";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblStatus.Location = new System.Drawing.Point(233, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 18);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Pending";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(5, 37);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(73, 18);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(5, 63);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(89, 18);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "ServiceType:";
            // 
            // lbltimeSched
            // 
            this.lbltimeSched.AutoSize = true;
            this.lbltimeSched.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeSched.Location = new System.Drawing.Point(4, 117);
            this.lbltimeSched.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltimeSched.Name = "lbltimeSched";
            this.lbltimeSched.Size = new System.Drawing.Size(114, 18);
            this.lbltimeSched.TabIndex = 9;
            this.lbltimeSched.Text = "Time Scheduled:";
            // 
            // custName
            // 
            this.custName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.custName.Location = new System.Drawing.Point(82, 37);
            this.custName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(110, 19);
            this.custName.TabIndex = 81;
            this.custName.Text = "Customer Name";
            this.custName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceType
            // 
            this.serviceType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serviceType.AutoEllipsis = true;
            this.serviceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.serviceType.Location = new System.Drawing.Point(98, 62);
            this.serviceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(136, 19);
            this.serviceType.TabIndex = 82;
            this.serviceType.Text = "service";
            this.serviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPickup
            // 
            this.lblPickup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPickup.AutoSize = true;
            this.lblPickup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPickup.Location = new System.Drawing.Point(4, 157);
            this.lblPickup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPickup.Name = "lblPickup";
            this.lblPickup.Size = new System.Drawing.Size(94, 19);
            this.lblPickup.TabIndex = 83;
            this.lblPickup.Text = "Pick-Up Date:";
            this.lblPickup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton.Location = new System.Drawing.Point(206, 162);
            this.lblButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(75, 18);
            this.lblButton.TabIndex = 85;
            this.lblButton.Text = "Start Now";
            this.lblButton.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::WashablesSystem.Properties.Resources.Start;
            this.btnStart.Location = new System.Drawing.Point(225, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 40);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 84;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timeScheduled
            // 
            this.timeScheduled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeScheduled.AutoSize = true;
            this.timeScheduled.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.timeScheduled.Location = new System.Drawing.Point(16, 135);
            this.timeScheduled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeScheduled.Name = "timeScheduled";
            this.timeScheduled.Size = new System.Drawing.Size(149, 19);
            this.timeScheduled.TabIndex = 86;
            this.timeScheduled.Text = "00:00:00 MM/DD/YYY";
            this.timeScheduled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pickup
            // 
            this.pickup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pickup.AutoSize = true;
            this.pickup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.pickup.Location = new System.Drawing.Point(95, 157);
            this.pickup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(99, 19);
            this.pickup.TabIndex = 87;
            this.pickup.Text = "MM/DD/YYYY";
            this.pickup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoEllipsis = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(99, 89);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(136, 19);
            this.lblWeight.TabIndex = 89;
            this.lblWeight.Text = "weight";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "Weight:";
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.lblBatch.Location = new System.Drawing.Point(79, 2);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(35, 21);
            this.lblBatch.TabIndex = 90;
            this.lblBatch.Text = "B#";
            // 
            // PendingLaundryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickup);
            this.Controls.Add(this.timeScheduled);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPickup);
            this.Controls.Add(this.serviceType);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.lbltimeSched);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOR);
            this.Name = "PendingLaundryList";
            this.Size = new System.Drawing.Size(295, 190);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lbltimeSched;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label serviceType;
        private System.Windows.Forms.Label lblPickup;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label timeScheduled;
        private System.Windows.Forms.Label pickup;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBatch;
    }
}
