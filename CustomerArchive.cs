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
    public partial class CustomerArchive : Form
    {
        public CustomerArchive()
        {
            InitializeComponent();
        }

        private void CustomerArchive_Load(object sender, EventArgs e)
        {
            CustomerList customer = new CustomerList();
            customer.setCustomerInfo("C003", "Quiana Momingo", "momingo@gmail.com", "09132134761", "01 St., Balagtas, Bulacan", WashablesSystem.Properties.Resources.Restore, "archive");
            customerArchiveContainer.Controls.Add(customer);

            CustomerList customer2 = new CustomerList();
            customer2.setCustomerInfo("C004", "Natasha Valerio", "kvalerio@gmail.com", "09132133568", "02 St., Balagtas, Bulacan", WashablesSystem.Properties.Resources.Restore, "archive");
            customerArchiveContainer.Controls.Add(customer2);
        }
    }
}
