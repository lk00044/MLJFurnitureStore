namespace cs6232_g4.UserControls
{
    partial class EditMemberInfoUserControl
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
            MbrNewFNameTextBox = new TextBox();
            MbrNewPhoneNumTextBox = new TextBox();
            SearchInstructionsLabel = new Label();
            DisplayIDLabel = new Label();
            EnterNewMbrNameLabel = new Label();
            NewDOBLabel = new Label();
            NewAddr1Label = new Label();
            UpdateMemberButton = new Button();
            NewFNameLabel = new Label();
            NewPhoneLabel = new Label();
            NewLNameLabel = new Label();
            MbrNewLNameTextBox = new TextBox();
            label2 = new Label();
            EnterMbrIDlabel = new Label();
            EnterMbrLNameLabel = new Label();
            NewAddr1TextBox = new TextBox();
            FindMemberButton = new Button();
            MbrPhoneNumTextBox = new TextBox();
            NewAddr2TextBox = new TextBox();
            NewCityTextBox = new TextBox();
            NewZipTextBox = new TextBox();
            NewStateComboBox = new ComboBox();
            NewDOBTextBox = new TextBox();
            GenderComboBox = new ComboBox();
            EnterMbrFNameLabel = new Label();
            EnterMbrPhoneNumLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            MbrIDTextBox = new TextBox();
            MbrFNameTextBox = new TextBox();
            MbrLNameTextBox = new TextBox();
            label1 = new Label();
            NewStateLabel = new Label();
            NewZipLabel = new Label();
            NewGenderLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // MbrNewFNameTextBox
            // 
            MbrNewFNameTextBox.Location = new Point(221, 2);
            MbrNewFNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrNewFNameTextBox.Name = "MbrNewFNameTextBox";
            MbrNewFNameTextBox.Size = new Size(246, 23);
            MbrNewFNameTextBox.TabIndex = 6;
            // 
            // MbrNewPhoneNumTextBox
            // 
            MbrNewPhoneNumTextBox.Location = new Point(221, 50);
            MbrNewPhoneNumTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrNewPhoneNumTextBox.Name = "MbrNewPhoneNumTextBox";
            MbrNewPhoneNumTextBox.Size = new Size(246, 23);
            MbrNewPhoneNumTextBox.TabIndex = 5;
            // 
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(29, 28);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(483, 20);
            SearchInstructionsLabel.TabIndex = 12;
            SearchInstructionsLabel.Text = "Enter Member ID, Member Phone Number or Member First and Last Name.";
            // 
            // DisplayIDLabel
            // 
            DisplayIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayIDLabel.Location = new Point(157, 190);
            DisplayIDLabel.Name = "DisplayIDLabel";
            DisplayIDLabel.Size = new Size(143, 19);
            DisplayIDLabel.TabIndex = 11;
            // 
            // EnterNewMbrNameLabel
            // 
            EnterNewMbrNameLabel.AutoSize = true;
            EnterNewMbrNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterNewMbrNameLabel.Location = new Point(26, 188);
            EnterNewMbrNameLabel.Name = "EnterNewMbrNameLabel";
            EnterNewMbrNameLabel.Size = new Size(86, 19);
            EnterNewMbrNameLabel.TabIndex = 8;
            EnterNewMbrNameLabel.Text = "Member ID: ";
            // 
            // NewDOBLabel
            // 
            NewDOBLabel.AutoSize = true;
            NewDOBLabel.Location = new Point(3, 240);
            NewDOBLabel.Name = "NewDOBLabel";
            NewDOBLabel.Size = new Size(184, 15);
            NewDOBLabel.TabIndex = 19;
            NewDOBLabel.Text = "Enter Member New Date of Birth: ";
            // 
            // NewAddr1Label
            // 
            NewAddr1Label.AutoSize = true;
            NewAddr1Label.Location = new Point(3, 74);
            NewAddr1Label.Name = "NewAddr1Label";
            NewAddr1Label.Size = new Size(169, 15);
            NewAddr1Label.TabIndex = 8;
            NewAddr1Label.Text = "Enter Member New Address 1: ";
            // 
            // UpdateMemberButton
            // 
            UpdateMemberButton.FlatStyle = FlatStyle.Popup;
            UpdateMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMemberButton.Location = new Point(508, 2);
            UpdateMemberButton.Margin = new Padding(3, 2, 3, 2);
            UpdateMemberButton.Name = "UpdateMemberButton";
            UpdateMemberButton.Size = new Size(225, 20);
            UpdateMemberButton.TabIndex = 5;
            UpdateMemberButton.Text = "Update Member";
            UpdateMemberButton.UseVisualStyleBackColor = true;
            // 
            // NewFNameLabel
            // 
            NewFNameLabel.AutoSize = true;
            NewFNameLabel.Location = new Point(3, 0);
            NewFNameLabel.Name = "NewFNameLabel";
            NewFNameLabel.Size = new Size(175, 15);
            NewFNameLabel.TabIndex = 2;
            NewFNameLabel.Text = "Enter Member New First Name: ";
            // 
            // NewPhoneLabel
            // 
            NewPhoneLabel.AutoSize = true;
            NewPhoneLabel.Location = new Point(3, 48);
            NewPhoneLabel.Name = "NewPhoneLabel";
            NewPhoneLabel.Size = new Size(199, 15);
            NewPhoneLabel.TabIndex = 3;
            NewPhoneLabel.Text = "Enter Member New Phone Number: ";
            // 
            // NewLNameLabel
            // 
            NewLNameLabel.AutoSize = true;
            NewLNameLabel.Location = new Point(3, 24);
            NewLNameLabel.Name = "NewLNameLabel";
            NewLNameLabel.Size = new Size(174, 15);
            NewLNameLabel.TabIndex = 1;
            NewLNameLabel.Text = "Enter Member New Last Name: ";
            // 
            // MbrNewLNameTextBox
            // 
            MbrNewLNameTextBox.Location = new Point(221, 26);
            MbrNewLNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrNewLNameTextBox.Name = "MbrNewLNameTextBox";
            MbrNewLNameTextBox.Size = new Size(246, 23);
            MbrNewLNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 129);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 9;
            label2.Text = "Enter Member New City ";
            // 
            // EnterMbrIDlabel
            // 
            EnterMbrIDlabel.AutoSize = true;
            EnterMbrIDlabel.Location = new Point(3, 0);
            EnterMbrIDlabel.Name = "EnterMbrIDlabel";
            EnterMbrIDlabel.Size = new Size(102, 15);
            EnterMbrIDlabel.TabIndex = 0;
            EnterMbrIDlabel.Text = "Enter Member ID: ";
            // 
            // EnterMbrLNameLabel
            // 
            EnterMbrLNameLabel.AutoSize = true;
            EnterMbrLNameLabel.Location = new Point(3, 74);
            EnterMbrLNameLabel.Name = "EnterMbrLNameLabel";
            EnterMbrLNameLabel.Size = new Size(147, 15);
            EnterMbrLNameLabel.TabIndex = 1;
            EnterMbrLNameLabel.Text = "Enter Member Last Name: ";
            // 
            // NewAddr1TextBox
            // 
            NewAddr1TextBox.Location = new Point(221, 76);
            NewAddr1TextBox.Margin = new Padding(3, 2, 3, 2);
            NewAddr1TextBox.Name = "NewAddr1TextBox";
            NewAddr1TextBox.Size = new Size(246, 23);
            NewAddr1TextBox.TabIndex = 12;
            // 
            // FindMemberButton
            // 
            FindMemberButton.FlatStyle = FlatStyle.Popup;
            FindMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FindMemberButton.Location = new Point(508, 2);
            FindMemberButton.Margin = new Padding(3, 2, 3, 2);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(225, 20);
            FindMemberButton.TabIndex = 5;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            // 
            // MbrPhoneNumTextBox
            // 
            MbrPhoneNumTextBox.Location = new Point(220, 26);
            MbrPhoneNumTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrPhoneNumTextBox.Name = "MbrPhoneNumTextBox";
            MbrPhoneNumTextBox.Size = new Size(246, 23);
            MbrPhoneNumTextBox.TabIndex = 6;
            // 
            // NewAddr2TextBox
            // 
            NewAddr2TextBox.Location = new Point(221, 103);
            NewAddr2TextBox.Margin = new Padding(3, 2, 3, 2);
            NewAddr2TextBox.Name = "NewAddr2TextBox";
            NewAddr2TextBox.Size = new Size(246, 23);
            NewAddr2TextBox.TabIndex = 15;
            // 
            // NewCityTextBox
            // 
            NewCityTextBox.Location = new Point(221, 131);
            NewCityTextBox.Margin = new Padding(3, 2, 3, 2);
            NewCityTextBox.Name = "NewCityTextBox";
            NewCityTextBox.Size = new Size(246, 23);
            NewCityTextBox.TabIndex = 14;
            // 
            // NewZipTextBox
            // 
            NewZipTextBox.Location = new Point(221, 190);
            NewZipTextBox.Margin = new Padding(3, 2, 3, 2);
            NewZipTextBox.Name = "NewZipTextBox";
            NewZipTextBox.Size = new Size(246, 23);
            NewZipTextBox.TabIndex = 13;
            // 
            // NewStateComboBox
            // 
            NewStateComboBox.FormattingEnabled = true;
            NewStateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "AS", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            NewStateComboBox.Location = new Point(221, 163);
            NewStateComboBox.Margin = new Padding(3, 2, 3, 2);
            NewStateComboBox.Name = "NewStateComboBox";
            NewStateComboBox.Size = new Size(245, 23);
            NewStateComboBox.TabIndex = 16;
            // 
            // NewDOBTextBox
            // 
            NewDOBTextBox.Location = new Point(221, 242);
            NewDOBTextBox.Margin = new Padding(3, 2, 3, 2);
            NewDOBTextBox.Name = "NewDOBTextBox";
            NewDOBTextBox.Size = new Size(246, 23);
            NewDOBTextBox.TabIndex = 20;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "Female", "Male ", "Transgender", "Non-binary/non-conforming", "Prefer not to respond" });
            GenderComboBox.Location = new Point(221, 216);
            GenderComboBox.Margin = new Padding(3, 2, 3, 2);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(246, 23);
            GenderComboBox.TabIndex = 21;
            // 
            // EnterMbrFNameLabel
            // 
            EnterMbrFNameLabel.AutoSize = true;
            EnterMbrFNameLabel.Location = new Point(3, 48);
            EnterMbrFNameLabel.Name = "EnterMbrFNameLabel";
            EnterMbrFNameLabel.Size = new Size(148, 15);
            EnterMbrFNameLabel.TabIndex = 2;
            EnterMbrFNameLabel.Text = "Enter Member First Name: ";
            // 
            // EnterMbrPhoneNumLabel
            // 
            EnterMbrPhoneNumLabel.AutoSize = true;
            EnterMbrPhoneNumLabel.Location = new Point(3, 24);
            EnterMbrPhoneNumLabel.Name = "EnterMbrPhoneNumLabel";
            EnterMbrPhoneNumLabel.Size = new Size(172, 15);
            EnterMbrPhoneNumLabel.TabIndex = 3;
            EnterMbrPhoneNumLabel.Text = "Enter Member Phone Number: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel1.Controls.Add(FindMemberButton, 2, 0);
            tableLayoutPanel1.Controls.Add(MbrPhoneNumTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(EnterMbrIDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMbrLNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(EnterMbrFNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EnterMbrPhoneNumLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MbrIDTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(MbrFNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MbrLNameTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(26, 58);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(740, 106);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // MbrIDTextBox
            // 
            MbrIDTextBox.Location = new Point(220, 2);
            MbrIDTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrIDTextBox.Name = "MbrIDTextBox";
            MbrIDTextBox.Size = new Size(246, 23);
            MbrIDTextBox.TabIndex = 4;
            // 
            // MbrFNameTextBox
            // 
            MbrFNameTextBox.Location = new Point(220, 50);
            MbrFNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrFNameTextBox.Name = "MbrFNameTextBox";
            MbrFNameTextBox.Size = new Size(246, 23);
            MbrFNameTextBox.TabIndex = 7;
            // 
            // MbrLNameTextBox
            // 
            MbrLNameTextBox.Location = new Point(220, 76);
            MbrLNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrLNameTextBox.Name = "MbrLNameTextBox";
            MbrLNameTextBox.Size = new Size(246, 23);
            MbrLNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 101);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 11;
            label1.Text = "Enter Member New Address 2:";
            // 
            // NewStateLabel
            // 
            NewStateLabel.AutoSize = true;
            NewStateLabel.Location = new Point(3, 161);
            NewStateLabel.Name = "NewStateLabel";
            NewStateLabel.Size = new Size(144, 15);
            NewStateLabel.TabIndex = 10;
            NewStateLabel.Text = "Enter Member New State: ";
            // 
            // NewZipLabel
            // 
            NewZipLabel.AutoSize = true;
            NewZipLabel.Location = new Point(3, 188);
            NewZipLabel.Name = "NewZipLabel";
            NewZipLabel.Size = new Size(135, 15);
            NewZipLabel.TabIndex = 17;
            NewZipLabel.Text = "Enter Member New Zip: ";
            // 
            // NewGenderLabel
            // 
            NewGenderLabel.AutoSize = true;
            NewGenderLabel.Location = new Point(3, 214);
            NewGenderLabel.Name = "NewGenderLabel";
            NewGenderLabel.Size = new Size(156, 15);
            NewGenderLabel.TabIndex = 18;
            NewGenderLabel.Text = "Enter Member New Gender: ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 287F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel2.Controls.Add(NewDOBLabel, 0, 9);
            tableLayoutPanel2.Controls.Add(NewAddr1Label, 0, 3);
            tableLayoutPanel2.Controls.Add(UpdateMemberButton, 2, 0);
            tableLayoutPanel2.Controls.Add(NewFNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(NewPhoneLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(NewLNameLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(MbrNewFNameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(MbrNewLNameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(MbrNewPhoneNumTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 4);
            tableLayoutPanel2.Controls.Add(NewAddr1TextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(NewAddr2TextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(NewCityTextBox, 1, 5);
            tableLayoutPanel2.Controls.Add(NewStateLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(NewZipTextBox, 1, 7);
            tableLayoutPanel2.Controls.Add(NewStateComboBox, 1, 6);
            tableLayoutPanel2.Controls.Add(NewZipLabel, 0, 7);
            tableLayoutPanel2.Controls.Add(NewGenderLabel, 0, 8);
            tableLayoutPanel2.Controls.Add(NewDOBTextBox, 1, 9);
            tableLayoutPanel2.Controls.Add(GenderComboBox, 1, 8);
            tableLayoutPanel2.Location = new Point(24, 218);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel2.Size = new Size(740, 266);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // EditMemberInfoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchInstructionsLabel);
            Controls.Add(DisplayIDLabel);
            Controls.Add(EnterNewMbrNameLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditMemberInfoUserControl";
            Size = new Size(791, 500);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MbrNewFNameTextBox;
        private TextBox MbrNewPhoneNumTextBox;
        private Label SearchInstructionsLabel;
        private Label DisplayIDLabel;
        private Label EnterNewMbrNameLabel;
        private Label NewDOBLabel;
        private Label NewAddr1Label;
        private Button UpdateMemberButton;
        private Label NewFNameLabel;
        private Label NewPhoneLabel;
        private Label NewLNameLabel;
        private TextBox MbrNewLNameTextBox;
        private Label label2;
        private Label EnterMbrIDlabel;
        private Label EnterMbrLNameLabel;
        private TextBox NewAddr1TextBox;
        private Button FindMemberButton;
        private TextBox MbrPhoneNumTextBox;
        private TextBox NewAddr2TextBox;
        private TextBox NewCityTextBox;
        private TextBox NewZipTextBox;
        private ComboBox NewStateComboBox;
        private TextBox NewDOBTextBox;
        private ComboBox GenderComboBox;
        private Label EnterMbrFNameLabel;
        private Label EnterMbrPhoneNumLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox MbrIDTextBox;
        private TextBox MbrFNameTextBox;
        private TextBox MbrLNameTextBox;
        private Label label1;
        private Label NewStateLabel;
        private Label NewZipLabel;
        private Label NewGenderLabel;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
