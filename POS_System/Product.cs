using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class Product
    {
        public int Id { get; set; }
        public string Prod_id { get; set; }
        public string Prod_name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public byte[] Image_data { get; set; }
        public string Status { get; set; }
        public string Date_insert { get; set; }


        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");


            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT * FROM Products";

                using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                {

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = (int)reader["id"];
                        product.Prod_id = reader["prod_id"].ToString();
                        product.Prod_name = reader["prod_name"].ToString();
                        product.Category = reader["category"].ToString();
                        product.Price = (double)reader["price"];
                        product.Stock = (int)reader["stock"];
                        product.Image_data = reader["image_data"] as byte[];
                        product.Status = reader["status"].ToString();
                        product.Date_insert = reader["date_insert"].ToString();

                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public List<Product> GetAllAvailableProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");


            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT * FROM Products WHERE stock >0 AND status = 'Available'";

                using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                {

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = (int)reader["id"];
                        product.Prod_id = reader["prod_id"].ToString();
                        product.Prod_name = reader["prod_name"].ToString();
                        product.Category = reader["category"].ToString();
                        product.Price = (double)reader["price"];
                        product.Stock = (int)reader["stock"];
                        product.Image_data = reader["image_data"] as byte[];
                        product.Status = reader["status"].ToString();
                        product.Date_insert = reader["date_insert"].ToString();

                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public List<Product> SearchProducts(string keyword)
        {
            List<Product> products = new List<Product>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSearchSql = "SELECT * FROM Products WHERE prod_id LIKE @keyword" +
                                                                " OR prod_name LIKE @keyword " +
                                                                " OR category LIKE @keyword " +
                                                                " OR CAST(price AS NVARCHAR) LIKE @keyword " +
                                                                " OR CAST(stock AS NVARCHAR) LIKE @keyword ";

                using (SqlCommand selectSearchCmd = new SqlCommand(selectSearchSql, connect))
                {
                    selectSearchCmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataReader reader = selectSearchCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = (int)reader["id"];
                        product.Prod_id = reader["prod_id"].ToString();
                        product.Prod_name = reader["prod_name"].ToString();
                        product.Category = reader["category"].ToString();
                        product.Price = (double)reader["price"];
                        product.Stock = (int)reader["stock"];
                        product.Image_data = reader["image_data"] as byte[];
                        product.Status = reader["status"].ToString();
                        product.Date_insert = reader["date_insert"].ToString();

                        products.Add(product);
                    }
                }
            }
            return products;
        }


    }
}
