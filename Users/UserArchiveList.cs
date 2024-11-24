using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class UserArchiveList : UserControl
    {
        public UserArchiveList()
        {
            InitializeComponent();
        }
        public void setUserArchive(string userArchiveNum, string userArchiveName)
        {
            //Displaying customer info
            userArchNo.Text = userArchiveNum;
            userArchName.Text = userArchiveName;
        }
    }
}
