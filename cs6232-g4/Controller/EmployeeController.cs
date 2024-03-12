using Employees.DAL;

namespace Employees.Controller
{
    public class EmployeeController
    {

        private EmployeeDAL EmployeeSource;

        public EmployeeController()
        {
            EmployeeSource = new EmployeeDAL();
        }

        public bool CheckLogIn(string UserID, string PWord)
        {
            return this.EmployeeSource.CheckLogIn(UserID, PWord);
        }

    }
}
