namespace WashablesSystem
{
    partial class ServiceTypeList
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.checkBoxCtrl = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(2, 1);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(111, 21);
            this.lblHeader.TabIndex = 99;
            this.lblHeader.Text = "Main Service";
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxCtrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxCtrl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCtrl.FormattingEnabled = true;
            this.checkBoxCtrl.Items.AddRange(new object[] {
            "Clothes, Table Napkin, Pillowcase",
            "Bed Sheet, Table Cloth, Curtain",
            "Comforter, Bath Towel"});
            this.checkBoxCtrl.Location = new System.Drawing.Point(15, 26);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(287, 15);
            this.checkBoxCtrl.TabIndex = 100;
            // 
            // ServiceTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.checkBoxCtrl);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(305, 0);
            this.Name = "ServiceTypeList";
            this.Size = new System.Drawing.Size(305, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.CheckedListBox checkBoxCtrl;
    }
}
