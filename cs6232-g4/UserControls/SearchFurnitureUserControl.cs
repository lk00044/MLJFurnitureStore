using Furnitures.Model;
using Members.Controller;

/// <summary>
/// Class to handle the user interaction for the view and the database
/// Programmer:     Leslie Keller
/// Date:           06 Apr 2024
/// Modified by:  
/// Modified on:    
/// Modifications:  
/// </summary>
/// 
namespace cs6232_g4.UserControls
{

    /// <summary>
    /// Creates the User Control for the Search Furniture function
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    /// 
    public partial class SearchFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
         private List<Furniture> _selectedFurniture;
        private BindingSource bindingSource1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureSearchUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._selectedFurniture = new List<Furniture>();
            this.bindingSource1 = new BindingSource();
        }

        /// <summary>
        /// Handles the Load event of the FurnitureSearchUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FurnitureSearchUserControl_Load(object sender, EventArgs e)
        {
            this.LoadFurnitureCategories();
            this.LoadFurnitureIds();
            this.LoadFurnitureStyles();
        }

        // Helper Functions ----------------------------------------------------------

        /// <summary>
        /// Loads the furniture ids.
        /// 
        /// </summary>
        private void LoadFurnitureIds()
        {
            this.furnitureIDComboBox.Items.Clear();

            List<int> ids = new List<int>();
            ids = this._furnitureController.GetAllFurnitureIDs();
            foreach (int id in ids)
            {
                this.furnitureIDComboBox.Items.Add(id);
            }
        }

        /// <summary>
        /// Loads the furniture categories.
        /// </summary>
        private void LoadFurnitureCategories()
        {
            this.furnitureCategoriesComboBox.Items.Clear();

            List<string> categories = new List<string>();
            categories = this._furnitureController.GetFurnitureCategories();
            foreach (string category in categories)
            {
                this.furnitureCategoriesComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Loads the furniture styles.
        /// </summary>
        private void LoadFurnitureStyles()
        {
            this.furnitureStyleComboBox.Items.Clear();

            List<string> styles = new List<string>();
            styles = this._furnitureController.GetFurnitureStyles();
            foreach (string style in styles)
            {
                this.furnitureStyleComboBox.Items.Add(style);
            }
        }

        /// <summary>
        /// Setups the grid.
        /// </summary>
        private void SetupGrid()
        {

            this.FurnitureDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.FurnitureDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FurnitureDataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.FurnitureDataGridView.Columns[5].Width = 150;
            this.FurnitureDataGridView.AutoGenerateColumns = false;
            this.FurnitureDataGridView.AutoSize = true;

            this.FurnitureDataGridView.Columns[0].HeaderText = "ID";
            this.FurnitureDataGridView.Columns[1].HeaderText = "Name";
            this.FurnitureDataGridView.Columns[2].HeaderText = "Description";
            this.FurnitureDataGridView.Columns[3].HeaderText = "Category";
            this.FurnitureDataGridView.Columns[4].HeaderText = "Style";
            this.FurnitureDataGridView.Columns[5].HeaderText = "Total Quantity";
            this.FurnitureDataGridView.Columns[6].HeaderText = "In Stock";
            this.FurnitureDataGridView.Columns[7].HeaderText = "Daily Rate";
            this.FurnitureDataGridView.Columns[7].DefaultCellStyle.Format = "c";
        }

        /// <summary>
        /// Shows the furniture.
        /// </summary>
        private void ShowFurniture()
        {
            try
            {
                this.FurnitureDataGridView.DataSource = null;
                this.bindingSource1.DataSource = this._selectedFurniture;
                this.FurnitureDataGridView.DataSource = this._selectedFurniture;
                this.SetupGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Handles the SelectionChangeCommitted event of the furnitureIDComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureIDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.furnitureIDComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    int idSelected = Int32.Parse(selected);
                    this._selectedFurniture = this._furnitureController.GetFurnitureById(idSelected);
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
        /// Handles the SelectionChangeCommitted event of the furnitureCategoriesComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureCategoriesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.furnitureCategoriesComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._selectedFurniture = this._furnitureController.GetFurnitureByCategory(selected);
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
        /// Handles the SelectionChangeCommitted event of the furnitureStyleComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.furnitureStyleComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._selectedFurniture = this._furnitureController.GetFurnitureByStyle(selected);
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
            this.furnitureIDComboBox.SelectedIndex = -1;
            this.furnitureStyleComboBox.SelectedIndex = -1;
            this.furnitureCategoriesComboBox.SelectedIndex = -1;
        }
    }
}
