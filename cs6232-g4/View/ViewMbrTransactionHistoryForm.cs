
using cs6232_g4.Model;
using Members.Controller;

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


        public ViewMbrTransactionHistoryForm(int mbrID, string memberName)
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            rentalTransactions = new List<RentalTransaction>();
            this.MemberID = mbrID;
            this.MemberName = memberName;
        }

        private void ViewMbrTransactionHistoryForm_Load(object sender, EventArgs e)
        {
            this.MemberIDLabel.Text = this.MemberID.ToString();
            this.MemberNameLabel.Text = this.MemberName;            
               
        }

        private void showTransactions()
        {
            try
            {
                this.rentalTransactions = this._transactionController.GetMemberTransactions(this.MemberID);
                this.MemberTransactionsDataGridView.DataSource = null;
                this.MemberTransactionsDataGridView.DataSource = rentalTransactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
