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
            FinishedList finishedList = new FinishedList();
            finishedList.setScheduleInfo("OR1033", "Amiah Velesco", "Unit II", "Wash/Dry (Clothes...)", "5.00", "Time Schedule: 10/14/2024\n8:45 AM\nStart Time: 10:00:29 AM\nEnd Time: 10:40:29 AM", "10/16/2024", "10/14/2024\n10:40:29 AM", WashablesSystem.Properties.Resources.Bill);
            FinishedContainer.Controls.Add(finishedList);
        }
    }
}