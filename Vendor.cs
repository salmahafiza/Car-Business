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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAR_Bussiness
{
    public partial class Vendor : Form
    {
        private SqlConnection connection;
        public Vendor()
        {
            InitializeComponent();
            DatabaseConnection.Initialize();

            // Get the connection from the DatabaseConnection class
            connection = DatabaseConnection.Connection;


            RefreshDataGridView();
        }
    

        private void RefreshDataGridView()
        {
            try
            {


                string query = "SELECT * FROM VendorInformation"; // Replace with your table name

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



            private void Disclaimer_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

           
        }

        private void VendorName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void VendorID_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM VendorInformation WHERE VendorID = @VendorID OR VendorName = @VendorName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorID", VendorID.Text);
                    command.Parameters.AddWithValue("@VendorName", VendorName.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");

                        // Refresh the DataGridView
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No record found for deletion.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if VendorID or VendorName is provided
                if (string.IsNullOrEmpty(VendorID.Text) && string.IsNullOrEmpty(VendorName.Text))
                {
                    MessageBox.Show("Please provide either VendorID or VendorName for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE VendorInformation SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(Contact.Text))
                {
                    updateColumns.Add("ContactNumber = @ContactNumber");
                }
                if (!string.IsNullOrEmpty(Email.Text))
                {
                    updateColumns.Add("Email = @Email");
                }
                if (!string.IsNullOrEmpty(Address.Text))
                {
                    updateColumns.Add("Address = @Address");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Add the Commission column if the value is valid
                if (decimal.TryParse(Commission.Text, out decimal commission))
                {
                    queryBuilder.Append(", Commission = @Commission");
                }
                else if (!string.IsNullOrEmpty(Commission.Text))
                {
                    MessageBox.Show("Commission should be a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Append the WHERE clause to match on VendorID or VendorName
                queryBuilder.Append(" WHERE VendorID = @VendorID OR VendorName = @VendorName");

                // Create a SqlCommand object with the query and connection from the connection class
                SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection);

                // Add parameter values to the SqlCommand
                command.Parameters.AddWithValue("@VendorID", VendorID.Text.Trim());
                command.Parameters.AddWithValue("@VendorName", VendorName.Text.Trim());
                command.Parameters.AddWithValue("@ContactNumber", Contact.Text.Trim());
                command.Parameters.AddWithValue("@Email", Email.Text.Trim());
                command.Parameters.AddWithValue("@Address", Address.Text.Trim());

                // Add the Commission parameter if the value is valid
                if (decimal.TryParse(Commission.Text, out commission))
                {
                    command.Parameters.AddWithValue("@Commission", commission);
                }

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully.");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("No record found for update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Open the connection

                // Create the SQL insert query with parameters
                string query = @"INSERT INTO VendorInformation (VendorName, ContactNumber, Email, Address, Commission)
                     VALUES (@VendorName, @ContactNumber, @Email, @Address, @Commission)";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values from text fields
                    command.Parameters.AddWithValue("@VendorName", VendorName.Text);
                    command.Parameters.AddWithValue("@ContactNumber", Contact.Text);
                    command.Parameters.AddWithValue("@Email", Email.Text);
                    command.Parameters.AddWithValue("@Address", Address.Text);
                    command.Parameters.AddWithValue("@Commission", decimal.Parse(Commission.Text));

                    // Execute the insert query
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Commission_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Click(object sender, EventArgs e)
        {

        }
    }
}

