﻿using cs6232_g4.Model;
using Members.Controller;
using Members.Model;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

/// <summary>
/// Interact between the view and the data for members to search for a specific member
/// Programmer:     Leslie
/// Date:           14 March 2024
/// Modifications:  Changed from listview to datagridview
///                 Added ability to select member from the grid to pull of update
///                 
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

        private readonly MembersController _memberController;


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
        }

        private void FindMemberButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.CheckIfMissingAllInput())
                {
                    this.ErrorLabel.Text = "You must enter one of the following options: 1) Member ID, 2) Member Phone Number, or 3) Member First and Last Name";
                }
                else if (this.MbrIDTextBox.Text != "")
                {
                    if (Int32.TryParse(this.MbrIDTextBox.Text, out MbrId))
                    {
                        MemberList = this._memberController.GetMemberByID(MbrId);
                        this.DisplayMemberMatches();
                        this.ClearTextBoxes();
                        this.ReEnableTextBoxes();
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
                        this.DisplayMemberMatches();
                        this.ClearTextBoxes();
                        this.ReEnableTextBoxes();
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
                    this.ClearTextBoxes();
                    this.ReEnableTextBoxes();
                    this.DisplayMemberMatches();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

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

        private void MbrIDTextBox_Click(object sender, EventArgs e)
        {

            this.ErrorLabel.Text = string.Empty;
            this.MbrFNameTextBox.Enabled = false;
            this.MbrLNameTextBox.Enabled = false;
            this.MbrPhoneNumTextBox.Enabled = false;
        }

        private void MbrPhoneNumTextBox_Click(object sender, EventArgs e)
        {

            this.ErrorLabel.Text = string.Empty;

            this.MbrPhoneNumTextBox.Enabled = true;
            this.MbrFNameTextBox.Enabled = false;
            this.MbrLNameTextBox.Enabled = false;
            this.MbrIDTextBox.Enabled = false;


        }

        private void MbrFNameTextBox_Click(object sender, EventArgs e)
        {
            this.MembersDataGridView.DataSource = null;
            this.ErrorLabel.Text = string.Empty;

            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MbrLNameTextBox_Click(object sender, EventArgs e)
        {
            this.MembersDataGridView.DataSource = null;
            this.ErrorLabel.Text = string.Empty;


            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MembersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                int MbrID = Int32.Parse(cellValue);
                List<Member> searchList = new List<Member>();
                searchList = this._memberController.GetMemberByID(MbrID);
                this.SelectedMember = searchList[0];
                this.SelectedMemberId = this.SelectedMember.MemberID;
            }
        }

        private void UpdateMbrButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedMember == null)
            {
                this.ErrorLabel.Text = "Please click on a row to select a member.";
            }
            else
            {
                using (Form updateMemberForm = new View.UpdateMemberForm(SelectedMemberId))
                {

                    DialogResult result = updateMemberForm.ShowDialog();

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
