/// <summary>
/// Login Data Access Layer
/// Group 4
/// Author: Laskey
/// </summary>

using cs6232_g4.Model;
using Employees.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public static void SetLogin(Login login)
    {
        _currentLogin = login;
    }

    /// <summary>
    /// Gets the current user logged in 
    /// </summary>
    /// <returns></returns>
    public static Login GetCurrentLogin()
    {
        return _currentLogin;
        }

    /// <summary>
    /// Checks login
    /// </summary>
    /// <returns></returns>
    public Login CheckLogin (Login login)
        {

        string selectStatement =
            "SELECT user_id, password " +
            "FROM Login " +
            "WHERE user_id = @UserID and @password";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@UserID", login.Username));
                    selectCommand.Parameters.Add(new SqlParameter("@Password", login.Password));
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["UserID"] != DBNull.Value)
                            {
                                login.MemberId = Convert.ToInt32(reader["userId"]);
                                login.Active = Convert.ToBoolean(reader["active"]);
                            }
                        }
                    }
                }
            }
            return login;
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
    }


}