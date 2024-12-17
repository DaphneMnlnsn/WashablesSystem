
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem.Classes
{
    internal class ServiceClass
    {
        private string serviceID;
        private string serviceName;
        private string serviceCategory;
        private decimal servicePrice;
        private decimal serviceMinWeight;
        private bool availabilityStatus;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public ServiceClass()
        {
            constring = sessionVar.Constring;
        }
        public ServiceClass(string service_category)
        {
            constring = sessionVar.Constring;
            this.serviceCategory = service_category;
        }
        public ServiceClass(string service_category, string name, decimal rate, decimal weight)
        {
            constring = sessionVar.Constring;
            this.serviceCategory = service_category;
            this.serviceName = name;
            this.servicePrice = rate;
            this.serviceMinWeight = weight;
        }

        public void addService()
        {
            int IDNum;

            try
            {
                constring.Open();

                ///
                /// service code generator
                /// 
                string input = serviceCategory;
                string acronym = "";
                char[] separators = new char[] { '-' };
                string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    acronym += word[0];
                }

                //Add Service to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [service_name],[service_id] FROM [Service] WHERE [service_category] = '" + serviceCategory + "' ORDER BY [service_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    serviceID = reader1.GetString(1);
                    IDNum = int.Parse(string.Join("", serviceID.Where(Char.IsDigit))) + 1;
                    serviceID = acronym + IDNum;
                }
                else
                {
                    serviceID = acronym + "101";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                String query = "INSERT INTO [Service] VALUES('" + serviceID + "','" + serviceName + "','"
                    + serviceCategory + "','" + servicePrice + "','" + serviceMinWeight + "',0);";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Added New Service");

                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                    constring.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void editService(string serviceID)
        {
            try
            {
                constring.Open();

                this.serviceID = serviceID;

                //Query for editing
                String query = "UPDATE [Service] SET service_name='" + serviceName + "',service_category='"
                    + serviceCategory + "',service_rate='" + servicePrice + "',service_minWeight='" + serviceMinWeight
                    + "' WHERE service_id='" + serviceID + "';";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Edited Service");
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
        public DataTable displaySelectedService(string serviceID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Service] WHERE service_id = '" + serviceID + "'";
            DataTable serviceInfo = new DataTable("serviceInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(serviceInfo);
            constring.Close();

            return serviceInfo;
        }
        public void restoreService(string serviceID)
        {
            constring.Open();

            this.serviceID = serviceID;

            String query = "UPDATE [Service] SET archived=0 WHERE service_id='" + serviceID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Restored Service");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void archiveService(string serviceID)
        {
            constring.Open();

            this.serviceID = serviceID;

            //Query for editing
            String query = "UPDATE [Service] SET archived=1 WHERE service_id='" + serviceID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Archived Service");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void deleteService(string serviceID)
        {
            constring.Open();

            this.serviceID = serviceID;

            string checkQuery = "SELECT COUNT(*) FROM [Order] WHERE service_id = @ServiceId OR service_id2 = @ServiceId OR service_id3 = @ServiceId";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, constring))
            {
                checkCommand.Parameters.AddWithValue("@ServiceId", serviceID);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Service cannot be deleted because it is in a record.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else
                {
                    string query = "DELETE FROM [Service] WHERE service_id='" + serviceID + "';";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Deleted Service");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }

        }
        public DataTable displayService()
        {
            constring.Open();
            string sql = "SELECT * FROM [Service] WHERE archived = 0 AND service_category = '" + serviceCategory + "'";
            DataTable service = new DataTable("services");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(service);
            constring.Close();

            return service;
        }
        public DataTable displayServiceArchive()
        {
            constring.Open();
            string sql = "SELECT * FROM [Service] WHERE archived = 1";
            DataTable serviceInfo = new DataTable("serviceInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(serviceInfo);
            constring.Close();

            return serviceInfo;
        }
        private void logOperation(string activity)
        {
            constring.Open();
            int logID = 0;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [log_id] FROM ActivityLog ORDER BY [log_id] DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                logID = reader1.GetInt32(0) + 1;
            }
            else
            {
                logID = 1;
            }
            reader1.Close();
            cmd.Dispose();

            if (activity.Equals("Added New Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added service "
                            + serviceID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited service "
                            + serviceID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Archived Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','archived service "
                            + serviceID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Restored Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','restored service "
                            + serviceID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Deleted Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','deleted service "
                            + serviceID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}