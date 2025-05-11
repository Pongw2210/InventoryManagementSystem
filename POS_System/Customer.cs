using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public float TotalPrice { get; set; }
        public float Amount { get; set; }
        public float Change { get; set; }
        public string OrderDate { get; set; }

        public List<Customer> GetAllCustomers()
        {


            List<Customer> customers = new List<Customer>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Customers";
                    using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                    {

                        SqlDataReader reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Customer customer = new Customer();

                            //customer.CustomerId = reader["customer_id"].ToString() ;
                            //customer.TotalPrice = reader["total_price"].ToString(); ;
                            //customer.Amount = reader["amount"].ToString() ;
                            //customer.Change = reader["change"].ToString();
                            //customer.OrderDate = reader["order_date"].ToString();

                            customer.CustomerId = (int)reader["customer_id"];
                            customer.TotalPrice = Convert.ToSingle(reader["total_price"]);
                            customer.Amount = Convert.ToSingle(reader["amount"]);
                            customer.Change = Convert.ToSingle(reader["change"]);
                            customer.OrderDate = reader["order_date"].ToString();


                            customers.Add(customer);
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
            return customers;
        }

        public List<Customer> GetAllCustomersToday()
        {


            List<Customer> customers = new List<Customer>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Customers WHERE order_date=@date";
                    using (SqlCommand selectCmd = new SqlCommand(selectSql, connect))
                    {
                        DateTime today = DateTime.Today;
                        selectCmd.Parameters.AddWithValue("date", today);

                        SqlDataReader reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Customer customer = new Customer();

                            customer.CustomerId = (int)reader["customer_id"];
                            customer.TotalPrice = Convert.ToSingle(reader["total_price"]);
                            customer.Amount = Convert.ToSingle(reader["amount"]);
                            customer.Change = Convert.ToSingle(reader["change"]);
                            customer.OrderDate = reader["order_date"].ToString();

                            customers.Add(customer);
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
            return customers;
        }
    }


}
