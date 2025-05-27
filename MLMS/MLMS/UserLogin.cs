using MLMS2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MLMS.addMemberForm;

namespace MLMS
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            string username = emailTextBox.Text;
            string password = passwordTextBox.Text;

            // Validate user inputs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out both username and password.");
                return;
            }

            // Validate login credentials from the database
            if (ValidateUserLogin(username, password))
            {
                MessageBox.Show("Login Success!");

                StoreLoggedInUser(username);

                MainDashbboard dashboard = new MainDashbboard();
                //MessageBox.Show("here");
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Denied :(");
            }
        }

        private bool ValidateUserLogin(string username, string password)
        {
            bool isValid = false;

            // Get the connection string from the App.config file
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "AppData", "Library.mdf");
            //string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30;";
            //string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=..\\..\\AppData\\Library.mdf;Integrated Security=True;Connect Timeout=30;";

            //MessageBox.Show("1");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //MessageBox.Show("1.5");
                conn.Open();
                string query = "SELECT Password,MemberID FROM Member WHERE Email = @Email";
                //MessageBox.Show("2");
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", username);
                    //string storedPassword = (string)cmd.ExecuteScalar();
                    //MessageBox.Show("3");
                    // Use SqlDataReader to get both Password and MemberID
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //MessageBox.Show("4");
                        if (reader.Read()) // Check if data is found
                        {
                            //MessageBox.Show("5");
                            string storedPassword = reader.GetString(0); // First column (Password)
                            int memberId = reader.GetInt32(1); // Second column (MemberID)

                            // Check if the password matches
                            if (storedPassword == password)
                            {
                                //MessageBox.Show("6");
                                // Store MemberID and Email in UserSession
                                UserSession.MemberID = memberId;
                                UserSession.Email = username;
                                isValid = true;
                            }
                            //MessageBox.Show("7");
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }

            return isValid;
        }

        private void StoreLoggedInUser(string username)
        {
            // Get the connection string from the App.config file
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MemberID, Email FROM Member WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", username);

                        // Execute the query and get the data
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store MemberID and Email in the UserSession class
                                UserSession.MemberID = reader.GetInt32(reader.GetOrdinal("MemberID"));
                                UserSession.Email = reader.GetString(reader.GetOrdinal("Email"));
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            addMemberForm newUserForm = new addMemberForm(FormType.UserLogin);
            newUserForm.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            WelcomeScreen B = new WelcomeScreen();
            B.Show();
            this.Hide();
        }
    }
}