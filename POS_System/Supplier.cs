using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class Supplier
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DateJoin { get; set; }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");
            using (connect)
            {
                connect.Open();
                string selectSql = "SELECT * FROM Suppliers";
                using(SqlCommand selectCmd=new SqlCommand(selectSql, connect))
                {
                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Supplier supplier = new Supplier();
                        supplier.Id = (int)reader["id"];
                        supplier.Name = reader["name"].ToString();
                        supplier.Address = reader["address"].ToString();
                        supplier.DateJoin = reader["date_join"].ToString();

                        suppliers.Add(supplier);
                    }
                }
            }
            return suppliers;
        }
    }
}
