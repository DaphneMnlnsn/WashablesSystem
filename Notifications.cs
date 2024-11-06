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
            NotificationList notif1 = new NotificationList();
            notif1.setNotificationInfo("1", "Unit I has finished Laundry OR1003", "10/24/2024 11:00:04AM");
            NotificationContainer.Controls.Add(notif1);

            NotificationList notif2 = new NotificationList();
            notif2.setNotificationInfo("2", "Unit II has finished Laundry OR1005", "10/24/2024 11:40:05AM");
            NotificationContainer.Controls.Add(notif2);

            NotificationList notif3 = new NotificationList();
            notif3.setNotificationInfo("3", "ITM003 Zonrox is low in stock! Restock now before it runs out!", "10/24/2024 2:30:14PM");
            NotificationContainer.Controls.Add(notif3);
        }
    }
}