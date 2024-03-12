using Members.Controller;
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

        private readonly MemberController _memberController;


        public SearchForMemberUserControl()
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

            if (this.CheckIfMissingAllInput())
            {
                this.ErrorLabel.Text = "You must enter one of the following options: 1) Member ID, 2) Member Phone Number, or 3) Member First and Last Name";
            }

            if (this.CheckIfMissingNamePart())
            {
                this.ErrorLabel.Text = "You must enter both the Member First and Last Name";
            }

            try
            {

                if (this.MbrIDTextBox.Text != "")
                {
                    if (Int32.TryParse(this.MbrIDTextBox.Text, out MbrId)) {
                        MemberList = this._memberController.GetMemberByID(MbrId);
                        this.DisplayMemberMatches();
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
                    }
                    else
                    {
                        this.ErrorLabel.Text = "The phone number should be numeric only, no - needed.";
                    }
                    
                }
                else if (this.MbrFNameTextBox.Text != "" && this.MbrLNameTextBox.Text != "")
                {
                    this.MbrLName = this.MbrLNameTextBox.Text;
                    this.MbrFName = this.MbrFNameTextBox.Text;

                    MemberList = this._memberController.GetMemberByName(MbrFName.Trim(), MbrLName.Trim());
                    this.DisplayMemberMatches();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }          

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

        private void MbrIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;
        }

        private void MbrPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;
        }

        private void MbrFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;
        }

        private void MbrLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MatchingMembersListView.Items.Clear();
            this.ErrorLabel.Text = string.Empty;
        }
    }
}
