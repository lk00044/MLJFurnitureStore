using Furnitures.Model;
using Members.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            this.cartListView.Columns.Add("ID", 50);
            this.cartListView.Columns.Add("Name", 50);
            this.cartListView.Columns.Add("Quantity", 50);
            this.cartListView.Columns.Add("Daily Rate", 50);
        }
        private void PopulateAvailableFurniture()
        {
            this.furnitureList = this._furnitureController.GetAllFurniture();
            this.availableFurnitureGridView.DataSource = furnitureList;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Furniture addedFurniture = this.furnitureList.Find(furniture => furniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text));
            ListViewItem listViewItem = new ListViewItem(addedFurniture.FurnitureId.ToString());
            this.cartListView.Items.Add(listViewItem);
            listViewItem.SubItems.Add(addedFurniture.Name);
            listViewItem.SubItems.Add(this.quantityTextBox.Text);
            listViewItem.SubItems.Add("$" + addedFurniture.DailyRentalRate.ToString());
            this.totalCostValue.Text = "$" + this.CalculateTotalCost().ToString("F");
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            this.CalculateTotalCost();
            Furniture addedFurniture = this.furnitureList.Find(furniture => furniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text));
            ListViewItem listViewItem = this.cartListView.FindItemWithText(this.furnitureIdTextBox.Text);
            if(this.quantityTextBox.Text == "0")
            {
                this.cartListView.Items.Remove(listViewItem);
            }
            else
            {
                listViewItem.SubItems[2].Text = this.quantityTextBox.Text;
            }
            this.totalCostValue.Text = "$" + this.CalculateTotalCost().ToString("F");
        }

        private double CalculateTotalCost()
        {
            DateTime currentDate = DateTime.Now;
            DateTime dueDate = DateTime.Parse(this.monthComboBox.Text + "/" + this.dayComboBox.Text + "/" + this.yearComboBox.Text, new CultureInfo("en-CA"));
            int totalDays = (dueDate.Date - currentDate.Date).Days;
            double totalCost = 0;
            foreach (ListViewItem item in this.cartListView.Items)
            {
                double dailyPrice = double.Parse(item.SubItems[3].Text.Trim('$'));
                int quantity = int.Parse(item.SubItems[2].Text);
                totalCost += quantity * dailyPrice * totalDays;
            }
            return totalCost;
        }
    }
}
