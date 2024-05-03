using cs6232_g4.Model;
using System.Data.SqlClient;

namespace cs6232_g4.DAL
{
    /// <summary>
    /// Data access for the admin report
    /// Programmer: Leslie
    /// </summary>
    public class AdminReportDAL
    {

        /// <summary>
        /// Purpose: Gets the statistics that show the most popular furniture
        /// during the specified period for furniture with the same furnitureID
        /// that was rented out in at least two transactions.
        /// </summary>
        /// <param name="StartDate">The start date.</param>
        /// <param name="EndDate">The end date.</param>        

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
    }
}
