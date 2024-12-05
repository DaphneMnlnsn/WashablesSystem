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
    public partial class PendingPayments : Form
    {
        PaymentClass paymentClass = new PaymentClass();
        public PendingPayments()
        {
            InitializeComponent();
        }

        public PendingPayments(string ORNum)
        {
            InitializeComponent();
            string transactNum = "";
            DataTable bill = paymentClass.getTransactNum(ORNum);
            foreach (DataRow row in bill.Rows)
            {
                transactNum = row["transaction_id"].ToString();
                if (row["payment_status"].ToString().Equals("Paid"))
                {
                    Receipt receipt = new Receipt(transactNum);
                    receipt.ShowDialog();
                }
                else
                {
                    PaymentDetails paymentDetails = new PaymentDetails(this, transactNum);
                    paymentDetails.ShowDialog();
                }
            }
        }
        private void PendingPayments_Load(object sender, EventArgs e)
        {
            PendingContainer.Controls.Clear();
            DataTable payments = paymentClass.getBills();
            foreach (DataRow row in payments.Rows)
            {
                PendingPaymentList payment = new PendingPaymentList();
                payment.setPendingInfo(row["transaction_id"].ToString(), row["order_id"].ToString(),
                   row["customer_name"].ToString(), row["unit_id"].ToString(),
                   row["service_id"].ToString(), row["weight"].ToString(), row["payment_status"].ToString());
                PendingContainer.Controls.Add(payment);
            }
        }
        public void RefreshPanel(object sender, EventArgs e)
        {
            PendingPayments_Load(sender, e);
        }
    }
}