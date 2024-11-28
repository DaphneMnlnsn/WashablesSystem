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
    public partial class ServiceEquipmentList : UserControl
    {
        public ServiceEquipmentList()
        {
            InitializeComponent();
        }

        public void setRowInfo(string code, string name, string rs, string s_or_e, string weight, string kind, Image editOrRestore)
        {
            lblCode.Text = code;
            ulblSE.Text = name;
            if (s_or_e.Equals("Service"))
            {
                ulblRS.Text = "Php " + rs + "/kgs" + " (" + weight + "kgs min.)";
            }
            else
            {
                ulblRS.Text = rs;
            }
            what.Text = kind;
            btnEdit.Image = editOrRestore;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Label lblHeader = (Label)this.FindForm().Controls.Find("lblHeader", true)[0];
            if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Services"))
            {
                EditService editService = new EditService(lblCode.Text);
                editService.ShowDialog();
            }
            else if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Equipment"))
            {
                EditUnit editUnit = new EditUnit(lblCode.Text);
                editUnit.ShowDialog();
            }
            else if (what.Text.Equals("Restore") && lblHeader.Text.Equals("Services"))
            {
                //call restore method
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore this service?\nThis will be moved to Service page.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceClass serviceClass = new ServiceClass();
                    serviceClass.restoreService(lblCode.Text);
                }
            }
            else if(what.Text.Equals("Restore") && lblHeader.Text.Equals("Equipment"))
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore this unit?\nThis will be moved to Equipment Page.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EquipmentClass equipmentClass = new EquipmentClass();
                    equipmentClass.restoreUnit(lblCode.Text);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Label lblHeader = (Label)this.FindForm().Controls.Find("lblHeader", true)[0];

            if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Services"))
            {
                //call archive method
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?\nThis will be moved to the service archive.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceClass serviceClass = new ServiceClass();
                    serviceClass.archiveService(lblCode.Text);
                }
            }
            else if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Equipment"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this unit?\nThis will be moved to the unit archive.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EquipmentClass equipmentClass = new EquipmentClass();
                    equipmentClass.archiveUnit(lblCode.Text);
                }
            }
            else if (what.Text.Equals("Restore") && lblHeader.Text.Equals("Services"))
            {
                //call delete method
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?\nThis will be deleted permanently.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceClass serviceClass = new ServiceClass();
                    serviceClass.deleteService(lblCode.Text);
                }
            }
            else if(what.Text.Equals("Restore") && lblHeader.Text.Equals("Equipment"))
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this unit?\nThis will be deleted permanently.", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EquipmentClass equipmentClass = new EquipmentClass();
                    equipmentClass.deleteUnit(lblCode.Text);
                }
            }
        }
    }
}