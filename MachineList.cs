﻿using System;
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
            MachineUnitList machine = new MachineUnitList();
            machine.setMachineInfo("Unit I", "Available", "Green");
            machineContainer.Controls.Add(machine);

            MachineUnitList machine2 = new MachineUnitList();
            machine.setMachineInfo("Unit II", "Available", "Green");
            machineContainer.Controls.Add(machine2);

            MachineUnitList machine3 = new MachineUnitList();
            machine.setMachineInfo("Unit III", "Occupied", "Red");
            machineContainer.Controls.Add(machine3);
        }
        public void setMachine(string unit)
        {
            //Displaying machine name
            lblMachine.Text = unit;
        }
    }
}