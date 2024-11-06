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
    public partial class NotificationList : UserControl
    {
        public NotificationList()
        {
            InitializeComponent();
        }
        public void setNotificationInfo(string Num, string Subject, string Received)
        {
            //Displaying info
            lblNo.Text = Num;
            lblSubject.Text = Subject;
            lblReceived.Text = Received;
        }
    }
}