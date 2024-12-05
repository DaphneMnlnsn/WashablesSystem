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
    public partial class EditUnit : Form
    {
        private string unit_selected;
        private ServicesAndEquipment _parentForm = new ServicesAndEquipment(new Main());
        public EditUnit(ServicesAndEquipment parentForm, string unitSelected)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.unit_selected = unitSelected;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUnit_Load(object sender, EventArgs e)
        {
            //call displayselectedinfo method here
            EquipmentClass equipmentClass = new EquipmentClass();
            DataTable equipmentInfo = new DataTable();
            equipmentInfo = equipmentClass.displaySelectedUnit(unit_selected);

            foreach (DataRow row in equipmentInfo.Rows)
            {
                cbEquipment.Text = row["unit_category"].ToString();
                txtBoxName.Text = row["unit_name"].ToString();
                cbStatus.Text = row["availability_status"].ToString();              
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //call edit method here
                EquipmentClass equipmentClass = new EquipmentClass(cbEquipment.Text, txtBoxName.Text, cbStatus.Text);
                equipmentClass.editUnit(unit_selected);
                _parentForm.RefreshPanel();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
