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
                //call restock method here
                InventoryClass itemClass = new InventoryClass(decimal.Parse(txtBoxQuantity.Text));
                itemClass.restockItem(item_selected);
                _parentForm.RefreshPanel();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
