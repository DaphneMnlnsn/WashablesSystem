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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            TransactionContainer.Controls.Clear();
            PaymentClass paymentClass = new PaymentClass();
            DataTable payments = paymentClass.getHistory();
            foreach (DataRow row in payments.Rows)
            {
                TransactionList payment = new TransactionList();
                payment.setTransactionInfo(row["transaction_id"].ToString(), row["order_id"].ToString(), row["user_fullname"].ToString(),
                   row["customer_name"].ToString(), row["transaction_date"].ToString(), row["payment_method"].ToString(), row["total_amount"].ToString());
                TransactionContainer.Controls.Add(payment);
            }

        }
    }
}