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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            txtBoxName.Text = "Surf Powder";
            txtBoxPrice.Text = "20.00";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
