using Members.Controller;
using Members.Model;

/// <summary>
/// Created from Jonathan's original tab code
/// Programmer:     Jonathan
/// Modified by:    Leslie
/// Modified date:  30 March 2024
/// Modifications:  Created a new form
///                 Added data validation
///                 Added error checking
///                 Added ability to be opened from search form
///                 and to return to search form showing updated data
///                 Added Gender transformation from database char to string display
///                 
/// </summary>
namespace cs6232_g4.View
{
    public partial class UpdateMemberForm : Form
    {
        private readonly MembersController _memberController;
        private List<Member> MemberList;
        Member memberToUpdate;
        private int _memberID;
        string enteredZip;
        string enteredPhone;
        string? enteredGender;
        string enteredFName;
        string enteredLName;
        string enteredAddr1;
        string enteredCity;
        string enteredState;


        public UpdateMemberForm(int memberID)
        {
            InitializeComponent();
            this._memberController = new MembersController();
            MemberList = new List<Member>();
            memberToUpdate = new Member();
            this._memberID = memberID;
            this.InfoLabel.Text = string.Empty;
            this.InfoLabel.ForeColor = Color.Red;
            this.enteredAddr1 = string.Empty;
            this.enteredCity = string.Empty;
            this.enteredFName = string.Empty;
            this.enteredLName = string.Empty;
            this.enteredPhone = string.Empty;
            this.enteredZip = string.Empty;
            this.enteredState = string.Empty;
            this.enteredGender = string.Empty;
            this.PopulateUpdateFields();
        }

        //enter data into textboxes
        private void PopulateUpdateFields()
        {
            this.MemberList = this._memberController.GetMemberByID(this._memberID);
            this.memberToUpdate = this.MemberList[0];           
            this.InfoLabel.Text = String.Empty;
            this.MbrNewFNameTextBox.Text = this.memberToUpdate.FirstName;
            this.MbrNewLNameTextBox.Text = this.memberToUpdate.LastName;
            this.PhoneNumTextBox.Text = this.memberToUpdate.Phone;
            this.NewAddr1TextBox.Text = this.memberToUpdate.Address1;
            this.NewAddr2TextBox.Text = this.memberToUpdate.Address2;
            this.NewCityTextBox.Text = this.memberToUpdate.City;
            this.StateComboBox.Text = this.memberToUpdate.State;
            this.NewZipTextBox.Text = this.memberToUpdate.ZipCode.ToString();
            this.dobDateTimePicker.Value = (DateTime)this.memberToUpdate.DateOfBirth;
            this.SetOrigGender();           

        }

        private void SetOrigGender()
        {
            char gender = this.memberToUpdate.Gender;

            if (gender == 'M')
            {
                this.GenderComboBox.Text = "Male";
            }
            else if (gender == 'F')
            {
                this.GenderComboBox.Text = "Female";
            }
            else if (gender == 'T')
            {
                this.GenderComboBox.Text = "Transgender";
            }
            else if (gender == 'N')
            {
                this.GenderComboBox.Text = "Non-binary/non-conforming";
            }
            else if (gender == 'P')
            {
                this.GenderComboBox.Text = "Prefer not to respond";
            }
            else if (gender == 'O')
            {
                this.GenderComboBox.Text = "Prefer not to respond";
            }
        }

        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                memberToUpdate.Address2 = this.NewAddr2TextBox.Text;
                this.enteredFName = this.MbrNewFNameTextBox.Text;
                this.enteredLName = this.MbrNewLNameTextBox.Text;
                this.enteredAddr1 = this.NewAddr1TextBox.Text;
                this.enteredCity = this.NewCityTextBox.Text;
                this.enteredZip = this.NewZipTextBox.Text;
                this.enteredPhone = this.PhoneNumTextBox.Text;
                this.enteredGender = this.GenderComboBox.Text;
                this.enteredState = this.StateComboBox.Text;

                if (ValidateData())
                {
                    this._memberController.UpdateStoreMember(memberToUpdate);
                    this.ResetFields();
                    this.ResetErrorLabels();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.InfoLabel.Text = "Failed to register customer.";
                    this.InfoLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private bool CheckGender()
        {
            this.enteredGender = this.enteredGender.Trim();

            if (string.IsNullOrEmpty(this.enteredGender))
            {
                this.genderErrorLabel.ForeColor = Color.Red;
                this.genderErrorLabel.Text = "Gender is required.";
                return false;
            }
            else
            {
                if (this.enteredGender.Equals("Male"))
                {
                    this.memberToUpdate.Gender = 'M';
                }
                else if (this.enteredGender.Equals("Female"))
                {
                    this.memberToUpdate.Gender = 'F';
                }
                else if (this.enteredGender.Equals("Transgender"))
                {
                    this.memberToUpdate.Gender = 'T';
                }
                else if (this.enteredGender.Equals("Non-binary/non-conforming"))
                {
                    this.memberToUpdate.Gender = 'N';
                }
                else if (this.enteredGender.Equals("Prefer not to respond"))
                {
                    this.memberToUpdate.Gender = 'P';
                }
                return true;
            }

        }

        private bool ValidateData()
        {

            bool nameAddress = CheckNames() && CheckAddress();
            bool zipGender = CheckZipCode() && CheckGender();
            bool phoneDOB = CheckPhone() && CheckDOB();
            bool part1 = nameAddress && zipGender;
            bool part2 = zipGender && phoneDOB;
            bool done = part1 && part2;

            if (done)
            {
                return true;
            }
            return false;
        }

        private bool CheckAddress()
        {

            if (string.IsNullOrEmpty(this.enteredAddr1) || string.IsNullOrEmpty(this.enteredCity) ||
                string.IsNullOrEmpty(this.enteredState))
            {
                if (string.IsNullOrEmpty(this.enteredAddr1))
                {
                    this.addr1ErrorLabel.ForeColor = Color.Red;
                    this.addr1ErrorLabel.Text = "Address is required.";
                }

                if (string.IsNullOrEmpty(this.enteredCity))
                {
                    this.cityErrorLabel.ForeColor = Color.Red;
                    this.cityErrorLabel.Text = "City is required.";
                }

                if (string.IsNullOrEmpty(this.enteredState))
                {
                    this.stateErrorLabel.ForeColor = Color.Red;
                    this.stateErrorLabel.Text = "State is required.";
                }

                return false;
            }
            this.memberToUpdate.Address1 = this.enteredAddr1;
            this.memberToUpdate.City = this.enteredCity;
            this.memberToUpdate.State = this.StateComboBox.Text;
            return true;
        }

        private bool CheckZipCode()
        {
            int ziplength = this.enteredZip.Trim().Length;

            if (string.IsNullOrEmpty(enteredZip))
            {
                this.zipErrorLabel.ForeColor = Color.Red;
                this.zipErrorLabel.Text = "Zipcode is required.";
                return false;
            }
            if (!Int32.TryParse(enteredZip, out _))
            {
                this.zipErrorLabel.ForeColor = Color.Red;
                this.zipErrorLabel.Text = "Zipcode must be numeric.";
                return false;
            }
            if (ziplength.CompareTo(5) == 0 || ziplength.CompareTo(9) == 0)
            {
                this.memberToUpdate.ZipCode = enteredZip;
                return true;
            } 
            else
            {
                this.zipErrorLabel.ForeColor = Color.Red;
                this.zipErrorLabel.Text = "Zipcode must be 5 or 9 numbers.";
                return false;
            }

        }

        private bool CheckNames()
        {
            // if data deleted
            if (string.IsNullOrEmpty(this.enteredFName) || (string.IsNullOrEmpty(this.enteredLName)))
            {

                if (string.IsNullOrEmpty(this.enteredFName))
                {
                    this.fnameErrorLabel.ForeColor = Color.Red;
                    this.fnameErrorLabel.Text = "First name required.";
                }

                if (string.IsNullOrEmpty(this.enteredLName))
                {
                    this.lNameErrorLabel.ForeColor = Color.Red;
                    this.lNameErrorLabel.Text = "Last name required.";
                }
                return false;
            }

            this.memberToUpdate.FirstName = this.enteredFName;
            this.memberToUpdate.LastName = this.enteredLName;
            return true;
        }

        private bool CheckDOB()
        {
            // if deleted dob
            if (!this.dobDateTimePicker.Checked)
            {
                this.dobErrorLabel.ForeColor = Color.Red;
                this.dobErrorLabel.Text = "Date of birth is required.";
                return false;
            }
            else
            {
                this.memberToUpdate.DateOfBirth = this.dobDateTimePicker.Value.Date;
                return true;
            }
        }

        private bool CheckPhone()
        {
            //if it's deleted
            if (string.IsNullOrEmpty(this.enteredPhone))
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Phone number is required.";
                return false;
            }
            else
            {
                this.enteredPhone = this.PhoneNumTextBox.Text;
            }
            //if not numeric
            if (!Int64.TryParse(this.enteredPhone, out _))
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Enter only numbers.";
                return false;
            }
            //if too long
            if (this.enteredPhone.Length != 10)
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Phone number must be 10 numbers.";
                return false;
            }

            this.memberToUpdate.Phone = this.enteredPhone;

            return true;
        }

        /// <summary>
        /// helper to reset all fields
        /// </summary>
        private void ResetFields()
        {
            this.InfoLabel.Text = string.Empty;
            this.MbrNewFNameTextBox.Text = string.Empty;
            this.MbrNewLNameTextBox.Text = string.Empty;
            this.PhoneNumTextBox.Text = string.Empty;
            this.NewAddr1TextBox.Text = string.Empty;
            this.NewAddr2TextBox.Text = string.Empty;
            this.NewCityTextBox.Text = string.Empty;
            this.NewZipTextBox.Text = string.Empty;
            this.StateComboBox.SelectedIndex = -1;
            this.GenderComboBox.SelectedIndex = -1;
            this.dobDateTimePicker.Value = DateTime.Parse("2002-01-01");
        }

        private void ResetErrorLabels()
        {
            this.InfoLabel.Text = string.Empty;
            this.lNameErrorLabel.Text = string.Empty;
            this.fnameErrorLabel.Text = string.Empty;
            this.phoneErrorLabel.Text = string.Empty;
            this.addr1ErrorLabel.Text = string.Empty;
            this.cityErrorLabel.Text = string.Empty;
            this.zipErrorLabel.Text = string.Empty;
            this.stateErrorLabel.Text = string.Empty;
            this.genderErrorLabel.Text = string.Empty;
            this.dobErrorLabel.Text = string.Empty;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.fnameErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lNameErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.genderErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.phoneErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void address1TextBox_TextChanged(object sender, EventArgs e)
        {
            this.addr1ErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.cityErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.stateErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            this.zipErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.dobErrorLabel.Text = string.Empty;
            this.InfoLabel.Text = string.Empty;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
            this.ResetErrorLabels();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
