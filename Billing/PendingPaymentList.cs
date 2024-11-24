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
    public partial class PendingPaymentList : UserControl
    {
        public PendingPaymentList()
        {
            InitializeComponent();
        }
        public void setPendingInfo(string PNo, string ONo, string CustomerName, string UnitUsed, string Services, string Weight, string Status)
        {
            //Displaying info
            lblPNo.Text = PNo;
            lblONo.Text = ONo;
            lblCustomerName.Text = CustomerName;
            lblUnitUsed.Text = UnitUsed;
            lblServices.Text = Services;
            lblWeight.Text = Weight;
            lblStatus.Text = Status;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentDetails details = new PaymentDetails();
            details.ShowDialog();
        }
    }
}