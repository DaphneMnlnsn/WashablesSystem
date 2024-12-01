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

namespace WashablesSystem
{
    public partial class FinishedList : UserControl
    {
        Form grandparentForm;
        Form greatgrandparentForm;
        public FinishedList()
        {
            InitializeComponent();
        }
        public void setScheduleInfo(string OrNum, string customerName, string unitUsed, string services, string weights, string SchedTime, string totalDuration, string pickUpDate, string finishedOn, Image billImage)
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


        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            grandparentForm = parentForm?.ParentForm;
            greatgrandparentForm = grandparentForm?.ParentForm;
            loadForm(new Billing(new Main(), ORNo.Text));
        }
        private void loadForm(Form m)
        {
            Panel panelTab = (Panel)greatgrandparentForm.Controls.Find("panelPage", true)[0];
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
    }
}