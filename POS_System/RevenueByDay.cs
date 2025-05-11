using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class RevenueByDay
    {
        public int Day {  get; set; }
        public float TotalPrice {  get; set; }

        public List<RevenueByDay> GetRevenueByDay(int month, int year)
        {
            List<RevenueByDay> revenueByDays = new List<RevenueByDay>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            using (connect)
            {
                connect.Open();

                string selectSql = "SELECT DAY(order_date) AS day, SUM(total_price) AS tongtien " +
                                    "FROM Orders " +
                                    "WHERE MONTH(order_date) =@month AND YEAR(order_date)=@year " +
                                    "GROUP BY DAY(order_date)" +
                                    "ORDER BY DAY(order_date)";
               
                using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                {
                    cmd.Parameters.AddWithValue("@month",month);
                    cmd.Parameters.AddWithValue("@year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RevenueByDay revenueByDay = new RevenueByDay();

                        revenueByDay.Day = (int)reader["day"];
                        revenueByDay.TotalPrice = Convert.ToSingle( reader["tongtien"]);

                        revenueByDays.Add(revenueByDay);
                    }
                }
            }
            return revenueByDays;
        }
    }
}
