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
    public partial class UserArchive : Form
    {
        public UserArchive()
        {
            InitializeComponent();
        }

        private void UserArchive_Load(object sender, EventArgs e)
        {
            UserArchiveList archive1 = new UserArchiveList();
            archive1.setUserArchive("U004", "Kirsten Momingo");
            archiveContainer.Controls.Add(archive1);

            UserArchiveList archive2 = new UserArchiveList();
            archive2.setUserArchive("U005", "Daph Man");
            archiveContainer.Controls.Add(archive2);

            UserArchiveList archive3 = new UserArchiveList();
            archive3.setUserArchive("U006", "Lei Mar");
            archiveContainer.Controls.Add(archive3);

        }
    }
}
