﻿using System;
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
    internal class ComplaintsClass
    {
        private string complaintID;
        private string employeeID;
        private string customerID;
        private string complaintIssue;
        private DateTime complaintDate;
        private DateTime resolvedDate;
        private string status;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public ComplaintsClass()
        {
            constring = sessionVar.Constring;
        }
        public ComplaintsClass(string customer_id, string complaint_issue, DateTime complaint_date)
        {
            constring = sessionVar.Constring;
            this.customerID = customer_id;
            this.complaintIssue = complaint_issue;
            this.complaintDate = complaint_date;
        }

        public void addComplaint()
        {
            try
            {
                constring.Open();
                //Add User to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [complaint_id] FROM [Complaints] ORDER BY [complaint_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    complaintID = reader1.GetString(0);
                    int IDNum = int.Parse(string.Join("", complaintID.Where(Char.IsDigit))) + 1;
                    complaintID = "CC" + IDNum;
                }
                else
                {
                    complaintID = "CC101";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                String query = "INSERT INTO [Complaints] VALUES('" + complaintID + "','" + sessionVar.loggedIn + "','"
                    + customerID + "','" + complaintIssue + "','" + complaintDate + "','','0')";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Added New Complaint");

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
        public void resolveComplaint(string complaintID, string problem)
        {
            constring.Open();

            this.complaintID = complaintID;

            //Query for editing
            String query = "UPDATE [Complaints] SET resolved_status='1' WHERE complaint_id='" + complaintID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Resolved Complaint");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public DataTable missingItem(string order_date)
        {
            constring.Open();
            DataTable missingItemInfo = new DataTable("missingItemInfo");
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id INNER JOIN [Unit] ON [Order].unit_id = [Unit].unit_id WHERE CAST(scheduled_time AS DATE) = @order_date";

            SqlCommand cmd = new SqlCommand(sql, constring);
            cmd.Parameters.AddWithValue("@order_date", order_date);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(missingItemInfo);
            constring.Close();

            return missingItemInfo;
        }
        public DataTable displayComplaint()
        {
            constring.Open();
            string sql = "SELECT * FROM [Complaints] INNER JOIN [Customer] ON [Complaints].customer_id = [Customer].customer_id INNER JOIN [User] ON [Complaints].user_id = [User].user_id";

            DataTable complaints = new DataTable("complaints");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(complaints);
            constring.Close();

            return complaints;
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

            if (activity.Equals("Added New Complaint"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added complaint "
                            + complaintID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Complaint successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Resolved Complaint"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','marked complaint "
                            + complaintID + " as resolved','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Complaint successfully marked as resolved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
