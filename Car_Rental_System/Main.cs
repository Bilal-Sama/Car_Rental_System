using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Car_Rental_System
{
    public partial class Main : Form
    {
        private string userRole;
        public Main(string role)
        {
            InitializeComponent();
            userRole = role;
            lblWelcome.Text = ($"Logged in as: {role}");
            ApplyPermissions();
        }
        private void ApplyPermissions()
        {
            if(userRole != "admin")
            {
                btnManageUsers.Enabled = false;
                
            }
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            using (CarsForm cars = new CarsForm())
            { 
                cars.ShowDialog(); 
            }
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            using (rentalForm rentalform = new rentalForm())
            {
                rentalform.ShowDialog();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using(customersFormcs customers=new customersFormcs())
            {
                customers.ShowDialog();
            }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            using(paymentsForm payments=new paymentsForm())
            {
                payments.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            using( usersForm users=new usersForm())
            {
                users.ShowDialog();
            }
        }
    }
}
