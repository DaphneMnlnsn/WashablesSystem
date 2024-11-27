using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addNotification()
        {

        }
        public void deleteNotification()
        {

        }
        public DataTable displayNotification()
        {
            constring.Open();
            string sql = "SELECT * FROM [Notification] INNER JOIN [Order] ON [Notification].order_id=[Order].order_id INNER JOIN [Item] ON [Notification].item_id=[Item].item_id";

            DataTable notification = new DataTable("notification");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(notification);
            constring.Close();

            return notification;
        }
    }
}
