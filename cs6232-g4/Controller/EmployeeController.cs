using Employees.DAL;

/// <summary>
/// Interacts with the DAL for the employee and the view
/// </summary>
namespace Employees.Controller
{
    /// <summary>
    /// Creates an intermediary between the view and the database layer
    /// </summary>
    public class EmployeeController
    {

        private EmployeeDAL _employeeDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            _employeeDal = new EmployeeDAL();
        }

        /// <summary>
        /// verifies the username exists in the DB 
        /// </summary>
        /// <param name="UserID">user id</param>
        /// <param name="PWord"> password</param>
        /// <returns>username or empty string if not found</returns>
        public string GetUserName(string UserID, string PWord)
        {
            return this._employeeDal.GetUserName(UserID, PWord);
        }

    }
}
