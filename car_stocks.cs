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

namespace CAR_Bussiness
{
    public partial class car_stocks : Form
    {
        private SqlConnection connection;
        public car_stocks()
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


                string query = "SELECT * FROM CarInformation"; // Replace with your table name

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    
                        // Open the connection
                       

                        // Create the SQL insert query with parameters
                        string query = @"INSERT INTO CarInformation (Make, Model, Year, Color, Mileage, Price, VIN, VendorID, Status)
                                     VALUES (@Make, @Model, @Year, @Color, @Mileage, @Price, @VIN, @VendorID, @Status)";

                        // Create a SqlCommand object with the query and connection
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Set the parameter values from text fields
                            command.Parameters.AddWithValue("@Make", Makes.Text);
                            command.Parameters.AddWithValue("@Model", Model.Text);
                            command.Parameters.AddWithValue("@Year", int.Parse(Year.Text));
                            command.Parameters.AddWithValue("@Color", Color.Text);
                            command.Parameters.AddWithValue("@Mileage", int.Parse(Milage.Text));
                            command.Parameters.AddWithValue("@Price", decimal.Parse(Price.Text));
                            command.Parameters.AddWithValue("@VIN", VIN.Text);
                            command.Parameters.AddWithValue("@VendorID", int.Parse(VendorID.Text));
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if CarID is provided
                if (string.IsNullOrEmpty(CarID.Text))
                {
                    MessageBox.Show("Please provide the CarID for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE CarInformation SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(Makes.Text.Trim()))
                {
                    updateColumns.Add("Make = @Make");
                }
                if (!string.IsNullOrEmpty(Model.Text.Trim()))
                {
                    updateColumns.Add("Model = @Model");
                }
                if (!string.IsNullOrEmpty(Year.Text.Trim()))
                {
                    updateColumns.Add("Year = @Year");
                }
                if (!string.IsNullOrEmpty(Color.Text.Trim()))
                {
                    updateColumns.Add("Color = @Color");
                }
                if (!string.IsNullOrEmpty(Milage.Text.Trim()))
                {
                    updateColumns.Add("Mileage = @Mileage");
                }
                if (!string.IsNullOrEmpty(Price.Text.Trim()))
                {
                    updateColumns.Add("Price = @Price");
                }
                if (!string.IsNullOrEmpty(VIN.Text.Trim()))
                {
                    updateColumns.Add("VIN = @VIN");
                }
                if (!string.IsNullOrEmpty(VendorID.Text.Trim()))
                {
                    updateColumns.Add("VendorID = @VendorID");
                }
                if (!string.IsNullOrEmpty(Status.Text.Trim()))
                {
                    updateColumns.Add("Status = @Status");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Append the WHERE clause to match on CarID
                queryBuilder.Append(" WHERE CarID = @CarID");

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@CarID", CarID.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Make", Makes.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Model", Model.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Year", Year.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Color", Color.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Mileage", Milage.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Price", Price.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@VIN", VIN.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@VendorID", VendorID.Text.Trim().ToString());
                    command.Parameters.AddWithValue("@Status", Status.Text.Trim().ToString());

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

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            
                // Get the CarID from the control
                int carID = int.Parse(CarID.Text);

            try
            {

                connection.Open();

                // Create the SQL delete query with parameter
                string query = "DELETE FROM CarInformation WHERE CarID = @CarID";

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@CarID", carID);

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
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
    }
    }
    
