using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;


namespace POS_System
{
    public partial class frmCashierOrder : Sample
    {
        private SqlConnection connect;
        public frmCashierOrder()
        {
            InitializeComponent();

            string cnStr = "Data Source=DESKTOP-QG4RJGH\\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True";
            connect = new SqlConnection(cnStr);

            displayAllAvailableProducts();
            displayCategories();
            displayAllOrders();
            displayTotalPrice();
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            else
                return false;
        }

        private void displayAllAvailableProducts()
        {
            Product product = new Product();

            List<Product> products = product.GetAllAvailableProducts();

            dgvProds.DataSource = products;

            dgvProds.Columns["stock"].Visible = false;
            dgvProds.Columns["status"].Visible = false;
            dgvProds.Columns["date_insert"].Visible = false;
        }

        private void displayAllOrders()
        {
            Order oder = new Order();

            List<Order> oders = oder.GetAllOrders();

            dgvOrders.DataSource = oders;

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
                                cbxCate_Order.Items.Add(reader["category"].ToString());
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

        private float totalPrice = 0;

        private void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT SUM(total_price) FROM Orders WHERE customer_id=@cId";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        cmd.Parameters.AddWithValue("@cId", idGen);

                        object resutl = cmd.ExecuteScalar();

                        if (resutl != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(resutl);

                            lbTotal_Oder.Text = totalPrice.ToString();

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed display: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private void cbxCate_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProdId_Order.Items.Clear();

            lbPrice_Order.Text = "";
            lbProdName_Order.Text = "";
            numQuantity_Order.Value = 0;

            if (cbxCate_Order.SelectedItem == null)
                return;

            string selectedValue = cbxCate_Order.SelectedItem.ToString();

            if (selectedValue != null)
            {
                try
                {
                    connect.Open();

                    string selectSql = "SELECT * FROM Products WHERE category=@category AND status=@status AND stock>0";

                    using (SqlCommand cmd = new SqlCommand(selectSql, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbxProdId_Order.Items.Add(reader["prod_id"].ToString());
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed slect cate: " + ex.Message,
                                       "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cbxProdId_Order_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedValue = cbxProdId_Order.SelectedItem.ToString();

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
                                string prodName = reader["prod_name"].ToString();
                                float price = Convert.ToSingle(reader["price"]);

                                lbProdName_Order.Text = prodName;
                                lbPrice_Order.Text = price.ToString("0.00");
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

        private void btnAdd_Order_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cbxCate_Order.SelectedIndex == -1 || cbxProdId_Order.SelectedIndex == -1 ||
                lbProdName_Order.Text == "" || lbPrice_Order.Text == "" || numQuantity_Order.Value == 0)
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

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM Products WHERE prod_id=@prod_id";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prod_id", cbxProdId_Order.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);

                                    }
                                }
                            }
                        }

                        string insertSql = "INSERT INTO Orders VALUES(@cus_id,@prod_id,@prod_name," +
                                                                        "@cate,@qty,@origPrice,@totalPrice,@orderDate)";

                        using (SqlCommand insertCmd = new SqlCommand(insertSql, connect))
                        {
                            insertCmd.Parameters.AddWithValue("@cus_id", idGen);
                            insertCmd.Parameters.AddWithValue("@prod_id", cbxProdId_Order.SelectedItem);
                            insertCmd.Parameters.AddWithValue("@prod_name", lbProdName_Order.Text);
                            insertCmd.Parameters.AddWithValue("@cate", cbxCate_Order.SelectedItem);
                            insertCmd.Parameters.AddWithValue("@qty", numQuantity_Order.Value);
                            insertCmd.Parameters.AddWithValue("@origPrice", getPrice);

                            float totalP = getPrice * (int)numQuantity_Order.Value;
                            insertCmd.Parameters.AddWithValue("@totalPrice", totalP);

                            DateTime today = DateTime.Today;
                            insertCmd.Parameters.AddWithValue("@orderDate", today);

                            insertCmd.ExecuteNonQuery();



                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed Add: " + ex.Message,
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayAllOrders();
            displayTotalPrice();

        }

        private int idGen;

        private void IDGenerator()
        {
            if (checkConnection())
            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM Customers";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                idGen = 1;
                            }
                            else
                            {
                                idGen = temp + 1;
                            }
                        }
                        else
                        {
                            idGen = 1;
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

        private int idOder;
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dgvOrders.Rows[e.RowIndex];

            idOder = (int)row.Cells[0].Value;
        }

        private void btnRemove_Order_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to REMOVE Order Id: " + idOder + "?", "Comfirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string deleteDataSql = "DELETE FROM Orders WHERE id =@id";
                        using (SqlCommand deleteCmd = new SqlCommand(deleteDataSql, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", idOder);

                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Remove successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed Remove: " + ex.Message,
                                     "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayAllOrders();
            displayTotalPrice();
        }

        private void clearFields()
        {
            cbxCate_Order.SelectedIndex = -1;
            cbxProdId_Order.SelectedIndex = -1;
            lbPrice_Order.Text = "";
            lbProdName_Order.Text = "";
            lbPrice_Order.Text = "";
            numQuantity_Order.Value = 0;
        }

        private void btnClear_Order_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnPay_Oder_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (txtAmount_Oder.Text == ""||lbChange_Order.Text=="0.00" || dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to pay your oders?", "Confirmation Message",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string insertSql = "INSERT INTO Customers VALUES(@customer_id,@total_price,@amount,@change,@order_date)";

                            using (SqlCommand cmd = new SqlCommand(insertSql, connect))
                            {
                                cmd.Parameters.AddWithValue("@customer_id", idGen);
                                cmd.Parameters.AddWithValue("@total_price", lbTotal_Oder.Text);
                                cmd.Parameters.AddWithValue("@amount", txtAmount_Oder.Text);
                                cmd.Parameters.AddWithValue("@change", lbChange_Order.Text);

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@order_date", today);

                                cmd.ExecuteNonQuery();


                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();

                                foreach (DataGridViewRow row in dgvOrders.Rows)
                                {
                                    string prodId = row.Cells["prod_id_order"].Value.ToString();
                                    string prodName = row.Cells["prod_name_order"].Value.ToString();
                                    int qty = Convert.ToInt32(row.Cells["qty"].Value);

                                    string updateSql = "UPDATE Products SET stock=stock-@qty WHERE prod_id=@prod_id";
                                    using (SqlCommand updateCmd = new SqlCommand(updateSql, connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@qty", qty);
                                        updateCmd.Parameters.AddWithValue("@prod_id", prodId);

                                        updateCmd.ExecuteNonQuery();

                                        string selectStockSql = "SELECT prod_name, stock FROM Products WHERE prod_id = @prod_id";
                                        using (SqlCommand stockCmd = new SqlCommand(selectStockSql, connect))
                                        {
                                            stockCmd.Parameters.AddWithValue("@prod_id", prodId);
                                            using (SqlDataReader reader = stockCmd.ExecuteReader())
                                            {
                                                if (reader.Read())
                                                {
                                                    string prodNameMail = reader["prod_name"].ToString();
                                                    int currentStock = Convert.ToInt32(reader["stock"]);

                                                    if (currentStock < 20) 
                                                    {
                                                        SendLowStockAlert(prodId, prodNameMail, currentStock);
                                                    }
                                                }
                                            }

                                        }
                                    }

                                    string insertOrderSql = "INSERT INTO OrderDetails VALUES(@prod_id,@prod_name,@customer_id, @qty, @order_date)";
                                    using(SqlCommand insertOrderCmd = new SqlCommand(insertOrderSql, connect))
                                    {
                                        insertOrderCmd.Parameters.AddWithValue("@prod_id", prodId);
                                        insertOrderCmd.Parameters.AddWithValue("@prod_name", prodName);
                                        insertOrderCmd.Parameters.AddWithValue("@customer_id", idGen);
                                        insertOrderCmd.Parameters.AddWithValue("@qty", qty);
                                        insertOrderCmd.Parameters.AddWithValue("@order_date", today);

                                        insertOrderCmd.ExecuteNonQuery();

                                    }

                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed Pay: " + ex.Message,
                                      "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { connect.Close(); }
                    }
                }
            }
            displayTotalPrice();

        }

        private void txtAmount_Oder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float getAmount = Convert.ToSingle(txtAmount_Oder.Text);
                float getChange = getAmount - totalPrice;

                if (getChange <= -1)
                {
                    txtAmount_Oder.Text = "";
                    lbChange_Order.Text = "";
                }
                else
                {
                    lbChange_Order.Text = getChange.ToString();
                }
            }
        }

        private void dgvProds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row = dgvProds.Rows[e.RowIndex];

            var categoryValue = row.Cells["category"].Value.ToString();
            int index = cbxCate_Order.Items.IndexOf(categoryValue);
            cbxCate_Order.SelectedIndex = index;


            var prodValue = row.Cells["prod_id"].Value.ToString();
            int indexProd = cbxProdId_Order.Items.IndexOf(prodValue);
            cbxProdId_Order.SelectedIndex = indexProd;
        }


        private int rowIndex = 0;
        private void btnReceipt_Order_Click(object sender, EventArgs e)
        {
            if (txtAmount_Oder.Text == "" || dgvOrders.Rows.Count < 0)
            {
                MessageBox.Show("Please order first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
                printDocument.BeginPrint += new PrintEventHandler(printDocument_BeginPrint);

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            
        }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 5;
            int tableMargin = 5;

            Font font = new Font("Segoe UI", 12);
            Font bold = new Font("Segoe UI", 12, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 16, FontStyle.Bold);
            Font labelFont = new Font("Segoe UI", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Inventory Management System";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left +
                (dgvOrders.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;

            y += tableMargin;

            string[] header = { "ID","CID", "PID", "PName", "Category", "QTY", "OrigPrice","Total Price",};
            
            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dgvOrders.Rows.Count)
            {
                DataGridViewRow row = dgvOrders.Rows[rowIndex];

                for (int q = 0; q < dgvOrders.Columns.Count; q++)
                {
                    object cellValues = row.Cells[q].Value;
                    string cell = (cellValues != null) ? cellValues.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-------------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price:\t$" + totalPrice + "\nAmount:\t$" + txtAmount_Oder.Text.Trim()
                + "\n\t\t--------------------\nChange: \t$" + lbChange_Order.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right -
                e.Graphics.MeasureString("--------------------", labelFont).Width, y);
        }

        private void SendLowStockAlert(string prodId,string prodName, int stock)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("pongw.2210@gmail.com");
                mailMessage.To.Add("2254052006bong@ou.edu.vn");
                mailMessage.Subject = "Low Stock Alert";
                mailMessage.Body = $"Product '{prodName}' (ID: {prodId}) is low on stock. Remaining: {stock} items.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // dùng Gmail
                smtp.Credentials = new NetworkCredential("pongw.2210@gmail.com", "naok eohy xcrk qlup"); 
                smtp.EnableSsl = true;

                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send alert email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
