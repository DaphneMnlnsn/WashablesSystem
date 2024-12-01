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
    public partial class LaundryOperations : Form
    {
        public LaundryOperations(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Laundry Operations";
                string text = parentForm.Header;
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            btnInProg.BackColor = Color.FromArgb(217, 217, 217);
            btnPending.BackColor = SystemColors.Control;
            /// add space for sort by button
            laundryContainer.Padding = new Padding(0, 50, 0, 0);
            cbSort.Show();
            /// add pending Laundry orders
            laundryContainer.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayPending();
            foreach (DataRow row in orders.Rows)
            {
                PendingLaundryList pending = new PendingLaundryList();
                pending.setStatus(row["order_id"].ToString(), row["customer_name"].ToString(), 
                    row["service_category"] + "(" + row["service_name"].ToString() + ")", row["order_status"].ToString(),
                   row["scheduled_time"].ToString(), row["pickup_date"].ToString());
                laundryContainer.Controls.Add(pending);
            }
        }

        private void btnInProg_Click(object sender, EventArgs e)
        {
            btnPending.BackColor = Color.FromArgb(217, 217, 217);
            btnInProg.BackColor = SystemColors.Control;
            /// remove space & sort by button
            laundryContainer.Padding = new Padding(0, 10, 0, 0);
            cbSort.Hide();
            /// add in-progress Laundry orders
            laundryContainer.Controls.Clear();
            ScheduleClass scheduleClass = new ScheduleClass();
            DataTable orders = scheduleClass.displayInProgress("Wash In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                if (row["order_status"].ToString().Equals("Wash In-Progress"))
                {
                    InProgLaundryList inProg = new InProgLaundryList();
                    inProg.setStatus(row["order_id"].ToString(), row["unit_name"].ToString(),
                       row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                       row["order_status"].ToString(), row["laundry_endTime"].ToString());
                    laundryContainer.Controls.Add(inProg);
                }
            }

            orders = scheduleClass.displayInProgress("Dry In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                if (row["order_status"].ToString().Equals("Dry In-Progress"))
                {
                    InProgLaundryList inProg = new InProgLaundryList();
                    inProg.setStatus(row["order_id"].ToString(), row["unit_name"].ToString(),
                       row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                       row["order_status"].ToString(), row["laundry_endTime"].ToString());
                    laundryContainer.Controls.Add(inProg);
                }
            }

            orders = scheduleClass.displayInProgress("Press In-Progress");
            foreach (DataRow row in orders.Rows)
            {
                if (row["order_status"].ToString().Equals("Press In-Progress"))
                {
                    InProgLaundryList inProg = new InProgLaundryList();
                    inProg.setStatus(row["order_id"].ToString(), row["unit_name"].ToString(),
                       row["customer_name"].ToString(), row["service_category"] + "(" + row["service_name"].ToString() + ")",
                       row["order_status"].ToString(), row["laundry_endTime"].ToString());
                    laundryContainer.Controls.Add(inProg);
                }
            }

        }

        private void LaundryOperations_Load(object sender, EventArgs e)
        {
            /// List of Machines
            MachineList WM = new MachineList();
            WM.setMachine("Washing Machine");
            machinePanel.Controls.Add(WM);

            MachineList DY = new MachineList();
            DY.setMachine("Dryer");
            machinePanel.Controls.Add(DY);

            MachineList IR = new MachineList();
            IR.setMachine("Iron");
            machinePanel.Controls.Add(IR);

            /// add Laundry orders
            cbSort.Hide();
            laundryContainer.Padding = new Padding(0, 10, 0, 0);
            btnInProg_Click(null,null);

        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddLaundry laundryForm = new AddLaundry();
            laundryForm.ShowDialog();
        }
    }
}