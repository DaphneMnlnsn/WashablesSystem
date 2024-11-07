namespace WashablesSystem
{
    partial class AddService
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMin = new WashablesSystem.CustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.btnAdd = new WashablesSystem.CustomButton();
            this.txtBoxRate = new WashablesSystem.CustomTextbox();
            this.txtBoxName = new WashablesSystem.CustomTextbox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(294, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 235;
            this.label6.Text = "kgs";
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.BackColor = System.Drawing.Color.White;
            this.txtBoxMin.BorderColor = System.Drawing.Color.Silver;
            this.txtBoxMin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxMin.BorderRadius = 5;
            this.txtBoxMin.BorderSize = 1;
            this.txtBoxMin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxMin.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMin.Location = new System.Drawing.Point(215, 231);
            this.txtBoxMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMin.Multiline = false;
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxMin.PasswordChar = false;
            this.txtBoxMin.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxMin.PlaceholderText = "";
            this.txtBoxMin.Size = new System.Drawing.Size(111, 30);
            this.txtBoxMin.TabIndex = 234;
            this.txtBoxMin.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(213, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 233;
            this.label5.Text = "Min. kgs";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 232;
            this.label3.Text = "/kg";
            // 
            // cbService
            // 
            this.cbService.BackColor = System.Drawing.SystemColors.Control;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbService.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbService.FormattingEnabled = true;
            this.cbService.Items.AddRange(new object[] {
            "Wash-Dry-Fold",
            "Wash-Dry-Press"});
            this.cbService.Location = new System.Drawing.Point(20, 92);
            this.cbService.Margin = new System.Windows.Forms.Padding(2);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(307, 25);
            this.cbService.TabIndex = 231;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(21, 209);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 18);
            this.lblPrice.TabIndex = 230;
            this.lblPrice.Text = "Rate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 229;
            this.label4.Text = "Service";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 228;
            this.label2.Text = "Service Type";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(16, 21);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(106, 21);
            this.lblHeader.TabIndex = 226;
            this.lblHeader.Text = "Add Service";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 227;
            this.label1.Text = "________________________________________";
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
            this.btnCancel.Location = new System.Drawing.Point(178, 299);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 225;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(58, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 224;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BackColor = System.Drawing.Color.White;
            this.txtBoxRate.BorderColor = System.Drawing.Color.Silver;
            this.txtBoxRate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxRate.BorderRadius = 5;
            this.txtBoxRate.BorderSize = 1;
            this.txtBoxRate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxRate.ForeColor = System.Drawing.Color.Black;
            this.txtBoxRate.Location = new System.Drawing.Point(19, 231);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRate.Multiline = false;
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxRate.PasswordChar = false;
            this.txtBoxRate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxRate.PlaceholderText = "";
            this.txtBoxRate.Size = new System.Drawing.Size(188, 30);
            this.txtBoxRate.TabIndex = 223;
            this.txtBoxRate.UnderlinedStyle = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.Color.White;
            this.txtBoxName.BorderColor = System.Drawing.Color.Silver;
            this.txtBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxName.BorderRadius = 5;
            this.txtBoxName.BorderSize = 1;
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxName.Location = new System.Drawing.Point(19, 161);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxName.Multiline = false;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxName.PasswordChar = false;
            this.txtBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxName.PlaceholderText = "";
            this.txtBoxName.Size = new System.Drawing.Size(307, 30);
            this.txtBoxName.TabIndex = 222;
            this.txtBoxName.UnderlinedStyle = false;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbService);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.txtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private CustomTextbox txtBoxMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private CustomButton btnCancel;
        private CustomButton btnAdd;
        private CustomTextbox txtBoxRate;
        private CustomTextbox txtBoxName;
    }
}
