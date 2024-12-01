using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WashablesSystem
{
    public partial class PendingLaundryList : UserControl
    {
        public PendingLaundryList()
        {
            InitializeComponent();
        }
        public void setStatus(string order, string customer, string service, string status, string scheduled, string date)
        {
            lblOR.Text = order;
            custName.Text = customer;
            serviceType.Text = service;
            lblStatus.Text = status;
            timeScheduled.Text = DateTime.Parse(scheduled).ToString();
            pickup.Text = DateTime.Parse(date).ToShortDateString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectAvailableUnit select = new SelectAvailableUnit(lblOR.Text);
            select.ShowDialog();
        }
    }
}