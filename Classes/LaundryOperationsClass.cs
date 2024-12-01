using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem.Classes
{
    internal class LaundryOperationsClass
    {
        private string orderID;
        private string unitID;
        private string customerID;
        private string serviceID;
        private DateTime startTime;
        private DateTime endTime;
        private DateTime timeScheduled;
        private DateTime pickupDate;
        private string status;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public LaundryOperationsClass()
        {
            constring = sessionVar.Constring;
        }
        public DataTable getUnitDetails(string category)
        {
            constring.Open();
            string sql = "SELECT * FROM [Unit] WHERE archived = 0 AND unit_category = '" + category + "'";
            DataTable units = new DataTable("units");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(units);
            constring.Close();

            return units;
        }
        private void logOperation()
        {

        }
    }
}
