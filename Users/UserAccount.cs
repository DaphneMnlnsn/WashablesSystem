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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            accountContainer.Controls.Clear();
            UserClass user  = new UserClass();
            DataTable users = user.displayUser();
            foreach (DataRow row in users.Rows)
            {
                AccountList account = new AccountList(this);
                account.setUserAccount(row["user_id"].ToString(), row["username"].ToString(),row["laundry_access"].ToString(), 
                   row["schedule_access"].ToString(), row["sAndE_access"].ToString(), 
                   row["inventory_access"].ToString(), row["customer_access"].ToString(),
                   row["user_access"].ToString(), row["billing_access"].ToString());
                accountContainer.Controls.Add(account);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.ShowDialog();
        }
        public void RefreshPanel()
        {
            UserAccount_Load(null, null);
        }
    }
}
