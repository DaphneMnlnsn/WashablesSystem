namespace WashablesSystem
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.btnPrint = new WashablesSystem.CustomButton();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.received2 = new System.Windows.Forms.Label();
            this.charge2 = new System.Windows.Forms.Label();
            this.refNo2 = new System.Windows.Forms.Label();
            this.paymentMethod2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastPaymentHeader = new System.Windows.Forms.Label();
            this.paymentMode = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPaymentReceived = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAdditionalCharge = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPickupTime = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnPrint.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 15;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(144, 557);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 29);
            this.btnPrint.TabIndex = 121;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(275, 557);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 122;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // received2
            // 
            this.received2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.received2.AutoSize = true;
            this.received2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.received2.ForeColor = System.Drawing.Color.Black;
            this.received2.Location = new System.Drawing.Point(349, 463);
            this.received2.Name = "received2";
            this.received2.Size = new System.Drawing.Size(105, 19);
            this.received2.TabIndex = 385;
            this.received2.Text = "<<Received>>";
            // 
            // charge2
            // 
            this.charge2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.charge2.AutoSize = true;
            this.charge2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.charge2.ForeColor = System.Drawing.Color.Black;
            this.charge2.Location = new System.Drawing.Point(349, 430);
            this.charge2.Name = "charge2";
            this.charge2.Size = new System.Drawing.Size(93, 19);
            this.charge2.TabIndex = 384;
            this.charge2.Text = "<<Charge>>";
            // 
            // refNo2
            // 
            this.refNo2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refNo2.AutoSize = true;
            this.refNo2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.refNo2.ForeColor = System.Drawing.Color.Black;
            this.refNo2.Location = new System.Drawing.Point(347, 393);
            this.refNo2.Name = "refNo2";
            this.refNo2.Size = new System.Drawing.Size(95, 19);
            this.refNo2.TabIndex = 383;
            this.refNo2.Text = "<<Ref. No>>";
            // 
            // paymentMethod2
            // 
            this.paymentMethod2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.paymentMethod2.AutoSize = true;
            this.paymentMethod2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.paymentMethod2.ForeColor = System.Drawing.Color.Black;
            this.paymentMethod2.Location = new System.Drawing.Point(347, 362);
            this.paymentMethod2.Name = "paymentMethod2";
            this.paymentMethod2.Size = new System.Drawing.Size(110, 19);
            this.paymentMethod2.TabIndex = 382;
            this.paymentMethod2.Text = "<<Method 2>>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(335, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 180);
            this.panel1.TabIndex = 381;
            // 
            // lastPaymentHeader
            // 
            this.lastPaymentHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastPaymentHeader.AutoSize = true;
            this.lastPaymentHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lastPaymentHeader.ForeColor = System.Drawing.Color.Black;
            this.lastPaymentHeader.Location = new System.Drawing.Point(357, 326);
            this.lastPaymentHeader.Name = "lastPaymentHeader";
            this.lastPaymentHeader.Size = new System.Drawing.Size(100, 18);
            this.lastPaymentHeader.TabIndex = 380;
            this.lastPaymentHeader.Text = "Last Payment";
            // 
            // paymentMode
            // 
            this.paymentMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.paymentMode.AutoSize = true;
            this.paymentMode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.paymentMode.ForeColor = System.Drawing.Color.Black;
            this.paymentMode.Location = new System.Drawing.Point(160, 325);
            this.paymentMode.Name = "paymentMode";
            this.paymentMode.Size = new System.Drawing.Size(143, 19);
            this.paymentMode.TabIndex = 379;
            this.paymentMode.Text = "<<Payment Mode>>";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(36, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 18);
            this.label14.TabIndex = 378;
            this.label14.Text = "Payment Type:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(153, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 377;
            // 
            // lblPaymentReceived
            // 
            this.lblPaymentReceived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaymentReceived.AutoSize = true;
            this.lblPaymentReceived.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentReceived.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentReceived.Location = new System.Drawing.Point(167, 462);
            this.lblPaymentReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentReceived.Name = "lblPaymentReceived";
            this.lblPaymentReceived.Size = new System.Drawing.Size(163, 19);
            this.lblPaymentReceived.TabIndex = 376;
            this.lblPaymentReceived.Text = "<<Payment Received>>";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(35, 462);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 18);
            this.label16.TabIndex = 375;
            this.label16.Text = "Payment Received:";
            // 
            // lblAdditionalCharge
            // 
            this.lblAdditionalCharge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdditionalCharge.AutoSize = true;
            this.lblAdditionalCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalCharge.ForeColor = System.Drawing.Color.Black;
            this.lblAdditionalCharge.Location = new System.Drawing.Point(167, 430);
            this.lblAdditionalCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdditionalCharge.Name = "lblAdditionalCharge";
            this.lblAdditionalCharge.Size = new System.Drawing.Size(162, 19);
            this.lblAdditionalCharge.TabIndex = 374;
            this.lblAdditionalCharge.Text = "<<Additional Charge>>";
            // 
            // lblReference
            // 
            this.lblReference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblReference.ForeColor = System.Drawing.Color.Black;
            this.lblReference.Location = new System.Drawing.Point(167, 391);
            this.lblReference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(134, 19);
            this.lblReference.TabIndex = 373;
            this.lblReference.Text = "<<Reference No>>";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentMethod.Location = new System.Drawing.Point(164, 362);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(156, 19);
            this.lblPaymentMethod.TabIndex = 372;
            this.lblPaymentMethod.Text = "<<Payment Method>>";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.Black;
            this.lblWeight.Location = new System.Drawing.Point(160, 291);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(95, 19);
            this.lblWeight.TabIndex = 371;
            this.lblWeight.Text = "<<Weight>>";
            // 
            // lblServiceType
            // 
            this.lblServiceType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblServiceType.ForeColor = System.Drawing.Color.Black;
            this.lblServiceType.Location = new System.Drawing.Point(160, 258);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(128, 19);
            this.lblServiceType.TabIndex = 370;
            this.lblServiceType.Text = "<<Service Type>>";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(160, 228);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(150, 19);
            this.lblCustomerName.TabIndex = 369;
            this.lblCustomerName.Text = "<<Customer Name>>";
            // 
            // lblPickupTime
            // 
            this.lblPickupTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPickupTime.AutoSize = true;
            this.lblPickupTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPickupTime.ForeColor = System.Drawing.Color.Black;
            this.lblPickupTime.Location = new System.Drawing.Point(142, 179);
            this.lblPickupTime.Name = "lblPickupTime";
            this.lblPickupTime.Size = new System.Drawing.Size(131, 19);
            this.lblPickupTime.TabIndex = 368;
            this.lblPickupTime.Text = "<<Pick-up Time>>";
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaff.ForeColor = System.Drawing.Color.Black;
            this.lblStaff.Location = new System.Drawing.Point(142, 148);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(79, 19);
            this.lblStaff.TabIndex = 367;
            this.lblStaff.Text = "<<Staff>>";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(36, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 18);
            this.label13.TabIndex = 366;
            this.label13.Text = "Additional Charge:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(64, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 365;
            this.label12.Text = "Reference No.:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(37, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 364;
            this.label9.Text = "Payment Method:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(35, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 363;
            this.label8.Text = "Total Weight:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(36, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 362;
            this.label7.Text = "Service:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 361;
            this.label6.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 356;
            this.label4.Text = "Pick-up Date:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(28, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(458, 21);
            this.label11.TabIndex = 360;
            this.label11.Text = "________________________________________________________";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(396, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 19);
            this.lblDate.TabIndex = 359;
            this.lblDate.Text = "11/4/2024";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WashablesSystem.Properties.Resources.image_3;
            this.pictureBox1.Location = new System.Drawing.Point(67, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 358;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 357;
            this.label5.Text = "Staff Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(345, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 355;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 354;
            this.label2.Text = "Pandi, Bulacan";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(174, 37);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(235, 21);
            this.lblHeader.TabIndex = 352;
            this.lblHeader.Text = "Washables Laundry Services";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 21);
            this.label1.TabIndex = 353;
            this.label1.Text = "________________________________________________________";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(162, 518);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 19);
            this.lblTotal.TabIndex = 351;
            this.lblTotal.Text = "<<Total Amount>>";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.label15.Location = new System.Drawing.Point(28, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 21);
            this.label15.TabIndex = 350;
            this.label15.Text = "Total Amount:";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(28, 487);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(458, 21);
            this.lblLine.TabIndex = 349;
            this.lblLine.Text = "________________________________________________________";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 609);
            this.Controls.Add(this.received2);
            this.Controls.Add(this.charge2);
            this.Controls.Add(this.refNo2);
            this.Controls.Add(this.paymentMethod2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lastPaymentHeader);
            this.Controls.Add(this.paymentMode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPaymentReceived);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblAdditionalCharge);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPickupTime);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton btnPrint;
        private CustomButton btnCancel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label received2;
        private System.Windows.Forms.Label charge2;
        private System.Windows.Forms.Label refNo2;
        private System.Windows.Forms.Label paymentMethod2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lastPaymentHeader;
        private System.Windows.Forms.Label paymentMode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPaymentReceived;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAdditionalCharge;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPickupTime;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLine;
    }
}