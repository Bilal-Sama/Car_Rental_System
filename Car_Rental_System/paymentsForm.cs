using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class paymentsForm : Form
    {
        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public paymentsForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentsForm_Load(object sender, EventArgs e)
        {
            LoadRentalIDs();
            LoadPayments();

            cmbPaymentMethod.Items.AddRange(new string[] { "cash", "credit card", "debit card", "online" });
            cmbPaymentMethod.SelectedIndex = 0;
        }
        private void LoadRentalIDs()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT rental_id FROM rentals";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbRentalID.DataSource = dt;
                    cmbRentalID.DisplayMember = "rental_id";
                    cmbRentalID.ValueMember = "rental_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rental IDs: " + ex.Message);
                }
            }
        }

        private void LoadPayments()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM payments";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayments.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO payments (rental_id, payment_date, amount, payment_method, notes)
                             VALUES (@rental_id, @payment_date, @amount, @payment_method, @notes)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@rental_id", cmbRentalID.SelectedValue);
                    cmd.Parameters.AddWithValue("@payment_date", dtpPaymentDate.Value.Date);
                    cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@payment_method", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment saved successfully!");
                    LoadPayments();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving payment: " + ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            txtPaymentID.Clear();
            cmbRentalID.SelectedIndex = -1;
            dtpPaymentDate.Value = DateTime.Today;
            txtAmount.Clear();
            cmbPaymentMethod.SelectedIndex = 0;
            txtNotes.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs(); 
        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayments.Rows[e.RowIndex];

                txtPaymentID.Text = row.Cells["payment_id"].Value.ToString();
                cmbRentalID.SelectedValue = row.Cells["rental_id"].Value;
                dtpPaymentDate.Value = Convert.ToDateTime(row.Cells["payment_date"].Value);
                txtAmount.Text = row.Cells["amount"].Value.ToString();
                cmbPaymentMethod.SelectedItem = row.Cells["payment_method"].Value.ToString();
                txtNotes.Text = row.Cells["notes"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentID.Text))
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE payments 
                             SET rental_id=@rental_id, payment_date=@payment_date, 
                                 amount=@amount, payment_method=@payment_method, notes=@notes 
                             WHERE payment_id=@payment_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@rental_id", cmbRentalID.SelectedValue);
                    cmd.Parameters.AddWithValue("@payment_date", dtpPaymentDate.Value.Date);
                    cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@payment_method", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@payment_id", txtPaymentID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment updated successfully.");
                    LoadPayments();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating payment: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentID.Text))
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this payment?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM payments WHERE payment_id = @payment_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@payment_id", txtPaymentID.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Payment deleted successfully.");
                        LoadPayments();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting payment: " + ex.Message);
                    }
                }
            }
        }
    }
}
