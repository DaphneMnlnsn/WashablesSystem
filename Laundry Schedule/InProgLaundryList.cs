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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WashablesSystem
{
    public partial class InProgLaundryList : UserControl
    {
        private TimeSpan time_left;
        private DateTime end_time;
        ScheduleClass scheduleClass = new ScheduleClass();
        private bool notifDisplayed = false;
        private LaundryOperations _parentForm;
        public InProgLaundryList(LaundryOperations parentForm)
        {
            InitializeComponent();
            this._parentForm = parentForm;
        }
        public void setStatus(string orNo, string batchNo, string unit, string customer, string service, string weight, string status, string endTime)
        {
            orderNum.Text = orNo + "-";
            lblBatch.Text = batchNo;
            lblUnit.Text = unit;
            custName.Text = customer;
            serviceType.Text = service;
            lblWeight.Text = weight;
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
            SessionVariables session = new SessionVariables();
            if (timeLeft.Text.Equals("00:00:00") && notifDisplayed == false && !session.notified1)
            {
                notifDisplayed = true;
                session.notified1 = true;
                NotificationClass notificationClass = new NotificationClass();
                notificationClass.sendNotification(lblBatch.Text, "Laundry Finished");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            timeLeftTimer.Stop();
            scheduleClass.finishSchedule(lblBatch.Text);
            _parentForm.RefreshPanel();
        }
    }
}