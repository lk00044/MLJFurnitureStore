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

        private void SetupGrid()
        {

            this.SearchFurnitureDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.SearchFurnitureDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SearchFurnitureDataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.SearchFurnitureDataGridView.Columns[5].Width = 150;
            this.SearchFurnitureDataGridView.AutoGenerateColumns = false;
            this.SearchFurnitureDataGridView.AutoSize = true;

            this.SearchFurnitureDataGridView.Columns[0].HeaderText = "ID";
            this.SearchFurnitureDataGridView.Columns[1].HeaderText = "Name";
            this.SearchFurnitureDataGridView.Columns[2].HeaderText = "Description";
            this.SearchFurnitureDataGridView.Columns[3].HeaderText = "Category";
            this.SearchFurnitureDataGridView.Columns[4].HeaderText = "Style";
            this.SearchFurnitureDataGridView.Columns[5].HeaderText = "Total Quantity";
            this.SearchFurnitureDataGridView.Columns[6].HeaderText = "In Stock";
            this.SearchFurnitureDataGridView.Columns[7].HeaderText = "Daily Rate";
            this.SearchFurnitureDataGridView.Columns[7].DefaultCellStyle.Format = "c";
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

        /// <summary>
        /// Handles the SelectionChangeCommitted event of the FurnitureComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.FurnitureComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    int idSelected = Int32.Parse(selected);
                    this._furniture = this._furnitureController.GetFurnitureByID(idSelected);
                    this.ShowFurniture();
                    this.resetComboBoxes();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Handles the SelectionChangeCommitted event of the CategoryComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.CategoryComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._furniture = this._furnitureController.GetFurnitureByCategory(selected);
                    this.ShowFurniture();
                    this.resetComboBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Handles the SelectionChangeCommitted event of the StyleComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void styleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.StyleComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._furniture = this._furnitureController.GetFurnitureByStyle(selected);
                    this.ShowFurniture();
                    this.resetComboBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
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
            if (!int.TryParse(FurnitureComboBox.Text, out ID))
            {
                // Handle invalid input, such as displaying an error message
                MessageBox.Show("Invalid ID. Please select a valid integer.");
                return;
            }
            string category = CategoryComboBox.Text;
            string style = StyleComboBox.Text;

            if (ID == 0 && string.IsNullOrEmpty(category) && string.IsNullOrEmpty(style))
            {
                 MessageBox.Show("Please select furniture ID, category, or style to search", "Furniture ID OR Category OR Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }

            try
            {
                List<Furniture> searchedFurniture = new List<Furniture>();

                if (ID != 0)
                {
                    List<Furniture> furnitureByID = _furnitureController.GetFurnitureByID(ID);
                    searchedFurniture.AddRange(furnitureByID);
                    if (furnitureByID.Count == 0)
                    {
                        MessageBox.Show("No furniture matching that ID found");
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(category))
                {
                    List<Furniture> furnitureByCategory = _furnitureController.GetFurnitureByCategory(category);
                    searchedFurniture.AddRange(furnitureByCategory);
                    if (furnitureByCategory.Count == 0)
                    {
                        MessageBox.Show("No furniture matching that category found");
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(style))
                {
                    List<Furniture> furnitureByStyle = _furnitureController.GetFurnitureByStyle(style);
                    searchedFurniture.AddRange(furnitureByStyle);
                    if (furnitureByStyle.Count == 0)
                    {
                        MessageBox.Show("No furniture matching that style found");
                        return;
                    }
                }

                SearchFurnitureDataGridView.DataSource = searchedFurniture;
                Furniture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
