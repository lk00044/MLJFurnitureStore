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
            ReturnHistBtn = new Button();
            MembersDataGridView = new DataGridView();
            ViewTransactionsButton = new Button();
            UpdateMbrButton = new Button();
            EnterMbrIDlabel = new Label();
            EnterMbrLNameLabel = new Label();
            EnterMbrFNameLabel = new Label();
            EnterMbrPhoneNumLabel = new Label();
            ErrorLabel = new Label();
            SearchInstructionsLabel = new Label();
            informationLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MembersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MatchingMembersLabel
            // 
            MatchingMembersLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MatchingMembersLabel.Location = new Point(3, 171);
            MatchingMembersLabel.Name = "MatchingMembersLabel";
            MatchingMembersLabel.Size = new Size(201, 21);
            MatchingMembersLabel.TabIndex = 12;
            MatchingMembersLabel.Text = "Matching Members:";
            // 
            // FindMemberButton
            // 
            FindMemberButton.FlatStyle = FlatStyle.Popup;
            FindMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FindMemberButton.Location = new Point(542, 3);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(287, 29);
            FindMemberButton.TabIndex = 4;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            FindMemberButton.Click += FindMemberButton_Click;
            // 
            // MbrPhoneNumTextBox
            // 
            MbrPhoneNumTextBox.Location = new Point(251, 38);
            MbrPhoneNumTextBox.Name = "MbrPhoneNumTextBox";
            MbrPhoneNumTextBox.Size = new Size(281, 27);
            MbrPhoneNumTextBox.TabIndex = 1;
            MbrPhoneNumTextBox.TextChanged += MbrPhoneNumTextBox_TextChanged;
            // 
            // MbrIDTextBox
            // 
            MbrIDTextBox.Location = new Point(251, 3);
            MbrIDTextBox.Name = "MbrIDTextBox";
            MbrIDTextBox.Size = new Size(281, 27);
            MbrIDTextBox.TabIndex = 0;
            MbrIDTextBox.TextChanged += MbrIDTextBox_TextChanged;
            // 
            // MbrFNameTextBox
            // 
            MbrFNameTextBox.Location = new Point(251, 75);
            MbrFNameTextBox.Name = "MbrFNameTextBox";
            MbrFNameTextBox.Size = new Size(281, 27);
            MbrFNameTextBox.TabIndex = 2;
            MbrFNameTextBox.TextChanged += MbrFNameTextBox_TextChanged;
            // 
            // MbrLNameTextBox
            // 
            MbrLNameTextBox.Location = new Point(251, 110);
            MbrLNameTextBox.Name = "MbrLNameTextBox";
            MbrLNameTextBox.Size = new Size(281, 27);
            MbrLNameTextBox.TabIndex = 3;
            MbrLNameTextBox.TextChanged += MbrLNameTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 291F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 299F));
            tableLayoutPanel1.Controls.Add(ReturnHistBtn, 2, 6);
            tableLayoutPanel1.Controls.Add(MembersDataGridView, 1, 7);
            tableLayoutPanel1.Controls.Add(ViewTransactionsButton, 2, 5);
            tableLayoutPanel1.Controls.Add(FindMemberButton, 2, 0);
            tableLayoutPanel1.Controls.Add(UpdateMbrButton, 2, 4);
            tableLayoutPanel1.Controls.Add(MbrPhoneNumTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(EnterMbrIDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMbrLNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(EnterMbrFNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EnterMbrPhoneNumLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MbrIDTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(MbrFNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MbrLNameTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(ErrorLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(MatchingMembersLabel, 0, 5);
            tableLayoutPanel1.Location = new Point(21, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(837, 538);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // ReturnHistBtn
            // 
            ReturnHistBtn.FlatStyle = FlatStyle.Popup;
            ReturnHistBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ReturnHistBtn.Location = new Point(542, 213);
            ReturnHistBtn.Name = "ReturnHistBtn";
            ReturnHistBtn.Size = new Size(287, 29);
            ReturnHistBtn.TabIndex = 17;
            ReturnHistBtn.Text = "View Return History";
            ReturnHistBtn.UseVisualStyleBackColor = true;
            ReturnHistBtn.Click += ReturnHistBtn_Click;
            // 
            // MembersDataGridView
            // 
            MembersDataGridView.AllowUserToAddRows = false;
            MembersDataGridView.AllowUserToDeleteRows = false;
            MembersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(MembersDataGridView, 3);
            MembersDataGridView.Dock = DockStyle.Fill;
            MembersDataGridView.Location = new Point(3, 260);
            MembersDataGridView.Name = "MembersDataGridView";
            MembersDataGridView.ReadOnly = true;
            MembersDataGridView.RowHeadersWidth = 51;
            MembersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersDataGridView.Size = new Size(832, 275);
            MembersDataGridView.TabIndex = 14;
            MembersDataGridView.CellClick += MembersDataGridView_CellClick;
            // 
            // ViewTransactionsButton
            // 
            ViewTransactionsButton.FlatStyle = FlatStyle.Popup;
            ViewTransactionsButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ViewTransactionsButton.Location = new Point(542, 174);
            ViewTransactionsButton.Name = "ViewTransactionsButton";
            ViewTransactionsButton.Size = new Size(287, 29);
            ViewTransactionsButton.TabIndex = 16;
            ViewTransactionsButton.Text = "View Transactions and Do Returns";
            ViewTransactionsButton.UseVisualStyleBackColor = true;
            ViewTransactionsButton.Click += ViewTransactionsButton_Click;
            // 
            // UpdateMbrButton
            // 
            UpdateMbrButton.FlatStyle = FlatStyle.Popup;
            UpdateMbrButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            UpdateMbrButton.Location = new Point(542, 138);
            UpdateMbrButton.Name = "UpdateMbrButton";
            UpdateMbrButton.Size = new Size(287, 29);
            UpdateMbrButton.TabIndex = 15;
            UpdateMbrButton.Text = "Update Selected Member";
            UpdateMbrButton.UseVisualStyleBackColor = true;
            UpdateMbrButton.Click += UpdateMbrButton_Click;
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
            EnterMbrLNameLabel.Location = new Point(3, 107);
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
            ErrorLabel.Location = new Point(542, 35);
            ErrorLabel.Name = "ErrorLabel";
            tableLayoutPanel1.SetRowSpan(ErrorLabel, 3);
            ErrorLabel.Size = new Size(287, 91);
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
            // informationLabel
            // 
            informationLabel.Location = new Point(13, 59);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(837, 27);
            informationLabel.TabIndex = 12;
            informationLabel.Text = "   Search for and then select the member. The Transactions Window opens. From there, you can do a member return.\r\n";
            // 
            // SearchForMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(informationLabel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SearchInstructionsLabel);
            Name = "SearchForMemberUserControl";
            Size = new Size(875, 657);
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
        private Button UpdateMbrButton;
        private Button ViewTransactionsButton;
        private Label informationLabel;
        private DataGridView MembersDataGridView;
        private Button ReturnHistBtn;
    }
}
