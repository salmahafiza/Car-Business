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
    public partial class ServiceInformation : Form
    {
        private SqlConnection connection;
        public ServiceInformation()
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


                string query = "SELECT * FROM ServiceInformation"; // Replace with your table name

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

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                
                {
                    // Create the SQL insert query with parameters
                    string query = @"INSERT INTO ServiceInformation (CarID, DateOfService, ServiceDescription, ServiceCost, Status)
                         VALUES (@CarID, @DateOfService, @ServiceDescription, @ServiceCost, @Status)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values from text fields
                        command.Parameters.AddWithValue("@CarID", int.Parse(CarID.Text));
                        command.Parameters.AddWithValue("@DateOfService", DateOfService.Value);
                        command.Parameters.AddWithValue("@ServiceDescription", ServiceDescription.Text);
                        command.Parameters.AddWithValue("@ServiceCost", decimal.Parse(ServiceCost.Text));
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ServiceID is provided
                if (string.IsNullOrEmpty(ServiceID.Text))
                {
                    MessageBox.Show("Please provide the ServiceID for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE ServiceInformation SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(CarID.Text.Trim()))
                {
                    updateColumns.Add("CarID = @CarID");
                }
                if (!string.IsNullOrEmpty(DateOfService.Text.Trim()))
                {
                    updateColumns.Add("DateOfService = @DateOfService");
                }
                if (!string.IsNullOrEmpty(ServiceDescription.Text.Trim()))
                {
                    updateColumns.Add("ServiceDescription = @ServiceDescription");
                }
                if (!string.IsNullOrEmpty(ServiceCost.Text.Trim()))
                {
                    updateColumns.Add("ServiceCost = @ServiceCost");
                }
                if (!string.IsNullOrEmpty(Status.Text.Trim()))
                {
                    updateColumns.Add("Status = @Status");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Append the WHERE clause to match on ServiceID
                queryBuilder.Append(" WHERE ServiceID = @ServiceID");

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@ServiceID", int.Parse(ServiceID.Text.Trim()));

                    if (!string.IsNullOrEmpty(CarID.Text.Trim()))
                    {
                        if (int.TryParse(CarID.Text.Trim(), out int carID))
                        {
                            command.Parameters.AddWithValue("@CarID", carID);
                        }
                        else
                        {
                            MessageBox.Show("Invalid CarID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(DateOfService.Text.Trim()))
                    {
                        if (DateTime.TryParse(DateOfService.Text.Trim(), out DateTime dateOfService))
                        {
                            command.Parameters.AddWithValue("@DateOfService", dateOfService);
                        }
                        else
                        {
                            MessageBox.Show("Invalid DateOfService value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    command.Parameters.AddWithValue("@ServiceDescription", ServiceDescription.Text.Trim());

                    if (!string.IsNullOrEmpty(ServiceCost.Text.Trim()))
                    {
                        if (decimal.TryParse(ServiceCost.Text.Trim(), out decimal serviceCost))
                        {
                            command.Parameters.AddWithValue("@ServiceCost", serviceCost);
                        }
                        else
                        {
                            MessageBox.Show("Invalid ServiceCost value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ServiceID is provided
                if (string.IsNullOrEmpty(ServiceID.Text))
                {
                    MessageBox.Show("Please provide the ServiceID for deleting the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameter
                string query = "DELETE FROM ServiceInformation WHERE ServiceID = @ServiceID";

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@ServiceID", int.Parse(ServiceID.Text.Trim()));

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
