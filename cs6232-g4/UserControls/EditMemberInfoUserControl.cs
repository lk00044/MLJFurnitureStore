using Members.Controller;
using Members.Model;

namespace cs6232_g4.UserControls
{
    public partial class EditMemberInfoUserControl : UserControl
    {
        private readonly MemberController _memberController;

        private List<Member> MemberList;

        public EditMemberInfoUserControl()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            MemberList = new List<Member>();
            this.ErrorLabel.Text = string.Empty;
            this.ErrorLabel.ForeColor = Color.Red;
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
                    if (Int32.TryParse(this.MbrIDTextBox.Text, out _))
                    {
                        MemberList = this._memberController.GetMemberByID(Int32.Parse(this.MbrIDTextBox.Text));
                        this.PopulateUpdateFields();
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
                        MemberList = this._memberController.GetMemberByPhone(this.MbrPhoneNumTextBox.Text.Trim());
                        this.PopulateUpdateFields();
                    }
                    else
                    {
                        this.ErrorLabel.Text = "The phone number should be numeric only, no - needed.";
                    }

                }
                else if (this.MbrFNameTextBox.Text != "" && this.MbrLNameTextBox.Text != "")
                {
                    MemberList = this._memberController.GetMemberByName(this.MbrFNameTextBox.Text, this.MbrLNameTextBox.Text);
                    this.PopulateUpdateFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void PopulateUpdateFields()
        {
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
            this.ErrorLabel.Text = String.Empty;
        }

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
    }
}
