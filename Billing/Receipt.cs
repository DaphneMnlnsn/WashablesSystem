using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Bitmap bmp;
        public Receipt(string transactionID)
        {
            InitializeComponent();
            btnCancel.Visible = true;
            btnPrint.Visible = true;
            this.transactionID = transactionID;

            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, e.PageBounds.Width, e.PageBounds.Height);
            e.HasMorePages = false;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {

            btnCancel.Visible = false;
            btnPrint.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);

            if (printPreviewDialog1.ShowDialog() == DialogResult.Cancel)
            {
                btnCancel.Visible = true;
                btnPrint.Visible = true;
            }
        }
    }
}
