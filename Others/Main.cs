using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class Main : Form
    {
        SessionVariables sessionVariables;
        bool laundryOpAccess, schedAccess, sAndEAccess, inventoryAccess, customerAccess, userAccess, billingAccess;
        Timer notifTimer;
        NotificationClass notificationClass = new NotificationClass();
        public Main()
        {
            InitializeComponent();
            loadForm(new Dashboard(this));
        }
        public Main(string activity)
        {
            InitializeComponent();
            MessageBox.Show(activity);
        }

        public void showNotif(string activity)
        {
            Panel notificationPanel = new Panel
            {
                BackColor = System.Drawing.Color.FromArgb(179, 200, 176),
                Size = new System.Drawing.Size(450, 62),
                Location = new System.Drawing.Point(1160, 110),
                Visible = false
            };

            Label notificationLabel = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10),
                Text = "Notification Text"
            };

            notificationPanel.Controls.Add(notificationLabel);
            this.Controls.Add(notificationPanel);

            notificationPanel.BringToFront();

            notifTimer = new Timer();
            notifTimer.Interval = 2000;
            notifTimer.Tick += (s, e) =>
            {
                notifTimer.Stop();

                notificationLabel.Text = activity;
                notificationPanel.Visible = true;

                Timer hideTimer = new Timer { Interval = 5000 };
                hideTimer.Tick += (s2, e2) =>
                {
                    notificationPanel.Dispose();
                    hideTimer.Stop();
                };
                hideTimer.Start();
            };
            notifTimer.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sessionVariables = new SessionVariables(true);
            sessionVariables = new SessionVariables();
            UserClass userClass = new UserClass();
            DataTable user = userClass.displaySelectedUser(sessionVariables.loggedIn);
            foreach (DataRow row in user.Rows)
            {
                laundryOpAccess = bool.Parse(row["laundry_access"].ToString());
                schedAccess = bool.Parse(row["schedule_access"].ToString());
                sAndEAccess = bool.Parse(row["sAndE_access"].ToString());
                inventoryAccess = bool.Parse(row["inventory_access"].ToString());
                customerAccess = bool.Parse(row["customer_access"].ToString());
                userAccess = bool.Parse(row["user_access"].ToString());
                billingAccess = bool.Parse(row["billing_access"].ToString());
            }

            notificationClass.checkIfAllRead();

            if (sessionVariables.allRead)
            {
                btnNotif.Image = WashablesSystem.Properties.Resources.Bell;
            }
            else
            {
                btnNotif.Image = WashablesSystem.Properties.Resources.NewNotif;
            }
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
            if (laundryOpAccess)
            {
                loadForm(new LaundryOperations(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (schedAccess)
            {
                loadForm(new Schedule(this, "In Progress"));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSAndE_Click(object sender, EventArgs e)
        {
            if (sAndEAccess)
            {
                loadForm(new ServicesAndEquipment(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (inventoryAccess)
            {
                loadForm(new Inventory(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (customerAccess)
            {
                loadForm(new Customers(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (userAccess)
            {
                loadForm(new Users(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (billingAccess)
            {
                loadForm(new Billing(this));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            notificationClass.checkIfAllRead();

            if (sessionVariables.allRead)
            {
                btnNotif.Image = WashablesSystem.Properties.Resources.Bell;
            }
            else
            {
                btnNotif.Image = WashablesSystem.Properties.Resources.NewNotif;
            }
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }
    }
}
