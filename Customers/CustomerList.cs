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
    public partial class CustomerList : UserControl
    {
        public CustomerList()
        {
            InitializeComponent();
        }
        public void setCustomerInfo(string customerNum, string customerName, string customerEmail, string customerPhone, string customerAddress, Image image, string kind)
        {
            //Displaying customer info
            custNo.Text = customerNum;
            custName.Text = customerName;
            emailAd.Text = customerEmail;
            phoneNum.Text = customerPhone;
            address.Text = customerAddress;
            btnEdit.Image = image;
            what.Text = kind;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(what.Text.Equals("edit"))
            {
                EditCustomer editCustomer = new EditCustomer();
                editCustomer.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Restore this information?", "Confirm Restore", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Customer information restored successfully!");
                }
            }
            
        }
    }
}
