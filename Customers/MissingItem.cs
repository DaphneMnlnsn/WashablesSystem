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
    public partial class MissingItem : Form
    {
        private Form _parentForm;
        private string customerID;
        private string complaintID;
        public MissingItem(Form parentForm, string complaintID, string customerID)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.complaintID = complaintID;
            this.customerID = customerID;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MissingItem_Load(object sender, EventArgs e)
        {
        }
        private void loadForm(Form m)
        {
            Button customerInfo = (Button)_parentForm.Controls.Find("btnCustomerInfo", true)[0];
            customerInfo.BackColor = Color.FromArgb(217, 217, 217);
            Button complaints = (Button)_parentForm.Controls.Find("btnComplaints", true)[0];
            complaints.BackColor = SystemColors.Control;
            Panel panelTab = (Panel)_parentForm.Controls.Find("panelTab", true)[0];
            if (panelTab.Controls.Count > 0)
            {
                panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panelTab.Controls.Add(m);
            panelTab.Tag = m;
            m.Show();
        }

        private void MissingItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadForm(new CustomerInfo());
        }

        private void dateLaundry_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateLaundry.Value.Date;
            ComplaintsClass complaints = new ComplaintsClass();

            DataTable sameDate = complaints.missingItem(selectedDate.ToString("yyyy-MM-dd"));

            sameDateContainer.Controls.Clear();

            foreach (DataRow row in sameDate.Rows)
            {
                SameDateItem sameDateItem = new SameDateItem();
                sameDateItem.setInfo(
                    row["customer_name"].ToString(),
                    row["unit_id"].ToString() + " | " + row["unit_id2"] + " | " + row["unit_id3"],
                    row["finished_on"].ToString()
                );
                sameDateContainer.Controls.Add(sameDateItem);
            }

        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            ComplaintsClass complaintClass = new ComplaintsClass();
            complaintClass.resolveComplaint(complaintID, "Missing Item");
        }
    }
}
