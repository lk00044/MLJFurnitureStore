using cs6232_g4.Model;
using System.Data.SqlClient;

namespace cs6232_g4.DAL
{
    /// <summary>
    /// Data access for the admin report
    /// </summary>
    public class AdminReportDAL
    {

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

        public IList<AdminReport> GetAdminReportData(DateTime StartDate, DateTime EndDate)
        {
            var reportData = new List<AdminReport>();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand("GetAdminReport", connection))
                {
                    selectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    selectCommand.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                    selectCommand.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                    selectCommand.Parameters["@StartDate"].Direction = System.Data.ParameterDirection.Input;
                    selectCommand.Parameters["@EndDate"].Direction = System.Data.ParameterDirection.Input;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        AdminReport data;

                        while (reader.Read())
                        {
                            data = new AdminReport();
                            data.FurnitureId = (int)reader["furniture_id"];
                            data.Name = (string)reader["name"];
                            data.CategoryName = (string)reader["category_name"];
                            data.TotalRentalsOfInterest = (int)reader["total_qualifying_trans"];
                            data.TotalTransactions = (int)reader["total_transactions"];
                            data.PctOfQualifyingTransactions = (int)reader["pct_qualifying_transactions"];
                            data.PctOfMembers18To29 = (int)reader["pct_18_to_29"];
                            data.PctOfRemainingMembers = (int)reader["pct_over_age_range"];                            

                            reportData.Add(data);
                        }
                    }
                }
            }
            return reportData;
        }

        /// <summary>
        /// 5) the total number of all the furniture rental transactions(occurred) 
        ///    during the specified period, 
        /// </summary>
        /// <param name="StartDate">The start date.</param>
        /// <param name="EndDate">The end date.</param>
        /// <returns>total number of transactions between dates inclusively</returns>
        public int getTotalOverallTransactions(DateTime StartDate, DateTime EndDate)
        {
            int totalOverallTransactions = 0;

            string selectStatement =
                "SELECT count(rt.transaction_id) as total, li.furniture_id " +
                "FROM RentalTransaction rt " +
                "INNER JOIN RentalLineItem li " +
                "ON rt.transaction_id = li.rental_transaction_id " +
                "WHERE rt.transaction_date between @StartDate and @EndDate " +
                "GROUPBY li.furniture_id "
            ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                    selectCommand.Parameters.Add(new SqlParameter("@EndDate", EndDate));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalOverallTransactions = (int)reader["total"];
                        }
                    }
                }
            }

            return totalOverallTransactions;

        }
    }
}
