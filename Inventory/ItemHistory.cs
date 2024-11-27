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
    public partial class ItemHistory : Form
    {
        string selectedItemID;
        public ItemHistory(string itemID)
        {
            InitializeComponent();
            this.selectedItemID = itemID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemHistory_Load(object sender, EventArgs e)
        {
            InventoryClass inventory = new InventoryClass();
            DataTable itemHistoryTbl = inventory.displayItemHistory(selectedItemID);
            foreach (DataRow row in itemHistoryTbl.Rows)
            {
                ItemHistoryList itemHistory = new ItemHistoryList();
                itemHistory.setItemHistory(row["username"].ToString(), row["history_date"].ToString(),
                   row["description"].ToString());
                activityContainer.Controls.Add(itemHistory);
            }
        }
    }
}
