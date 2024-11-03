using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class SameDateItem : UserControl
    {
        public SameDateItem()
        {
            InitializeComponent();
        }


        public void setInfo(string custName, string unitName, string sameDate)
        {
            //Displaying customer info
            lblCust.Text = custName;
            lblUnit.Text = unitName;
            lblDate.Text = sameDate;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        
    }
}
