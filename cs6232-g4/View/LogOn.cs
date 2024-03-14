using Employees.Controller;

namespace Logon.View
{
    public partial class LogOnForm : Form
    {
        EmployeeController _employeeController;

        public LogOnForm()
        {
            InitializeComponent();
            _employeeController = new EmployeeController();
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            string userID = "";
            string password = "";
            try
            {
                userID = this.UserIDInputTextBox.Text;
                password = this.PasswordInputTextBox.Text;

                if (this._employeeController.CheckUserID(userID))
                {
                    this.UserIDErrorLabel.ForeColor = Color.Red;
                    this.UserIDErrorLabel.Text = "Invalid User ID.";
                    this.UserIDInputTextBox.Clear();
                    this.PasswordInputTextBox.Clear();
                }
                               
                else if (this._employeeController.CheckPassword(userID, password))
                {
                    this.PasswordErrorLabel.ForeColor = Color.Red;
                    this.PasswordErrorLabel.Text = "Invalid Password";
                    this.UserIDInputTextBox.Clear();
                    this.PasswordInputTextBox.Clear();
                } 
                else
                {
                    string emplName = this._employeeController.GetUserName(userID, password);

                    using (Form dashboardTabForm = new DashboardForm(userID, emplName))
                    {
                        this.Hide();
                        dashboardTabForm.Show();                        
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

        private void UserIDInputTextBox_Click(object sender, EventArgs e)
        {
            this.UserIDErrorLabel.Text = "";
            this.PasswordErrorLabel.Text = "";
        }

        private void PasswordInputTextBox_Click(object sender, EventArgs e)
        {
            this.UserIDErrorLabel.Text = "";
            this.PasswordErrorLabel.Text = "";
        }
    }
}
