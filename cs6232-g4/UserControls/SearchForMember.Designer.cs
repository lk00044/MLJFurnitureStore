namespace cs6232_g4.UserControls
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
            DOBColumnHeader = new ColumnHeader();
            ZipColumnHeader = new ColumnHeader();
            StateColumnHeader = new ColumnHeader();
            CityColumnHeader = new ColumnHeader();
            Addr2ColumnHeader = new ColumnHeader();
            Addr1ColumnHeader = new ColumnHeader();
            LNameColumnHeader = new ColumnHeader();
            MbrFNameColumnHeader = new ColumnHeader();
            MbrUDColumnHeader = new ColumnHeader();
            MatchingMembersListView = new ListView();
            GenderColumnHeader = new ColumnHeader();
            MatchingMembersLabel = new Label();
            FindMemberButton = new Button();
            MbrPhoneNumTextBox = new TextBox();
            MbrIDTextBox = new TextBox();
            MbrFNameTextBox = new TextBox();
            MbrLNameTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            EnterMbrIDlabel = new Label();
            EnterMbrLNameLabel = new Label();
            EnterMbrFNameLabel = new Label();
            EnterMbrPhoneNumLabel = new Label();
            SearchInstructionsLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DOBColumnHeader
            // 
            DOBColumnHeader.Text = "Date of Birth";
            DOBColumnHeader.Width = 100;
            // 
            // ZipColumnHeader
            // 
            ZipColumnHeader.Text = "Zip";
            // 
            // StateColumnHeader
            // 
            StateColumnHeader.Text = "State";
            // 
            // CityColumnHeader
            // 
            CityColumnHeader.Text = "City";
            CityColumnHeader.Width = 100;
            // 
            // Addr2ColumnHeader
            // 
            Addr2ColumnHeader.Text = "Address 2";
            Addr2ColumnHeader.Width = 120;
            // 
            // Addr1ColumnHeader
            // 
            Addr1ColumnHeader.Text = "Address 1";
            Addr1ColumnHeader.Width = 150;
            // 
            // LNameColumnHeader
            // 
            LNameColumnHeader.Text = "Last Name";
            LNameColumnHeader.Width = 120;
            // 
            // MbrFNameColumnHeader
            // 
            MbrFNameColumnHeader.Text = "First Name";
            MbrFNameColumnHeader.Width = 120;
            // 
            // MbrUDColumnHeader
            // 
            MbrUDColumnHeader.Text = "Member ID";
            MbrUDColumnHeader.Width = 120;
            // 
            // MatchingMembersListView
            // 
            MatchingMembersListView.Columns.AddRange(new ColumnHeader[] { MbrUDColumnHeader, MbrFNameColumnHeader, LNameColumnHeader, Addr1ColumnHeader, Addr2ColumnHeader, CityColumnHeader, StateColumnHeader, ZipColumnHeader, GenderColumnHeader, DOBColumnHeader });
            MatchingMembersListView.GridLines = true;
            MatchingMembersListView.Location = new Point(17, 250);
            MatchingMembersListView.Name = "MatchingMembersListView";
            MatchingMembersListView.Size = new Size(834, 418);
            MatchingMembersListView.TabIndex = 13;
            MatchingMembersListView.UseCompatibleStateImageBehavior = false;
            MatchingMembersListView.View = View.Details;
            // 
            // GenderColumnHeader
            // 
            GenderColumnHeader.Text = "Gender";
            // 
            // MatchingMembersLabel
            // 
            MatchingMembersLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MatchingMembersLabel.Location = new Point(17, 213);
            MatchingMembersLabel.Name = "MatchingMembersLabel";
            MatchingMembersLabel.Size = new Size(201, 25);
            MatchingMembersLabel.TabIndex = 12;
            MatchingMembersLabel.Text = "Matching Members:";
            // 
            // FindMemberButton
            // 
            FindMemberButton.FlatStyle = FlatStyle.Popup;
            FindMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FindMemberButton.Location = new Point(580, 3);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(254, 26);
            FindMemberButton.TabIndex = 5;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            FindMemberButton.Click += FindMemberButton_Click;
            // 
            // MbrPhoneNumTextBox
            // 
            MbrPhoneNumTextBox.Location = new Point(251, 35);
            MbrPhoneNumTextBox.Name = "MbrPhoneNumTextBox";
            MbrPhoneNumTextBox.Size = new Size(280, 27);
            MbrPhoneNumTextBox.TabIndex = 6;
            // 
            // MbrIDTextBox
            // 
            MbrIDTextBox.Location = new Point(251, 3);
            MbrIDTextBox.Name = "MbrIDTextBox";
            MbrIDTextBox.Size = new Size(280, 27);
            MbrIDTextBox.TabIndex = 4;
            // 
            // MbrFNameTextBox
            // 
            MbrFNameTextBox.Location = new Point(251, 67);
            MbrFNameTextBox.Name = "MbrFNameTextBox";
            MbrFNameTextBox.Size = new Size(280, 27);
            MbrFNameTextBox.TabIndex = 7;
            // 
            // MbrLNameTextBox
            // 
            MbrLNameTextBox.Location = new Point(251, 101);
            MbrLNameTextBox.Name = "MbrLNameTextBox";
            MbrLNameTextBox.Size = new Size(280, 27);
            MbrLNameTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 329F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.Controls.Add(FindMemberButton, 2, 0);
            tableLayoutPanel1.Controls.Add(MbrPhoneNumTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(EnterMbrIDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMbrLNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(EnterMbrFNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EnterMbrPhoneNumLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MbrIDTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(MbrFNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MbrLNameTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(14, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(837, 141);
            tableLayoutPanel1.TabIndex = 10;
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
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(13, 13);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(612, 25);
            SearchInstructionsLabel.TabIndex = 11;
            SearchInstructionsLabel.Text = "Enter Member ID, Member Phone Number or Member First and Last Name.";
            // 
            // SearchForMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MatchingMembersListView);
            Controls.Add(MatchingMembersLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SearchInstructionsLabel);
            Name = "SearchForMember";
            Size = new Size(877, 687);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColumnHeader DOBColumnHeader;
        private ColumnHeader ZipColumnHeader;
        private ColumnHeader StateColumnHeader;
        private ColumnHeader CityColumnHeader;
        private ColumnHeader Addr2ColumnHeader;
        private ColumnHeader Addr1ColumnHeader;
        private ColumnHeader LNameColumnHeader;
        private ColumnHeader MbrFNameColumnHeader;
        private ColumnHeader MbrUDColumnHeader;
        private ListView MatchingMembersListView;
        private ColumnHeader GenderColumnHeader;
        private Label MatchingMembersLabel;
        private Button FindMemberButton;
        private TextBox MbrPhoneNumTextBox;
        private TextBox MbrIDTextBox;
        private TextBox MbrFNameTextBox;
        private TextBox MbrLNameTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label EnterMbrIDlabel;
        private Label EnterMbrLNameLabel;
        private Label EnterMbrFNameLabel;
        private Label EnterMbrPhoneNumLabel;
        private Label SearchInstructionsLabel;
    }
}
