using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class Receipt : Form
    {
        private string transactionID = "";
        public Receipt(string transactionID)
        {
            InitializeComponent();
            this.transactionID = transactionID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            PaymentClass paymentClass = new PaymentClass();
            DataTable payments = paymentClass.getBillingDetails(transactionID);
            foreach (DataRow row in payments.Rows)
            {
                lblDate.Text = DateTime.Parse(row["transaction_date"].ToString()).ToShortDateString();
                lblStaff.Text = row["user_fullname"].ToString();
                lblPickupTime.Text = DateTime.Parse(row["pickup_date"].ToString()).ToShortDateString();
                lblCustomerName.Text = row["customer_name"].ToString();
                lblServiceType.Text = row["service_category"].ToString();
                lblWeight.Text = (decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString())).ToString();
                lblPaymentMethod.Text = row["payment_method"].ToString();
                if (row["payment_method"].ToString().Equals("Cash"))
                {
                    lblReference.Text = "N/A";
                }
                else
                {
                    lblReference.Text = row["reference_num"].ToString() + " | " + row["reference_num"].ToString();
                }
                lblAdditionalCharge.Text = row["additional_charge"].ToString();
                lblPaymentReceived.Text = row["payment_received"].ToString() + " | " + row["downpayment_received"].ToString();
                lblChange.Text = row["change"].ToString() + " | " + row["downpayment_change"].ToString();
                lblTotal.Text = row["total_amount"].ToString();
            }
        }
    }
}
