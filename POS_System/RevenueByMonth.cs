using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class RevenueByMonth
    {
        public int Month { get; set; }
        public float TotalPrice { get; set; }

        public List<RevenueByMonth> GetRevenueByMonth(int year)
        {
            List<RevenueByMonth> revenueByMonths = new List<RevenueByMonth>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT MONTH(order_date) AS month, SUM(total_price) AS tongtien " +
                                    "FROM Orders " +
                                    "WHERE YEAR(order_date)=@year " +
                                    "GROUP BY MONTH(order_date)" +
                                    "ORDER BY MONTH(order_date)";

                using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                {
                    cmd.Parameters.AddWithValue("@year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RevenueByMonth revenueByMonth = new RevenueByMonth();

                        revenueByMonth.Month = (int)reader["month"];
                        revenueByMonth.TotalPrice = Convert.ToSingle(reader["tongtien"]);

                        revenueByMonths.Add(revenueByMonth);
                    }
                }
            }
            return revenueByMonths;
        }
    }
}
