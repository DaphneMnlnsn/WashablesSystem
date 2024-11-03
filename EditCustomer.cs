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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txtBoxName.Text = "Quiana Momingo";
            txtBoxEmail.Text = "momingo@gmail.com";
            txtBoxPhone.Text = "09132134761";
            txtBoxAddress.Text = "01 St., Balagtas, Bulacan";
        }
    }
}
