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

        public SqlConnection Constring
        {
            get { return constring; }
        }

        public string loggedIn
        {
            get { return _loggedIn; }
            set { _loggedIn = value; }
        }
    }
}
