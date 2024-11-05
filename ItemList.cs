using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace WashablesSystem
{
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
        }

        public void setItemInfo(string code, string name, string categ, string quan, string price)
        {
            //Displaying info
            ItemCode.Text = code;
            ItemName.Text = name;
            Category.Text = categ;
            Quantity.Text = quan;
            Price.Text = price;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditItem editItem = new EditItem();
            editItem.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RestockItem restockItem = new RestockItem();
            restockItem.ShowDialog();
        }
    }
}