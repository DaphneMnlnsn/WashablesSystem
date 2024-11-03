﻿using System;
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
            loadForm(new Dashboard());
        }

        public Main(string open)
        {
            InitializeComponent();
            if (open.Equals("customers"))
            {
                loadForm(new Customers());
            }
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
            loadForm(new Dashboard());
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            loadForm(new LaundryOperations());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            loadForm(new Schedule());
        }

        private void btnSAndE_Click(object sender, EventArgs e)
        {
            loadForm(new ServicesAndEquipment());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadForm(new Inventory());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            loadForm(new Customers());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            loadForm(new Users());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            loadForm(new Billing());
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            NotifOverlay notif1 = new NotifOverlay();
            notif1.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(notif1);
            notif1.Size = new System.Drawing.Size(524, 615);
            notif1.Location = new System.Drawing.Point(1093, 110);
            notif1.Select();
            notif1.BringToFront();
        }
    }
}
