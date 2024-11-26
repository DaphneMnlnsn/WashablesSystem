using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashablesSystem.Classes
{
    internal class InventoryClass
    {
        private string itemID;
        private string itemName;
        private string itemCategory;
        private decimal itemQuantity;
        private string itemUnit;
        private decimal itemPrice;
        private bool availabilityStatus;

        SessionVariables sessionVar = new SessionVariables();
        private SqlConnection constring;

        public InventoryClass()
        {
            constring = sessionVar.Constring;
        }

        public InventoryClass(string ItemName, string Category, decimal Quantity, decimal Price)
        {
            constring = sessionVar.Constring;
            this.itemName = ItemName;
            this.itemCategory = Category;   
            this.itemQuantity = Quantity;   
            this.itemPrice = Price;
        }

        public void addItem()
        {
            constring.Open();

            //Verify if username exists
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [Item] WHERE item_name ='" + itemName + "'", constring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                //Add User to Database
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [item_id] FROM [Item] ORDER BY [item_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    itemID = reader1.GetString(0);
                    int num = int.Parse(string.Join("", itemID.Where(Char.IsDigit))) + 1;
                    itemID = "ITM" + num;
                }
                else
                {
                    MessageBox.Show("NO DATA FOUND");
                }
                reader1.Close();
                cmd.Dispose();

                //Query for inserting
                String query = "INSERT INTO [Item] VALUES('" + itemID + "','" + itemName + "','"
                    + itemCategory + "','" + itemQuantity + "','" + itemPrice + "'" +  ",0);";

                SqlCommand cmd2 = new SqlCommand(query, constring);
                cmd2.CommandText = query;

                //If successful, add to activity log
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    constring.Close();
                    logOperation("Added New Item");

                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                    constring.Close();
                }
            }
            else
            {
                MessageBox.Show("ItemName already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                constring.Close();
            }
        }
        public void editItem(string itemID)
        {

        }
        public void restoreItem(string itemID)
        {

        }
        public void archiveItem(string itemID)
        {

        }
        public void deleteItem(string itemID)
        {

        }
        public DataTable displayItem()
        {
            constring.Open();
            string sql = "SELECT * FROM [Item] WHERE archived = 0";
            DataTable item = new DataTable("item");
            SqlDataAdapter da = new SqlDataAdapter(sql, constring);
            da.Fill(item);
            constring.Close();

            return item;
        }
        private void logOperation(string activity)
        {
            if (activity.Equals("Added New User"))
            {
                constring.Open();
                int logID = 0;
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 [log_id] FROM ActivityLog ORDER BY [log_id] DESC", constring);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    logID = reader1.GetInt32(0) + 1;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
                reader1.Close();
                cmd.Dispose();
                string queryAct = "INSERT INTO ActivityLog VALUES('" + logID + "','" + sessionVar.loggedIn.ToString() + "','added item "
                            + itemID + "','" + DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','Inventory" + "')";
                SqlCommand cmdAct = new SqlCommand(queryAct, constring);
                cmdAct.CommandText = queryAct;
                cmdAct.ExecuteNonQuery();
                MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                constring.Close();
            }
        }
    }
}
