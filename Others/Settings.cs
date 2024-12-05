using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem
{
    public partial class Settings : Form
    {
        SessionVariables sessionVariables = new SessionVariables();
        SqlConnection constring;
        public Settings()
        {
            InitializeComponent();
            constring = sessionVariables.Constring;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtRate1.Value = sessionVariables.downPaymentRate * 100;
            txtRate2.Value = sessionVariables.balanceDueRate * 100;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            constring.Open();
            string query = "UPDATE [Settings] SET downpayment_rate='" + decimal.Parse(txtRate1.Text) / 100 + "',balancedue_rate='"
                + decimal.Parse(txtRate2.Text) / 100 + "';";

            SqlCommand cmd2 = new SqlCommand(query, constring);
            cmd2.CommandText = query;

            //If successful, add to activity log
            if (cmd2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Configured Successfully!");
                constring.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
                constring.Close();
            }
        }

        private void txtBackup_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup\\";
            saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak";
            saveFileDialog1.FileName = "WashablesLaundry_backup.bak";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = saveFileDialog1.FileName;
            }
        }
        public void backupDatabase(string databaseName, string backupFilePath)
        {
            string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH FORMAT, MEDIANAME = 'DatabaseBackup', NAME = 'Full Backup of {databaseName}';";

            try
            {
                constring.Open();

                using (SqlCommand cmd = new SqlCommand(backupQuery, constring))
                {
                    cmd.ExecuteNonQuery();
                }
                constring.Close();

                MessageBox.Show("Backup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                constring.Close();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string backupFilePath = txtBackup.Text;

            if (string.IsNullOrEmpty(backupFilePath))
            {
                MessageBox.Show("Please enter a valid file path.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!backupFilePath.EndsWith(".bak"))
            {
                MessageBox.Show("The backup file must have a .bak extension.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string databaseName = "WashablesLaundry";

            backupDatabase(databaseName, backupFilePath);
        }

        private void txtRestore_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup\\";
            openFileDialog1.Filter = "Backup Files (*.bak)|*.bak";
            openFileDialog1.FileName = "WashablesLaundry_backup.bak";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = openFileDialog1.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string restoreFilePath = txtRestore.Text;

            if (string.IsNullOrEmpty(restoreFilePath))
            {
                MessageBox.Show("Please enter a valid file path.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!restoreFilePath.EndsWith(".bak"))
            {
                MessageBox.Show("The backup file must have a .bak extension.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SessionVariables sessionVariables = new SessionVariables();
            SqlConnection connectionString = sessionVariables.Constring;

            RestoreDatabase(connectionString, restoreFilePath);
        }
        public void RestoreDatabase(SqlConnection connectionString, string backupFilePath)
        {
            string restoreQuery = $"RESTORE DATABASE [WashablesLaundry] FROM DISK = '{backupFilePath}' WITH REPLACE, RECOVERY;";

            try
            {
                connectionString.Open();
                using (SqlCommand cmd = new SqlCommand(restoreQuery, connectionString))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Restore successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectionString.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionString.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionString.Close();
            }
        }

        private void txtRate1_ValueChanged(object sender, EventArgs e)
        {
            txtRate2.Value = 100 - txtRate1.Value;
        }
    }
}
