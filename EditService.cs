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
    public partial class EditService : Form
    {
        public EditService()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            cbService.SelectedIndex = 0;
            txtBoxName.Text = "Curtains, Pillows";
            txtBoxRate.Text = "70.00";
            txtBoxMin.Text = "3";
        }
    }
}
