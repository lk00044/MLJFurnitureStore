/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// Author: Laskey
/// </summary>
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs6232_g4.Model;
using cs6232_g4.DAL;

namespace cs6232_g4.Controller
{
    public class LoginController
    {
        private LoginDAL loginDAL;

        public LoginController() {
            loginDAL = new LoginDAL();
        }

        /// <summary>
        /// Checks userID against password
        /// </summary>
        /// <param name="UserID">The user identifier.</param>
        /// <param name="PWord">The p word.</param>
        /// <returns></returns>
        public Login CheckLogin(Login login)

        {
            return this.loginDAL.CheckLogin(login);
        }

        /// <summary>
        /// Checks the login fields are valid
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Login CheckIfLoginIsValid(Login login)
        {
            return loginDAL.CheckLogin(login);
        }
    }
}
