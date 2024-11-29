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
    public partial class AddComplaint : Form
    {
        CustomerComplaints _parentForm = new CustomerComplaints(new Main());
        public AddComplaint(CustomerComplaints parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComplaintsClass complaintsClass = new ComplaintsClass(cbCustomerName.Text, cbIssue.Text, DateTime.Parse(dateComplained.Text));
            complaintsClass.addComplaint();
            _parentForm.RefreshPanel();
            this.Close();
        }
    }
}
