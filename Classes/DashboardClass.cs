using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WashablesSystem.Classes
{
    internal class DashboardClass
    {
        private string timeSpan;
        private string machineName;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public DashboardClass()
        {
            constring = sessionVar.Constring;
        }
        public Dictionary<string, decimal> generateSales(string filter)
        {
            constring.Open();

            string query = "";

            // Filtering queries
            if (filter.Equals("This Week"))
            {
                query = @"SELECT DATEPART(day, transaction_date) AS Day, SUM(total_amount) AS TotalSales
                  FROM Billing
                  WHERE DATEPART(week, transaction_date) = DATEPART(week, GETDATE())
                    AND YEAR(transaction_date) = YEAR(GETDATE())
                  GROUP BY DATEPART(day, transaction_date)";
            }
            else if (filter.Equals("This Month"))
            {
                query = @"SELECT DAY(transaction_date) AS Day, SUM(total_amount) AS TotalSales
                  FROM Billing
                  WHERE MONTH(transaction_date) = MONTH(GETDATE())
                    AND YEAR(transaction_date) = YEAR(GETDATE())
                  GROUP BY DAY(transaction_date)";
            }
            else if (filter.Equals("This Year"))
            {
                query = @"SELECT MONTH(transaction_date) AS Month, SUM(total_amount) AS TotalSales
                  FROM Billing
                  WHERE YEAR(transaction_date) = YEAR(GETDATE())
                  GROUP BY MONTH(transaction_date)";
            }

            var salesData = new Dictionary<string, decimal>();

            using (SqlCommand cmd = new SqlCommand(query, constring))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string key = filter == "This Year" ?
                            $"Month {reader["Month"]}" :
                            $"Day {reader["Day"]}";
                        decimal totalSales = reader["TotalSales"] != DBNull.Value
                            ? Convert.ToDecimal(reader["TotalSales"]) : 0;

                        salesData[key] = totalSales;
                    }
                }

                constring.Close();
                return salesData;
            }
        }
        public Dictionary<string, List<decimal>> generateUnitUsed(DateTime startDate, DateTime endDate, string machineType)
        {
            Dictionary<string, List<decimal>> unitData = new Dictionary<string, List<decimal>>();

            string query = "";

            if (machineType.Equals("Washer"))
            {
                query = @"SELECT unit_id AS unitID, SUM([weight]) + SUM(weight2) + SUM(weight3) AS TotalWeight 
                         FROM [Order] 
                         WHERE finished_on >= @StartDate AND finished_on <= @EndDate
                         GROUP BY unit_id";
            }
            else if (machineType.Equals("Dryer"))
            {
                query = @"SELECT unit_id2 AS unitID, SUM([weight]) + SUM(weight2) + SUM(weight3) AS TotalWeight 
                         FROM [Order] 
                         WHERE finished_on >= @StartDate AND finished_on <= @EndDate
                         GROUP BY unit_id2";
            }
            else if (machineType.Equals("Iron"))
            {
                query = @"SELECT unit_id3 AS unitID, SUM([weight]) + SUM(weight2) + SUM(weight3) AS TotalWeight 
                         FROM [Order] 
                         WHERE finished_on >= @StartDate AND finished_on <= @EndDate
                         GROUP BY unit_id3";
            }

                SqlCommand command = new SqlCommand(query, constring);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                constring.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string unitID = reader["unitID"].ToString();
                        decimal totalWeight = decimal.Parse(reader["TotalWeight"].ToString());

                        if (!unitData.ContainsKey(unitID))
                        {
                            unitData[unitID] = new List<decimal>();
                        }

                        unitData[unitID].Add(totalWeight);
                    }
                }
            
            constring.Close();
            return unitData;
        }
        public DataTable generateUnitUsed(string machine, string filter)
        {
            constring.Open();

            string query = "";

            // Filtering queries
            if (filter.Equals("This Week"))
            {
                if (machine.Equals("Washer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND DAY(o.finished_on) = DAY(GETDATE())
                            GROUP BY u.unit_name";
                }
                else if (machine.Equals("Dryer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id2 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND DAY(o.finished_on) = DAY(GETDATE())
                            GROUP BY u.unit_name";
                }
                else if (machine.Equals("Iron"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id3 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND DAY(o.finished_on) = DAY(GETDATE())
                            GROUP BY u.unit_name";
                }
            }
            else if (filter.Equals("This Month"))
            {
                if (machine.Equals("Washer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND MONTH(o.finished_on) = MONTH(GETDATE())
                            GROUP BY u.unit_name";
                }
                else if (machine.Equals("Dryer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id2 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND MONTH(o.finished_on) = MONTH(GETDATE())
                            GROUP BY u.unit_name";
                }
                else if (machine.Equals("Iron"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id3 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND MONTH(o.finished_on) = MONTH(GETDATE())
                            GROUP BY u.unit_name";
                }
            }
            else if (filter.Equals("This Year"))
            {
                if (machine.Equals("Washer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) GROUP BY u.unit_name";
                }
                else if (machine.Equals("Dryer"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id2 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) GROUP BY u.unit_name";
                }
                else if (machine.Equals("Iron"))
                {
                    query = @"SELECT u.unit_name, SUM(o.weight) + SUM(o.weight2) + SUM(o.weight3) AS TotalWeight
                            FROM 
                               [Order] o JOIN Unit u ON o.unit_id3 = u.unit_id
                            WHERE YEAR(o.finished_on) = YEAR(GETDATE()) GROUP BY u.unit_name";
                }
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, constring);
            DataTable kiloPerUnit = new DataTable("kiloPerUnit");
            dataAdapter.Fill(kiloPerUnit);

            constring.Close();
            return kiloPerUnit;
        }
        public Dictionary<string, int> generateServices(string filter)
        {
            Dictionary<string, int> serviceCounts = new Dictionary<string, int>();
            string query = "";

            switch (filter)
            {
                case "This Week":
                    query = @"
                    SELECT service_category, COUNT(*) AS ServiceCount
                    FROM [Order] o INNER JOIN [Service] ON o.service_id = [Service].service_id
                    OR o.service_id2 = [Service].service_id
                    OR o.service_id3 = [Service].service_id
                    WHERE YEAR(o.finished_on) = YEAR(GETDATE()) AND DAY(o.finished_on) = DAY(GETDATE())
                    GROUP BY service_category";
                    break;

                case "This Month":
                    query = @"
                    SELECT service_category, COUNT(*) AS ServiceCount
                    FROM [Order] INNER JOIN [Service] ON [Order].service_id = [Service].service_id
                    OR [Order].service_id2 = [Service].service_id
                    OR [Order].service_id3 = [Service].service_id
                    WHERE finished_on >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
                    GROUP BY service_category";
                    break;

                case "This Year":
                    query = @"
                    SELECT service_category, COUNT(*) AS ServiceCount
                    FROM [Order] INNER JOIN [Service] ON [Order].service_id = [Service].service_id
                    OR [Order].service_id2 = [Service].service_id
                    OR [Order].service_id3 = [Service].service_id
                    WHERE finished_on >= DATEFROMPARTS(YEAR(GETDATE()), 1, 1)
                    GROUP BY service_category";
                    break;
            }

            // Execute the query and fill the serviceCounts dictionary
                SqlCommand cmd = new SqlCommand(query, constring);

                constring.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string serviceType = reader["service_category"].ToString();
                    int serviceCount = Convert.ToInt32(reader["ServiceCount"]);

                    // Add the service type and count to the dictionary
                    serviceCounts[serviceType] = serviceCount;
                }

            constring.Close();
            return serviceCounts;
        }
        public DataTable generateActLog()
        {
            constring.Open();
            string sql = "SELECT TOP 4 * FROM [ActivityLog] INNER JOIN [User] ON [ActivityLog].user_id = [User].user_id ORDER BY [log_id] DESC";
            DataTable log = new DataTable("log");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(log);
            constring.Close();

            return log;
        }
    }
}
