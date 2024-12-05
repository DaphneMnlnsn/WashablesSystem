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
using WashablesSystem.Laundry_Schedule;

namespace WashablesSystem
{
    public partial class InProgressList : UserControl
    {
        private TimeSpan time_left;
        private DateTime end_time;
        private TimeSpan actual_time;
        Schedule _parentForm;
        public InProgressList(Schedule parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public void setScheduleInfo(string OrNum, string customerName, string services, string weights, string SchedTime, string pickUpDate, string startTime, string endTime, Image PauseImage, Image CancelImage)
        {
            //Displaying Schedule info
            ORNo.Text = OrNum;
            CustomerName.Text = customerName;
            Services.Text = services;
            Weights.Text = weights;

            ScheduleTime.Text = SchedTime;
            PickUpDate.Text = DateTime.Parse(pickUpDate).ToShortDateString();
            if (!endTime.Equals("-") && !startTime.Equals("-"))
            {
                // timeLeftTimer.Start();
                // actualTimeTimer.Start();
            }
            else
            {
                TimeLeft.Text = "-";
                ActualTime.Text = "-";
            }
            btnCancel.Image = CancelImage;

            displayBatches();
        }
        private void displayBatches()
        {
            batchesContainer.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayBatches(ORNo.Text, "Wash In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), row["unit_name"].ToString(),
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: " + row["start_time"].ToString() + "\nEnd Time: "
                   + row["end_time"].ToString(), row["start_time"].ToString(), row["end_time"].ToString(),
                   "In-Progress", WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);
            }

            orders = scheduleClass.displayBatches(ORNo.Text, "Dry In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), row["unit_name"].ToString(),
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: " + row["start_time"].ToString() + "\nEnd Time: "
                   + row["end_time"].ToString(), row["start_time"].ToString(), row["end_time"].ToString(),
                  "In-Progress", WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);
            }
            orders = scheduleClass.displayBatches(ORNo.Text, "Press In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), row["unit_name"].ToString(),
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: " + row["start_time"].ToString() + "\nEnd Time: "
                   + row["end_time"].ToString(), row["start_time"].ToString(), row["end_time"].ToString(), "In-Progress",
                   WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);
            }
            orders = scheduleClass.displayBatches(ORNo.Text, "Finished");
            foreach (DataRow row in orders.Rows)
            {
                /*BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), row["unit_name"].ToString(),
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: " + row["start_time"].ToString() + "\nEnd Time: "
                   + row["end_time"].ToString(), row["start_time"].ToString(), row["end_time"].ToString(), "",
                   WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);*/
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
                //timeLeftTimer.Stop();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this schedule?\nThis cannot be undone.", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ScheduleClass scheduleClass = new ScheduleClass();
                scheduleClass.cancelSchedule(ORNo.Text);
                _parentForm.RefreshPanel();
            }
        }

        private void batchesContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}