using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class ActivityLogList : UserControl
    {
        public ActivityLogList()
        {
            InitializeComponent();
        }
        public void setActivityLog(string activityLocation, string activitylogName, string activitylogDate, string activitylogDescription)
        {
            //Displaying customer info
            lblLocation.Text = activityLocation;
            actlogName.Text = activitylogName;
            actlogDate.Text = activitylogDate;
            actlogDescription.Text = activitylogDescription;           
        }
    }
}
