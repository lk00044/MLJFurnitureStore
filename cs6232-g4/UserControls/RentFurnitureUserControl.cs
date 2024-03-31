using cs6232_g4.Controller;
using cs6232_g4.DAL;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cs6232_g4.UserControls
{
    public partial class RentFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly LoginController _loginController;
        private readonly MembersController _membersController;
        private readonly TransactionController _transactionController;
        private RentalTransaction rentalTransaction;
        private List<Furniture> furnitureList;
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this._loginController = new LoginController();
            this._furnitureController = new FurnitureController();
            this._transactionController = new TransactionController();
            this.furnitureList = new List<Furniture>();
            this._membersController = new MembersController();
            this.rentalTransaction = new RentalTransaction();
            this.infoMessageLabel.Text = string.Empty;
            this.dueDatePicker.MinDate = DateTime.Today.AddDays(1);
        }
        private void RentFurnitureUserControl_Load(object sender, EventArgs e)
        {
            this.PopulateAvailableFurniture();
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.Columns.Add("ID", 50);
            this.cartListView.Columns.Add("Name", 80);
            this.cartListView.Columns.Add("Quantity", 80);
            this.cartListView.Columns.Add("Daily Rate", 80);
            this.cartListView.Columns.Add("Subtotal", 80);
        }
        private void PopulateAvailableFurniture()
        {
            this.furnitureList = this._furnitureController.GetAllFurniture();
            this.availableFurnitureGridView.DataSource = furnitureList;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (IsValidItemInput(false))
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
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            if (IsValidItemInput(true))
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
            if (!this.IsTransactionInputsValid()) return;
            try
            {
                this.CreateRentalTransaction();
                this.UpdateAvailableFurnitureQuantity();
                this.CreateLineItems();
                this.CreateReceipt();
            }
            catch(Exception error)
            {
                MessageBox.Show("Failed to submit order" + Environment.NewLine + error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAvailableFurnitureQuantity()
        {
            foreach (ListViewItem item in this.cartListView.Items)
            {
                int id = int.Parse(item.SubItems[0].Text);
                int quantity = int.Parse(item.SubItems[2].Text);
                this._furnitureController.UpdateFurniture(id, quantity);
            }
            this.PopulateAvailableFurniture();
        }
        private void CreateRentalTransaction()
        {
            try
            {
                this.rentalTransaction.EmployeeId = this._loginController.GetCurrentLogin().EmployeeId;
                this.rentalTransaction.MemberId = int.Parse(this.memberIdTextBox.Text);
                this.rentalTransaction.DueDate = DateTime.Parse(this.dueDatePicker.Text);
                this.rentalTransaction.TotalAmount = decimal.Parse(this.totalCostValue.Text.Trim('$'));
                this.rentalTransaction.TransactionID = this._transactionController.CreateRentalTransaction(this.rentalTransaction);
            }
            catch (Exception error)
            {
                MessageBox.Show("Failed to create rental transaction" + Environment.NewLine + error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            DateTime dueDate = DateTime.Parse(this.dueDatePicker.Text);
            return (dueDate.Date - currentDate.Date).Days;
        }

        private void CreateReceipt()
        {
            this.infoMessageLabel.Text = "Transaction created successfully!";
            this.infoMessageLabel.ForeColor = Color.Green;
            string lineItemsInfo = "";
            foreach (RentalLineItem lineItem in this._transactionController.GetRentalLineItems(this.rentalTransaction.TransactionID))
            {
                lineItemsInfo += "    ID: " + lineItem.LineItemId + ", Name: " + lineItem.Name + ", Subtotal: $" + lineItem.Subtotal + "\n";
            }
            string receipt = "Rental Transaction ID: " + this.rentalTransaction.TransactionID + "\n"
            + "Due Date: " + this.rentalTransaction.DueDate.ToString("MM/dd/yyyy") + "\n"
            + "Total Cost: $" + this.rentalTransaction.TotalAmount + "\n"
            + "Items Info: \n"
            + lineItemsInfo;

            MessageBox.Show(receipt, "Rental Receipt");
            this.ResetFields();
        }

        private void FurnitureIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void MemberIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool IsTransactionInputsValid()
        {
            this.infoMessageLabel.ForeColor = Color.Red;
            if (this.memberIdTextBox.Text == string.Empty)
            {
                this.infoMessageLabel.Text = "Please enter a valid member id";
                return false;
            }
            if (this._membersController.GetMemberByID(int.Parse(this.memberIdTextBox.Text)).Count() == 0)
            {
                this.infoMessageLabel.Text = "Member not found!";
                return false;
            }
            if (this.cartListView.Items.Count == 0)
            {
                this.infoMessageLabel.Text = "At least one item must be added in cart!";
                return false;
            }
            return true;
        }

        private bool IsValidItemInput(bool isUpdate)
        {
            this.infoMessageLabel.ForeColor = Color.Red;
            if (this.furnitureIdTextBox.Text == string.Empty)
            {
                this.infoMessageLabel.Text = "Please enter a valid furniture id";
                return false;
            }
            if (!this.furnitureList.Exists(furniture => furniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text)))
            {
                this.infoMessageLabel.Text = "Unable to find furniture with given id";
                return false;
            }
            if (!isUpdate && this.cartListView.FindItemWithText(this.furnitureIdTextBox.Text) != null)
            {
                this.infoMessageLabel.Text = "Item is already added in cart";
                return false;
            }
            if (this.quantityTextBox.Text == string.Empty || this.quantityTextBox.Text == "0")
            {
                this.infoMessageLabel.Text = "Please enter valid quantity";
                return false;
            }
            if (int.Parse(this.quantityTextBox.Text) > this.furnitureList.Find(furniture => furniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text)).InstockQuantity)
            {
                this.infoMessageLabel.Text = "Item quantity cannot exceed the instock total";
                return false;
            }
            this.infoMessageLabel.Text = "";
            return true;
        }

        private void ResetOrderButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
        }

        public void ResetFields()
        {
            this.furnitureIdTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.memberIdTextBox.Text = string.Empty;
            this.infoMessageLabel.Text = string.Empty;
            this.cartListView.Items.Clear();
            this.totalCostValue.Text = string.Empty;
        }
    }
}
