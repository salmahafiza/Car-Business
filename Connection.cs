using System.Data.SqlClient;

public static class DatabaseConnection
{
    public static SqlConnection Connection { get; private set; }

    public static void Initialize()
    { 
        string cn = "Data Source=DESKTOP-IA2F4H0\\SQLEXPRESS;Initial Catalog=final_db;Integrated Security=True;";

        Connection = new SqlConnection(cn);
    }
}
