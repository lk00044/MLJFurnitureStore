using Employees.Controller;
using Furnitures.Controller;
using Furnitures.Model;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;

/// <summary>
/// Furniture Search Form
/// Author: LM
/// 30 Mar 2024
/// </summary>
/// 
namespace cs6232_g4.View
{
    public partial class SearchFurnitureForm : Form
    {
        private readonly EmployeeController _employeeController;
        private readonly FurnitureController _furnitureController;
        private List<Furniture> _furniture;
        private bool loggedOut;
        private readonly LoginForm _loginForm;

        public SearchFurnitureForm(LoginForm loginForm)
        {
            InitializeComponent();
        }
        private void Clear()
        {
            RentalComboBox.Text = "";
            CategoryComboBox.Text = "";
            StyleComboBox.Text = "";

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

        private void Furniture()
        {
            SearchFurnitureDataGridView.DataSource = _furniture;

            if (SearchFurnitureDataGridView.Rows.Count > 0)
            {
                SearchFurnitureDataGridView.Rows[0].Selected = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string rental = RentalComboBox.Text;
            string category = CategoryComboBox.Text;
            string style = StyleComboBox.Text;

            try
            {

                if (string.IsNullOrEmpty(rental) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select rental ID, category, or style to search", "Rental ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _furniture = _furnitureController.GetFurnitureByID(rental);
                _furniture = _furnitureController.GetFurnitureByCategory(category);
                _furniture = _furnitureController.GetFurnituryByStyle(style);
                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching your search found");
                }

                SearchFurnitureDataGridView.DataSource = _furniture;

                Furniture();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
