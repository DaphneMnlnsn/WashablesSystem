using Microsoft.ReportingServices.Diagnostics.Internal;
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
    internal class ScheduleClass
    {
        private string batchID, orderID, customerID;
        private string serviceCategory = "";
        private bool priority;
        private string serviceID1, serviceID2, serviceID3;
        private string unitID1, unitID2, unitID3;
        private decimal weight1, weight2, weight3;
        private string item1, item2, item3;
        private decimal itemQuan1, itemQuan2, itemQuan3;
        private TimeSpan washTime, dryTime, ironTime;
        private DateTime startTime, endTime, timeScheduled, pickupDate, dateFinished;
        private string status;

        SessionVariables sessionVar = new SessionVariables();
        InventoryClass inventoryClass = new InventoryClass();
        private SqlConnection constring;

        public ScheduleClass()
        {
            constring = sessionVar.Constring;
        }
        public ScheduleClass(string serviceCategory, string service_id1, string service_id2, string service_id3,
            string service1_weight, string service2_weight, string service3_weight, string customer_id,
            DateTime time_scheduled, DateTime pickup, string itemID1, string itemID2,
            string itemID3, string quan1, string quan2, string quan3, TimeSpan washTime, TimeSpan dryTime, TimeSpan ironTime)
        {
            constring = sessionVar.Constring;
            this.serviceCategory = serviceCategory;
            this.serviceID1 = service_id1;
            if (service_id2.Equals("") || service_id2.Equals(null))
            {
                this.serviceID2 = null;
            }
            else
            {
                this.serviceID2 = service_id2;
            }
            if (service_id3.Equals("") || service_id3.Equals(null))
            {
                this.serviceID3 = null;
            }
            else
            {
                this.serviceID3 = service_id3;
            }
            this.customerID = customer_id;
            this.weight1 = decimal.Parse(service1_weight);
            this.weight2 = decimal.Parse(service2_weight);
            this.weight3 = decimal.Parse(service3_weight);
            this.timeScheduled = time_scheduled;

            this.pickupDate = pickup;
            this.item1 = itemID1;
            if (itemID2.Equals("placeholder"))
            {
                this.item2 = null;
            }
            else
            {
                this.item2 = itemID2;
            }
            if (itemID3.Equals("placeholder"))
            {
                this.item3 = null;
            }
            else
            {
                this.item3 = itemID2;
            }

            this.itemQuan1 = decimal.Parse(quan1);
            this.itemQuan2 = decimal.Parse(quan2);
            this.itemQuan3 = decimal.Parse(quan3);

            this.washTime = washTime;
            this.dryTime = dryTime;
            this.ironTime = ironTime;

            if (serviceCategory.Equals("Wash-Dry-Fold") || serviceCategory.Equals("Wash-Dry-Press"))
            {
                status = "Pending Wash";
            }
            else if (serviceCategory.Equals("Dry Only"))
            {
                status = "Pending Dry";
            }
        }
        public void addLaundry()
        {
            try
            {
                constring.Open();

                //Add Item to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [order_id] FROM [Order] ORDER BY [order_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    orderID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", orderID.Where(Char.IsDigit))) + 1;
                    orderID = "OR" + num;
                }
                else
                {
                    orderID = "OR1";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                string query = @"INSERT INTO [Order] VALUES(@orderID, @customerID, @serviceID1, @serviceID2, @serviceID3, null, null, null," +
                    "@washTime, @dryTime, @ironTime, @weight1, @weight2, @weight3, @status, @timeScheduled, null, null, null, @pickupDate, @item1, @item2, @item3,"
                    + "@itemQuan1, @itemQuan2, @itemQuan3, null)";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.Parameters.AddWithValue("@customerID", customerID);
                    cmd2.Parameters.AddWithValue("@serviceId1", serviceID1);
                    cmd2.Parameters.AddWithValue("@serviceId2", serviceID2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@serviceId3", serviceID3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@washTime", washTime.ToString());
                    cmd2.Parameters.AddWithValue("@dryTime", dryTime.ToString());
                    cmd2.Parameters.AddWithValue("@ironTime", ironTime.ToString());
                    cmd2.Parameters.AddWithValue("@weight1", weight1);
                    cmd2.Parameters.AddWithValue("@weight2", weight2);
                    cmd2.Parameters.AddWithValue("@weight3", weight3);
                    cmd2.Parameters.AddWithValue("@status", status);
                    cmd2.Parameters.AddWithValue("@timeScheduled", timeScheduled);
                    cmd2.Parameters.AddWithValue("@pickupDate", pickupDate);
                    cmd2.Parameters.AddWithValue("@item1", item1);
                    cmd2.Parameters.AddWithValue("@item2", item2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@item3", item3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@itemQuan1", itemQuan1);
                    cmd2.Parameters.AddWithValue("@itemQuan2", itemQuan2);
                    cmd2.Parameters.AddWithValue("@itemQuan3", itemQuan3);

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        PaymentClass paymentClass = new PaymentClass();
                        paymentClass.addBill(orderID);
                        BatchClass batchClass = new BatchClass(orderID, status);
                        batchClass.batchLaundry();
                        logOperation("Added New Laundry");
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
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void addLaundry(string specificUnit, string machineType)
        {
            try
            {
                constring.Open();

                //Add Item to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [order_id] FROM [Order] ORDER BY [order_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    orderID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", orderID.Where(Char.IsDigit))) + 1;
                    orderID = "OR" + num;
                }
                else
                {
                    orderID = "OR1001";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                string query = @"INSERT INTO [Order] VALUES(@orderID, @customerID, @serviceID1, @serviceID2, @serviceID3, null, null, null," +
                    "@washTime, @dryTime, @ironTime, @weight1, @weight2, @weight3, @status, @timeScheduled, null, null, null, @pickupDate, @item1, @item2, @item3,"
                    + "@itemQuan1, @itemQuan2, @itemQuan3, null)";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.Parameters.AddWithValue("@customerID", customerID);
                    cmd2.Parameters.AddWithValue("@serviceId1", serviceID1);
                    cmd2.Parameters.AddWithValue("@serviceId2", serviceID2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@serviceId3", serviceID3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@washTime", washTime.ToString());
                    cmd2.Parameters.AddWithValue("@dryTime", dryTime.ToString());
                    cmd2.Parameters.AddWithValue("@ironTime", ironTime.ToString());
                    cmd2.Parameters.AddWithValue("@weight1", weight1);
                    cmd2.Parameters.AddWithValue("@weight2", weight2);
                    cmd2.Parameters.AddWithValue("@weight3", weight3);
                    if (serviceCategory.Equals("Wash-Dry-Fold") || serviceCategory.Equals("Wash-Dry-Press"))
                    {
                        cmd2.Parameters.AddWithValue("@status", "Wash In-Progress");
                    }
                    else
                    {
                        cmd2.Parameters.AddWithValue("@status", "Dry In-Progress");
                    }
                    cmd2.Parameters.AddWithValue("@timeScheduled", timeScheduled);
                    cmd2.Parameters.AddWithValue("@pickupDate", pickupDate);
                    cmd2.Parameters.AddWithValue("@item1", item1);
                    cmd2.Parameters.AddWithValue("@item2", item2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@item3", item3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@itemQuan1", itemQuan1);
                    cmd2.Parameters.AddWithValue("@itemQuan2", itemQuan2);
                    cmd2.Parameters.AddWithValue("@itemQuan3", itemQuan3);

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        cmd2.Dispose();
                        constring.Close();
                        PaymentClass paymentClass = new PaymentClass();

                        paymentClass.addBill(orderID);
                        BatchClass batchClass = new BatchClass(orderID, status);
                        batchClass.batchLaundry();
                        logOperation("Added New Laundry");

                        constring.Open();
                        string batchToStart = "";
                        SqlCommand cmd3 = new SqlCommand("SELECT TOP 1 [batch_id] FROM [OrderBatch] WHERE [order_id] = '" + orderID + "' ORDER BY [batch_id] ASC", constring);
                        SqlDataReader reader2;
                        reader2 = cmd3.ExecuteReader();
                        if (reader2.Read())
                        {
                            batchToStart = reader2.GetString(0);
                        }
                        else
                        {

                        }
                        reader2.Close();
                        cmd3.Dispose();
                        constring.Close();
                        startSchedule(batchToStart, specificUnit);

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
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void addFreeWash()
        {
            try
            {
                constring.Open();

                //Add Item to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [order_id] FROM [Order] ORDER BY [order_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    orderID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", orderID.Where(Char.IsDigit))) + 1;
                    orderID = "OR" + num;
                }
                else
                {
                    orderID = "OR1";
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                string query = @"INSERT INTO [Order] VALUES(@orderID, @customerID, @serviceID1, @serviceID2, @serviceID3, null, null, null," +
                    "@washTime, @dryTime, @ironTime, @weight1, @weight2, @weight3, @status, @timeScheduled, null, null, null, @pickupDate, @item1, @item2, @item3,"
                    + "@itemQuan1, @itemQuan2, @itemQuan3, null)";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@orderID", orderID);
                    cmd2.Parameters.AddWithValue("@customerID", customerID);
                    cmd2.Parameters.AddWithValue("@serviceId1", serviceID1);
                    cmd2.Parameters.AddWithValue("@serviceId2", serviceID2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@serviceId3", serviceID3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@washTime", washTime.ToString());
                    cmd2.Parameters.AddWithValue("@dryTime", dryTime.ToString());
                    cmd2.Parameters.AddWithValue("@ironTime", ironTime.ToString());
                    cmd2.Parameters.AddWithValue("@weight1", weight1);
                    cmd2.Parameters.AddWithValue("@weight2", weight2);
                    cmd2.Parameters.AddWithValue("@weight3", weight3);
                    cmd2.Parameters.AddWithValue("@status", status);
                    cmd2.Parameters.AddWithValue("@timeScheduled", timeScheduled);
                    cmd2.Parameters.AddWithValue("@pickupDate", pickupDate);
                    cmd2.Parameters.AddWithValue("@item1", item1);
                    cmd2.Parameters.AddWithValue("@item2", item2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@item3", item3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@itemQuan1", itemQuan1);
                    cmd2.Parameters.AddWithValue("@itemQuan2", itemQuan2);
                    cmd2.Parameters.AddWithValue("@itemQuan3", itemQuan3);

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        PaymentClass paymentClass = new PaymentClass();
                        paymentClass.addFreeBill(orderID);
                        BatchClass batchClass = new BatchClass(orderID, status);
                        batchClass.batchLaundry();
                        logOperation("Added Free Laundry");
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
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void editSchedule(string orderID)
        {
            try
            {
                constring.Open();

                this.orderID = orderID;

                string query = @"UPDATE [Order] SET pickup_date = @pickupDate, item_id = @item1, item_id2 = @item2, item_id3 = @item3,
                            item1_quantity = @itemQuan1, item2_quantity = @itemQuan2, item3_quantity = @itemQuan3, wash_time = @washTime,
                            dry_time = @dryTime, iron_time = @ironTime WHERE order_id = '" + orderID + "'";

                using (SqlCommand cmd2 = new SqlCommand(query, constring))
                {
                    // Add parameters
                    cmd2.Parameters.AddWithValue("@washTime", washTime.ToString());
                    cmd2.Parameters.AddWithValue("@dryTime", dryTime.ToString());
                    cmd2.Parameters.AddWithValue("@ironTime", ironTime.ToString());
                    cmd2.Parameters.AddWithValue("@pickupDate", pickupDate);
                    cmd2.Parameters.AddWithValue("@item1", item1);
                    cmd2.Parameters.AddWithValue("@item2", item2 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@item3", item3 ?? (object)DBNull.Value);
                    cmd2.Parameters.AddWithValue("@itemQuan1", itemQuan1);
                    cmd2.Parameters.AddWithValue("@itemQuan2", itemQuan2);
                    cmd2.Parameters.AddWithValue("@itemQuan3", itemQuan3);

                    //If successful, add to activity log and generate bill
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        constring.Close();
                        logOperation("Edited Laundry");
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
                MessageBox.Show("Invalid input! Error: " + ex, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void markPickUp(string orderID)
        {
            constring.Open();

            this.orderID = orderID;

            //Query for editing
            string query = "UPDATE [Order] SET order_status='Picked-Up', pickup_date='"
                + DateTime.Now + "' WHERE order_id ='" + orderID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Marked Laundry Picked-Up");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void pauseSchedule(string orderID)
        {

        }
        public void playSchedule(string orderID)
        {

        }
        public void startSchedule(string batchID, string unitID)
        {
            constring.Open();

            string sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id WHERE batch_id = '" + batchID + "'";
            DataTable order = new DataTable("order");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(order);

            this.batchID = batchID;
            DateTime start_time = DateTime.Now;
            TimeSpan washTime = TimeSpan.Zero;
            TimeSpan dryTime = TimeSpan.Zero;
            TimeSpan ironTime = TimeSpan.Zero;
            string serviceCategory = "";
            string query = "";
            string query2 = "";
            string status = "";
            string itemID1 = "", itemID2 = "", itemID3 = "";
            decimal quantity1 = 0, quantity2 = 0, quantity3 = 0;
            foreach (DataRow row in order.Rows)
            {
                this.orderID = row["order_id"].ToString();
                serviceCategory = row["service_category"].ToString();
                status = row["status"].ToString();
                washTime = TimeSpan.Parse(row["wash_time"].ToString());
                dryTime = TimeSpan.Parse(row["dry_time"].ToString());
                ironTime = TimeSpan.Parse(row["iron_time"].ToString());
                itemID1 = row["item_id"].ToString();
                itemID2 = row["item_id2"].ToString();
                itemID3 = row["item_id3"].ToString();
                quantity1 = decimal.Parse(row["item1_quantity"].ToString());
                quantity2 = decimal.Parse(row["item2_quantity"].ToString());
                quantity3 = decimal.Parse(row["item3_quantity"].ToString());
            }
            //Query for starting
            if (serviceCategory.Equals("Wash-Dry-Fold") && status.Equals("Pending Wash"))
            {
                query = "UPDATE [OrderBatch] SET status='Wash In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(washTime)
                    + "', unit_id ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
                inventoryClass.subtractItem(itemID1, itemID2, itemID3, quantity1, quantity2, quantity3);
            }
            else if (serviceCategory.Equals("Wash-Dry-Fold") && status.Equals("Pending Dry"))
            {
                query = "UPDATE [OrderBatch] SET status='Dry In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(dryTime)
                    + "', unit_id2 ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Pending Wash"))
            {
                query = "UPDATE [OrderBatch] SET status='Wash In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(washTime)
                    + "', unit_id ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
                inventoryClass.subtractItem(itemID1, itemID2, itemID3, quantity1, quantity2, quantity3);
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Pending Dry"))
            {
                query = "UPDATE [OrderBatch] SET status='Dry In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(dryTime)
                    + "', unit_id2 ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Pending Press"))
            {
                query = "UPDATE [OrderBatch] SET status='Press In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(ironTime)
                    + "', unit_id3 ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
            }
            else if (serviceCategory.Equals("Dry Only") && status.Equals("Pending Dry"))
            {
                query = "UPDATE [OrderBatch] SET status='Dry In-Progress',start_time = '" +
                    start_time + "', end_time='" + start_time.Add(dryTime)
                    + "', unit_id2 ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=1 WHERE unit_id='" + unitID + "';";
                inventoryClass.subtractItem(itemID1, itemID2, itemID3, quantity1, quantity2, quantity3);
            }

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            SqlCommand cmd3 = new SqlCommand(query2, constring);
            cmd3.CommandText = query2;
            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1 && cmd3.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Started Laundry");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public void finishSchedule(string batchID)
        {
            constring.Open();

            string sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                            "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id WHERE batch_id = '" + batchID + "'";
            DataTable order = new DataTable("order");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(order);

            this.batchID = batchID;
            TimeSpan total_duration = TimeSpan.Zero;
            string serviceCategory = "";
            string query = "", query2 = "";
            string status = "";
            string unitID = "", unitID2 = "", unitID3 = "";
            foreach (DataRow row in order.Rows)
            {
                this.orderID = row["order_id"].ToString();
                total_duration = total_duration.Add(DateTime.Now - DateTime.Parse(row["start_time"].ToString()));
                serviceCategory = row["service_category"].ToString();
                status = row["status"].ToString();
                unitID = row["unit_id"].ToString();
                unitID2 = row["unit_id2"].ToString();
                unitID3 = row["unit_id3"].ToString();
            }
            //Query for finished
            if (serviceCategory.Equals("Wash-Dry-Fold") && status.Equals("Wash In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Pending Dry',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Fold") && status.Equals("Dry In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Finished',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id2 ='" + unitID2 + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID2 + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Wash In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Pending Dry',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id ='" + unitID + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Dry In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Pending Press',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id2 ='" + unitID2 + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID2 + "';";
            }
            else if (serviceCategory.Equals("Wash-Dry-Press") && status.Equals("Press In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Finished',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id3 ='" + unitID3 + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID3 + "';";
            }
            else if (serviceCategory.Equals("Dry Only") && status.Equals("Dry In-Progress"))
            {
                query = "UPDATE [OrderBatch] SET status='Finished',finished_on='"
                + DateTime.Now + "',total_duration='" + total_duration + "', unit_id2 ='" + unitID2 + "' WHERE batch_id='" + batchID + "';";
                query2 = "UPDATE [Unit] SET occupied=0 WHERE unit_id='" + unitID2 + "';";
            }

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            SqlCommand cmd3 = new SqlCommand(query2, constring);
            cmd3.CommandText = query2;
            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1 && cmd3.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Finished Laundry");
                checkIfFinished();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }

        }
        private void checkIfFinished()
        {
            constring.Open();

            //Query for checking    
            string query = "SELECT * FROM OrderBatch WHERE order_id ='" + orderID + "' AND [status] != 'Finished';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            SqlDataReader reader1 = cmd2.ExecuteReader();
            if (!reader1.Read())
            {
                string query2 = "UPDATE [Order] SET order_status='Finished', finished_on ='" + DateTime.Now + "' WHERE order_id ='" + orderID + "';";
                reader1.Close();
                cmd2.Dispose();

                SqlCommand cmd = new SqlCommand(query2, constring);
                cmd.CommandText = query2;

                //If successful, add to activity log
                if (cmd.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Finished Laundry");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                    constring.Close();
                }
            }
            else
            {
                constring.Close();
            }
        }
        public void cancelSchedule(string orderID)
        {
            constring.Open();

            this.orderID = orderID;

            //Query for cancelling
            string query = "UPDATE [Order] SET order_status='Cancelled' WHERE order_id ='" + orderID + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                constring.Close();
                logOperation("Cancelled Laundry");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }
        public DataTable displaySelectedEdit(string orderID)
        {
            constring.Open();
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id INNER JOIN [Service] ON [Order].service_id = [Service].service_id " +
                "WHERE order_id ='" + orderID + "'";
            DataTable order = new DataTable("order");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(order);
            constring.Close();

            return order;
        }
        public DataTable displaySelectedOrder(string batchID)
        {
            constring.Open();
            string sql = "SELECT * FROM [OrderBatch] INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id " +
                "WHERE batch_id ='" + batchID + "'";
            DataTable order = new DataTable("order");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(order);
            constring.Close();

            return order;
        }
        public bool checkIfPending(string orderID)
        {
            constring.Open();

            this.orderID = orderID;

            bool allPending;
            //Query for checking    
            string query = "SELECT * FROM OrderBatch WHERE order_id ='" + orderID + "' AND [status] NOT LIKE 'Pending%'";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;
            SqlDataReader reader1 = cmd2.ExecuteReader();
            if (!reader1.Read())
            {
                allPending = true;
                constring.Close();
            }
            else
            {
                allPending = false;
                constring.Close();
            }
            return allPending;
        }
        public DataTable displayInProgress(string status)
        {
            constring.Open();
            string sql = "";
            if (status.Equals("Wash In-Progress"))
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id INNER JOIN [OrderBatch] ON [OrderBatch].order_id = [Order].order_id " +
                "WHERE [status] = 'Wash In-Progress'";
            }
            else if (status.Equals("Dry In-Progress"))
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id INNER JOIN [OrderBatch] ON [OrderBatch].order_id = [Order].order_id " +
                "WHERE [status] = 'Dry In-Progress'";
            }
            else if (status.Equals("Press In-Progress"))
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id INNER JOIN [OrderBatch] ON [OrderBatch].order_id = [Order].order_id " +
                "WHERE [status] = 'Press In-Progress'";
            }
            DataTable inProgress = new DataTable("inProgress");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(inProgress);
            constring.Close();

            return inProgress;
        }
        public DataTable displayInProgressBatches(string status)
        {
            constring.Open();
            string sql = "";
            if (status.Equals("Wash In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Unit] ON [OrderBatch].unit_id = [Unit].unit_id " +
                "WHERE status = 'Wash In-Progress'";
            }
            else if (status.Equals("Dry In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Unit] ON [OrderBatch].unit_id2 = [Unit].unit_id " +
                "WHERE status = 'Dry In-Progress'";
            }
            else if (status.Equals("Press In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Unit] ON [OrderBatch].unit_id3 = [Unit].unit_id " +
                "WHERE status = 'Press In-Progress'";
            }
            DataTable inProgress = new DataTable("inProgress");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(inProgress);

            constring.Close();

            return inProgress;
        }
        public DataTable displayBatches(string orderID, string status)
        {
            constring.Open();
            string sql = "";
            if (status.Equals("Wash In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Unit] ON [OrderBatch].unit_id = [Unit].unit_id " +
                "WHERE status LIKE 'Wash In-Progress' AND order_id = '" + orderID + "'";
            }
            else if (status.Equals("Dry In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Unit] ON [OrderBatch].unit_id2 = [Unit].unit_id " +
                    "WHERE status LIKE 'Dry In-Progress' AND order_id = '" + orderID + "'";
            }
            else if (status.Equals("Press In-Progress"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Unit] ON [OrderBatch].unit_id3 = [Unit].unit_id " +
                    "WHERE status LIKE 'Press In-Progress' AND order_id = '" + orderID + "'";
            }
            else if (status.Equals("Pending"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "WHERE status LIKE 'Pending%' AND order_id = '" + orderID + "'";
            }
            else if (status.Equals("Finished"))
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Unit] ON [OrderBatch].unit_id = [Unit].unit_id " +
                    "WHERE status = 'Finished' AND order_id = '" + orderID + "'";
            }
            DataTable batch = new DataTable("batch");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(batch);
            constring.Close();

            return batch;
        }
        public DataTable displayPendingBatches()
        {
            constring.Open();
            string sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                    "WHERE status LIKE 'Pending%'";
            DataTable pending = new DataTable("pending");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(pending);
            constring.Close();

            return pending;
        }
        public DataTable displayPendingBatchesSort(int sortBy)
        {
            constring.Open();

            string sql = "";
            if (sortBy == 0)
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                    "WHERE status LIKE 'Pending%' ORDER BY [Order].scheduled_time ASC";
            }
            else if (sortBy == 1)
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                    "WHERE status LIKE 'Pending%' ORDER BY [Order].scheduled_time DESC";
            }
            else if (sortBy == 2)
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                    "WHERE status LIKE 'Pending%' ORDER BY [Order].pickup_date ASC";
            }
            else if (sortBy == 3)
            {
                sql = "SELECT * FROM [OrderBatch] INNER JOIN [Service] ON [OrderBatch].service_id = [Service].service_id " +
                    "INNER JOIN [Order] ON [OrderBatch].order_id = [Order].order_id INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                    "WHERE status LIKE 'Pending%' ORDER BY [Order].pickup_date DESC";
            }
            DataTable pending = new DataTable("pending");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(pending);
            constring.Close();

            return pending;
        }
        public DataTable displayPending()
        {
            constring.Open();
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_status LIKE 'Pending%'";
            DataTable pending = new DataTable("pending");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(pending);
            constring.Close();

            return pending;
        }
        public DataTable displayPendingSort(int sortBy)
        {
            constring.Open();
            string sql = "";

            if (sortBy == 0)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_status LIKE 'Pending%' ORDER BY [Order].scheduled_time ASC";
            }
            else if (sortBy == 1)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_status LIKE 'Pending%' ORDER BY [Order].scheduled_time DESC";
            }
            else if (sortBy == 2)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_status LIKE 'Pending%' ORDER BY [Order].pickup_date ASC";
            }
            else if (sortBy == 3)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id WHERE order_status LIKE 'Pending%' ORDER BY [Order].pickup_date DESC";
            }

            DataTable pending = new DataTable("pending");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(pending);
            constring.Close();

            return pending;
        }
        public DataTable displayFinished()
        {
            constring.Open();
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id WHERE order_status = 'Finished'";
            DataTable finished = new DataTable("finished");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(finished);
            constring.Close();

            return finished;
        }
        public DataTable displayFinishedSort(int sortBy)
        {
            constring.Open();

            string sql = "";
            if (sortBy == 0)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id " +
                "WHERE order_status = 'Finished' ORDER BY [Order].scheduled_time ASC";
            }
            else if (sortBy == 1)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id " +
                "WHERE order_status = 'Finished' ORDER BY [Order].scheduled_time DESC";
            }
            else if (sortBy == 2)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id " +
                "WHERE order_status = 'Finished' ORDER BY [Order].pickup_date ASC";
            }
            else if (sortBy == 3)
            {
                sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id " +
                "WHERE order_status = 'Finished' ORDER BY [Order].pickup_date DESC";
            }

            DataTable finished = new DataTable("finished");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(finished);
            constring.Close();

            return finished;
        }
        public TimeSpan computeTotalDuration()
        {
            constring.Open();
            string sql = "SELECT CAST(DATEADD(SECOND, SUM(DATEDIFF(SECOND, 0, total_duration)), 0) AS TIME) AS totalDuration " +
                "FROM OrderBatch WHERE order_id = '" + orderID + "'";
            SqlCommand cmd = new SqlCommand(sql, constring);
            object result = cmd.ExecuteScalar();
            constring.Close();
            if (result != DBNull.Value)
            {
                int totalSeconds = Convert.ToInt32(result);
                return TimeSpan.FromSeconds(totalSeconds);
            }
            else
            {
                return TimeSpan.Zero;
            }

        }
        public DataTable displayPickedUp()
        {
            constring.Open();
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id INNER JOIN [Unit] ON [Order].unit_id = [Unit].unit_id WHERE order_status = 'Picked-Up'";
            DataTable pickedUp = new DataTable("pickedUp");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(pickedUp);
            constring.Close();

            return pickedUp;
        }
        public DataTable displayCancelled()
        {
            constring.Open();
            string sql = "SELECT * FROM [Order] INNER JOIN [Customer] ON [Order].customer_id = [Customer].customer_id " +
                "INNER JOIN [Service] ON [Order].service_id = [Service].service_id LEFT JOIN [Unit] ON [Order].unit_id = [Unit].unit_id WHERE order_status = 'Cancelled'";
            DataTable cancelled = new DataTable("cancelled");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(cancelled);
            constring.Close();

            return cancelled;
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

            if (activity.Equals("Added New Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','scheduled laundry "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Laundry" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Added Free Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','scheduled free wash "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Laundry" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }

            else if (activity.Equals("Edited Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','edited laundry "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Schedule" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Edit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Cancelled Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','cancelled laundry "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Schedule" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Paused Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','paused laundry "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Schedule" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order paused!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Continued Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','continued laundry "
                            + orderID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Schedule" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order continued!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Started Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','started laundry "
                            + batchID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Laundry Operations" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order started!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Finished Laundry"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','finished laundry "
                            + batchID + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Laundry Operations" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Order finished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
            else if (activity.Equals("Marked Laundry Picked-Up"))
            {
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','marked laundry "
                            + orderID + " as picked-up','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','Schedule" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("Marked order as picked-up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
