using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace final_windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if input fields are empty
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DataStore.ConnectionString))
                {
                    
                    string query = "SELECT StaffID, Name FROM STAFF WHERE Username=@u AND Password=@p";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPass.Text.Trim());

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        
                        DataStore.LoggedStaffID = dr["StaffID"] != DBNull.Value ? (int)dr["StaffID"] : 0;
                        DataStore.LoggedStaffName = dr["Name"]?.ToString() ?? "Guest";

                        MessageBox.Show($"Welcome, {DataStore.LoggedStaffName}!");

                        this.Hide();
                        MainForm main = new MainForm();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message);
            }
        }
    }
}