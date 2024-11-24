using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private bool dashboardPermission;
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
        public UserClass(string employeeName, string employeeUsername, string employeePass, bool dashboardPermission, bool laundryPermission, bool schedPermission, bool sAndEPermission, bool inventoryPermission, bool customerPermission, bool userPermission, bool billingPermission)
        {
            constring = sessionVar.Constring;
            this.employeeName = employeeName;
            this.employeeUsername = employeeUsername;
            this.employeePass = employeePass;
            this.dashboardPermission = dashboardPermission;
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

                String query = "INSERT INTO [User] VALUES('" + employeeID + "','" + employeeName + "','"
                    + employeeUsername + "','" + Cryptography.Encrypt(employeePass) + "','" + dashboardPermission + "','" + laundryPermission + "','"
                    + schedPermission + "','" + sAndEPermission + "','" + inventoryPermission + "','" + customerPermission
                    + "','" + userPermission + "','" + billingPermission + "',1);";

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
        public bool loginUser()
        {
            constring.Open();

            //Verify if user has credentials
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE username ='" + employeeUsername + "' AND user_password ='" + employeePass + "' AND archived = 0", constring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT [user_id] FROM [User] WHERE username ='" + employeeUsername + "' AND archived = 0", constring);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                sessionVar.loggedIn = employeeUsername.ToString();
                constring.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                constring.Close();
                return false;
            }
        }
        public void editUser(string userID)
        {

        }
        public void restoreUser(string userID)
        {

        }
        public void deleteUser(string userID)
        {

        }
        public ArrayList displayUser()
        {
            return new ArrayList();
        }
        private void logOperation(string activity)
        {
            if (activity.Equals("Added New User"))
            {
                constring.Open();
                string queryAct = "INSERT INTO ActivityLog VALUES('" + sessionVar.loggedIn + "','" + "','added user "
                            + employeeID + "'," + DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss"))  + ",'Users" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
