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
            /// add space for sort by button
            laundryContainer.Padding = new Padding(0, 50, 0, 0);
            cbSort.Show();
            /// add pending Laundry orders
            laundryContainer.Controls.Clear();
            PendingLaundryList pending = new PendingLaundryList();
            pending.setStatus("OR123", "Quiana Momingo", "Wash (Clothes...)", "10/12/2024 5:22PM", "10/15/2024");
            laundryContainer.Controls.Add(pending);

            PendingLaundryList pending2 = new PendingLaundryList();
            pending2.setStatus("OR123", "Quiana Momingo", "Wash (Bed Sheet...)", "10/12/2024 5:22PM", "10/15/2024");
            laundryContainer.Controls.Add(pending2);
        }

        private void btnInProg_Click(object sender, EventArgs e)
        {
            btnPending.BackColor = Color.FromArgb(217, 217, 217);
            btnInProg.BackColor = SystemColors.Control;
            /// remove space & sort by button
            laundryContainer.Padding = new Padding(0, 10, 0, 0);
            cbSort.Hide();
            /// add in-progress Laundry orders
            laundryContainer.Controls.Clear();
            InProgLaundryList inProgress = new InProgLaundryList();
            inProgress.setStatus("Unit I", "Kiana Martin", "Wash (Clothes...)", "29 minutes");
            laundryContainer.Controls.Add(inProgress);

        }

        private void LaundryOperations_Load(object sender, EventArgs e)
        {
            /// List of Machines
            MachineList WM = new MachineList();
            WM.setMachine("Washing Machine");
            machinePanel.Controls.Add(WM);

            MachineList DY = new MachineList();
            DY.setMachine("Dryer");
            machinePanel.Controls.Add(DY);

            MachineList IR = new MachineList();
            IR.setMachine("Iron");
            machinePanel.Controls.Add(IR);

            /// add Laundry orders
            cbSort.Hide();
            laundryContainer.Padding = new Padding(0, 10, 0, 0);
            InProgLaundryList inProgress = new InProgLaundryList();
            inProgress.setStatus("Unit I", "Kiana Martin", "Wash (Clothes...)", "29 minutes");
            laundryContainer.Controls.Add(inProgress);

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddLaundry laundryForm = new AddLaundry();
            laundryForm.ShowDialog();
        }
    }
}