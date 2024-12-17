using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class AddLaundry : Form
    {
        bool specificUnit;
        string unitSelected;
        LaundryOperations _parentForm;
        public AddLaundry(LaundryOperations parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            pickupDate.MinDate = DateTime.Now;
            timeDryer1.Checked = true;
            timeWashing1.Checked = true;
            timeIron1.Checked = true;
        }
        public AddLaundry()
        {
            InitializeComponent();
            pickupDate.MinDate = DateTime.Now;
            timeDryer1.Checked = true;
            timeWashing1.Checked = true;
            timeIron1.Checked = true;
        }

        public AddLaundry(string unitID, string machineSelected, string unitSelected)
        {
            InitializeComponent();
            tobeassignedLbl.Visible = false;
            this.unitSelected = unitID;
            lblMachine.Visible = true;
            cbMachine.Visible = true;
            lblUnit.Visible = true;
            txtBoxUnit.Visible = true;
            cbMachine.Text = machineSelected;
            txtBoxUnit.Text = unitSelected;
            specificUnit = true;
            pickupDate.MinDate = DateTime.Now;
            timeDryer1.Checked = true;
            timeWashing1.Checked = true;
            timeIron1.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /// collect details
                string unit = txtBoxUnit.Text;
                string serviceCategory = cbService.Text;

                //string service = btnService.Text;
                /*string service1 = "", service2 = "", service3 = "";
                //string input = service;
                char[] separators = new char[] { '|' };
                string[] types = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if (types.Length == 1)
                {
                    service1 = types[0];
                }
                else if (types.Length == 2)
                {
                    service1 = types[0];
                    service2 = types[1];
                }
                else if (types.Length == 3)
                {
                    service1 = types[0];
                    service2 = types[1];
                    service3 = types[2];
                }*/

                string service1 = serviceType1.SelectedValue.ToString();
                string service2 = serviceType2.SelectedValue.ToString();
                string service3 = serviceType3.SelectedValue.ToString();

                if (service1.Equals("placeholder"))
                {

                }
                else if (service2.Equals("placeholder"))
                {
                    service2 = "";
                    service3 = "";
                }
                else if (service3.Equals("placeholder"))
                {
                    service3 = "";
                }

                string weight = txtWeight.Text;
                string weight2 = txtWeight2.Text;
                string weight3 = txtWeight3.Text;

                DateTime pickUp = DateTime.Parse(pickupDate.Text);
                string item1 = cbItem1.SelectedValue.ToString();
                string item2 = cbItem2.SelectedValue.ToString();
                string item3 = cbItem3.SelectedValue.ToString();

                string itemQuan1 = quantity1.Text;
                string itemQuan2 = quantity2.Text;
                string itemQuan3 = quantity3.Text;

                TimeSpan washTime = TimeSpan.Zero;
                if (timeWashing30.Checked)
                {
                    washTime = TimeSpan.FromMinutes(30);
                }
                else if (timeWashing1.Checked)
                {
                    washTime = TimeSpan.FromMinutes(60);
                }
                else if (timeWashingCustomMin.Checked)
                {
                    washTime = TimeSpan.FromMinutes(double.Parse(txtWashOtherMin.Text));
                }
                else if (timeWashingCustomHr.Checked)
                {
                    washTime = TimeSpan.FromHours(double.Parse(txtWashOtherHour.Text));
                }

                TimeSpan dryTime = TimeSpan.Zero;
                if (timeDryer30.Checked)
                {
                    dryTime = TimeSpan.FromMinutes(30);
                }
                else if (timeDryer1.Checked)
                {
                    dryTime = TimeSpan.FromMinutes(60);
                }
                else if (timeDryerCustomMin.Checked)
                {
                    dryTime = TimeSpan.FromMinutes(double.Parse(txtDryOtherMin.Text));
                }
                else if (timeDryerCustomHr.Checked)
                {
                    dryTime = TimeSpan.FromHours(double.Parse(txtDryOtherHour.Text));
                }

                TimeSpan ironTime = TimeSpan.Zero;
                if (timeIron30.Checked)
                {
                    ironTime = TimeSpan.FromMinutes(30);
                }
                else if (timeIron1.Checked)
                {
                    ironTime = TimeSpan.FromMinutes(60);
                }
                else if (timeIronCustomMin.Checked)
                {
                    ironTime = TimeSpan.FromMinutes(double.Parse(txtPressOtherMin.Text));
                }
                else if (timeIronCustomHr.Checked)
                {
                    ironTime = TimeSpan.FromHours(double.Parse(txtPressOtherHr.Text));
                }

                string custID = "";
                //Adding/Editing Customer
                if (cbCust.SelectedValue.ToString().Equals("add"))
                {
                    CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text, txtBoxAddress.Text);
                    custID = customerClass.addCustomer(true);
                }
                else if (cbCust.SelectedValue.ToString().Equals("placeholder"))
                {
                    MessageBox.Show("Please select a customer!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    CustomerClass customerClass = new CustomerClass(txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text, txtBoxAddress.Text);
                    customerClass.editCustomer(cbCust.SelectedValue.ToString());
                    custID = cbCust.SelectedValue.ToString();
                }

                ScheduleClass schedule = new ScheduleClass(serviceCategory, service1, service2, service3, weight, weight2, weight3, custID, DateTime.Now, pickUp, item1, item2, item3, itemQuan1, itemQuan2, itemQuan3, washTime, dryTime, ironTime);
                if (specificUnit)
                {
                    schedule.addLaundry(unitSelected, cbMachine.Text);
                }
                else
                {
                    schedule.addLaundry();
                }

                this.Close();
                _parentForm.RefreshPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            SelectServices select = new SelectServices(this, cbService.Text);
            select.ShowDialog();
        }

        private void AddLaundry_Load(object sender, EventArgs e)
        {
            cbService.SelectedIndex = 0;
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "placeholder", "<Select Customer Name>" },
                { "add", "<Add New Customer>" }
            };
            CustomerClass customer = new CustomerClass();
            DataTable customers = customer.displayCustomer();
            foreach (DataRow row in customers.Rows)
            {
                data.Add(row["customer_id"].ToString(), row["customer_name"].ToString());
            }
            cbCust.DataSource = data.ToArray();
            cbCust.DisplayMember = "Value";
            cbCust.ValueMember = "Key";

            Dictionary<string, string> itemData = new Dictionary<string, string>
            {
                { "placeholder", "<Select Item Name>" }
            };
            InventoryClass inventoryClass = new InventoryClass();
            DataTable items = inventoryClass.displayItem();
            foreach (DataRow row in items.Rows)
            {
                itemData.Add(row["item_id"].ToString(), row["item_name"].ToString());
            }
            cbItem1.DataSource = itemData.ToArray();
            cbItem1.DisplayMember = "Value";
            cbItem1.ValueMember = "Key";
            cbItem2.DataSource = itemData.ToArray();
            cbItem2.DisplayMember = "Value";
            cbItem2.ValueMember = "Key";
            cbItem3.DataSource = itemData.ToArray();
            cbItem3.DisplayMember = "Value";
            cbItem3.ValueMember = "Key";

        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbService.Text.Equals("Wash-Dry-Fold"))
            {
                serviceType1.Enabled = true;

                timeIron30.Enabled = false;
                timeIron1.Enabled = false;
                timeIronCustomMin.Enabled = false;
                timeIronCustomHr.Enabled = false;
                timeWashing30.Enabled = true;
                timeWashing1.Enabled = true;
                timeWashingCustomMin.Enabled = true;
                timeWashingCustomHr.Enabled = true;
                timeDryer1.Enabled = true;
                timeDryer30.Enabled = true;
                timeDryerCustomMin.Enabled = true;
                timeDryerCustomHr.Enabled = true;
            }
            else if (cbService.Text.Equals("Dry Only"))
            {
                serviceType1.Enabled = true;

                timeWashing30.Enabled = false;
                timeWashing1.Enabled = false;
                timeWashingCustomMin.Enabled = false;
                timeWashingCustomHr.Enabled = false;
                timeIron30.Enabled = false;
                timeIron1.Enabled = false;
                timeIronCustomMin.Enabled = false;
                timeIronCustomHr.Enabled = false;
                timeDryer1.Enabled = true;
                timeDryer30.Enabled = true;
                timeDryerCustomMin.Enabled = true;
                timeDryerCustomHr.Enabled = true;
            }
            else
            {
                serviceType1.Enabled = true;

                timeWashing30.Enabled = true;
                timeWashing1.Enabled = true;
                timeWashingCustomMin.Enabled = true;
                timeWashingCustomHr.Enabled = true;
                timeDryer1.Enabled = true;
                timeDryer30.Enabled = true;
                timeDryerCustomMin.Enabled = true;
                timeDryerCustomHr.Enabled = true;
                timeIron30.Enabled = true;
                timeIron1.Enabled = true;
                timeIronCustomMin.Enabled = true;
                timeIronCustomHr.Enabled = true;
            }

            Dictionary<string, string> serviceData = new Dictionary<string, string>
            {
                { "placeholder", "<Select Service Type>" }
            };

            ServiceClass serviceClass = new ServiceClass(cbService.Text);
            DataTable services = serviceClass.displayService();
            foreach (DataRow row in services.Rows)
            {
                if (!row["service_id"].ToString().Equals(serviceType1.SelectedValue.ToString()) && !row["service_id"].ToString().Equals(serviceType2.SelectedValue.ToString()))
                {
                    serviceData.Add(row["service_id"].ToString(), row["service_name"].ToString());
                }
            }

            serviceType1.DataSource = serviceData.ToArray();
            serviceType1.DisplayMember = "Value";
            serviceType1.ValueMember = "Key";
        }

        private void cbCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCust.SelectedValue.ToString().Equals("placeholder"))
            {
                txtBoxName.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxAddress.Enabled = false;
                txtBoxPhone.Enabled = false;
            }
            else if (cbCust.SelectedValue.ToString().Equals("add"))
            {
                txtBoxName.Enabled = true;
                txtBoxEmail.Enabled = true;
                txtBoxAddress.Enabled = true;
                txtBoxPhone.Enabled = true;
            }
            else
            {
                txtBoxName.Enabled = true;
                txtBoxEmail.Enabled = true;
                txtBoxAddress.Enabled = true;
                txtBoxPhone.Enabled = true;

                CustomerClass customerClass = new CustomerClass();
                DataTable customerInfo = new DataTable();
                customerInfo = customerClass.displaySelectedCustomer(cbCust.SelectedValue.ToString());

                foreach (DataRow row in customerInfo.Rows)
                {
                    txtBoxName.Text = row["customer_name"].ToString();
                    txtBoxEmail.Text = row["customer_email"].ToString();
                    txtBoxPhone.Text = row["customer_phone"].ToString();
                    txtBoxAddress.Text = row["customer_address"].ToString();
                }
            }
        }

        private void serviceType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceType1.SelectedValue.ToString().Equals("placeholder"))
            {
                serviceType2.Enabled = false;
                serviceType3.Enabled = false;
                txtWeight2.Enabled = false;
                txtWeight3.Enabled = false;
            }
            else if (!serviceType1.SelectedValue.ToString().Equals("placeholder"))
            {
                serviceType2.Enabled = true;
                txtWeight2.Enabled = true;
                Dictionary<string, string> serviceData = new Dictionary<string, string>
                {
                    { "placeholder", "<Select Service Type>" }
                };

                ServiceClass serviceClass = new ServiceClass(cbService.Text);
                DataTable services = serviceClass.displayService();
                foreach (DataRow row in services.Rows)
                {
                    if (!row["service_id"].ToString().Equals(serviceType1.SelectedValue.ToString()) && !row["service_id"].ToString().Equals(serviceType2.SelectedValue.ToString()))
                    {
                        serviceData.Add(row["service_id"].ToString(), row["service_name"].ToString());
                    }
                }

                serviceType2.DataSource = serviceData.ToArray();
                serviceType2.DisplayMember = "Value";
                serviceType2.ValueMember = "Key";
            }
        }

        private void serviceType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceType2.SelectedValue.ToString().Equals("placeholder"))
            {
                serviceType3.Enabled = false;
                txtWeight3.Enabled= false;
            }
            else if (!serviceType2.SelectedValue.ToString().Equals("placeholder"))
            {
                serviceType3.Enabled = true;
                txtWeight3.Enabled = true;

                Dictionary<string, string> serviceData = new Dictionary<string, string>
                {
                    { "placeholder", "<Select Service Type>" }
                };

                ServiceClass serviceClass = new ServiceClass(cbService.Text);
                DataTable services = serviceClass.displayService();
                foreach (DataRow row in services.Rows)
                {
                    if (!row["service_id"].ToString().Equals(serviceType1.SelectedValue.ToString()) && !row["service_id"].ToString().Equals(serviceType2.SelectedValue.ToString()))
                    {
                        serviceData.Add(row["service_id"].ToString(), row["service_name"].ToString());
                    }
                }

                serviceType3.DataSource = serviceData.ToArray();
                serviceType3.DisplayMember = "Value";
                serviceType3.ValueMember = "Key";
            }
        }
    }
}