/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// Author: Laskey
/// </summary>
/// 

using cs6232_g4.DAL;
using cs6232_g4.Model;

namespace cs6232_g4.Controller
{
    public class LoginController
    {
        private LoginDAL _loginDAL;

        public LoginController() {
            _loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Checks userID against password
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public bool CheckLogin(string userID, string password)

        {
            return this._loginDAL.CheckLogin(userID, password);
        }

        /// <summary>
        /// Checks Login 
        /// Author: Leslie Keller
        /// </summary>
        public bool CheckUserID(string UserID)
        {
            return this._loginDAL.CheckUserID(UserID);
        }

        /// <summary>
        /// gets employee ID
        /// </summary>
        /// <returns></returns>
        public int GetEmployeeId(string UserID)
        {
            return this._loginDAL.GetEmployeeId(UserID);
        }


        /// <summary>
        /// Gets the current user logged in 
        /// </summary>
        /// <returns></returns>
        public Login GetCurrentLogin()
        {
            return this._loginDAL.GetCurrentLogin();
        }

        /// <summary>
        /// Sets the current user as logged in 
        /// </summary>
        /// <param name="login"></param>
        public void SetLogin(Login login)
        {
            this._loginDAL.SetLogin(login);
        }
    }
}
