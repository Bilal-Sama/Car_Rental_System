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
    public partial class customersFormcs : Form
    {
        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public customersFormcs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM customers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;
                    dgvCustomers.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            txtAddress.Clear();
            txtCustID.Clear();
            txtLicenseNumber.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO customers (name, phone, license_number, address)
                             VALUES (@name, @phone, @license, @address)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@license", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully!");
                    LoadCustomers();
                    ClearInputs();
                }
                catch (MySqlException ex) when (ex.Number == 1062)
                {
                    MessageBox.Show("License number must be unique.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustID.Text)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE customers SET
                             name = @name,
                             phone = @phone,
                             license_number = @license,
                             address = @address
                             WHERE customer_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@license", txtLicenseNumber.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id", txtCustID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully!");
                    LoadCustomers();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer: " + ex.Message);
                }
            }
        }

        private void customersFormcs_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            dgvCustomers.ClearSelection();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtCustID.Text = row.Cells["customer_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtLicenseNumber.Text = row.Cells["license_number"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustID.Text)) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM customers WHERE customer_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", txtCustID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer deleted.");
                        LoadCustomers();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string keyword = "%" + txtSearch.Text + "%";
                    string query = @"SELECT * FROM customers
                             WHERE name LIKE @keyword
                             OR phone LIKE @keyword
                             OR license_number LIKE @keyword";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCustomers();
        }
    }
}
