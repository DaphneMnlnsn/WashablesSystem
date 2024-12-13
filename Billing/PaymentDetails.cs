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
    public partial class PaymentDetails : Form
    {
        string transactNum = "";
        decimal totalAmount = 0;
        PaymentClass paymentClass = new PaymentClass();
        PendingPayments _parentForm = new PendingPayments();
        decimal currentAmount = 0;
        public PaymentDetails(PendingPayments parentForm, string transactNum)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this.transactNum = transactNum;
            radioBtnCash.Checked = true;
            fullPaymentRadio.Checked = true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            DataTable transactionInfo = new DataTable();
            transactionInfo = paymentClass.getBillingDetails(transactNum);

            foreach (DataRow row in transactionInfo.Rows)
            {
                txtBoxName.Text = row["customer_name"].ToString();
                service1.Text = row["service_id"].ToString();
                service2.Text = row["service_id2"].ToString();
                service3.Text = row["service_id3"].ToString();
                weight1.Text = row["weight"].ToString();
                weight2.Text = row["weight2"].ToString();
                weight3.Text = row["weight3"].ToString();
                datePickup.Text = row["pickup_date"].ToString();
                totalAmount = decimal.Parse(row["total_amount"].ToString());
                if (row["payment_status"].ToString().Equals("Downpaid"))
                {
                    //if downpayment is already paid and only balance due is remaining
                    downpaymentRadio.Checked = true;
                    fullPaymentRadio.Enabled = false;
                    totalAmountLbl.Text = "Balance Due:";
                    lblTotal.Text = (totalAmount - decimal.Parse(row["downpayment"].ToString())).ToString("0.00");
                }
                else
                {
                    lblTotal.Text = row["total_amount"].ToString();
                }
            }
        }

        private void radioBtnGcash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnGcash.Checked)
            {
                txtBoxReferenceNo.Enabled = true;
            }
            else if (!radioBtnGcash.Checked)
            {
                txtBoxReferenceNo.Enabled = false;
            }
        }

        private void downpaymentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (downpaymentRadio.Checked)
            {
                totalAmountLbl.Text = "Downpayment Amount:";
                lblTotal.Text = paymentClass.computeDownPaymentAmount(totalAmount).ToString("0.00");
            }
            else
            {
                totalAmountLbl.Text = "Total Amount to Pay:";
                lblTotal.Text = (totalAmount + decimal.Parse(txtBoxCharge.Text)).ToString("0.00");
            }
            currentAmount = decimal.Parse(lblTotal.Text);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";
            if (radioBtnGcash.Checked)
            {
                paymentMethod = "GCash";
            }
            else if (!radioBtnGcash.Checked)
            {
                paymentMethod = "Cash";
            }

            if (decimal.TryParse(lblTotal.Text, out decimal num) && txtBoxReceived.Value >= 0 && txtBoxReceived.Value >= decimal.Parse(lblTotal.Text)) {
                
                PaymentClass paymentClass2 = new PaymentClass(decimal.Parse(lblTotal.Text), totalAmount - decimal.Parse(lblTotal.Text),
                    totalAmount, txtBoxCharge.Value, paymentMethod, txtBoxReferenceNo.Text,
                    txtBoxReceived.Value, txtBoxChange.Value);

                if (downpaymentRadio.Checked && totalAmountLbl.Text.Equals("Downpayment Amount:"))
                {
                    paymentClass2.payBillDown(transactNum);
                    _parentForm.RefreshPanel(sender, e);
                    this.Close();
                }
                else if (downpaymentRadio.Checked && totalAmountLbl.Text.Equals("Balance Due:"))
                {
                    paymentClass2.payBillDue(transactNum);
                    _parentForm.RefreshPanel(sender, e);
                    this.Close();
                }
                else if (!downpaymentRadio.Checked && totalAmountLbl.Text.Equals("Total Amount to Pay:"))
                {
                    paymentClass2.payBillFullPayment(transactNum);
                    _parentForm.RefreshPanel(sender, e);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBoxReceived_ValueChanged(object sender, EventArgs e)
        {
            if (txtBoxReceived.Value > currentAmount)
            {
                txtBoxChange.Value = txtBoxReceived.Value - decimal.Parse(lblTotal.Text);
            }
        }

        private void txtBoxCharge_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (currentAmount + txtBoxCharge.Value).ToString();
        }
    }
}
