using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmLogin : Sample
    {
        private SqlConnection connect;
        private SqlDataAdapter adapter;
        private DataTable table;
        public frmLogin()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);

                        adapter = new SqlDataAdapter(cmd);
                        table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            frmMain frmMain = new frmMain();
                            frmMain.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password are incorrect",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Connection failed: " + ex.Message,
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void lb_Register_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();

            this.Hide();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = ckbShowPass.Checked;
            txtPass.UseSystemPasswordChar = !showPassword;
        }
    }
}
