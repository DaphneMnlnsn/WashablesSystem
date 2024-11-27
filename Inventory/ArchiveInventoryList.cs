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
    public partial class ArchiveInventoryList : UserControl
    {
        public ArchiveInventoryList()
        {
            InitializeComponent();
        }
        public void setInventoryInfo(string code, string name, string categ, string quan, string price)
        {
            //Displaying info
            ItemCode.Text = code;
            ItemName.Text = name;
            Category.Text = categ;
            Quantity.Text = quan;
            Price.Text = price;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //call restore method here
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //call delete method here
        }
    }
}