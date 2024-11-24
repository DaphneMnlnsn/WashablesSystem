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

namespace WashablesSystem
{
    public partial class AccountList : UserControl
    {
        public AccountList()
        {
            InitializeComponent();
        }
        public void setUserAccount(string employeeNum, string empName, string dashboardChecked,string laundryChecked, string scheduleChecked, string serviceEqChecked, string inventoryChecked, string customersChecked, string usersChecked, string billingChecked)
        {
            //Displaying customer info
            employeeNo.Text = employeeNum;
            employeeName.Text = empName;
            lblDashboard.Text = dashboardChecked;
            lblLaundry.Text = laundryChecked;
            lblSchedule.Text = scheduleChecked;
            lblSerEq.Text = serviceEqChecked;
            lblInventory.Text = inventoryChecked;
            lblCustomers.Text = customersChecked;
            lblUsers.Text = usersChecked; 
            lblBilling.Text = billingChecked;    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.ShowDialog();
        }
    }
}
