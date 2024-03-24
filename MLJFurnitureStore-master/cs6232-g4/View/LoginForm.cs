using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs6232_g4.DAL;
using cs6232_g4.Controller;
using cs6232_g4.Model;
using cs6232_g4.Helper;
using Members.Controller;


namespace cs6232_g4.View
{
    public partial class LoginForm : Form
    {
        private LoginController _loginController;
        private Login _login;
        private MembersController _memberController;
        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController();
            _login = new Login();
        }

        /// <summary>
        /// Checks the username and password to match value, if correct we take the user to the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                _login.Username = TextUsername.Text.Trim();
                _login.Password = EncryptionHelper.EncryptString(_login.Password);

                
                if (_login.Username is null)
                {
                    LoginForm _loginForm = new LoginForm();
                    _loginForm._login = _login;
                    LoginDAL.SetLogin(_login);
                    Hide();
                    _loginForm.Show();
                }
                else
                {
                    LblError.Text = "Invalid username/password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
