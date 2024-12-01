using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem
{
    internal class SessionVariables
    {
        private static SqlConnection constring = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString);
        private string _loggedIn = "U1";
        private decimal _downpaymentRate = decimal.Parse("0.50");
        private decimal _balanceDueRate = decimal.Parse("0.50");

        public SqlConnection Constring
        {
            get { return constring; }
        }

        public string loggedIn
        {
            get { return _loggedIn; }
            set { _loggedIn = value; }
        }

        public decimal downPaymentRate
        {
            get { return _downpaymentRate; }
            set { _downpaymentRate = value; }
        }
        public decimal balanceDueRate
        {
            get { return _balanceDueRate; }
            set { _balanceDueRate = value; }
        }
    }
}
