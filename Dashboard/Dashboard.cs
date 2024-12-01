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

        // Set the date range based on the selected filter
        switch (cbTimeKilos.SelectedItem.ToString())
        {
            case "This Week":
                startDate = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek); // Start of the week (Sunday)
                endDate = startDate.AddDays(7); // End of the week (Saturday)
                break;
            case "This Month":
                startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Start of the current month
                endDate = startDate.AddMonths(1); // Start of the next month
                break;
            case "This Year":
                startDate = new DateTime(DateTime.Now.Year, 1, 1); // Start of the current year
                endDate = startDate.AddYears(1); // Start of the next year
                break;
        }

        // Fetch data based on the filter and machine type
        Dictionary<string, List<decimal>> unitData = dashboardClass.generateUnitUsed(startDate, endDate, machineType);

        // Clear any existing series from the chart
        this.chartKgs.Series.Clear();
        int colorIndex = 0;

        // Add series for each unit if there is data
        foreach (var unit in unitData)
        {
            string unitName = unit.Key;
            List<decimal> weights = unit.Value;

            // Only add the series if it contains data
            if (weights != null && weights.Count > 0)
            {
                // Create a new series for this unit
                Series series = new Series(unitName)
                {
                    ChartType = SeriesChartType.Column,
                    Color = GetColorForIndex(colorIndex),
                };

                // Add data points to the series
                for (int i = 0; i < weights.Count; i++)
                {
                    series.Points.AddXY(i + 1, weights[i]); // X: day (or unit index), Y: weight
                }

                // Add the series to the chart
                this.chartKgs.Series.Add(series);
                colorIndex++;
            }
        }

        /*chartKgs.Series.Clear();
        DataTable filteredWeight = dashboardClass.generateUnitUsed(cbMachine.SelectedItem.ToString(), cbTimeKilos.SelectedItem.ToString());

        var series = new Series("kgs")
        {
            ChartType = SeriesChartType.Column,
            Color = Color.ForestGreen
        };

        foreach (DataRow row in filteredWeight.Rows)
        {
            string unit = row["unit_name"].ToString();
            decimal totalWeight = decimal.Parse(row["TotalWeight"].ToString());
            series.Points.AddXY(unit, totalWeight);
        }

        chartKgs.Series.Add(series);*/
        }

        private Color GetColorForIndex(int index)
        {
            // Return different colors for each series (Unit I, Unit II, Unit III, etc.)
            Color[] colors = new Color[] { Color.ForestGreen, Color.Green, Color.LightSeaGreen, Color.Cyan, Color.DarkGreen };
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
            this.chartServices.Series.Add(pieSeries);
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            loadForm(new Users(new Main(), "Activity Log"));
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
