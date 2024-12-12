using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    internal class CustomerClass
    {
        private string customerID;
        private string customerName;
        private string customerPhone;
        private string customerEmail;
        private string customerAddress;
        private bool availabilityStatus;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public CustomerClass()
        {
            constring = sessionVar.Constring;
        }
        public CustomerClass(string customer_Name, string customer_Phone, string customer_Email, string customer_Address)
        {
            constring = sessionVar.Constring;
            this.customerName = customer_Name;
            this.customerPhone = customer_Phone;
            this.customerEmail = customer_Email;
            this.customerAddress = customer_Address;
        }
        public void addCustomer()
        {
            
            try
            {
                constring.Open();

                //Verify if Customername exists
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Customer] WHERE customer_id ='" + customerID + "'", constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    //Add User to Database
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 [customer_id] FROM [Customer] ORDER BY [customer_id] DESC", constring);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        customerID = reader1.GetString(0);
                        int IDNum = int.Parse(string.Join("", customerID.Where(Char.IsDigit))) + 1;
                        customerID = "C" + IDNum;
                    }
                    else
                    {
                        MessageBox.Show("NO DATA FOUND");
                    }
                    reader1.Close();
                    cmd.Dispose();

                    //Query for inserting
                    String query = "INSERT INTO [Customer] VALUES('" + customerID + "','" + customerName + "','"
                        + customerEmail + "','" + customerPhone + "','" + customerAddress + "',0)";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Added New Customer");

                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Customer name already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    constring.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public string addCustomer(bool directNew)
        {
            try
            {
                constring.Open();

                //Verify if Customername exists
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Customer] WHERE customer_id ='" + customerID + "'", constring);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    //Add User to Database
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 [customer_id] FROM [Customer] ORDER BY [customer_id] DESC", constring);
                    SqlDataReader reader1;
                    reader1 = cmd.ExecuteReader();
                    if (reader1.Read())
                    {
                        customerID = reader1.GetString(0);
                        int IDNum = int.Parse(string.Join("", customerID.Where(Char.IsDigit))) + 1;
                        customerID = "C" + IDNum;
                    }
                    else
                    {
                        MessageBox.Show("NO DATA FOUND");
                    }
                    reader1.Close();
                    cmd.Dispose();

                    //Query for inserting
                    String query = "INSERT INTO [Customer] VALUES('" + customerID + "','" + customerName + "','"
                        + customerEmail + "','" + customerPhone + "','" + customerAddress + "',0)";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Added New Customer");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                    return customerID;
                }
                else
                {
                    MessageBox.Show("Customer name already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    constring.Close();
                    return customerID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return customerID;
            }

        }
        public void editCustomer(string customerID)
        {
            try
            {
                constring.Open();

                this.customerID = customerID;

                //Query for editing
                String query = "UPDATE [Customer] SET customer_name='" + customerName + "',customer_email='"
                    + customerEmail + "',customer_phone='" + customerPhone + "',customer_address='" + customerAddress +
                      "' WHERE customer_id='" + customerID + "';";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Edited Customer");
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
        public DataTable displaySelectedCustomer(string customerID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Customer] WHERE customer_id = '" + customerID + "'";
            DataTable customerInfo = new DataTable("customerInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(customerInfo);
            constring.Close();

            return customerInfo;


        }
        public void restoreCustomer(string customerID)
        {
            constring.Open();

            this.customerID = customerID;

            String query = "UPDATE [Customer] SET archived=0 WHERE customer_id='" + customerID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Restored Customer");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void archiveCustomer(string customerID)
        {
            constring.Open();

            this.customerID = customerID;

            //Query for editing
            String query = "UPDATE [Customer] SET archived=1 WHERE customer_id='" + customerID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Archived Customer");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void deleteCustomer(string customerID)
        {
            constring.Open();

            this.customerID = customerID;

            string checkQuery = "SELECT COUNT(*) FROM [Order] WHERE customer_id = @CustomerId";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, constring))
            {
                checkCommand.Parameters.AddWithValue("@CustomerId", customerID);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Customer cannot be deleted because it is in a record.", "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    constring.Close();
                    return;
                }
                else
                {
                    string query = "DELETE FROM [Customer] WHERE customer_id='" + customerID + "';";

                    SqlCommand cmd2 = new SqlCommand(query, constring);
                    cmd2.CommandText = query;

                    //If successful, add to activity log
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Deleted Customer");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }

        }
        public DataTable displayCustomer()
        {
            constring.Open();
            string sql = "SELECT * FROM [Customer] WHERE archived = 0";

            DataTable customers = new DataTable("customers");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(customers);
            constring.Close();

            return customers;
        }
        public DataTable displayCustomerArchive()
        {
            constring.Open();
            string sql = "SELECT * FROM [Customer] WHERE archived = 1";
            DataTable customerInfo = new DataTable("customerInfo");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(customerInfo);
            constring.Close();

            return customerInfo;

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

            if (activity.Equals("Added New Customer"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added customer "
                            + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Customer successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited Customer"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited customer "
                            + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Archived Customer"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','archived customer "
                            + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Customer successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Restored Customer"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','restored customer "
                            + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Customer successfully restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Deleted Customer"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','deleted customer "
                            + customerID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Customers" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Customer deleted permanently!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}