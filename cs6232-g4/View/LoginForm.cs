using cs6232_g4.Controller;
using cs6232_g4.DAL;
using cs6232_g4.Helper;
using cs6232_g4.Model;
using Employees.Controller;


/// <summary>
/// Interacts with the controller for the view for the login
/// Author:         Leslie & LM
/// Modifications:  From Iteration 1 Feedback:
///                 Add getting employee name
///                 Fix Login form functionality
///                 Add authentication
///                 Add showing user name
///                 removed unneeded using statements
/// Modified by:    Leslie
/// Modified Date:  27 Mar 2024
/// </summary>
/// 
namespace cs6232_g4.View
{
    public partial class LoginForm : Form
    {
        private LoginController _loginController;
        private EmployeeController _employeeController;
        private Login _login;

        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController();
            _employeeController = new EmployeeController();

        }

        /// <summary>
        /// Checks the username and password to match value, if correct we take the user to the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            try
            {
                username = this.TextUsername.Text.Trim();
                string entered = this.TextPassword.Text.Trim();
                password = EncryptionHelper.EncryptString(entered);

                if (this._loginController.CheckUserID(username))
                {
                    this.UserNameErrorlabel.ForeColor = Color.Red;
                    this.UserNameErrorlabel.Text = "Invalid UserName.";
                    this.TextUsername.Clear();
                    this.TextPassword.Clear();
                }
                else if (this._loginController.CheckLogin(username, password))
                {
                    this.PasswordErrorLabel.ForeColor = Color.Red;
                    this.PasswordErrorLabel.Text = "Invalid Password";
                    this.TextPassword.Clear();
                }
                else
                {
                    string emplName = this._employeeController.GetUserName(username, password);
                    if (emplName == null || emplName == "")
                    {
                        emplName = "NA";
                    }

                    using (Form dashboardForm = new DashboardForm(username, emplName))
                    {
                        Login user = new Login();
                        user.Username = username;
                        user.EmployeeId = this._loginController.GetEmployeeId(username);
                        this._loginController.SetLogin(user);
                        this.Hide();
                        DialogResult result = dashboardForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.Show();
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input \n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TextUsername_Click(object sender, EventArgs e)
        {
            this.UserNameErrorlabel.Text = "";
            this.PasswordErrorLabel.Text = "";
        }

        private void TextPassword_Click(object sender, EventArgs e)
        {
            this.PasswordErrorLabel.Text = "";
        }

        /// <summary>
        /// Clears the textbox values
        /// </summary>
        public void Logout()
        {
            
            TextUsername.Clear();
            TextPassword.Clear();
            Show();
            TextUsername.Focus();
            _login = new Login();
        }
    }
}
