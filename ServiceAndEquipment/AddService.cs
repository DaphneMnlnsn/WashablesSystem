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
    public partial class AddService : Form
    {
        
        public AddService()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass(cbService.Text, txtBoxName.Text, 
                decimal.Parse(txtBoxRate.Text), decimal.Parse(txtBoxMin.Text));
            service.addService();

            this.Close();
        }
    }
}
