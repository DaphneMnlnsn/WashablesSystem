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
    public partial class EditItem : Form
    {
        private ItemView _parentForm = new ItemView();
        private string item_selected;
        private decimal item_quantity;
        private string item_unit;
        public EditItem(ItemView parentForm, string itemSelected)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.item_selected = itemSelected;
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            //call displayselectedinfo method here
            InventoryClass editItem = new InventoryClass();
            DataTable items = new DataTable();
            items = editItem.displaySelectedItem(item_selected);

            foreach (DataRow row in items.Rows)
            {
                txtBoxName.Text = row["item_name"].ToString();
                cbCategory.Text = row["item_category"].ToString();
                txtBoxPrice.Text = row["item_price"].ToString();
                item_quantity = decimal.Parse(row["item_quantity"].ToString());
                item_unit = row["item_measurement"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //call edit method here
            InventoryClass inventory = new InventoryClass(txtBoxName.Text, cbCategory.Text,item_quantity, decimal.Parse(txtBoxPrice.Text), item_unit);
            inventory.editItem(item_selected);
            _parentForm.RefreshPanel();
            this.Close();
        }
    }
}
