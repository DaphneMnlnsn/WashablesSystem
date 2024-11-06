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
    public partial class MachineList : UserControl
    {
        public MachineList()
        {
            InitializeComponent();
        }

        private void MachineList_Load(object sender, EventArgs e)
        {
            if (lblMachine.Text.Equals("Washing Machine"))
            {
                Image washing = WashablesSystem.Properties.Resources.Washing_Machine;
                MachineUnitList Wmachine = new MachineUnitList();
                Wmachine.setMachineInfo("Unit I", "Available", washing);
                machineContainer.Controls.Add(Wmachine);

                MachineUnitList Wmachine2 = new MachineUnitList();
                Wmachine2.setMachineInfo("Unit II", "Available", washing);
                machineContainer.Controls.Add(Wmachine2);

                MachineUnitList Wmachine3 = new MachineUnitList();
                Wmachine3.setMachineInfo("Unit III", "Occupied", washing);
                machineContainer.Controls.Add(Wmachine3);
            }
            else if (lblMachine.Text.Equals("Dryer"))
            {
                Image dryer = WashablesSystem.Properties.Resources.Tumble_Dryer;
                MachineUnitList Wmachine = new MachineUnitList();
                Wmachine.setMachineInfo("Unit I", "Available", dryer);
                machineContainer.Controls.Add(Wmachine);

                MachineUnitList Wmachine2 = new MachineUnitList();
                Wmachine2.setMachineInfo("Unit II", "Available", dryer);
                machineContainer.Controls.Add(Wmachine2);

                MachineUnitList Wmachine3 = new MachineUnitList();
                Wmachine3.setMachineInfo("Unit III", "Available", dryer);
                machineContainer.Controls.Add(Wmachine3);
            }
            else if (lblMachine.Text.Equals("Iron"))
            {
                Image iron = WashablesSystem.Properties.Resources.Iron;
                MachineUnitList Wmachine = new MachineUnitList();
                Wmachine.setMachineInfo("Unit I", "Available", iron);
                machineContainer.Controls.Add(Wmachine);
            }
        }
        public void setMachine(string unit)
        {
            //Displaying machine name
            lblMachine.Text = unit;
        }
    }
}