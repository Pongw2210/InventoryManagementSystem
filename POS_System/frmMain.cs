using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmMain : Sample
    {
        private string _username;

        public frmMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
            btnHome.PerformClick();

            lbUser.Text = "Welcome, " + _username;
        }

        public void AddForm(Form F)
        {
            this.centerPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            centerPanel.Controls.Add(F);

            F.Show();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AddForm(new frmUser());
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            AddForm(new frmHome());
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            AddForm(new frmCategory());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddForm(new frmProduct());
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            AddForm(new frmCashierCustomer());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            AddForm(new frmStatistic());
        }
    }
}
