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
    public partial class UserArchive : Form
    {
        public UserArchive()
        {
            InitializeComponent();
        }

        private void UserArchive_Load(object sender, EventArgs e)
        {
            archiveContainer.Controls.Clear();
            UserClass userArchive = new UserClass();
            DataTable users = userArchive.displayUserArchive();
            foreach (DataRow row in users.Rows)
            {
                UserArchiveList archive = new UserArchiveList(this);
                archive.setUserArchive(row["user_id"].ToString(), row["user_fullname"].ToString(), row["username"].ToString());
                archiveContainer.Controls.Add(archive);
            }

        }
        public void RefreshPanel()
        {
            UserArchive_Load(null, null);
        }
    }
}
