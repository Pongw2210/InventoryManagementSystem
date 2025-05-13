using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class Purchase
    {
        public int Id { get; set; }
        public string SupName { get; set; }
        public string ProdId { get; set; }
        public string Prodname { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        public string Date { get; set; }

        public List<Purchase> GetAllPurchases()
        {
            List<Purchase> purchases = new List<Purchase>();
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");
            using (connect)
            {
                connect.Open();
                string selectSql = "SELECT * FROM Purchases";
                using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                {
                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Purchase purchase = new Purchase();
                        purchase.Id = (int)reader["id"];
                        purchase.SupName = reader["supplier_name"].ToString();
                        purchase.SupName = reader["prod_id"].ToString();
                        purchase.Prodname = reader["prod_name"].ToString();
                        purchase.Qty = (int)reader["qty"];
                        purchase.Price = Convert.ToSingle(reader["price"]);
                        purchase.Date = reader["date_import"].ToString();

                        purchases.Add(purchase);
                    }
                }
            }
            return purchases;
        }

        //public List<Supplier> SearchSuppliers(string keyword)
        //{
        //    List<Supplier> suppliers = new List<Supplier>();

        //    SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

        //    using (connect)
        //    {
        //        connect.Open();

        //        string selectSql = "SELECT * FROM Suppliers WHERE name LIKE @keyword OR address LIKE @keyword";

        //        using (SqlCommand cmd = new SqlCommand(selectSql, connect))
        //        {
        //            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

        //            SqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Supplier supplier = new Supplier();
        //                supplier.Id = (int)reader["id"];
        //                supplier.Name = reader["name"].ToString();
        //                supplier.Address = reader["address"].ToString();
        //                supplier.DateJoin = reader["date_join"].ToString();

        //                suppliers.Add(supplier);
        //            }
        //        }
        //    }
        //    return suppliers;
        //}
    }
}
