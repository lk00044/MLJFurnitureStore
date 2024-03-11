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
            memberRegistrationLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneLabel = new Label();
            address1Label = new Label();
            address2Label = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipLabel = new Label();
            genderLabel = new Label();
            dobLabel = new Label();
            registerButton = new Button();
            cancelButton = new Button();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            address1TextBox = new TextBox();
            address2TextBox = new TextBox();
            cityTextBox = new TextBox();
            stateTextBox = new TextBox();
            zipTextBox = new TextBox();
            genderTextBox = new TextBox();
            dobTextBox = new TextBox();
            SuspendLayout();
            // 
            // memberRegistrationLabel
            // 
            memberRegistrationLabel.AutoSize = true;
            memberRegistrationLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberRegistrationLabel.Location = new Point(94, 17);
            memberRegistrationLabel.Name = "memberRegistrationLabel";
            memberRegistrationLabel.Size = new Size(220, 30);
            memberRegistrationLabel.TabIndex = 0;
            memberRegistrationLabel.Text = "Member Registration";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(17, 68);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(92, 21);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(17, 118);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 21);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(17, 165);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(59, 21);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Phone";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address1Label.Location = new Point(17, 212);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(70, 21);
            address1Label.TabIndex = 4;
            address1Label.Text = "Address";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address2Label.Location = new Point(17, 257);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(86, 21);
            address2Label.TabIndex = 5;
            address2Label.Text = "Apt/Unit#";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityLabel.Location = new Point(17, 309);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(40, 21);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(17, 364);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(49, 21);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipLabel.Location = new Point(17, 423);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(72, 21);
            zipLabel.TabIndex = 8;
            zipLabel.Text = "Zipcode";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(17, 476);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(65, 21);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(17, 530);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(107, 21);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "Date of Birth";
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(94, 582);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(95, 36);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(239, 582);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(87, 36);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(148, 68);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(202, 29);
            firstNameTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(148, 118);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(202, 29);
            lastNameTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTextBox.Location = new Point(148, 165);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(202, 29);
            phoneTextBox.TabIndex = 16;
            // 
            // address1TextBox
            // 
            address1TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address1TextBox.Location = new Point(148, 209);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(202, 29);
            address1TextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            address2TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address2TextBox.Location = new Point(148, 257);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(202, 29);
            address2TextBox.TabIndex = 18;
            // 
            // cityTextBox
            // 
            cityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cityTextBox.Location = new Point(148, 309);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(202, 29);
            cityTextBox.TabIndex = 19;
            // 
            // stateTextBox
            // 
            stateTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stateTextBox.Location = new Point(148, 364);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(202, 29);
            stateTextBox.TabIndex = 20;
            // 
            // zipTextBox
            // 
            zipTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipTextBox.Location = new Point(148, 423);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(202, 29);
            zipTextBox.TabIndex = 21;
            // 
            // genderTextBox
            // 
            genderTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderTextBox.Location = new Point(148, 473);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(202, 26);
            genderTextBox.TabIndex = 22;
            // 
            // dobTextBox
            // 
            dobTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobTextBox.Location = new Point(148, 522);
            dobTextBox.Name = "dobTextBox";
            dobTextBox.Size = new Size(202, 29);
            dobTextBox.TabIndex = 23;
            // 
            // MemberRegistrationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dobTextBox);
            Controls.Add(genderTextBox);
            Controls.Add(zipTextBox);
            Controls.Add(stateTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(address2TextBox);
            Controls.Add(address1TextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(cancelButton);
            Controls.Add(registerButton);
            Controls.Add(dobLabel);
            Controls.Add(genderLabel);
            Controls.Add(zipLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(address2Label);
            Controls.Add(address1Label);
            Controls.Add(phoneLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(memberRegistrationLabel);
            Name = "MemberRegistrationUserControl";
            Size = new Size(415, 650);
            Load += MemberRegistrationUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberRegistrationLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneLabel;
        private Label address1Label;
        private Label address2Label;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private Label genderLabel;
        private Label dobLabel;
        private Button registerButton;
        private Button cancelButton;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneTextBox;
        private TextBox address1TextBox;
        private TextBox address2TextBox;
        private TextBox cityTextBox;
        private TextBox stateTextBox;
        private TextBox zipTextBox;
        private TextBox genderTextBox;
        private TextBox dobTextBox;
    }
}
