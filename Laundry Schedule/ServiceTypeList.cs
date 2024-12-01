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
    public partial class ServiceTypeList : UserControl
    {
        public ServiceTypeList()
        {
            InitializeComponent();
            
            // Explicitly set height to fit options
            checkBoxCtrl.ClientSize = new Size(checkBoxCtrl.ClientSize.Width, checkBoxCtrl.GetItemRectangle(0).Height * checkBoxCtrl.Items.Count);

        }
        public void setTypeInfo(string mainService, ArrayList subServices)
        {
            checkBoxCtrl.Items.Clear();
            lblHeader.Text = mainService;
            foreach (string service in subServices)
            {
                checkBoxCtrl.Items.Add(service);
            }
        }
        public ArrayList getSelectedItems()
        {
            ArrayList selectedItems = new ArrayList();
            // Determine if there are any items checked.  
            if (checkBoxCtrl.CheckedItems.Count != 0)
            {
                //If so, loop through all checked items and print results.  
                foreach(string checkedService in checkBoxCtrl.CheckedItems)
                {
                    selectedItems.Add(checkedService);
                }
            }
            return selectedItems;
        }
    }
}
