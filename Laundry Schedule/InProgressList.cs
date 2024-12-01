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

namespace WashablesSystem
{
    public partial class InProgressList : UserControl
    {
        private TimeSpan time_left;
        private DateTime end_time;
        private TimeSpan actual_time;
        public InProgressList()
        {
            InitializeComponent();
        }
        public void setScheduleInfo(string OrNum, string customerName, string unitUsed, string services, string weights, string SchedTime, string pickUpDate, string startTime, string endTime, Image PauseImage, Image CancelImage)
        {
            //Displaying Schedule info
            ORNo.Text = OrNum;
            CustomerName.Text = customerName;
            UnitUsed.Text = unitUsed;
            Services.Text = services;
            Weights.Text = weights;

            ScheduleTime.Text = SchedTime;
            PickUpDate.Text = DateTime.Parse(pickUpDate).ToShortDateString();
            btnPause.Image = PauseImage;
            if (!endTime.Equals("-") && !startTime.Equals("-"))
            {

                end_time = DateTime.Parse(endTime);
                time_left = DateTime.Parse(endTime) - DateTime.Now;
                actual_time = DateTime.Now - DateTime.Parse(startTime);
                timeLeftTimer.Start();
                actualTimeTimer.Start();
            }
            else
            {
                TimeLeft.Text = "-";
                ActualTime.Text = "-";
            }
            btnCancel.Image = CancelImage;
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
            else
            {
                btnPause.Image = WashablesSystem.Properties.Resources.Pause;
                lblStatus.Text = "Playing";
                timeLeftTimer.Start();
                actualTimeTimer.Start();
            }
        }

        private void InProgressList_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
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
        private void UpdateTimeDisplay(TimeSpan timeLeft)
        {
            TimeLeft.Text = timeLeft.ToString(@"hh\:mm\:ss");
            ActualTime.Text = actual_time.ToString(@"hh\:mm\:ss");
        }

        private void actualTimeTimer_Tick(object sender, EventArgs e)
        {
            actual_time = actual_time.Add(TimeSpan.FromSeconds(1));
            UpdateTimeDisplay(time_left);
        }
    }
}