using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CAR_Bussiness
{
    public partial class Login : Form
    {
        private SqlConnection connection;
        public Login()
        {
            InitializeComponent();
            DatabaseConnection.Initialize();

            // Get the connection from the DatabaseConnection class
            connection = DatabaseConnection.Connection;



        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
            string user = username.Text;
            string pass = password.Text;

            // Perform authentication or validation using the retrieved username and password
            // ...

            // Example: Check if the username and password match in the database
            string query = "SELECT COUNT(*) FROM Login WHERE Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", user);
            command.Parameters.AddWithValue("@Password", pass);

            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();

            if (result > 0)
            {
                // Login successful
                MessageBox.Show("Login successful");
                Vendor form = new Vendor();
                form.ShowDialog();
                

            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password");
            }
        }

    

        private void username_Click(object sender, EventArgs e)
        {
            string a = "abc";
            if(username!=null){
                username.Text = "";
                
            }
            else
            {
                
                username.Text = a;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
