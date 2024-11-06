using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class TransactionList : UserControl
    {
        public TransactionList()
        {
            InitializeComponent();
        }
        public void setTransactionInfo(string PNo, string ONo, string ManagedBy, string CustomerName, string TransactionDate, string PaymentMethod, string Amount)
        {
            //Displaying info
            lblPNo.Text = PNo;
            lblONo.Text = ONo;
            lblManagedBy.Text = ManagedBy;
            lblCustomerName.Text = CustomerName;
            lblTransactionDate.Text = TransactionDate;
            lblPaymentMethod.Text = PaymentMethod;
            lblAmount.Text = Amount;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.ShowDialog();
        }
    }
}