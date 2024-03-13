
using cs6232_g4.DAL;
using Employees.Model;
using System.Data.SqlClient;

/// <summary>
/// 
/// </summary>

namespace Employees.DAL
{
    public class EmployeeDAL
    {

        public bool CheckLogIn(string UserID, string PWord)
        {
            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID and password = @PWord"
            ;

            Employee employee = new Employee();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@UserID", UserID));
                    selectCommand.Parameters.Add(new SqlParameter("@PWord", PWord));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {                            
                            employee.UserID = reader["user_id"].ToString();
                            employee.Password = reader["password"].ToString();
                        }
                    }
                }
            }
            return !(string.IsNullOrEmpty(employee.UserID));
        }
    }
}
