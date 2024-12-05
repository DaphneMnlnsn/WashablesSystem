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
            new ReportView(true).ShowDialog();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            salesPanel.Controls.Clear();
            DashboardClass dashboardClass = new DashboardClass();
            DataTable sales = dashboardClass.generateSalesReport();
            foreach (DataRow row in sales.Rows)
            {
                SalesList sale = new SalesList();
                sale.setSalesInfo(row["order_id"].ToString(), row["customer_name"].ToString(),
                    row["unit_id"].ToString(), row["unit_id2"].ToString(),
                   row["unit_id3"].ToString(), row["service_category"].ToString(),
                   row["service_id"].ToString(), row["service_id2"].ToString(),
                   row["service_id3"].ToString(), row["totalweight"].ToString(), row["transaction_date"].ToString(), row["total_amount"].ToString());
                salesPanel.Controls.Add(sale);
            }
        }
    }
}
