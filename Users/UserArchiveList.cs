using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class UserArchiveList : UserControl
    {
        UserClass userClass;
        public UserArchiveList()
        {
            InitializeComponent();
            userClass = new UserClass();
        }
        public void setUserArchive(string userArchiveNum, string userArchiveFullName, string userArchiveName)
        {
            //Displaying customer info
            userArchNo.Text = userArchiveNum;
            userFullName.Text = userArchiveFullName;
            userArchName.Text = userArchiveName;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore this user account?\nThis will be moved to User Accounts.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userClass.restoreUser(userArchNo.Text);
            }
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user account?\nThis will be deleted permanently.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                userClass.deleteUser(userArchNo.Text);
            }
        }
    }
}
