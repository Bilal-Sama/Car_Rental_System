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
    public partial class usersForm : Form
    {
        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public usersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        
           {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User added.");
                    LoadUsers();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET username=@username, password=@password, role=@role WHERE user_id=@user_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User updated.");
                    LoadUsers();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)) return;

            DialogResult result = MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE user_id=@user_id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@user_id", txtUserID.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("User deleted.");
                        LoadUsers();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message);
                    }
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchUsers(string searchText)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username LIKE @search";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching users: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchUsers(txtSearch.Text);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUserID.Text = row.Cells["user_id"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["role"].Value.ToString();
            }
        }
    }
}
