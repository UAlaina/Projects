using MLMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLMS2
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //WelcomeScreen.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserLogin M = new UserLogin();
            M.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected language from the ComboBox
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();

            // Map language to culture codes
            string cultureCode = selectedLanguage == "French" ? "fr-FR" : "en-US";

            // Update the application language
            ChangeLanguage.UpdateLanguage(cultureCode);

            // Optional: Inform the user that the language has been changed
            MessageBox.Show("Language changed to " + selectedLanguage + ". Please restart the application to apply changes.", "Language Switch");
        }

        private void comboBoxLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get the selected language from the ComboBox
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();

            // Map language to culture codes
            string cultureCode = selectedLanguage == "French" ? "fr" : "en";

            // Set the culture for the current thread
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureCode);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCode);

            // Reload the form to apply the language
            this.Controls.Clear();
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminLogin M = new AdminLogin();
            M.Show();
            this.Hide();
        }
    }
}
