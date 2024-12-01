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
        public void setMachineInfo(string unitName, string availability, bool occupied, string machine, Image picture)
        {
            //Displaying machine info
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
            }
            else if (availability.Equals("Not Available"))
            {
                btnAvailability.BackColor = Color.FromArgb(217, 217, 217);
                btnAvailability.Text = "Not Available";
                btnAvailability.Enabled = false;
            }

        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            AddLaundry addLaundry = new AddLaundry(machineType.Text, lblUnit.Text);
            addLaundry.ShowDialog();
        }
    }
}