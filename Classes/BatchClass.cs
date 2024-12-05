using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem.Classes
{
    internal class BatchClass
    {
        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;
        string orderID = "", status = "";

        public BatchClass(string orderID, string status)
        {
            constring = sessionVar.Constring;
            this.orderID = orderID;
            this.status = status;
        }
        public void batchLaundry()
        {
            constring.Open();

            // For service_id1
            string query = @"
                            WITH BatchCTE AS (
                                SELECT 
                                    o.order_id, s.service_id, s.service_minWeight AS max_weight, o.weight,
                                    FLOOR(o.weight / s.service_minWeight) AS full_batches, o.weight % s.service_minWeight AS remaining_weight
                                FROM [Order] o JOIN Service s ON o.service_id = s.service_id WHERE o.weight > 0 AND o.order_id = @OrderId
                            )
                            SELECT 
                                order_id, service_id, max_weight AS batch_weight, 'Full Batch' AS batch_type
                            FROM BatchCTE
                            WHERE full_batches > 0
                            UNION ALL
                            SELECT order_id, service_id, remaining_weight AS batch_weight, 'Remaining Batch' AS batch_type
                            FROM BatchCTE WHERE remaining_weight > 0;";

            DataTable orderDetails = new DataTable();
            SqlCommand cmd = new SqlCommand(query, constring);
            cmd.Parameters.AddWithValue("@OrderId", orderID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(orderDetails);

            foreach (DataRow row in orderDetails.Rows)
            {
                string batchID = "";
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 [batch_id] FROM [OrderBatch] ORDER BY [batch_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd2.ExecuteReader();
                if (reader1.Read())
                {
                    batchID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", batchID.Where(Char.IsDigit))) + 1;
                    batchID = "B" + num;
                }
                else
                {
                    batchID = "B1001";
                }
                reader1.Close();
                cmd2.Dispose();
                string serviceId = row["service_id"].ToString();
                double batchWeight = Convert.ToDouble(row["batch_weight"]);
                string query2 = @"
                        INSERT INTO OrderBatch (batch_id, order_id, service_id, weight, status)
                        VALUES (@BatchId, @OrderId, @ServiceId, @Weight, @Status)";
                cmd2 = new SqlCommand(query2, constring);
                cmd2.Parameters.AddWithValue("@BatchId", batchID);
                cmd2.Parameters.AddWithValue("@OrderId", row["order_id"].ToString());
                cmd2.Parameters.AddWithValue("@ServiceId", serviceId);
                cmd2.Parameters.AddWithValue("@Weight", batchWeight);
                cmd2.Parameters.AddWithValue("@Status", status);
                cmd2.ExecuteNonQuery();
            }

            //For service_id2
            query = @"
                      WITH BatchCTE AS (
                        SELECT 
                          o.order_id, s.service_id, s.service_minWeight AS max_weight, o.weight2,
                          FLOOR(o.weight2 / s.service_minWeight) AS full_batches, o.weight2 % s.service_minWeight AS remaining_weight
                          FROM [Order] o JOIN Service s ON o.service_id2 = s.service_id WHERE o.weight2 > 0 AND o.order_id = @OrderId
                       )
                       SELECT 
                        order_id, service_id, max_weight AS batch_weight, 'Full Batch' AS batch_type
                       FROM BatchCTE
                       WHERE full_batches > 0
                       UNION ALL
                       SELECT order_id, service_id, remaining_weight AS batch_weight, 'Remaining Batch' AS batch_type
                       FROM BatchCTE WHERE remaining_weight > 0;";

            DataTable orderDetails2 = new DataTable();
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.AddWithValue("@OrderId", orderID);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(orderDetails2);

            foreach (DataRow row in orderDetails2.Rows)
            {
                string batchID = "";
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 [batch_id] FROM [OrderBatch] ORDER BY [batch_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd2.ExecuteReader();
                if (reader1.Read())
                {
                    batchID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", batchID.Where(Char.IsDigit))) + 1;
                    batchID = "B" + num;
                }
                else
                {
                    batchID = "B1001";
                }
                reader1.Close();
                cmd2.Dispose();
                string serviceId = row["service_id"].ToString();
                double batchWeight = Convert.ToDouble(row["batch_weight"]);
                string query2 = @"
                        INSERT INTO OrderBatch (batch_id, order_id, service_id, weight, status)
                        VALUES (@BatchId, @OrderId, @ServiceId, @Weight, @Status)";
                cmd2 = new SqlCommand(query2, constring);
                cmd2.Parameters.AddWithValue("@BatchId", batchID);
                cmd2.Parameters.AddWithValue("@OrderId", row["order_id"].ToString());
                cmd2.Parameters.AddWithValue("@ServiceId", serviceId);
                cmd2.Parameters.AddWithValue("@Weight", batchWeight);
                cmd2.Parameters.AddWithValue("@Status", status);
                cmd2.ExecuteNonQuery();
            }

            //For service_id3
            query = @"
                      WITH BatchCTE AS (
                        SELECT 
                          o.order_id, s.service_id, s.service_minWeight AS max_weight, o.weight3,
                          FLOOR(o.weight3 / s.service_minWeight) AS full_batches, o.weight3 % s.service_minWeight AS remaining_weight
                          FROM [Order] o JOIN Service s ON o.service_id3 = s.service_id WHERE o.weight3 > 0 AND o.order_id = @OrderId
                       )
                       SELECT 
                         order_id, service_id, max_weight AS batch_weight, 'Full Batch' AS batch_type
                       FROM BatchCTE
                       WHERE full_batches > 0
                       UNION ALL
                       SELECT order_id, service_id, remaining_weight AS batch_weight, 'Remaining Batch' AS batch_type
                       FROM BatchCTE WHERE remaining_weight > 0;";

            DataTable orderDetails3 = new DataTable();
            cmd = new SqlCommand(query, constring);
            cmd.Parameters.AddWithValue("@OrderId", orderID);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(orderDetails3);

            foreach (DataRow row in orderDetails3.Rows)
            {
                string batchID = "";
                SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 [batch_id] FROM [OrderBatch] ORDER BY [batch_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd2.ExecuteReader();
                if (reader1.Read())
                {
                    batchID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", batchID.Where(Char.IsDigit))) + 1;
                    batchID = "B" + num;
                }
                else
                {
                    batchID = "B1001";
                }
                reader1.Close();
                cmd2.Dispose();
                string serviceId = row["service_id"].ToString();
                double batchWeight = Convert.ToDouble(row["batch_weight"]);
                string query2 = @"
                        INSERT INTO OrderBatch (batch_id, order_id, service_id, weight, status)
                        VALUES (@BatchId, @OrderId, @ServiceId, @Weight, @Status)";
                cmd2 = new SqlCommand(query2, constring);
                cmd2.Parameters.AddWithValue("@BatchId", batchID);
                cmd2.Parameters.AddWithValue("@OrderId", row["order_id"].ToString());
                cmd2.Parameters.AddWithValue("@ServiceId", serviceId);
                cmd2.Parameters.AddWithValue("@Weight", batchWeight);
                cmd2.Parameters.AddWithValue("@Status", status);
                cmd2.ExecuteNonQuery();
            }
            constring.Close();
        }

    }
}
