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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            CustomerClass custom = new CustomerClass();
            DataTable customers = custom.displayCustomer();
            foreach (DataRow row in customers.Rows)
            {
                CustomerList account = new CustomerList();
                account.setCustomerInfo(row["customer_id"].ToString(), row["customer_name"].ToString(),
                   row["customer_email"].ToString(), row["customer_phone"].ToString(),
                   row["customer_address"].ToString(), WashablesSystem.Properties.Resources.Create, "Edit");
                customerContainer.Controls.Add(account);
            }
         

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
