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

        public void setRowInfo(string code, string name, string rs, string s_or_e, string weight, string kind, Image editOrRestore)
        {
            lblCode.Text = code;
            ulblSE.Text = name;
            if (s_or_e.Equals("Service"))
            {
                ulblRS.Text = "Php " + rs + "/kgs" + " (" + weight + "kgs min.)";
            }
            else
            {
                ulblRS.Text = rs;
            }
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
            else if (what.Text.Equals("Restore"))
            {
                //call restore method here
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (what.Text.Equals("Edit"))
            {
               //call archive method here
            }
            else if (what.Text.Equals("Restore"))
            {
               //call delete method here
            }
        }
    }
}