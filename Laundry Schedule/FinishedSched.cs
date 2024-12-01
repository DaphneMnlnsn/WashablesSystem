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
    public partial class FinishedSched : Form
    {
        private Form _parentForm;
        public FinishedSched(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void FinishedSched_Load(object sender, EventArgs e)
        {
        }
    }
}