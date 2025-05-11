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
    public partial class frmCashierCustomer : Sample
    {
        public frmCashierCustomer()
        {
            InitializeComponent();
            displayCustomer();
        }

        public void displayCustomer()
        {
            Customer customer = new Customer();

            List<Customer> customers = customer.GetAllCustomers();

            dgvCus.DataSource= customers;
        }
    }
}
