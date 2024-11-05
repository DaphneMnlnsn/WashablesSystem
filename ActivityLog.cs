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
    public partial class ActivityLog : Form
    {
        public ActivityLog()
        {
            InitializeComponent();
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            ActivityLogList activity1 = new ActivityLogList();
            activity1.setActivityLog("Roxanne Rose", "10/12/2024 8:38PM", "finished laundry OR2345");
            activityContainer.Controls.Add(activity1);

            ActivityLogList activity2 = new ActivityLogList();
            activity2.setActivityLog("Roxanne Rose", "10/12/2024 7:34PM", "started laundry OR2345 at Unit I");
            activityContainer.Controls.Add(activity2);

            ActivityLogList activity3 = new ActivityLogList();
            activity3.setActivityLog("Roxanne Rose", "10/12/2024 7:30PM", "scheduled laundry OR2345");
            activityContainer.Controls.Add(activity3);
        }
    }
}
