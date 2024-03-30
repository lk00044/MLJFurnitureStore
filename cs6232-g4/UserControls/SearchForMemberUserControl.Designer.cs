namespace cs6232_g4.UserControls
{
    partial class SearchForMemberUserControl
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
            ErrorLabel = new Label();
            SearchInstructionsLabel = new Label();
            MembersDataGridView = new DataGridView();
            UpdateMbrButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MembersDataGridView).BeginInit();
            SuspendLayout();
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
            FindMemberButton.Size = new Size(254, 29);
            FindMemberButton.TabIndex = 4;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            FindMemberButton.Click += FindMemberButton_Click;
            // 
            // MbrPhoneNumTextBox
            // 
            MbrPhoneNumTextBox.Location = new Point(251, 38);
            MbrPhoneNumTextBox.Name = "MbrPhoneNumTextBox";
            MbrPhoneNumTextBox.Size = new Size(280, 27);
            MbrPhoneNumTextBox.TabIndex = 1;
            MbrPhoneNumTextBox.TextChanged += MbrPhoneNumTextBox_Click;
            // 
            // MbrIDTextBox
            // 
            MbrIDTextBox.Location = new Point(251, 3);
            MbrIDTextBox.Name = "MbrIDTextBox";
            MbrIDTextBox.Size = new Size(280, 27);
            MbrIDTextBox.TabIndex = 0;
            MbrIDTextBox.TextChanged += MbrIDTextBox_Click;
            // 
            // MbrFNameTextBox
            // 
            MbrFNameTextBox.Location = new Point(251, 75);
            MbrFNameTextBox.Name = "MbrFNameTextBox";
            MbrFNameTextBox.Size = new Size(280, 27);
            MbrFNameTextBox.TabIndex = 2;
            MbrFNameTextBox.TextChanged += MbrFNameTextBox_Click;
            // 
            // MbrLNameTextBox
            // 
            MbrLNameTextBox.Location = new Point(251, 109);
            MbrLNameTextBox.Name = "MbrLNameTextBox";
            MbrLNameTextBox.Size = new Size(280, 27);
            MbrLNameTextBox.TabIndex = 3;
            MbrLNameTextBox.TextChanged += MbrLNameTextBox_Click;
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
            tableLayoutPanel1.Controls.Add(ErrorLabel, 2, 1);
            tableLayoutPanel1.Location = new Point(14, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
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
            EnterMbrLNameLabel.Location = new Point(3, 106);
            EnterMbrLNameLabel.Name = "EnterMbrLNameLabel";
            EnterMbrLNameLabel.Size = new Size(184, 20);
            EnterMbrLNameLabel.TabIndex = 1;
            EnterMbrLNameLabel.Text = "Enter Member Last Name: ";
            // 
            // EnterMbrFNameLabel
            // 
            EnterMbrFNameLabel.AutoSize = true;
            EnterMbrFNameLabel.Location = new Point(3, 72);
            EnterMbrFNameLabel.Name = "EnterMbrFNameLabel";
            EnterMbrFNameLabel.Size = new Size(185, 20);
            EnterMbrFNameLabel.TabIndex = 2;
            EnterMbrFNameLabel.Text = "Enter Member First Name: ";
            // 
            // EnterMbrPhoneNumLabel
            // 
            EnterMbrPhoneNumLabel.AutoSize = true;
            EnterMbrPhoneNumLabel.Location = new Point(3, 35);
            EnterMbrPhoneNumLabel.Name = "EnterMbrPhoneNumLabel";
            EnterMbrPhoneNumLabel.Size = new Size(213, 20);
            EnterMbrPhoneNumLabel.TabIndex = 3;
            EnterMbrPhoneNumLabel.Text = "Enter Member Phone Number: ";
            // 
            // ErrorLabel
            // 
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(580, 35);
            ErrorLabel.Name = "ErrorLabel";
            tableLayoutPanel1.SetRowSpan(ErrorLabel, 3);
            ErrorLabel.Size = new Size(254, 91);
            ErrorLabel.TabIndex = 5;
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
            // MembersDataGridView
            // 
            MembersDataGridView.AllowUserToAddRows = false;
            MembersDataGridView.AllowUserToDeleteRows = false;
            MembersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersDataGridView.Location = new Point(17, 254);
            MembersDataGridView.Name = "MembersDataGridView";
            MembersDataGridView.ReadOnly = true;
            MembersDataGridView.RowHeadersWidth = 51;
            MembersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersDataGridView.Size = new Size(834, 349);
            MembersDataGridView.TabIndex = 14;
            MembersDataGridView.CellClick += MembersDataGridView_CellClick;
            // 
            // UpdateMbrButton
            // 
            UpdateMbrButton.FlatStyle = FlatStyle.Popup;
            UpdateMbrButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateMbrButton.Location = new Point(594, 206);
            UpdateMbrButton.Name = "UpdateMbrButton";
            UpdateMbrButton.Size = new Size(254, 29);
            UpdateMbrButton.TabIndex = 15;
            UpdateMbrButton.Text = "Update Selected Member";
            UpdateMbrButton.UseVisualStyleBackColor = true;
            UpdateMbrButton.Click += UpdateMbrButton_Click;
            // 
            // SearchForMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UpdateMbrButton);
            Controls.Add(MembersDataGridView);
            Controls.Add(MatchingMembersLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SearchInstructionsLabel);
            Name = "SearchForMemberUserControl";
            Size = new Size(877, 687);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MembersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label ErrorLabel;
        private DataGridView MembersDataGridView;
        private Button UpdateMbrButton;
    }
}
