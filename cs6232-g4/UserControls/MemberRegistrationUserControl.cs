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
        private readonly MemberController _memberController;

        public MemberRegistrationUserControl()
        {
            InitializeComponent();
            this._memberController = new MemberController();
        }

        private void MemberRegistrationUserControl_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Member newMember = new Member();
            newMember.FirstName = this.firstNameTextBox.Text;
            newMember.LastName = this.lastNameTextBox.Text;
            newMember.Address1 = this.address1TextBox.Text;
            newMember.Phone = this.phoneTextBox.Text;
            newMember.Address2 = this.address2TextBox.Text;
            newMember.City = this.cityTextBox.Text;
            newMember.State = this.stateComboBox.Text;
            newMember.ZipCode = this.zipTextBox.Text;
            newMember.Gender = this.genderComboBox.Text[0];
            newMember.DateOfBirth = DateTime.Parse(this.monthComboBox.Text + "-" + this.dayComboBox.Text + "-"+ this.yearComboBox.Text);

            this._memberController.RegisterStoreMember(newMember);
        }
    }
}
