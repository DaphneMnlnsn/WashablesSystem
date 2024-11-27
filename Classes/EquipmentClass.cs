using System;
using System.Collections;
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
    internal class EquipmentClass
    {
        private string unitID;
        private string unitName;
        private bool unitStatus;
        private string availabilityStatus;
        private string unitCategory;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public EquipmentClass()
        {
            constring = sessionVar.Constring;
        }
        public EquipmentClass(string unit_category)
        {
            constring = sessionVar.Constring;
            this.unitCategory = unit_category;
        }
        public EquipmentClass(string unitCategory, string unitName, string availabilityStatus)
        {
            constring = sessionVar.Constring;
            this.unitCategory = unitCategory;
            this.unitName = unitName;
            this.availabilityStatus = availabilityStatus;
        }

        public void addUnit()
        {
            int IDNum;
            constring.Open();

            //Add Unit to Database
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [unit_name],[unit_id] FROM [Unit] ORDER BY [unit_id] DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                unitID = reader1.GetString(1);
                MessageBox.Show(unitID);
                IDNum = int.Parse(string.Join("", unitID.Where(Char.IsDigit))) + 1;
               
                ///
                /// unit code generator
                /// 
                string input = unitCategory;
                string acronym = "";
                char[] separators = new char[] { '-' };
                string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    acronym += word[0];
                }
                unitID = acronym + "U" + IDNum;
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
            String query = "INSERT INTO [Unit] VALUES('" + unitID + "','" + unitName + "','" 
                + unitCategory + "','" + availabilityStatus + "',0,0);";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Added New Unit");

            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void editUnit(string unitID)
        {

        }
        public void restoreUnit(string unitID)
        {

        }
        public void archiveUnit(string unitID)
        {

        }
        public void deleteUnit(string unitID)
        {

        }
        public DataTable displayUnit()
        {
            constring.Open();
            string sql = "SELECT * FROM [Unit] WHERE archived = 0 AND unit_category = '" + unitCategory + "'";
            DataTable equipment = new DataTable("Unit");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(equipment);
            constring.Close();

            return equipment;
        }
        private void logOperation(string activity)
        {
            if (activity.Equals("Added New Unit"))
            {
                constring.Open();
                int logID = 0;
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [unit_id] FROM ActivityLog ORDER BY [unit_id] DESC", constring);
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
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added unit "
                            + unitID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Equipment" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Unit successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
