﻿using Members.Controller;
using Members.Model;

namespace cs6232_g4.UserControls
{
    public partial class SearchForMemberUserControl : UserControl
    {

        private string MbrFName;
        private string MbrLName;
        private int MbrId;
        private string MbrPhoneNum;
        private List<Member> MemberList;

        private readonly MembersController _memberController;


        public SearchForMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MembersController();
            MemberList = new List<Member>();
            MbrId = 0;
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
                else if(this.CheckIfMissingNamePart())
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
            this.MbrLNameTextBox.Text= string.Empty;
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

        private void DisplayMemberMatches()
        {
            this.MatchingMembersListView.Items.Clear();

            try
            {
                if (MemberList.Count > 0)
                {
                    Member member;
                    for (int i = 0; i < MemberList.Count; i++)
                    {
                        member = MemberList[i];
                        MatchingMembersListView.Items.Add(member.MemberID.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.FirstName.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.LastName.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.Address1.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.Address2.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.City.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.State.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.ZipCode.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.Phone.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.Gender.ToString());
                        MatchingMembersListView.Items[i].SubItems.Add(member.DateOfBirth.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no members that match.");
                }
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
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;

            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }

        private void MbrLNameTextBox_Click(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;


            this.MbrPhoneNumTextBox.Enabled = false;
            this.MbrFNameTextBox.Enabled = true;
            this.MbrLNameTextBox.Enabled = true;
            this.MbrIDTextBox.Enabled = false;
        }
    }
}
