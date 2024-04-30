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
            this._furnitureController = new FurnitureController();
            this._furniture = new List<Furniture>();
            this._bindingSource = new BindingSource();

            LoadFurnitureIDs();
            LoadFurnitureCategories();
            LoadFurnitureStyles();  
            
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
            this.RefreshDataGridView();
        }

        /// <summary>
        /// Refreshes the data grid view.
        /// </summary>
        public void RefreshDataGridView()
        {
            RefreshDataGridView(this._furnitureController.GetAllFurniture());
        }
        private void RefreshDataGridView(List<Furniture> furniture)
        {
            _furniture = furniture;
            SearchFurnitureDataGridView.DataSource = null;
            SearchFurnitureDataGridView.DataSource = _furniture;
            SearchFurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Clear();
        }

        private void LoadFurnitureIDs()

        {
            try
            {
                List<int> ids = this._furnitureController.GetAllFurnitureIDs();
                this.FurnitureComboBox.Items.Clear();
                foreach (int id in ids)
                {
                    this.FurnitureComboBox.Items.Add(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void LoadFurnitureCategories()
        {
            try
            {
                List<string> categories = this._furnitureController.GetAllFurnitureCategories();
                categories.Insert(0, "");
                CategoryComboBox.DataSource = categories;
                CategoryComboBox.DisplayMember = "Category";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }


        }

        private void LoadFurnitureStyles()
        {
            try
            {
                List<string> styles = this._furnitureController.GetAllFurnitureStyles();
                styles.Insert(0, "");
                StyleComboBox.DataSource = styles;
                StyleComboBox.DisplayMember = "Style";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }


        /// <summary>
        /// Shows the furniture.
        /// </summary>
        private void ShowFurniture()
        {
            try
            {
                this.SearchFurnitureDataGridView.DataSource = null;
                this._bindingSource.DataSource = this._furniture;
                this.SearchFurnitureDataGridView.DataSource = this._furniture;
                this.SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetupGrid()
        {
            foreach (DataGridViewColumn column in SearchFurnitureDataGridView.Columns)
            {
                switch (column.Name)
                {
                    case "FurnitureIDText":
                        column.HeaderText = "ID";
                        break;
                    case "FurnitureGridText":
                        column.HeaderText = "Name";
                        break;
                    case "CategoryGridText":
                        column.HeaderText = "Category";
                        break;
                    case "StyleGridText":
                        column.HeaderText = "Style";
                        break;
                    case "QuantityGridText":
                        column.HeaderText = "Total Quantity";
                        column.Width = 150;
                        break;
                    case "InfoGridText":
                        column.HeaderText = "Description";
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        break;
                    case "AvailableGridText":
                        column.HeaderText = "In Stock";
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Resets the combo boxes.
        /// </summary>
        private void resetComboBoxes()
        {
            this.FurnitureComboBox.SelectedIndex = -1;
            this.StyleComboBox.SelectedIndex = -1;
            this.CategoryComboBox.SelectedIndex = -1;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(FurnitureComboBox.Text, out ID);
            string category = CategoryComboBox.Text;
            string style = StyleComboBox.Text;

            try
            {
                List<Furniture> searchedFurniture = _furnitureController.SearchFurniture(ID, category, style);

                if (searchedFurniture.Count == 0)
                {
                    MessageBox.Show("No furniture matching the search criteria found", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RefreshDataGridView(searchedFurniture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }
}
