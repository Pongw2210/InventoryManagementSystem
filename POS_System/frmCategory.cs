using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmCategory : Sample
    {
        private SqlConnection connect;
        private SqlDataAdapter adapter;
        private DataTable table;

        public frmCategory()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            displayAllCategories();
        }

        private void displayAllCategories()
        {
            Category category = new Category();

            List<Category> categories = category.GetAllCategories();

            dgvCates.DataSource = categories;
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void clearFields()
        {
            txtCate_AddCate.Clear();
            txtCate_AddCate.Focus();
        }

        private void btnAdd_AddCate_Click(object sender, EventArgs e)
        {
            if (txtCate_AddCate.Text == "")
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

                        string checkCate = "SELECT * FROM Categories WHERE category=@category";
                        using (SqlCommand checkCmd = new SqlCommand(checkCate, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@category", txtCate_AddCate.Text.Trim());

                            adapter = new SqlDataAdapter(checkCmd);
                            table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtCate_AddCate.Text.Trim() + " is already exist.",
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertSql = "INSERT INTO Categories VALUES(@category,@date)";

                                using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@category", txtCate_AddCate.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertCmd.Parameters.AddWithValue("@date", today);

                                    insertCmd.ExecuteNonQuery();


                                    MessageBox.Show("Added successfully!",
                                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAllCategories();
                                    clearFields();

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

        private void btnClear_AddCate_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID;
        private void dgvCates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCates.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string category = row.Cells[1].Value.ToString();

                txtCate_AddCate.Text = category;

            }
        }
        private void btnUpdate_AddCate_Click(object sender, EventArgs e)
        {
            if (txtCate_AddCate.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to UPDATE Category Id: " + getID + "?", "Comfirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string checkDuplicatedSql = "SELECT COUNT(*) FROM Categories WHERE category=@category and id!=@id";
                            using (SqlCommand checkCmd = new SqlCommand(checkDuplicatedSql, connect))
                            {
                                checkCmd.Parameters.AddWithValue("@category", txtCate_AddCate.Text.Trim());
                                checkCmd.Parameters.AddWithValue("@id", getID);

                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Category already exists.Please choose a different one."
                                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            string updateDataSql = "UPDATE Categories SET category=@category WHERE id =@id";
                            using (SqlCommand updateCmd = new SqlCommand(updateDataSql, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@category", txtCate_AddCate.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Update successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                                displayAllCategories();

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

        private void btnRemove_AddCate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to REMOVE Category Id: " + getID + "?", "Comfirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string deleteDataSql = "DELETE FROM Categories WHERE id =@id";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteDataSql, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", getID);

                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Remove successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            displayAllCategories();

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

        private void txtSearch_AddCate_TextChanged(object sender, EventArgs e)
        {
            Category category = new Category();

            List<Category> categories = category.SearchCategories(txtSearch_AddCate.Text.Trim());

            dgvCates.DataSource = categories;
        }
    }
}
