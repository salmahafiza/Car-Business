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

namespace CAR_Bussiness
{
    public partial class TransactionInformation : Form
    {
        private SqlConnection connection;
        public TransactionInformation()
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


                string query = "SELECT * FROM TransactionInformation"; // Replace with your table name

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

        private void i_Click(object sender, EventArgs e)
        {
           

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if TransactionID is provided
                if (string.IsNullOrEmpty(TransactionID.Text))
                {
                    MessageBox.Show("Please provide the TransactionID for updating the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameters
                StringBuilder queryBuilder = new StringBuilder("UPDATE TransactionInformation SET ");
                List<string> updateColumns = new List<string>();

                // Check which columns need to be updated
                if (!string.IsNullOrEmpty(CarID.Text.Trim()))
                {
                    updateColumns.Add("CarID = @CarID");
                }
                if (!string.IsNullOrEmpty(CustomerID.Text.Trim()))
                {
                    updateColumns.Add("CustomerID = @CustomerID");
                }
                if (!string.IsNullOrEmpty(VendorID.Text.Trim()))
                {
                    updateColumns.Add("VendorID = @VendorID");
                }
                if (!string.IsNullOrEmpty(DateOfSale.Text.Trim()))
                {
                    updateColumns.Add("DateOfSale = @DateOfSale");
                }
                if (!string.IsNullOrEmpty(SalePrice.Text.Trim()))
                {
                    updateColumns.Add("SalePrice = @SalePrice");
                }
                if (!string.IsNullOrEmpty(PaymentMethod.Text.Trim()))
                {
                    updateColumns.Add("PaymentMethod = @PaymentMethod");
                }

                // Append the columns to the query
                queryBuilder.Append(string.Join(", ", updateColumns));

                // Append the WHERE clause to match on TransactionID
                queryBuilder.Append(" WHERE TransactionID = @TransactionID");

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@TransactionID", TransactionID.Text.Trim());

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

                    if (!string.IsNullOrEmpty(CustomerID.Text.Trim()))
                    {
                        if (int.TryParse(CustomerID.Text.Trim(), out int customerID))
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerID);
                        }
                        else
                        {
                            MessageBox.Show("Invalid CustomerID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(VendorID.Text.Trim()))
                    {
                        if (int.TryParse(VendorID.Text.Trim(), out int vendorID))
                        {
                            command.Parameters.AddWithValue("@VendorID", vendorID);
                        }
                        else
                        {
                            MessageBox.Show("Invalid VendorID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(DateOfSale.Text.Trim()))
                    {
                        if (DateTime.TryParse(DateOfSale.Text.Trim(), out DateTime dateOfSale))
                        {
                            command.Parameters.AddWithValue("@DateOfSale", dateOfSale);
                        }
                        else
                        {
                            MessageBox.Show("Invalid DateOfSale value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(SalePrice.Text.Trim()))
                    {
                        if (decimal.TryParse(SalePrice.Text.Trim(), out decimal salePrice))
                        {
                            command.Parameters.AddWithValue("@SalePrice", salePrice);
                        }
                        else
                        {
                            MessageBox.Show("Invalid SalePrice value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod.Text.Trim());

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
                // Check if TransactionID is provided
                if (string.IsNullOrEmpty(TransactionID.Text))
                {
                    MessageBox.Show("Please provide the TransactionID for deleting the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the SQL query with parameter
                string query = "DELETE FROM TransactionInformation WHERE TransactionID = @TransactionID";

                // Create a SqlCommand object with the query and connection from the connection class
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter value
                    command.Parameters.AddWithValue("@TransactionID", int.Parse(TransactionID.Text.Trim()));

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
