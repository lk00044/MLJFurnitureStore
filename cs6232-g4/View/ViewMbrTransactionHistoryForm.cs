
using cs6232_g4.Model;
using Furnitures.Model;
using Members.Controller;
using System.Windows.Forms;

/// <summary>
/// </summary>

namespace cs6232_g4.View
{
    public partial class ViewMbrTransactionHistoryForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewMbrTransactionHistoryForm"/> class.
        /// </summary>


        private readonly TransactionController _transactionController;
        private List<RentalTransaction> rentalTransactions;
        private int MemberID;
        private string MemberName;
        private BindingSource bindingSource1;
        private RentalLineItem selectedLineItem;
        private List<RentalLineItem> rentalLineItemList;

        public ViewMbrTransactionHistoryForm(int mbrID, string memberName)
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            rentalTransactions = new List<RentalTransaction>();
            this.selectedLineItem = new RentalLineItem();
            this.rentalLineItemList = new List<RentalLineItem>();
            this.MemberID = mbrID;
            this.MemberName = memberName;
            bindingSource1 = new BindingSource();
            this.infoMessageLabel.ForeColor = Color.Red;
        }

        private void ViewMbrTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            this.MemberIDLabel.Text = "Member ID: " + this.MemberID.ToString();
            this.MemberNameLabel.Text = "Member Name: " + this.MemberName;
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.Columns.Add("Furniture Name", 80);
            this.cartListView.Columns.Add("Quantity", 80);
            this.ShowTransactions();
            this.MemberTransactionsDataGridView.ClearSelection();
        }

        private void ShowTransactions()
        {
            try
            {
                this.rentalTransactions = this._transactionController.GetMemberTransactions(this.MemberID);
                this.bindingSource1.DataSource = this.rentalTransactions;
                this.MemberTransactionsDataGridView.DataSource = this.rentalTransactions;
                this.SetupDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void SetupDataGrid()
        {

            this.MemberTransactionsDataGridView.AutoGenerateColumns = false;
            this.MemberTransactionsDataGridView.AutoSize = true;
            this.MemberTransactionsDataGridView.Columns[0].HeaderText = "Transaction ID";
            this.MemberTransactionsDataGridView.Columns[1].HeaderText = "Transaction Date";
            this.MemberTransactionsDataGridView.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.MemberTransactionsDataGridView.Columns[2].HeaderText = "Member ID";
            this.MemberTransactionsDataGridView.Columns[3].HeaderText = "Employee ID";
            this.MemberTransactionsDataGridView.Columns[4].HeaderText = "Employee Name";
            this.MemberTransactionsDataGridView.Columns[5].HeaderText = "Line Item ID";
            this.MemberTransactionsDataGridView.Columns[6].HeaderText = "Due Date";
            this.MemberTransactionsDataGridView.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.MemberTransactionsDataGridView.Columns[7].HeaderText = "Furniture ID";
            this.MemberTransactionsDataGridView.Columns[8].HeaderText = "Furniture Name";
            this.MemberTransactionsDataGridView.Columns[9].HeaderText = "Remaining Quantity";
            this.MemberTransactionsDataGridView.Columns[10].HeaderText = "SubTotal";
            this.MemberTransactionsDataGridView.Columns[10].DefaultCellStyle.Format = "c";
            this.MemberTransactionsDataGridView.Columns[11].HeaderText = "Transaction Total";
            this.MemberTransactionsDataGridView.Columns[11].DefaultCellStyle.Format = "c";

        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberNameLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// checks whether a row is selected 
        /// </summary>
        private bool CheckRowIsSelected()
        {
            if (this.MemberTransactionsDataGridView.SelectedRows.Count == 0)
            {
                return false;
            }
            return true;
        }
        private void MemberTransactionsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.infoMessageLabel.Text = "";

            if (MemberTransactionsDataGridView.SelectedRows.Count != 1)
            {
                this.infoMessageLabel.Text = "You must select one item to add to cart.";
            }
            else
            {
                /// Get the row of data
                int selectedrowindex = MemberTransactionsDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = MemberTransactionsDataGridView.Rows[selectedrowindex];
                this.selectedLineItem.LineItemId = (int)selectedRow.Cells[5].Value;
                this.selectedLineItem.RentalTransactionId = (int)selectedRow.Cells[0].Value;
                this.selectedLineItem.Quantity = (int)selectedRow.Cells[9].Value;
                this.selectedLineItem.FurnitureId = (int)selectedRow.Cells[7].Value;
                this.selectedLineItem.Name = (string)selectedRow.Cells[8].Value;
                this.selectedLineItem.DueDate = (DateTime)selectedRow.Cells[6].Value;
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(false)) return;
            this.selectedLineItem.Quantity = int.Parse(this.quantityTextBox.Text);
            ListViewItem listViewItem = new ListViewItem(this.selectedLineItem.Name);
            this.cartListView.Items.Add(listViewItem);
            listViewItem.SubItems.Add(this.selectedLineItem.Quantity.ToString());
            this.rentalLineItemList.Add(this.selectedLineItem);
            this.selectedLineItem = new RentalLineItem();
            this.MemberTransactionsDataGridView.ClearSelection();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!IsValidInput(true)) return;
            RentalLineItem updatedItem = this.rentalLineItemList.Find(item => item.FurnitureId == this.selectedLineItem.FurnitureId);
            if (updatedItem != null)
            {
                updatedItem.Quantity = int.Parse(this.quantityTextBox.Text);
                ListViewItem listViewItem = this.cartListView.FindItemWithText(updatedItem.Name);
                listViewItem.SubItems[1].Text = updatedItem.Quantity.ToString();
            }
            else
            {
                this.infoMessageLabel.Text = "cannot update an item not in cart";
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RentalLineItem updatedItem = this.rentalLineItemList.Find(item => item.FurnitureId == this.selectedLineItem.FurnitureId);
            if (updatedItem != null)
            {
                ListViewItem listViewItem = this.cartListView.FindItemWithText(updatedItem.Name);
                this.cartListView.Items.Remove(listViewItem);
                this.rentalLineItemList.Remove(updatedItem);
            }
            else
            {
                this.infoMessageLabel.Text = "cannot remove an item not in cart";
            }
        }

        private bool IsValidInput(bool isUpdate)
        {
            this.infoMessageLabel.Text = string.Empty;
            if (this.selectedLineItem.FurnitureId == 0)
            {
                this.infoMessageLabel.Text = "You must select one item to add to cart.";
                return false;
            }
            else if (!isUpdate && this.rentalLineItemList.Find(item => item.FurnitureId == this.selectedLineItem.FurnitureId) != null)
            {
                this.infoMessageLabel.Text = "cannot add an item already in return cart";
                return false;
            }
            else if (this.quantityTextBox.Text == string.Empty || this.quantityTextBox.Text == "0" || !int.TryParse(this.quantityTextBox.Text, out _))
            {
                this.infoMessageLabel.Text = "Please enter valid quantity";
                return false;
            }
            else if (int.Parse(this.quantityTextBox.Text) > this.selectedLineItem.Quantity)
            {
                this.infoMessageLabel.Text = "returned quantity must be less or equal to rented quantity";
                return false;
            }
            return true;
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?" , "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    List<double> txnDetails = this._transactionController.CreateReturnTransaction(this.rentalLineItemList);
                    this.CreateReceipt(txnDetails[0], txnDetails[1]);
                }
                catch
                {
                    this.infoMessageLabel.Text = "failed to return items please try again later.";
                }
            }
            
        }

        /// <summary>
        /// helper constuctrs a receipt 
        /// </summary>
        private void CreateReceipt(double returnTxnId, double refund_or_fine)
        {
            this.infoMessageLabel.Text = "Items returned successfully!";
            this.infoMessageLabel.ForeColor = Color.Green;
            string lineItemsInfo = "";
            foreach (RentalLineItem lineItem in this.rentalLineItemList)
            {
                lineItemsInfo += "    Rental Txn ID: " + lineItem.RentalTransactionId + ", Item ID: " + lineItem.LineItemId + ", Name: " + lineItem.Name + "\n";
            }
            string receipt = "Return Transaction ID: " + returnTxnId + "\n"
            + "Fine or refund: " + refund_or_fine.ToString("F") + "\n"
            + "Items Info: \n"
            + lineItemsInfo;
            MessageBox.Show(receipt, "Rental Receipt");
            this.ResetFields();
        }

        public void ResetFields()
        {
            this.quantityTextBox.Text = string.Empty;
            this.infoMessageLabel.Text = string.Empty;
            this.cartListView.Items.Clear();
            this.rentalLineItemList.Clear();
            this.ShowTransactions();
        }
    }
}


