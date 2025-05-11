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
    public partial class frmUser : Sample
    {
        private SqlConnection connect;
        private SqlDataAdapter adapter;
        private DataTable table;
        public frmUser()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            displayAllUsers();
        }

        private void displayAllUsers()
        {
            User user = new User();

            List<User> users = user.GetAllUsers();
            
            dgvUsers.DataSource = users;
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void btnAdd_AddUsers_Click(object sender, EventArgs e)
        {
            if (txtUsername_AddUsers.Text==""||txtPassword_AddUsers.Text==""
                || cbxRole_AddUsers.SelectedIndex == -1 || cbxStatus_AddUsers.SelectedIndex == -1)
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
                        string checkUsernameSql = "SELECT * FROM Users WHERE username=@username";

                        using (SqlCommand cmd = new SqlCommand(checkUsernameSql, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername_AddUsers.Text.Trim());

                            adapter = new SqlDataAdapter(cmd);
                            table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtUsername_AddUsers.Text.Trim() + " is already taken",
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertDataSql = "INSERT INTO Users (username, password, role, status,date)" +
                                    " VALUES(@username,@password,@role,@status,@date)";
                                using (SqlCommand cmdInsert = new SqlCommand(insertDataSql, connect))
                                {
                                    cmdInsert.Parameters.AddWithValue("@username", txtUsername_AddUsers.Text.Trim());
                                    cmdInsert.Parameters.AddWithValue("@password", txtPassword_AddUsers.Text);
                                    cmdInsert.Parameters.AddWithValue("@role", cbxRole_AddUsers.SelectedItem.ToString());
                                    cmdInsert.Parameters.AddWithValue("@status", cbxStatus_AddUsers.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmdInsert.Parameters.AddWithValue("@date", today);

                                    cmdInsert.ExecuteNonQuery();

                                    MessageBox.Show("Added successfully!",
                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                    displayAllUsers();

                                }
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
        }

        private void clearFields()
        {
            txtUsername_AddUsers.Clear();
            txtPassword_AddUsers.Clear();
            cbxRole_AddUsers.SelectedIndex = -1;
            cbxStatus_AddUsers.SelectedIndex = -1;
            txtUsername_AddUsers.Focus();
        }

        private void btnClear_AddUsers_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;

        private void btnUpdate_AddUsers_Click(object sender, EventArgs e)
        {
            if (txtUsername_AddUsers.Text == "" || txtPassword_AddUsers.Text == ""
                || cbxRole_AddUsers.SelectedIndex == -1 || cbxStatus_AddUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (MessageBox.Show("Are you sure you want to UPDATE User Id: " + getID + "?", "Comfirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string checkDuplicatedSql = "SELECT COUNT(*) FROM Users WHERE username=@username and id!=@id";
                            using (SqlCommand checkCmd = new SqlCommand(checkDuplicatedSql,connect)) 
                            { 
                                checkCmd.Parameters.AddWithValue("@username",txtUsername_AddUsers.Text.Trim());
                                checkCmd.Parameters.AddWithValue("@id", getID);

                                int count= (int)checkCmd.ExecuteScalar();

                                if (count > 0) 
                                { 
                                    MessageBox.Show("Username already exists.Please choose a different one."
                                        ,"Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            string updateDataSql = "UPDATE Users SET username=@username, password=@password," +
                                "role=@role,status=@status WHERE id =@id";
                            using (SqlCommand updateCmd = new SqlCommand(updateDataSql, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@username", txtUsername_AddUsers.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@password", txtPassword_AddUsers.Text);
                                updateCmd.Parameters.AddWithValue("@role", cbxRole_AddUsers.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@status", cbxStatus_AddUsers.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();
                                clearFields();
                                displayAllUsers();

                                MessageBox.Show("Update successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                getID = (int) row.Cells[0].Value;
                string username= row.Cells[1].Value.ToString();
                string password= row.Cells[2].Value.ToString();
                string role= row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();


                txtUsername_AddUsers.Text = username;
                txtPassword_AddUsers.Text = password;
                cbxRole_AddUsers.Text = role;
                cbxStatus_AddUsers.Text = status;
            }
        }

        private void btnRemove_AddUsers_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to REMOVE User Id: " + getID + "?", "Comfirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string deleteDataSql = "DELETE FROM Users WHERE id =@id";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteDataSql, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", getID);

                            deleteCmd.ExecuteNonQuery();
                            clearFields();
                            displayAllUsers();

                            MessageBox.Show("Remove successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void txtSearch_AddUsers_TextChanged(object sender, EventArgs e)
        {
            User user=new User();

            List<User> users = user.SearchUsers(txtSearch_AddUsers.Text.Trim());

            dgvUsers.DataSource = users;
        }
    }
}
