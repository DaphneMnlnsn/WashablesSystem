using System;
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
    public partial class EditService : Form
    {
        private ServicesAndEquipment _parentForm = new ServicesAndEquipment(new Main());
        private string service_selected;
        public EditService(ServicesAndEquipment parentForm, string serviceSelected)
        {
            InitializeComponent();
            _parentForm = parentForm;
            this.service_selected = serviceSelected;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditService_Load(object sender, EventArgs e)
        {
            ServiceClass serviceClass = new ServiceClass();
            DataTable serviceInfo = new DataTable();
            serviceInfo = serviceClass.displaySelectedService(service_selected);

            foreach (DataRow row in serviceInfo.Rows)
            {
                cbService.Text = row["service_category"].ToString();
                txtBoxName.Text = row["service_name"].ToString();
                txtBoxRate.Text = row["service_rate"].ToString();
                txtBoxMin.Text = row["service_minWeight"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxName.Text) && decimal.TryParse(txtBoxRate.Text, out decimal rate)
                    && decimal.Parse(txtBoxRate.Text) > 0 && txtBoxMin.Value > 0)
                {
                    ServiceClass serviceClass = new ServiceClass(cbService.Text, txtBoxName.Text, decimal.Parse(txtBoxRate.Text), decimal.Parse(txtBoxMin.Text));
                    serviceClass.editService(service_selected);
                    _parentForm.RefreshPanel();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please try again.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
