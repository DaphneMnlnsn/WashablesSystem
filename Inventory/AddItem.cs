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

        }

        private void unitQuantity_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryClass inventory = new InventoryClass(txtBoxName.Text, cbCategory.Text, decimal.Parse(txtBoxQuantity.Text), decimal.Parse(txtBoxPrice.Text), unitQuantity.Text);
            inventory.addItem();
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.Text.Equals("Liquid"))
            {
                unitQuantity.SelectedItem = "L";
                unitQuantity.Enabled = false;
            }
            else
            {
                unitQuantity.SelectedItem = "kg";
                unitQuantity.Enabled = false;
            }
            lblPrice.Text = "Price per " + unitQuantity.Text;
        }
    }
}
