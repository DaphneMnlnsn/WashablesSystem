﻿using System;
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
    public partial class AddService : Form
    {
        private ServicesAndEquipment _parentForm = new ServicesAndEquipment(new Main());

        public AddService(ServicesAndEquipment parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceClass service = new ServiceClass(cbService.Text, txtBoxName.Text,
                    decimal.Parse(txtBoxRate.Text), decimal.Parse(txtBoxMin.Text));
                service.addService();
                _parentForm.RefreshPanel();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
