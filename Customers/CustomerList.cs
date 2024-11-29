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
    public partial class CustomerList : UserControl
    {
        CustomerInfo _parentForm = new CustomerInfo();
        CustomerArchive _archiveForm = new CustomerArchive();
        public CustomerList(CustomerInfo parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public CustomerList(CustomerArchive parentForm)
        {
            InitializeComponent();
            _archiveForm = parentForm;
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
            if(what.Text.Equals("Edit"))
            {
                EditCustomer editCustomer = new EditCustomer(_parentForm, custNo.Text);
                editCustomer.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore this customer information?\nThis will be moved to customer information.", "Confirm Restore", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerClass customerClass = new CustomerClass();
                    customerClass.restoreCustomer(custNo.Text);
                    _archiveForm.RefreshPanel();
                }

            }
            
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (what.Text.Equals("Edit"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer information?\nThis will be moved to the user archive.", "Confirm Archive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerClass customerClass = new CustomerClass();
                    customerClass.archiveCustomer(custNo.Text);
                    _parentForm.RefreshPanel();
                }
            }
            else
            {
                //call delete method here
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer information?\nThis will be deleted permanently.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerClass customerClass = new CustomerClass();
                    customerClass.deleteCustomer(custNo.Text);
                    _archiveForm.RefreshPanel();
                }
            }
        }
    }
}
