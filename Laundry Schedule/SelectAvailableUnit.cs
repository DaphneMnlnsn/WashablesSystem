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
        public SelectAvailableUnit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAvailableUnit_Load(object sender, EventArgs e)
        {
            string machineType = "";
            if (lblMachine.Text.Equals("Washing Machine"))
            {
                machineType = "Washing Machine";
            }
            if (lblMachine.Text.Equals("Dryer"))
            {
                machineType = "Dryer";
            }
            if (lblMachine.Text.Equals("Iron"))
            {
                machineType = "Iron";
            }

            LaundryOperationsClass laundryOperationsClass = new LaundryOperationsClass();
            DataTable units = laundryOperationsClass.getUnitDetails(machineType);
            foreach (DataRow row in units.Rows)
            {
                SelectableUnitList unit = new SelectableUnitList();
                unit.setMachineInfo(row["unit_name"].ToString(), row["availability_status"].ToString(), bool.Parse(row["occupied"].ToString()));
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
    }
}
