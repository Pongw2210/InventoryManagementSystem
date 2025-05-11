namespace POS_System
{
    partial class frmUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear_AddUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_AddUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove_AddUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_AddUsers = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStatus_AddUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxRole_AddUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPassword_AddUsers = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername_AddUsers = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch_AddUsers = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear_AddUsers);
            this.panel1.Controls.Add(this.btnUpdate_AddUsers);
            this.panel1.Controls.Add(this.btnRemove_AddUsers);
            this.panel1.Controls.Add(this.btnAdd_AddUsers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxStatus_AddUsers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxRole_AddUsers);
            this.panel1.Controls.Add(this.txtPassword_AddUsers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername_AddUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 651);
            this.panel1.TabIndex = 0;
            // 
            // btnClear_AddUsers
            // 
            this.btnClear_AddUsers.Animated = true;
            this.btnClear_AddUsers.AutoRoundedCorners = true;
            this.btnClear_AddUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear_AddUsers.FillColor = System.Drawing.Color.Gold;
            this.btnClear_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear_AddUsers.ForeColor = System.Drawing.Color.White;
            this.btnClear_AddUsers.Location = new System.Drawing.Point(185, 472);
            this.btnClear_AddUsers.Name = "btnClear_AddUsers";
            this.btnClear_AddUsers.Size = new System.Drawing.Size(128, 45);
            this.btnClear_AddUsers.TabIndex = 11;
            this.btnClear_AddUsers.Text = "Clear";
            this.btnClear_AddUsers.Click += new System.EventHandler(this.btnClear_AddUsers_Click);
            // 
            // btnUpdate_AddUsers
            // 
            this.btnUpdate_AddUsers.Animated = true;
            this.btnUpdate_AddUsers.AutoRoundedCorners = true;
            this.btnUpdate_AddUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_AddUsers.FillColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_AddUsers.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_AddUsers.Location = new System.Drawing.Point(185, 386);
            this.btnUpdate_AddUsers.Name = "btnUpdate_AddUsers";
            this.btnUpdate_AddUsers.Size = new System.Drawing.Size(128, 45);
            this.btnUpdate_AddUsers.TabIndex = 10;
            this.btnUpdate_AddUsers.Text = "Update";
            this.btnUpdate_AddUsers.Click += new System.EventHandler(this.btnUpdate_AddUsers_Click);
            // 
            // btnRemove_AddUsers
            // 
            this.btnRemove_AddUsers.Animated = true;
            this.btnRemove_AddUsers.AutoRoundedCorners = true;
            this.btnRemove_AddUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove_AddUsers.FillColor = System.Drawing.Color.Crimson;
            this.btnRemove_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove_AddUsers.ForeColor = System.Drawing.Color.White;
            this.btnRemove_AddUsers.Location = new System.Drawing.Point(27, 472);
            this.btnRemove_AddUsers.Name = "btnRemove_AddUsers";
            this.btnRemove_AddUsers.Size = new System.Drawing.Size(128, 45);
            this.btnRemove_AddUsers.TabIndex = 9;
            this.btnRemove_AddUsers.Text = "Remove";
            this.btnRemove_AddUsers.Click += new System.EventHandler(this.btnRemove_AddUsers_Click);
            // 
            // btnAdd_AddUsers
            // 
            this.btnAdd_AddUsers.Animated = true;
            this.btnAdd_AddUsers.AutoRoundedCorners = true;
            this.btnAdd_AddUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd_AddUsers.ForeColor = System.Drawing.Color.White;
            this.btnAdd_AddUsers.Location = new System.Drawing.Point(27, 386);
            this.btnAdd_AddUsers.Name = "btnAdd_AddUsers";
            this.btnAdd_AddUsers.Size = new System.Drawing.Size(128, 45);
            this.btnAdd_AddUsers.TabIndex = 8;
            this.btnAdd_AddUsers.Text = "Add";
            this.btnAdd_AddUsers.Click += new System.EventHandler(this.btnAdd_AddUsers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // cbxStatus_AddUsers
            // 
            this.cbxStatus_AddUsers.AutoRoundedCorners = true;
            this.cbxStatus_AddUsers.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus_AddUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStatus_AddUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus_AddUsers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus_AddUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStatus_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxStatus_AddUsers.ForeColor = System.Drawing.Color.Black;
            this.cbxStatus_AddUsers.ItemHeight = 30;
            this.cbxStatus_AddUsers.Items.AddRange(new object[] {
            "Active ",
            "Inactive",
            "Approval"});
            this.cbxStatus_AddUsers.Location = new System.Drawing.Point(27, 303);
            this.cbxStatus_AddUsers.Name = "cbxStatus_AddUsers";
            this.cbxStatus_AddUsers.Size = new System.Drawing.Size(286, 36);
            this.cbxStatus_AddUsers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // cbxRole_AddUsers
            // 
            this.cbxRole_AddUsers.AutoRoundedCorners = true;
            this.cbxRole_AddUsers.BackColor = System.Drawing.Color.Transparent;
            this.cbxRole_AddUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxRole_AddUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole_AddUsers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRole_AddUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxRole_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxRole_AddUsers.ForeColor = System.Drawing.Color.Black;
            this.cbxRole_AddUsers.ItemHeight = 30;
            this.cbxRole_AddUsers.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbxRole_AddUsers.Location = new System.Drawing.Point(27, 221);
            this.cbxRole_AddUsers.Name = "cbxRole_AddUsers";
            this.cbxRole_AddUsers.Size = new System.Drawing.Size(286, 36);
            this.cbxRole_AddUsers.TabIndex = 4;
            // 
            // txtPassword_AddUsers
            // 
            this.txtPassword_AddUsers.Animated = true;
            this.txtPassword_AddUsers.AutoRoundedCorners = true;
            this.txtPassword_AddUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword_AddUsers.DefaultText = "";
            this.txtPassword_AddUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_AddUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_AddUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_AddUsers.ForeColor = System.Drawing.Color.Black;
            this.txtPassword_AddUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_AddUsers.Location = new System.Drawing.Point(27, 135);
            this.txtPassword_AddUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword_AddUsers.Name = "txtPassword_AddUsers";
            this.txtPassword_AddUsers.PlaceholderText = "";
            this.txtPassword_AddUsers.SelectedText = "";
            this.txtPassword_AddUsers.Size = new System.Drawing.Size(286, 39);
            this.txtPassword_AddUsers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtUsername_AddUsers
            // 
            this.txtUsername_AddUsers.Animated = true;
            this.txtUsername_AddUsers.AutoRoundedCorners = true;
            this.txtUsername_AddUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername_AddUsers.DefaultText = "";
            this.txtUsername_AddUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_AddUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_AddUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername_AddUsers.ForeColor = System.Drawing.Color.Black;
            this.txtUsername_AddUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_AddUsers.Location = new System.Drawing.Point(27, 49);
            this.txtUsername_AddUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername_AddUsers.Name = "txtUsername_AddUsers";
            this.txtUsername_AddUsers.PlaceholderText = "";
            this.txtUsername_AddUsers.SelectedText = "";
            this.txtUsername_AddUsers.Size = new System.Drawing.Size(286, 39);
            this.txtUsername_AddUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtSearch_AddUsers);
            this.panel2.Controls.Add(this.dgvUsers);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(391, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 651);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch_AddUsers
            // 
            this.txtSearch_AddUsers.Animated = true;
            this.txtSearch_AddUsers.AutoRoundedCorners = true;
            this.txtSearch_AddUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch_AddUsers.DefaultText = "";
            this.txtSearch_AddUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch_AddUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch_AddUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch_AddUsers.ForeColor = System.Drawing.Color.Black;
            this.txtSearch_AddUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddUsers.IconLeft = global::POS_System.Properties.Resources.search;
            this.txtSearch_AddUsers.Location = new System.Drawing.Point(307, 16);
            this.txtSearch_AddUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch_AddUsers.Name = "txtSearch_AddUsers";
            this.txtSearch_AddUsers.PlaceholderText = "Search";
            this.txtSearch_AddUsers.SelectedText = "";
            this.txtSearch_AddUsers.Size = new System.Drawing.Size(272, 44);
            this.txtSearch_AddUsers.TabIndex = 14;
            this.txtSearch_AddUsers.TextChanged += new System.EventHandler(this.txtSearch_AddUsers_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(17, 69);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(562, 564);
            this.dgvUsers.TabIndex = 13;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 28;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "username";
            this.Column2.FillWeight = 56.31498F;
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "password";
            this.Column3.FillWeight = 56.31498F;
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "role";
            this.Column4.FillWeight = 56.31498F;
            this.Column4.HeaderText = "Role";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "status";
            this.Column5.FillWeight = 56.31498F;
            this.Column5.HeaderText = "Status";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 65;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date";
            this.Column6.FillWeight = 56.31498F;
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "All User\'s Data";
            // 
            // frmUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername_AddUsers;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAdd_AddUsers;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStatus_AddUsers;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbxRole_AddUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword_AddUsers;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_AddUsers;
        private Guna.UI2.WinForms.Guna2Button btnRemove_AddUsers;
        private Guna.UI2.WinForms.Guna2Button btnClear_AddUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_AddUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}