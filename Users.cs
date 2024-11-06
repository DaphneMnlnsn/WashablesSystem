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
    public partial class Users : Form
    {
        string openedForm = "User Account";

        public Users(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Users";
            }
            
        }

        public Users(Main parentForm, string openForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Users";
            }
            this.openedForm = openForm;
        }

        private void loadForm(Form m)
        {
            if (this.panelTab.Controls.Count > 0)
            {
                this.panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panelTab.Controls.Add(m);
            this.panelTab.Tag = m;
            m.Show();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            if (openedForm.Equals("Activity Log"))
            {
                btnActivityLog_Click(sender, e);
            }
            else
            {
                btnUserAccount_Click(sender, e);
            }
        }
        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            loadForm(new UserAccount());
            btnUserAccount.BackColor = Color.FromArgb(217, 217, 217);
            btnUserArchive.BackColor = SystemColors.Control;
            btnActivityLog.BackColor = SystemColors.Control;
        }
        private void btnUserArchive_Click(object sender, EventArgs e)
        {
            loadForm(new UserArchive());
            btnUserArchive.BackColor = Color.FromArgb(217, 217, 217);
            btnUserAccount.BackColor = SystemColors.Control;
            btnActivityLog.BackColor = SystemColors.Control;
        }
        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            loadForm(new ActivityLog());
            btnActivityLog.BackColor = Color.FromArgb(217, 217, 217);
            btnUserAccount.BackColor = SystemColors.Control;
            btnUserArchive.BackColor = SystemColors.Control;
        }
    }
}
