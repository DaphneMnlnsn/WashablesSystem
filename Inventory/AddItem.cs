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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unitQuantity_Click(object sender, EventArgs e)
        {
            if (cbCategory.Text.Equals("Liquid"))
            {
                unitQuantity.Items.Clear();
                unitQuantity.Items.Add("milliliter (mL)");
                unitQuantity.Items.Add("liter (L)");
            }
            else
            {
                unitQuantity.Items.Clear();
                unitQuantity.Items.Add("gram (g)");
                unitQuantity.Items.Add("kilogram (kg)");
            }
        }

        private void unitQuantity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblPrice.Text = "Price per " + unitQuantity.Text;
        }
    }
}
