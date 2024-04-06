﻿using cs6232_g4.View;
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
/// </summary>

namespace cs6232_g4.UserControls
{
    public partial class SearchForMemberUserControl : UserControl
    {

        private string MbrFName;
        private string MbrLName;
        private int MbrId;
        private string MbrPhoneNum;
        private List<Member> MemberList;
        private Member SelectedMember;
        private int SelectedMemberId;
        private List<Member> searchList;
        private int MbrID;
        string origPhone;
        string origFName;
        string origLName;
        string MemberName;

        private readonly MembersController _memberController;
        private readonly TransactionController _transactionController;

        public SearchForMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MembersController();
            MemberList = new List<Member>();
            SelectedMember = new Member();
            MbrId = 0;
            SelectedMemberId = 0;
            MbrFName = string.Empty;
            MbrLName = string.Empty;
            MbrPhoneNum = string.Empty;
            MbrID = 0;
            this.origFName = string.Empty;
            this.origLName = string.Empty;
            this.origPhone = string.Empty;
            this.MemberName = string.Empty;
            this._transactionController = new TransactionController();
        }

        private void FindMemberButton_Click(object sender, EventArgs e)
        {
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
                            this.clearGrid();
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
                        this.MbrPhoneNum = this.MbrPhoneNumTextBox.Text;
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
                            this.clearGrid();
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
                    this.MbrLName = this.MbrLNameTextBox.Text;
                    this.MbrFName = this.MbrFNameTextBox.Text;

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
                        this.clearGrid();
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

        private bool CheckRowIsSelected()
        {
            if (this.MembersDataGridView.SelectedRows.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void ClearTextBoxes()
        {
            this.MbrIDTextBox.Text = string.Empty;
            this.MbrPhoneNumTextBox.Text = string.Empty;
            this.MbrFNameTextBox.Text = string.Empty;
            this.MbrLNameTextBox.Text = string.Empty;
        }


        private void ReEnableTextBoxes()
        {
            this.MbrIDTextBox.Enabled = true;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrPhoneNumTextBox.Enabled = true;
        }

        private bool CheckIfMissingAllInput()
        {
            return string.IsNullOrEmpty(MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text) &&
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text);
        }

        private bool CheckIfMissingNamePart()
        {
            return (string.IsNullOrEmpty(MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text)) &&
                (!string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text) ||
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && !string.IsNullOrEmpty(this.MbrFNameTextBox.Text)
                );
        }

        private void RefreshDataGrid(List<Member> MatchingMembers)
        {
            this.MembersDataGridView.DataSource = null;
            this.MembersDataGridView.DataSource = MatchingMembers;
            this.MembersDataGridView.ClearSelection();
            this.SetupGrid();
        }



        private void SetupGrid()
        {

            this.MembersDataGridView.AutoGenerateColumns = false;
            this.MembersDataGridView.AutoSize = true;
            this.MembersDataGridView.Columns[0].HeaderText = "Member ID";
            this.MembersDataGridView.Columns[1].HeaderText = "First Name";
            this.MembersDataGridView.Columns[2].HeaderText = "Last Name";
            this.MembersDataGridView.Columns[3].HeaderText = "Address 1";
            this.MembersDataGridView.Columns[4].HeaderText = "Address 2";
            this.MembersDataGridView.Columns[5].HeaderText = "City";
            this.MembersDataGridView.Columns[6].HeaderText = "State";
            this.MembersDataGridView.Columns[7].HeaderText = "Zip Code";
            this.MembersDataGridView.Columns[8].HeaderText = "Phone";
            this.MembersDataGridView.Columns[9].HeaderText = "Gender";
            this.MembersDataGridView.Columns[10].HeaderText = "Date of Birth";
            this.MembersDataGridView.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy";

        }

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
                this.MbrID = Int32.Parse(cellValue);
                this.searchList = this._memberController.GetMemberByID(MbrID);
                this.SelectedMember = searchList[0];
                this.SelectedMemberId = this.SelectedMember.MemberID;
                this.MemberName = this.SelectedMember.FirstName + " " + this.SelectedMember.LastName;
            }
        }


        private void UpdateMbrButton_Click(object sender, EventArgs e)
        {

            if (!CheckRowIsSelected())
            {
                this.ErrorLabel.Text = "You must select a row first. ";
            }
            else
            {
                this.ErrorLabel.Text = string.Empty;

                using (Form updateMemberForm = new View.UpdateMemberForm(this.MbrID))
                {
                    int mbrid = this.MbrID;

                    DialogResult result = updateMemberForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        this.Show();
                        this.MemberList = this._memberController.GetMemberByID(mbrid);
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

        private void clearGrid()
        {
            this.MembersDataGridView.Columns.Clear();
        }

        private void ViewMbrTransactionsButton_Click(object sender, EventArgs e)
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
