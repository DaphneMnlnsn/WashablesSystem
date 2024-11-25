using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem.Classes
{
    internal class ActivityLogClass
    {
        private string activityLocation;
        private string employeeID;
        private DateTime activityDate;
        private string activityDesc;

        public DataTable displayActivity()
        {
            return new DataTable();
        }
        private void logOperation()
        {

        }
    }
}
