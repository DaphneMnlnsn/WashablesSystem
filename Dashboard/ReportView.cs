using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WashablesSystem
{
    public partial class ReportView : Form
    {
        bool reportView;
        public ReportView()
        {
            InitializeComponent();
        }
        public ReportView(bool reportView)
        {
            InitializeComponent();
            this.reportView = reportView;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=WashablesLaundry;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();

            if (!reportView)
            {
                this.reportViewer1.RefreshReport();
                SqlCommand command = new SqlCommand("Select * FROM ActivityLog", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.ReportPath = "ActivityLogReport.rdlc";
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else if (reportView)
            {
                this.reportViewer1.RefreshReport();
                SqlCommand command = new SqlCommand(@"SELECT O.order_id, C.customer_name, ISNULL(O.unit_id,'') + CHAR(13) + CHAR(10) + ISNULL(O.unit_id2,'')
                    + CHAR(13) + CHAR(10) + ISNULL(O.unit_id3, '') AS units_used,
                    ISNULL(S.service_category, '') + CHAR(13) + CHAR(10) + ISNULL(O.service_id, '') +
                    +CHAR(13) + CHAR(10) + ISNULL(O.service_id2, '') + CHAR(13) + CHAR(10) + ISNULL(O.service_id3, '') AS service_category, O.weight + O.weight2 + O.weight3 AS total_weight, B.transaction_date, B.total_amount FROM
                    [Order] O INNER JOIN Customer C ON C.customer_ID = O.customer_id INNER JOIN
                    Billing B ON O.order_id = B.order_id INNER JOIN Service S ON O.service_id = S.service_id WHERE B.transaction_date IS NOT NULL", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("SalesReportDataSet", dt);

                reportViewer1.LocalReport.ReportPath = "SalesReport.rdlc";
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }


            conn.Close();
        }
    }
}
