using Employees.DAL;

/// <summary>
/// Interacts with the DAL for the employee and the view
/// </summary>
namespace Employees.Controller
{
    public class EmployeeController
    {

        private EmployeeDAL _employeeDal;

        public EmployeeController()
        {
            _employeeDal = new EmployeeDAL();
        }

        public string GetUserName(string UserID, string PWord)
        {
            return this._employeeDal.GetUserName(UserID, PWord);
        }

    }
}
