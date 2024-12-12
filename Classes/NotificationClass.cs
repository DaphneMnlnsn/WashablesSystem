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

        public void sendNotification(string num, string type)
        {
            try
            {
                constring.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [notification_id] FROM [Notification] ORDER BY [datetime_received] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    notificationID = reader1.GetString(0);
                    int IDNum = int.Parse(string.Join("", notificationID.Where(Char.IsDigit))) + 1;
                    notificationID = IDNum.ToString();
                }
                else
                {
                    notificationID = "1";
                }
                reader1.Close();
                cmd.Dispose();

                string query = "";
                string description = "";
                if (type.Equals("Laundry Finished"))
                {
                    description = "has finished";
                    //Query for inserting
                    query = "INSERT INTO [Notification] VALUES('" + notificationID + "','" + num + "',null,'"
                        + description + "','Laundry Operations',0,'" + DateTime.Now + "')";
                }
                else if (type.Equals("Low on Stock"))
                {
                    description = "is low on stock";
                    //Query for inserting
                    query = "INSERT INTO [Notification] VALUES('" + notificationID + "',null,'" + num + "','"
                        + description + "','Inventory',0,'" + DateTime.Now + "')";
                }
                else if (type.Equals("Out of Stock"))
                {
                    description = "is out of stock";
                    //Query for inserting
                    query = "INSERT INTO [Notification] VALUES('" + notificationID + "',null,'" + num + "','"
                        + description + "','Inventory',0,'" + DateTime.Now + "')";
                }

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    new Main(num + " " + description);
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                    constring.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
        public void checkIfAllRead()
        {
            constring.Open();

            //Query for checking    
            string query = "SELECT [notification_id] FROM Notification WHERE [read_status] != 1;";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            SqlDataReader reader1 = cmd2.ExecuteReader();
            if (!reader1.Read())
            {
                sessionVar.allRead = true;
                constring.Close();
            }
            else
            {
                sessionVar.allRead = false;
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
            string sql = "SELECT * FROM [Notification] LEFT JOIN [OrderBatch] ON [Notification].batch_id=[OrderBatch].batch_id LEFT JOIN [Item] ON [Notification].item_id=[Item].item_id ORDER BY [datetime_received] DESC";

            DataTable notification = new DataTable("notification");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(notification);
            constring.Close();

            return notification;
        }
    }
}
