﻿using System;
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
    public partial class EditUnit : Form
    {
        public EditUnit()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditUnit_Load(object sender, EventArgs e)
        {
            //call displayselectedinfo method here
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //call edit method here
        }
    }
}
