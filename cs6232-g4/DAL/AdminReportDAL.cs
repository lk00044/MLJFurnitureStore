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

        public List<AdminReport> getAdminReport(DateTime StartDate, DateTime EndDate)
        {
            List<AdminReport> reportData = new List<AdminReport>();

            /// Get all rentals on furniture that have more than 1 rental
            string selectStatement =
               "SELECT  f.furniture_id, f.name, f.category_name, " +
               "        count(rt.transaction_id) as totalTransactions " +
               "        count(li.line_item_id) as totalRentals " +
               "        count(mbr.member_id) as totalNumOfMembers " +
               "        rt.transaction_date, mbr.date_of_birth " +


               "        concat(round((COUNT(IF(DATE_FORMAT(FROM_DAYS(DATEDIFF(rt.transaction_date, mbr.date_of_birth)), '%Y') > 17 and " +
               "        DATE_FORMAT(FROM_DAYS(DATEDIFF(rt.transaction_date, mbr.date_of_birth)), '%Y') < 30, mbr.member_id, NULL)) / " +
               "        count(mbr.member_id)), 2) * 100) as pct_18_to_29, " +

               "        pct_out_of_age_range as (100 - pct_18_to_29) " +

               "        FROM Furniture f " +

               "        INNER JOIN RentalTransaction rt " +
               "        ON f.furniture_id = rt.furniture_id " +

               "        INNER JOIN RentalLineItem li " +
               "        ON rt.transaction_id = li.transaction_id " +

               "        INNER JOIN StoreMember mbr " +
               "        ON rt.member_id = mbr.member_id " +

                        "WHERE totalRentals > 1 and " +
                        "and (rt.transaction_date between @StartDate and @EndDate) "
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
                        AdminReport data = new AdminReport(); ;

                        while (reader.Read())
                        {
                            data = new AdminReport();
                            data.FurnitureId = (int)reader["furniture_id"];
                            data.Name = (string)reader["name"];
                            data.CategoryName = (string)reader["category"];
                            data.PctOfMembers18To29 = pct_18_to_29;
                            data.TotalRentals = (int)totalRentals;

                            reportData.Add(data);
                        }
                    }
                }
            }
            return reportData;
        }
    }
}
