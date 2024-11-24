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
            if (lblMachine.Text.Equals("Washing Machine"))
            {
                SelectableUnitList Wmachine = new SelectableUnitList();
                Wmachine.setMachineInfo("Unit I", "Available");
                unitPanel.Controls.Add(Wmachine);

                SelectableUnitList Wmachine2 = new SelectableUnitList();
                Wmachine2.setMachineInfo("Unit II", "Available");
                unitPanel.Controls.Add(Wmachine2);

                SelectableUnitList Wmachine3 = new SelectableUnitList();
                Wmachine3.setMachineInfo("Unit III", "Occupied");
                unitPanel.Controls.Add(Wmachine3);

                Wmachine.ButtonClicked += ButtonControl_ButtonClicked;
                Wmachine2.ButtonClicked += ButtonControl_ButtonClicked;
                Wmachine3.ButtonClicked += ButtonControl_ButtonClicked;
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
