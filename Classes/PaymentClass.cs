using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashablesSystem.Classes
{
    internal class PaymentClass
    {
        private string transactionID;
        private string orderID;
        private string customerID;
        private string unitID;
        private string serviceID;
        private string serviceWeight;
        private DateTime transactionDate;
        private decimal downpaymentRate;
        private decimal balancedueRate;
        private decimal totalAmount;
        private string status;
        private bool availabilityStatus;

        public DataTable getBillingDetails()
        {
            return new DataTable();
        }
        public decimal computeAmount()
        {
            return 0;
        }
        public void updatePaymentStatus()
        {

        }
        public void cancelPayment()
        {

        }
        public void generateReceipt()
        {

        }
        private void logOperation()
        {

        }
    }
}
