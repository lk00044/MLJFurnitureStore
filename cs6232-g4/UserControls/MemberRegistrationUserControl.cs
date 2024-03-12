using cs6232_g4.Controller;
using StoreMembers.Model;
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
        private readonly StoreMemberController _storeMemberController;

        public MemberRegistrationUserControl()
        {
            InitializeComponent();
            this._storeMemberController = new StoreMemberController();
        }

        private void MemberRegistrationUserControl_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            StoreMember newMember = new StoreMember();
            newMember.FirstName = this.firstNameTextBox.Text;
            newMember.LastName = this.lastNameTextBox.Text;
            newMember.Address1 = this.address1TextBox.Text;
            newMember.Phone = this.phoneTextBox.Text;
            newMember.Address2 = this.address2TextBox.Text;
            newMember.City = this.cityTextBox.Text;
            newMember.State = this.stateComboBox.Text;
            newMember.ZipCode = this.zipTextBox.Text;
            newMember.Gender = this.genderComboBox.Text[0].ToString();
            newMember.DateOfBirth = DateTime.Parse(this.monthComboBox.Text + "-" + this.dayComboBox.Text + "-"+ this.yearComboBox.Text);

            this._storeMemberController.RegisterStoreMember(newMember);
        }
    }
}
