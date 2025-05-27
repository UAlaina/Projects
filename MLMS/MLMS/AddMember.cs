using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MLMS2;

namespace MLMS
{
    public partial class addMemberForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public enum FormType
        {
            AdminMainDashBoard,
            MainDashBoard,
            UserLogin
        }

        private FormType currentForm;


        public addMemberForm(FormType formType)
        {
            InitializeComponent();
            currentForm = formType;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Based on the current form, show the correct form
            if (currentForm == FormType.AdminMainDashBoard)
            {
                AdminMainDashBoard adminDash = new AdminMainDashBoard();
                adminDash.Show();
            }
            else if (currentForm == FormType.MainDashBoard)
            {
                MainDashbboard mainDash = new MainDashbboard();
                mainDash.Show();
            }
            else if (currentForm == FormType.UserLogin)
            {
                UserLogin loginForm = new UserLogin();
                loginForm.Show();
            }

            this.Hide(); // Hide current form
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form inputs
            string fullName = nameTextBox.Text;
            string address = addressRichTextBox.Text;
            DateTime dob = DOBDateTimePicker.Value;
            string phoneNumber = phoneNoTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            //Mess
            //string confirmPassword = confirmPasswordTextBox.Text;

            //if (password != confirmPassword)
            //{
            //    MessageBox.Show("Passwords do not match.");
            //    return;
            //}

            // Validate that email is not already in use
            if (CheckIfEmailExists(email))
            {
                MessageBox.Show("Email already exists. Please choose a different one.");
                return;
            }

            // Get the connection string from the App.config file
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            //roy path
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School_Projects\Git_Repositories\Library-Management\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            // SQL query to insert the member into the database
            string memberQuery = "INSERT INTO Member (FullName, Address, DOB, PhoneNumber, Email, Password) VALUES (@FullName, @Address, @DOB, @PhoneNumber, @Email, @Password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Create a command object with the query and connection
                    SqlCommand cmd = new SqlCommand(memberQuery, conn);

                    // Add parameters to the SQL command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Member and User account created successfully!");

                        UserLogin loginForm = new UserLogin();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error adding the member or user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private bool CheckIfEmailExists(string email)
        {
            bool exists = false;

            // Get the connection string from the App.config file
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            //roy path
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School_Projects\Git_Repositories\Library-Management\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Member WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}