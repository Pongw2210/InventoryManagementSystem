using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<User> GetAllUsers()
       {
            List<User> users = new List<User>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");
            

            using ( connect)
            {
                connect.Open();

                string selectSql = "SELECT * FROM Users";

                using (SqlCommand selectCmd = new SqlCommand(selectSql,connect))
                {

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = (int)reader["id"];
                        user.Username = reader["username"].ToString();
                        user.Password = reader["password"].ToString();
                        user.Role = reader["role"].ToString();
                        user.Status = reader["status"].ToString();
                        user.Date = reader["date"].ToString();

                        users.Add(user);
                    }
                }
            }
            return users;
       }

        public List<User> SearchUsers(string keyword)
        {
            List<User> users = new List<User>();

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");


            using (connect)
            {
                connect.Open();

                string selectSearchSql = "SELECT * FROM Users WHERE username LIKE @keyword";

                using (SqlCommand selectSearchCmd = new SqlCommand(selectSearchSql, connect))
                {
                    selectSearchCmd.Parameters.AddWithValue("@keyword","%"+keyword+"%");
                    SqlDataReader reader = selectSearchCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = (int)reader["id"];
                        user.Username = reader["username"].ToString();
                        user.Password = reader["password"].ToString();
                        user.Role = reader["role"].ToString();
                        user.Status = reader["status"].ToString();
                        user.Date = reader["date"].ToString();

                        users.Add(user);
                    }
                }
            }
            return users;
        }



    }
}
