namespace WashablesSystem
{
    partial class MachineList
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
            this.lblMachine = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.machineContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblMachine
            // 
            this.lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(5, 4);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(104, 26);
            this.lblMachine.TabIndex = 4;
            this.lblMachine.Text = "Machines";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(-3, 23);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(607, 13);
            this.line.TabIndex = 5;
            this.line.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // machineContainer
            // 
            this.machineContainer.Location = new System.Drawing.Point(0, 36);
            this.machineContainer.Name = "machineContainer";
            this.machineContainer.Size = new System.Drawing.Size(599, 241);
            this.machineContainer.TabIndex = 6;
            // 
            // MachineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.line);
            this.Controls.Add(this.machineContainer);
            this.Name = "MachineList";
            this.Size = new System.Drawing.Size(599, 277);
            this.Load += new System.EventHandler(this.MachineList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.FlowLayoutPanel machineContainer;
    }
}