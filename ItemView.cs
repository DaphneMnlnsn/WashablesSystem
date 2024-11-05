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
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            ItemList item = new ItemList();
            item.setItemInfo("ITM0001", "Surf Powder", "Powder", "20", "20.00");
            ItemContainer.Controls.Add(item);

            ItemList item2 = new ItemList();
            item2.setItemInfo("ITM0002", "Champion Liquid", "Liquid", "20", "45.00");
            ItemContainer.Controls.Add(item2);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.ShowDialog();
        }
    }
}