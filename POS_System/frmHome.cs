using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmHome : Sample
    {
        private SqlConnection connect;
        public frmHome()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);

            displayCustomersToday();
            displayAllUsers();
            displayAllCus();
            displayTodayIncome();
            displayAllIncome();
        }

        public void displayCustomersToday()
        {
            Customer customer = new Customer();

            List<Customer> customers = customer.GetAllCustomersToday();

            dgvCusToday.DataSource = customers;
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT COUNT(*) from Users";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        object num = cmd.ExecuteScalar();

                        lbAllUsers.Text = num.ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }

        public void displayAllCus()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT COUNT(*) from Customers";
                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        object num = cmd.ExecuteScalar();

                        lbAllCus.Text = num.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }

        public void displayTodayIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT SUM(total_price) from Customers WHERE order_date=@date";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        var num =Convert.ToSingle( cmd.ExecuteScalar());

                        lbTodayIncome.Text = "$"+num.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }

        public void displayAllIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT SUM(total_price) from Customers";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {

                        var num = Convert.ToSingle(cmd.ExecuteScalar());

                        lbTotalIncome.Text = "$" + num.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }


    }
}
