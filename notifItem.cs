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
    public partial class notifItem : UserControl
    {
        Main grandparentForm;
        NotifOverlay notifOverlay;
        public notifItem(Main grandparentForm, NotifOverlay notifOverlay)
        {
            InitializeComponent();
            this.grandparentForm = grandparentForm;
            this.notifOverlay = notifOverlay;
        }
        public void setNotif(string notif)
        {
            activityText.Text = notif;
        }

        private void activityText_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)grandparentForm.FindForm().Controls.Find("btnNotif", true)[0];
            btn.Enabled = true;
            if(activityText.Text.Equals("ITM003 Zonrox is low in stock! Restock now!"))
            {
                loadForm(new Inventory(grandparentForm));
            }
            else
            {
                loadForm(new Schedule(grandparentForm, "Finished"));
            }
            
            notifOverlay.Dispose();
        }
        private void loadForm(Form m)
        {
            Panel panelPage = (Panel)this.FindForm().Controls.Find("panelPage", true)[0];
            if (panelPage.Controls.Count > 0)
            {
                panelPage.Controls.RemoveAt(0);
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panelPage.Controls.Add(m);
            panelPage.Tag = m;
            m.Show();
        }
    }
}
