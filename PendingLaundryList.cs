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
        public void setStatus(string order, string customer, string service, string scheduled, string date)
        {
            lblOR.Text = order;
            custName.Text = customer;
            serviceType.Text = service;
            timeScheduled.Text = scheduled;
            pickup.Text = date;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectAvailableUnit select = new SelectAvailableUnit();
            select.ShowDialog();
        }
    }
}