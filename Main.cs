using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WashablesSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loadForm(new Dashboard(this));
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void loadForm(Form m)
        {
            if (this.panelPage.Controls.Count > 0)
            {
                this.panelPage.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panelPage.Controls.Add(m);
            this.panelPage.Tag = m;
            m.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard(this));
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            loadForm(new LaundryOperations(this));
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            loadForm(new Schedule(this));
        }

        private void btnSAndE_Click(object sender, EventArgs e)
        {
            loadForm(new ServicesAndEquipment(this));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory(this));
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new Customers(this));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadForm(new Users(this));
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            loadForm(new Billing(this));
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            NotifOverlay notif1 = new NotifOverlay(this);
            notif1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(notif1);
            notif1.Size = new System.Drawing.Size(524, 615);
            notif1.Dock = DockStyle.Right;
            notif1.Select();
            notif1.BringToFront();
            btnNotif.Enabled = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public string Header
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
