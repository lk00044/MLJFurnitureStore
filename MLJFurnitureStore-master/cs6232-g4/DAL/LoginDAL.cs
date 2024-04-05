/// <summary>
/// Login Data Access Layer
/// Group 4
/// Author: Laskey
/// Modified by: Leslie
/// Modified on: 27 March 2024
/// Modification: Updated CheckLogin
/// </summary>

using cs6232_g4.Helper;
using cs6232_g4.Model;
using System.Data.SqlClient;

namespace cs6232_g4.DAL
{
    /// <summary>
    /// Login Class
    /// </summary>
    public class LoginDAL
    {
        private static Login _currentLogin;

        /// <summary>
        /// Sets the current user as logged in 
        /// </summary>
        /// <param name="login"></param>
        public void SetLogin(Login login)
        {
            _currentLogin = login;
        }

        /// <summary>
        /// Gets the current user logged in 
        /// </summary>
        /// <returns></returns>
        public Login GetCurrentLogin()
        {
            return _currentLogin;
        }

        /// <summary>
        /// Checks Password
        /// </summary>
        /// <returns></returns>
        public bool CheckLogin(string UserID, string Entered)
        {
            string decrypted = EncryptionHelper.DecryptString(Entered);
            string Password = "";

            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID";

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
                            Password = reader["password"].ToString();                            
                        }
                    }
                }
            }
            return !(decrypted.Equals(Password));
        }

        /// <summary>
        /// checks userID
        /// </summary>
        /// <returns></returns>
        public bool CheckUserID(string UserID)
        {
            string id = "";

            string selectStatement =
                "SELECT user_id, password " +
                "FROM Login " +
                "WHERE user_id = @UserID";

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
        /// gets employee ID
        /// </summary>
        /// <returns></returns>
        public int GetEmployeeId(string UserID)
        {

            string selectStatement =
                "SELECT employee_id " +
                "FROM Login " +
                "JOIN Employee ON login_userID = user_id "+
                "WHERE login_userID = @UserID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@UserID", UserID));
                    return (int) selectCommand.ExecuteScalar();
                }
            }

        }
    }
}