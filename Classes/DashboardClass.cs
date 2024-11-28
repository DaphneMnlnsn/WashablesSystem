using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void generateSales()
        {

        }
        public void generateUnitUsed()
        {

        }
        public void generateServices()
        {

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
