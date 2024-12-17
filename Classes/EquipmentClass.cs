using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
            try
            {
                constring.Open();

                ///
                /// unit code generator
                /// 
                string input = unitCategory;
                string acronym = "";
                char[] separators = new char[] { '-', ' ' };
                string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    acronym += word[0];
                }

                //Add Unit to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [unit_name],[unit_id] FROM [Unit] WHERE [unit_category] = '" + unitCategory + "' ORDER BY [unit_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    unitID = reader1.GetString(1);
                    IDNum = int.Parse(string.Join("", unitID.Where(Char.IsDigit))) + 1;
                    unitID = acronym + "U" + IDNum;
                }
                else
                {
                    unitID = acronym + "U101";
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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public string viewUnit(string machineType)
        {
            constring.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [unit_name],[unit_id] FROM [Unit] WHERE [unit_category] = '" + machineType + "' ORDER BY [unit_id] DESC", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            string newUnitName = "";
            if (reader1.Read())
            {
                int latestUnitNum = int.Parse(string.Join("", reader1.GetString(0).Where(Char.IsDigit))) + 1;
                if (machineType.Equals("Washing Machine"))
                {
                    newUnitName = "Washer " + latestUnitNum;
                }
                else if (machineType.Equals("Dryer"))
                {
                    newUnitName = "Dryer " + latestUnitNum;
                }
                else if (machineType.Equals("Iron"))
                {
                    newUnitName = "Iron " + latestUnitNum;
                }
            }
            else
            {
            }
            reader1.Close();
            cmd.Dispose();
            constring.Close();
            return newUnitName;
        }
        public void editUnit(string unitID)
        {
            try
            {
                constring.Open();

                this.unitID = unitID;

                //Query for editing
                String query = "UPDATE [Unit] SET unit_name ='" + unitName + "',unit_category ='"
                    + unitCategory + "',availability_status ='" + availabilityStatus + "' WHERE unit_id='" + unitID + "';";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Edited Unit");
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
        public DataTable displaySelectedUnit(string unitID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Unit] WHERE unit_id = '" + unitID + "'";
            DataTable equipmentInfo = new DataTable("equipmentInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(equipmentInfo);
            constring.Close();

            return equipmentInfo;
        }
        public void restoreUnit(string unitID)
        {
            constring.Open();

            this.unitID = unitID;

            String query = "UPDATE [Unit] SET archived=0 WHERE unit_id='" + unitID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Restored Unit");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void archiveUnit(string unitID)
        {
            constring.Open();

            this.unitID = unitID;

            string checkQuery = "SELECT occupied FROM [Unit] WHERE unit_id = @UnitId";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, constring))
            {
                checkCommand.Parameters.AddWithValue("@UnitId", unitID);
                bool occupied = (bool)checkCommand.ExecuteScalar();

                if (occupied)
                {
                    MessageBox.Show("Unit cannot be archived because it is being used.", "Archive Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else
                {
                    //Query for archiving
                    string query = "UPDATE [Unit] SET archived=1 WHERE unit_id='" + unitID + "';";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Archived Unit");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }

        }
        public void deleteUnit(string unitID)
        {
            constring.Open();

            this.unitID = unitID;

            string checkQuery = "SELECT COUNT(*) FROM [Order] WHERE unit_id = @UnitId OR unit_id2 = @UnitId OR unit_id3 = @UnitId";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, constring))
            {
                checkCommand.Parameters.AddWithValue("@UnitId", unitID);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Unit cannot be deleted because it is in a record.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else
                {
                    string query = "DELETE FROM [Unit] WHERE unit_id='" + unitID + "';";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Deleted Unit");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }
        }
        public DataTable displayUnit(string unit_category)
        {
            this.unitCategory = unit_category;
            constring.Open();
            string sql = "SELECT * FROM [Unit] WHERE archived = 0 AND unit_category = '" + unitCategory + "'";
            DataTable equipment = new DataTable("Unit");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(equipment);
            constring.Close();

            return equipment;
        }
        public DataTable displayUnitArchive()
        {
            constring.Open();
            string sql = "SELECT * FROM [Unit] WHERE archived = 1";
            DataTable unitInfo = new DataTable("unitInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(unitInfo);
            constring.Close();

            return unitInfo;

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

            if (activity.Equals("Added New Unit"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added unit "
                            + unitID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Unit" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Unit successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited Unit"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited unit "
                            + unitID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Unit" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Archived Unit"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','archived unit "
                            + unitID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Unit" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Unit successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Restored Unit"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','restored unit "
                            + unitID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Unit" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Unit successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Deleted Unit"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','deleted unit "
                            + unitID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Unit" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Unit deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
