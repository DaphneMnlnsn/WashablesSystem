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
        public PendingPayments()
        {
            InitializeComponent();
        }

        public PendingPayments(string ORNum)
        {
            InitializeComponent();
            PaymentDetails paymentDetails = new PaymentDetails(this, ORNum);
            paymentDetails.ShowDialog();
        }

        private void PendingPayments_Load(object sender, EventArgs e)
        {
            PendingContainer.Controls.Clear();
            PaymentClass paymentClass = new PaymentClass();
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