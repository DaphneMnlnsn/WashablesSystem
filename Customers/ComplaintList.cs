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
    public partial class ComplaintList : UserControl
    {
        public ComplaintList()
        {
            InitializeComponent();
        }
        public void setComplaintInfo(string complaintNum, string handled, string custName, string problem, string dateComp, string dateRes, string status)
        {
            //Displaying customer info
            lblNum.Text = complaintNum;
            lblHandled.Text = handled;
            lblCustomer.Text = custName;
            lblProblem.Text = problem;
            lblDateComp.Text = dateComp;
            lblDateRes.Text = dateRes;
            lblStatus.Text = status;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            Form grandparentForm = parentForm?.ParentForm;
            if (lblProblem.Text.Equals("Missing Item"))
            {
                MissingItem findItem = new MissingItem(grandparentForm);
                findItem.ShowDialog();
            }
            if (lblProblem.Text.Equals("Remaining Stain"))
            {
                FreeWash freeWash = new FreeWash();
                freeWash.ShowDialog();
            }
        }
    }
}
