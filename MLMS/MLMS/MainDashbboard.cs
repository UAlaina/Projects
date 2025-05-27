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
using static MLMS.addMemberForm;

namespace MLMS2
{
    public partial class MainDashbboard : Form
    {
        public MainDashbboard()
        {
            InitializeComponent();
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            addMemberForm member = new addMemberForm(FormType.MainDashBoard);
            member.Show();
            this.Hide();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            ReserveBook r = new ReserveBook();
            r.Show();
            this.Hide();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            Payment P = new Payment();
            P.Show();
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
            string cultureCode = selectedLanguage == "French" ? "fr" : "en";

            // Set the culture for the current thread
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureCode);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureCode);

            // Reload the form to apply the language
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
