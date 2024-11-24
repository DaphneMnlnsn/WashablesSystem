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
        string unitAvailability;
        public event EventHandler ButtonClicked;
        public SelectableUnitList()
        {
            InitializeComponent();
            btnUnit.Click += btnUnit_Click;
        }
        public void setMachineInfo(string unitName, string availability)
        {
            //Displaying machine info
            btnUnit.Text = unitName;
            unitAvailability = availability;

            if (availability.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(117, 238, 131);
            }
            else if (availability.Equals("Occupied"))
            {
                btnUnit.BackColor = Color.FromArgb(255, 0, 0);
                btnUnit.Enabled = false;
            }
            else if (availability.Equals("Not Available"))
            {
                btnUnit.BackColor = Color.FromArgb(217, 217, 217);
                btnUnit.Enabled= false;
            }
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            // Notify parent that the button was clicked
            ButtonClicked?.Invoke(this, e);
        }
        public void SelectButton()
        {
            btnUnit.BackColor = Color.FromArgb(34,56,97);
            btnUnit.ForeColor = Color.White;
        }

        // Method to unselect the button
        public void DeselectButton()
        {
            if (unitAvailability.Equals("Available"))
            {
                btnUnit.BackColor = Color.FromArgb(117, 238, 131);
            }
            else if (unitAvailability.Equals("Occupied"))
            {
                btnUnit.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (unitAvailability.Equals("Not Available"))
            {
                btnUnit.BackColor = Color.FromArgb(217, 217, 217);
            }
            btnUnit.ForeColor = Color.Black;
        }
    }
}
