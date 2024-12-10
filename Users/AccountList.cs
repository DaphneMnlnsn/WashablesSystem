using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class AccountList : UserControl
    {
        private UserAccount _parentForm = new UserAccount();
        public AccountList(UserAccount parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public void setUserAccount(string employeeNum, string empName, string laundryChecked, string scheduleChecked, string serviceEqChecked, string inventoryChecked, string customersChecked, string usersChecked, string billingChecked)
        {
            //Displaying customer info
            employeeNo.Text = employeeNum;
            employeeName.Text = empName;
            Image check = WashablesSystem.Properties.Resources.Check_Mark;
            if (laundryChecked.Equals("True"))
            {
                laundryCheck.Image = check;
            }
            if (scheduleChecked.Equals("True"))
            {
                scheduleCheck.Image = check;
            }
            if (serviceEqChecked.Equals("True"))
            {
                sAndECheck.Image = check;
            }
            if (inventoryChecked.Equals("True"))
            {
                inventoryCheck.Image = check;
            }
            if (customersChecked.Equals("True"))
            {
                customersCheck.Image = check;
            }
            if (usersChecked.Equals("True"))
            {
                usersCheck.Image = check;
            }
            if (billingChecked.Equals("True"))
            {
                billingCheck.Image = check;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(_parentForm, employeeNo.Text);
            editUser.ShowDialog();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to archive this user account?\nThis will be moved to the user archive.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserClass userClass = new UserClass();
                userClass.archiveUser(employeeNo.Text);
                _parentForm.RefreshPanel();
            }

        }
    }
}
