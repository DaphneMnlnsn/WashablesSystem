using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WashablesSystem.Classes;
using WashablesSystem.Laundry_Schedule;

namespace WashablesSystem
{
    public partial class FinishedList : UserControl
    {
        Form grandparentForm;
        Form greatgrandparentForm;
        Schedule _parentForm;
        private string status;
        public FinishedList(Schedule parentForm)
        {
            grandparentForm = parentForm?.ParentForm;
            InitializeComponent();
            _parentForm = parentForm;
        }
        public void setScheduleInfo(string OrNum, string customerName, string unitUsed, string services, string weights, string SchedTime, string totalDuration, string pickUpDate, string finishedOn, string status, Image billImage)
        {
            //Displaying Schedule info
            ORNo.Text = OrNum;
            CustomerName.Text = customerName;
            UnitUsed.Text = unitUsed;
            Services.Text = services;
            Weights.Text = weights;

            ScheduleTime.Text = SchedTime;
            actualTime.Text = totalDuration;
            PickUpDate.Text = DateTime.Parse(pickUpDate).ToShortDateString();
            btnBill.Image = billImage;
            FinishedOn.Text = finishedOn;

            if (status.Equals("Picked-Up"))
            {
                btnPickedUp.Visible = false;
            }
            displayBatches();
        }
        private void displayBatches()
        {
            batchesContainer.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayBatches(ORNo.Text, "Finished");
            foreach (DataRow row in orders.Rows)
            {
                BatchList batch = new BatchList();
                batch.setScheduleInfo(row["batch_id"].ToString(), row["unit_id"].ToString() + "\n" + row["unit_id2"].ToString() + "\n" + row["unit_id3"].ToString(),
                    row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   row["weight"].ToString(), "Start Time: " + row["start_time"].ToString() + "\nEnd Time: "
                   + row["end_time"].ToString(), row["total_duration"].ToString(), row["finished_on"].ToString(), "Finished",
                   WashablesSystem.Properties.Resources.Pause);
                batchesContainer.Controls.Add(batch);
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            grandparentForm = parentForm?.ParentForm;
            loadForm(new Billing(new Main(), ORNo.Text));
        }
        private void loadForm(Form m)
        {
            Panel panelTab = (Panel)grandparentForm.Controls.Find("panelPage", true)[0];
            if (panelTab.Controls.Count > 0)
            {
                panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panelTab.Controls.Add(m);
            panelTab.Tag = m;
            m.Show();
        }

        private void btnPickedUp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to mark this schedule as picked up?\nThis cannot be undone.", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ScheduleClass scheduleClass = new ScheduleClass();
                scheduleClass.markPickUp(ORNo.Text);
                _parentForm.RefreshPanel();
            }

        }
    }
}