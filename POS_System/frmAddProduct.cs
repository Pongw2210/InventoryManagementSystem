using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmAddProduct : Sample
    {
        SqlConnection connect;
        private frmPurchase frmPurchase;
        public frmAddProduct(frmPurchase frmPurchase)
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            this.frmPurchase = frmPurchase;
            displayCategories();
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
                    MessageBox.Show("Connection failed displayCategories: " + ex.Message,
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
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
            if (txtId_AddProd.Text == "" || txtName_AddProd.Text == "" || txtPrice_AddProd.Text == "" ||
                cbxCate_AddProd.SelectedIndex == -1 | cbxStatus_AddProd.SelectedIndex == -1 || pbxImage_AddProd.Image == null)
                return true;
            return false;
        }
        private void btnSave_Prod_Click(object sender, EventArgs e)
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
                                    "(@prod_id,@prod_name,@category,@price,@stock,@image_data,@status,@date_insert,@supplier_name)";
                                using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@prod_id", txtId_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prod_name", txtName_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@category", cbxCate_AddProd.SelectedItem);
                                    insertCmd.Parameters.AddWithValue("@price", txtPrice_AddProd.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@stock", 0);
                                    insertCmd.Parameters.AddWithValue("@image_data", imageBytes);
                                    insertCmd.Parameters.AddWithValue("@status", cbxStatus_AddProd.SelectedItem);
                                    insertCmd.Parameters.AddWithValue("@supplier_name", DBNull.Value);

                                    DateTime today = DateTime.Today;
                                    insertCmd.Parameters.AddWithValue("@date_insert", today);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Added successfully!",
                                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmPurchase.displayProducts();
                                    frmPurchase.SelectProductById(txtId_AddProd.Text.Trim());
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed btnSave_Prod: " + ex.Message,
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
