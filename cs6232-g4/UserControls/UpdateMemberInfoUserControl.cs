using Members.Controller;
using Members.Model;
/// <summary>
/// Interaction between the view to update a member and the data
/// Programmer:     Leslie
/// Date:           29 March 2024
/// Modification:   Moved to its own form for enhancement.
/// </summary>

namespace cs6232_g4.UserControls
{
    public partial class UpdateMemberInfoUserControl : UserControl
    {
        private readonly MembersController _memberController;
        private List<Member> MemberList;
        private int _memberID;

        public UpdateMemberInfoUserControl(int memberID)
        {
            InitializeComponent();
            this._memberController = new MembersController();
            MemberList = new List<Member>();
            this._memberID = memberID;
            this.InfoLabel.Text = string.Empty;
            this.InfoLabel.ForeColor = Color.Red;
            this.PopulateUpdateFields();
        }

        /// <summary>
        /// pipulates the fields 
        /// </summary>
        private void PopulateUpdateFields()
        {
            this.MemberList = this._memberController.GetMemberByID(this._memberID);
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

        /// <summary>
        /// action when UpdateButton is clicked 
        /// </summary>
        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            Member updatedMember = new Member();
            updatedMember = this.MemberList[0];
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
            if (this._memberController.UpdateStoreMember(updatedMember) > 0)
            {
                this.InfoLabel.ForeColor = Color.Green;
                this.InfoLabel.Text = "Member updated successfully!";
            }
            else
            {
                this.InfoLabel.ForeColor = Color.Red;
                this.InfoLabel.Text = "Member failed to update!";
            }
        }
    }
}