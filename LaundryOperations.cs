using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class LaundryOperations : Form
    {
        public LaundryOperations(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Laundry Operations";
                string text = parentForm.Header;
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            btnInProg.BackColor = Color.FromArgb(217, 217, 217);
            btnPending.BackColor = SystemColors.Control;
        }

        private void btnInProg_Click(object sender, EventArgs e)
        {
            btnPending.BackColor = Color.FromArgb(217, 217, 217);
            btnInProg.BackColor = SystemColors.Control;
        }

        private void LaundryOperations_Load(object sender, EventArgs e)
        {
            MachineList machine = new MachineList();
            machine.setMachine("Washing Machine");
            machinePanel.Controls.Add(machine);
        }
    }
}