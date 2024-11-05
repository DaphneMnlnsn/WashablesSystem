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
    public partial class PendingSched : Form
    {
        public PendingSched()
        {
            InitializeComponent();
        }

        private void PendingSched_Load(object sender, EventArgs e)
        {
            PendingList pendingList = new PendingList();
            pendingList.setScheduleInfo("OR1032", "Quiana Momingo", "-", "Wash/Dry (Clothes...)", "5.00", "Time Schedule: 10/12/2024\n5:22 AM\nStart Time: ---\nEnd Time: ---", "10/15/2024", "25 hrs", WashablesSystem.Properties.Resources.Create, WashablesSystem.Properties.Resources.Cancel);
            PendingContainer.Controls.Add(pendingList);

        }
    }
}