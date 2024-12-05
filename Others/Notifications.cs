using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class Notifications : Form
    {

        public Notifications(Main grandparentForm)
        {
            InitializeComponent();
            if (grandparentForm != null)
            {
                grandparentForm.Header = "Notifications";
            }
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            NotificationContainer.Controls.Clear();
            NotificationClass notifClass = new NotificationClass();
            DataTable notifications = notifClass.displayNotification();
            foreach (DataRow row in notifications.Rows)
            {
                NotificationList notif = new NotificationList(this);
                notif.setNotificationInfo(row["notification_id"].ToString(), row["unit_id"].ToString(),
                    row["batch_id"].ToString(), row["item_id"].ToString(),
                   row["item_name"].ToString(), row["notification_subject"].ToString(),
                   row["notification_location"].ToString(), bool.Parse(row["read_status"].ToString()),
                   row["datetime_received"].ToString());
                NotificationContainer.Controls.Add(notif);
            }
        }
        public void RefreshPanel()
        {
            this.Notifications_Load(null, null);
        }
    }
}