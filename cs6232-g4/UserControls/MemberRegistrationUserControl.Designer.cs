namespace cs6232_g4.UserControls
{
    partial class MemberRegistrationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            regFeedbackLabel = new Label();
            cancelButton = new Button();
            regTableLayoutPanel = new TableLayoutPanel();
            firstNameLabel = new Label();
            stateComboBox = new ComboBox();
            zipTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            FNameErrorLabel = new Label();
            phoneTextBox = new TextBox();
            phoneLabel = new Label();
            phoneErrorLabel = new Label();
            stateLabel = new Label();
            address1TextBox = new TextBox();
            address1Label = new Label();
            address2Label = new Label();
            address2TextBox = new TextBox();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            addr1ErrorLabel = new Label();
            zipLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lNameErrorLabel = new Label();
            dobLabel = new Label();
            genderComboBox = new ComboBox();
            dobDateTimePicker = new DateTimePicker();
            genderErrorLabel = new Label();
            dobErrorLabel = new Label();
            cityErrorLabel = new Label();
            stateErrorLabel = new Label();
            zipErrorLabel = new Label();
            genderLabel = new Label();
            registerButton = new Button();
            instructionsLabel = new Label();
            regTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // regFeedbackLabel
            // 
            regFeedbackLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regFeedbackLabel.Location = new Point(19, 440);
            regFeedbackLabel.Name = "regFeedbackLabel";
            regFeedbackLabel.Size = new Size(367, 26);
            regFeedbackLabel.TabIndex = 42;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 10.8F);
            cancelButton.Location = new Point(528, 437);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(113, 32);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // regTableLayoutPanel
            // 
            regTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            regTableLayoutPanel.ColumnCount = 4;
            regTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.490406F));
            regTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.5096F));
            regTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            regTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 238F));
            regTableLayoutPanel.Controls.Add(firstNameLabel, 0, 0);
            regTableLayoutPanel.Controls.Add(stateComboBox, 3, 8);
            regTableLayoutPanel.Controls.Add(zipTextBox, 3, 10);
            regTableLayoutPanel.Controls.Add(firstNameTextBox, 1, 0);
            regTableLayoutPanel.Controls.Add(FNameErrorLabel, 1, 1);
            regTableLayoutPanel.Controls.Add(phoneTextBox, 1, 4);
            regTableLayoutPanel.Controls.Add(phoneLabel, 0, 4);
            regTableLayoutPanel.Controls.Add(phoneErrorLabel, 1, 5);
            regTableLayoutPanel.Controls.Add(stateLabel, 2, 8);
            regTableLayoutPanel.Controls.Add(address1TextBox, 1, 6);
            regTableLayoutPanel.Controls.Add(address1Label, 0, 6);
            regTableLayoutPanel.Controls.Add(address2Label, 2, 6);
            regTableLayoutPanel.Controls.Add(address2TextBox, 3, 6);
            regTableLayoutPanel.Controls.Add(cityTextBox, 1, 8);
            regTableLayoutPanel.Controls.Add(cityLabel, 0, 8);
            regTableLayoutPanel.Controls.Add(addr1ErrorLabel, 1, 7);
            regTableLayoutPanel.Controls.Add(zipLabel, 2, 10);
            regTableLayoutPanel.Controls.Add(lastNameTextBox, 3, 0);
            regTableLayoutPanel.Controls.Add(lastNameLabel, 2, 0);
            regTableLayoutPanel.Controls.Add(lNameErrorLabel, 3, 1);
            regTableLayoutPanel.Controls.Add(dobLabel, 2, 2);
            regTableLayoutPanel.Controls.Add(genderComboBox, 1, 2);
            regTableLayoutPanel.Controls.Add(dobDateTimePicker, 3, 2);
            regTableLayoutPanel.Controls.Add(genderErrorLabel, 1, 3);
            regTableLayoutPanel.Controls.Add(dobErrorLabel, 3, 3);
            regTableLayoutPanel.Controls.Add(cityErrorLabel, 1, 9);
            regTableLayoutPanel.Controls.Add(stateErrorLabel, 3, 9);
            regTableLayoutPanel.Controls.Add(zipErrorLabel, 3, 11);
            regTableLayoutPanel.Controls.Add(genderLabel, 0, 2);
            regTableLayoutPanel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regTableLayoutPanel.Location = new Point(19, 46);
            regTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            regTableLayoutPanel.Name = "regTableLayoutPanel";
            regTableLayoutPanel.RowCount = 12;
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            regTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            regTableLayoutPanel.Size = new Size(626, 383);
            regTableLayoutPanel.TabIndex = 40;
            // 
            // firstNameLabel
            // 
            firstNameLabel.Font = new Font("Segoe UI", 9F);
            firstNameLabel.Location = new Point(3, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(84, 19);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            firstNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // stateComboBox
            // 
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.Font = new Font("Segoe UI", 10.8F);
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 19;
            stateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            stateComboBox.Location = new Point(390, 261);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(233, 27);
            stateComboBox.TabIndex = 10;
            stateComboBox.SelectedIndexChanged += StateComboBox_SelectedIndexChanged;
            // 
            // zipTextBox
            // 
            zipTextBox.Font = new Font("Segoe UI", 10.8F);
            zipTextBox.Location = new Point(390, 327);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(233, 27);
            zipTextBox.TabIndex = 11;
            zipTextBox.TextChanged += ZipTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(93, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(200, 27);
            firstNameTextBox.TabIndex = 1;
            firstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // FNameErrorLabel
            // 
            FNameErrorLabel.Location = new Point(93, 30);
            FNameErrorLabel.Name = "FNameErrorLabel";
            FNameErrorLabel.Size = new Size(200, 25);
            FNameErrorLabel.TabIndex = 16;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 10.8F);
            phoneTextBox.Location = new Point(93, 130);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 27);
            phoneTextBox.TabIndex = 5;
            phoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Segoe UI", 10.8F);
            phoneLabel.Location = new Point(3, 127);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(84, 20);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Phone";
            phoneLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.Location = new Point(93, 159);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(200, 31);
            phoneErrorLabel.TabIndex = 18;
            // 
            // stateLabel
            // 
            stateLabel.Font = new Font("Segoe UI", 10.8F);
            stateLabel.Location = new Point(299, 258);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(85, 19);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "State";
            stateLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // address1TextBox
            // 
            address1TextBox.Font = new Font("Segoe UI", 10.8F);
            address1TextBox.Location = new Point(93, 193);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(200, 27);
            address1TextBox.TabIndex = 6;
            address1TextBox.TextChanged += Address1TextBox_TextChanged;
            // 
            // address1Label
            // 
            address1Label.Font = new Font("Segoe UI", 10.8F);
            address1Label.Location = new Point(3, 190);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(84, 19);
            address1Label.TabIndex = 4;
            address1Label.Text = "Address";
            address1Label.TextAlign = ContentAlignment.TopRight;
            // 
            // address2Label
            // 
            address2Label.Font = new Font("Segoe UI", 10.8F);
            address2Label.Location = new Point(299, 190);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(85, 19);
            address2Label.TabIndex = 5;
            address2Label.Text = "Apt/Unit#";
            address2Label.TextAlign = ContentAlignment.TopRight;
            // 
            // address2TextBox
            // 
            address2TextBox.Font = new Font("Segoe UI", 10.8F);
            address2TextBox.Location = new Point(390, 193);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(233, 27);
            address2TextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            cityTextBox.Font = new Font("Segoe UI", 10.8F);
            cityTextBox.Location = new Point(93, 261);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(200, 27);
            cityTextBox.TabIndex = 8;
            cityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // cityLabel
            // 
            cityLabel.Font = new Font("Segoe UI", 10.8F);
            cityLabel.Location = new Point(3, 258);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(84, 19);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City";
            cityLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // addr1ErrorLabel
            // 
            addr1ErrorLabel.Location = new Point(93, 226);
            addr1ErrorLabel.Name = "addr1ErrorLabel";
            addr1ErrorLabel.Size = new Size(200, 30);
            addr1ErrorLabel.TabIndex = 30;
            // 
            // zipLabel
            // 
            zipLabel.Font = new Font("Segoe UI", 10.8F);
            zipLabel.Location = new Point(299, 324);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(85, 19);
            zipLabel.TabIndex = 8;
            zipLabel.Text = "Zipcode";
            zipLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 11F);
            lastNameTextBox.Location = new Point(390, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(233, 27);
            lastNameTextBox.TabIndex = 2;
            lastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(299, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(85, 26);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // lNameErrorLabel
            // 
            lNameErrorLabel.Location = new Point(390, 30);
            lNameErrorLabel.Name = "lNameErrorLabel";
            lNameErrorLabel.Size = new Size(233, 20);
            lNameErrorLabel.TabIndex = 17;
            // 
            // dobLabel
            // 
            dobLabel.Font = new Font("Segoe UI", 10.8F);
            dobLabel.Location = new Point(299, 55);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(85, 38);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "Date of Birth";
            dobLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.Font = new Font("Segoe UI", 10.8F);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderComboBox.Location = new Point(93, 58);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(200, 27);
            genderComboBox.TabIndex = 3;
            genderComboBox.SelectedIndexChanged += GenderComboBox_SelectedIndexChanged;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobDateTimePicker.Checked = false;
            dobDateTimePicker.Location = new Point(390, 57);
            dobDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dobDateTimePicker.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(233, 27);
            dobDateTimePicker.TabIndex = 4;
            dobDateTimePicker.Value = new DateTime(1999, 9, 9, 0, 0, 0, 0);
            dobDateTimePicker.ValueChanged += DobDateTimePicker_ValueChanged;
            // 
            // genderErrorLabel
            // 
            genderErrorLabel.Location = new Point(93, 96);
            genderErrorLabel.Name = "genderErrorLabel";
            genderErrorLabel.Size = new Size(200, 27);
            genderErrorLabel.TabIndex = 32;
            // 
            // dobErrorLabel
            // 
            dobErrorLabel.Location = new Point(390, 96);
            dobErrorLabel.Name = "dobErrorLabel";
            dobErrorLabel.Size = new Size(233, 27);
            dobErrorLabel.TabIndex = 33;
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.Location = new Point(93, 293);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(200, 26);
            cityErrorLabel.TabIndex = 34;
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.Location = new Point(390, 293);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(233, 26);
            stateErrorLabel.TabIndex = 35;
            // 
            // zipErrorLabel
            // 
            zipErrorLabel.Location = new Point(390, 357);
            zipErrorLabel.Name = "zipErrorLabel";
            zipErrorLabel.Size = new Size(233, 26);
            zipErrorLabel.TabIndex = 36;
            // 
            // genderLabel
            // 
            genderLabel.Font = new Font("Segoe UI", 10.8F);
            genderLabel.Location = new Point(3, 55);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(84, 19);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender";
            genderLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 10.8F);
            registerButton.Location = new Point(400, 437);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(113, 32);
            registerButton.TabIndex = 12;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterButton_Click;
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            instructionsLabel.Location = new Point(19, 13);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(332, 20);
            instructionsLabel.TabIndex = 43;
            instructionsLabel.Text = "Enter only numbers for phone number and zipcode.";
            // 
            // MemberRegistrationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(instructionsLabel);
            Controls.Add(regFeedbackLabel);
            Controls.Add(cancelButton);
            Controls.Add(regTableLayoutPanel);
            Controls.Add(registerButton);
            Name = "MemberRegistrationUserControl";
            Size = new Size(673, 479);
            Load += MemberRegistrationUserControl_Load;
            regTableLayoutPanel.ResumeLayout(false);
            regTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label regFeedbackLabel;
        private Button cancelButton;
        private TableLayoutPanel regTableLayoutPanel;
        private Label firstNameLabel;
        private ComboBox stateComboBox;
        private TextBox zipTextBox;
        private TextBox firstNameTextBox;
        private Label FNameErrorLabel;
        private TextBox phoneTextBox;
        private Label phoneLabel;
        private Label phoneErrorLabel;
        private Label stateLabel;
        private TextBox address1TextBox;
        private Label address1Label;
        private Label address2Label;
        private TextBox address2TextBox;
        private TextBox cityTextBox;
        private Label cityLabel;
        private Label addr1ErrorLabel;
        private Label zipLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label lNameErrorLabel;
        private Label dobLabel;
        private ComboBox genderComboBox;
        private DateTimePicker dobDateTimePicker;
        private Label genderErrorLabel;
        private Label dobErrorLabel;
        private Label cityErrorLabel;
        private Label stateErrorLabel;
        private Label zipErrorLabel;
        private Label genderLabel;
        private Button registerButton;
        private Label instructionsLabel;
    }
}
