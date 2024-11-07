namespace WashablesSystem
{
    partial class CustomerList
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrash = new System.Windows.Forms.PictureBox();
            this.emailAd = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.custNo = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.what = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Controls.Add(this.btnTrash, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.emailAd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.phoneNum, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.address, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.custName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.custNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(935, 37);
            this.tableLayoutPanel2.TabIndex = 91;
            // 
            // btnTrash
            // 
            this.btnTrash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTrash.Image = global::WashablesSystem.Properties.Resources.Trash;
            this.btnTrash.Location = new System.Drawing.Point(882, 5);
            this.btnTrash.Margin = new System.Windows.Forms.Padding(2, 2, 23, 2);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(30, 27);
            this.btnTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTrash.TabIndex = 83;
            this.btnTrash.TabStop = false;
            // 
            // emailAd
            // 
            this.emailAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailAd.AutoSize = true;
            this.emailAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.emailAd.Location = new System.Drawing.Point(376, 9);
            this.emailAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailAd.Name = "emailAd";
            this.emailAd.Size = new System.Drawing.Size(96, 19);
            this.emailAd.TabIndex = 78;
            this.emailAd.Text = "Email Address";
            this.emailAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNum
            // 
            this.phoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNum.AutoSize = true;
            this.phoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.phoneNum.Location = new System.Drawing.Point(543, 9);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(48, 19);
            this.phoneNum.TabIndex = 79;
            this.phoneNum.Text = "Phone";
            this.phoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.address.Location = new System.Drawing.Point(684, 9);
            this.address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 19);
            this.address.TabIndex = 81;
            this.address.Text = "Address";
            this.address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custName
            // 
            this.custName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.custName.Location = new System.Drawing.Point(142, 9);
            this.custName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(110, 19);
            this.custName.TabIndex = 80;
            this.custName.Text = "Customer Name";
            this.custName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custNo
            // 
            this.custNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custNo.AutoSize = true;
            this.custNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.custNo.Location = new System.Drawing.Point(12, 9);
            this.custNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custNo.Name = "custNo";
            this.custNo.Size = new System.Drawing.Size(31, 19);
            this.custNo.TabIndex = 77;
            this.custNo.Text = "No.";
            this.custNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.Image = global::WashablesSystem.Properties.Resources.Create;
            this.btnEdit.Location = new System.Drawing.Point(827, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 27);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 82;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 37);
            this.tableLayoutPanel1.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(381, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Email Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(549, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(691, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 81;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // what
            // 
            this.what.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.what.AutoSize = true;
            this.what.Font = new System.Drawing.Font("Segoe UI Semibold", 1F, System.Drawing.FontStyle.Bold);
            this.what.Location = new System.Drawing.Point(931, 39);
            this.what.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(9, 3);
            this.what.TabIndex = 93;
            this.what.Text = "Address";
            this.what.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.what.Visible = false;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.what);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerList";
            this.Size = new System.Drawing.Size(941, 44);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label custNo;
        private System.Windows.Forms.Label emailAd;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnTrash;
        private System.Windows.Forms.Label what;
    }
}
