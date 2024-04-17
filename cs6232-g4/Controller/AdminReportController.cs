
using cs6232_g4.DAL;
using cs6232_g4.Model;

namespace cs6232_g4.Controller
{
    /// <summary>
    /// Handles the interactions between the data and the view
    /// </summary>
    public class AdminReportController
    {
        private AdminReportDAL _adminReportDAL;

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
            return this._adminReportDAL.GetAdminReportData(StartDate, EndDate);
        }

    }
}
