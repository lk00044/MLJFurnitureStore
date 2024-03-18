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


namespace cs6232_g4.View
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;
        private LoginForm _login;
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
                _login.Username = txtUsername.Text.Trim();
                _login.Password = EncryptionHelper.EncryptString(_login.Password);

                _login = _loginController.CheckIfLoginIsValid(_login);

                if (_login.AdministratorId > 0)
                {
                    AdministratorForm _adminForm = new AdministratorForm(this);
                    _adminForm.SetUsername(_login, _userController.GetUserAdminByLogin(_login));
                    LoginDAL.SetLogin(_login);
                    Hide();
                    _adminForm.Show();
                }
                else if (_login.NurseId > 0)
                {
                    LoginDAL.SetLogin(_login);

                    SearchPatientForm _searchPatientForm = new SearchPatientForm(this);
                    _searchPatientForm.SetUsername(_login, _userController.GetUserNurseByLogin(_login));
                    Hide();
                    _searchPatientForm.Show();
                }
                else
                {
                    lblError.Text = "Invalid username/password";
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
