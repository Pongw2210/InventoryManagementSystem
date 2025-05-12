using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace POS_System
{
    public partial class frmProduct : Sample
    {
        private SqlConnection connect;

        public frmProduct()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            displayCategories();
            displayAllProducts();
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private bool checkEmptyFields()
        {
            if (txtId_AddProd.Text == "" || txtName_AddProd.Text == "" || txtPrice_AddProd.Text == "" || txtStock_AddProd.Text == ""
                    || cbxCate_AddProd.SelectedIndex == -1 || cbxStatus_AddProd.SelectedIndex == -1 || pbxImage_AddProd.Image == null)
                return true;
            return false;
        }

        private void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Categories";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cbxCate_AddProd.Items.Add(reader["category"].ToString());
                            }
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
        }

        private void displayAllProducts()
        {
            Product product = new Product();

            List<Product> products = product.GetAllProducts();

            dgvProds.DataSource = products;
        }

        private void txtSearch_AddProd_TextChanged(object sender, EventArgs e)
        {
            Product product = new Product();

            List<Product> products=product.SearchProducts(txtSearch_AddProd.Text.Trim());

            dgvProds.DataSource=products;
        }

        private void btnImport_AddProd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxImage_AddProd.ImageLocation = dialog.FileName;
            }
        }

        private void btnAdd_AddProd_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
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

                        string checkProdSql = "SELECT * FROM Products WHERE prod_id=@prod_id";
                        using (SqlCommand checkCmd = new SqlCommand(checkProdSql, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@prod_id", txtId_AddProd.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkCmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(txtId_AddProd.Text.Trim() + " is already exist.",
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                byte[] imageBytes = null;
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    pbxImage_AddProd.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    imageBytes = ms.ToArray();
                                }

                                string insertSql = "INSERT INTO Products VALUES" +
                                    "(@prod_id,@prod_name,@category,@price,@stock,@image_data,@status,@date_insert)";
                                using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@prod_id", txtId_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prod_name", txtName_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@category", cbxCate_AddProd.SelectedItem);
                                    insertCmd.Parameters.AddWithValue("@price", txtPrice_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@stock", txtStock_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@image_data", imageBytes);
                                    insertCmd.Parameters.AddWithValue("@status", cbxStatus_AddProd.SelectedItem);

                                    DateTime today = DateTime.Today;
                                    insertCmd.Parameters.AddWithValue("@date_insert", today);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Added successfully!",
                                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAllProducts();
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

        private void clearFields()
        {
            txtId_AddProd.Clear();
            txtName_AddProd.Clear();
            txtPrice_AddProd.Clear();
            txtStock_AddProd.Clear();
            cbxCate_AddProd.SelectedIndex = -1;
            cbxStatus_AddProd.SelectedIndex = -1;
            pbxImage_AddProd.Image = null;
            txtId_AddProd.Focus();

        }

        private void btnClear_AddProd_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dgvProds_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProds.Rows[e.RowIndex];

                getID = (int)row.Cells["id"].Value;
                txtId_AddProd.Text = row.Cells["prod_id"].Value.ToString();
                txtName_AddProd.Text = row.Cells["prod_name"].Value.ToString();
                cbxCate_AddProd.Text = row.Cells["cate"].Value.ToString();
                txtPrice_AddProd.Text = row.Cells["price"].Value.ToString();
                txtStock_AddProd.Text = row.Cells["stock"].Value.ToString();

                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string sql = "SELECT image_data FROM Products WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(sql, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            byte[] imageBytes = cmd.ExecuteScalar() as byte[];

                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pbxImage_AddProd.Image = Image.FromStream(ms);
                                }
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

                cbxStatus_AddProd.Text = row.Cells["status"].Value.ToString();
            }

        }

        private void btnUpdate_AddProd_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to UPDATE Product Id: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string checkDuplicatedSql = "SELECT COUNT(*) FROM Products WHERE prod_id=@prod_id and id!=@id";
                            using (SqlCommand checkCmd = new SqlCommand(checkDuplicatedSql, connect))
                            {
                                checkCmd.Parameters.AddWithValue("@prod_id", txtId_AddProd.Text.Trim());
                                checkCmd.Parameters.AddWithValue("@id", getID);

                                int count = (int)checkCmd.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Product ID already exists. Please choose a different one.",
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            byte[] imageBytes = null;
                            if (pbxImage_AddProd.Image != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    using (Bitmap bmp = new Bitmap(pbxImage_AddProd.Image)) // tao ban sao cua anh hien tai co trong pbx
                                    {
                                        bmp.Save(ms, ImageFormat.Jpeg);
                                        imageBytes = ms.ToArray();
                                    }
                                }
                            }

                            // Cập nhật dữ liệu
                            string updateSql = "UPDATE Products SET prod_id=@prod_id, prod_name=@prod_name, category=@category, price=@price, " +
                                                "stock=@stock, image_data=@image_data, status=@status WHERE id=@id";

                            using (SqlCommand updateCmd = new SqlCommand(updateSql, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@prod_id", txtId_AddProd.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@prod_name", txtName_AddProd.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@category", cbxCate_AddProd.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@price", txtPrice_AddProd.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@stock", txtStock_AddProd.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@image_data", imageBytes);
                                updateCmd.Parameters.AddWithValue("@status", cbxStatus_AddProd.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Update successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                                displayAllProducts();
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

        private void btnRemove_AddProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to REMOVE Product Id: " + getID + "?", "Comfirmation Message"
                                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string deleteDataSql = "DELETE FROM Products WHERE id =@id";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteDataSql, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", getID);

                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Remove successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            displayAllProducts();

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
}

