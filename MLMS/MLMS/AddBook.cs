using MLMS2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MLMS
{
    public partial class AddBook : Form
    {
        //roy path
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School_Projects\Git_Repositories\Library-Management\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
        //alaina path
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\santh\source\repos\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
        
        //we can just use this and change the path in the app.config so itll be easy to change.
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public AddBook()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMainDashBoard A = new AdminMainDashBoard();
            A.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //testing:
            //MessageBox.Show(Directory.GetCurrentDirectory());
            
            // Retrieve values from the form inputs
            string title = bookTextBox.Text;
            string isbn = ISBNtextBox.Text;
            string author = authorTextBox.Text;
            DateTime yearPublished = publishDateTimePicker.Value;
            string edition = editionTextBox.Text;
            string description = descriptionRichTextBox.Text;
            string availability = availabilityComboBox.SelectedItem?.ToString();

            if (availability == null)
            {
                MessageBox.Show("Please select the availability status.");
                return;
            }

            // Convert availability to a boolean
            bool isAvailable = availability == "Available";

            DateTime dueDate = DateTime.Now.AddDays(30);

            // Define the connection string (update with your connection string)
            //Alaina path
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\santh\Documents\GitHub\MLMS\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";

            //roy path
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\School_Projects\Git_Repositories\Library-Management\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            // relative path
            //string relativePath = Path.Combine("..", "..", "..", "App_Data", "Library.mdf");
            //string dbPath = Path.GetFullPath(relativePath);
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30;";

            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

            // SQL query to insert the book into the database
            string query = @"INSERT INTO Book (Title, ISBN, Author, YearPublished, Description, Availability, DueDate) 
                     VALUES (@Title, @ISBN, @Author, @YearPublished, @Description, @Availability, @DueDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Create a command object with the query and connection
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to the SQL command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Availability", isAvailable ? 1 : 0);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);

                    // Execute the command
                    int result = cmd.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (result > 0)
                    {
                        MessageBox.Show("Book added successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Error adding the book.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void validateBookFields()
        {
            // Check if the book name is empty
            if (string.IsNullOrWhiteSpace(bookTextBox.Text))
            {
                MessageBox.Show("Book name should be filled out.");
                return;
            }

            // Check if the ISBN is empty
            if (string.IsNullOrWhiteSpace(ISBNtextBox.Text))
            {
                MessageBox.Show("ISBN should be filled out.");
                return;
            }

            // Check if the author is empty
            if (string.IsNullOrWhiteSpace(authorTextBox.Text))
            {
                MessageBox.Show("Author should be filled out.");
                return;
            }

            // Check if the edition is empty
            if (string.IsNullOrWhiteSpace(editionTextBox.Text))
            {
                MessageBox.Show("Edition should be filled out.");
                return;
            }

            // Check if the description is empty
            if (string.IsNullOrWhiteSpace(descriptionRichTextBox.Text))
            {
                MessageBox.Show("Description should be filled out.");
                return;
            }

            // If all fields are valid, proceed to add the book
            AddBookToDatabase();
        }

        private void AddBookToDatabase()
        {
            // Logic to add the book to the database
            string title = bookTextBox.Text;
            string isbn = ISBNtextBox.Text;
            string author = authorTextBox.Text;
            DateTime yearPublished = publishDateTimePicker.Value;
            string edition = editionTextBox.Text;
            string description = descriptionRichTextBox.Text;
            string availability = availabilityComboBox.SelectedItem?.ToString();

            if (availability == null)
            {
                MessageBox.Show("Please select the availability status.");
                return;
            }

            // Convert availability to a boolean
            bool isAvailable = availability == "Available";

            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\santh\source\repos\MLMS\MLMS\App_Data\Library.mdf;Integrated Security=True;Connect Timeout=30;";
            string query = @"INSERT INTO Book (Title, ISBN, Author, YearPublished, Description, Availability) 
                     VALUES (@Title, @ISBN, @Author, @YearPublished, @Description, @Availability)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@YearPublished", yearPublished);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Availability", isAvailable ? 1 : 0);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Book added successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Error adding the book.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            // Clear text fields
            bookTextBox.Clear();
            ISBNtextBox.Clear();
            authorTextBox.Clear();
            editionTextBox.Clear();
            descriptionRichTextBox.Clear();

            // Reset the DateTimePicker to today's date or a specific default date
            publishDateTimePicker.Value = DateTime.Today;

            // Reset the ComboBox to the first item (e.g., "Available")
            if (availabilityComboBox.Items.Count > 0)
            {
                availabilityComboBox.SelectedIndex = 0;
            }
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            availabilityComboBox.Items.Add("Available");
            availabilityComboBox.Items.Add("Unavailable");
            availabilityComboBox.SelectedIndex = 0;
        }

        private void publishDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bookLabel_Click(object sender, EventArgs e)
        {

        }
    }
}