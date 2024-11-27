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
using System.Windows.Media;

namespace WashablesSystem
{
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
        }

        public void setItemInfo(string code, string name, string categ, string quan, string price, string measurement)
        {
            //Displaying info
            ItemCode.Text = code;
            ItemName.Text = name;
            Category.Text = categ;
            Quantity.Text = quan + measurement;
            Price.Text = price + "/" + measurement;

            if (Quantity.Text.Equals("20mL"))
            {
                ItemCode.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                ItemName.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Category.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Quantity.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Price.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
            }

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

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            ItemHistory itemHistory = new ItemHistory(ItemCode.Text);
            itemHistory.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //call archive method here
        }
    }
}