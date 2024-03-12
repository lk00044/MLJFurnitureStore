using System.Data.SqlClient;
namespace cs6232_g4.DAL
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=cs6232-g4;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
