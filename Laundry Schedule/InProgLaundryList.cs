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
    public partial class InProgLaundryList : UserControl
    {
        public InProgLaundryList()
        {
            InitializeComponent();
        }
        public void setStatus(string unit, string customer, string service, string time)
        {
            lblUnit.Text = unit;
            custName.Text = customer;
            serviceType.Text = service;
            timeLeft.Text = time;
        }
    }
}