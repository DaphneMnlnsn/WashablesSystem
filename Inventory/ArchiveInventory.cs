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
    public partial class ArchiveInventory : Form
    {
        public ArchiveInventory()
        {
            InitializeComponent();
        }

        private void ArchiveInventory_Load(object sender, EventArgs e)
        {
            ArchiveInventoryList ArchiInventoryList = new ArchiveInventoryList();
            ArchiInventoryList.setInventoryInfo("ITM0001", "Surf Powder", "Powder", "20kg", "200.00/kg");
            ArchivedItemsContainer.Controls.Add(ArchiInventoryList);

            ArchiveInventoryList ArchiInventoryList2 = new ArchiveInventoryList();
            ArchiInventoryList2.setInventoryInfo("ITM0002", "Champion Liquid", "Liquid", "20L", "45.00/L");
            ArchivedItemsContainer.Controls.Add(ArchiInventoryList2);

            ArchiveInventoryList ArchiInventoryList3 = new ArchiveInventoryList();
            ArchiInventoryList3.setInventoryInfo("ITM0003", "Zonrox", "Liquid", "20L", "30.00/L");
            ArchivedItemsContainer.Controls.Add(ArchiInventoryList3);
        }
    }
}