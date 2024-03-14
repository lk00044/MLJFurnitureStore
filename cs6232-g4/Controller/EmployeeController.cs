using Employees.DAL;
using System.Diagnostics.Eventing.Reader;

namespace Employees.Controller
{
    public class EmployeeController
    {

        private EmployeeDAL EmployeeSource;

        public EmployeeController()
        {
            EmployeeSource = new EmployeeDAL();
        }

        /// <summary>
        /// Checks the password as long as the user id and password match
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public bool CheckIDAndPassword(string UserID, string PWord)
        {
            return this.EmployeeSource.CheckIDAndPassword(UserID, PWord);
        }

        /// <summary>
        /// Gets the name of the user if there is a correct id and password
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns> Employee Name </returns>
        public string GetUserName(string UserID, string PWord)
        {
            return this.EmployeeSource.GetUserName(UserID, PWord);
        }

        /// <summary>
        /// Checks the user id is in the database
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <returns></returns>
        public bool CheckUserID(string UserID)
        {
            return this.EmployeeSource.CheckUserID(UserID);
        }
    }
}
