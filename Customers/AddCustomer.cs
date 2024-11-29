using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class AddCustomer : Form
    {
        CustomerInfo _parentForm = new CustomerInfo();
        public AddCustomer(CustomerInfo parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text, txtBoxAddress.Text);
            customerClass.addCustomer();
            _parentForm.RefreshPanel();
            this.Close();
        }
    }
}
