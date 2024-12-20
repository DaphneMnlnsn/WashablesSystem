﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class MachineUnitList : UserControl
    {
        public MachineUnitList()
        {
            InitializeComponent();
        }
        public void setMachineInfo(string unitID, string unitName, string availability, bool occupied, string machine, Image picture)
        {
            //Displaying machine info
            lblunitID.Text = unitID;
            lblUnit.Text = unitName;
            btnAvailability.Text = availability;
            unitPicture.Image = picture;
            machineType.Text = machine;

            if (availability.Equals("Available") && !occupied)
            {
                btnAvailability.BackColor = Color.FromArgb(117, 238, 131);
                btnAvailability.Enabled = true;
            }
            else if (occupied)
            {
                btnAvailability.BackColor = Color.FromArgb(255, 0, 0);
                btnAvailability.Text = "Occupied";
                btnAvailability.Enabled = false;
                if(machine.Equals("Washing Machine"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.OccupiedWasher;
                }
                else if (machine.Equals("Dryer"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.OccupiedDryer;
                }
                else if (machine.Equals("Iron"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.OccupiedIron;
                }
            }
            else if (availability.Equals("Not Available"))
            {
                btnAvailability.BackColor = Color.FromArgb(217, 217, 217);
                btnAvailability.Text = "Not Available";
                btnAvailability.Enabled = false;
                if (machine.Equals("Washing Machine"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.NotAvailableWasher;
                }
                else if (machine.Equals("Dryer"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.NotAvailableDryer;
                }
                else if (machine.Equals("Iron"))
                {
                    unitPicture.Image = WashablesSystem.Properties.Resources.NotAvailableIron;
                }
            }
            else if (machineType.Equals("Iron"))
            {
                btnAvailability.Enabled = false;
            }
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            AddLaundry addLaundry = new AddLaundry(lblunitID.Text, machineType.Text, lblUnit.Text);
            addLaundry.ShowDialog();
        }
    }
}