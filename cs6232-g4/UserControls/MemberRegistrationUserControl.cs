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
    public partial class MemberRegistrationUserControl : UserControl
    {
        private readonly UpdateRegistrationController _memberController;

        public MemberRegistrationUserControl()
        {
            InitializeComponent();
            this._memberController = new MembersController();
        }

        /// <summary>
        /// form load action
        /// </summary>
        private void MemberRegistrationUserControl_Load(object sender, EventArgs e)
        {
            this.ResetFields();
            this.messageLabel.Visible = true;
            this.messageLabel.Text = "";
        }

        /// <summary>
        /// register button click actions
        /// </summary>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (this.firstNameTextBox.Text == String.Empty || this.lastNameTextBox.Text == String.Empty)
            {
                this.messageLabel.Text = "please enter first and last name";
                this.messageLabel.ForeColor = Color.Red;
                return;
            }
            if (this.monthComboBox.Text == String.Empty || this.dayComboBox.Text == String.Empty || this.yearComboBox.Text == String.Empty)
            {
                this.messageLabel.Text = "please enter valid date of birth";
                this.messageLabel.ForeColor = Color.Red;
                return;
            }
            Member newMember = new Member();
            newMember.FirstName = this.firstNameTextBox.Text;
            newMember.LastName = this.lastNameTextBox.Text;
            newMember.Address1 = this.address1TextBox.Text;
            newMember.Phone = this.phoneTextBox.Text;
            newMember.Address2 = this.address2TextBox.Text;
            newMember.City = this.cityTextBox.Text;
            newMember.State = this.stateComboBox.Text;
            newMember.ZipCode = this.zipTextBox.Text;
            newMember.Gender = this.genderComboBox.Text.Length > 0 ? this.genderComboBox.Text[0] : 'O';
            newMember.DateOfBirth = DateTime.Parse(this.monthComboBox.Text + "-" + this.dayComboBox.Text + "-" + this.yearComboBox.Text);
            try
            {
                this._memberController.RegisterStoreMember(newMember);
                this.messageLabel.Text = "Customer registered successfully!";
                this.messageLabel.ForeColor = Color.Green;
            }
            catch (Exception)
            {
                this.messageLabel.Text = "Failed to register customer";
                this.messageLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// phone text change action
        /// </summary>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(this.phoneTextBox.Text, out _))
            {
                this.phoneTextBox.Text = "";
                this.messageLabel.Text = "Phone input must be 10 numbers";
                this.messageLabel.ForeColor = Color.Red;
            }
            else
            {
                this.messageLabel.Text = "";
            }
        }

        /// <summary>
        /// zipcode text change action
        /// </summary>
        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.zipTextBox.Text.Length > 10)
            {
                this.messageLabel.Text = "Zip can't be more than 10 chars";
                this.messageLabel.ForeColor = Color.Red;
            }
            else
            {
                this.messageLabel.Text = "";
            }
        }

        /// <summary>
        /// helper to reset all fields
        /// </summary>
        public void ResetFields()
        {
            this.messageLabel.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            this.phoneTextBox.Text = string.Empty;
            this.address1TextBox.Text = string.Empty;
            this.address2TextBox.Text = string.Empty;
            this.cityTextBox.Text = string.Empty;
            this.stateComboBox.Text = string.Empty;
            this.zipTextBox.Text = string.Empty;
            this.genderComboBox.Text = string.Empty;
            this.dayComboBox.Text = string.Empty;
            this.monthComboBox.Text = string.Empty;
            this.yearComboBox.Text = string.Empty;
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
