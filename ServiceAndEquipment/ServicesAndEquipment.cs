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
    public partial class ServicesAndEquipment : Form
    {
        Image edit = WashablesSystem.Properties.Resources.Create;
        Image restore = WashablesSystem.Properties.Resources.Restore;
        ServiceClass service;
        EquipmentClass equipmentU;
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
            ///
            /// call display event
            /// 
            cbSE_SelectedIndexChanged(sender, e);
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
                ///
                /// EQUIPMENT DISPLAY
                ///
                containerSE.Controls.Clear();
                if (cbSE.Text.Equals("ARCHIVE"))
                {
                    EquipmentClass equipmentArchive = new EquipmentClass();
                    DataTable users = equipmentArchive.displayUnitArchive();
                    foreach (DataRow row in users.Rows)
                    {
                        ServiceEquipmentList archive = new ServiceEquipmentList(this);
                        archive.setRowInfo(row["unit_id"].ToString(), row["unit_name"].ToString(),
                          row["availability_status"].ToString(), "Equipment", "", "Restore", WashablesSystem.Properties.Resources.Restore);
                        containerSE.Controls.Add(archive);
                    }
                }
                else
                {
                    equipmentU = new EquipmentClass(cbSE.Text);
                    DataTable equipment = equipmentU.displayUnit(cbSE.Text);
                    foreach (DataRow row in equipment.Rows)
                    {
                        ServiceEquipmentList equipmentList = new ServiceEquipmentList(this);
                        equipmentList.setRowInfo(row["unit_id"].ToString(), row["unit_name"].ToString(),
                          row["availability_status"].ToString(), "Equipment", "", "Edit", WashablesSystem.Properties.Resources.Create);
                        containerSE.Controls.Add(equipmentList);
                    }
                }
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
                ///
                /// services display
                /// 
                containerSE.Controls.Clear();
                service = new ServiceClass(cbSE.Text);
                DataTable services = service.displayService();
                foreach (DataRow row in services.Rows)
                {
                    ServiceEquipmentList serviceList = new ServiceEquipmentList(this);
                    serviceList.setRowInfo(row["service_id"].ToString(), row["service_name"].ToString(),
                       row["service_rate"].ToString(), "Service", row["service_minWeight"].ToString(),
                       "Edit", WashablesSystem.Properties.Resources.Create);
                    containerSE.Controls.Add(serviceList);
                }
            }
        }
        public void check()
        {
            ///
            /// Add rows
            ///
            if (btnEquipment.Text.Equals("EQUIPMENT"))
            {
                ///
                /// display services
                /// 
                containerSE.Controls.Clear();

                if (cbSE.Text.Equals("ARCHIVE"))
                {
                    ServiceClass serviceArchive = new ServiceClass();
                    DataTable service = serviceArchive.displayServiceArchive();
                    foreach (DataRow row in service.Rows)
                    {
                        ServiceEquipmentList archive = new ServiceEquipmentList(this);
                        archive.setRowInfo(row["service_id"].ToString(), row["service_name"].ToString(),
                            row["service_rate"].ToString(), "Service", row["service_minWeight"].ToString(),
                            "Restore", WashablesSystem.Properties.Resources.Restore);
                        containerSE.Controls.Add(archive);
                    }
                }
                else
                {
                    service = new ServiceClass(cbSE.Text);
                    DataTable services = service.displayService();
                    foreach (DataRow row in services.Rows)
                    {
                        ServiceEquipmentList serviceList = new ServiceEquipmentList(this);
                        serviceList.setRowInfo(row["service_id"].ToString(), row["service_name"].ToString(),
                           row["service_rate"].ToString(), "Service", row["service_minWeight"].ToString(),
                           "Edit", WashablesSystem.Properties.Resources.Create);
                        containerSE.Controls.Add(serviceList);
                    }
                }

            }
            else if (btnEquipment.Text.Equals("SERVICES"))
            {
                ///
                /// display equipment
                /// 
                containerSE.Controls.Clear();

                if (cbSE.Text.Equals("ARCHIVE"))
                {
                    EquipmentClass equipmentArchive = new EquipmentClass();
                    DataTable users = equipmentArchive.displayUnitArchive();
                    foreach (DataRow row in users.Rows)
                    {
                        ServiceEquipmentList archive = new ServiceEquipmentList(this);
                        archive.setRowInfo(row["unit_id"].ToString(), row["unit_name"].ToString(),
                          row["availability_status"].ToString(), "Equipment", "", "Restore", WashablesSystem.Properties.Resources.Restore);
                        containerSE.Controls.Add(archive);
                    }
                }
                else
                {
                    equipmentU = new EquipmentClass(cbSE.Text);
                    DataTable equipment = equipmentU.displayUnit(cbSE.Text);
                    foreach (DataRow row in equipment.Rows)
                    {
                        ServiceEquipmentList equipmentList = new ServiceEquipmentList(this);
                        equipmentList.setRowInfo(row["unit_id"].ToString(), row["unit_name"].ToString(),
                          row["availability_status"].ToString(), "Equipment", "", "Edit", WashablesSystem.Properties.Resources.Create);
                        containerSE.Controls.Add(equipmentList);
                    }
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
        public void RefreshPanel()
        {
            containerSE.Refresh();
        }
    }
}