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
    public partial class RestockItem : Form
    {
        private string item_selected;
        private ItemView _parentForm = new ItemView();
        public RestockItem(ItemView parentForm, string itemSelected)
        {
            InitializeComponent();
            item_selected = itemSelected;
            _parentForm = parentForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestockItem_Load(object sender, EventArgs e)
        {
            InventoryClass editItem = new InventoryClass();
            DataTable items = new DataTable();
            items = editItem.displaySelectedItem(item_selected);

            foreach (DataRow row in items.Rows)
            {
                txtBoxRemaining.Text = row["item_quantity"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxQuantity.Value > 0)
                {
                    //call restock method here
                    InventoryClass itemClass = new InventoryClass(decimal.Parse(txtBoxQuantity.Text));
                    if (radioAdd.Checked)
                    {
                        itemClass.restockItem(item_selected);
                    }
                    else
                    {
                        itemClass.subtractItem(item_selected);
                    }
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
