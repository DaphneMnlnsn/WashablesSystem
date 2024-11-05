namespace WashablesSystem
{
    partial class EditItem
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new WashablesSystem.CustomComboBox();
            this.btnCancel = new WashablesSystem.CustomButton();
            this.btnAdd = new WashablesSystem.CustomButton();
            this.txtBoxPrice = new WashablesSystem.CustomTextbox();
            this.txtBoxName = new WashablesSystem.CustomTextbox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Item Name";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.lblHeader.Location = new System.Drawing.Point(17, 18);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(183, 21);
            this.lblHeader.TabIndex = 32;
            this.lblHeader.Text = "Edit this selected item";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "________________________________________";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategory.BorderColor = System.Drawing.Color.DimGray;
            this.cbCategory.BorderSize = 1;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.cbCategory.Items.AddRange(new object[] {
            "Powder",
            "Liquid"});
            this.cbCategory.ListBackColor = System.Drawing.SystemColors.Control;
            this.cbCategory.ListTextColor = System.Drawing.Color.Black;
            this.cbCategory.Location = new System.Drawing.Point(21, 162);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.MinimumSize = new System.Drawing.Size(133, 20);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategory.Size = new System.Drawing.Size(306, 25);
            this.cbCategory.TabIndex = 40;
            this.cbCategory.Texts = "Powder";
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
            this.btnCancel.Location = new System.Drawing.Point(179, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 29);
            this.btnCancel.TabIndex = 31;
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
            this.btnAdd.Location = new System.Drawing.Point(59, 308);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Save";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxPrice.BorderColor = System.Drawing.Color.Black;
            this.txtBoxPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxPrice.BorderRadius = 15;
            this.txtBoxPrice.BorderSize = 1;
            this.txtBoxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPrice.Location = new System.Drawing.Point(20, 231);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrice.Multiline = false;
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxPrice.PasswordChar = false;
            this.txtBoxPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxPrice.PlaceholderText = "";
            this.txtBoxPrice.Size = new System.Drawing.Size(307, 26);
            this.txtBoxPrice.TabIndex = 27;
            this.txtBoxPrice.UnderlinedStyle = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxName.BorderColor = System.Drawing.Color.Black;
            this.txtBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxName.BorderRadius = 15;
            this.txtBoxName.BorderSize = 1;
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxName.Location = new System.Drawing.Point(20, 89);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxName.Multiline = false;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxName.PasswordChar = false;
            this.txtBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxName.PlaceholderText = "";
            this.txtBoxName.Size = new System.Drawing.Size(307, 26);
            this.txtBoxName.TabIndex = 23;
            this.txtBoxName.UnderlinedStyle = false;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 383);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomTextbox txtBoxName;
        private CustomTextbox txtBoxPrice;
        private CustomButton btnAdd;
        private CustomButton btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private CustomComboBox cbCategory;
    }
}
