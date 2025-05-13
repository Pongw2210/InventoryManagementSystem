namespace POS_System
{
    partial class frmProduct
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
            this.btnImport_AddProd = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxImage_AddProd = new System.Windows.Forms.PictureBox();
            this.btnClear_AddProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_AddProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove_AddProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_AddProd = new Guna.UI2.WinForms.Guna2Button();
            this.cbxStatus_AddProd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxCate_AddProd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock_AddProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice_AddProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName_AddProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_AddProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProds = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch_AddProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage_AddProd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport_AddProd
            // 
            this.btnImport_AddProd.Animated = true;
            this.btnImport_AddProd.AutoRoundedCorners = true;
            this.btnImport_AddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImport_AddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImport_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImport_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImport_AddProd.FillColor = System.Drawing.Color.DarkBlue;
            this.btnImport_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnImport_AddProd.ForeColor = System.Drawing.Color.White;
            this.btnImport_AddProd.Location = new System.Drawing.Point(807, 146);
            this.btnImport_AddProd.Name = "btnImport_AddProd";
            this.btnImport_AddProd.Size = new System.Drawing.Size(128, 42);
            this.btnImport_AddProd.TabIndex = 21;
            this.btnImport_AddProd.Text = "Import";
            this.btnImport_AddProd.Click += new System.EventHandler(this.btnImport_AddProd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.pbxImage_AddProd);
            this.panel3.Location = new System.Drawing.Point(811, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 120);
            this.panel3.TabIndex = 20;
            // 
            // pbxImage_AddProd
            // 
            this.pbxImage_AddProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImage_AddProd.Location = new System.Drawing.Point(0, 0);
            this.pbxImage_AddProd.Name = "pbxImage_AddProd";
            this.pbxImage_AddProd.Size = new System.Drawing.Size(120, 120);
            this.pbxImage_AddProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage_AddProd.TabIndex = 0;
            this.pbxImage_AddProd.TabStop = false;
            // 
            // btnClear_AddProd
            // 
            this.btnClear_AddProd.Animated = true;
            this.btnClear_AddProd.AutoRoundedCorners = true;
            this.btnClear_AddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear_AddProd.FillColor = System.Drawing.Color.Gold;
            this.btnClear_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear_AddProd.ForeColor = System.Drawing.Color.White;
            this.btnClear_AddProd.Location = new System.Drawing.Point(594, 229);
            this.btnClear_AddProd.Name = "btnClear_AddProd";
            this.btnClear_AddProd.Size = new System.Drawing.Size(128, 45);
            this.btnClear_AddProd.TabIndex = 19;
            this.btnClear_AddProd.Text = "Clear";
            this.btnClear_AddProd.Click += new System.EventHandler(this.btnClear_AddProd_Click);
            // 
            // btnUpdate_AddProd
            // 
            this.btnUpdate_AddProd.Animated = true;
            this.btnUpdate_AddProd.AutoRoundedCorners = true;
            this.btnUpdate_AddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_AddProd.FillColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_AddProd.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_AddProd.Location = new System.Drawing.Point(215, 229);
            this.btnUpdate_AddProd.Name = "btnUpdate_AddProd";
            this.btnUpdate_AddProd.Size = new System.Drawing.Size(128, 45);
            this.btnUpdate_AddProd.TabIndex = 18;
            this.btnUpdate_AddProd.Text = "Update";
            this.btnUpdate_AddProd.Click += new System.EventHandler(this.btnUpdate_AddProd_Click);
            // 
            // btnRemove_AddProd
            // 
            this.btnRemove_AddProd.Animated = true;
            this.btnRemove_AddProd.AutoRoundedCorners = true;
            this.btnRemove_AddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove_AddProd.FillColor = System.Drawing.Color.Crimson;
            this.btnRemove_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove_AddProd.ForeColor = System.Drawing.Color.White;
            this.btnRemove_AddProd.Location = new System.Drawing.Point(399, 229);
            this.btnRemove_AddProd.Name = "btnRemove_AddProd";
            this.btnRemove_AddProd.Size = new System.Drawing.Size(128, 45);
            this.btnRemove_AddProd.TabIndex = 17;
            this.btnRemove_AddProd.Text = "Remove";
            this.btnRemove_AddProd.Click += new System.EventHandler(this.btnRemove_AddProd_Click);
            // 
            // btnAdd_AddProd
            // 
            this.btnAdd_AddProd.Animated = true;
            this.btnAdd_AddProd.AutoRoundedCorners = true;
            this.btnAdd_AddProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd_AddProd.ForeColor = System.Drawing.Color.White;
            this.btnAdd_AddProd.Location = new System.Drawing.Point(34, 229);
            this.btnAdd_AddProd.Name = "btnAdd_AddProd";
            this.btnAdd_AddProd.Size = new System.Drawing.Size(128, 45);
            this.btnAdd_AddProd.TabIndex = 16;
            this.btnAdd_AddProd.Text = "Add";
            this.btnAdd_AddProd.Click += new System.EventHandler(this.btnAdd_AddProd_Click);
            // 
            // cbxStatus_AddProd
            // 
            this.cbxStatus_AddProd.AutoRoundedCorners = true;
            this.cbxStatus_AddProd.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus_AddProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus_AddProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus_AddProd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxStatus_AddProd.ForeColor = System.Drawing.Color.Black;
            this.cbxStatus_AddProd.ItemHeight = 30;
            this.cbxStatus_AddProd.Items.AddRange(new object[] {
            "Available ",
            "Not Available"});
            this.cbxStatus_AddProd.Location = new System.Drawing.Point(509, 105);
            this.cbxStatus_AddProd.Name = "cbxStatus_AddProd";
            this.cbxStatus_AddProd.Size = new System.Drawing.Size(209, 36);
            this.cbxStatus_AddProd.TabIndex = 15;
            // 
            // cbxCate_AddProd
            // 
            this.cbxCate_AddProd.AutoRoundedCorners = true;
            this.cbxCate_AddProd.BackColor = System.Drawing.Color.Transparent;
            this.cbxCate_AddProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCate_AddProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCate_AddProd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCate_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCate_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxCate_AddProd.ForeColor = System.Drawing.Color.Black;
            this.cbxCate_AddProd.ItemHeight = 30;
            this.cbxCate_AddProd.Location = new System.Drawing.Point(145, 108);
            this.cbxCate_AddProd.Name = "cbxCate_AddProd";
            this.cbxCate_AddProd.Size = new System.Drawing.Size(209, 36);
            this.cbxCate_AddProd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // txtStock_AddProd
            // 
            this.txtStock_AddProd.Animated = true;
            this.txtStock_AddProd.AutoRoundedCorners = true;
            this.txtStock_AddProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock_AddProd.DefaultText = "";
            this.txtStock_AddProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStock_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStock_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock_AddProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock_AddProd.ForeColor = System.Drawing.Color.Black;
            this.txtStock_AddProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock_AddProd.Location = new System.Drawing.Point(509, 60);
            this.txtStock_AddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock_AddProd.Name = "txtStock_AddProd";
            this.txtStock_AddProd.PlaceholderText = "";
            this.txtStock_AddProd.SelectedText = "";
            this.txtStock_AddProd.Size = new System.Drawing.Size(209, 36);
            this.txtStock_AddProd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock:";
            // 
            // txtPrice_AddProd
            // 
            this.txtPrice_AddProd.Animated = true;
            this.txtPrice_AddProd.AutoRoundedCorners = true;
            this.txtPrice_AddProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice_AddProd.DefaultText = "";
            this.txtPrice_AddProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice_AddProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice_AddProd.ForeColor = System.Drawing.Color.Black;
            this.txtPrice_AddProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice_AddProd.Location = new System.Drawing.Point(509, 18);
            this.txtPrice_AddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice_AddProd.Name = "txtPrice_AddProd";
            this.txtPrice_AddProd.PlaceholderText = "";
            this.txtPrice_AddProd.SelectedText = "";
            this.txtPrice_AddProd.Size = new System.Drawing.Size(209, 36);
            this.txtPrice_AddProd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price($):";
            // 
            // txtName_AddProd
            // 
            this.txtName_AddProd.Animated = true;
            this.txtName_AddProd.AutoRoundedCorners = true;
            this.txtName_AddProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName_AddProd.DefaultText = "";
            this.txtName_AddProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName_AddProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName_AddProd.ForeColor = System.Drawing.Color.Black;
            this.txtName_AddProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName_AddProd.Location = new System.Drawing.Point(145, 67);
            this.txtName_AddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName_AddProd.Name = "txtName_AddProd";
            this.txtName_AddProd.PlaceholderText = "";
            this.txtName_AddProd.SelectedText = "";
            this.txtName_AddProd.Size = new System.Drawing.Size(209, 36);
            this.txtName_AddProd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name:";
            // 
            // txtId_AddProd
            // 
            this.txtId_AddProd.Animated = true;
            this.txtId_AddProd.AutoRoundedCorners = true;
            this.txtId_AddProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId_AddProd.DefaultText = "";
            this.txtId_AddProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId_AddProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId_AddProd.ForeColor = System.Drawing.Color.Black;
            this.txtId_AddProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId_AddProd.Location = new System.Drawing.Point(145, 21);
            this.txtId_AddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId_AddProd.Name = "txtId_AddProd";
            this.txtId_AddProd.PlaceholderText = "";
            this.txtId_AddProd.SelectedText = "";
            this.txtId_AddProd.Size = new System.Drawing.Size(209, 36);
            this.txtId_AddProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbxSupplier);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnImport_AddProd);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnClear_AddProd);
            this.panel2.Controls.Add(this.btnUpdate_AddProd);
            this.panel2.Controls.Add(this.btnRemove_AddProd);
            this.panel2.Controls.Add(this.btnAdd_AddProd);
            this.panel2.Controls.Add(this.cbxStatus_AddProd);
            this.panel2.Controls.Add(this.cbxCate_AddProd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtStock_AddProd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrice_AddProd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtName_AddProd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtId_AddProd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 366);
            this.panel2.TabIndex = 3;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoRoundedCorners = true;
            this.cbxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cbxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSupplier.ForeColor = System.Drawing.Color.Black;
            this.cbxSupplier.ItemHeight = 30;
            this.cbxSupplier.Location = new System.Drawing.Point(145, 152);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(209, 36);
            this.cbxSupplier.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Supplier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "All Products";
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
            this.Id,
            this.prod_id,
            this.prod_name,
            this.cate,
            this.price,
            this.stock,
            this.image,
            this.status,
            this.date,
            this.sup_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProds.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProds.Location = new System.Drawing.Point(3, 60);
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
            this.dgvProds.Size = new System.Drawing.Size(970, 222);
            this.dgvProds.TabIndex = 14;
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
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // cate
            // 
            this.cate.DataPropertyName = "category";
            this.cate.HeaderText = "Category";
            this.cate.MinimumWidth = 8;
            this.cate.Name = "cate";
            this.cate.ReadOnly = true;
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
            // date
            // 
            this.date.DataPropertyName = "date_insert";
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // sup_name
            // 
            this.sup_name.DataPropertyName = "supplier_name";
            this.sup_name.HeaderText = "Sup_Name";
            this.sup_name.MinimumWidth = 8;
            this.sup_name.Name = "sup_name";
            this.sup_name.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearch_AddProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvProds);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 289);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch_AddProd
            // 
            this.txtSearch_AddProd.Animated = true;
            this.txtSearch_AddProd.AutoRoundedCorners = true;
            this.txtSearch_AddProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch_AddProd.DefaultText = "";
            this.txtSearch_AddProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch_AddProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch_AddProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddProd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch_AddProd.ForeColor = System.Drawing.Color.Black;
            this.txtSearch_AddProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddProd.IconLeft = global::POS_System.Properties.Resources.search;
            this.txtSearch_AddProd.Location = new System.Drawing.Point(690, 6);
            this.txtSearch_AddProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch_AddProd.Name = "txtSearch_AddProd";
            this.txtSearch_AddProd.PlaceholderText = "Search";
            this.txtSearch_AddProd.SelectedText = "";
            this.txtSearch_AddProd.Size = new System.Drawing.Size(272, 44);
            this.txtSearch_AddProd.TabIndex = 17;
            this.txtSearch_AddProd.TextChanged += new System.EventHandler(this.txtSearch_AddProd_TextChanged);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage_AddProd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnImport_AddProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxImage_AddProd;
        private Guna.UI2.WinForms.Guna2Button btnClear_AddProd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_AddProd;
        private Guna.UI2.WinForms.Guna2Button btnRemove_AddProd;
        private Guna.UI2.WinForms.Guna2Button btnAdd_AddProd;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatus_AddProd;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCate_AddProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtStock_AddProd;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice_AddProd;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtName_AddProd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtId_AddProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProds;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_AddProd;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup_name;
    }
}