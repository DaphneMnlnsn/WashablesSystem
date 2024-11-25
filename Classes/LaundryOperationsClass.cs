using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public void startLaundry(string orderID)
        {

        }
        public void finishLaundry(string orderID)
        {

        }
        public DataTable getOperationDetails()
        {
            return new DataTable();
        }
        private void logOperation()
        {

        }
    }
}
