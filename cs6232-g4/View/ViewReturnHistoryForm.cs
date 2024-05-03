using cs6232_g4.Model;
using Furniture.Model;
using Members.Controller;
using System.Windows.Forms;

namespace cs6232_g4.View
{
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
        private ReturnLineItem selectedLineItem;
        private BindingSource transactionDALBindingSource;
        private List<ReturnLineItem> returnLineItemList;

        public ViewReturnHistoryForm(int mbrID, string mbrName)
        {
            InitializeComponent();
            _transactionController = new TransactionController();
            returns = new List<ReturnTransaction>();
            this.returnLineItemList = new List<ReturnLineItem>();
            this.MemberID = mbrID;
            this.MemberName = mbrName;
            this.selectedLineItem = new ReturnLineItem();
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
