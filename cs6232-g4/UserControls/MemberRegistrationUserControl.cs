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

        public MemberRegistrationUserControl()
        {
            InitializeComponent();
            this._memberController = new MembersController();
            this.enteredPhone = string.Empty;
            this.enteredZip = string.Empty;
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
            enteredZip = string.Empty;
            enteredPhone = string.Empty;

            try
            {
                newMember.FirstName = this.firstNameTextBox.Text;
                newMember.LastName = this.lastNameTextBox.Text;
                newMember.Address1 = this.address1TextBox.Text;
                newMember.Phone = this.phoneTextBox.Text;
                newMember.Address2 = this.address2TextBox.Text;
                newMember.City = this.cityTextBox.Text;
                newMember.State = this.stateComboBox.Text;
                enteredZip = this.zipTextBox.Text;
                enteredPhone = this.phoneTextBox.Text;

                if (ValidateData())
                {
                    this._memberController.RegisterStoreMember(newMember);
                    this.regFeedbackLabel.Text = "Customer registered successfully!";
                    this.regFeedbackLabel.ForeColor = Color.Green;
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
            if (CheckNames() && CheckAddress() && CheckGender() && CheckPhone() && CheckDOB())
            {
                return true;
            }
            return false;
        }

        private bool CheckDOB()
        {
            string strDate = string.Empty;
            strDate = this.dobDateTimePicker.Value.ToString();

            if (string.IsNullOrEmpty(strDate))
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
                this.phoneErrorLabel.Text = "Enter only numbers.";
                return false;
            }
            else if (!(Int32.TryParse(this.enteredPhone, out _)))
            {
                this.phoneErrorLabel.ForeColor = Color.Red;
                this.phoneErrorLabel.Text = "Enter only numbers.";
                return false;
            }

            this.newMember.Phone = this.enteredPhone;
            return true;
        }

        private bool CheckNames()
        {
            if (string.IsNullOrEmpty(newMember.FirstName) || (string.IsNullOrEmpty(newMember.LastName))){

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
                string.IsNullOrEmpty(newMember.State) || string.IsNullOrEmpty(enteredZip))
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

                if (string.IsNullOrEmpty(enteredZip))
                {
                    this.zipErrorLabel.ForeColor = Color.Red;
                    this.zipErrorLabel.Text = "Zipcode is required.";
                }
                else if (!Int32.TryParse(enteredZip, out _))
                {
                    this.zipErrorLabel.ForeColor = Color.Red;
                    this.zipErrorLabel.Text = "Zipcode must be numeric.";
                }
                else if (enteredZip.Length > 10)
                {
                    this.zipErrorLabel.ForeColor = Color.Red;
                    this.zipErrorLabel.Text = "Zipcode cannot be more than 10 characters.";
                }

                return false;
            }

            this.newMember.ZipCode = enteredZip;
            return true;
        }

        private bool CheckGender()
        {
            int selectedIndex = this.genderComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Object selectedItem = this.genderComboBox.SelectedItem;
                this.newMember.Gender = char.Parse(selectedItem.ToString());
                return true;
            }
            else
            {
                this.genderErrorLabel.ForeColor = Color.Red;
                this.genderErrorLabel.Text = "Gender is required.";
                return false;
            }
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
            this.stateComboBox.Text = string.Empty;
            this.zipTextBox.Text = string.Empty;
            this.genderComboBox.Text = string.Empty;
        }

        /// <summary>
        /// cancel button action
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ResetFields();
        }
    }
}
