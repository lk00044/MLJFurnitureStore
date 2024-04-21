using cs6232_g4.View;
using Members.Controller;
using Members.Model;

/// <summary>
/// Interact between the view and the data for members to search for a specific member
/// Programmer:     Leslie
/// Date:           14 March 2024
/// Modifications:  Changed from listview to datagridview
///                 Added ability to select member from the grid to pull of update
///                 Added new form to make updates
///                 Added results back to this form
///                 Added data validation and error checking
/// Modified by:    Leslie
/// Modified on:    29 March 2024
/// Modification:   updated showing memberID
/// Modified by:    Leslie
/// Modified on:    19 April 2024
/// </summary>

namespace cs6232_g4.UserControls
{
    /// <summary>
    /// Creates the User Control for the app
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchForMemberUserControl : UserControl
    {

        private List<Member> MemberList;
        private Member SelectedMember;
        private int SelectedMemberId;
        private List<Member> searchList;
        private string MemberName;
        private int MbrId;
        private readonly MembersController _memberController;
        private readonly TransactionController _transactionController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchForMemberUserControl"/> class.
        /// </summary>
        public SearchForMemberUserControl()
        {
            InitializeComponent();
            this._transactionController = new TransactionController();
            _memberController = new MembersController();
            MemberList = new List<Member>();
            SelectedMember = new Member();
            MbrId = 0;
            SelectedMemberId = 0;
            this.MemberName = string.Empty;
            this.MbrFNameTextBox.Select();
        }

        /// <summary>
        /// actions when the find member button is clicked 
        /// </summary>
        private void FindMemberButton_Click(object sender, EventArgs e)
        {
            string MbrFName = string.Empty; 
            string MbrLName = string.Empty;
            string MbrPhoneNum = string.Empty;
            int MbrId = 0;

            try
            {
                this.ErrorLabel.Text = string.Empty;

                if (this.CheckIfMissingAllInput())
                {
                    this.ErrorLabel.Text = "You must enter one of the following options: 1) Member ID, 2) Member Phone Number, or 3) Member First and Last Name";
                }
                else if (this.MbrIDTextBox.Text != "")
                {
                    if (Int32.TryParse(this.MbrIDTextBox.Text, out MbrId))
                    {
                        MemberList = this._memberController.GetMemberByID(MbrId);

                        if (MemberList.Count > 0)
                        {
                            this.DisplayMemberMatches();
                            this.ClearTextBoxes();
                            this.ReEnableTextBoxes();
                        }
                        else
                        {
                            this.ErrorLabel.Text = "No members with that ID.";
                            this.ClearGrid();
                            this.ClearTextBoxes();
                            this.ReEnableTextBoxes();
                        }
                    }
                    else
                    {
                        this.ErrorLabel.Text = "Member ID must be numberic.";
                    }

                }
                else if (this.MbrPhoneNumTextBox.Text != "")
                {
                    if (Int64.TryParse(this.MbrPhoneNumTextBox.Text, out _))
                    {
                        MbrPhoneNum = this.MbrPhoneNumTextBox.Text;
                        MemberList = this._memberController.GetMemberByPhone(MbrPhoneNum.Trim());

                        if (MemberList.Count > 0)
                        {
                            this.DisplayMemberMatches();
                            this.ClearTextBoxes();
                            this.ReEnableTextBoxes();
                        }
                        else
                        {
                            this.ErrorLabel.Text = "No members with that number.";
                            this.ClearGrid();
                            this.ClearTextBoxes();
                            this.ReEnableTextBoxes();
                        }
                    }
                    else
                    {
                        this.ErrorLabel.Text = "The phone number should be numeric only, no - needed.";
                    }

                }
                else if (this.CheckIfMissingNamePart())
                {
                    this.ErrorLabel.Text = "You must enter both the Member's First and Last Name";
                }
                else if (this.MbrFNameTextBox.Text != "" && this.MbrLNameTextBox.Text != "")
                {
                    MbrLName = this.MbrLNameTextBox.Text;
                    MbrFName = this.MbrFNameTextBox.Text;

                    MemberList = this._memberController.GetMemberByName(MbrFName.Trim(), MbrLName.Trim());

                    if (MemberList.Count > 0)
                    {
                        this.DisplayMemberMatches();
                        this.ClearTextBoxes();
                        this.ReEnableTextBoxes();
                    }
                    else
                    {
                        this.ErrorLabel.Text = "No members with that name.";
                        this.ClearGrid();
                        this.ClearTextBoxes();
                        this.ReEnableTextBoxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// checks whether a row is selected 
        /// </summary>
        private bool CheckRowIsSelected()
        {
            if (this.MembersDataGridView.SelectedRows.Count == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clears the errors.
        /// </summary>
        public void ClearErrors()
        {
            this.ErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// clears the text boxes 
        /// </summary>
        public void ClearTextBoxes()
        {
            this.MbrIDTextBox.Text = string.Empty;
            this.MbrPhoneNumTextBox.Text = string.Empty;
            this.MbrFNameTextBox.Text = string.Empty;
            this.MbrLNameTextBox.Text = string.Empty;
        }

        /// <summary>
        /// reenables the text boxes 
        /// </summary>
        private void ReEnableTextBoxes()
        {
            this.MbrIDTextBox.Enabled = true;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrPhoneNumTextBox.Enabled = true;
        }

        /// <summary>
        /// checks whether any inputs is missing 
        /// </summary>
        private bool CheckIfMissingAllInput()
        {
            return string.IsNullOrEmpty(MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text) &&
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text);
        }

        /// <summary>
        /// checks is the name is missing 
        /// </summary>
        private bool CheckIfMissingNamePart()
        {
            return (string.IsNullOrEmpty(MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text)) &&
                (!string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text) ||
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && !string.IsNullOrEmpty(this.MbrFNameTextBox.Text)
                );
        }

        /// <summary>
        /// repopulate the grid 
        /// </summary>
        private void RefreshDataGrid(List<Member> MatchingMembers)
        {
            this.MembersDataGridView.DataSource = null;
            this.MembersDataGridView.DataSource = MatchingMembers;
            this.MembersDataGridView.Columns["MemberID"].Visible = false;
            this.MembersDataGridView.ClearSelection();
        }

        /// <summary>
        /// display the matches 
        /// </summary>
        private void DisplayMemberMatches()
        {
            try
            {
                this.RefreshDataGrid(MemberList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void MbrIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MbrFNameTextBox.Enabled = false;
            this.MbrLNameTextBox.Enabled = false;
            this.MbrPhoneNumTextBox.Enabled = false;
        }

        private void MbrPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MbrPhoneNumTextBox.Enabled = true;
            this.MbrFNameTextBox.Enabled = false;
            this.MbrLNameTextBox.Enabled = false;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MbrFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MbrLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MembersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int MbrID = 0;

            this.ErrorLabel.Text = "";

            if (MembersDataGridView.SelectedRows.Count > 1)
            {
                this.ErrorLabel.Text = "Please only select one member.";
            }
            else if (MembersDataGridView.SelectedRows.Count < 0)
            {
                this.ErrorLabel.Text = "You can only select one member.";
            }
            else if (MembersDataGridView.SelectedRows.Count == 1)
            {
                /// Get the row of data
                int selectedrowindex = MembersDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = MembersDataGridView.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                MbrID = Int32.Parse(cellValue);
                this.searchList = this._memberController.GetMemberByID(MbrID);
                this.SelectedMember = searchList[0];
                this.SelectedMemberId = this.SelectedMember.MemberID;
                this.MemberName = this.SelectedMember.FirstName + " " + this.SelectedMember.LastName;   
            }
        }

        /// <summary>
        /// actions when the button is clicked 
        /// </summary>
        private void UpdateMbrButton_Click(object sender, EventArgs e)
        {

            if (!CheckRowIsSelected())
            {
                this.ErrorLabel.Text = "You must select a row first. ";
            }
            else
            {
                this.ErrorLabel.Text = string.Empty;

                using (Form updateMemberForm = new View.UpdateMemberForm(SelectedMemberId))
                {

                    DialogResult result = updateMemberForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.Show();
                        MemberList = this._memberController.GetMemberByID(MbrId);
                        this.DisplayMemberMatches();
                        this.ErrorLabel.Text = "Member updated.";

                    }
                    else if (result == DialogResult.Cancel)
                    {
                        this.ErrorLabel.Text = "Update cancelled.";
                    }
                }
            }
        }

        /// <summary>
        /// clears the grid 
        /// </summary>
        public void ClearGrid()
        {
            this.MembersDataGridView.Columns.Clear();
        }

        private void ViewTransactionsButton_Click(object sender, EventArgs e)
        {
            if (!CheckRowIsSelected())
            {
                this.ErrorLabel.Text = "You must select a row first. ";
            }
            else if (!this._transactionController.VerifyMemberTransactionavailable(this.SelectedMemberId))
            {
                this.ErrorLabel.Text = "No transactions for this member id.";
            }
            else
            {
                this.ErrorLabel.Text = string.Empty;

                using (ViewMbrTransactionHistoryForm viewMbrTransHistory = new ViewMbrTransactionHistoryForm(this.SelectedMemberId, this.MemberName))
                {
                    DialogResult result = viewMbrTransHistory.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }
            }
        }
    }
}
