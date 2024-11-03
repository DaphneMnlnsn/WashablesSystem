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
    public partial class MissingItem : Form
    {
        private Form _parentForm;
        public MissingItem(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MissingItem_Load(object sender, EventArgs e)
        {
            SameDateItem complaint = new SameDateItem();
            complaint.setInfo("Daph Man", "Unit III", "10/13/2024 10:30AM");
            sameDateContainer.Controls.Add(complaint);

            SameDateItem complaint2 = new SameDateItem();
            complaint2.setInfo("Lei Mar", "Unit II", "10/13/2024 10:31AM");
            sameDateContainer.Controls.Add(complaint2);
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
    }
}
