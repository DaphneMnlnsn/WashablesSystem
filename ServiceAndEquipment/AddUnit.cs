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
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EquipmentClass equipmentClass = new EquipmentClass(cbEquipment.Text, txtBoxName.Text, cbStatus.Text);
            equipmentClass.addUnit();
            _parentForm.RefreshPanel();
            this.Close();
        }
    }
}
