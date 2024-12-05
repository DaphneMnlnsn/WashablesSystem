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
    public partial class notifItem : UserControl
    {
        Main grandparentForm;
        NotifOverlay notifOverlay;
        string notificationID;
        string category;
        public notifItem(Main grandparentForm, NotifOverlay notifOverlay)
        {
            InitializeComponent();
            this.grandparentForm = grandparentForm;
            this.notifOverlay = notifOverlay;
        }
        public notifItem(Main grandparentForm)
        {
            InitializeComponent();
            this.grandparentForm = grandparentForm;
            showNotifWithTimer();
        }
        public void setNotif(string notif, bool read, string notificationID, string category)
        {
            this.notificationID = notificationID;
            activityText.Text = notif;
            this.category = category;

            if (read)
            {
                panel1.Dispose();
            }
        }

        private void activityText_Click(object sender, EventArgs e)
        {
            NotificationClass notificationClass = new NotificationClass();
            PictureBox btn = (PictureBox)grandparentForm.FindForm().Controls.Find("btnNotif", true)[0];
            btn.Enabled = true;
            if (category.Equals("Inventory"))
            {
                notificationClass.readNotification(notificationID);
                loadForm(new Inventory(grandparentForm));
            }
            else
            {
                notificationClass.readNotification(notificationID);
                loadForm(new LaundryOperations(grandparentForm));
            }

            notifOverlay.Dispose();
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

        private void showNotifWithTimer()
        {

        }
    }
}
