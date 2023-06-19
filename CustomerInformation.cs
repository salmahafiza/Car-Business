using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CAR_Bussiness
{
    public partial class CustomerInformation : Form
    {
        private SqlConnection connection;
        public CustomerInformation()
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


                string query = "SELECT * FROM CustomerInformation"; // Replace with your table name

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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                
                {
                    // Create the SQL insert query with parameters
                    string query = @"INSERT INTO CustomerInformation (FirstName, LastName, ContactNumber, Email, Address)
                         VALUES (@FirstName, @LastName, @ContactNumber, @Email, @Address)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values from text fields
                        command.Parameters.AddWithValue("@FirstName", FirstName.Text);
                        command.Parameters.AddWithValue("@LastName", LastName.Text);
                        command.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text);
                        command.Parameters.AddWithValue("@Email", Email.Text);
                        command.Parameters.AddWithValue("@Address", Address.Text);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if CustomerID is provided
                if (string.IsNullOrEmpty(CustomerID.Text))
                {
                    MessageBox.Show("Please provide the CustomerID for deleting the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameter
                string query = "DELETE FROM CustomerInformation WHERE CustomerID = @CustomerID";

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerID.Text.Trim()));

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No record found for delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if CustomerID is provided
                if (string.IsNullOrEmpty(CustomerID.Text))
                {
                    MessageBox.Show("Please provide the CustomerID for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE CustomerInformation SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(FirstName.Text.Trim()))
                {
                    updateColumns.Add("FirstName = @FirstName");
                }
                if (!string.IsNullOrEmpty(LastName.Text.Trim()))
                {
                    updateColumns.Add("LastName = @LastName");
                }
                if (!string.IsNullOrEmpty(ContactNumber.Text.Trim()))
                {
                    updateColumns.Add("ContactNumber = @ContactNumber");
                }
                if (!string.IsNullOrEmpty(Email.Text.Trim()))
                {
                    updateColumns.Add("Email = @Email");
                }
                if (!string.IsNullOrEmpty(Address.Text.Trim()))
                {
                    updateColumns.Add("Address = @Address");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Append the WHERE clause to match on CustomerID
                queryBuilder.Append(" WHERE CustomerID = @CustomerID");

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerID.Text.Trim()));
                    command.Parameters.AddWithValue("@FirstName", FirstName.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", LastName.Text.Trim());
                    command.Parameters.AddWithValue("@ContactNumber", ContactNumber.Text.Trim());
                    command.Parameters.AddWithValue("@Email", Email.Text.Trim());
                    command.Parameters.AddWithValue("@Address", Address.Text.Trim());

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
