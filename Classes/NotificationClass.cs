using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem.Classes
{
    internal class NotificationClass
    {
        private string notificationID;
        private string notificationSubject;
        private DateTime notificationTime;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public NotificationClass()
        {
            constring = sessionVar.Constring;
        }

        public void sendNotification()
        {
            
        }
        public void deleteNotification(string notificationID)
        {
            constring.Open();
            this.notificationID = notificationID;

            string sql = "DELETE FROM [Notification] WHERE notification_id = '" + notificationID + "'";

            SqlCommand cmd2 = new SqlCommand(sql, constring);
            cmd2.CommandText = sql;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void readNotification(string notificationID)
        {
            constring.Open();
            this.notificationID = notificationID;

            string sql = "UPDATE [Notification] SET read_status = 1 WHERE notification_id = '" + notificationID + "'";

            SqlCommand cmd2 = new SqlCommand(sql, constring);
            cmd2.CommandText = sql;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public DataTable displayNewNotif()
        {
            return new DataTable();
        }
        public DataTable displayNotification()
        {
            constring.Open();
            string sql = "SELECT * FROM [Notification] LEFT JOIN [Order] ON [Notification].order_id=[Order].order_id LEFT JOIN [Item] ON [Notification].item_id=[Item].item_id ORDER BY notification_id DESC";

            DataTable notification = new DataTable("notification");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(notification);
            constring.Close();

            return notification;
        }
    }
}
