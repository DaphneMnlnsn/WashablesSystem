using System;
using System.Collections;
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
    public partial class SelectServices : Form
    {
        private Form parentForm;
        private ArrayList servicesSelected;
        ServiceTypeList serviceTypeList;
        public SelectServices(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SelectServices_Load(object sender, EventArgs e)
        {
            ArrayList serve = new ArrayList();
            serve.Add("(Clothes, Table Napkin, Pillowcase)");
            serve.Add("(Bed Sheet, Table Cloth, Curtain)");
            serve.Add("(Comforter, Bath Towel)");
            serviceTypeList = new ServiceTypeList();
            serviceTypeList.setTypeInfo("Wash-Dry-Fold", serve);
            serviceTypeContainer.Controls.Add(serviceTypeList);
            servicesSelected = serviceTypeList.getSelectedItems();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            servicesSelected.Clear();
            CustomTextbox serviceBtn = (CustomTextbox)parentForm.Controls.Find("btnService", true)[0];
            serviceBtn.Text = "";
            servicesSelected = serviceTypeList.getSelectedItems();
            foreach (string services in servicesSelected)
            {
                serviceBtn.Text += string.Join(", ", services);
            }
            CustomTextbox weight2 = (CustomTextbox)parentForm.Controls.Find("txtWeight2", true)[0];
            CustomTextbox weight3 = (CustomTextbox)parentForm.Controls.Find("txtWeight3", true)[0];
            if (servicesSelected.Count == 1)
            {
                weight2.Enabled = false;
                weight3.Enabled = false;
            }
            else if (servicesSelected.Count == 2)
            {
                weight3.Enabled = false;
            }
            else
            {
                weight2.Enabled = true;
                weight3.Enabled = true;
            }
            this.Dispose();
        }
    }
}
