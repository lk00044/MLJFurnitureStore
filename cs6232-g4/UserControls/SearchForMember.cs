
using Members.Controller;
using Members.Model;

/// <summary>
/// User Control to search for member
/// Group 4
/// Programmer: LKeller
/// Date: 03/09/24
/// </summary>
namespace SearchForMember.UserControls
{
    public partial class SearchForMember : UserControl
    {
        private string MbrFName;
        private string MbrLName;
        private int MbrId;
        private string MbrPhoneNum;
        private Member amember;

        private readonly MemberController _memberController;

        public SearchForMember()
        {
            _memberController = new MemberController();
            amember = new Member();
        }


        private void FindMemberButton_Click(object sender, EventArgs e)
        {
            if (this.MbrIDTextBox.Text != "")
            {
                MbrId = int.Parse(this.MbrIDTextBox.Text);
                amember = this._memberController.GetMemberByID(MbrId);
            }
            else if (this.MbrPhoneNumTextBox.Text != "")
            {
                
            }
            else if (this.MbrFNameTextBox.Text != "" && this.MbrLNameTextBox.Text != "")
            {
                
            }

        }

        private void DisplayMemberMatches()
        {

        }

    }
}
