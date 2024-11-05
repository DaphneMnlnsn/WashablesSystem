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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            AccountList account1= new AccountList();
            account1.setUserAccount("U001", "Lyca Max", "Yes", "Yes", "Yes", "No", "No", "Yes", "No", "Yes");
            accountContainer.Controls.Add(account1);

            AccountList account2 = new AccountList();
            account2.setUserAccount("U002", "Lyco Max", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes", "Yes");
            accountContainer.Controls.Add(account2);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
