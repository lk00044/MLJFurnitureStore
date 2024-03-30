using Employees.Controller;
using System.Drawing.Text;
using System.Windows.Forms;

/// <summary>
/// Furniture Search Form
/// Author: LM
/// Modified Date: 30 Mar 2024
/// </summary>
/// 
namespace cs6232_g4.View
{
    public partial class SearchFurnitureForm : Form
    {
        private readonly EmployeeController _employeeController;
        private bool loggedOut;
        private readonly LoginForm _loginForm;

        public SearchFurnitureForm(LoginForm loginForm)
        {
            InitializeComponent();
        }
        private void clear()
        {

        }
        private void SearchFurniture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                Application.Exit();
            }
        }
        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggedOut = true;
            _loginForm.Logout();
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            loggedOut = true;
            _loginForm.Logout();
            Close();
        }
        private void SearchFurnitureDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SearchFurnitureDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
