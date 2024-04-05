using cs6232_g4.DAL;
using cs6232_g4.Helper;
using System.Data.SqlClient;

/// <summary>
/// Data Access Layer for employees
/// Author: Leslie
/// </summary>

namespace Employees.DAL
{
    public class EmployeeDAL
    {

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public string GetUserName(string UserID, string Entered)
        {

            string PWord = EncryptionHelper.DecryptString(Entered);

            string selectStatement =
               "SELECT l.user_id, l.password, e.fname, e.lname " +
               "FROM Login l " +
               "LEFT JOIN Employee e " +
               "ON l.user_id = e.login_userID " +
               "WHERE l.user_id = @UserID and l.password = @PWord"
           ;

            Model.Employee employee = new Model.Employee();

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
                            employee.FirstName = reader["fname"].ToString();
                            employee.LastName = reader["lname"].ToString();
                        }
                    }
                }
            }
            return employee.FirstName + " " + employee.LastName;
        }
    }
}
