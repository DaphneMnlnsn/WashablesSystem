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
                serviceID = acronym + "1";
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
        public void editService(string serviceID)
        {
            
        }
        public DataTable displaySelectedItem(string itemID)
        {
            return new DataTable();
        }
        public void restoreService(string serviceID)
        {

        }
        public void archiveService(string serviceID)
        {

        }
        public void deleteService(string serviceID)
        {

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
            return new DataTable();

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
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited service "
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Archived Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','archived service "
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Restored Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','restored service "
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Deleted Service"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','deleted service "
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
