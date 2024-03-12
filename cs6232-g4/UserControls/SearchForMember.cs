using Members.Controller;
using Members.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs6232_g4.UserControls
{
    public partial class SearchForMember : UserControl
    {

        private string MbrFName;
        private string MbrLName;
        private int MbrId;
        private string MbrPhoneNum;
        private List<Member> MemberList;

        private readonly MemberController _memberController;


        public SearchForMember()
        {
            InitializeComponent();
            _memberController = new MemberController();
            MemberList = new List<Member>();
            MbrId = 0;
            MbrFName = string.Empty;
            MbrLName = string.Empty;
            MbrPhoneNum = string.Empty;
        }

        private void FindMemberButton_Click(object sender, EventArgs e)
        {
            if (this.MbrIDTextBox.Text != "")
            {
                MbrId = int.Parse(this.MbrIDTextBox.Text);
                MemberList = this._memberController.GetMemberByID(MbrId);
                this.DisplayMemberMatches();
            }
            else if (this.MbrPhoneNumTextBox.Text != "")
            {
                this.MbrPhoneNum = this.MbrPhoneNumTextBox.Text;
                MemberList = this._memberController.GetMemberByPhone(MbrPhoneNum.Trim());
                this.DisplayMemberMatches();
            }
            else if (this.MbrFNameTextBox.Text != "" && this.MbrLNameTextBox.Text != "")
            {
                this.MbrLName = this.MbrLNameTextBox.Text;
                this.MbrFName = this.MbrFNameTextBox.Text;

                MemberList = this._memberController.GetMemberByName(MbrFName.Trim(), MbrLName.Trim());
                this.DisplayMemberMatches();
            }

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

        private void MbrIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
        }

        private void MbrPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
        }

        private void MbrFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
        }

        private void MbrLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
        }
    }
}
