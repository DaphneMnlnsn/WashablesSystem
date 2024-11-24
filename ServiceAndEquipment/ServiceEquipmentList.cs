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
    public partial class ServiceEquipmentList : UserControl
    {
        public ServiceEquipmentList()
        {
            InitializeComponent();
        }

        public void setRowInfo(string code, string category, string rs, string kind, Image editOrRestore)
        {
            lblCode.Text = code;
            ulblSE.Text = category;
            ulblRS.Text = rs;
            what.Text = kind;
            btnEdit.Image = editOrRestore;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Label lblHeader = (Label)this.FindForm().Controls.Find("lblHeader", true)[0];
            if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Services"))
            {
                EditService editService = new EditService();
                editService.ShowDialog();
            }
            else if (what.Text.Equals("Edit") && lblHeader.Text.Equals("Equipment"))
            {
                EditUnit editUnit = new EditUnit();
                editUnit.ShowDialog();
            }
            else
            {
            }
        }
    }
}