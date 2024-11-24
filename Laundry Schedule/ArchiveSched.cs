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
    public partial class ArchiveSched : Form
    {
        public ArchiveSched()
        {
            InitializeComponent();
        }

        private void ArchiveSched_Load(object sender, EventArgs e)
        {
            ArchiveSchedList archiveSchedList = new ArchiveSchedList();
            archiveSchedList.setScheduleInfo("OR1033", "Amiah Velesco", "-", "Wash/Dry (Clothes...)", "1.00", "Time Schedule: 10/14/2024\n8:45 AM\nStart Time: ---\nEnd Time: ---", "10/16/2024", "1 hr");
            ArchivedContainer.Controls.Add(archiveSchedList);
        }
    }
}