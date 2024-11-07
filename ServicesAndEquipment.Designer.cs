namespace WashablesSystem
{
    partial class ServicesAndEquipment
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.cbSE = new System.Windows.Forms.ComboBox();
            this.containerSE = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSE = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnEquipment = new WashablesSystem.CustomButton();
            this.btnAddService = new WashablesSystem.CustomButton();
            this.txtBoxSearch = new WashablesSystem.CustomTextbox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(19, 20);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(91, 26);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Services";
            // 
            // cbSE
            // 
            this.cbSE.BackColor = System.Drawing.SystemColors.Control;
            this.cbSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSE.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbSE.FormattingEnabled = true;
            this.cbSE.Items.AddRange(new object[] {
            "WASH-DRY-FOLD",
            "WASH-DRY-PRESS",
            "ARCHIVE"});
            this.cbSE.Location = new System.Drawing.Point(23, 60);
            this.cbSE.Name = "cbSE";
            this.cbSE.Size = new System.Drawing.Size(276, 38);
            this.cbSE.TabIndex = 91;
            this.cbSE.SelectedIndexChanged += new System.EventHandler(this.cbSE_SelectedIndexChanged);
            // 
            // containerSE
            // 
            this.containerSE.AutoScroll = true;
            this.containerSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.containerSE.Location = new System.Drawing.Point(23, 150);
            this.containerSE.Margin = new System.Windows.Forms.Padding(2);
            this.containerSE.Name = "containerSE";
            this.containerSE.Size = new System.Drawing.Size(948, 351);
            this.containerSE.TabIndex = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblSE, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCode, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(948, 37);
            this.tableLayoutPanel2.TabIndex = 95;
            // 
            // lblSE
            // 
            this.lblSE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSE.AutoSize = true;
            this.lblSE.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSE.Location = new System.Drawing.Point(277, 9);
            this.lblSE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(58, 18);
            this.lblSE.TabIndex = 85;
            this.lblSE.Text = "column1";
            this.lblSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRS
            // 
            this.lblRS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRS.AutoSize = true;
            this.lblRS.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.Location = new System.Drawing.Point(586, 9);
            this.lblRS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(62, 18);
            this.lblRS.TabIndex = 84;
            this.lblRS.Text = "column2";
            this.lblRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(53, 9);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(19, 18);
            this.lblCode.TabIndex = 86;
            this.lblCode.Text = "#";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::WashablesSystem.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(940, 75);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TabStop = false;
            // 
            // btnEquipment
            // 
            this.btnEquipment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnEquipment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnEquipment.BorderColor = System.Drawing.Color.Transparent;
            this.btnEquipment.BorderRadius = 6;
            this.btnEquipment.BorderSize = 0;
            this.btnEquipment.FlatAppearance.BorderSize = 0;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.ForeColor = System.Drawing.Color.Black;
            this.btnEquipment.Location = new System.Drawing.Point(826, 16);
            this.btnEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(144, 38);
            this.btnEquipment.TabIndex = 93;
            this.btnEquipment.Text = "EQUIPMENT";
            this.btnEquipment.TextColor = System.Drawing.Color.Black;
            this.btnEquipment.UseVisualStyleBackColor = false;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAddService.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddService.BorderRadius = 6;
            this.btnAddService.BorderSize = 0;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.Location = new System.Drawing.Point(312, 62);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(144, 31);
            this.btnAddService.TabIndex = 92;
            this.btnAddService.Text = "+ Add Service";
            this.btnAddService.TextColor = System.Drawing.Color.Black;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearch.BorderColor = System.Drawing.Color.Black;
            this.txtBoxSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtBoxSearch.BorderRadius = 15;
            this.txtBoxSearch.BorderSize = 1;
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.Location = new System.Drawing.Point(691, 72);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Padding = new System.Windows.Forms.Padding(10, 5, 7, 5);
            this.txtBoxSearch.PasswordChar = false;
            this.txtBoxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.PlaceholderText = "";
            this.txtBoxSearch.Size = new System.Drawing.Size(279, 26);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.UnderlinedStyle = false;
            // 
            // ServicesAndEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 523);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.containerSE);
            this.Controls.Add(this.btnEquipment);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.cbSE);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServicesAndEquipment";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.ServicesAndEquipment_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private CustomTextbox txtBoxSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.ComboBox cbSE;
        private CustomButton btnAddService;
        private CustomButton btnEquipment;
        private System.Windows.Forms.FlowLayoutPanel containerSE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSE;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblCode;
    }
}