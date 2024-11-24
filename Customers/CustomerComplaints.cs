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
    public partial class CustomerComplaints : Form
    {
        private Form _parentForm;
        public CustomerComplaints(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void CustomerComplaints_Load(object sender, EventArgs e)
        {
            ComplaintList complaint = new ComplaintList();
            complaint.setComplaintInfo("R001", "Roxanne Rose", "Quiana Momingo", "Missing Item", "10/12/2024", "---", "Not Resolved");
            complaintContainer.Controls.Add(complaint);

            ComplaintList complaint2 = new ComplaintList();
            complaint2.setComplaintInfo("R002", "Roxanne Rose", "Lei Mar", "Remaining Stain", "10/12/2024", "---", "Not Resolved");
            complaintContainer.Controls.Add(complaint2);

        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            AddComplaint addComplaint = new AddComplaint();
            addComplaint.ShowDialog();
        }
    }
}
