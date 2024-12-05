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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows;
using WashablesSystem.Classes;
using System.IdentityModel.Claims;

namespace WashablesSystem.Laundry_Schedule
{
    public partial class BatchList : UserControl
    {
        private TimeSpan time_left;
        private DateTime end_time;
        private TimeSpan actual_time;
        private string status = "";
        private bool notifDisplayed = false;
        public BatchList()
        {
            InitializeComponent();
        }
        public void setScheduleInfo(string batchNum, string unitUsed, string services, string weights, string SchedTime, string startTime, string endTime, string status, Image PauseImage)
        {
            this.status = status;
            if (status.Equals("Finished"))
            {
                ORNo.Text = batchNum;
                UnitUsed.Text = unitUsed;
                Services.Text = services;
                Weights.Text = weights;
                ScheduleTime.Text = SchedTime;
                btnPause.Visible = false;
                ActualTime.Text = DateTime.Parse(startTime).ToString(@"hh\:mm\:ss");
                TimeLeft.Text = endTime;
            }
            else if (status.Equals("In-Progress") || status.Equals("Pending"))
            {
                //Displaying Schedule info
                ORNo.Text = batchNum;
                UnitUsed.Text = unitUsed;
                Services.Text = services;
                Weights.Text = weights;
                ScheduleTime.Text = SchedTime;
                btnPause.Image = PauseImage;
                if (!endTime.Equals("-") && !startTime.Equals("-"))
                {

                    end_time = DateTime.Parse(endTime);
                    time_left = DateTime.Parse(endTime) - DateTime.Now;
                    actual_time = DateTime.Now - DateTime.Parse(startTime);
                    timeLeftTimer.Start();
                    actualTimeTimer.Start();
                    this.status = "In-Progress";
                }
                else
                {
                    TimeLeft.Text = "-";
                    ActualTime.Text = "-";
                    btnPause.Visible = false;
                    this.status = "Pending";
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text.Equals("Playing"))
            {
                btnPause.Image = WashablesSystem.Properties.Resources.Play;
                lblStatus.Text = "Paused";
                timeLeftTimer.Stop();
                actualTimeTimer.Stop();
            }
            else if (lblStatus.Text.Equals("Paused"))
            {
                btnPause.Image = WashablesSystem.Properties.Resources.Pause;
                lblStatus.Text = "Playing";
                timeLeftTimer.Start();
                actualTimeTimer.Start();
            }
        }

        private void InProgressList_Load(object sender, EventArgs e)
        {
            notifDisplayed = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status.Equals("Pending") || status.Equals("Finished"))
            {

            }
            else
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

                    this.status = "Finished";
                }
            }

        }
        private void UpdateTimeDisplay(TimeSpan timeLeft)
        {

            TimeLeft.Text = timeLeft.ToString(@"hh\:mm\:ss");
            ActualTime.Text = actual_time.ToString(@"hh\:mm\:ss");
            if (TimeLeft.Text.Equals("00:00:00") && notifDisplayed == false)
            {
                notifDisplayed = true;
                NotificationClass notificationClass = new NotificationClass();
                notificationClass.sendNotification(ORNo.Text, "Laundry Finished");
            }
        }

        private void actualTimeTimer_Tick(object sender, EventArgs e)
        {
            actual_time = actual_time.Add(TimeSpan.FromSeconds(1));
            UpdateTimeDisplay(time_left);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ScheduleClass scheduleClass = new ScheduleClass();
            scheduleClass.cancelSchedule(ORNo.Text);
        }
    }
}