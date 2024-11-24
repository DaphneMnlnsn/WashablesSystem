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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            CustomerList customer = new CustomerList();
            customer.setCustomerInfo("C001", "Quiana Momingo", "momingo@gmail.com", "09132134761", "01 St., Balagtas, Bulacan", WashablesSystem.Properties.Resources.Create, "edit");
            customerContainer.Controls.Add(customer);

            CustomerList customer2 = new CustomerList();
            customer2.setCustomerInfo("C002", "Kiana Valerio", "kvalerio@gmail.com", "09132133568", "02 St., Balagtas, Bulacan", WashablesSystem.Properties.Resources.Create, "edit");
            customerContainer.Controls.Add(customer2);

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
