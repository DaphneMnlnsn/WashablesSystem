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
    public partial class SelectableUnitList : UserControl
    {
        string availabilityStatus;
        bool unitOccupied;
        public event EventHandler ButtonClicked;
        public SelectableUnitList()
        {
            InitializeComponent();

            btnUnit.Click += btnUnit_Click;
        }
        public void setMachineInfo(string unitName, string unitID, string availability_status, bool occupied)
        {
            //Displaying machine info
            btnUnit.Text = unitName;
            lblUnit.Text = unitID;
            unitOccupied = occupied;
            availabilityStatus = availability_status;

            if (!occupied && availability_status.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(117, 238, 131);
            }
            else if (occupied && availability_status.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(255, 0, 0);
                btnUnit.Enabled = false;
            }
            else if (availability_status.Equals("Not Available"))
            {
                btnUnit.BackColor = Color.FromArgb(217, 217, 217);
                btnUnit.Enabled = false;
            }
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            // Notify parent that the button was clicked
            ButtonClicked?.Invoke(this, e);
        }
        public void SelectButton()
        {
            btnUnit.BackColor = Color.FromArgb(34, 56, 97);
            btnUnit.ForeColor = Color.White;
        }

        public string getSelectedButton()
        {
            return lblUnit.Text;
        }

        // Method to unselect the button
        public void DeselectButton()
        {
            if (!unitOccupied && availabilityStatus.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(117, 238, 131);
            }
            else if (unitOccupied && availabilityStatus.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(255, 0, 0);
                btnUnit.Enabled = false;
            }
            else if (availabilityStatus.Equals("Not Available"))
            {
                btnUnit.BackColor = Color.FromArgb(217, 217, 217);
                btnUnit.Enabled = false;
            }
            btnUnit.ForeColor = Color.Black;
        }

        private void btnUnit_ControlAdded(object sender, ControlEventArgs e)
        {


        }
    }
}
