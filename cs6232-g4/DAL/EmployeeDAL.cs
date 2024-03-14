
using System.Data.SqlClient;
using Employees.Model;
using Logon.DAL;

/// <summary>
/// Interface between the view and the data for the employee
/// </summary>

namespace Employees.DAL
{
    public class EmployeeDAL
    {

        public bool CheckIDAndPassword(string UserID, string PWord)
        {
            string password = "";

            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID and password = @PWord"
            ;

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
                            password = reader["password"].ToString();
                        }
                    }
                }
            }
            return password == "";
        }

        public bool CheckUserID(string UserID)
        {
            string id = "";

            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID"
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@UserID", UserID));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             id = reader["user_id"].ToString();
                        }
                    }
                }
            }
            return id == "";
        }

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public string GetUserName(string UserID, string PWord)
        {
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
                            employee.UserID = reader["user_id"].ToString();
                            employee.Password = reader["password"].ToString();
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
