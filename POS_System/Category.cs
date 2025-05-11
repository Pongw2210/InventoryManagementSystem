using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class Category
    {
        public int id { get; set; }
        public string category { get; set; }    
        public string date { get; set; }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT * FROM Categories";

                using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.id = (int)reader["id"];
                        category.category = reader["category"].ToString();
                        category.date = reader["date"].ToString();

                        categories.Add(category);
                    }
                }
            }
            return categories;
        }

        public List<Category> SearchCategories(string keyword)
        {
            List<Category> categories = new List<Category>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT * FROM Categories WHERE category LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%"+keyword+"%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.id = (int)reader["id"];
                        category.category = reader["category"].ToString();
                        category.date = reader["date"].ToString();

                        categories.Add(category);
                    }
                }
            }
            return categories;
        }
    }
}
