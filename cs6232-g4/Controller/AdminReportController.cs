using cs6232_g4.DAL;
using cs6232_g4.Model;


/// <summary>
/// Programmer: Leslie
/// </summary>

namespace cs6232_g4.Controller
{
    /// <summary>
    /// Handles the interactions between the data and the view
    /// </summary>
    public class AdminReportController
    {
        private AdminReportDAL _adminReportDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminReportController"/> class.
        /// </summary>
        public AdminReportController()
        {
            _adminReportDAL = new AdminReportDAL();
        }

        /// <summary>
        /// Gets the admin report data.
        /// </summary>
        /// <param name="StartDate">The start date.</param>
        /// <param name="EndDate">The end date.</param>
        /// <returns></returns>
        public List<AdminReport> GetAdminReportData(DateTime StartDate, DateTime EndDate)
        {
            return (List<AdminReport>)this._adminReportDAL.GetAdminReportData(StartDate, EndDate);
        }

    }
}
