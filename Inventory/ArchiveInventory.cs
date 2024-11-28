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
    public partial class ArchiveInventory : Form
    {
        public ArchiveInventory()
        {
            InitializeComponent();
        }

        private void ArchiveInventory_Load(object sender, EventArgs e)
        {
            InventoryClass inventoryArchive = new InventoryClass();
            DataTable inventory = inventoryArchive.displayItemArchive();
            foreach (DataRow row in inventory.Rows)
            {
                ArchiveInventoryList archive = new ArchiveInventoryList();
                archive.setInventoryInfo(row["item_id"].ToString(), row["item_name"].ToString(), row["item_category"].ToString(), row["item_quantity"].ToString(), row["item_price"].ToString());
                ArchivedItemsContainer.Controls.Add(archive);
            }
        }
    }
}