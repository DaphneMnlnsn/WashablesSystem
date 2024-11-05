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
    public partial class Inventory : Form
    {
        public Inventory(Main parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                parentForm.Header = "Inventory";
                string text = parentForm.Header;
            }
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            loadForm(new ItemView());
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

        private void btnView_Click(object sender, EventArgs e)
        {
            loadForm(new ItemView());
            btnView.BackColor = Color.FromArgb(217, 217, 217);
            btnArchive.BackColor = SystemColors.Control;
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            loadForm(new ArchiveInventory());
            btnArchive.BackColor = Color.FromArgb(217, 217, 217);
            btnView.BackColor = SystemColors.Control;
        }
    }
}
