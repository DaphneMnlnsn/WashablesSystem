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
        private string search;
        public ItemView()
        {
            InitializeComponent();
        }
        public ItemView(string search)
        {
            InitializeComponent();
            this.search = search;
            loadSearch();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            ItemContainer.Controls.Clear();
            InventoryClass inventory = new InventoryClass();
            DataTable items = inventory.displayItem();
            foreach (DataRow row in items.Rows)
            {
                ItemList item = new ItemList(this);
                item.setItemInfo(row["item_id"].ToString(), row["item_name"].ToString(),
                   row["item_category"].ToString(), row["item_quantity"].ToString(),
                   row["item_price"].ToString(), row["item_measurement"].ToString());
                ItemContainer.Controls.Add(item);
            }
        }
        private void loadSearch()
        {
            ItemContainer.Controls.Clear();
            InventoryClass inventory = new InventoryClass();
            DataTable items = inventory.displayItemSearch(search);
            foreach (DataRow row in items.Rows)
            {
                ItemList item = new ItemList(this);
                item.setItemInfo(row["item_id"].ToString(), row["item_name"].ToString(),
                   row["item_category"].ToString(), row["item_quantity"].ToString(),
                   row["item_price"].ToString(), row["item_measurement"].ToString());
                ItemContainer.Controls.Add(item);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }
        public void RefreshPanel()
        {
            ItemView_Load(null, null);
        }
    }
}