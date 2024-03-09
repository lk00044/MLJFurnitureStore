namespace SearchForMember.UserControls
{
    partial class SearchForMember
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
            EnterMbrIDlabel = new Label();
            EnterMbrLNameLabel = new Label();
            EnterMbrFNameLabel = new Label();
            EnterMbrPhoneNumLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            FindMemberButton = new Button();
            PhoneNumTextBox = new TextBox();
            MbrIDtextBox = new TextBox();
            FNameTextBox = new TextBox();
            LNameTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            NewDOBLabel = new Label();
            NewAddr1Label = new Label();
            UpdateMemberButton = new Button();
            NewFNameLabel = new Label();
            NewPhoneLabel = new Label();
            NewLNameLabel = new Label();
            MbrNewFNameTextBox = new TextBox();
            MbrNewLNameTextBox = new TextBox();
            MbrNewPhoneNumTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NewAddr1TextBox = new TextBox();
            NewAddr2TextBox = new TextBox();
            NewCityTextBox = new TextBox();
            NewStateLabel = new Label();
            NewZipTextBox = new TextBox();
            NewStateComboBox = new ComboBox();
            NewZipLabel = new Label();
            NewGenderLabel = new Label();
            NewGenderTextBox = new TextBox();
            NewDOBTextBox = new TextBox();
            EnterNewMbrNameLabel = new Label();
            DisplayIDLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // EnterMbrIDlabel
            // 
            EnterMbrIDlabel.AutoSize = true;
            EnterMbrIDlabel.Location = new Point(3, 0);
            EnterMbrIDlabel.Name = "EnterMbrIDlabel";
            EnterMbrIDlabel.Size = new Size(129, 20);
            EnterMbrIDlabel.TabIndex = 0;
            EnterMbrIDlabel.Text = "Enter Member ID: ";
            // 
            // EnterMbrLNameLabel
            // 
            EnterMbrLNameLabel.AutoSize = true;
            EnterMbrLNameLabel.Location = new Point(3, 98);
            EnterMbrLNameLabel.Name = "EnterMbrLNameLabel";
            EnterMbrLNameLabel.Size = new Size(184, 20);
            EnterMbrLNameLabel.TabIndex = 1;
            EnterMbrLNameLabel.Text = "Enter Member Last Name: ";
            // 
            // EnterMbrFNameLabel
            // 
            EnterMbrFNameLabel.AutoSize = true;
            EnterMbrFNameLabel.Location = new Point(3, 64);
            EnterMbrFNameLabel.Name = "EnterMbrFNameLabel";
            EnterMbrFNameLabel.Size = new Size(185, 20);
            EnterMbrFNameLabel.TabIndex = 2;
            EnterMbrFNameLabel.Text = "Enter Member First Name: ";
            // 
            // EnterMbrPhoneNumLabel
            // 
            EnterMbrPhoneNumLabel.AutoSize = true;
            EnterMbrPhoneNumLabel.Location = new Point(3, 32);
            EnterMbrPhoneNumLabel.Name = "EnterMbrPhoneNumLabel";
            EnterMbrPhoneNumLabel.Size = new Size(213, 20);
            EnterMbrPhoneNumLabel.TabIndex = 3;
            EnterMbrPhoneNumLabel.Text = "Enter Member Phone Number: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 329F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.Controls.Add(FindMemberButton, 2, 0);
            tableLayoutPanel1.Controls.Add(PhoneNumTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(EnterMbrIDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMbrLNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(EnterMbrFNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EnterMbrPhoneNumLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MbrIDtextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(FNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(LNameTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(23, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(846, 141);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // FindMemberButton
            // 
            FindMemberButton.Location = new Point(580, 3);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(257, 26);
            FindMemberButton.TabIndex = 5;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            // 
            // PhoneNumTextBox
            // 
            PhoneNumTextBox.Location = new Point(251, 35);
            PhoneNumTextBox.Name = "PhoneNumTextBox";
            PhoneNumTextBox.Size = new Size(280, 27);
            PhoneNumTextBox.TabIndex = 6;
            // 
            // MbrIDtextBox
            // 
            MbrIDtextBox.Location = new Point(251, 3);
            MbrIDtextBox.Name = "MbrIDtextBox";
            MbrIDtextBox.Size = new Size(280, 27);
            MbrIDtextBox.TabIndex = 4;
            // 
            // FNameTextBox
            // 
            FNameTextBox.Location = new Point(251, 67);
            FNameTextBox.Name = "FNameTextBox";
            FNameTextBox.Size = new Size(280, 27);
            FNameTextBox.TabIndex = 7;
            // 
            // LNameTextBox
            // 
            LNameTextBox.Location = new Point(251, 101);
            LNameTextBox.Name = "LNameTextBox";
            LNameTextBox.Size = new Size(280, 27);
            LNameTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 328F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
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
            tableLayoutPanel2.Controls.Add(NewGenderTextBox, 1, 8);
            tableLayoutPanel2.Controls.Add(NewDOBTextBox, 1, 9);
            tableLayoutPanel2.Location = new Point(24, 285);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(846, 354);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // NewDOBLabel
            // 
            NewDOBLabel.AutoSize = true;
            NewDOBLabel.Location = new Point(3, 318);
            NewDOBLabel.Name = "NewDOBLabel";
            NewDOBLabel.Size = new Size(233, 20);
            NewDOBLabel.TabIndex = 19;
            NewDOBLabel.Text = "Enter Member New Date of Birth: ";
            // 
            // NewAddr1Label
            // 
            NewAddr1Label.AutoSize = true;
            NewAddr1Label.Location = new Point(3, 98);
            NewAddr1Label.Name = "NewAddr1Label";
            NewAddr1Label.Size = new Size(213, 20);
            NewAddr1Label.TabIndex = 8;
            NewAddr1Label.Text = "Enter Member New Address 1: ";
            // 
            // UpdateMemberButton
            // 
            UpdateMemberButton.Location = new Point(580, 3);
            UpdateMemberButton.Name = "UpdateMemberButton";
            UpdateMemberButton.Size = new Size(257, 26);
            UpdateMemberButton.TabIndex = 5;
            UpdateMemberButton.Text = "Update Member";
            UpdateMemberButton.UseVisualStyleBackColor = true;
            // 
            // NewFNameLabel
            // 
            NewFNameLabel.AutoSize = true;
            NewFNameLabel.Location = new Point(3, 0);
            NewFNameLabel.Name = "NewFNameLabel";
            NewFNameLabel.Size = new Size(219, 20);
            NewFNameLabel.TabIndex = 2;
            NewFNameLabel.Text = "Enter Member New First Name: ";
            // 
            // NewPhoneLabel
            // 
            NewPhoneLabel.AutoSize = true;
            NewPhoneLabel.Location = new Point(3, 64);
            NewPhoneLabel.Name = "NewPhoneLabel";
            NewPhoneLabel.Size = new Size(243, 20);
            NewPhoneLabel.TabIndex = 3;
            NewPhoneLabel.Text = "Enter Member New Phone Number: ";
            // 
            // NewLNameLabel
            // 
            NewLNameLabel.AutoSize = true;
            NewLNameLabel.Location = new Point(3, 32);
            NewLNameLabel.Name = "NewLNameLabel";
            NewLNameLabel.Size = new Size(218, 20);
            NewLNameLabel.TabIndex = 1;
            NewLNameLabel.Text = "Enter Member New Last Name: ";
            // 
            // MbrNewFNameTextBox
            // 
            MbrNewFNameTextBox.Location = new Point(252, 3);
            MbrNewFNameTextBox.Name = "MbrNewFNameTextBox";
            MbrNewFNameTextBox.Size = new Size(280, 27);
            MbrNewFNameTextBox.TabIndex = 6;
            // 
            // MbrNewLNameTextBox
            // 
            MbrNewLNameTextBox.Location = new Point(252, 35);
            MbrNewLNameTextBox.Name = "MbrNewLNameTextBox";
            MbrNewLNameTextBox.Size = new Size(280, 27);
            MbrNewLNameTextBox.TabIndex = 7;
            // 
            // MbrNewPhoneNumTextBox
            // 
            MbrNewPhoneNumTextBox.Location = new Point(252, 67);
            MbrNewPhoneNumTextBox.Name = "MbrNewPhoneNumTextBox";
            MbrNewPhoneNumTextBox.Size = new Size(280, 27);
            MbrNewPhoneNumTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 171);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 9;
            label2.Text = "Enter Member New City ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 134);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 11;
            label1.Text = "Enter Member New Address 2:";
            // 
            // NewAddr1TextBox
            // 
            NewAddr1TextBox.Location = new Point(252, 101);
            NewAddr1TextBox.Name = "NewAddr1TextBox";
            NewAddr1TextBox.Size = new Size(280, 27);
            NewAddr1TextBox.TabIndex = 12;
            // 
            // NewAddr2TextBox
            // 
            NewAddr2TextBox.Location = new Point(252, 137);
            NewAddr2TextBox.Name = "NewAddr2TextBox";
            NewAddr2TextBox.Size = new Size(280, 27);
            NewAddr2TextBox.TabIndex = 15;
            // 
            // NewCityTextBox
            // 
            NewCityTextBox.Location = new Point(252, 174);
            NewCityTextBox.Name = "NewCityTextBox";
            NewCityTextBox.Size = new Size(280, 27);
            NewCityTextBox.TabIndex = 14;
            // 
            // NewStateLabel
            // 
            NewStateLabel.AutoSize = true;
            NewStateLabel.Location = new Point(3, 213);
            NewStateLabel.Name = "NewStateLabel";
            NewStateLabel.Size = new Size(182, 20);
            NewStateLabel.TabIndex = 10;
            NewStateLabel.Text = "Enter Member New State: ";
            // 
            // NewZipTextBox
            // 
            NewZipTextBox.Location = new Point(252, 252);
            NewZipTextBox.Name = "NewZipTextBox";
            NewZipTextBox.Size = new Size(280, 27);
            NewZipTextBox.TabIndex = 13;
            // 
            // NewStateComboBox
            // 
            NewStateComboBox.FormattingEnabled = true;
            NewStateComboBox.Location = new Point(252, 216);
            NewStateComboBox.Name = "NewStateComboBox";
            NewStateComboBox.Size = new Size(279, 28);
            NewStateComboBox.TabIndex = 16;
            // 
            // NewZipLabel
            // 
            NewZipLabel.AutoSize = true;
            NewZipLabel.Location = new Point(3, 249);
            NewZipLabel.Name = "NewZipLabel";
            NewZipLabel.Size = new Size(170, 20);
            NewZipLabel.TabIndex = 17;
            NewZipLabel.Text = "Enter Member New Zip: ";
            // 
            // NewGenderLabel
            // 
            NewGenderLabel.AutoSize = true;
            NewGenderLabel.Location = new Point(3, 283);
            NewGenderLabel.Name = "NewGenderLabel";
            NewGenderLabel.Size = new Size(196, 20);
            NewGenderLabel.TabIndex = 18;
            NewGenderLabel.Text = "Enter Member New Gender: ";
            // 
            // NewGenderTextBox
            // 
            NewGenderTextBox.Location = new Point(252, 286);
            NewGenderTextBox.Name = "NewGenderTextBox";
            NewGenderTextBox.Size = new Size(280, 27);
            NewGenderTextBox.TabIndex = 21;
            // 
            // NewDOBTextBox
            // 
            NewDOBTextBox.Location = new Point(252, 321);
            NewDOBTextBox.Name = "NewDOBTextBox";
            NewDOBTextBox.Size = new Size(280, 27);
            NewDOBTextBox.TabIndex = 20;
            // 
            // EnterNewMbrNameLabel
            // 
            EnterNewMbrNameLabel.AutoSize = true;
            EnterNewMbrNameLabel.Location = new Point(27, 246);
            EnterNewMbrNameLabel.Name = "EnterNewMbrNameLabel";
            EnterNewMbrNameLabel.Size = new Size(129, 20);
            EnterNewMbrNameLabel.TabIndex = 0;
            EnterNewMbrNameLabel.Text = "Enter Member ID: ";
            // 
            // DisplayIDLabel
            // 
            DisplayIDLabel.Location = new Point(176, 248);
            DisplayIDLabel.Name = "DisplayIDLabel";
            DisplayIDLabel.Size = new Size(163, 25);
            DisplayIDLabel.TabIndex = 6;
            // 
            // SearchForMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DisplayIDLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(EnterNewMbrNameLabel);
            Name = "SearchForMember";
            Size = new Size(895, 710);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EnterMbrIDlabel;
        private Label EnterMbrLNameLabel;
        private Label EnterMbrFNameLabel;
        private Label EnterMbrPhoneNumLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox PhoneNumTextBox;
        private TextBox MbrIDtextBox;
        private TextBox FNameTextBox;
        private TextBox LNameTextBox;
        private Button FindMemberButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button UpdateMemberButton;
        private Label NewFNameLabel;
        private Label NewPhoneLabel;
        private Label NewLNameLabel;
        private TextBox MbrNewFNameTextBox;
        private TextBox MbrNewLNameTextBox;
        private TextBox MbrNewPhoneNumTextBox;
        private Label EnterNewMbrNameLabel;
        private Label NewAddr1Label;
        private Label NewStateLabel;
        private Label label2;
        private Label label1;
        private TextBox NewAddr1TextBox;
        private TextBox NewAddr2TextBox;
        private TextBox NewCityTextBox;
        private TextBox NewZipTextBox;
        private ComboBox NewStateComboBox;
        private Label NewZipLabel;
        private Label DisplayIDLabel;
        private Label NewDOBLabel;
        private Label NewGenderLabel;
        private TextBox NewGenderTextBox;
        private TextBox NewDOBTextBox;
    }
}
