using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmCashierMain : Sample
    {
        private string _username;
        public frmCashierMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmCashierMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
            btnHome.PerformClick();

            lbUser.Text = "Welcome, " + _username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();

                this.Hide();

            }
        }

        public void AddFomrs(Form F)
        {
            this.centerPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            centerPanel.Controls.Add(F);

            F.Show();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            AddFomrs(new frmCashierOrder());
        }

        private void btnCustomer_Order_Click(object sender, EventArgs e)
        {
            AddFomrs(new frmCashierCustomer());
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            AddFomrs(new frmProduct());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddFomrs(new frmHome());
        }
    }
}
