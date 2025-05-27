using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MLMS
{
    public partial class ViewReserve : Form
    {
        public ViewReserve()
        {
            InitializeComponent();
        }

        private void ViewReserve_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void memberNameTextBob_TextChanged(object sender, EventArgs e)
        {
        }

        private void currentReserveButton_Click(object sender, EventArgs e)
        {
            // Get the member name from the text box
            string memberName = memberNameTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(memberName))
            {
                // Connection string (update with your database details)
                string connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

                // SQL query to retrieve the filtered data
                string query = @"
                    SELECT 
                        M.FullName AS [Member Name],
                        R.ReserveDate AS [Reserve Date],
                        R.Status,
                        R.DueDate AS [Due Date]
                    FROM 
                        Member M
                    INNER JOIN 
                        ReserveBooks R ON M.MemberId = R.MemberID
                    WHERE 
                        M.FullName LIKE @MemberName";

                // Using a SqlConnection and SqlDataAdapter to fill the data
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add a parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@MemberName", "%" + memberName + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable resultTable = new DataTable();

                        try
                        {
                            // Open connection and fill the DataTable
                            connection.Open();
                            adapter.Fill(resultTable);

                            if (resultTable.Rows.Count > 0)
                            {
                                // Bind the results to the DataGridView
                                dataGridView1.DataSource = resultTable;
                            }
                            else
                            {
                                MessageBox.Show("No reservations found for the entered member name.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a member name to filter the reservations.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminMainDashBoard A = new AdminMainDashBoard();
            A.Show();
            this.Hide();
        }
    }
}
