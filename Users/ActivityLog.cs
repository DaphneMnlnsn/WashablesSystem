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
    public partial class ActivityLog : Form
    {

        public ActivityLog()
        {
            InitializeComponent();
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            activityContainer.Controls.Clear();
            UserClass user = new UserClass();
            DataTable log = user.displayLog();
            foreach (DataRow row in log.Rows)
            {
                ActivityLogList logList = new ActivityLogList();
                logList.setActivityLog(row["page_location"].ToString(), row["username"].ToString(),
                   row["activity_date"].ToString(), row["activity"].ToString());
                activityContainer.Controls.Add(logList);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView(false);
            reportView.ShowDialog();
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            activityContainer.Controls.Clear();
            UserClass user = new UserClass();
            DataTable log = user.displayLogFilter(dateFilter.Value);
            foreach (DataRow row in log.Rows)
            {
                ActivityLogList logList = new ActivityLogList();
                logList.setActivityLog(row["page_location"].ToString(), row["username"].ToString(),
                   row["activity_date"].ToString(), row["activity"].ToString());
                activityContainer.Controls.Add(logList);
            }
        }
    }
}
