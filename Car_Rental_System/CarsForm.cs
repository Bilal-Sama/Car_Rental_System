using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CarsForm : Form
    {
        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public CarsForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }
        private void LoadCars()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cars";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCars.DataSource = dt;
                    dgvCars.ClearSelection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading cars: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = " INSERT INTO cars(make,model,year,status,plate_number,rental_rate) VALUES(@make,@model,@year,@status,@plate_number,@rental_rate)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@make", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@year", txtYear.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@plate_number",txtNumberPlate.Text);
                    cmd.Parameters.AddWithValue("@rental_rate", txtRentalRate.Text);
                   cmd.ExecuteNonQuery();
                    LoadCars();
                    ClearInputs();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error adding car: " + ex.Message);
                }
            }
        }
        private void ClearInputs()
        {
            txtCarID.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtNumberPlate.Clear();
            txtRentalRate.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];
                txtCarID.Text = row.Cells["car_id"].Value.ToString();
                txtCarID.Text = row.Cells["car_id"].Value.ToString();
                txtBrand.Text = row.Cells["make"].Value.ToString();
                txtModel.Text = row.Cells["model"].Value.ToString();
                txtYear.Text = row.Cells["year"].Value.ToString();
                txtNumberPlate.Text = row.Cells["plate_number"].Value.ToString();
                txtRentalRate.Text = row.Cells["rental_rate"].Value.ToString();
                cmbStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this car?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM cars WHERE car_id=@car_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@car_id", txtCarID.Text);
                        cmd.ExecuteNonQuery();
                        LoadCars();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting car: " + ex.Message);
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE cars SET make=@make, model=@model, year=@year, status=@status, rental_rate=@rental_rate, plate_number=@plate_number WHERE car_id=@car_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@car_id",Convert.ToInt32(txtCarID.Text));
                    cmd.Parameters.AddWithValue("@make", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@year",Convert.ToInt32( txtYear.Text));
                    cmd.Parameters.AddWithValue("@plate_number", txtNumberPlate.Text);
                    cmd.Parameters.AddWithValue("@rental_rate", Convert.ToDecimal(txtRentalRate.Text));
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.ExecuteNonQuery();
                    LoadCars();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating car: " + ex.Message);
                }
            }
        }
    }
}
