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

namespace WashablesSystem
{
    public partial class ArchiveSchedList : UserControl
    {
        public ArchiveSchedList()
        {
            InitializeComponent();
        }
        public void setScheduleInfo(string OrNum, string customerName, string unitUsed, string services, string weights, string SchedTime, string pickUpDate, string timeLeft)
        {
            //Displaying Schedule info
            ORNo.Text = OrNum;
            CustomerName.Text = customerName;
            UnitUsed.Text = unitUsed;
            Services.Text = services;
            Weights.Text = weights;

            ScheduleTime.Text = SchedTime;
            PickUpDate.Text = pickUpDate;
            TimeLeft.Text = timeLeft;

        }
    }
}