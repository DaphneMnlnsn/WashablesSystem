using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem.Classes
{
    internal class ScheduleClass
    {
        private string orderID;
        private string unitID;
        private string customerID;
        private string serviceID;
        private DateTime startTime;
        private DateTime endTime;
        private DateTime timeScheduled;
        private DateTime pickupDate;
        private DateTime dateFinished;
        private string status;

        public void editSchedule(string serviceID)
        {

        }
        public void pauseSchedule(string serviceID)
        {

        }
        public void playSchedule(string serviceID)
        {

        }
        public void cancelSchedule(string serviceID)
        {

        }
        public void deleteService(string serviceID)
        {

        }
        public DataTable displayInProgress()
        {
            return new DataTable();
        }
        public DataTable displayPending()
        {
            return new DataTable();
        }
        public DataTable displayFinished()
        {
            return new DataTable();
        }
        public DataTable displayCancelled()
        {
            return new DataTable();
        }
        private void logOperation()
        {

        }
    }
}
