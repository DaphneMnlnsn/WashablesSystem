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
        private string customer_selected;
        public EditCustomer(string customerSelected)
        {
            InitializeComponent();
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
            //call edit method here
            CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxEmail.Text, txtBoxPhone.Text, txtBoxAddress.Text);               
            customerClass.editCustomer(customer_selected);
            this.Close();
        }
    }
}
