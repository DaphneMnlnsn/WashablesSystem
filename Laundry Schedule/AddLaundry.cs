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
    public partial class AddLaundry : Form
    {
        public AddLaundry()
        {
            InitializeComponent();
        }

        public AddLaundry(string machineSelected, string unitSelected)
        {
            InitializeComponent();
            cbMachine.Text = machineSelected;
            cbUnit.Text = unitSelected;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// collect details
            string unit = cbMachine.Text;
            string custName = cbCust.Text;
            string service = btnService.Text;
            string weight = txtWeight.Text;
            string item1 = cbItem1.Text;
            string item2 = cbItem2.Text;
            string item3 = cbItem3.Text;
            string date = pickupDate.Text;
            /// confirmation message
            //MessageBox.Show("Laundry Order Added Successfully!");
            /// add
            //PendingLaundryList pending = new PendingLaundryList();
            //pending.setStatus("OR002", custName, service, "10:00AM", date);
            //laundryContainer.Controls.Add(pending);                          //I tried HAHAHA
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            SelectServices select = new SelectServices(this);
            select.ShowDialog();
        }
    }
}