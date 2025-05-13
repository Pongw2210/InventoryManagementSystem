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
    public partial class frmAddSupplier : Sample
    {
        SqlConnection connect;
        private frmPurchase frmPurchase;
        public frmAddSupplier(frmPurchase frmPurchase)
        {
            InitializeComponent();
            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);
            this.frmPurchase = frmPurchase;
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Sup_Click(object sender, EventArgs e)
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

                                    frmPurchase.displaySuppliers();
                                    frmPurchase.SelectSupplierByName(txtName_Sup.Text.Trim());

                                    this.Close();
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
    }
}
