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
    public partial class Billing : Form
    {
        public Billing(Main parentForm)
        {
            InitializeComponent();
            parentForm.Header = "Billing";
        }

        public Billing(Main parentForm, string ORNum)
        {
            InitializeComponent();
            parentForm.Header = "Billing";
            loadForm(new PendingPayments(ORNum));
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            loadForm(new PendingPayments());
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

        private void btnPending_Click(object sender, EventArgs e)
        {
            loadForm(new PendingPayments());
            btnPending.BackColor = Color.FromArgb(217, 217, 217);
            btnHistory.BackColor = SystemColors.Control;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadForm(new TransactionHistory());
            btnHistory.BackColor = Color.FromArgb(217, 217, 217);
            btnPending.BackColor = SystemColors.Control;
        }
    }
}
