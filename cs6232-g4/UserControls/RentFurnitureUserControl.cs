using cs6232_g4.Model;
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
        private RentalTransaction rentalTransaction;
        private List<Furniture> furnitureList;
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this._transactionController = new TransactionController();
            this.furnitureList = new List<Furniture>();
            this.rentalTransaction = new RentalTransaction();
        }
        private void RentFurnitureUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateAvailableFurniture();
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.Columns.Add("ID", 50);
            this.cartListView.Columns.Add("Name", 50);
            this.cartListView.Columns.Add("Quantity", 50);
            this.cartListView.Columns.Add("Daily Rate", 50);
            this.cartListView.Columns.Add("Subtotal", 50);
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
            listViewItem.SubItems.Add("$" + "0.00");
            this.UpdateCostValues();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            this.UpdateCostValues();
            Furniture addedFurniture = this.furnitureList.Find(furniture => furniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text));
            ListViewItem listViewItem = this.cartListView.FindItemWithText(this.furnitureIdTextBox.Text);
            if (this.quantityTextBox.Text == "0")
            {
                this.cartListView.Items.Remove(listViewItem);
            }
            else
            {
                listViewItem.SubItems[2].Text = this.quantityTextBox.Text;
            }
            this.UpdateCostValues();
        }

        private void UpdateCostValues()
        {

            double totalCost = 0;
            foreach (ListViewItem item in this.cartListView.Items)
            {
                double dailyPrice = double.Parse(item.SubItems[3].Text.Trim('$'));
                int quantity = int.Parse(item.SubItems[2].Text);
                double subtotal = quantity * dailyPrice * this.GetTotalDays();
                item.SubItems[4].Text = "$" + subtotal.ToString("F");
                totalCost += quantity * dailyPrice * this.GetTotalDays();
            }
            this.totalCostValue.Text = "$" + totalCost.ToString("F");
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            this.CreateRentalTransaction();
            this.CreateLineItems();
        }

        private void CreateRentalTransaction()
        {
            this.rentalTransaction.EmployeeId = int.Parse(this.employeeIdTextBox.Text);
            this.rentalTransaction.MemberId = int.Parse(this.memberIdTextBox.Text);
            this.rentalTransaction.DueDate = DateTime.Parse(this.monthComboBox.Text + "/" + this.dayComboBox.Text + "/" + this.yearComboBox.Text, new CultureInfo("en-CA"));
            this.rentalTransaction.TotalAmount = decimal.Parse(this.totalCostValue.Text.Trim('$'));
            this.rentalTransaction.TransactionID = this._transactionController.CreateRentalTransaction(this.rentalTransaction);
        }

        private void CreateLineItems()
        {

            foreach (ListViewItem item in this.cartListView.Items)
            {
                RentalLineItem lineItem = new RentalLineItem();
                lineItem.RentalTransactionId = this.rentalTransaction.TransactionID;
                lineItem.FurnitureId = int.Parse(item.SubItems[0].Text);
                lineItem.Quantity = int.Parse(item.SubItems[2].Text);
                lineItem.Subtotal = decimal.Parse(item.SubItems[4].Text.Trim('$'));
                this._transactionController.CreateRentalLineItem(lineItem);
            }
        }

        private int GetTotalDays()
        {
            DateTime currentDate = DateTime.Now;
            DateTime dueDate = DateTime.Parse(this.monthComboBox.Text + "/" + this.dayComboBox.Text + "/" + this.yearComboBox.Text, new CultureInfo("en-CA"));
            return (dueDate.Date - currentDate.Date).Days;
        }
    }
}
