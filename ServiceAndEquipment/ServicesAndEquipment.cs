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
    public partial class ServicesAndEquipment : Form
    {
        Image edit = WashablesSystem.Properties.Resources.Create;
        Image restore = WashablesSystem.Properties.Resources.Restore;
        public ServicesAndEquipment(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Services and Equipment";
                string text = parentForm.Header;
            }
        }
        private void ServicesAndEquipment_Load(object sender, EventArgs e)
        {
            lblSE.Text = "SERVICES";
            lblRS.Text = "RATES";
            cbSE.SelectedIndex = 0;
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            ///
            /// change services to equipment page vice versa
            ///
            if (btnEquipment.Text.Equals("EQUIPMENT"))
            {
                lblSE.Text = "MACHINE NAME";
                lblRS.Text = "UNIT STATUS";
                ///
                lblHeader.Text = "Equipment";
                btnEquipment.Text = "SERVICES";
                btnAddService.Text = "+ Add Unit";
                /// change combobox items
                cbSE.Items.Clear();
                cbSE.Items.Add("WASHING MACHINE");
                cbSE.Items.Add("DRYER");
                cbSE.Items.Add("IRON");
                cbSE.Items.Add("ARCHIVE");
                cbSE.SelectedIndex = 0;
            }
            else if (btnEquipment.Text.Equals("SERVICES"))
            {
                lblSE.Text = "SERVICES";
                lblRS.Text = "RATES";
                lblHeader.Text = "Services";
                btnEquipment.Text = "EQUIPMENT";
                btnAddService.Text = "+ Add Service";
                /// change combobox items
                cbSE.Items.Clear();
                cbSE.Items.Add("WASH-DRY-FOLD");
                cbSE.Items.Add("WASH-DRY-PRESS");
                cbSE.Items.Add("ARCHIVE");
                cbSE.SelectedIndex = 0;
            }
        }
        public void check()
        {
            ///
            /// Add rows
            ///
            if (btnEquipment.Text.Equals("EQUIPMENT"))
            {
                ServiceEquipmentList row1 = new ServiceEquipmentList();
                containerSE.Controls.Clear();
                row1.setRowInfo("WDF001", "Clothes, Table Napkin, Pillowcase", "Php 28.00/kgs (5kgs min.)", "Edit", edit);
                containerSE.Controls.Add(row1);
                /// combobox selector
                switch (cbSE.Text.ToString())
                {
                    case "WASH-DRY-FOLD":
                        containerSE.Controls.Clear();
                        row1.setRowInfo("WDF001", "Clothes, Table Napkin, Pillowcase", "Php 28.00/kgs (5kgs min.)", "Edit", edit);
                        containerSE.Controls.Add(row1);

                        ServiceEquipmentList row2 = new ServiceEquipmentList();
                        row2.setRowInfo("WDF002", "Bed sheet, Table Cloth, Curtain", "Php 50.00/kgs (3kgs min.)", "Edit", edit);
                        containerSE.Controls.Add(row2);
                        break;
                    case "WASH-DRY-PRESS":
                        containerSE.Controls.Clear();
                        row1.setRowInfo("WDP001", "Clothes, Table Napkin, Pillowcase", "Php 80.00/kgs (5kgs min.)", "Edit", edit);
                        containerSE.Controls.Add(row1);

                        row2 = new ServiceEquipmentList();
                        row2.setRowInfo("WDP002", "Bedsheet, Tablecloth, Curtain", "Php 100.00/kgs (3kgs min.)", "Edit", edit);
                        containerSE.Controls.Add(row2);
                        break;
                    case "ARCHIVE":
                        containerSE.Controls.Clear();
                        row1.setRowInfo("Wash-Dry-Fold\nWDF04", "Clothes, Pillowcase", "Php 10.00/kgs (5kgs min.)", "Restore", restore);
                        containerSE.Controls.Add(row1);

                        row2 = new ServiceEquipmentList();
                        row2.setRowInfo("Wash-Dry-Fold\nWDF05", "Bedsheet, Tablecloth", "Php 200.00/kgs (3kgs min.)", "Restore", restore);
                        containerSE.Controls.Add(row2);
                        break;
                }
            }
            else if (btnEquipment.Text.Equals("SERVICES"))
            {
                ServiceEquipmentList Erow1 = new ServiceEquipmentList();
                containerSE.Controls.Clear();
                Erow1.setRowInfo("WMU1", "Unit I", "Available", "Edit", edit);
                containerSE.Controls.Add(Erow1);
                /// combobox selector
                switch (cbSE.Text.ToString())
                {
                    case "WASHING MACHINE":
                        containerSE.Controls.Clear();
                        Erow1.setRowInfo("WMU1", "Unit I", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow1);

                        ServiceEquipmentList Erow2 = new ServiceEquipmentList();
                        Erow2.setRowInfo("WMU2", "Unit II", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow2);

                        ServiceEquipmentList Erow3 = new ServiceEquipmentList();
                        Erow3.setRowInfo("WMU3", "Unit III", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow3);
                        break;
                    case "DRYER":
                        containerSE.Controls.Clear();
                        Erow1.setRowInfo("DRU1", "Unit I", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow1);

                        Erow2 = new ServiceEquipmentList();
                        Erow2.setRowInfo("DRU2", "Unit II", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow2);

                        Erow3 = new ServiceEquipmentList();
                        Erow3.setRowInfo("DRU3", "Unit III", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow3);
                        break;
                    case "IRON":
                        containerSE.Controls.Clear();
                        Erow1.setRowInfo("IR1", "Unit I", "Available", "Edit", edit);
                        containerSE.Controls.Add(Erow1);
                        break;
                    case "ARCHIVE":
                        containerSE.Controls.Clear();
                        Erow1.setRowInfo("Dryer\nDRU5", "Unit V", "Available", "Restore", restore);
                        containerSE.Controls.Add(Erow1);

                        Erow2 = new ServiceEquipmentList();
                        Erow2.setRowInfo("Washing Machine\nWMU7", "Unit VII", "Available", "Restore", restore);
                        containerSE.Controls.Add(Erow2);
                        break;
                }

            }
        }

        private void cbSE_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// row display
            check();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            switch (btnAddService.Text)
            {
                case "+ Add Service":
                    AddService addService = new AddService();
                    addService.ShowDialog();
                    break;
                case "+ Add Unit":
                    AddUnit addUnit = new AddUnit();
                    addUnit.ShowDialog();
                    break;
            }
        }
    }
}