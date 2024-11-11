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
    public partial class PaymentDetails : Form
    {
        string payingORNum = "";
        public PaymentDetails()
        {
            InitializeComponent();
        }
        public PaymentDetails(string ORNum)
        {
            InitializeComponent();
            payingORNum = ORNum;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            if (payingORNum.Equals("OR1033"))
            {
                txtBoxName.Text = "Amiah Velasco";
            }
            else
            {
                txtBoxName.Text = "Daphne Manalansan";
            }
            txtBoxService.Text = "Wash-Dry-Fold (Clothes, Pillowcase...)";
            txtBoxWeight.Text = "5.00";
            lblTotal.Text = "140.00";
        }
    }
}
