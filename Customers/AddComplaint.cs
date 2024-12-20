﻿using System;
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
            try
            {
                if (!cbCustomerName.SelectedValue.ToString().Equals("placeholder") && !cbIssue.Text.Equals(""))
                {
                    ComplaintsClass complaintsClass = new ComplaintsClass(cbCustomerName.SelectedValue.ToString(), cbIssue.Text, DateTime.Parse(dateComplained.Text));
                    complaintsClass.addComplaint();
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddComplaint_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                { "placeholder", "<Select Customer Name>" }
            };
            CustomerClass customer = new CustomerClass();
            DataTable customers = customer.displayCustomer();
            foreach (DataRow row in customers.Rows)
            {
                data.Add(row["customer_id"].ToString(), row["customer_name"].ToString());
            }
            cbCustomerName.DataSource = data.ToArray();
            cbCustomerName.DisplayMember = "Value";
            cbCustomerName.ValueMember = "Key";
        }
    }
}
