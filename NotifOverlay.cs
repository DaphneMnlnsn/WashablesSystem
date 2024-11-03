﻿using System;
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
    public partial class NotifOverlay : UserControl
    {
        public NotifOverlay()
        {
            InitializeComponent();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            loadForm(new Notifications());
        }
        private void loadForm(Form m)
        {
            Panel panelPage = (Panel)this.FindForm().Controls.Find("panelPage", true)[0];
            if (panelPage.Controls.Count > 0)
            {
                panelPage.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panelPage.Controls.Add(m);
            panelPage.Tag = m;
            m.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NotifOverlay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.Visible == true)
                this.Dispose();
        }

        private void NotifOverlay_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) { 
                if (ctrl is Panel || ctrl is Label || ctrl is PictureBox){
                    ctrl.MouseClick += NotifOverlay_MouseClick;
                }
            }

            notifItem activity = new notifItem();
            string message = "Unit I has finished Laundry OR1003 at 10/13/2024 5:12PM";
            activity.setNotif(message);
            notifPanel.Controls.Add(activity);

            notifItem activity2 = new notifItem();
            string message2 = "Unit II has finished Laundry OR1004 at 10/14/2024 4:30PM";
            activity2.setNotif(message2);
            notifPanel.Controls.Add(activity2);

            notifItem activity3 = new notifItem();
            string message3 = "ITM003 Zonrox is low in stock! Restock now!";
            activity3.setNotif(message3);
            notifPanel.Controls.Add(activity3);
        }
    }
}