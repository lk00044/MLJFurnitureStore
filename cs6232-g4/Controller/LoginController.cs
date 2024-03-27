/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// Author: Laskey
/// </summary>
/// 

using cs6232_g4.DAL;

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

    }
}
