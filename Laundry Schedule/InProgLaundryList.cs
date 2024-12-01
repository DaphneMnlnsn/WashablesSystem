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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WashablesSystem
{
    public partial class InProgLaundryList : UserControl
    {
        private TimeSpan time_left;
        private DateTime end_time;
        ScheduleClass scheduleClass = new ScheduleClass();
        public InProgLaundryList()
        {
            InitializeComponent();
        }
        public void setStatus(string orNo, string unit, string customer, string service, string status, string endTime)
        {
            orderNum.Text = orNo;
            lblUnit.Text = unit;
            custName.Text = customer;
            serviceType.Text = service;
            lblStatus.Text = status;
            time_left = DateTime.Parse(endTime) - DateTime.Now;
            end_time = DateTime.Parse(endTime);

            timeLeftTimer.Start();
        }

        private void timeLeftTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now < end_time)
            {
                time_left = end_time - DateTime.Now;
                UpdateTimeDisplay(time_left);
            }
            else
            {
                timeLeftTimer.Stop();
                time_left = TimeSpan.Zero;
                UpdateTimeDisplay(time_left);
            }
        }

        private void InProgLaundryList_Load(object sender, EventArgs e)
        {
        }
        private void UpdateTimeDisplay(TimeSpan time)
        {
            timeLeft.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            timeLeftTimer.Stop();
            scheduleClass.finishSchedule(orderNum.Text);
        }
    }
}