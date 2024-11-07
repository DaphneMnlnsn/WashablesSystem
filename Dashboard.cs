using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class Dashboard : Form
    {
        Form thisParentForm;
        public Dashboard(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Dashboard";
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            activityLogItem activity = new activityLogItem();
            //string message = "Staff " + row["employee_num"] + " " + row["activity_performed"] + " at " + DateTime.Parse(row["activity_time"].ToString()).ToString() + ".";
            string message = "Roxanne Rose finished a laundry order at 10/13/2024 5:12PM";
            activity.setActivity(message);
            activityPanel.Controls.Add(activity);

            activityLogItem activity2 = new activityLogItem();
            string message2 = "Roxanne Rose started a laundry order at 10/13/2024 5:12PM";
            activity2.setActivity(message2);
            activityPanel.Controls.Add(activity2);

            activityLogItem activity3 = new activityLogItem();
            string message3 = "Roxanne Rose scheduled a laundry order at 10/13/2024 5:12PM";
            activity3.setActivity(message3);
            activityPanel.Controls.Add(activity3);

            setChartSales();
            setChartKgs();
            setChartServices();
        }

        private void setChartSales()
        {
            this.chartSales.Series["Series1"].Points.AddXY("Week 1", 90);
            this.chartSales.Series["Series1"].Points.AddXY("Week 2", 80);
            this.chartSales.Series["Series1"].Points.AddXY("Week 3", 50);
            this.chartSales.Series["Series1"].Points.AddXY("Week 4", 90);
            this.chartSales.Series["Series1"].Points.AddXY("Week 5", 85);
        }

        private void setChartKgs()
        {
            this.chartKgs.Series["Unit I"].Points.AddXY("Monday", 30);
            this.chartKgs.Series["Unit I"].Points.AddXY("Tuesday", 40);
            this.chartKgs.Series["Unit I"].Points.AddXY("Wednesday", 10);
            this.chartKgs.Series["Unit I"].Points.AddXY("Thursday", 20);
            this.chartKgs.Series["Unit I"].Points.AddXY("Friday", 35);
            this.chartKgs.Series["Unit I"].Points.AddXY("Saturday", 40);
            this.chartKgs.Series["Unit I"].Points.AddXY("Sunday", 25);

            this.chartKgs.Series["Unit II"].Points.AddXY("Monday", 20);
            this.chartKgs.Series["Unit II"].Points.AddXY("Tuesday", 30);
            this.chartKgs.Series["Unit II"].Points.AddXY("Wednesday", 20);
            this.chartKgs.Series["Unit II"].Points.AddXY("Thursday", 10);
            this.chartKgs.Series["Unit II"].Points.AddXY("Friday", 25);
            this.chartKgs.Series["Unit II"].Points.AddXY("Saturday", 30);
            this.chartKgs.Series["Unit II"].Points.AddXY("Sunday", 15);

            this.chartKgs.Series["Unit III"].Points.AddXY("Monday", 10);
            this.chartKgs.Series["Unit III"].Points.AddXY("Tuesday", 20);
            this.chartKgs.Series["Unit III"].Points.AddXY("Wednesday", 5);
            this.chartKgs.Series["Unit III"].Points.AddXY("Thursday", 12);
            this.chartKgs.Series["Unit III"].Points.AddXY("Friday", 25);
            this.chartKgs.Series["Unit III"].Points.AddXY("Saturday", 32);
            this.chartKgs.Series["Unit III"].Points.AddXY("Sunday", 2);
        }

        private void setChartServices()
        {
            chartServices.Series["Series1"].Points.AddXY("Wash", "33");
            chartServices.Series["Series1"].Points.AddXY("Dry", "35");
            chartServices.Series["Series1"].Points.AddXY("Wash-Dry-Fold", "23");
            chartServices.Series["Series1"].Points.AddXY("Wash-Dry-Press", "13");
            chartServices.Series["Series1"].Points.AddXY("Dry Clean", "3");
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            thisParentForm = this.ParentForm;
            loadForm(new Users(new Main(), "Activity Log"));
        }
        private void loadForm(Form m)
        {
            Panel panelTab = (Panel)thisParentForm.Controls.Find("panelPage", true)[0];
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.ShowDialog();
        }
    }
}
