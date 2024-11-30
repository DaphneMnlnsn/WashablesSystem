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
    public partial class AddUser : Form
    {
        private UserAccount _parentForm = new UserAccount();
        public AddUser(UserAccount parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals(txtBoxConfirm.Text))
            {
                UserClass userClass = new UserClass(txtBoxFullname.Text, txtBoxName.Text, txtBoxPass.Text, checkLaundry.Checked,
                                checkSched.Checked, checkSAndE.Checked, checkInventory.Checked, checkCustomers.Checked, checkUsers.Checked, checkBilling.Checked);
                userClass.addUser();
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
