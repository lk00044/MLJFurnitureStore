using Employees.DAL;
using System.Diagnostics.Eventing.Reader;

namespace Employees.Controller
{
    public class EmployeeController
    {

        private EmployeeDAL _employeeDAL;

        public EmployeeController()
        {
            _employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Checks the password as long as the user id and password match
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public bool CheckIDAndPassword(string UserID, string PWord)
        {
            return this._employeeDAL.CheckIDAndPassword(UserID, PWord);
        }

        /// <summary>
        /// Gets the name of the user if there is a correct id and password
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns> Employee Name </returns>
        public string GetUserName(string UserID, string PWord)
        {
            return this._employeeDAL.GetUserName(UserID, PWord);
        }

        /// <summary>
        /// Checks the user id is in the database
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <returns></returns>
        public bool CheckUserID(string UserID)
        {
            return this._employeeDAL.CheckUserID(UserID);
        }
    }
}
