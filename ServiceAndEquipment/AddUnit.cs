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
    public partial class AddUnit : Form
    {
        private ServicesAndEquipment _parentForm = new ServicesAndEquipment(new Main());

        public AddUnit(ServicesAndEquipment parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            cbEquipment.SelectedIndex = 0;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxName.Text) && !String.IsNullOrWhiteSpace(cbStatus.Text))
                {
                    EquipmentClass equipmentClass = new EquipmentClass(cbEquipment.Text, txtBoxName.Text, cbStatus.Text);
                    equipmentClass.addUnit();
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentClass equipmentClass = new EquipmentClass();
            txtBoxName.Text = equipmentClass.viewUnit(cbEquipment.Text);
        }
    }
}
