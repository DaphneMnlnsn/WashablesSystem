namespace WashablesSystem
{
    partial class InProgLaundryList
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
            this.components = new System.ComponentModel.Container();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.serviceType = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.PictureBox();
            this.lblButton = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.Label();
            this.timeLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinish)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(2, 2);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(76, 26);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Unit #";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.lblStatus.Location = new System.Drawing.Point(216, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 18);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "In-Progress";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(5, 58);
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
            this.lblService.Location = new System.Drawing.Point(5, 81);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(89, 18);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "ServiceType:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time left:";
            // 
            // custName
            // 
            this.custName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.custName.Location = new System.Drawing.Point(83, 57);
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
            this.serviceType.Location = new System.Drawing.Point(99, 80);
            this.serviceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(129, 19);
            this.serviceType.TabIndex = 82;
            this.serviceType.Text = "service";
            this.serviceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLeft
            // 
            this.timeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.timeLeft.Location = new System.Drawing.Point(80, 129);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(0, 19);
            this.timeLeft.TabIndex = 83;
            this.timeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinish
            // 
            this.btnFinish.Image = global::WashablesSystem.Properties.Resources.Finish;
            this.btnFinish.Location = new System.Drawing.Point(215, 94);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(52, 40);
            this.btnFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFinish.TabIndex = 84;
            this.btnFinish.TabStop = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton.Location = new System.Drawing.Point(203, 137);
            this.lblButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(77, 18);
            this.lblButton.TabIndex = 85;
            this.lblButton.Text = "Finish now";
            // 
            // orderNum
            // 
            this.orderNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderNum.AutoSize = true;
            this.orderNum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.orderNum.Location = new System.Drawing.Point(3, 32);
            this.orderNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(39, 21);
            this.orderNum.TabIndex = 86;
            this.orderNum.Text = "or #";
            this.orderNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftTimer
            // 
            this.timeLeftTimer.Interval = 1000;
            this.timeLeftTimer.Tick += new System.EventHandler(this.timeLeftTimer_Tick);
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWeight.AutoEllipsis = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(83, 104);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(74, 19);
            this.lblWeight.TabIndex = 91;
            this.lblWeight.Text = "weight";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Weight:";
            // 
            // lblBatch
            // 
            this.lblBatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBatch.Location = new System.Drawing.Point(66, 33);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(29, 19);
            this.lblBatch.TabIndex = 92;
            this.lblBatch.Text = "b #";
            this.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InProgLaundryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.serviceType);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUnit);
            this.Name = "InProgLaundryList";
            this.Size = new System.Drawing.Size(295, 165);
            this.Load += new System.EventHandler(this.InProgLaundryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFinish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label serviceType;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.PictureBox btnFinish;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label orderNum;
        private System.Windows.Forms.Timer timeLeftTimer;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBatch;
    }
}