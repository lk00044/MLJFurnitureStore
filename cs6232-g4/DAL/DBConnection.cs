/// <summary>
/// Handles the connection to the database   
/// Programmer: LKeller
/// Date: 11 Mrach 2024
/// </summary>
/// 
using System.Data.SqlClient;

namespace cs6232_g4.DAL
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
                 string connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=cs6232-g4;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
