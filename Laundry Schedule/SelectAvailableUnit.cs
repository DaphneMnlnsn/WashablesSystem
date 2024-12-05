using System;
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
    public partial class SelectAvailableUnit : Form
    {
        private SelectableUnitList selectedButtonControl = null;
        private string batchID = "";
        ScheduleClass scheduleClass;
        public SelectAvailableUnit(string batchID)
        {
            InitializeComponent();
            this.batchID = batchID;
            scheduleClass = new ScheduleClass();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAvailableUnit_Load(object sender, EventArgs e)
        {
            string machineType = "";
            string order_status = "";

            DateTime startTime = DateTime.Now;
            TimeSpan washTime = TimeSpan.Zero, dryTime = TimeSpan.Zero, ironTime = TimeSpan.Zero;

            DataTable orders = scheduleClass.displaySelectedOrder(batchID);
            foreach (DataRow row in orders.Rows)
            {
                order_status = row["status"].ToString();
                washTime = TimeSpan.Parse(row["wash_time"].ToString());
                dryTime = TimeSpan.Parse(row["dry_time"].ToString());
                ironTime = TimeSpan.Parse(row["iron_time"].ToString());
            }
            lblStartTime.Text = startTime.ToShortTimeString();
            if (order_status.Equals("Pending Wash"))
            {
                lblMachine.Text.Equals("Washing Machine");
                lblEndTime.Text = (startTime + washTime).ToShortTimeString();
                machineType = "Washing Machine";
            }
            else if (order_status.Equals("Pending Dry"))
            {
                lblMachine.Text.Equals("Dryer");
                lblEndTime.Text = (startTime + dryTime).ToShortTimeString();
                machineType = "Dryer";
            }
            else if (order_status.Equals("Pending Press"))
            {
                lblMachine.Text.Equals("Iron");
                lblEndTime.Text = (startTime + ironTime).ToShortTimeString();
                machineType = "Iron";
            }

            LaundryOperationsClass laundryOperationsClass = new LaundryOperationsClass();
            DataTable units = laundryOperationsClass.getUnitDetails(machineType);
            foreach (DataRow row in units.Rows)
            {
                SelectableUnitList unit = new SelectableUnitList();
                unit.setMachineInfo(row["unit_name"].ToString(), row["unit_id"].ToString(), row["availability_status"].ToString(), bool.Parse(row["occupied"].ToString()));
                unitPanel.Controls.Add(unit);
                unit.ButtonClicked += ButtonControl_ButtonClicked;
            }
        }
        private void ButtonControl_ButtonClicked(object sender, EventArgs e)
        {
            // Deselect the previously selected button, if any
            if (selectedButtonControl != null)
            {
                selectedButtonControl.DeselectButton();
            }

            // Select the clicked button
            selectedButtonControl = (SelectableUnitList)sender;
            selectedButtonControl.SelectButton();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string unitID = selectedButtonControl.getSelectedButton();
            scheduleClass.startSchedule(batchID, unitID);
            this.Close();
        }
    }
}
