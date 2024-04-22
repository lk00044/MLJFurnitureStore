using cs6232_g4.Model;
using Members.Controller;

namespace cs6232_g4.View
{
    /// <summary>
    /// Interacts between the user and the data layer to show the return history
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ViewReturnHistoryForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the View Return History class.
        /// </summary>
        /// 

        private readonly TransactionController _transactionController;
        private List<ReturnTransaction> returns;
        private int MemberID;
        private string MemberName;
        private BindingSource transactionDALBindingSource;

        public ViewReturnHistoryForm(int mbrID, string mbrName)
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            returns = new List<ReturnTransaction>();
            this.MemberID = mbrID;
            this.MemberName = mbrName;
            transactionDALBindingSource = new BindingSource();
        }

        /// <summary>
        ///  loads the grid
        /// </summary>
        private void ViewReturnHistory_Load(object sender, EventArgs e)
        {
            this.MemberIDLabel.Text = "Member ID: " + this.MemberID.ToString();
            this.MemberNameLabel.Text = "Member Name: " + this.MemberName;
            this.ShowReturns();
            this.ReturnsDataGridView.ClearSelection(); 
        }

        /// <summary>
        ///  shows all returns by member
        /// </summary>
        private void ShowReturns()
        {
            try
            {
                this.returns = this._transactionController.GetMemberReturns(this.MemberID);
                this.transactionDALBindingSource.DataSource = this.returns;
                this.ReturnsDataGridView.DataSource = this.returns;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
