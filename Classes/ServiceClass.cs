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

            //Add Service to Database
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [service_name],[service_id] FROM [Service] ORDER BY [service_id] DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            { 
                serviceID = reader1.GetString(1);
                IDNum = int.Parse(string.Join("", serviceID.Where(Char.IsDigit))) + 1;
                ///
                /// service code generator
                /// 
                string input = serviceCategory;
                string acronym = "";
                char[] separators = new char[] {'-'};
                string[] words = input.Split(separators,StringSplitOptions.RemoveEmptyEntries);
                foreach(string word in words)
                {
                    acronym += word[0];
                }
                serviceID = acronym + IDNum;
                ///
                ///
                ///
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
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
        public void restoreService(string serviceID)
        {

        }
        public void archiveService(string serviceID)
        {

        }
        public void deleteUnit(string serviceID)
        {

        }
        public DataTable displayUnit()
        {
            constring.Open();
            string sql = "SELECT * FROM [Service] WHERE archived = 0 AND service_category = '" + serviceCategory + "'";
            DataTable service = new DataTable("services");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(service);
            constring.Close();

            return service;
        }
        private void logOperation(string activity)
        {
            if (activity.Equals("Added New Service"))
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
                    MessageBox.Show("No Data Found");
                }
                reader1.Close();
                cmd.Dispose();
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added service "
                            + serviceID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Services" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Service successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
