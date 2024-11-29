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
    public partial class CustomerArchive : Form
    {
        public CustomerArchive()
        {
            InitializeComponent();
        }

        private void CustomerArchive_Load(object sender, EventArgs e)
        {
            customerArchiveContainer.Controls.Clear();
            CustomerClass userArchive = new CustomerClass();
            DataTable users = userArchive.displayCustomerArchive();
            foreach (DataRow row in users.Rows)
            {
                CustomerList archive = new CustomerList(this);
                archive.setCustomerInfo(row["customer_id"].ToString(), row["customer_name"].ToString(), row["customer_email"].ToString(), row["customer_phone"].ToString(), row["customer_address"]. ToString(), WashablesSystem.Properties.Resources.Restore, "Restore"); 
                customerArchiveContainer.Controls.Add(archive);
            }
        }
        public void RefreshPanel()
        {
            this.CustomerArchive_Load(null, null);
        }
    }
}
