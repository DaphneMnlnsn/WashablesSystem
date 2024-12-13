using Microsoft.IdentityModel.Tokens;
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
        private ItemView _parentForm = new ItemView();
        public AddItem(ItemView parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
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
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxName.Text) && txtBoxQuantity.Value > 0 && decimal.TryParse(txtBoxPrice.Text, out decimal price)
                    && decimal.Parse(txtBoxPrice.Text) > 0)
                {
                    InventoryClass inventory = new InventoryClass(txtBoxName.Text, cbCategory.Text, decimal.Parse(txtBoxQuantity.Text), decimal.Parse(txtBoxPrice.Text), unitQuantity.Text);
                    inventory.addItem();
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void AddItem_Load(object sender, EventArgs e)
        {
            cbCategory.SelectedIndex = 0;
        }
    }
}
