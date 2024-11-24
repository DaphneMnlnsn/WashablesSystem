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
    public partial class Customers : Form
    {
        public Customers(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Customers";
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            loadForm(new CustomerInfo());
        }
        private void loadForm(Form m)
        {
            if (this.panelTab.Controls.Count > 0)
            {
                this.panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panelTab.Controls.Add(m);
            this.panelTab.Tag = m;
            m.Show();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerInfo());
            btnCustomerInfo.BackColor = Color.FromArgb(217, 217, 217);
            btnCustomerArchive.BackColor = SystemColors.Control;
            btnComplaints.BackColor = SystemColors.Control;
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerComplaints(this));
            btnComplaints.BackColor = Color.FromArgb(217, 217, 217);
            btnCustomerInfo.BackColor = SystemColors.Control;
            btnCustomerArchive.BackColor = SystemColors.Control;
        }

        private void btnCustomerArchive_Click(object sender, EventArgs e)
        {
            loadForm(new CustomerArchive());
            btnCustomerArchive.BackColor = Color.FromArgb(217, 217, 217);
            btnCustomerInfo.BackColor = SystemColors.Control;
            btnComplaints.BackColor = SystemColors.Control;
        }
    }
}
