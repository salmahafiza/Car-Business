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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAR_Bussiness
{
    public partial class CustomerVendorRelationship : Form
    {
        private SqlConnection connection;
        public CustomerVendorRelationship()
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


                string query = "SELECT * FROM CustomerVendorRelationship"; // Replace with your table name

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
                    string query = @"INSERT INTO CustomerVendorRelationship (CustomerID, VendorID, RelationshipStartDate, RelationshipEndDate, CarID, Status)
                         VALUES (@CustomerID, @VendorID, @RelationshipStartDate, @RelationshipEndDate, @CarID, @Status)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values from text fields
                        command.Parameters.AddWithValue("@CustomerID", int.Parse(CustomerID.Text));
                        command.Parameters.AddWithValue("@VendorID", int.Parse(VendorID.Text));
                        command.Parameters.AddWithValue("@RelationshipStartDate", RelationshipStartDate.Value);
                        command.Parameters.AddWithValue("@RelationshipEndDate", RelationshipEndDate.Value);
                        command.Parameters.AddWithValue("@CarID", int.Parse(CarID.Text));
                        command.Parameters.AddWithValue("@Status", Status.Text);

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
                // Check if CustomerVendorID is provided
                if (string.IsNullOrEmpty(CustomerVendorID.Text))
                {
                    MessageBox.Show("Please provide the CustomerVendorID for deleting the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameter
                string query = "DELETE FROM CustomerVendorRelationship WHERE CustomerVendorID = @CustomerVendorID";

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@CustomerVendorID", int.Parse(CustomerVendorID.Text.Trim()));

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
                // Check if CustomerVendorID is provided
                if (string.IsNullOrEmpty(CustomerVendorID.Text))
                {
                    MessageBox.Show("Please provide the CustomerVendorID for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE CustomerVendorRelationship SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(CustomerID.Text.Trim()))
                {
                    updateColumns.Add("CustomerID = @CustomerID");
                }
                if (!string.IsNullOrEmpty(VendorID.Text.Trim()))
                {
                    updateColumns.Add("VendorID = @VendorID");
                }
                if (!string.IsNullOrEmpty(RelationshipStartDate.Text.Trim()))
                {
                    updateColumns.Add("RelationshipStartDate = @RelationshipStartDate");
                }
                if (!string.IsNullOrEmpty(RelationshipEndDate.Text.Trim()))
                {
                    updateColumns.Add("RelationshipEndDate = @RelationshipEndDate");
                }
                if (!string.IsNullOrEmpty(CarID.Text.Trim()))
                {
                    updateColumns.Add("CarID = @CarID");
                }
                if (!string.IsNullOrEmpty(Status.Text.Trim()))
                {
                    updateColumns.Add("Status = @Status");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Append the WHERE clause to match on CustomerVendorID
                queryBuilder.Append(" WHERE CustomerVendorID = @CustomerVendorID");

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Set the parameter values
                    if (!int.TryParse(CustomerVendorID.Text.Trim(), out int customerVendorID))
                    {
                        MessageBox.Show("Invalid CustomerVendorID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    command.Parameters.AddWithValue("@CustomerVendorID", customerVendorID);

                    if (!string.IsNullOrEmpty(CustomerID.Text.Trim()))
                    {
                        if (!int.TryParse(CustomerID.Text.Trim(), out int customerID))
                        {
                            MessageBox.Show("Invalid CustomerID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                    }

                    if (!string.IsNullOrEmpty(VendorID.Text.Trim()))
                    {
                        if (!int.TryParse(VendorID.Text.Trim(), out int vendorID))
                        {
                            MessageBox.Show("Invalid VendorID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        command.Parameters.AddWithValue("@VendorID", vendorID);
                    }

                    if (!string.IsNullOrEmpty(RelationshipStartDate.Text.Trim()))
                    {
                        if (!DateTime.TryParse(RelationshipStartDate.Text.Trim(), out DateTime relationshipStartDate))
                        {
                            MessageBox.Show("Invalid RelationshipStartDate value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        command.Parameters.AddWithValue("@RelationshipStartDate", relationshipStartDate);
                    }

                    if (!string.IsNullOrEmpty(RelationshipEndDate.Text.Trim()))
                    {
                        if (!DateTime.TryParse(RelationshipEndDate.Text.Trim(), out DateTime relationshipEndDate))
                        {
                            MessageBox.Show("Invalid RelationshipEndDate value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        command.Parameters.AddWithValue("@RelationshipEndDate", relationshipEndDate);
                    }

                    if (!string.IsNullOrEmpty(CarID.Text.Trim()))
                    {
                        if (!int.TryParse(CarID.Text.Trim(), out int carID))
                        {
                            MessageBox.Show("Invalid CarID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        command.Parameters.AddWithValue("@CarID", carID);
                    }

                    command.Parameters.AddWithValue("@Status", Status.Text.Trim());

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
