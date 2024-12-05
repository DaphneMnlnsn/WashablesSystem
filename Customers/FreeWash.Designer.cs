namespace WashablesSystem
{
    partial class FreeWash
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
            this.txtBoxWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDryOtherHour = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDryOtherMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.timeDryerCustomHr = new System.Windows.Forms.RadioButton();
            this.timeDryer30 = new System.Windows.Forms.RadioButton();
            this.timeDryer1 = new System.Windows.Forms.RadioButton();
            this.timeDryerCustomMin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWashOtherHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWashOtherMin = new System.Windows.Forms.NumericUpDown();
            this.timeWash = new System.Windows.Forms.Label();
            this.timeWashingCustomHr = new System.Windows.Forms.RadioButton();
            this.timeWashing30 = new System.Windows.Forms.RadioButton();
            this.timeWashing1 = new System.Windows.Forms.RadioButton();
            this.timeWashingCustomMin = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity3 = new System.Windows.Forms.NumericUpDown();
            this.quantity2 = new System.Windows.Forms.NumericUpDown();
            this.quantity1 = new System.Windows.Forms.NumericUpDown();
            this.cbItem3 = new System.Windows.Forms.ComboBox();
            this.cbItem2 = new System.Windows.Forms.ComboBox();
            this.cbItem1 = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.datePickup = new WashablesSystem.CustomDatePicker();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.btnSched = new WashablesSystem.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxWeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDryOtherHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDryOtherMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWashOtherHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWashOtherMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.DecimalPlaces = 2;
            this.txtBoxWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWeight.Location = new System.Drawing.Point(25, 91);
            this.txtBoxWeight.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(193, 25);
            this.txtBoxWeight.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDryOtherHour);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDryOtherMin);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.timeDryerCustomHr);
            this.groupBox2.Controls.Add(this.timeDryer30);
            this.groupBox2.Controls.Add(this.timeDryer1);
            this.groupBox2.Controls.Add(this.timeDryerCustomMin);
            this.groupBox2.Location = new System.Drawing.Point(265, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 122);
            this.groupBox2.TabIndex = 290;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(83, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 225;
            this.label4.Text = "hours";
            // 
            // txtDryOtherHour
            // 
            this.txtDryOtherHour.DecimalPlaces = 2;
            this.txtDryOtherHour.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtDryOtherHour.Location = new System.Drawing.Point(24, 89);
            this.txtDryOtherHour.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDryOtherHour.Name = "txtDryOtherHour";
            this.txtDryOtherHour.Size = new System.Drawing.Size(57, 25);
            this.txtDryOtherHour.TabIndex = 224;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(83, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 223;
            this.label9.Text = "minutes";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 222;
            this.label10.Text = "30 minutes";
            // 
            // txtDryOtherMin
            // 
            this.txtDryOtherMin.DecimalPlaces = 2;
            this.txtDryOtherMin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtDryOtherMin.Location = new System.Drawing.Point(24, 59);
            this.txtDryOtherMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDryOtherMin.Name = "txtDryOtherMin";
            this.txtDryOtherMin.Size = new System.Drawing.Size(57, 25);
            this.txtDryOtherMin.TabIndex = 221;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 220;
            this.label11.Text = "1 hour (default time)";
            // 
            // timeDryerCustomHr
            // 
            this.timeDryerCustomHr.AutoSize = true;
            this.timeDryerCustomHr.Location = new System.Drawing.Point(6, 96);
            this.timeDryerCustomHr.Name = "timeDryerCustomHr";
            this.timeDryerCustomHr.Size = new System.Drawing.Size(14, 13);
            this.timeDryerCustomHr.TabIndex = 217;
            this.timeDryerCustomHr.TabStop = true;
            this.timeDryerCustomHr.UseVisualStyleBackColor = true;
            // 
            // timeDryer30
            // 
            this.timeDryer30.AutoSize = true;
            this.timeDryer30.Location = new System.Drawing.Point(6, 15);
            this.timeDryer30.Name = "timeDryer30";
            this.timeDryer30.Size = new System.Drawing.Size(14, 13);
            this.timeDryer30.TabIndex = 209;
            this.timeDryer30.TabStop = true;
            this.timeDryer30.UseVisualStyleBackColor = true;
            // 
            // timeDryer1
            // 
            this.timeDryer1.AutoSize = true;
            this.timeDryer1.Location = new System.Drawing.Point(6, 39);
            this.timeDryer1.Name = "timeDryer1";
            this.timeDryer1.Size = new System.Drawing.Size(14, 13);
            this.timeDryer1.TabIndex = 78;
            this.timeDryer1.TabStop = true;
            this.timeDryer1.UseVisualStyleBackColor = true;
            // 
            // timeDryerCustomMin
            // 
            this.timeDryerCustomMin.AutoSize = true;
            this.timeDryerCustomMin.Location = new System.Drawing.Point(6, 66);
            this.timeDryerCustomMin.Name = "timeDryerCustomMin";
            this.timeDryerCustomMin.Size = new System.Drawing.Size(14, 13);
            this.timeDryerCustomMin.TabIndex = 80;
            this.timeDryerCustomMin.TabStop = true;
            this.timeDryerCustomMin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtWashOtherHour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWashOtherMin);
            this.groupBox1.Controls.Add(this.timeWash);
            this.groupBox1.Controls.Add(this.timeWashingCustomHr);
            this.groupBox1.Controls.Add(this.timeWashing30);
            this.groupBox1.Controls.Add(this.timeWashing1);
            this.groupBox1.Controls.Add(this.timeWashingCustomMin);
            this.groupBox1.Location = new System.Drawing.Point(265, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 122);
            this.groupBox1.TabIndex = 288;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(83, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 225;
            this.label8.Text = "hours";
            // 
            // txtWashOtherHour
            // 
            this.txtWashOtherHour.DecimalPlaces = 2;
            this.txtWashOtherHour.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWashOtherHour.Location = new System.Drawing.Point(24, 89);
            this.txtWashOtherHour.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWashOtherHour.Name = "txtWashOtherHour";
            this.txtWashOtherHour.Size = new System.Drawing.Size(57, 25);
            this.txtWashOtherHour.TabIndex = 224;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(83, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 223;
            this.label5.Text = "minutes";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 222;
            this.label6.Text = "30 minutes";
            // 
            // txtWashOtherMin
            // 
            this.txtWashOtherMin.DecimalPlaces = 2;
            this.txtWashOtherMin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtWashOtherMin.Location = new System.Drawing.Point(24, 59);
            this.txtWashOtherMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWashOtherMin.Name = "txtWashOtherMin";
            this.txtWashOtherMin.Size = new System.Drawing.Size(57, 25);
            this.txtWashOtherMin.TabIndex = 221;
            // 
            // timeWash
            // 
            this.timeWash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeWash.AutoSize = true;
            this.timeWash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeWash.ForeColor = System.Drawing.Color.Black;
            this.timeWash.Location = new System.Drawing.Point(21, 36);
            this.timeWash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeWash.Name = "timeWash";
            this.timeWash.Size = new System.Drawing.Size(131, 17);
            this.timeWash.TabIndex = 220;
            this.timeWash.Text = "1 hour (default time)";
            // 
            // timeWashingCustomHr
            // 
            this.timeWashingCustomHr.AutoSize = true;
            this.timeWashingCustomHr.Location = new System.Drawing.Point(6, 96);
            this.timeWashingCustomHr.Name = "timeWashingCustomHr";
            this.timeWashingCustomHr.Size = new System.Drawing.Size(14, 13);
            this.timeWashingCustomHr.TabIndex = 217;
            this.timeWashingCustomHr.TabStop = true;
            this.timeWashingCustomHr.UseVisualStyleBackColor = true;
            // 
            // timeWashing30
            // 
            this.timeWashing30.AutoSize = true;
            this.timeWashing30.Location = new System.Drawing.Point(6, 15);
            this.timeWashing30.Name = "timeWashing30";
            this.timeWashing30.Size = new System.Drawing.Size(14, 13);
            this.timeWashing30.TabIndex = 209;
            this.timeWashing30.TabStop = true;
            this.timeWashing30.UseVisualStyleBackColor = true;
            // 
            // timeWashing1
            // 
            this.timeWashing1.AutoSize = true;
            this.timeWashing1.Location = new System.Drawing.Point(6, 39);
            this.timeWashing1.Name = "timeWashing1";
            this.timeWashing1.Size = new System.Drawing.Size(14, 13);
            this.timeWashing1.TabIndex = 78;
            this.timeWashing1.TabStop = true;
            this.timeWashing1.UseVisualStyleBackColor = true;
            // 
            // timeWashingCustomMin
            // 
            this.timeWashingCustomMin.AutoSize = true;
            this.timeWashingCustomMin.Location = new System.Drawing.Point(6, 66);
            this.timeWashingCustomMin.Name = "timeWashingCustomMin";
            this.timeWashingCustomMin.Size = new System.Drawing.Size(14, 13);
            this.timeWashingCustomMin.TabIndex = 80;
            this.timeWashingCustomMin.TabStop = true;
            this.timeWashingCustomMin.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblTime.Location = new System.Drawing.Point(250, 68);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(169, 18);
            this.lblTime.TabIndex = 295;
            this.lblTime.Text = "Time (Washing Machine)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.label12.Location = new System.Drawing.Point(250, 209);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 296;
            this.label12.Text = "Time(Dryer)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 294;
            this.label3.Text = "Pick-up Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 293;
            this.label2.Text = "Weight (kg)";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(21, 19);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(169, 21);
            this.lblHeader.TabIndex = 291;
            this.lblHeader.Text = "Schedule Free Wash";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 21);
            this.label1.TabIndex = 292;
            this.label1.Text = "___________________________________________________";
            // 
            // quantity3
            // 
            this.quantity3.DecimalPlaces = 2;
            this.quantity3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity3.Location = new System.Drawing.Point(149, 305);
            this.quantity3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity3.Name = "quantity3";
            this.quantity3.Size = new System.Drawing.Size(70, 25);
            this.quantity3.TabIndex = 305;
            // 
            // quantity2
            // 
            this.quantity2.DecimalPlaces = 2;
            this.quantity2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity2.Location = new System.Drawing.Point(149, 273);
            this.quantity2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity2.Name = "quantity2";
            this.quantity2.Size = new System.Drawing.Size(69, 25);
            this.quantity2.TabIndex = 304;
            // 
            // quantity1
            // 
            this.quantity1.DecimalPlaces = 2;
            this.quantity1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.quantity1.Location = new System.Drawing.Point(149, 241);
            this.quantity1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(69, 25);
            this.quantity1.TabIndex = 303;
            // 
            // cbItem3
            // 
            this.cbItem3.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem3.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem3.FormattingEnabled = true;
            this.cbItem3.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem3.Location = new System.Drawing.Point(25, 305);
            this.cbItem3.Name = "cbItem3";
            this.cbItem3.Size = new System.Drawing.Size(118, 25);
            this.cbItem3.TabIndex = 302;
            // 
            // cbItem2
            // 
            this.cbItem2.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem2.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem2.FormattingEnabled = true;
            this.cbItem2.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem2.Location = new System.Drawing.Point(25, 273);
            this.cbItem2.Name = "cbItem2";
            this.cbItem2.Size = new System.Drawing.Size(118, 25);
            this.cbItem2.TabIndex = 301;
            // 
            // cbItem1
            // 
            this.cbItem1.BackColor = System.Drawing.SystemColors.Control;
            this.cbItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbItem1.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.cbItem1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbItem1.FormattingEnabled = true;
            this.cbItem1.Items.AddRange(new object[] {
            "Surf Powder",
            "Tide",
            "Champion Liquid"});
            this.cbItem1.Location = new System.Drawing.Point(24, 241);
            this.cbItem1.Name = "cbItem1";
            this.cbItem1.Size = new System.Drawing.Size(119, 25);
            this.cbItem1.TabIndex = 300;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblItemName.Location = new System.Drawing.Point(22, 221);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(82, 18);
            this.lblItemName.TabIndex = 299;
            this.lblItemName.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblQuantity.Location = new System.Drawing.Point(124, 220);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(116, 18);
            this.lblQuantity.TabIndex = 298;
            this.lblQuantity.Text = "Quantity (mL/g)";
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblItemTitle.Location = new System.Drawing.Point(22, 199);
            this.lblItemTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(121, 18);
            this.lblItemTitle.TabIndex = 297;
            this.lblItemTitle.Text = "Items to be Used:";
            // 
            // datePickup
            // 
            this.datePickup.BorderColor = System.Drawing.Color.Silver;
            this.datePickup.BorderSize = 1;
            this.datePickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickup.Location = new System.Drawing.Point(25, 149);
            this.datePickup.Margin = new System.Windows.Forms.Padding(2);
            this.datePickup.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickup.Name = "datePickup";
            this.datePickup.Size = new System.Drawing.Size(193, 35);
            this.datePickup.SkinColor = System.Drawing.SystemColors.Control;
            this.datePickup.TabIndex = 40;
            this.datePickup.TextColor = System.Drawing.Color.Black;
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
            this.btnCancel.Location = new System.Drawing.Point(225, 356);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 41);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSched
            // 
            this.btnSched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnSched.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnSched.BorderColor = System.Drawing.Color.Transparent;
            this.btnSched.BorderRadius = 15;
            this.btnSched.BorderSize = 0;
            this.btnSched.FlatAppearance.BorderSize = 0;
            this.btnSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSched.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSched.ForeColor = System.Drawing.Color.White;
            this.btnSched.Location = new System.Drawing.Point(57, 353);
            this.btnSched.Margin = new System.Windows.Forms.Padding(2);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(163, 47);
            this.btnSched.TabIndex = 30;
            this.btnSched.Text = "Schedule and Mark as Resolved";
            this.btnSched.TextColor = System.Drawing.Color.White;
            this.btnSched.UseVisualStyleBackColor = false;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // FreeWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 420);
            this.Controls.Add(this.quantity3);
            this.Controls.Add(this.quantity2);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.cbItem3);
            this.Controls.Add(this.cbItem2);
            this.Controls.Add(this.cbItem1);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemTitle);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.datePickup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSched);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FreeWash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FreeWash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxWeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDryOtherHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDryOtherMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWashOtherHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWashOtherMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton btnSched;
        private CustomButton btnCancel;
        private CustomDatePicker datePickup;
        private System.Windows.Forms.NumericUpDown txtBoxWeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtDryOtherHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtDryOtherMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton timeDryerCustomHr;
        private System.Windows.Forms.RadioButton timeDryer30;
        private System.Windows.Forms.RadioButton timeDryer1;
        private System.Windows.Forms.RadioButton timeDryerCustomMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtWashOtherHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtWashOtherMin;
        private System.Windows.Forms.Label timeWash;
        private System.Windows.Forms.RadioButton timeWashingCustomHr;
        private System.Windows.Forms.RadioButton timeWashing30;
        private System.Windows.Forms.RadioButton timeWashing1;
        private System.Windows.Forms.RadioButton timeWashingCustomMin;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantity3;
        private System.Windows.Forms.NumericUpDown quantity2;
        private System.Windows.Forms.NumericUpDown quantity1;
        private System.Windows.Forms.ComboBox cbItem3;
        private System.Windows.Forms.ComboBox cbItem2;
        private System.Windows.Forms.ComboBox cbItem1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemTitle;
    }
}
