using Employees.Controller;
using Furnitures.Controller;
using Furnitures.Model;

namespace cs6232_g4.UserControls
{
    public partial class SearchFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private List<Furniture> _furniture;
        private BindingSource _bindingSource;

        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            _furnitureController = new FurnitureController();
            _furniture = new List<Furniture>();
            _bindingSource = new BindingSource();

        }

        private void Clear()
        {
            FurnitureComboBox.Text = "";
            CategoryComboBox.Text = "";
            StyleComboBox.Text = "";

        }

        private void FurnitureSearchUserControl_Load(object sender, EventArgs e)
        {
            this.LoadFurnitureCategories();
            this.LoadFurnitureIDs();
            this.LoadFurnitureStyles();
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

        private void LoadFurnitureIDs()
        {
            this.FurnitureComboBox.Items.Clear();

            List<int> ids = new List<int>();
            ids = this._furnitureController.GetAllFurnitureIDs();
            foreach (int id in ids)
            {
                this.FurnitureComboBox.Items.Add(id);
            }
        }

        private void LoadFurnitureCategories()
        {
            this.CategoryComboBox.Items.Clear();

            List<string> categories = new List<string>();
            categories = this._furnitureController.GetAllFurnitureCategories();
            foreach (string category in categories)
            {
                this.CategoryComboBox.Items.Add(category);
            }
        }

        private void LoadFurnitureStyles()
        {
            this.StyleComboBox.Items.Clear();

            List<string> styles = new List<string>();
            styles = this._furnitureController.GetAllFurnitureStyles();
            foreach (string style in styles)
            {
                this.StyleComboBox.Items.Add(style);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string ID = FurnitureComboBox.Text;
            string category = CategoryComboBox.Text;
            string style = StyleComboBox.Text;

            try
            {

                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select furniture ID, category, or style to search", "Furniture ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _furniture = _furnitureController.GetFurnitureByID(ID);

                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching that furniture ID found");
                }

                else if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select furniture ID, category, or style to search", "Furniture ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _furniture = _furnitureController.GetFurnitureByCategory(category);

                if (_furniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching that category found");
                }

                else if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(style))
                {
                    MessageBox.Show("Please select furniture ID, category, or style to search", "Furniture ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
