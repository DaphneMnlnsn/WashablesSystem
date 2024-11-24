namespace WashablesSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cLoginButton = new WashablesSystem.CustomButton();
            this.ctxtbxPass = new WashablesSystem.CustomTextbox();
            this.ctxtbxUserName = new WashablesSystem.CustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cLoginButton);
            this.panel1.Controls.Add(this.ctxtbxPass);
            this.panel1.Controls.Add(this.ctxtbxUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(613, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 393);
            this.panel1.TabIndex = 17;
            // 
            // cLoginButton
            // 
            this.cLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.cLoginButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.cLoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.cLoginButton.BorderRadius = 10;
            this.cLoginButton.BorderSize = 0;
            this.cLoginButton.FlatAppearance.BorderSize = 0;
            this.cLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLoginButton.ForeColor = System.Drawing.Color.Black;
            this.cLoginButton.Location = new System.Drawing.Point(133, 292);
            this.cLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.cLoginButton.Name = "cLoginButton";
            this.cLoginButton.Size = new System.Drawing.Size(125, 41);
            this.cLoginButton.TabIndex = 6;
            this.cLoginButton.Text = "Log In";
            this.cLoginButton.TextColor = System.Drawing.Color.Black;
            this.cLoginButton.UseVisualStyleBackColor = false;
            this.cLoginButton.Click += new System.EventHandler(this.cLoginButton_Click);
            // 
            // ctxtbxPass
            // 
            this.ctxtbxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ctxtbxPass.BorderColor = System.Drawing.Color.Transparent;
            this.ctxtbxPass.BorderFocusColor = System.Drawing.Color.Transparent;
            this.ctxtbxPass.BorderRadius = 0;
            this.ctxtbxPass.BorderSize = 2;
            this.ctxtbxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtbxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctxtbxPass.Location = new System.Drawing.Point(53, 223);
            this.ctxtbxPass.Margin = new System.Windows.Forms.Padding(4);
            this.ctxtbxPass.Multiline = false;
            this.ctxtbxPass.Name = "ctxtbxPass";
            this.ctxtbxPass.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ctxtbxPass.PasswordChar = true;
            this.ctxtbxPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctxtbxPass.PlaceholderText = "";
            this.ctxtbxPass.Size = new System.Drawing.Size(277, 32);
            this.ctxtbxPass.TabIndex = 5;
            this.ctxtbxPass.UnderlinedStyle = false;
            // 
            // ctxtbxUserName
            // 
            this.ctxtbxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ctxtbxUserName.BorderColor = System.Drawing.Color.Transparent;
            this.ctxtbxUserName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.ctxtbxUserName.BorderRadius = 0;
            this.ctxtbxUserName.BorderSize = 2;
            this.ctxtbxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtbxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctxtbxUserName.Location = new System.Drawing.Point(53, 130);
            this.ctxtbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.ctxtbxUserName.Multiline = false;
            this.ctxtbxUserName.Name = "ctxtbxUserName";
            this.ctxtbxUserName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.ctxtbxUserName.PasswordChar = false;
            this.ctxtbxUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctxtbxUserName.PlaceholderText = "";
            this.ctxtbxUserName.Size = new System.Drawing.Size(277, 32);
            this.ctxtbxUserName.TabIndex = 4;
            this.ctxtbxUserName.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "______________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WashablesSystem.Properties.Resources.image_2;
            this.pictureBox1.Location = new System.Drawing.Point(57, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(56)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1079, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomTextbox ctxtbxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomButton cLoginButton;
        private CustomTextbox ctxtbxPass;
    }
}