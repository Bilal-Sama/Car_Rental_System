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
using MySqlX.XDevAPI;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public string connectionString = "server=localhost; user id=root;password=818283;database=car_rental_db; ";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password= @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        string role = reader["role"].ToString();
                        Session.UserID = Convert.ToInt32(reader["user_id"]); // or your column name
                        Session.Username = reader["username"].ToString();
                        Main main = new Main(role);
                        main.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        lblError.Text = "Invalid credentials!";
                        lblError.Visible = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
