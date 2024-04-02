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

                if (ValidateData())
                {
                    this._memberController.RegisterStoreMember(newMember);
                    this.regFeedbackLabel.Text = "Customer registered successfully!";
                    this.regFeedbackLabel.ForeColor = Color.Green;
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

        private bool CheckDOB()
        {
            if (!this.dobDateTimePicker.Checked)
            {
                this.dobErrorLabel.ForeColor = Color.Red;
                this.dobErrorLabel.Text = "Date of birth is required.";
                return false;
            }
            else
            {
                newMember.DateOfBirth = this.dobDateTimePicker.Value.Date;
                return true;
            }
        }

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
            this.dobDateTimePicker.Value = DateTime.Parse("2002-01-01");
        }

        /// <summary>
        /// cancel button action
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FNameErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.lNameErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.genderErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.phoneErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void address1TextBox_TextChanged(object sender, EventArgs e)
        {
            this.addr1ErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            this.cityErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.stateErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void zipTextBox_TextChanged(object sender, EventArgs e)
        {
            this.zipErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.dobErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;
        }

        public void ClearAllErrors()
        {
            this.FNameErrorLabel.Text = string.Empty;
            this.lNameErrorLabel.Text = string.Empty;
            this.addr1ErrorLabel.Text= string.Empty;
            this.cityErrorLabel.Text = string.Empty;
            this.stateErrorLabel.Text = string.Empty;
            this.zipErrorLabel.Text = string.Empty;
            this.phoneErrorLabel.Text = string.Empty;
            this.dobErrorLabel.Text = string.Empty;
            this.regFeedbackLabel.Text = string.Empty;

        }

    }
}
