using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WashablesSystem.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WashablesSystem
{
    public partial class Dashboard : Form
    {
        Form thisParentForm;
        DashboardClass dashboardClass;
        SessionVariables sessionVariables = new SessionVariables();
        bool userAccess;
        public Dashboard(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Dashboard";
            }
            dashboardClass = new DashboardClass();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserClass userClass = new UserClass();
            DataTable user = userClass.displaySelectedUser(sessionVariables.loggedIn);
            foreach (DataRow row in user.Rows)
            {
                userAccess = bool.Parse(row["user_access"].ToString());
            }

            DataTable log = dashboardClass.generateActLog();
            foreach (DataRow row in log.Rows)
            {
                activityLogItem logList = new activityLogItem();
                logList.setActivity(row["username"].ToString() + " " +
                   row["activity"].ToString() + " at " + row["activity_date"].ToString());
                activityPanel.Controls.Add(logList);
            }

            cbTimeSales.SelectedIndex = 0;
            cbTimeKilos.SelectedIndex = 0;
            cbMachine.SelectedIndex = 0;
            cbTimeServices.SelectedIndex = 0;

            setChartSales();
            setChartKgs();
            setChartServices();
        }

        private void setChartSales()
        {
            Dictionary<string, decimal> filteredSales = dashboardClass.generateSales(cbTimeSales.SelectedItem.ToString());

            chartSales.Series.Clear();
            var series = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.ForestGreen
            };

            foreach (var data in filteredSales)
            {
                series.Points.AddXY(data.Key, data.Value);
            }

            chartSales.Series.Add(series);
        }

        private void setChartKgs()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            string machineType = cbMachine.SelectedItem.ToString();

            switch (cbTimeKilos.SelectedItem.ToString())
            {
                case "This Week":
                    startDate = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
                    endDate = startDate.AddDays(7);
                    break;
                case "This Month":
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    endDate = startDate.AddMonths(1);
                    break;
                case "This Year":
                    startDate = new DateTime(DateTime.Now.Year, 1, 1);
                    endDate = startDate.AddYears(1);
                    break;
            }

            Dictionary<string, List<decimal>> unitData = dashboardClass.generateUnitUsed(startDate, endDate, machineType);

            this.chartKgs.Series.Clear();
            int colorIndex = 0;

            foreach (var unit in unitData)
            {
                string unitName = unit.Key;
                List<decimal> weights = unit.Value;

                if (weights != null && weights.Count > 0 && !unitName.Equals(""))
                {
                    Series series = new Series(unitName)
                    {
                        ChartType = SeriesChartType.Column,
                        Color = getColorForIndex(colorIndex),
                    };

                    for (int i = 0; i < weights.Count; i++)
                    {
                        series.Points.AddXY(i + 1, weights[i]);
                    }

                    this.chartKgs.Series.Add(series);
                    colorIndex++;
                }
            }
        }

        private Color getColorForIndex(int index)
        {
            Color[] colors = new Color[] { Color.ForestGreen, Color.LightBlue, Color.PaleGreen, Color.LightGoldenrodYellow, Color.Thistle, Color.Pink, Color.Lavender, Color.LightCoral, Color.PaleTurquoise, Color.LightSkyBlue };
            return colors[index % colors.Length];
        }

        private void setChartServices()
        {
            var serviceData = dashboardClass.generateServices(cbTimeServices.SelectedItem.ToString());
            this.chartServices.Series.Clear();

            Series pieSeries = new Series
            {
                Name = "Services",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie,
                BorderWidth = 0
            };
            foreach (var service in serviceData)
            {
                string serviceName = service.Key;
                int serviceCount = service.Value;

                pieSeries.Points.AddXY(serviceName, serviceCount);
                pieSeries.Points[pieSeries.Points.Count - 1].IsValueShownAsLabel = true; // Show value as label
            }
            chartServices.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartServices.Series.Add(pieSeries);
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            if (userAccess)
            {
                loadForm(new Users(new Main(), "Activity Log"));
            }
            else
            {
                MessageBox.Show("You do not have access to this page!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void loadForm(Form m)
        {
            thisParentForm = this.ParentForm;
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
            loadForm(new Reports(new Main()));
        }

        private void cbTimeSales_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setChartSales();
        }

        private void cbMachine_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMachine.SelectedItem != null)
            {
                setChartKgs();
            }
            else
            {
                cbTimeKilos.SelectedIndex = 0;
                cbMachine.SelectedIndex = 0;
            }
        }

        private void cbTimeServices_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setChartServices();
        }
    }
}
