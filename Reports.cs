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
    public partial class Reports : Form
    {
        Form thisparentForm;
        public Reports(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Reports";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new ReportView().ShowDialog();
        }
    }
}
