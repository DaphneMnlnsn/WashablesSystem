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
    public partial class InProgressSched : Form
    {
        public InProgressSched()
        {
            InitializeComponent();
        }

        private void InProgressSched_Load(object sender, EventArgs e)
        {
            InProgressList inprogressList = new InProgressList();
            inprogressList.setScheduleInfo("OR001", "Quiana Momingo", "Unit III", "Wash/Dry (Clothes...)", "1.00", "Time Schedule: 10/13/2024" + "\n" + "9:45 AM\nStart Time: 10/13/2024\n10:45 AM\n Actual Time: 00:01:00\nEnd Time: 10/13/2024\n10:54 AM ", "10/15/2024", "29 mins", WashablesSystem.Properties.Resources.Pause, WashablesSystem.Properties.Resources.Cancel);
            InProgressContainer.Controls.Add(inprogressList);

            InProgressList inprogressList2 = new InProgressList();
            inprogressList2.setScheduleInfo("OR002", "Kiana Valerio", "UnitIV", "Wash/Dry/Fold (Bed sheet...)", "3.00", "Time Schedule: 10/13/2024\nStart Time: 10/13/2024\n12:12 PM\n Actual Time: 00:02:00\nEnd Time: 10/13/2024 12:42 PM", "10/15/2024", "28 mins", WashablesSystem.Properties.Resources.Pause, WashablesSystem.Properties.Resources.Cancel);
            InProgressContainer.Controls.Add(inprogressList2);
        }
    }
}