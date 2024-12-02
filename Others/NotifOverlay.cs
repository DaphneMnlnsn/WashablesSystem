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
    public partial class NotifOverlay : UserControl
    {
        Main parentForm;
        public NotifOverlay(Main parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)parentForm.FindForm().Controls.Find("btnNotif", true)[0];
            btn.Enabled = true;
            loadForm(new Notifications(parentForm));
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
            PictureBox btn = (PictureBox)parentForm.FindForm().Controls.Find("btnNotif", true)[0];
            btn.Enabled = true;
        }

        private void NotifOverlay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.Visible == true)
                this.Dispose();
                PictureBox btn = (PictureBox)parentForm.FindForm().Controls.Find("btnNotif", true)[0];
                btn.Enabled = true;
        }

        private void NotifOverlay_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls) { 
                if (ctrl is Panel || ctrl is Label || ctrl is PictureBox){
                    ctrl.MouseClick += NotifOverlay_MouseClick;
                }
            }

            NotificationClass notifClass = new NotificationClass();
            DataTable notifications = notifClass.displayNotification();
            foreach (DataRow row in notifications.Rows)
            {
                notifItem notif = new notifItem(parentForm, this);
                if (!row["order_id"].ToString().Equals(""))
                {
                   notif.setNotif("Laundry " + row["order_id"].ToString() + " " + row["notification_subject"].ToString() + ".", bool.Parse(row["read_status"].ToString()), row["notification_id"].ToString(), "Schedule");
                }
                else if (!row["item_id"].ToString().Equals(""))
                {
                    notif.setNotif(row["item_id"].ToString() + " " + row["item_name"].ToString() + " " + row["notification_subject"].ToString() + ". Restock now!", bool.Parse(row["read_status"].ToString()), row["notification_id"].ToString(), "Inventory");
                }
                notifPanel.Controls.Add(notif);
            }
        }
    }
}
