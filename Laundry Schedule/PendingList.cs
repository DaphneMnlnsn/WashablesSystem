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
using WashablesSystem.Classes;
using WashablesSystem.Laundry_Schedule;

namespace WashablesSystem
{
    public partial class PendingList : UserControl
    {
        Schedule _parentForm;
        ScheduleClass scheduleClass = new ScheduleClass();
        public PendingList(Schedule parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        public void setScheduleInfo(string OrNum, string customerName, string unitUsed, string services, string weights, string SchedTime, string pickUpDate, string startTime, string endTime)
        {
            //Displaying Schedule info
            ORNo.Text = OrNum;
            CustomerName.Text = customerName;
            UnitUsed.Text = unitUsed;
            Services.Text = services;
            Weights.Text = weights;

            ScheduleTime.Text = SchedTime;
            PickUpDate.Text = DateTime.Parse(pickUpDate).ToShortDateString();
            TimeLeft.Text = "-";
            ActualTime.Text = "-";

            displayBatches();
        }
        private void displayBatches()
        {
            batchesContainer.Controls.Clear();
            DataTable orders = scheduleClass.displayBatches(ORNo.Text, "Pending");
            foreach (DataRow row in orders.Rows)
            {
                BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), "",
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: -\nEnd Time: -",
                   "-", "-", "Pending", WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (scheduleClass.checkIfPending(ORNo.Text))
            {
                EditLaundry edit = new EditLaundry(ORNo.Text);
                edit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Laundry cannot be edited if one of its batch is already in-progress or finished!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this schedule?\nThis cannot be undone.", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                scheduleClass.cancelSchedule(ORNo.Text);
                _parentForm.RefreshPanel();
            }

        }
    }
}