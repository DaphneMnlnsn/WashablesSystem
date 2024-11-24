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
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            TransactionList transaction1 = new TransactionList();
            transaction1.setTransactionInfo("P0001", "OR341", "Admin", "Lei Anysson Marquez", "10/13/2024 6:47:15 PM", "Gcash", "140.00");
            TransactionContainer.Controls.Add(transaction1);

            TransactionList transaction2 = new TransactionList();
            transaction2.setTransactionInfo("P0001", "OR341", "Admin", "Quiana Domingo", "10/12/2024 4:33:21 PM", "Cash", "140.00");
            TransactionContainer.Controls.Add(transaction2);

        }
    }
}