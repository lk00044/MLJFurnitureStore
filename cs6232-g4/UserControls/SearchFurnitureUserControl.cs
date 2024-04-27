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
                    this._furniture = this._furnitureController.GetFurnituryByStyle(selected);
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
