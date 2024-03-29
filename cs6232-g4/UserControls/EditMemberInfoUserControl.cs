using Members.Controller;
using Members.Model;

namespace cs6232_g4.UserControls
{
    public partial class EditMemberInfoUserControl : UserControl
    {
        private readonly MembersController _memberController;

        private List<Member> MemberList;

        public EditMemberInfoUserControl()
        {
            InitializeComponent();
            this._memberController = new MembersController();
            MemberList = new List<Member>();
            this.InfoLabel.Text = string.Empty;
            this.InfoLabel.ForeColor = Color.Red;
        }



        private void PopulateUpdateFields()
        {
            this.InfoLabel.Text = String.Empty;
            this.MbrNewFNameTextBox.Text = MemberList[0].FirstName;
            this.MbrNewLNameTextBox.Text = MemberList[0].LastName;
            this.MbrNewPhoneNumTextBox.Text = MemberList[0].Phone;
            this.NewAddr1TextBox.Text = MemberList[0].Address1;
            this.NewAddr2TextBox.Text = MemberList[0].Address2;
            this.NewCityTextBox.Text = MemberList[0].City;
            this.NewDOBTextBox.Text = MemberList[0].DateOfBirth.ToString();
            this.NewStateComboBox.Text = MemberList[0].State;
            this.NewZipTextBox.Text = MemberList[0].ZipCode.ToString();
            this.GenderComboBox.Text = MemberList[0].Gender.ToString();
        }

      /*
      private bool CheckIfMissingAllInput()
        {
            return string.IsNullOrEmpty(this.MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text) &&
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text);
        }

        private bool CheckIfMissingNamePart()
        {
            return (string.IsNullOrEmpty(this.MbrIDTextBox.Text) && string.IsNullOrEmpty(this.MbrPhoneNumTextBox.Text)) &&
                (!string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && string.IsNullOrEmpty(this.MbrFNameTextBox.Text) ||
                string.IsNullOrEmpty(this.MbrLNameTextBox.Text) && !string.IsNullOrEmpty(this.MbrFNameTextBox.Text)
                );
        }

        */
        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            Member updatedMember = MemberList[0];
            updatedMember.FirstName = this.MbrNewFNameTextBox.Text;
            updatedMember.LastName = this.MbrNewLNameTextBox.Text;
            updatedMember.Address1 = this.NewAddr1TextBox.Text;
            updatedMember.Address2 = this.NewAddr2TextBox.Text;
            updatedMember.Phone = this.MbrNewPhoneNumTextBox.Text;
            updatedMember.State = this.NewStateComboBox.Text;
            updatedMember.DateOfBirth = DateTime.Parse(this.NewDOBTextBox.Text);
            updatedMember.Gender = this.GenderComboBox.Text[0];
            updatedMember.City = this.NewCityTextBox.Text;
            updatedMember.ZipCode = this.NewZipTextBox.Text;
            this._memberController.UpdateStoreMember(updatedMember);
            this.InfoLabel.ForeColor = Color.Green;
            this.InfoLabel.Text = "Member updated successfully!";
        }
    }
}
