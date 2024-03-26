using Furnitures.Model;
using Members.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs6232_g4.UserControls
{
    public partial class RentFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly TransactionController _transactionController;
        private List<Furniture> furnitureList;
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._transactionController = new TransactionController();
            this.furnitureList = new List<Furniture>();
        }
        private void RentFurnitureUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateAvailableFurniture();
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.Columns.Add("Name", 100);
            this.cartListView.Columns.Add("Quantity", 100);
            this.cartListView.Columns.Add("Daily Rate", 100);
        }
        private void PopulateAvailableFurniture()
        {
            this.furnitureList = this._furnitureController.GetAllFurniture();
            this.availableFurnitureGridView.DataSource = furnitureList;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Furniture addedFurniture = this.furnitureList.Find(furniture => furniture.FurnitureId == Int32.Parse(this.furnitureIdTextBox.Text));
            ListViewItem listViewItem = new ListViewItem(addedFurniture.Name);
            this.cartListView.Items.Add(listViewItem);
            listViewItem.SubItems.Add(this.quantityTextBox.Text);
            listViewItem.SubItems.Add("$" + addedFurniture.DailyRentalRate.ToString());
        }
    }
}
