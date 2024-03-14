
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

        public bool CheckPassword(string UserID, string PWord)
        {
            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID and password = @PWord"
            ;

            Employe employee = new Employe();

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
            return (string.IsNullOrEmpty(employee.Password));
        }

        public bool CheckUserID(string UserID)
        {
            string pwd = "";

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
                             pwd = reader["password"].ToString();
                        }
                    }
                }
            }
            return pwd == "";
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
               "ON l.user_id = @UserID and l.password = @PWord and l.user_id = e.employee_id "
           ;

            Employe employee = new Employe();

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
