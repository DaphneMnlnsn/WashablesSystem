using Microsoft.ReportingServices.Interfaces;
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
        private static string _loggedIn;
        private static decimal _downpaymentRate;
        private static decimal _balanceDueRate;
        private static bool _allRead;
        private static bool _notified1 = false;
        private static bool _notified2 = false;

        public SessionVariables()
        {

        }
        public SessionVariables(bool rates)
        {
            constring.Open();

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 [downpayment_rate], [balancedue_rate] FROM [Settings]", constring);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                downPaymentRate = reader1.GetDecimal(0);
                balanceDueRate = reader1.GetDecimal(1);
            }
            else
            {

            }
            reader1.Close();
            cmd.Dispose();
            constring.Close();
        }
        public SqlConnection Constring
        {
            get { return constring; }
        }

        public string loggedIn
        {
            get { return _loggedIn; }
            set { _loggedIn = value; }
        }

        public bool allRead
        {
            get { return _allRead; }
            set { _allRead = value; }
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
        public bool notified1
        {
            get { return _notified1; }
            set { _notified1 = value; }
        }
        public bool notified2
        {
            get { return _notified2; }
            set { _notified2 = value; }
        }
    }
}
