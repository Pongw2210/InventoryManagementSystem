using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmPurchase : Sample
    {

        SqlConnection connect;

        public frmPurchase()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            displayAllPurchases();
        }

        private void displayAllPurchases()
        {
            Purchase purchase = new Purchase();

            List<Purchase> purchases = purchase.GetAllPurchases();

            dgvPurchases.DataSource = purchases;
            displaySuppliers();
            displayProducts();
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }
        public void displaySuppliers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Suppliers";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cbxSupName.Items.Add(reader["name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed displaySuppliers: " + ex.Message,
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }

        public void displayProducts()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Products";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cbxProdId.Items.Add(reader["prod_id"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed displayProduct: " + ex.Message,
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }

        public void SelectSupplierByName(string name)
        {
            if (cbxSupName.Items.Contains(name))
            {
                cbxSupName.SelectedItem = name;
            }
        }

        public void SelectProductById(string id)
        {
            if (cbxProdId.Items.Contains(id))
            {
                cbxProdId.SelectedItem = id;
            }
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            frmAddSupplier frmaddSupplier = new frmAddSupplier(this);
            frmaddSupplier.Show();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAddProduct = new frmAddProduct(this);
            frmAddProduct.Show();
        }

        private void btnAdd_AddCate_Click(object sender, EventArgs e)
        {
            if (cbxProdId.SelectedIndex == -1 || cbxSupName.SelectedIndex == -1 || numQty.Value <= 0 || txtPrice.Text == "")
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
                        string insertSql = "INSERT INTO Purchases VALUES (@supplier_name,@prod_id,@prod_name,@qty,@price,@date_import)";
                        using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                        {
                            insertCmd.Parameters.AddWithValue("@supplier_name", cbxSupName.SelectedItem);
                            insertCmd.Parameters.AddWithValue("@prod_id", cbxProdId.SelectedItem);
                            insertCmd.Parameters.AddWithValue("@prod_name", lbProdName.Text.Trim());
                            insertCmd.Parameters.AddWithValue("@qty", numQty.Value);
                            insertCmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());

                            DateTime today = DateTime.Today;
                            insertCmd.Parameters.AddWithValue("@date_import", today);

                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Added successfully!",
                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAllPurchases();

                            string updateSql = "UPDATE Products SET stock=stock+@qty,supplier_name=@sup_name WHERE prod_id=@prod_id";
                            using (SqlCommand updateCmd = new SqlCommand(updateSql, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@sup_name", cbxSupName.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@prod_id", cbxProdId.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@qty", numQty.Value);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed btnAdd_AddCate: " + ex.Message,
                                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }
        }

        private void cbxProdId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbxProdId.SelectedItem.ToString();

            if (selectedValue != null)
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Products WHERE prod_id=@prod_id";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        cmd.Parameters.AddWithValue("@prod_id", selectedValue);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lbProdName.Text = reader["prod_name"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed select product: " + ex.Message,
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
