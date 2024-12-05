using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WashablesSystem.Classes
{
    internal class UserClass
    {
        private string employeeID;
        private int IDNum;
        private string employeeName;
        private string employeeUsername;
        private string employeePass;
        private bool laundryPermission;
        private bool schedPermission;
        private bool sAndEPermission;
        private bool inventoryPermission;
        private bool customerPermission;
        private bool userPermission;
        private bool billingPermission;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public UserClass()
        {
            constring = sessionVar.Constring;
        }
        public UserClass(string employeeUsername, string employeePass)
        {
            constring = sessionVar.Constring;
            this.employeeUsername = employeeUsername;
            this.employeePass = employeePass;
        }
        public UserClass(string employeeName, string employeeUsername, string employeePass, bool laundryPermission, bool schedPermission, bool sAndEPermission, bool inventoryPermission, bool customerPermission, bool userPermission, bool billingPermission)
        {
            constring = sessionVar.Constring;
            this.employeeName = employeeName;
            this.employeeUsername = employeeUsername;
            this.employeePass = Cryptography.Encrypt(employeePass);
            this.laundryPermission = laundryPermission;
            this.schedPermission = schedPermission;
            this.sAndEPermission = sAndEPermission;
            this.inventoryPermission = inventoryPermission;
            this.customerPermission = customerPermission;
            this.userPermission = userPermission;
            this.billingPermission = billingPermission;
        }

        public void addUser()
        {
            try
            {
                constring.Open();

                //Verify if username exists
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE username ='" + employeeUsername + "'", constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    //Add User to Database
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 [user_id] FROM [User] ORDER BY [user_id] DESC", constring);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        employeeID = reader1.GetString(0);
                        IDNum = int.Parse(string.Join("", employeeID.Where(Char.IsDigit))) + 1;
                        employeeID = "U" + IDNum;
                    }
                    else
                    {
                        MessageBox.Show("NO DATA FOUND");
                    }
                    reader1.Close();
                    cmd.Dispose();

                    //Query for inserting
                    String query = "INSERT INTO [User] VALUES('" + employeeID + "','" + employeeName + "','"
                        + employeeUsername + "','" + employeePass + "','" + laundryPermission + "','"
                        + schedPermission + "','" + sAndEPermission + "','" + inventoryPermission + "','" + customerPermission
                        + "','" + userPermission + "','" + billingPermission + "',0);";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Added New User");

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    constring.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool loginUser()
        {
            constring.Open();

            //Verify if user has credentials
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE username='" + employeeUsername + "' AND archived = 0", constring);
            SqlDataReader sdr = cmd.ExecuteReader();
            string dbPassword = "";
            string userID = "";
            bool exists = false;
            if (sdr.Read())
            {
                userID = sdr.GetString(0);
                dbPassword = sdr.GetString(3);  //get the user password from db if the user name exists.  
                exists = true;
            }
            constring.Close();
            if (exists)  //if record exists in db, it will return true, otherwise it will return false  
            {
                if (Cryptography.Decrypt(dbPassword).Equals(employeePass))
                {
                    sessionVar.loggedIn = userID;
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            else  //showing the error message if user credential is wrong  
            {
                MessageBox.Show("Invalid username or password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public void editUser(string userID)
        {
            try
            {
                constring.Open();

                this.employeeID = userID;

                //Query for editing
                String query = "UPDATE [User] SET user_fullname='" + employeeName + "',username='"
                    + employeeUsername + "',user_password='" + employeePass + "',laundry_access='" + laundryPermission
                    + "',schedule_access='" + schedPermission + "',sAndE_access='" + sAndEPermission
                    + "',inventory_access='" + inventoryPermission + "',customer_access='" + customerPermission
                    + "',user_access='" + userPermission + "',billing_access='" + billingPermission + "' WHERE user_id='" + employeeID + "';";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Edited User");
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
        public DataTable displaySelectedUser(string userID)
        {
            constring.Open();
            string sql = "SELECT * FROM [User] WHERE user_id = '" + userID + "'";
            DataTable userInfo = new DataTable("userInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(userInfo);
            constring.Close();

            return userInfo;
        }
        public void restoreUser(string userID)
        {
            constring.Open();

            this.employeeID = userID;

            String query = "UPDATE [User] SET archived=0 WHERE user_id='" + employeeID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Restored User");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void archiveUser(string userID)
        {
            constring.Open();

            this.employeeID = userID;

            if (!userID.Equals("U101"))
            {
                //Query for editing
                String query = "UPDATE [User] SET archived=1 WHERE user_id='" + employeeID + "';";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Archived User");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("Administrator cannot be deleted!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                constring.Close();
            }
        }
        public void deleteUser(string userID)
        {
            constring.Open();

            this.employeeID = userID;

            string checkQuery = "SELECT(SELECT COUNT(*) FROM [Billing] WHERE user_id = @UserId) + (SELECT COUNT(*) FROM [ActivityLog] WHERE user_id = @UserId) " +
                "+ (SELECT COUNT(*) FROM [Complaints] WHERE user_id = @UserId) AS total";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, constring))
            {
                checkCommand.Parameters.AddWithValue("@UserId", userID);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("User cannot be deleted because it is referenced elsewhere.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else if (sessionVar.loggedIn.Equals(userID))
                {
                    MessageBox.Show("User cannot be deleted because it is currently in use.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else
                {
                    string query = "DELETE FROM [User] WHERE user_id='" + employeeID + "';";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Deleted User");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }
        }
        public DataTable displayUser()
        {
            constring.Open();
            string sql = "SELECT * FROM [User] WHERE archived = 0";
            DataTable users = new DataTable("users");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(users);
            constring.Close();

            return users;

        }
        public DataTable displayUserArchive()
        {
            constring.Open();
            string sql = "SELECT * FROM [User] WHERE archived = 1";
            DataTable usersArchive = new DataTable("usersArchive");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(usersArchive);
            constring.Close();

            return usersArchive;

        }
        public DataTable displayLog()
        {
            constring.Open();
            string sql = "SELECT * FROM [ActivityLog] INNER JOIN [User] ON [ActivityLog].user_id = [User].user_id ORDER BY [log_id] DESC";
            DataTable log = new DataTable("log");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(log);
            constring.Close();

            return log;
        }
        public DataTable displayLogFilter(DateTime filterBy)
        {
            constring.Open();
            string sql = "SELECT * FROM [ActivityLog] INNER JOIN [User] ON [ActivityLog].user_id = [User].user_id WHERE activity_date >= '" +
                filterBy.Date + "' AND activity_date < '" + filterBy.AddDays(1) + "' ORDER BY [log_id] DESC";
            DataTable log = new DataTable("log");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(log);
            constring.Close();

            return log;
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

            if (activity.Equals("Added New User"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added user "
                            + employeeID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited User"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited user "
                            + employeeID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Archived User"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','archived user "
                            + employeeID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Restored User"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','restored user "
                            + employeeID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Deleted User"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','deleted user "
                            + employeeID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
