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
    public partial class Schedule : Form
    {
        public Schedule(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Schedule";
                string text = parentForm.Header;
            }
        }
    }
}
