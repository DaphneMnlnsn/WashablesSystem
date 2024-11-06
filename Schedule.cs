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
        private void Customers_Load(object sender, EventArgs e)
        {
            loadForm(new InProgressSched());
        }
        private void loadForm(Form m)
        {
            if (this.panelTab.Controls.Count > 0)
            {
                this.panelTab.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            this.panelTab.Controls.Add(m);
            this.panelTab.Tag = m;
            m.Show();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            loadForm(new InProgressSched());
            btnInProgress.BackColor = Color.FromArgb(217, 217, 217);
            btnFinished.BackColor = SystemColors.Control;
            btnPending.BackColor = SystemColors.Control;
            btnArchive.BackColor = SystemColors.Control;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            loadForm(new PendingSched());
            btnInProgress.BackColor = SystemColors.Control;
            btnFinished.BackColor = SystemColors.Control;
            btnPending.BackColor = Color.FromArgb(217, 217, 217);
            btnArchive.BackColor = SystemColors.Control;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            loadForm(new FinishedSched(this));
            btnInProgress.BackColor = SystemColors.Control;
            btnFinished.BackColor = Color.FromArgb(217, 217, 217);
            btnPending.BackColor = SystemColors.Control;
            btnArchive.BackColor = SystemColors.Control;
        }

        private void bntArchive_Click(object sender, EventArgs e)
        {
            loadForm(new ArchiveSched());
            btnInProgress.BackColor = SystemColors.Control;
            btnFinished.BackColor = SystemColors.Control;
            btnPending.BackColor = SystemColors.Control;
            btnArchive.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void btnAddLaundry_Click(object sender, EventArgs e)
        {
            AddLaundry laundryForm = new AddLaundry();
            laundryForm.ShowDialog();
        }
    }
}
