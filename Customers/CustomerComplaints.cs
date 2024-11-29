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
            complaintContainer.Controls.Clear();

            ComplaintsClass complaintsClass = new ComplaintsClass();
            DataTable complaints = complaintsClass.displayComplaint();
            foreach (DataRow row in complaints.Rows)
            {
                ComplaintList complaint = new ComplaintList(this);
                complaint.setComplaintInfo(row["complaint_id"].ToString(), row["user_id"].ToString(),
                   row["customer_id"].ToString(), row["problem"].ToString(),
                   row["date_complained"].ToString(), row["date_resolved"].ToString(), row["resolved_status"].ToString());
                complaintContainer.Controls.Add(complaint);
            }

        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            AddComplaint addComplaint = new AddComplaint(this);
            addComplaint.ShowDialog();
        }

        public void RefreshPanel()
        {
            CustomerComplaints_Load(null, null);
        }
    }
}
