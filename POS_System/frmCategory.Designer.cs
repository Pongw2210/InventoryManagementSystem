namespace POS_System
{
    partial class frmCategory
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCates = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch_AddCate = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear_AddCate = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate_AddCate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove_AddCate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_AddCate = new Guna.UI2.WinForms.Guna2Button();
            this.txtCate_AddCate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCates)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "All Categories";
            // 
            // dgvCates
            // 
            this.dgvCates.AllowUserToAddRows = false;
            this.dgvCates.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCates.ColumnHeadersHeight = 35;
            this.dgvCates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCates.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCates.Location = new System.Drawing.Point(17, 73);
            this.dgvCates.Name = "dgvCates";
            this.dgvCates.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCates.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCates.RowHeadersVisible = false;
            this.dgvCates.RowHeadersWidth = 62;
            this.dgvCates.RowTemplate.Height = 28;
            this.dgvCates.Size = new System.Drawing.Size(562, 560);
            this.dgvCates.TabIndex = 13;
            this.dgvCates.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCates.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCates.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCates.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCates.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCates.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCates.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCates.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCates.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCates.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCates.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCates.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCates.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCates.ThemeStyle.ReadOnly = true;
            this.dgvCates.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCates.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCates.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCates.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dgvCates.ThemeStyle.RowsStyle.Height = 28;
            this.dgvCates.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCates.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCates_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "category";
            this.Column2.FillWeight = 68.66219F;
            this.Column2.HeaderText = "Category";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "date";
            this.Column6.FillWeight = 68.66219F;
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSearch_AddCate);
            this.panel2.Controls.Add(this.dgvCates);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(384, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 651);
            this.panel2.TabIndex = 3;
            // 
            // txtSearch_AddCate
            // 
            this.txtSearch_AddCate.Animated = true;
            this.txtSearch_AddCate.AutoRoundedCorners = true;
            this.txtSearch_AddCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch_AddCate.DefaultText = "";
            this.txtSearch_AddCate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddCate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_AddCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch_AddCate.ForeColor = System.Drawing.Color.Black;
            this.txtSearch_AddCate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_AddCate.IconLeft = global::POS_System.Properties.Resources.search;
            this.txtSearch_AddCate.Location = new System.Drawing.Point(307, 16);
            this.txtSearch_AddCate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch_AddCate.Name = "txtSearch_AddCate";
            this.txtSearch_AddCate.PlaceholderText = "Search";
            this.txtSearch_AddCate.SelectedText = "";
            this.txtSearch_AddCate.Size = new System.Drawing.Size(272, 44);
            this.txtSearch_AddCate.TabIndex = 15;
            this.txtSearch_AddCate.TextChanged += new System.EventHandler(this.txtSearch_AddCate_TextChanged);
            // 
            // btnClear_AddCate
            // 
            this.btnClear_AddCate.Animated = true;
            this.btnClear_AddCate.AutoRoundedCorners = true;
            this.btnClear_AddCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear_AddCate.FillColor = System.Drawing.Color.Gold;
            this.btnClear_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear_AddCate.ForeColor = System.Drawing.Color.White;
            this.btnClear_AddCate.Location = new System.Drawing.Point(186, 330);
            this.btnClear_AddCate.Name = "btnClear_AddCate";
            this.btnClear_AddCate.Size = new System.Drawing.Size(128, 45);
            this.btnClear_AddCate.TabIndex = 11;
            this.btnClear_AddCate.Text = "Clear";
            this.btnClear_AddCate.Click += new System.EventHandler(this.btnClear_AddCate_Click);
            // 
            // btnUpdate_AddCate
            // 
            this.btnUpdate_AddCate.Animated = true;
            this.btnUpdate_AddCate.AutoRoundedCorners = true;
            this.btnUpdate_AddCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate_AddCate.FillColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate_AddCate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_AddCate.Location = new System.Drawing.Point(186, 244);
            this.btnUpdate_AddCate.Name = "btnUpdate_AddCate";
            this.btnUpdate_AddCate.Size = new System.Drawing.Size(128, 45);
            this.btnUpdate_AddCate.TabIndex = 10;
            this.btnUpdate_AddCate.Text = "Update";
            this.btnUpdate_AddCate.Click += new System.EventHandler(this.btnUpdate_AddCate_Click);
            // 
            // btnRemove_AddCate
            // 
            this.btnRemove_AddCate.Animated = true;
            this.btnRemove_AddCate.AutoRoundedCorners = true;
            this.btnRemove_AddCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove_AddCate.FillColor = System.Drawing.Color.Crimson;
            this.btnRemove_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove_AddCate.ForeColor = System.Drawing.Color.White;
            this.btnRemove_AddCate.Location = new System.Drawing.Point(28, 330);
            this.btnRemove_AddCate.Name = "btnRemove_AddCate";
            this.btnRemove_AddCate.Size = new System.Drawing.Size(128, 45);
            this.btnRemove_AddCate.TabIndex = 9;
            this.btnRemove_AddCate.Text = "Remove";
            this.btnRemove_AddCate.Click += new System.EventHandler(this.btnRemove_AddCate_Click);
            // 
            // btnAdd_AddCate
            // 
            this.btnAdd_AddCate.Animated = true;
            this.btnAdd_AddCate.AutoRoundedCorners = true;
            this.btnAdd_AddCate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddCate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd_AddCate.ForeColor = System.Drawing.Color.White;
            this.btnAdd_AddCate.Location = new System.Drawing.Point(28, 244);
            this.btnAdd_AddCate.Name = "btnAdd_AddCate";
            this.btnAdd_AddCate.Size = new System.Drawing.Size(128, 45);
            this.btnAdd_AddCate.TabIndex = 8;
            this.btnAdd_AddCate.Text = "Add";
            this.btnAdd_AddCate.Click += new System.EventHandler(this.btnAdd_AddCate_Click);
            // 
            // txtCate_AddCate
            // 
            this.txtCate_AddCate.Animated = true;
            this.txtCate_AddCate.AutoRoundedCorners = true;
            this.txtCate_AddCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCate_AddCate.DefaultText = "";
            this.txtCate_AddCate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCate_AddCate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCate_AddCate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCate_AddCate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCate_AddCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCate_AddCate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCate_AddCate.ForeColor = System.Drawing.Color.Black;
            this.txtCate_AddCate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCate_AddCate.Location = new System.Drawing.Point(28, 129);
            this.txtCate_AddCate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCate_AddCate.Name = "txtCate_AddCate";
            this.txtCate_AddCate.PlaceholderText = "";
            this.txtCate_AddCate.SelectedText = "";
            this.txtCate_AddCate.Size = new System.Drawing.Size(286, 52);
            this.txtCate_AddCate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClear_AddCate);
            this.panel1.Controls.Add(this.btnUpdate_AddCate);
            this.panel1.Controls.Add(this.btnRemove_AddCate);
            this.panel1.Controls.Add(this.btnAdd_AddCate);
            this.panel1.Controls.Add(this.txtCate_AddCate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 651);
            this.panel1.TabIndex = 2;
            // 
            // frmCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCates)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCates;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnClear_AddCate;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_AddCate;
        private Guna.UI2.WinForms.Guna2Button btnRemove_AddCate;
        private Guna.UI2.WinForms.Guna2Button btnAdd_AddCate;
        private Guna.UI2.WinForms.Guna2TextBox txtCate_AddCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_AddCate;
    }
}