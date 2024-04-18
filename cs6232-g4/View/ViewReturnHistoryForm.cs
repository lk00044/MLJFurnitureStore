using cs6232_g4.Model;
using Furnitures.Model;
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
            transactionDALBindingSource = new BindingSource();
        }

        private void ViewReturnHistory_Load(object sender, EventArgs e)
        {
            this.MemberIDLabel.Text = "Member ID: " + this.MemberID.ToString();
            this.MemberNameLabel.Text = "Member Name: " + this.MemberName;
            this.ShowReturns();
            this.ReturnsDataGridView.ClearSelection(); 
        }

        private void ShowReturns()
        {
            try
            {
                this.returns = this._transactionController.GetMemberReturns(this.MemberID);
                this.transactionDALBindingSource.DataSource = this.returns;
                this.ReturnsDataGridView.DataSource = this.returns;
                this.SetupDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void SetupDataGrid()
        {

            this.ReturnsDataGridView.AutoGenerateColumns = false;
            this.ReturnsDataGridView.AutoSize = true;
            this.ReturnsDataGridView.Columns[0].HeaderText = "Return Transaction ID";
            this.ReturnsDataGridView.Columns[1].HeaderText = "Return Transaction Date";
            this.ReturnsDataGridView.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.ReturnsDataGridView.Columns[2].HeaderText = "Member ID";
            this.ReturnsDataGridView.Columns[3].HeaderText = "Employee ID";
            this.ReturnsDataGridView.Columns[4].HeaderText = "Employee Name";
            this.ReturnsDataGridView.Columns[5].HeaderText = "Line Item ID";
            this.ReturnsDataGridView.Columns[7].HeaderText = "Furniture ID";
            this.ReturnsDataGridView.Columns[8].HeaderText = "Furniture Name";

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
