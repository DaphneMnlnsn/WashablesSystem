﻿using System;
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
    public partial class Schedule : Form
    {
        string openedForm = "In Progress";
        public Schedule(Main parentForm, string openedForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Schedule";
                string text = parentForm.Header;
            }

            this.openedForm = openedForm;
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            if (openedForm.Equals("Finished"))
            {
                displayFinished();
            }
            else
            {
                displayInProgress();
            }

        }
        private void loadForm(Form m)
        {
            if (this.panelTab.Controls.Count > 0)
            {
                this.panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panelTab.Controls.Add(m);
            this.panelTab.Tag = m;
            m.Show();
        }
        private void displayInProgress()
        {
            panelTab.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayInProgress("Wash In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                InProgressList inProg = new InProgressList(this);
                inProg.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                   + row["laundry_endTime"].ToString(), row["pickup_date"].ToString(),
                   row["laundry_startTime"].ToString(), row["laundry_endTime"].ToString(),
                   WashablesSystem.Properties.Resources.Pause, WashablesSystem.Properties.Resources.Cancel);
                panelTab.Controls.Add(inProg);
            }

            orders = scheduleClass.displayInProgress("Dry In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                InProgressList inProg = new InProgressList(this);
                inProg.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                   + row["laundry_endTime"].ToString(), row["pickup_date"].ToString(),
                   row["laundry_startTime"].ToString(), row["laundry_endTime"].ToString(),
                   WashablesSystem.Properties.Resources.Pause, WashablesSystem.Properties.Resources.Cancel);
                panelTab.Controls.Add(inProg);
            }
            orders = scheduleClass.displayInProgress("Press In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                InProgressList inProg = new InProgressList(this);
                inProg.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                   + row["laundry_endTime"].ToString(), row["pickup_date"].ToString(),
                   row["laundry_startTime"].ToString(), row["laundry_endTime"].ToString(),
                   WashablesSystem.Properties.Resources.Pause, WashablesSystem.Properties.Resources.Cancel);
                panelTab.Controls.Add(inProg);
            }
        }
        private void displayPending()
        {
            panelTab.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayPending();
            foreach (DataRow row in orders.Rows)
            {
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                PendingList pending = new PendingList(this);
                pending.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                   "-", row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: -" + "\nEnd Time: -", row["pickup_date"].ToString(), "-",
                   "-");
                panelTab.Controls.Add(pending);
            }
        }
        private void displayFinished()
        {
            panelTab.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayFinished();
            foreach (DataRow row in orders.Rows)
            {
                FinishedList finished = new FinishedList(this);
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                finished.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                   row["unit_id"].ToString() + "\n" + row["unit_id2"].ToString() + "\n" + row["unit_id3"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                   total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                   + row["laundry_endTime"].ToString(), scheduleClass.computeTotalDuration().ToString(@"hh\:mm\:ss"), row["pickup_date"].ToString(),
                   row["finished_on"].ToString(), "Finished", WashablesSystem.Properties.Resources.Bill);
                panelTab.Controls.Add(finished);
            }
        }
        private void displayPickedUp()
        {
            panelTab.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayPickedUp();
            foreach (DataRow row in orders.Rows)
            {
                FinishedList pickedUp = new FinishedList(this);
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                pickedUp.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                   row["unit_name"].ToString(), total_weight.ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                    "Time Scheduled: " + row["scheduled_time"].ToString()
                   + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                   + row["laundry_endTime"].ToString(), TimeSpan.Parse(row["laundry_totalDuration"].ToString()).ToString(@"hh\:mm\:ss"), row["pickup_date"].ToString(),
                   row["finished_on"].ToString(), "Picked-Up", WashablesSystem.Properties.Resources.Bill);
                panelTab.Controls.Add(pickedUp);
            }
        }
        private void displayCancelled()
        {
            panelTab.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayCancelled();
            foreach (DataRow row in orders.Rows)
            {
                decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                ArchiveSchedList cancelled = new ArchiveSchedList();
                cancelled.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                   row["unit_name"].ToString(), row["service_category"] + "\n" + row["service_name"].ToString(),
                   total_weight.ToString(), row["scheduled_time"].ToString(), row["pickup_date"].ToString());
                panelTab.Controls.Add(cancelled);
            }
        }
        private void btnInProgress_Click(object sender, EventArgs e)
        {
            loadForm(new InProgressSched());
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            loadForm(new PendingSched());
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            loadForm(new FinishedSched(this));
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            loadForm(new ArchiveSched());
        }

        private void btnAddLaundry_Click(object sender, EventArgs e)
        {
            AddLaundry laundryForm = new AddLaundry();
            laundryForm.ShowDialog();
        }

        private void cbFilter_Load(object sender, EventArgs e)
        {

        }

        private void cbFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem.ToString().Equals("In-Progress"))
            {
                lblHeader.Text = "In-Progress Laundry";
                finishedLayout.Visible = false;
                displayInProgress();
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Pending"))
            {
                lblHeader.Text = "Pending Laundry";
                finishedLayout.Visible = false;
                displayPending();
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Finished"))
            {
                lblHeader.Text = "Finished Laundry";
                finishedLayout.Visible = true;
                displayFinished();
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Picked-Up"))
            {
                lblHeader.Text = "Picked-Up Laundry";
                finishedLayout.Visible = true;
                displayPickedUp();
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Cancelled"))
            {
                lblHeader.Text = "Cancelled Laundry";
                finishedLayout.Visible = false;
                displayCancelled();
            }
        }

        public void RefreshPanel()
        {
            this.Customers_Load(null, null);
        }

        private void cbSortFinished_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Texts.Equals("Pending"))
            {
                panelTab.Controls.Clear();
                ScheduleClass scheduleClass = new ScheduleClass();
                DataTable orders = scheduleClass.displayPendingSort(cbSortFinished.SelectedIndex);
                foreach (DataRow row in orders.Rows)
                {
                    decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                    PendingList pending = new PendingList(this);
                    pending.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                       "-", row["service_category"] + "(" + row["service_name"].ToString() + ")",
                       total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                       + "\nStart Time: -" + "\nEnd Time: -", row["pickup_date"].ToString(), "-",
                       "-");
                    panelTab.Controls.Add(pending);
                }
            }
            else if (cbFilter.Texts.Equals("Finished"))
            {
                panelTab.Controls.Clear();
                ScheduleClass scheduleClass = new ScheduleClass();
                DataTable orders = scheduleClass.displayFinishedSort(cbSortFinished.SelectedIndex);
                foreach (DataRow row in orders.Rows)
                {
                    FinishedList finished = new FinishedList(this);
                    decimal total_weight = decimal.Parse(row["weight"].ToString()) + decimal.Parse(row["weight2"].ToString()) + decimal.Parse(row["weight3"].ToString());
                    finished.setScheduleInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                       row["unit_id"].ToString() + "\n" + row["unit_id2"].ToString() + "\n" + row["unit_id3"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                       total_weight.ToString(), "Time Scheduled: " + row["scheduled_time"].ToString()
                       + "\nStart Time: " + row["laundry_startTime"].ToString() + "\nEnd Time: "
                       + row["laundry_endTime"].ToString(), scheduleClass.computeTotalDuration().ToString(@"hh\:mm\:ss"), row["pickup_date"].ToString(),
                       row["finished_on"].ToString(), "Finished", WashablesSystem.Properties.Resources.Bill);
                    panelTab.Controls.Add(finished);
                }
            }

        }
    }
}
