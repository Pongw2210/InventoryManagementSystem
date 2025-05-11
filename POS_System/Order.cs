using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public class Order
    {
        public int ID {  get; set; }
        public string Cus_id { get; set; }
        public string Prod_id { get; set; }
        public string Prod_name { get; set; }
        public string Category { get; set; }
        public string Qty { get; set; }
        public string OrigPrice { get; set; }
        public string TotalPrice { get; set; }

        public List<Order> GetAllOrders()
        {


            List<Order> orders = new List<Order>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int cusId = 0;
                    string selectCusSql = "SELECT MAX(customer_id) FROM Customers";

                    using(SqlCommand cmd=new SqlCommand(selectCusSql, connect))
                    {
                        object result= cmd.ExecuteScalar();
                        
                        if(result!=DBNull.Value)
                        {
                            int temp=Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                cusId = 1;
                            }
                            else
                            {
                                cusId = temp+1;
                            }
                        }
                    }

                    string selectSql = "SELECT * FROM Orders WHERE customer_id=@cusId ";
                    using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                    {
                        selectCmd.Parameters.AddWithValue("@cusId", cusId);

                        SqlDataReader reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Order order = new Order();

                            order.ID = (int)reader["id"];
                            order.Cus_id = reader["customer_id"].ToString();
                            order.Prod_id = reader["prod_id"].ToString();
                            order.Prod_name = reader["prod_name"].ToString();
                            order.Category = reader["category"].ToString();
                            order.Qty = reader["qty"].ToString();
                            order.OrigPrice = reader["orig_price"].ToString();
                            order.TotalPrice =reader["total_price"].ToString();

                            orders.Add(order);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
            return orders;  
        }

        

    }
}
