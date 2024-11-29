using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class EditUser : Form
    {
        private UserAccount _parentForm = new UserAccount();
        private string user_selected;
        public EditUser(UserAccount parentForm, string userSelected)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this.user_selected = userSelected;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            UserClass userClass = new UserClass();
            DataTable userInfo = new DataTable();
            userInfo = userClass.displaySelectedUser(user_selected);

            foreach (DataRow row in userInfo.Rows)
            {
                txtBoxFullname.Text = row["user_fullname"].ToString();
                txtBoxName.Text = row["username"].ToString();
                txtBoxPass.Text = Cryptography.Decrypt(row["user_password"].ToString());
                txtBoxConfirm.Text = txtBoxPass.Text;
                
                checkDashboard.Checked = bool.Parse(row["dashboard_access"].ToString());
                checkLaundry.Checked = bool.Parse(row["laundry_access"].ToString());
                checkSched.Checked = bool.Parse(row["schedule_access"].ToString());
                checkSAndE.Checked = bool.Parse(row["sAndE_access"].ToString());
                checkInventory.Checked = bool.Parse(row["inventory_access"].ToString());
                checkCustomers.Checked = bool.Parse(row["customer_access"].ToString());
                checkUsers.Checked = bool.Parse(row["user_access"].ToString());
                checkBilling.Checked = bool.Parse(row["billing_access"].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals(txtBoxConfirm.Text))
            {
                UserClass userClass = new UserClass(txtBoxFullname.Text, txtBoxName.Text, txtBoxPass.Text, checkDashboard.Checked, checkLaundry.Checked,
                                checkSched.Checked, checkSAndE.Checked, checkInventory.Checked, checkCustomers.Checked, checkUsers.Checked, checkBilling.Checked);
                userClass.editUser(user_selected);
                _parentForm.RefreshPanel();
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
