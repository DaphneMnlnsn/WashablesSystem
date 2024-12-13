using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                if (!txtBoxName.Text.Equals("") && !txtBoxName.Text.Equals(" ") && Regex.IsMatch(txtBoxPhone.Text, @"^09\d{9}$") &&
                    Regex.IsMatch(txtBoxEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text, txtBoxAddress.Text);
                    customerClass.addCustomer();
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else if(!Regex.IsMatch(txtBoxPhone.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Invalid phone number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(!Regex.IsMatch(txtBoxEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Invalid email address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
