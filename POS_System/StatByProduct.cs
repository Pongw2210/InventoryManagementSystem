using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class StatByProduct
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }    
        public int TotalQuantity { get; set; }

        public List<StatByProduct> GetOrderProduct(int month, int year)
        {
            List<StatByProduct>statByProducts = new List<StatByProduct>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT prod_id,prod_name, SUM(qty) as TotalQuantity " +
                                    "FROM OrderDetails " +
                                    "WHERE YEAR(order_date)=@year AND MONTH(order_date)=@month " +
                                    "GROUP BY prod_id,prod_name";

                using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        StatByProduct statByProduct = new StatByProduct();

                        statByProduct.ProdId = reader["prod_id"].ToString();
                        statByProduct.ProdName = reader["prod_name"].ToString();
                        statByProduct.TotalQuantity = (int) reader["TotalQuantity"];

                        statByProducts.Add(statByProduct);
                    }
                }
            }
            return statByProducts;
        }
    }
}
