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
    public partial class PendingPayments : Form
    {
        public PendingPayments()
        {
            InitializeComponent();
        }

        public PendingPayments(string ORNum)
        {
            InitializeComponent();
            PaymentDetails paymentDetails = new PaymentDetails(ORNum);
            paymentDetails.ShowDialog();
        }

        private void PendingPayments_Load(object sender, EventArgs e)
        {
            PendingPaymentList pending1 = new PendingPaymentList();
            pending1.setPendingInfo("P0001", "OR341", "Daphne Manalansan", "Unit I", "Wash-Day-Fold", "5.00", "Pending");
            PendingContainer.Controls.Add(pending1);

            PendingPaymentList pending2 = new PendingPaymentList();
            pending2.setPendingInfo("P0001", "OR341", "Kate Maxime Valerio", "Unit II", "Wash", "5.00", "Pending");
            PendingContainer.Controls.Add(pending2);

            PendingPaymentList pending3 = new PendingPaymentList();
            pending3.setPendingInfo("P0001", "OR341", "Kiana Martin", "Unit II", "Wash", "5.00", "Pending");
            PendingContainer.Controls.Add(pending3);
        }
    }
}