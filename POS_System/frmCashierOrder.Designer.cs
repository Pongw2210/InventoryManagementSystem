namespace POS_System
{
    partial class frmCashierOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProds = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPay_Oder = new Guna.UI2.WinForms.Guna2Button();
            this.btnReceipt_Order = new Guna.UI2.WinForms.Guna2Button();
            this.lbChange_Order = new System.Windows.Forms.Label();
            this.lbTotal_Oder = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount_Oder = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd_Order = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove_Order = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear_Order = new Guna.UI2.WinForms.Guna2Button();
            this.numQuantity_Order = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProdName_Order = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrice_Order = new System.Windows.Forms.Label();
            this.cbxProdId_Order = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCate_Order = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProds);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 334);
            this.panel1.TabIndex = 0;
            // 
            // dgvProds
            // 
            this.dgvProds.AllowUserToAddRows = false;
            this.dgvProds.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProds.ColumnHeadersHeight = 35;
            this.dgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod_id,
            this.prod_name,
            this.category,
            this.price,
            this.stock,
            this.image,
            this.status,
            this.date_insert});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProds.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProds.Location = new System.Drawing.Point(14, 59);
            this.dgvProds.Name = "dgvProds";
            this.dgvProds.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProds.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProds.RowHeadersVisible = false;
            this.dgvProds.RowHeadersWidth = 62;
            this.dgvProds.RowTemplate.Height = 28;
            this.dgvProds.Size = new System.Drawing.Size(583, 250);
            this.dgvProds.TabIndex = 17;
            this.dgvProds.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProds.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProds.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProds.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProds.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProds.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProds.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProds.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProds.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProds.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProds.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProds.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProds.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvProds.ThemeStyle.ReadOnly = true;
            this.dgvProds.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProds.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProds.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProds.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvProds.ThemeStyle.RowsStyle.Height = 28;
            this.dgvProds.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProds.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProds_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "Prod_id";
            this.prod_id.MinimumWidth = 8;
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            // 
            // prod_name
            // 
            this.prod_name.DataPropertyName = "prod_name";
            this.prod_name.HeaderText = "Prod_name";
            this.prod_name.MinimumWidth = 8;
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 8;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "image_data";
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // date_insert
            // 
            this.date_insert.DataPropertyName = "date_insert";
            this.date_insert.HeaderText = "Date";
            this.date_insert.MinimumWidth = 8;
            this.date_insert.Name = "date_insert";
            this.date_insert.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Available Products";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrders);
            this.panel2.Controls.Add(this.btnPay_Oder);
            this.panel2.Controls.Add(this.btnReceipt_Order);
            this.panel2.Controls.Add(this.lbChange_Order);
            this.panel2.Controls.Add(this.lbTotal_Oder);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtAmount_Oder);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(637, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 661);
            this.panel2.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders.ColumnHeadersHeight = 35;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_order,
            this.prod_id_order,
            this.prod_name_order,
            this.cate_order,
            this.qty});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrders.Location = new System.Drawing.Point(3, 59);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(345, 275);
            this.dgvOrders.TabIndex = 18;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrders.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvOrders.ThemeStyle.ReadOnly = true;
            this.dgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvOrders.ThemeStyle.RowsStyle.Height = 28;
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // btnPay_Oder
            // 
            this.btnPay_Oder.Animated = true;
            this.btnPay_Oder.AutoRoundedCorners = true;
            this.btnPay_Oder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay_Oder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay_Oder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay_Oder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay_Oder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay_Oder.ForeColor = System.Drawing.Color.White;
            this.btnPay_Oder.Location = new System.Drawing.Point(6, 483);
            this.btnPay_Oder.Name = "btnPay_Oder";
            this.btnPay_Oder.Size = new System.Drawing.Size(345, 45);
            this.btnPay_Oder.TabIndex = 25;
            this.btnPay_Oder.Text = "Pay Orders";
            this.btnPay_Oder.Click += new System.EventHandler(this.btnPay_Oder_Click);
            // 
            // btnReceipt_Order
            // 
            this.btnReceipt_Order.Animated = true;
            this.btnReceipt_Order.AutoRoundedCorners = true;
            this.btnReceipt_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReceipt_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReceipt_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReceipt_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReceipt_Order.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReceipt_Order.ForeColor = System.Drawing.Color.White;
            this.btnReceipt_Order.Location = new System.Drawing.Point(6, 544);
            this.btnReceipt_Order.Name = "btnReceipt_Order";
            this.btnReceipt_Order.Size = new System.Drawing.Size(345, 45);
            this.btnReceipt_Order.TabIndex = 26;
            this.btnReceipt_Order.Text = "Receipt";
            this.btnReceipt_Order.Click += new System.EventHandler(this.btnReceipt_Order_Click);
            // 
            // lbChange_Order
            // 
            this.lbChange_Order.AutoSize = true;
            this.lbChange_Order.Location = new System.Drawing.Point(174, 440);
            this.lbChange_Order.Name = "lbChange_Order";
            this.lbChange_Order.Size = new System.Drawing.Size(49, 28);
            this.lbChange_Order.TabIndex = 26;
            this.lbChange_Order.Text = "0.00";
            // 
            // lbTotal_Oder
            // 
            this.lbTotal_Oder.AutoSize = true;
            this.lbTotal_Oder.Location = new System.Drawing.Point(174, 370);
            this.lbTotal_Oder.Name = "lbTotal_Oder";
            this.lbTotal_Oder.Size = new System.Drawing.Size(49, 28);
            this.lbTotal_Oder.TabIndex = 25;
            this.lbTotal_Oder.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 28);
            this.label12.TabIndex = 23;
            this.label12.Text = "Change: ";
            // 
            // txtAmount_Oder
            // 
            this.txtAmount_Oder.Animated = true;
            this.txtAmount_Oder.AutoRoundedCorners = true;
            this.txtAmount_Oder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount_Oder.DefaultText = "";
            this.txtAmount_Oder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount_Oder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount_Oder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount_Oder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount_Oder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount_Oder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount_Oder.ForeColor = System.Drawing.Color.Black;
            this.txtAmount_Oder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount_Oder.Location = new System.Drawing.Point(157, 402);
            this.txtAmount_Oder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount_Oder.Name = "txtAmount_Oder";
            this.txtAmount_Oder.PlaceholderText = "";
            this.txtAmount_Oder.SelectedText = "";
            this.txtAmount_Oder.Size = new System.Drawing.Size(158, 36);
            this.txtAmount_Oder.TabIndex = 22;
            this.txtAmount_Oder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_Oder_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "Amount($):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total Price($):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "All Orders";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd_Order);
            this.panel3.Controls.Add(this.btnRemove_Order);
            this.panel3.Controls.Add(this.btnClear_Order);
            this.panel3.Controls.Add(this.numQuantity_Order);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbProdName_Order);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbPrice_Order);
            this.panel3.Controls.Add(this.cbxProdId_Order);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxCate_Order);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 308);
            this.panel3.TabIndex = 1;
            // 
            // btnAdd_Order
            // 
            this.btnAdd_Order.Animated = true;
            this.btnAdd_Order.AutoRoundedCorners = true;
            this.btnAdd_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Order.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Order.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Order.Location = new System.Drawing.Point(29, 193);
            this.btnAdd_Order.Name = "btnAdd_Order";
            this.btnAdd_Order.Size = new System.Drawing.Size(128, 45);
            this.btnAdd_Order.TabIndex = 19;
            this.btnAdd_Order.Text = "Add";
            this.btnAdd_Order.Click += new System.EventHandler(this.btnAdd_Order_Click);
            // 
            // btnRemove_Order
            // 
            this.btnRemove_Order.Animated = true;
            this.btnRemove_Order.AutoRoundedCorners = true;
            this.btnRemove_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove_Order.FillColor = System.Drawing.Color.Crimson;
            this.btnRemove_Order.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove_Order.ForeColor = System.Drawing.Color.White;
            this.btnRemove_Order.Location = new System.Drawing.Point(231, 193);
            this.btnRemove_Order.Name = "btnRemove_Order";
            this.btnRemove_Order.Size = new System.Drawing.Size(128, 45);
            this.btnRemove_Order.TabIndex = 20;
            this.btnRemove_Order.Text = "Remove";
            this.btnRemove_Order.Click += new System.EventHandler(this.btnRemove_Order_Click);
            // 
            // btnClear_Order
            // 
            this.btnClear_Order.Animated = true;
            this.btnClear_Order.AutoRoundedCorners = true;
            this.btnClear_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear_Order.FillColor = System.Drawing.Color.Gold;
            this.btnClear_Order.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear_Order.ForeColor = System.Drawing.Color.White;
            this.btnClear_Order.Location = new System.Drawing.Point(435, 193);
            this.btnClear_Order.Name = "btnClear_Order";
            this.btnClear_Order.Size = new System.Drawing.Size(128, 45);
            this.btnClear_Order.TabIndex = 21;
            this.btnClear_Order.Text = "Clear";
            this.btnClear_Order.Click += new System.EventHandler(this.btnClear_Order_Click);
            // 
            // numQuantity_Order
            // 
            this.numQuantity_Order.AutoRoundedCorners = true;
            this.numQuantity_Order.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity_Order.BorderRadius = 17;
            this.numQuantity_Order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity_Order.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity_Order.Location = new System.Drawing.Point(435, 80);
            this.numQuantity_Order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numQuantity_Order.Name = "numQuantity_Order";
            this.numQuantity_Order.Size = new System.Drawing.Size(162, 36);
            this.numQuantity_Order.TabIndex = 24;
            this.numQuantity_Order.UseTransparentBackground = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Product Name:";
            // 
            // lbProdName_Order
            // 
            this.lbProdName_Order.AutoSize = true;
            this.lbProdName_Order.Location = new System.Drawing.Point(166, 83);
            this.lbProdName_Order.Name = "lbProdName_Order";
            this.lbProdName_Order.Size = new System.Drawing.Size(0, 28);
            this.lbProdName_Order.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price($):";
            // 
            // lbPrice_Order
            // 
            this.lbPrice_Order.AutoSize = true;
            this.lbPrice_Order.Location = new System.Drawing.Point(140, 147);
            this.lbPrice_Order.Name = "lbPrice_Order";
            this.lbPrice_Order.Size = new System.Drawing.Size(0, 28);
            this.lbPrice_Order.TabIndex = 19;
            // 
            // cbxProdId_Order
            // 
            this.cbxProdId_Order.AutoRoundedCorners = true;
            this.cbxProdId_Order.BackColor = System.Drawing.Color.Transparent;
            this.cbxProdId_Order.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxProdId_Order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProdId_Order.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxProdId_Order.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxProdId_Order.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxProdId_Order.ForeColor = System.Drawing.Color.Black;
            this.cbxProdId_Order.ItemHeight = 30;
            this.cbxProdId_Order.Location = new System.Drawing.Point(435, 17);
            this.cbxProdId_Order.Name = "cbxProdId_Order";
            this.cbxProdId_Order.Size = new System.Drawing.Size(162, 36);
            this.cbxProdId_Order.TabIndex = 18;
            this.cbxProdId_Order.SelectedIndexChanged += new System.EventHandler(this.cbxProdId_Order_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product_ID:";
            // 
            // cbxCate_Order
            // 
            this.cbxCate_Order.AutoRoundedCorners = true;
            this.cbxCate_Order.BackColor = System.Drawing.Color.Transparent;
            this.cbxCate_Order.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCate_Order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCate_Order.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCate_Order.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCate_Order.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCate_Order.ForeColor = System.Drawing.Color.Black;
            this.cbxCate_Order.ItemHeight = 30;
            this.cbxCate_Order.Location = new System.Drawing.Point(114, 17);
            this.cbxCate_Order.Name = "cbxCate_Order";
            this.cbxCate_Order.Size = new System.Drawing.Size(162, 36);
            this.cbxCate_Order.TabIndex = 16;
            this.cbxCate_Order.SelectedIndexChanged += new System.EventHandler(this.cbxCate_Order_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Category:";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(625, 12);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 661);
            this.guna2VSeparator1.TabIndex = 27;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // id_order
            // 
            this.id_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_order.DataPropertyName = "id";
            this.id_order.HeaderText = "Id";
            this.id_order.MinimumWidth = 8;
            this.id_order.Name = "id_order";
            this.id_order.ReadOnly = true;
            this.id_order.Width = 63;
            // 
            // prod_id_order
            // 
            this.prod_id_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prod_id_order.DataPropertyName = "prod_id";
            this.prod_id_order.HeaderText = "Prod_id";
            this.prod_id_order.MinimumWidth = 8;
            this.prod_id_order.Name = "prod_id_order";
            this.prod_id_order.ReadOnly = true;
            this.prod_id_order.Width = 113;
            // 
            // prod_name_order
            // 
            this.prod_name_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prod_name_order.DataPropertyName = "prod_name";
            this.prod_name_order.HeaderText = "Prod_name";
            this.prod_name_order.MinimumWidth = 8;
            this.prod_name_order.Name = "prod_name_order";
            this.prod_name_order.ReadOnly = true;
            this.prod_name_order.Width = 144;
            // 
            // cate_order
            // 
            this.cate_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cate_order.DataPropertyName = "category";
            this.cate_order.HeaderText = "Category";
            this.cate_order.MinimumWidth = 8;
            this.cate_order.Name = "cate_order";
            this.cate_order.ReadOnly = true;
            this.cate_order.Width = 126;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 78;
            // 
            // frmCashierOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmCashierOrder";
            this.Text = "frmCashierOder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity_Order;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbProdName_Order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPrice_Order;
        private Guna.UI2.WinForms.Guna2ComboBox cbxProdId_Order;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCate_Order;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Order;
        private Guna.UI2.WinForms.Guna2Button btnRemove_Order;
        private Guna.UI2.WinForms.Guna2Button btnClear_Order;
        private Guna.UI2.WinForms.Guna2Button btnPay_Oder;
        private Guna.UI2.WinForms.Guna2Button btnReceipt_Order;
        private System.Windows.Forms.Label lbChange_Order;
        private System.Windows.Forms.Label lbTotal_Oder;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount_Oder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_insert;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
    }
}