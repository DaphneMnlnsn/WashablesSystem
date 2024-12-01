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
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class SelectServices : Form
    {
        private Form parentForm;
        private ArrayList servicesSelected;
        private string mainService;
        ServiceTypeList serviceTypeList;
        public SelectServices(Form parentForm, string mainService)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.mainService = mainService;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SelectServices_Load(object sender, EventArgs e)
        {
            ArrayList serve = new ArrayList();
            ServiceClass serviceClass = new ServiceClass(mainService);
            DataTable services = serviceClass.displayService();
            foreach (DataRow row in services.Rows)
            {
                serve.Add(row["service_id"].ToString());
            }
            serviceTypeList = new ServiceTypeList();
            serviceTypeList.setTypeInfo(mainService, serve);
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
                serviceBtn.Text += services + "|";
            }
            NumericUpDown weight2 = (NumericUpDown)parentForm.Controls.Find("txtWeight2", true)[0];
            NumericUpDown weight3 = (NumericUpDown)parentForm.Controls.Find("txtWeight3", true)[0];
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
