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
    public partial class frmRegister : Sample
    {
        private SqlConnection connect;
        private SqlDataAdapter adapter;
        private DataTable table;

        public frmRegister()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
        }

        private void LoadFormLogin()
        {

            frmLogin frmLogin = new frmLogin();

            frmLogin.ShowDialog();

            this.Hide();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtUserReg.Text == "" || txtPassReg.Text == "" || txtRe_PassReg.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsernameSQL = "SELECT * FROM Users WHERE username=@username";

                        using (SqlCommand cmd=new SqlCommand(checkUsernameSQL, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUserReg.Text.Trim());

                            adapter = new SqlDataAdapter(cmd);
                            table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUserReg.Text.Trim()+
                                    " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPassReg.Text.Length<3)
                            {
                                MessageBox.Show("Invalid Password, at least 3 characters are a needed",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txtPassReg.Text!= txtRe_PassReg.Text)
                            {
                                MessageBox.Show("Password does not match",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertSQL = "INSERT INTO Users (username,password,role,status,date)" +
                                "VALUES(@username,@password,@role,@status,@date)";

                                using (SqlCommand cmdInsert = new SqlCommand(insertSQL, connect))
                                {
                                    cmdInsert.Parameters.AddWithValue("@username", txtUserReg.Text.Trim());
                                    cmdInsert.Parameters.AddWithValue("@password", txtPassReg.Text);
                                    cmdInsert.Parameters.AddWithValue("@role", "Cashier");
                                    cmdInsert.Parameters.AddWithValue("@status","Approval");

                                    DateTime today = DateTime.Today;
                                    cmdInsert.Parameters.AddWithValue("@date", today);

                                    cmdInsert.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoadFormLogin();

                                }

                            }
                        }

                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Connection failed: "+ex.Message,
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        connect.Close();
                    }
                        
                }
            }

        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }
        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = ckbShowPass.Checked;
            txtPassReg.UseSystemPasswordChar = !showPassword;
            txtRe_PassReg.UseSystemPasswordChar = !showPassword;
        }
    }
}
