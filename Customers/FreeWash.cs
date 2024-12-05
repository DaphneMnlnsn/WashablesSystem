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
    public partial class FreeWash : Form
    {
        private string customerID;
        private string complaintID;
        public FreeWash(string complaintID, string customerID)
        {
            InitializeComponent();
            this.complaintID = complaintID;
            this.customerID = customerID;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FreeWash_Load(object sender, EventArgs e)
        {
            //Add items to combo box
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

        private void btnSched_Click(object sender, EventArgs e)
        {
            ComplaintsClass complaintClass = new ComplaintsClass();
            complaintClass.resolveComplaint(complaintID, "Remaining Stains");

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

            ScheduleClass scheduleClass = new ScheduleClass("Wash-Dry-Fold", "WDF101", "", "",
            txtBoxWeight.Text, "0.00", "0.00", customerID,
            DateTime.Now, DateTime.Parse(datePickup.Text), cbItem1.SelectedValue.ToString(), cbItem2.SelectedValue.ToString(),
            cbItem3.SelectedValue.ToString(), quantity1.Text, quantity2.Text, quantity3.Text, washTime, dryTime, TimeSpan.Zero);
            scheduleClass.addFreeWash();
        }
    }
}
