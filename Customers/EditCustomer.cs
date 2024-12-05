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
   
    public partial class EditCustomer : Form
    {
        CustomerInfo _parentForm = new CustomerInfo();
        private string customer_selected;
        public EditCustomer(CustomerInfo parentForm, string customerSelected)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this.customer_selected = customerSelected;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            //call displayselectedinfo method here
            CustomerClass customerClass = new CustomerClass();
            DataTable customerInfo = new DataTable();
            customerInfo = customerClass.displaySelectedCustomer(customer_selected);

            foreach (DataRow row in customerInfo.Rows)
            {
                txtBoxName.Text = row["customer_name"].ToString();
                txtBoxEmail.Text = row["customer_email"].ToString();
                txtBoxPhone.Text = row["customer_phone"].ToString();
                txtBoxAddress.Text = row["customer_address"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //call edit method here
                CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text, txtBoxAddress.Text);
                customerClass.editCustomer(customer_selected);
                _parentForm.RefreshPanel();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
