using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace WashablesSystem.Classes
{
    internal class PaymentClass
    {
        private string transactionID;
        private string orderID;
        private string customerID;
        private string unitID;
        private string serviceID;
        private string serviceWeight;
        private DateTime transactionDate;
        private decimal downpayment = 0;
        private decimal balancedue = 0;
        private decimal totalAmount = 0;
        private decimal charge = 0;
        private string referenceNo = "";
        private string paymentMethod;
        private decimal paymentReceived = 0, change = 0;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public PaymentClass()
        {
            constring = sessionVar.Constring;
        }
        public PaymentClass(decimal downpayment, decimal balancedue, decimal totalAmount, decimal charge, string paymentMethod, string referenceNo, decimal paymentReceived, decimal change)
        {
            constring = sessionVar.Constring;
            transactionDate = DateTime.Now;
            this.downpayment = downpayment;
            this.balancedue = balancedue;
            this.totalAmount = totalAmount;
            this.charge = charge;
            this.paymentMethod = paymentMethod;
            this.referenceNo = referenceNo;
            this.paymentReceived = paymentReceived;
            this.change = change;
        }

        public void addBill(string orderID)
        {
            try
            {
                constring.Open();

                this.orderID = orderID;

                //Add Item to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [transaction_id] FROM [Billing] ORDER BY [transaction_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    transactionID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", transactionID.Where(Char.IsDigit))) + 1;
                    transactionID = "T" + num;
                }
                else
                {
                    transactionID = "T101";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                string query = @"INSERT INTO [Billing](transaction_id, user_id, order_id, total_amount, payment_status) VALUES(@transactionID, @userID, @orderID, @totalAmount, 'Pending')";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@transactionID", transactionID);
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.Parameters.AddWithValue("@userID", sessionVar.loggedIn);
                    cmd2.Parameters.AddWithValue("@totalAmount", computeAmount(orderID));

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Generated Bill");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void addFreeBill(string orderID)
        {
            try
            {
                constring.Open();

                this.orderID = orderID;

                //Add Item to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [transaction_id] FROM [Billing] ORDER BY [transaction_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    transactionID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", transactionID.Where(Char.IsDigit))) + 1;
                    transactionID = "T" + num;
                }
                else
                {
                    transactionID = "T101";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                string query = @"INSERT INTO [Billing](transaction_id, user_id, order_id, total_amount, transaction_date, payment_method, payment_status) VALUES(@transactionID, @userID, @orderID, @totalAmount, @transaction_date, 'Free', 'Paid')";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@transactionID", transactionID);
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.Parameters.AddWithValue("@userID", sessionVar.loggedIn);
                    cmd2.Parameters.AddWithValue("@totalAmount", "0.00");
                    cmd2.Parameters.AddWithValue("@transactionDate", DateTime.Now);

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Generated Bill");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                        constring.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable getBillingDetails(string transactionID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Billing] INNER JOIN [Order] ON [Billing].order_id = [Order].order_id " +
                "INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id " +
                "OR [Order].service_id2 = [Service].service_id " +
                "OR [Order].service_id3 = [Service].service_id " +
                "INNER JOIN [User] ON [Billing].user_id = [User].user_id WHERE transaction_id = '" + transactionID + "'";

            DataTable bill = new DataTable("bill");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(bill);
            constring.Close();

            return bill;
        }
        public DataTable getTransactNum(string orderID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Billing] INNER JOIN [Order] ON [Billing].order_id = [Order].order_id " +
                "INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id " +
                "OR [Order].service_id2 = [Service].service_id " +
                "OR [Order].service_id3 = [Service].service_id " +
                "INNER JOIN [User] ON [Billing].user_id = [User].user_id WHERE [Billing].[order_id] = '" + orderID + "'";

            DataTable bill = new DataTable("bill");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(bill);
            constring.Close();

            return bill;
        }
        public DataTable getBills()
        {
            constring.Open();
            string sql = "SELECT * FROM [Billing] INNER JOIN [Order] ON [Billing].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id WHERE payment_status = 'Pending' OR payment_status = 'Partially Paid'";

            DataTable payments = new DataTable("payments");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(payments);
            constring.Close();

            return payments;
        }
        public DataTable getHistory()
        {
            constring.Open();
            string sql = "SELECT * FROM [Billing] INNER JOIN [Order] ON [Billing].order_id = [Order].order_id " +
                "INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [User] ON [Billing].user_id = [User].user_id WHERE payment_status = 'Paid'";

            DataTable paid = new DataTable("paid");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(paid);
            constring.Close();

            return paid;
        }

        public decimal computeAmount(string orderID)
        {
            decimal firstAmount = 0;
            decimal secondAmount = 0;
            decimal thirdAmount = 0;

            //Computation for first service
            string sql = "SELECT * FROM [Order] INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_id = '" + orderID + "'";

            DataTable paid = new DataTable("paid");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(paid);

            foreach (DataRow row in paid.Rows)
            {
                firstAmount = decimal.Parse(row["service_rate"].ToString()) * decimal.Parse(row["weight"].ToString());
            }

            //Computation for second service
            sql = "SELECT * FROM [Order] INNER JOIN [Service] ON [Order].service_id2 = [Service].service_id WHERE order_id = '" + orderID + "'";

            paid = new DataTable("paid");
            da = new SqlDataAdapter(sql, constring);
            da.Fill(paid);

            foreach (DataRow row in paid.Rows)
            {
                secondAmount = decimal.Parse(row["service_rate"].ToString()) * decimal.Parse(row["weight2"].ToString());
            }


            //Computation for third service
            sql = "SELECT * FROM [Order] INNER JOIN [Service] ON [Order].service_id3 = [Service].service_id WHERE order_id = '" + orderID + "'";

            paid = new DataTable("paid");
            da = new SqlDataAdapter(sql, constring);
            da.Fill(paid);

            foreach (DataRow row in paid.Rows)
            {
                thirdAmount = decimal.Parse(row["service_rate"].ToString()) * decimal.Parse(row["weight3"].ToString());
            }

            totalAmount = firstAmount + secondAmount + thirdAmount;

            return totalAmount;

        }
        public decimal computeDownPaymentAmount(decimal totalAmount)
        {
            decimal downpaymentAmount = totalAmount * sessionVar.downPaymentRate;
            return downpaymentAmount;
        }
        public decimal computeBalanceAmount()
        {
            decimal balanceAmount = totalAmount * sessionVar.balanceDueRate;
            return balanceAmount;
        }
        public void payBillFullPayment(string transactNum)
        {
            constring.Open();

            this.transactionID = transactNum;

            //Query for editing
            String query = "UPDATE [Billing] SET user_id = '" + sessionVar.loggedIn + "', total_amount='" + totalAmount + "',payment_method='"
                + paymentMethod + "',additional_charge='" + charge + "',payment_status='Paid', transaction_date = '" + transactionDate +
                  "', downpayment = null, balance_due = null, reference_num = '" + referenceNo +
                  "', payment_received = '" + paymentReceived + "', change = '" + change + "' WHERE transaction_id='" + transactNum + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Paid Bill");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void payBillDown(string transactNum)
        {
            constring.Open();

            this.transactionID = transactNum;

            //Query for editing
            String query = "UPDATE [Billing] SET user_id = '" + sessionVar.loggedIn + "', total_amount='" + totalAmount + "',payment_method='"
                + paymentMethod + "',additional_charge='" + charge + "',payment_status='Partially Paid', downpayment = '" + downpayment +
                "', balance_due = '" + balancedue + "', reference_num = '" + referenceNo +
                  "', downpayment_received = '" + paymentReceived + "', downpayment_change = '" + change + "' WHERE transaction_id='" + transactNum + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Paid Down Payment");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void payBillDue(string transactNum)
        {
            constring.Open();

            this.transactionID = transactNum;

            //Query for editing
            String query = "UPDATE [Billing] SET user_id = '" + sessionVar.loggedIn + "', total_amount='" + totalAmount + "',payment_method2='"
                + paymentMethod + "',additional_charge='" + charge + "',payment_status='Paid', downpayment = '" + downpayment +
                "', balance_due = '" + balancedue + "', transaction_date = '" + transactionDate + "', reference_num2 = '" + referenceNo +
                  "', payment_received = '" + paymentReceived + "', change = '" + change + "' WHERE transaction_id='" + transactNum + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Paid Bill");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
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

            if (activity.Equals("Paid Bill"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','finished transaction "
                            + transactionID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Billing" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Bill paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Paid Down Payment"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','handled downpayment for transaction "
                            + transactionID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Billing" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Downpayment paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Generated Bill"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','generated bill "
                            + transactionID + " for " + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Billing" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                constring.Close();
            }
        }
    }
}
