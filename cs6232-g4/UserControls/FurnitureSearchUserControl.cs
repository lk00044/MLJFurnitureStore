using Furnitures.Model;
using Members.Controller;

namespace cs6232_g4.UserControls
{
    /// <summary>
    /// Creates the User Control for the Search Furniture function
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    /// 
    public partial class FurnitureSearchUserControl : UserControl
    {

        private readonly FurnitureController _furnitureController;
        private List<int> _furnitureIDs;
        private List<string> _furnitureCategories;
        private List<string> _furnitureIDStyles;
        private List<Furniture> _selectedFurniture;
        private BindingSource bindingSource1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureSearchUserControl"/> class.
        /// </summary>
        public FurnitureSearchUserControl()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._furnitureIDs = new List<int>();
            this._furnitureCategories = new List<string>();
            this._furnitureIDStyles = new List<string>();
            this._selectedFurniture = new List<Furniture>();
            this.bindingSource1 = new BindingSource();
        }

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

        private void SetupGrid()
        {
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

        private void furnitureCategoriesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.furnitureCategoriesComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._selectedFurniture = this._furnitureController.GetFurnitureByCategory(selected);
                    this.ShowFurniture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void furnitureStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selected = this.furnitureStyleComboBox.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selected))
                {
                    this._selectedFurniture = this._furnitureController.GetFurnitureByStyle(selected);
                    this.ShowFurniture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void resetComboBoxes()
        {
            this.furnitureIDComboBox.SelectedIndex = -1;
            this.furnitureStyleComboBox.SelectedIndex = -1;
            this.furnitureCategoriesComboBox.SelectedIndex = -1;
        }
    }
}
