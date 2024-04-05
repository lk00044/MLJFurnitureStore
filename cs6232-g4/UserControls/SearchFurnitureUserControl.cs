
using Employees.Controller;
using Furnitures.Controller;
using Furnitures.Model;

namespace cs6232_g4.UserControls
{
    public partial class SearchFurnitureUserControl : UserControl
    {
        private readonly EmployeeController _employeeController;
        private readonly FurnitureController _furnitureController;
        private List<Furniture> _furniture;

        public SearchFurnitureUserControl()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            RentalComboBox.Text = "";
            CategoryComboBox.Text = "";
            StyleComboBox.Text = "";

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

                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching that rental ID found");
                }

                else if (string.IsNullOrEmpty(rental) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select rental ID, category, or style to search", "Rental ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _furniture = _furnitureController.GetFurnitureByCategory(category);

                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching that category found");
                }

                else if (string.IsNullOrEmpty(rental) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select rental ID, category, or style to search", "Rental ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _furniture = _furnitureController.GetFurnituryByStyle(style);
                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching that style found");
                }

                SearchFurnitureDataGridView.DataSource = _furniture;

                Furniture();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
