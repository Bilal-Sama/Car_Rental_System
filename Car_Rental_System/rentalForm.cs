using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace Car_Rental_System
{
    public partial class rentalForm : Form
    {

        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public rentalForm()
        {
            InitializeComponent();
        }

        private void rentalForm_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadCustomers();
            LoadUsers();
            cmbStatus.Items.AddRange(new string[] { "ongoing", "completed" });
            LoadRentals();
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadCars()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT car_id, CONCAT(make, ' ', model) AS car_name FROM cars";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCar.DataSource = dt;
                cmbCar.DisplayMember = "car_name";
                cmbCar.ValueMember = "car_id";
            }
        }

        private void LoadCustomers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT customer_id, name FROM customers";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "name";
                cmbCustomer.ValueMember = "customer_id";
            }
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT user_id, username FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUser.DataSource = dt;
                cmbUser.DisplayMember = "username";
                cmbUser.ValueMember = "user_id";
            }
        }

        private void LoadRentals()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT r.rental_id, 
                                r.car_id, 
                                r.customer_id, 
                                r.user_id, 
                                c.make, 
                                c.model, 
                                cu.name AS customer_name, 
                                r.rent_date, 
                                r.return_date, 
                                r.actual_return_date, 
                                r.total_cost, 
                                r.status
                         FROM rentals r
                         JOIN cars c ON r.car_id = c.car_id
                         JOIN customers cu ON r.customer_id = cu.customer_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRentals.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO rentals (car_id, customer_id, user_id, rent_date, return_date, total_cost) 
                         VALUES (@car_id, @customer_id, @user_id, @rent_date, @return_date, @total_cost)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@car_id", cmbCar.SelectedValue);
                cmd.Parameters.AddWithValue("@customer_id", cmbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@user_id", cmbUser.SelectedValue);
                cmd.Parameters.AddWithValue("@rent_date", dtpRentDate.Value.Date);
                cmd.Parameters.AddWithValue("@return_date", dtpReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@total_cost", Convert.ToDecimal(txtTotalCost.Text));

                cmd.ExecuteNonQuery();

                // Update car status to rented
                string updateCar = "UPDATE cars SET status = 'rented' WHERE car_id = @car_id";
                MySqlCommand carCmd = new MySqlCommand(updateCar, conn);
                carCmd.Parameters.AddWithValue("@car_id", cmbCar.SelectedValue);
                carCmd.ExecuteNonQuery();

                LoadRentals();
                LoadCars();
                MessageBox.Show("Car rented successfully!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE rentals 
                         SET actual_return_date = @actual_return_date, 
                             status = 'completed' 
                         WHERE rental_id = @rental_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@actual_return_date", dtpActualReturnDate.Value.Date);
                cmd.Parameters.AddWithValue("@rental_id", txtRentalID.Text);
                cmd.ExecuteNonQuery();

                // Update car status back to available
                string updateCar = "UPDATE cars SET status = 'available' WHERE car_id = @car_id";
                MySqlCommand carCmd = new MySqlCommand(updateCar, conn);
                carCmd.Parameters.AddWithValue("@car_id", cmbCar.SelectedValue);
                carCmd.ExecuteNonQuery();

                LoadRentals();
                LoadCars();
                MessageBox.Show("Car returned successfully!");
            }
        }

        private void ClearInputs()
        {
            cmbCar.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            dtpRentDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
            dtpActualReturnDate.Value = DateTime.Now;
            txtTotalCost.Clear();
            cmbStatus.SelectedIndex = -1;
            txtRentalID.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void CalculateTotalCost()
        {
            if (cmbCar.SelectedValue == null || cmbCar.SelectedValue.ToString() == "")
                return;

            int carId;
            if (!int.TryParse(cmbCar.SelectedValue.ToString(), out carId))
                return;

            DateTime rentDate = dtpRentDate.Value.Date;
            DateTime returnDate = dtpReturnDate.Value.Date;

            if (returnDate <= rentDate)
            {
                txtTotalCost.Text = "0.00";
                return;
            }

            int days = (returnDate - rentDate).Days;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT rental_rate FROM cars WHERE car_id = @car_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@car_id", carId);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal rate = Convert.ToDecimal(result);
                        decimal totalCost = days * rate;
                        txtTotalCost.Text = totalCost.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating cost: " + ex.Message);
                }
            }
        }

        private void dtpRentDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void dgvRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRentals.Rows[e.RowIndex];

                // Rental ID
                txtRentalID.Text = row.Cells["rental_id"].Value?.ToString() ?? "";

                // ComboBoxes
                cmbCar.SelectedValue = row.Cells["car_id"].Value ?? "";
                cmbCustomer.SelectedValue = row.Cells["customer_id"].Value ?? "";

                // Rent & Return Dates
                if (DateTime.TryParse(row.Cells["rent_date"].Value?.ToString(), out DateTime rentDate))
                    dtpRentDate.Value = rentDate;

                if (DateTime.TryParse(row.Cells["return_date"].Value?.ToString(), out DateTime returnDate))
                    dtpReturnDate.Value = returnDate;

                if (DateTime.TryParse(row.Cells["actual_return_date"].Value?.ToString(), out DateTime actualReturnDate))
                    dtpActualReturnDate.Value = actualReturnDate;

                // Total Cost
                txtTotalCost.Text = row.Cells["total_cost"].Value?.ToString() ?? "0.00";

                // Status
                string status = row.Cells["status"].Value?.ToString() ?? "ongoing";
                cmbStatus.SelectedItem = status;

                // Show warning if the car is already rented
                if (status == "completed" || cmbCar.SelectedItem == null)
                {
                    MessageBox.Show("This car rental is completed or car is no longer available.");
                }
                else
                {
                    MessageBox.Show("Car is already rented...");
                }

                btnReturn.Enabled = (status == "ongoing");
            }
        }
    }
}
