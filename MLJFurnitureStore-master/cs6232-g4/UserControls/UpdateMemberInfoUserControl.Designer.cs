namespace cs6232_g4.UserControls
{
    partial class UpdateMemberInfoUserControl
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
            InfoLabel = new Label();
            fnameErrorLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            NewFNameLabel = new Label();
            MbrNewLNameTextBox = new TextBox();
            NewGenderLabel = new Label();
            GenderComboBox = new ComboBox();
            NewLNameLabel = new Label();
            NewDOBLabel = new Label();
            NewDOBTextBox = new TextBox();
            MbrNewPhoneNumTextBox = new TextBox();
            NewPhoneLabel = new Label();
            NewAddr2TextBox = new TextBox();
            label1 = new Label();
            NewAddr1Label = new Label();
            NewAddr1TextBox = new TextBox();
            NewStateComboBox = new ComboBox();
            NewStateLabel = new Label();
            NewCityTextBox = new TextBox();
            label2 = new Label();
            NewZipTextBox = new TextBox();
            NewZipLabel = new Label();
            genderErrorLabel = new Label();
            label4 = new Label();
            dobErrorLabel = new Label();
            phoneErrorLabel = new Label();
            addr1ErrorLabel = new Label();
            cityErrorLabel = new Label();
            stateErrorLabel = new Label();
            zipErrorLabel = new Label();
            UpdateMemberButton = new Button();
            MbrNewFNameTextBox = new TextBox();
            SearchInstructionsLabel = new Label();
            MemberIDLabel = new Label();
            DisplayIDLabel = new Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.Location = new Point(545, 50);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(311, 33);
            InfoLabel.TabIndex = 37;
            // 
            // fnameErrorLabel
            // 
            fnameErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameErrorLabel.Location = new Point(138, 32);
            fnameErrorLabel.Name = "fnameErrorLabel";
            fnameErrorLabel.Size = new Size(253, 32);
            fnameErrorLabel.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 135F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 259F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(fnameErrorLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(NewFNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(MbrNewLNameTextBox, 3, 0);
            tableLayoutPanel2.Controls.Add(NewGenderLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(GenderComboBox, 1, 2);
            tableLayoutPanel2.Controls.Add(NewLNameLabel, 2, 0);
            tableLayoutPanel2.Controls.Add(NewDOBLabel, 2, 2);
            tableLayoutPanel2.Controls.Add(NewDOBTextBox, 3, 2);
            tableLayoutPanel2.Controls.Add(MbrNewPhoneNumTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(NewPhoneLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(NewAddr2TextBox, 3, 6);
            tableLayoutPanel2.Controls.Add(label1, 2, 6);
            tableLayoutPanel2.Controls.Add(NewAddr1Label, 0, 6);
            tableLayoutPanel2.Controls.Add(NewAddr1TextBox, 1, 6);
            tableLayoutPanel2.Controls.Add(NewStateComboBox, 3, 8);
            tableLayoutPanel2.Controls.Add(NewStateLabel, 2, 8);
            tableLayoutPanel2.Controls.Add(NewCityTextBox, 1, 8);
            tableLayoutPanel2.Controls.Add(label2, 0, 8);
            tableLayoutPanel2.Controls.Add(NewZipTextBox, 1, 10);
            tableLayoutPanel2.Controls.Add(NewZipLabel, 0, 10);
            tableLayoutPanel2.Controls.Add(genderErrorLabel, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 3, 1);
            tableLayoutPanel2.Controls.Add(dobErrorLabel, 3, 3);
            tableLayoutPanel2.Controls.Add(phoneErrorLabel, 1, 5);
            tableLayoutPanel2.Controls.Add(addr1ErrorLabel, 1, 7);
            tableLayoutPanel2.Controls.Add(cityErrorLabel, 1, 9);
            tableLayoutPanel2.Controls.Add(stateErrorLabel, 3, 9);
            tableLayoutPanel2.Controls.Add(zipErrorLabel, 1, 11);
            tableLayoutPanel2.Controls.Add(UpdateMemberButton, 3, 11);
            tableLayoutPanel2.Controls.Add(MbrNewFNameTextBox, 1, 0);
            tableLayoutPanel2.Location = new Point(40, 115);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 12;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel2.Size = new Size(816, 445);
            tableLayoutPanel2.TabIndex = 34;
            // 
            // NewFNameLabel
            // 
            NewFNameLabel.Location = new Point(3, 0);
            NewFNameLabel.Name = "NewFNameLabel";
            NewFNameLabel.Size = new Size(129, 32);
            NewFNameLabel.TabIndex = 2;
            NewFNameLabel.Text = "First Name: ";
            NewFNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MbrNewLNameTextBox
            // 
            MbrNewLNameTextBox.Location = new Point(525, 3);
            MbrNewLNameTextBox.Name = "MbrNewLNameTextBox";
            MbrNewLNameTextBox.Size = new Size(281, 27);
            MbrNewLNameTextBox.TabIndex = 7;
            // 
            // NewGenderLabel
            // 
            NewGenderLabel.Location = new Point(3, 64);
            NewGenderLabel.Name = "NewGenderLabel";
            NewGenderLabel.Size = new Size(129, 27);
            NewGenderLabel.TabIndex = 18;
            NewGenderLabel.Text = "Gender: ";
            NewGenderLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Female", "Male ", "Transgender", "Non-binary/non-conforming", "Prefer not to respond" });
            GenderComboBox.Location = new Point(138, 67);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(253, 28);
            GenderComboBox.TabIndex = 21;
            // 
            // NewLNameLabel
            // 
            NewLNameLabel.Location = new Point(397, 0);
            NewLNameLabel.Name = "NewLNameLabel";
            NewLNameLabel.Size = new Size(122, 32);
            NewLNameLabel.TabIndex = 1;
            NewLNameLabel.Text = "Last Name: ";
            NewLNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewDOBLabel
            // 
            NewDOBLabel.Location = new Point(397, 64);
            NewDOBLabel.Name = "NewDOBLabel";
            NewDOBLabel.Size = new Size(122, 35);
            NewDOBLabel.TabIndex = 19;
            NewDOBLabel.Text = "Date of Birth: ";
            NewDOBLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewDOBTextBox
            // 
            NewDOBTextBox.Location = new Point(525, 67);
            NewDOBTextBox.Name = "NewDOBTextBox";
            NewDOBTextBox.Size = new Size(281, 27);
            NewDOBTextBox.TabIndex = 20;
            // 
            // MbrNewPhoneNumTextBox
            // 
            MbrNewPhoneNumTextBox.Location = new Point(138, 138);
            MbrNewPhoneNumTextBox.Name = "MbrNewPhoneNumTextBox";
            MbrNewPhoneNumTextBox.Size = new Size(253, 27);
            MbrNewPhoneNumTextBox.TabIndex = 5;
            // 
            // NewPhoneLabel
            // 
            NewPhoneLabel.Location = new Point(3, 135);
            NewPhoneLabel.Name = "NewPhoneLabel";
            NewPhoneLabel.Size = new Size(129, 35);
            NewPhoneLabel.TabIndex = 3;
            NewPhoneLabel.Text = "Phone Number: ";
            NewPhoneLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr2TextBox
            // 
            NewAddr2TextBox.Location = new Point(525, 213);
            NewAddr2TextBox.Name = "NewAddr2TextBox";
            NewAddr2TextBox.Size = new Size(281, 27);
            NewAddr2TextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.Location = new Point(397, 210);
            label1.Name = "label1";
            label1.Size = new Size(122, 27);
            label1.TabIndex = 11;
            label1.Text = "Apt./Unit #:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr1Label
            // 
            NewAddr1Label.Location = new Point(3, 210);
            NewAddr1Label.Name = "NewAddr1Label";
            NewAddr1Label.Size = new Size(129, 27);
            NewAddr1Label.TabIndex = 8;
            NewAddr1Label.Text = "Address 1: ";
            NewAddr1Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewAddr1TextBox
            // 
            NewAddr1TextBox.Location = new Point(138, 213);
            NewAddr1TextBox.Name = "NewAddr1TextBox";
            NewAddr1TextBox.Size = new Size(253, 27);
            NewAddr1TextBox.TabIndex = 12;
            // 
            // NewStateComboBox
            // 
            NewStateComboBox.FormattingEnabled = true;
            NewStateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            NewStateComboBox.Location = new Point(525, 289);
            NewStateComboBox.Name = "NewStateComboBox";
            NewStateComboBox.Size = new Size(279, 28);
            NewStateComboBox.TabIndex = 16;
            // 
            // NewStateLabel
            // 
            NewStateLabel.Location = new Point(397, 286);
            NewStateLabel.Name = "NewStateLabel";
            NewStateLabel.Size = new Size(122, 27);
            NewStateLabel.TabIndex = 10;
            NewStateLabel.Text = "State: ";
            NewStateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewCityTextBox
            // 
            NewCityTextBox.Location = new Point(138, 289);
            NewCityTextBox.Name = "NewCityTextBox";
            NewCityTextBox.Size = new Size(253, 27);
            NewCityTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.Location = new Point(3, 286);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 9;
            label2.Text = "City:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewZipTextBox
            // 
            NewZipTextBox.Location = new Point(138, 364);
            NewZipTextBox.Name = "NewZipTextBox";
            NewZipTextBox.Size = new Size(253, 27);
            NewZipTextBox.TabIndex = 13;
            // 
            // NewZipLabel
            // 
            NewZipLabel.Location = new Point(3, 361);
            NewZipLabel.Name = "NewZipLabel";
            NewZipLabel.Size = new Size(129, 27);
            NewZipLabel.TabIndex = 17;
            NewZipLabel.Text = "Zip: ";
            NewZipLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // genderErrorLabel
            // 
            genderErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderErrorLabel.Location = new Point(138, 99);
            genderErrorLabel.Name = "genderErrorLabel";
            genderErrorLabel.Size = new Size(253, 32);
            genderErrorLabel.TabIndex = 24;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(525, 32);
            label4.Name = "label4";
            label4.Size = new Size(270, 32);
            label4.TabIndex = 25;
            // 
            // dobErrorLabel
            // 
            dobErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobErrorLabel.Location = new Point(525, 99);
            dobErrorLabel.Name = "dobErrorLabel";
            dobErrorLabel.Size = new Size(270, 32);
            dobErrorLabel.TabIndex = 26;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneErrorLabel.Location = new Point(138, 172);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(253, 32);
            phoneErrorLabel.TabIndex = 27;
            // 
            // addr1ErrorLabel
            // 
            addr1ErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addr1ErrorLabel.Location = new Point(138, 251);
            addr1ErrorLabel.Name = "addr1ErrorLabel";
            addr1ErrorLabel.Size = new Size(253, 32);
            addr1ErrorLabel.TabIndex = 28;
            // 
            // cityErrorLabel
            // 
            cityErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityErrorLabel.Location = new Point(138, 321);
            cityErrorLabel.Name = "cityErrorLabel";
            cityErrorLabel.Size = new Size(253, 32);
            cityErrorLabel.TabIndex = 29;
            // 
            // stateErrorLabel
            // 
            stateErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateErrorLabel.Location = new Point(525, 321);
            stateErrorLabel.Name = "stateErrorLabel";
            stateErrorLabel.Size = new Size(270, 32);
            stateErrorLabel.TabIndex = 30;
            // 
            // zipErrorLabel
            // 
            zipErrorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipErrorLabel.Location = new Point(138, 400);
            zipErrorLabel.Name = "zipErrorLabel";
            zipErrorLabel.Size = new Size(253, 32);
            zipErrorLabel.TabIndex = 31;
            // 
            // UpdateMemberButton
            // 
            UpdateMemberButton.FlatStyle = FlatStyle.Popup;
            UpdateMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMemberButton.Location = new Point(525, 403);
            UpdateMemberButton.Name = "UpdateMemberButton";
            UpdateMemberButton.Size = new Size(288, 32);
            UpdateMemberButton.TabIndex = 5;
            UpdateMemberButton.Text = "Update Member";
            UpdateMemberButton.UseVisualStyleBackColor = true;
            UpdateMemberButton.Click += UpdateMemberButton_Click;
            // 
            // MbrNewFNameTextBox
            // 
            MbrNewFNameTextBox.Location = new Point(138, 3);
            MbrNewFNameTextBox.Name = "MbrNewFNameTextBox";
            MbrNewFNameTextBox.Size = new Size(253, 27);
            MbrNewFNameTextBox.TabIndex = 6;
            // 
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(12, 18);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(422, 25);
            SearchInstructionsLabel.TabIndex = 36;
            SearchInstructionsLabel.Text = "Enter numbers only for phone number and zip code. ";
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.AutoSize = true;
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(12, 60);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(106, 23);
            MemberIDLabel.TabIndex = 33;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // DisplayIDLabel
            // 
            DisplayIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayIDLabel.Location = new Point(125, 58);
            DisplayIDLabel.Name = "DisplayIDLabel";
            DisplayIDLabel.Size = new Size(153, 25);
            DisplayIDLabel.TabIndex = 35;
            // 
            // UpdateMemberInfoUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InfoLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(SearchInstructionsLabel);
            Controls.Add(MemberIDLabel);
            Controls.Add(DisplayIDLabel);
            Name = "UpdateMemberInfoUserControl1";
            Size = new Size(899, 595);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private Label fnameErrorLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NewFNameLabel;
        private TextBox MbrNewLNameTextBox;
        private Label NewGenderLabel;
        private ComboBox GenderComboBox;
        private Label NewDOBLabel;
        private TextBox NewDOBTextBox;
        private TextBox MbrNewPhoneNumTextBox;
        private Label NewPhoneLabel;
        private TextBox NewAddr2TextBox;
        private Label label1;
        private Label NewAddr1Label;
        private TextBox NewAddr1TextBox;
        private ComboBox NewStateComboBox;
        private Label NewStateLabel;
        private TextBox NewCityTextBox;
        private Label label2;
        private TextBox NewZipTextBox;
        private Label NewZipLabel;
        private Label genderErrorLabel;
        private Label label4;
        private Label dobErrorLabel;
        private Label phoneErrorLabel;
        private Label addr1ErrorLabel;
        private Label cityErrorLabel;
        private Label stateErrorLabel;
        private Label zipErrorLabel;
        private Button UpdateMemberButton;
        private TextBox MbrNewFNameTextBox;
        private Label NewLNameLabel;
        private Label SearchInstructionsLabel;
        private Label MemberIDLabel;
        private Label DisplayIDLabel;
    }
}
