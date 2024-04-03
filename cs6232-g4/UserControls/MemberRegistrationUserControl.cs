using Members.Controller;
using Members.Model;

/// <summary>
/// User control to provide the interface for the user and to handle interaction
/// between the view and the data.
/// Author: Jonathan
/// Date:   23 March 2024
/// Modified by:    Leslie Keller
/// Date Modified:  28 March 2024
/// Modifications:  Added data validation
///                 Added date picker
///                 Revised GUI to match other tabs
///                 Added error messages to GUI for all input.
///                 
/// </summary>
/// 
namespace cs6232_g4.UserControls
{
    public partial class MemberRegistrationUserControl : UserControl
    {
        private readonly MembersController _memberController;
        Member newMember;
        string enteredZip;
        string enteredPhone;
        string enteredGender;

        public MemberRegistrationUserControl()
        {
            InitializeComponent();
            this._memberController = new MembersController();
            this.enteredPhone = string.Empty;
            this.enteredZip = string.Empty;
            this.enteredGender = string.Empty;
        }

        /// <summary>
        /// form load action
        /// </summary>
        private void MemberRegistrationUserControl_Load(object sender, EventArgs e)
        {
            this.ResetFields();
        }

        /// <summary>
        /// register button click actions
        /// </summary>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            newMember = new Member();

            try
            {
                newMember.FirstName = this.firstNameTextBox.Text;
                newMember.LastName = this.lastNameTextBox.Text;
                newMember.Address1 = this.address1TextBox.Text;
                newMember.Phone = this.phoneTextBox.Text;
                newMember.Address2 = this.address2TextBox.Text;
                newMember.City = this.cityTextBox.Text;
                newMember.State = this.stateComboBox.Text;
                enteredGender = this.genderComboBox.Text;
                enteredZip = this.zipTextBox.Text;
                enteredPhone = this.phoneTextBox.Text;
                if (!ValidateData()) return;
                if (this._memberController.RegisterStoreMember(newMember) > 0)
                {
                    MessageBox.Show("Customer registered successfully!");
                    this.ResetFields();
                }
                else
                {
                    this.regFeedbackLabel.Text = "Failed to register customer.";
                    this.regFeedbackLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// helped function to verify all data before submitting 
        /// </summary>
        /// <returns>true if all data valid and false otherwise</returns>
        private bool ValidateData()
        {
            CheckNames();
            CheckAddress();
            CheckZipCode();
            CheckPhone();
            CheckDOB();
            CheckGender();

            if (CheckNames() && CheckAddress() && CheckZipCode() && CheckGender() && CheckPhone() && CheckDOB())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// verifies the date of birth is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckDOB()
        {
            if (DateTime.Today.Year - this.dobDateTimePicker.Value.Year < 18 )
            {
                this.dobErrorLabel.ForeColor = Color.Red;
                this.dobErrorLabel.Text = "customer cannot be less than 18 years old";
                return false;
            }
            else
            {
                newMember.DateOfBirth = this.dobDateTimePicker.Value.Date;
                return true;
            }
        }

        /// <summary>
        /// verifies the phone is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckPhone()
        {
            if (string.IsNullOrEmpty(this.enteredPhone))
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Phone number is required.";
                return false;
            }

            if (!Int64.TryParse(this.enteredPhone, out _))
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Enter only numbers.";
                return false;
            }

            if (this.enteredPhone.Length != 10)
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Phone number must be 10 numbers.";
                return false;
            }

            this.newMember.Phone = this.enteredPhone;
            return true;
        }

        /// <summary>
        /// verifies the name is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckNames()
        {
            if (string.IsNullOrEmpty(newMember.FirstName) || (string.IsNullOrEmpty(newMember.LastName)))
            {

                if (string.IsNullOrEmpty(newMember.FirstName))
                {
                    this.FNameErrorLabel.ForeColor = Color.Red;
                    this.FNameErrorLabel.Text = "First name required.";
                }

                if (string.IsNullOrEmpty(newMember.LastName))
                {
                    this.lNameErrorLabel.ForeColor = Color.Red;
                    this.lNameErrorLabel.Text = "Last name required.";
                }

                return false;
            }

            return true;
        }
        /// <summary>
        /// verifies the address is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckAddress()
        {

            if (string.IsNullOrEmpty(newMember.Address1) || string.IsNullOrEmpty(newMember.City) ||
                string.IsNullOrEmpty(newMember.State))
            {
                if (string.IsNullOrEmpty(newMember.Address1))
                {
                    this.addr1ErrorLabel.ForeColor = Color.Red;
                    this.addr1ErrorLabel.Text = "Address is required.";
                }

                if (string.IsNullOrEmpty(newMember.City))
                {
                    this.cityErrorLabel.ForeColor = Color.Red;
                    this.cityErrorLabel.Text = "City is required.";
                }

                if (string.IsNullOrEmpty(newMember.State))
                {
                    this.stateErrorLabel.ForeColor = Color.Red;
                    this.stateErrorLabel.Text = "State is required.";
                }

                return false;
            }


            return true;
        }

        /// <summary>
        /// verifies the zipcode is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckZipCode()
        {
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
            if (enteredZip.Length > 9)
            {
                this.zipErrorLabel.ForeColor = Color.Red;
                this.zipErrorLabel.Text = "Zipcode cannot be more than 9 numbers.";
                return false;
            }

            if (enteredZip.Length < 5)
            {
                this.zipErrorLabel.ForeColor = Color.Red;
                this.zipErrorLabel.Text = "Zipcode cannot be less than 5 numbers.";
                return false;
            }

            this.newMember.ZipCode = enteredZip;
            return true;
        }

        /// <summary>
        /// verifies the gender is correct 
        /// </summary>
        /// <returns>true if data valid and false otherwise</returns>
        private bool CheckGender()
        {
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
                    this.newMember.Gender = 'M';
                }
                else if (this.enteredGender.Equals("Female"))
                {
                    this.newMember.Gender = 'F';
                }
                else if (this.enteredGender.Equals("Transgender"))
                {
                    this.newMember.Gender = 'T';
                }
                else if (this.enteredGender.Equals("Non-binary/non-conforming"))
                {
                    this.newMember.Gender = 'N';
                }
                else if (this.enteredGender.Equals("Prefer not to respond"))
                {
                    this.newMember.Gender = 'P';
                }

                return true;
            }
            return false;
        }


        /// <summary>
        /// helper to reset all fields
        /// </summary>
        public void ResetFields()
        {
            this.regFeedbackLabel.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.phoneTextBox.Text = string.Empty;
            this.address1TextBox.Text = string.Empty;
            this.address2TextBox.Text = string.Empty;
            this.cityTextBox.Text = string.Empty;
            this.zipTextBox.Text = string.Empty;
            this.stateComboBox.SelectedIndex = -1;            
            this.genderComboBox.SelectedIndex = -1;
            this.dobDateTimePicker.Value = DateTime.Today.AddYears(-18);
        }

        /// <summary>
        /// cancel button action
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FNameErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lNameErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.genderErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.phoneErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void Address1TextBox_TextChanged(object sender, EventArgs e)
        {
            this.addr1ErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.cityErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.stateErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            this.zipErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void DobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.dobErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        /// <summary>
        /// clears all errors fields 
        /// </summary>
        public void ClearAllErrors()
        {
            this.FNameErrorLabel.Text = string.Empty;
            this.lNameErrorLabel.Text = string.Empty;
            this.addr1ErrorLabel.Text= string.Empty;
            this.cityErrorLabel.Text = string.Empty;
            this.stateErrorLabel.Text = string.Empty;
            this.genderErrorLabel.Text = string.Empty;
            this.zipErrorLabel.Text = string.Empty;
            this.phoneErrorLabel.Text = string.Empty;
            this.dobErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

    }
}
