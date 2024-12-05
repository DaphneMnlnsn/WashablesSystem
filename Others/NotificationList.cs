using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class NotificationList : UserControl
    {
        private Notifications _parentForm = new Notifications(new Main());
        string pageLocation;
        bool readStatus;
        public NotificationList(Notifications parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public void setNotificationInfo(string Num, string unit_id, string order_id, string item_id, string item_name, string Subject, string loc, bool read, string Received)
        {
            //Displaying info
            this.readStatus = read;
            this.pageLocation = loc;
            lblNo.Text = Num;
            if (!order_id.Equals(""))
            {
                lblSubject.Text = unit_id + " " + Subject + " " + order_id;
            }
            else if (!item_id.Equals(""))
            {
                lblSubject.Text = item_id + " " + item_name + " " + Subject;
            }
            lblReceived.Text = Received;
        }

        private void btnTrash_Click(object sender, System.EventArgs e)
        {
            NotificationClass notificationClass = new NotificationClass();
            notificationClass.deleteNotification(lblNo.Text);
            _parentForm.RefreshPanel();
        }
    }
}