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
    public partial class EditLaundry : Form
    {
        public EditLaundry()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditLaundry_Load(object sender, EventArgs e)
        {
            cbMachine.Text = "Washing Machine";
            cbUnit.Text = "Not set";
            pickupDate.Text = "10/16/2024";
            btnService.Text = "Wash-Dry-Fold (Clothes, Table Napkin, Pillowcase)";
            cbCust.SelectedIndex = 1;
            txtWeight.Value = decimal.Parse("5.00");
            cbItem1.SelectedIndex = 0;
            cbItem2.SelectedIndex = 2;
            quantity1.Value = decimal.Parse("2.00");
            quantity2.Value = decimal.Parse("1.00");
            rb2hrs.Checked = true;

        }
        private void btnService_Click(object sender, EventArgs e)
        {
            SelectServices select = new SelectServices(this);
            select.ShowDialog();
        }
    }
}
