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
    public partial class MachineList : UserControl
    {
        public MachineList()
        {
            InitializeComponent();
        }

        private void MachineList_Load(object sender, EventArgs e)
        {
            string machineType = "";
            Image machine = WashablesSystem.Properties.Resources.Washing_Machine;
            if (lblMachine.Text.Equals("Washing Machine"))
            {
                machineType = "Washing Machine";
                machine = WashablesSystem.Properties.Resources.Washing_Machine;
            }
            else if (lblMachine.Text.Equals("Dryer"))
            {
                machineType = "Dryer";
                machine = WashablesSystem.Properties.Resources.Tumble_Dryer;
            }
            else if (lblMachine.Text.Equals("Iron"))
            {
                machineType = "Iron";
                machine = WashablesSystem.Properties.Resources.Iron;
            }
            LaundryOperationsClass laundryOperationsClass = new LaundryOperationsClass();
            DataTable units = laundryOperationsClass.getUnitDetails(machineType);
            foreach (DataRow row in units.Rows)
            {
                MachineUnitList unit = new MachineUnitList();
                unit.setMachineInfo(row["unit_name"].ToString(), row["availability_status"].ToString(),
                   bool.Parse(row["occupied"].ToString()),machineType, machine);
                machineContainer.Controls.Add(unit);
            }
        }
        public void setMachine(string unit)
        {
            //Displaying machine name
            lblMachine.Text = unit;
        }
    }
}