
using cs6232_g4.Model;
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

        public ViewMbrTransactionHistoryForm(int mbrID, string memberName)
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            rentalTransactions = new List<RentalTransaction>();
            this.MemberID = mbrID;
            this.MemberName = memberName;
            bindingSource1 = new BindingSource();
        }

        private void ViewMbrTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            this.MemberIDLabel.Text = "Member ID: " + this.MemberID.ToString();
            this.MemberNameLabel.Text = "Member Name: " + this.MemberName;
            this.ShowTransactions();
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
            this.MemberTransactionsDataGridView.Columns[7].HeaderText = "Furniture Name";
            this.MemberTransactionsDataGridView.Columns[8].HeaderText = "Quantity";
            this.MemberTransactionsDataGridView.Columns[9].HeaderText = "SubTotal";
            this.MemberTransactionsDataGridView.Columns[9].DefaultCellStyle.Format = "c";
            this.MemberTransactionsDataGridView.Columns[10].HeaderText = "Transaction Total";
            this.MemberTransactionsDataGridView.Columns[10].DefaultCellStyle.Format = "c"; ;

        }
    

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


