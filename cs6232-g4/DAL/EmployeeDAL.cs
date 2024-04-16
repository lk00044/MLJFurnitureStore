using cs6232_g4.DAL;
using cs6232_g4.Helper;
using cs6232_g4.Model;
using Furnitures.Model;
using Members.Model;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        /// <summary>
        /// Purpose: Gets the statistics that show the most popular furniture
        /// during the specified period for furniture with the same furnintureID
        /// that was rented out in at least two transactions.
        /// </summary>
        /// <param name="StartDate">The start date.</param>
        /// <param name="EndDate">The end date.</param>
        /// Specifications: 
        /// For each furniture qualified (to qualify, the furniture should be rented 
        /// in at least two rental transactions during the specified period, inclusive), 
        /// show: 
        /// 1) furniture id, 
        /// 2) furniture category, 
        /// 3) furniture name, 
        /// 4) the total number of rental transactions in which the qualified furniture 
        ///    was rented during the specified period, 
        /// 5) the total number of all the furniture rental transactions(occurred) 
        ///    during the specified period, 
        /// 6) the percentage of the number in 4) over the number in 5), 
        /// 7) the percentage of members aged 18-29 (at the time when the 
        ///    furniture was rented) who rented the qualified furniture among all 
        ///    the people who rented the qualified furniture during the specified period.
        ///    Note that if the same member rented the same furniture in two rentals, 
        ///    it’s viewed as two different members.
        /// 8) The percentage of members outside of the range 18-29 
        ///    (at the time when the furniture was rented) who rented the qualified 
        ///    furniture among all the people who rented the qualified furniture during 
        ///    the specified period.

        public List<AdminReport> getAdminRrport(DateTime StartDate, DateTime EndDate)
        {
            List<AdminReport> reportData = new List<AdminReport>();

            /// Get all rentals on furniture that have more than 1 rental
            string selectStatement =
               "SELECT  f.furniture_id, f.name, f.category_name " +
               "        count(rt.TransactionID) as totalTransactions " +
               "        count(rt.LineItemId) as totalRentals " +
               "        concat(round((COUNT(DISTINCT IF(DATE_FORMAT(FROM_DAYS(DATEDIFF(now(), mbr.dateOfBirth)), '%Y') > 17 and " +
               "        DATE_FORMAT(FROM_DAYS(DATEDIFF(now(), mbr.dateOfBirth)), '%Y') < 30, mbr.memberID, NULL)) / " +
               "        count(distinct mbr.memberID)), 2) * 100) as pct_18_to_29, " +
               "    concat(round((COUNT(DISTINCT IF(DATE_FORMAT(FROM_DAYS(DATEDIFF(now(), mbr.dateOfBirth)), '%Y') < 18 or DATE_FORMAT(FROM_DAYS(DATEDIFF(now(), mbr.dateOfBirth)), '%Y') > 29, mbr.memberID, NULL))\r\n\t\t\t\t/ count(distinct mbr.memberID)), 2) * 100, \" %\") as pct_out_of_age_range\r\n    from transaction t " +
               "FROM Furniture f " +
               "INNER JOIN RentalTransaction rt " +
               "ON f.furniture_id = rt.furniture_id " +
               "WHERE totalRentals > 1 and (rt.TransactionDate between StartDate and EndDate) "
               ;


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.FurnitureId = (int)reader["furniture_id"];
                            furniture.Name = (string)reader["name"];
                            furniture.Description = (string)reader["description"];
                            furniture.DailyRentalRate = (decimal)reader["daily_rental_rate"];
                            furniture.InstockQuantity = (int)reader["instock_quantity"];
                            furniture.TotalQuantity = (int)reader["total_quantity"];
                            furniture.CategoryName = (string)reader["category_name"];
                            furniture.StyleName = (string)reader["style_name"];

                            reportData.Add(furniture);
                        }
                    }
                }
            }

            return reportData;
        }

    

    }
}
