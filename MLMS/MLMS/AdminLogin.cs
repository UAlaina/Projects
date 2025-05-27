using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLMS
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginAdminButton_Click(object sender, EventArgs e)
        {
            // Retrieve the entered username and password
            string username = nameTextBox.Text;
            string password = passwordTextBox.Text;

            // Validate credentials
            if (username == "admin" && password == "12345678")
            {
                // Redirect to AdminMainDashboard
                AdminMainDashBoard adminDashboard = new AdminMainDashBoard();
                adminDashboard.Show();
                this.Hide();
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
