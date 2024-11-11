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
    public partial class ItemHistory : Form
    {
        public ItemHistory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemHistory_Load(object sender, EventArgs e)
        {
            ItemHistoryList activity1 = new ItemHistoryList();
            activity1.setItemHistory("Roxanne Rose", "10/12/2024 8:38PM", "used 1mL");
            activityContainer.Controls.Add(activity1);

            ItemHistoryList activity2 = new ItemHistoryList();
            activity2.setItemHistory("Roxanne Rose", "10/12/2024 7:34PM", "used 2g");
            activityContainer.Controls.Add(activity2);

            ItemHistoryList activity3 = new ItemHistoryList();
            activity3.setItemHistory("Roxanne Rose", "10/12/2024 7:30PM", "added 3kg");
            activityContainer.Controls.Add(activity3);
        }
    }
}
