﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Windows.Media;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class ItemList : UserControl
    {
        private ItemView _parentForm = new ItemView();
        public ItemList(ItemView parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        public void setItemInfo(string code, string name, string categ, string quan, string price, string measurement)
        {
            //Displaying info
            ItemCode.Text = code;
            ItemName.Text = name;
            Category.Text = categ;
            Quantity.Text = quan + measurement;
            Price.Text = price + "/" + measurement;

            if (decimal.Parse(quan) == 0)
            {
                ItemCode.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                ItemName.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Category.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Quantity.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);
                Price.ForeColor = System.Drawing.Color.FromArgb(161, 0, 0);

                SessionVariables sessionVariables = new SessionVariables();
                if (!sessionVariables.notified2)
                {
                    NotificationClass notification = new NotificationClass();
                    notification.sendNotification(ItemCode.Text, "Out of Stock");
                    sessionVariables.notified2 = true;
                }
            }
            else if (decimal.Parse(quan) <= 5 && decimal.Parse(quan) > 0)
            {
                ItemCode.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
                ItemName.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
                Category.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
                Quantity.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
                Price.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);

                SessionVariables sessionVariables = new SessionVariables();
                if (!sessionVariables.notified2)
                {
                    NotificationClass notification = new NotificationClass();
                    notification.sendNotification(ItemCode.Text, "Low on Stock");
                    sessionVariables.notified2 = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditItem editItem = new EditItem(_parentForm, ItemCode.Text);
            editItem.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RestockItem restockItem = new RestockItem(_parentForm, ItemCode.Text);
            restockItem.ShowDialog();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            ItemHistory itemHistory = new ItemHistory(ItemCode.Text);
            itemHistory.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //call archive method here
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to archive this item?\nThis will be moved to the item archive.", "Confirm Archive", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InventoryClass inventoryClass = new InventoryClass();
                inventoryClass.archiveItem(ItemCode.Text);
                _parentForm.RefreshPanel();
            }
        }
    }
}