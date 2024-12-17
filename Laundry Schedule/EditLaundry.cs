using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class EditLaundry : Form
    {
        private string orderID;
        public EditLaundry(string orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
            pickupDate.MinDate = DateTime.Now.AddDays(-1);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditLaundry_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "placeholder", "<Select Customer Name>" }
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

            //for value inserting
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable schedule = new DataTable();
            schedule = scheduleClass.displaySelectedEdit(orderID);

            foreach (DataRow row in schedule.Rows)
            {
                pickupDate.Text = row["pickup_date"].ToString();
                cbService.Text = row["service_category"].ToString();
                btnService.Text = row["service_id"].ToString() + "|" + row["service_id2"].ToString() + "|" + row["service_id3"].ToString();
                cbCust.Text = row["customer_name"].ToString();
                txtWeight.Text = row["weight"].ToString();
                txtWeight2.Text = row["weight2"].ToString();
                txtWeight3.Text = row["weight3"].ToString();
                cbItem1.SelectedValue = row["item_id"].ToString();
                cbItem2.Text = row["item_id2"].ToString();
                cbItem3.Text = row["item_id3"].ToString();
                quantity1.Value = decimal.Parse(row["item1_quantity"].ToString());
                quantity2.Value = decimal.Parse(row["item2_quantity"].ToString());
                quantity3.Value = decimal.Parse(row["item3_quantity"].ToString());

                if (row["service_category"].ToString().Equals("Dry Only"))
                {
                    timeWashing1.Enabled = false;
                    timeWashing30.Enabled = false;
                    timeWashingCustomHr.Enabled = false;
                    timeWashingCustomMin.Enabled = false;
                }
                else
                {
                    if (row["wash_time"].ToString().Equals("00:30:00"))
                    {
                        timeWashing30.Checked = true;
                    }
                    else if (row["wash_time"].ToString().Equals("01:00:00"))
                    {
                        timeWashing1.Checked = true;
                    }
                    else if (TimeSpan.Parse(row["wash_time"].ToString()) > TimeSpan.FromHours(1))
                    {
                        timeWashingCustomHr.Checked = true;
                        txtWashOtherHour.Value = decimal.Parse(TimeSpan.Parse(row["wash_time"].ToString()).TotalHours.ToString());
                    }
                    else if (row["wash_time"].ToString().Equals("00:00:00"))
                    {

                    }
                    else
                    {
                        timeWashingCustomMin.Checked = true;
                        txtWashOtherMin.Value = decimal.Parse(TimeSpan.Parse(row["wash_time"].ToString()).TotalMinutes.ToString());
                    }
                }


                if (row["dry_time"].ToString().Equals("00:30:00"))
                {
                    timeDryer30.Checked = true;
                }
                else if (row["dry_time"].ToString().Equals("01:00:00"))
                {
                    timeDryer1.Checked = true;
                }
                else if (TimeSpan.Parse(row["dry_time"].ToString()) > TimeSpan.FromHours(1))
                {
                    timeDryerCustomHr.Checked = true;
                    txtDryOtherHour.Value = decimal.Parse(TimeSpan.Parse(row["dry_time"].ToString()).TotalHours.ToString());
                }
                else if (row["dry_time"].ToString().Equals("00:00:00"))
                {

                }
                else
                {
                    timeDryerCustomMin.Checked = true;
                    txtDryOtherMin.Value = decimal.Parse(TimeSpan.Parse(row["dry_time"].ToString()).TotalMinutes.ToString());
                }

                if (row["service_category"].ToString().Equals("Wash-Dry-Fold") || row["service_category"].ToString().Equals("Dry Only"))
                {
                    timeIronCustomMin.Enabled = false;
                    timeIron1.Enabled = false;
                    timeIronCustomHr.Enabled = false;
                    timeIron30.Enabled = false;
                }
                else
                {
                    if (row["iron_time"].ToString().Equals("00:30:00"))
                    {
                        timeIron30.Checked = true;
                    }
                    else if (row["iron_time"].ToString().Equals("01:00:00"))
                    {
                        timeIron1.Checked = true;
                    }
                    else if (TimeSpan.Parse(row["iron_time"].ToString()) > TimeSpan.FromHours(1))
                    {
                        timeIronCustomHr.Checked = true;
                        txtPressOtherHr.Value = decimal.Parse(TimeSpan.Parse(row["iron_time"].ToString()).TotalHours.ToString());
                    }
                    else if (row["iron_time"].ToString().Equals("00:00:00"))
                    {

                    }
                    else
                    {
                        timeIronCustomMin.Checked = true;
                        txtPressOtherMin.Value = decimal.Parse(TimeSpan.Parse(row["iron_time"].ToString()).TotalMinutes.ToString());
                    }
                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
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

                ScheduleClass scheduleClass = new ScheduleClass("", "", "", "", "0.00", "0.00", "0.00", "",
                DateTime.Now, DateTime.Parse(pickupDate.Text), cbItem1.SelectedValue.ToString(), cbItem2.SelectedValue.ToString(),
                cbItem3.SelectedValue.ToString(), quantity1.Text, quantity2.Text, quantity3.Text, washTime, dryTime, ironTime);
                scheduleClass.editSchedule(orderID);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
