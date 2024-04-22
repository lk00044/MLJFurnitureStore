using cs6232_g4.Controller;
using cs6232_g4.Model;
using Furnitures.Model;
using Members.Controller;

namespace cs6232_g4.UserControls
{
    /// <summary>
    /// Creates the view to interact between the data layer and the user
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class RentFurnitureUserControl : UserControl
    {
        private readonly FurnitureController _furnitureController;
        private readonly LoginController _loginController;
        private readonly MembersController _membersController;
        private readonly TransactionController _transactionController;
        private RentalTransaction rentalTransaction;
        private List<Furniture> furnitureList;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentFurnitureUserControl"/> class.
        /// </summary>
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

        /// <summary>
        /// populates the available furniture section 
        /// </summary>
        private void PopulateAvailableFurniture()
        {
            this.furnitureList = this._furnitureController.GetAllFurniture();
            this.availableFurnitureGridView.DataSource = furnitureList;
        }

        /// <summary>
        /// actions after add item button is clicked 
        /// </summary>
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
                this.ClearTextBoxes();
            }
        }

        /// <summary>
        /// Clears the text boxes.
        /// Added: Leslie
        /// </summary>
        private void ClearTextBoxes()
        {
            this.quantityTextBox.Text = string.Empty;
            this.furnitureIdTextBox.Text = string.Empty;
        }

        /// <summary>
        /// update item click 
        /// </summary>
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
                    // added so it won't change quantity for whatever is in the list - must be the same furniture id - Leslie
                    if (addedFurniture.FurnitureId == int.Parse(this.furnitureIdTextBox.Text))
                    {
                        listViewItem.SubItems[2].Text = this.quantityTextBox.Text;
                    }
                    else
                    {
                        this.infoMessageLabel.Text = "You can only update furniture with the same Furniture ID. ";
                    }
                    
                }
                this.UpdateCostValues();
            }

        }

        /// <summary>
        /// updates the values of the cost labels 
        /// </summary>
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

        /// <summary>
        /// actions when submit order button is clicked 
        /// </summary>
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
            catch (Exception error)
            {
                MessageBox.Show("Failed to submit order" + Environment.NewLine + error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// updates the quantity of the furniture when submit an order 
        /// </summary>
        private void UpdateAvailableFurnitureQuantity()
        {
            foreach (ListViewItem item in this.cartListView.Items)
            {
                int id = int.Parse(item.SubItems[0].Text);
                int quantity = int.Parse(item.SubItems[2].Text);
                if (this._furnitureController.UpdateFurniture(id, quantity) == 0)
                {
                    MessageBox.Show("Failed to update furniture" + Environment.NewLine + "Failed to update quantity for FurnitureId= " + id, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                };
            }
            this.PopulateAvailableFurniture();
        }

        /// <summary>
        /// creates the rental transaction in the database 
        /// </summary>
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

        /// <summary>
        /// creates the lines items in the database 
        /// </summary>
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

        /// <summary>
        /// helper gets the total days from duedate 
        /// </summary>
        private int GetTotalDays()
        {
            DateTime currentDate = DateTime.Now;
            DateTime dueDate = DateTime.Parse(this.dueDatePicker.Text);
            return (dueDate.Date - currentDate.Date).Days;
        }

        /// <summary>
        /// helper constuctrs a receipt 
        /// </summary>
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

        /// <summary>
        /// checks the transaction inputs are valid to make a good transaction 
        /// </summary>
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

        /// <summary>
        /// checks the line item inputs good for db update 
        /// </summary>
        private bool IsValidItemInput(bool isUpdate)
        {

            string furnitureId = this.furnitureIdTextBox.Text;

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

            // Updated as it will find a match for the number if it's the id or the qty. Leslie
            // Orig: if (isUpdate && this.cartListView.FindItemWithText(this.furnitureIdTextBox.Text) == null)

            if (!isUpdate && isItemInCart(furnitureId))
            {
                this.infoMessageLabel.Text = "Item is already added in cart";
                return false;
            }

             if (isUpdate && this.cartListView.FindItemWithText(this.furnitureIdTextBox.Text) == null)
            {
                this.infoMessageLabel.Text = "Cannot update item before it's added to cart";
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

        // Checks to see if item already in cart
        private bool isItemInCart(string furnitureID)
        {
            int i = 0;
            while (i < cartListView.Items.Count)
            {
                if (furnitureID.Equals(cartListView.Items[i].SubItems[0].Text.ToString()))
                {
                    return true;
                }
                i++;
            }
            return false;
        }


        private void ResetOrderButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
        }

        /// <summary>
        /// resets the fields 
        /// </summary>
        public void ResetFields()
        {
            this.furnitureIdTextBox.Text = string.Empty;
            this.quantityTextBox.Text = string.Empty;
            this.memberIdTextBox.Text = string.Empty;
            this.infoMessageLabel.Text = string.Empty;
            this.cartListView.Items.Clear();
            this.totalCostValue.Text = string.Empty;
            this.PopulateAvailableFurniture();
        }

        /// <summary>
        /// Handles the Click event of the RemoveButton control.
        /// Added: Leslie
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (this.cartListView.SelectedItems.Count == 1)
            {
                ListViewItem listViewItem = this.cartListView.SelectedItems[0];
                this.cartListView.Items.Remove(listViewItem);
                this.UpdateCostValues();
                this.PopulateAvailableFurniture();             
            }
            
        }
    }
}
