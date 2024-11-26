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
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
 
            ItemList item2 = new ItemList();
            item2.setItemInfo("ITM0002", "Champion Liquid", "Liquid", "20mL", "45.00 /mL");
            ItemContainer.Controls.Add(item2);

            InventoryClass inventory = new InventoryClass();
            DataTable items = inventory.displayItem();
            foreach (DataRow row in items.Rows)
            {
                ItemList item = new ItemList();
                item.setItemInfo(row["item_id"].ToString(), row["item_name"].ToString(),
                   row["item_category"].ToString(), row["item_quantity"].ToString(),
                   row["item_price"].ToString());
                ItemContainer.Controls.Add(item);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }
    }
}