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
    public partial class SalesList : UserControl
    {
        public SalesList()
        {
            InitializeComponent();
        }
        public void setSalesInfo(string order_id, string cust_name, string unit1, string unit2, string unit3, string service_category, string service1, string service2, string service3, string weight, string transaction_date, string amount)
        {
            //Displaying info
            orderID.Text = order_id;
            customerName.Text = cust_name;
            unitUsed.Text = unit1 + "\n" + unit2 + "\n" + unit3;
            services.Text = service_category + "\n" + service1 + "\n" + service2 + "\n" + service3;
            totalWeight.Text = weight;
            transactDate.Text = transaction_date;
            totalAmount.Text = amount;
        }
    }
}
