using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addItem()
        {

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
        private void logOperation()
        {

        }
    }
}
