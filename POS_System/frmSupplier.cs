using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_System
{
    public partial class frmSupplier : Sample
    {
        SqlConnection connect;
        public frmSupplier()
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            displaySupplier();
        }
        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void displaySupplier()
        {
            Supplier supplier = new Supplier();

            List<Supplier> suppliers = supplier.GetAllSuppliers();

            dgvSuppliers.DataSource = suppliers;
        }

        public void clearFields()
        {
            txtAddress_Sup.Clear();
            txtName_Sup.Clear();
            txtName_Sup.Focus();
        }

        private void btnAdd_Sup_Click(object sender, EventArgs e)
        {
            if (txtName_Sup.Text == "" || txtAddress_Sup.Text == "")
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

                        string checkSql = "SELECT COUNT(*) FROM Suppliers WHERE name=@name AND address=@address";
                        using (SqlCommand checkCmd = new SqlCommand(checkSql, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@name", txtName_Sup.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@address", txtAddress_Sup.Text.Trim());

                            int num = (int)checkCmd.ExecuteScalar();
                            if (num > 0)
                            {
                                MessageBox.Show(txtName_Sup.Text.Trim() + ". Address: " + txtAddress_Sup.Text.Trim() + " is already exist.",
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertSql = "INSERT INTO Suppliers VALUES(@name,@address,@date)";
                                using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@name", txtName_Sup.Text);
                                    insertCmd.Parameters.AddWithValue("@address", txtAddress_Sup.Text);

                                    DateTime today = DateTime.Now;
                                    insertCmd.Parameters.AddWithValue("@date", today);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Added successfully!",
                                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displaySupplier();
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
                    finally { connect.Close(); }
                }
            }
        }

        private void btnClear_Sup_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnRemove_Sup_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to REMOVE Category Id: " + getId + "?", "Comfirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string delSql = "DELETE Suppliers WHERE id=@id";
                        using(SqlCommand delCmd = new SqlCommand(delSql,connect))
                        {
                            delCmd.Parameters.AddWithValue("@id", getId);

                            delCmd.ExecuteNonQuery();

                            MessageBox.Show("Remove successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            displaySupplier();
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


        private int getId;
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row=new DataGridViewRow();

            row = dgvSuppliers.Rows[e.RowIndex];

            getId = (int)row.Cells[0].Value;
            txtName_Sup.Text= row.Cells[1].Value.ToString();
            txtAddress_Sup.Text= row.Cells[2].Value.ToString();

        }

        private void btnUpdate_Sup_Click(object sender, EventArgs e)
        {
            if (txtName_Sup.Text == "" || txtAddress_Sup.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(MessageBox.Show("Are you sure you want to UPDATE Category Id: " + getId + "?", "Comfirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connect.Open();
                        string checkDuplicated = "SELECT COUNT(*) FROM Suppliers WHERE name=@name AND address=@address AND id!=@id";
                        using (SqlCommand checkCmd = new SqlCommand(checkDuplicated, connect))
                        {
                            checkCmd.Parameters.AddWithValue("@id", getId);
                            checkCmd.Parameters.AddWithValue("@name", txtName_Sup.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@address", txtAddress_Sup.Text.Trim());

                            int num = (int)checkCmd.ExecuteScalar();
                            if (num > 0)
                            {
                                MessageBox.Show("Supplier already exists.Please choose a different one."
                                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                string updateSql = "UPDATE Suppliers SET name=@name, address=@address WHERE id=@id";
                                using (SqlCommand updateCmd = new SqlCommand(updateSql, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@name", txtName_Sup.Text.Trim());
                                    updateCmd.Parameters.AddWithValue("@address", txtAddress_Sup.Text.Trim());
                                    updateCmd.Parameters.AddWithValue("@id", getId);

                                    updateCmd.ExecuteNonQuery();

                                    MessageBox.Show("Update successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                    displaySupplier();
                                }
                            }

                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
