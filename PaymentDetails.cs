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
        public PaymentDetails()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            txtBoxName.Text = "Daphne Manalansan";
            txtBoxService.Text = "Wash-Dry-Fold (Clothes, Pillowcase...)";
            txtBoxWeight.Text = "5.00";
            lblTotal.Text = "140.00";
        }
    }
}
