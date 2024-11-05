using System;
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
        public void setMachineInfo(string unitName, string availability, string availabilityColor)
        {
            //Displaying machine info
            lblUnit.Text = unitName;
            btnAvailability.Text = availability;
            if (availabilityColor.Equals("Green"))
            {
                btnAvailability.BackColor = Color.FromArgb(117, 238, 131);
            }
            else if (availabilityColor.Equals("Red"))
            {
                btnAvailability.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                btnAvailability.BackColor = Color.FromArgb(217, 217, 217);
            }

        }
    }
}