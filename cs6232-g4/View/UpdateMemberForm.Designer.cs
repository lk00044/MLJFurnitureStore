using Members.Model;

namespace cs6232_g4.View
{
    partial class UpdateMemberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fnameErrorLabel = new Label();
            NewFNameLabel = new Label();
            MbrNewLNameTextBox = new TextBox();
            NewGenderLabel = new Label();
            GenderComboBox = new ComboBox();
            NewLNameLabel = new Label();
            NewDOBLabel = new Label();
            PhoneNumTextBox = new TextBox();
            NewPhoneLabel = new Label();
            NewAddr2TextBox = new TextBox();
            label1 = new Label();
            NewAddr1Label = new Label();
            NewAddr1TextBox = new TextBox();
            StateComboBox = new ComboBox();
            SearchInstructionsLabel = new Label();
            DisplayIDLabel = new Label();
            NewStateLabel = new Label();
            InfoLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            NewCityTextBox = new TextBox();
            label2 = new Label();
            NewZipTextBox = new TextBox();
            NewZipLabel = new Label();
            genderErrorLabel = new Label();
            dobErrorLabel = new Label();
            phoneErrorLabel = new Label();
            addr1ErrorLabel = new Label();
            cityErrorLabel = new Label();
            stateErrorLabel = new Label();
            zipErrorLabel = new Label();
            MbrNewFNameTextBox = new TextBox();
            label4 = new Label();
            dobDateTimePicker = new DateTimePicker();
            lNameErrorLabel = new Label();
            UpdateMemberButton = new Button();
            cancelButton = new Button();
            MemberIDLabel = new Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // fnameErrorLabel
            // 
            fnameErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameErrorLabel.Location = new Point(121, 24);
            fnameErrorLabel.Name = "fnameErrorLabel";
            fnameErrorLabel.Size = new Size(221, 24);
            fnameErrorLabel.TabIndex = 23;
            // 
            // NewFNameLabel
            // 
            NewFNameLabel.Location = new Point(3, 0);
            NewFNameLabel.Name = "NewFNameLabel";
            NewFNameLabel.Size = new Size(112, 24);
            NewFNameLabel.TabIndex = 2;
            NewFNameLabel.Text = "First Name: ";
            NewFNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MbrNewLNameTextBox
            // 
            MbrNewLNameTextBox.Location = new Point(460, 2);
            MbrNewLNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrNewLNameTextBox.Name = "MbrNewLNameTextBox";
            MbrNewLNameTextBox.Size = new Size(251, 23);
            MbrNewLNameTextBox.TabIndex = 2;
            // 
            // NewGenderLabel
            // 
            NewGenderLabel.Location = new Point(3, 48);
            NewGenderLabel.Name = "NewGenderLabel";
            NewGenderLabel.Size = new Size(112, 20);
            NewGenderLabel.TabIndex = 18;
            NewGenderLabel.Text = "Gender: ";
            NewGenderLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GenderComboBox
            // 
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Female", "Male ", "Transgender", "Non-binary/non-conforming", "Prefer not to respond" });
            GenderComboBox.Location = new Point(121, 50);
            GenderComboBox.Margin = new Padding(3, 2, 3, 2);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(221, 23);
            GenderComboBox.TabIndex = 3;
            // 
            // NewLNameLabel
            // 
            NewLNameLabel.Location = new Point(348, 0);
            NewLNameLabel.Name = "NewLNameLabel";
            NewLNameLabel.Size = new Size(106, 24);
            NewLNameLabel.TabIndex = 1;
            NewLNameLabel.Text = "Last Name: ";
            NewLNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewDOBLabel
            // 
            NewDOBLabel.Location = new Point(348, 48);
            NewDOBLabel.Name = "NewDOBLabel";
            NewDOBLabel.Size = new Size(106, 26);
            NewDOBLabel.TabIndex = 19;
            NewDOBLabel.Text = "Date of Birth: ";
            NewDOBLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PhoneNumTextBox
            // 
            PhoneNumTextBox.Location = new Point(121, 103);
            PhoneNumTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneNumTextBox.Name = "PhoneNumTextBox";
            PhoneNumTextBox.Size = new Size(221, 23);
            PhoneNumTextBox.TabIndex = 5;
            // 
            // NewPhoneLabel
            // 
            NewPhoneLabel.Location = new Point(3, 101);
            NewPhoneLabel.Name = "NewPhoneLabel";
            NewPhoneLabel.Size = new Size(112, 26);
            NewPhoneLabel.TabIndex = 3;
            NewPhoneLabel.Text = "Phone Number: ";
            NewPhoneLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr2TextBox
            // 
            NewAddr2TextBox.Location = new Point(460, 159);
            NewAddr2TextBox.Margin = new Padding(3, 2, 3, 2);
            NewAddr2TextBox.Name = "NewAddr2TextBox";
            NewAddr2TextBox.Size = new Size(246, 23);
            NewAddr2TextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(348, 157);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 11;
            label1.Text = "Apt./Unit #:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr1Label
            // 
            NewAddr1Label.Location = new Point(3, 157);
            NewAddr1Label.Name = "NewAddr1Label";
            NewAddr1Label.Size = new Size(112, 20);
            NewAddr1Label.TabIndex = 8;
            NewAddr1Label.Text = "Address 1: ";
            NewAddr1Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr1TextBox
            // 
            NewAddr1TextBox.Location = new Point(121, 159);
            NewAddr1TextBox.Margin = new Padding(3, 2, 3, 2);
            NewAddr1TextBox.Name = "NewAddr1TextBox";
            NewAddr1TextBox.Size = new Size(221, 23);
            NewAddr1TextBox.TabIndex = 6;
            // 
            // StateComboBox
            // 
            StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            StateComboBox.Location = new Point(460, 216);
            StateComboBox.Margin = new Padding(3, 2, 3, 2);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(245, 23);
            StateComboBox.TabIndex = 9;
            // 
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(10, 16);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(340, 20);
            SearchInstructionsLabel.TabIndex = 41;
            SearchInstructionsLabel.Text = "Enter numbers only for phone number and zip code. ";
            // 
            // DisplayIDLabel
            // 
            DisplayIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayIDLabel.Location = new Point(112, 58);
            DisplayIDLabel.Name = "DisplayIDLabel";
            DisplayIDLabel.Size = new Size(134, 19);
            DisplayIDLabel.TabIndex = 40;
            // 
            // NewStateLabel
            // 
            NewStateLabel.Location = new Point(348, 214);
            NewStateLabel.Name = "NewStateLabel";
            NewStateLabel.Size = new Size(106, 20);
            NewStateLabel.TabIndex = 10;
            NewStateLabel.Text = "State: ";
            NewStateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InfoLabel
            // 
            InfoLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoLabel.Location = new Point(455, 20);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(272, 25);
            InfoLabel.TabIndex = 42;
            InfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 227F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Controls.Add(label3, 0, 11);
            tableLayoutPanel2.Controls.Add(fnameErrorLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(NewFNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(MbrNewLNameTextBox, 3, 0);
            tableLayoutPanel2.Controls.Add(NewGenderLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(GenderComboBox, 1, 2);
            tableLayoutPanel2.Controls.Add(NewLNameLabel, 2, 0);
            tableLayoutPanel2.Controls.Add(NewDOBLabel, 2, 2);
            tableLayoutPanel2.Controls.Add(PhoneNumTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(NewPhoneLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 2, 6);
            tableLayoutPanel2.Controls.Add(NewAddr1Label, 0, 6);
            tableLayoutPanel2.Controls.Add(NewAddr1TextBox, 1, 6);
            tableLayoutPanel2.Controls.Add(StateComboBox, 3, 8);
            tableLayoutPanel2.Controls.Add(NewStateLabel, 2, 8);
            tableLayoutPanel2.Controls.Add(NewCityTextBox, 1, 8);
            tableLayoutPanel2.Controls.Add(label2, 0, 8);
            tableLayoutPanel2.Controls.Add(NewZipTextBox, 1, 10);
            tableLayoutPanel2.Controls.Add(NewZipLabel, 0, 10);
            tableLayoutPanel2.Controls.Add(genderErrorLabel, 1, 3);
            tableLayoutPanel2.Controls.Add(dobErrorLabel, 3, 3);
            tableLayoutPanel2.Controls.Add(phoneErrorLabel, 1, 5);
            tableLayoutPanel2.Controls.Add(addr1ErrorLabel, 1, 7);
            tableLayoutPanel2.Controls.Add(cityErrorLabel, 1, 9);
            tableLayoutPanel2.Controls.Add(stateErrorLabel, 3, 9);
            tableLayoutPanel2.Controls.Add(zipErrorLabel, 1, 11);
            tableLayoutPanel2.Controls.Add(MbrNewFNameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 1);
            tableLayoutPanel2.Controls.Add(dobDateTimePicker, 3, 2);
            tableLayoutPanel2.Controls.Add(NewAddr2TextBox, 3, 6);
            tableLayoutPanel2.Controls.Add(lNameErrorLabel, 3, 1);
            tableLayoutPanel2.Controls.Add(UpdateMemberButton, 3, 10);
            tableLayoutPanel2.Controls.Add(cancelButton, 3, 11);
            tableLayoutPanel2.Location = new Point(22, 90);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel2.Size = new Size(714, 334);
            tableLayoutPanel2.TabIndex = 39;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 299);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 32;
            // 
            // NewCityTextBox
            // 
            NewCityTextBox.Location = new Point(121, 216);
            NewCityTextBox.Margin = new Padding(3, 2, 3, 2);
            NewCityTextBox.Name = "NewCityTextBox";
            NewCityTextBox.Size = new Size(221, 23);
            NewCityTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.Location = new Point(3, 214);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 9;
            label2.Text = "City:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewZipTextBox
            // 
            NewZipTextBox.Location = new Point(121, 272);
            NewZipTextBox.Margin = new Padding(3, 2, 3, 2);
            NewZipTextBox.Name = "NewZipTextBox";
            NewZipTextBox.Size = new Size(221, 23);
            NewZipTextBox.TabIndex = 10;
            // 
            // NewZipLabel
            // 
            NewZipLabel.Location = new Point(3, 270);
            NewZipLabel.Name = "NewZipLabel";
            NewZipLabel.Size = new Size(112, 20);
            NewZipLabel.TabIndex = 17;
            NewZipLabel.Text = "Zip: ";
            NewZipLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // genderErrorLabel
            // 
            genderErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderErrorLabel.Location = new Point(121, 74);
            genderErrorLabel.Name = "genderErrorLabel";
            genderErrorLabel.Size = new Size(221, 24);
            genderErrorLabel.TabIndex = 24;
            // 
            // dobErrorLabel
            // 
            dobErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobErrorLabel.Location = new Point(460, 74);
            dobErrorLabel.Name = "dobErrorLabel";
            dobErrorLabel.Size = new Size(236, 24);
            dobErrorLabel.TabIndex = 26;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneErrorLabel.Location = new Point(121, 129);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(221, 24);
            phoneErrorLabel.TabIndex = 27;
            // 
            // addr1ErrorLabel
            // 
            addr1ErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addr1ErrorLabel.Location = new Point(121, 188);
            addr1ErrorLabel.Name = "addr1ErrorLabel";
            addr1ErrorLabel.Size = new Size(221, 24);
            addr1ErrorLabel.TabIndex = 28;
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityErrorLabel.Location = new Point(121, 240);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(221, 24);
            cityErrorLabel.TabIndex = 29;
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateErrorLabel.Location = new Point(460, 240);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(236, 24);
            stateErrorLabel.TabIndex = 30;
            // 
            // zipErrorLabel
            // 
            zipErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipErrorLabel.Location = new Point(121, 299);
            zipErrorLabel.Name = "zipErrorLabel";
            zipErrorLabel.Size = new Size(221, 24);
            zipErrorLabel.TabIndex = 31;
            // 
            // MbrNewFNameTextBox
            // 
            MbrNewFNameTextBox.Location = new Point(121, 2);
            MbrNewFNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrNewFNameTextBox.Name = "MbrNewFNameTextBox";
            MbrNewFNameTextBox.Size = new Size(221, 23);
            MbrNewFNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(348, 24);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 25;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Location = new Point(460, 50);
            dobDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dobDateTimePicker.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dobDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(251, 23);
            dobDateTimePicker.TabIndex = 4;
            dobDateTimePicker.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // lNameErrorLabel
            // 
            lNameErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNameErrorLabel.Location = new Point(460, 24);
            lNameErrorLabel.Name = "lNameErrorLabel";
            lNameErrorLabel.Size = new Size(221, 24);
            lNameErrorLabel.TabIndex = 33;
            // 
            // UpdateMemberButton
            // 
            UpdateMemberButton.FlatStyle = FlatStyle.Popup;
            UpdateMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMemberButton.Location = new Point(460, 272);
            UpdateMemberButton.Margin = new Padding(3, 2, 3, 2);
            UpdateMemberButton.Name = "UpdateMemberButton";
            UpdateMemberButton.Size = new Size(251, 24);
            UpdateMemberButton.TabIndex = 11;
            UpdateMemberButton.Text = "Update Member";
            UpdateMemberButton.UseVisualStyleBackColor = true;
            UpdateMemberButton.Click += UpdateMemberButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(460, 301);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(251, 24);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.AutoSize = true;
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(22, 58);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(86, 19);
            MemberIDLabel.TabIndex = 38;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // UpdateMemberForm
            // 
            AcceptButton = UpdateMemberButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(764, 447);
            Controls.Add(SearchInstructionsLabel);
            Controls.Add(DisplayIDLabel);
            Controls.Add(InfoLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(MemberIDLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Me Furniture Rentals : : Update Member";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //  private UserControls.EditMemberInfoUserControl editMemberInfoUserControl;
        private UserControls.UpdateMemberInfoUserControl updateMemberInfoUserControl11;
        private Label fnameErrorLabel;
        private Label NewFNameLabel;
        private TextBox MbrNewLNameTextBox;
        private Label NewGenderLabel;
        private ComboBox GenderComboBox;
        private Label NewLNameLabel;
        private Label NewDOBLabel;
        private TextBox PhoneNumTextBox;
        private Label NewPhoneLabel;
        private TextBox NewAddr2TextBox;
        private Label label1;
        private Label NewAddr1Label;
        private TextBox NewAddr1TextBox;
        private ComboBox StateComboBox;
        private Label SearchInstructionsLabel;
        private Label DisplayIDLabel;
        private Label NewStateLabel;
        private Label InfoLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox NewCityTextBox;
        private Label label2;
        private TextBox NewZipTextBox;
        private Label NewZipLabel;
        private Label genderErrorLabel;
        private Label dobErrorLabel;
        private Label phoneErrorLabel;
        private Label addr1ErrorLabel;
        private Label cityErrorLabel;
        private Label stateErrorLabel;
        private Label zipErrorLabel;
        private Button UpdateMemberButton;
        private TextBox MbrNewFNameTextBox;
        private Label label4;
        private Label MemberIDLabel;
        private DateTimePicker dobDateTimePicker;
        private Label label3;
        private Label lNameErrorLabel;
        private Button cancelButton;
    }
}