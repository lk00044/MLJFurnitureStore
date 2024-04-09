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
            MembersDataGridView = new DataGridView();
            ViewTransactionsButton = new Button();
            UpdateMbrButton = new Button();
            EnterMbrIDlabel = new Label();
            EnterMbrLNameLabel = new Label();
            EnterMbrFNameLabel = new Label();
            EnterMbrPhoneNumLabel = new Label();
            ErrorLabel = new Label();
            SearchInstructionsLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MembersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MatchingMembersLabel
            // 
            MatchingMembersLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MatchingMembersLabel.Location = new Point(3, 164);
            MatchingMembersLabel.Name = "MatchingMembersLabel";
            MatchingMembersLabel.Size = new Size(176, 16);
            MatchingMembersLabel.TabIndex = 12;
            MatchingMembersLabel.Text = "Matching Members:";
            // 
            // FindMemberButton
            // 
            FindMemberButton.FlatStyle = FlatStyle.Popup;
            FindMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FindMemberButton.Location = new Point(508, 2);
            FindMemberButton.Margin = new Padding(3, 2, 3, 2);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(222, 22);
            FindMemberButton.TabIndex = 4;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
            FindMemberButton.Click += FindMemberButton_Click;
            // 
            // MbrPhoneNumTextBox
            // 
            MbrPhoneNumTextBox.Location = new Point(220, 28);
            MbrPhoneNumTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrPhoneNumTextBox.Name = "MbrPhoneNumTextBox";
            MbrPhoneNumTextBox.Size = new Size(246, 23);
            MbrPhoneNumTextBox.TabIndex = 1;
            MbrPhoneNumTextBox.TextChanged += MbrPhoneNumTextBox_TextChanged;
            // 
            // MbrIDTextBox
            // 
            MbrIDTextBox.Location = new Point(220, 2);
            MbrIDTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrIDTextBox.Name = "MbrIDTextBox";
            MbrIDTextBox.Size = new Size(246, 23);
            MbrIDTextBox.TabIndex = 0;
            MbrIDTextBox.TextChanged += MbrIDTextBox_TextChanged;
            // 
            // MbrFNameTextBox
            // 
            MbrFNameTextBox.Location = new Point(220, 56);
            MbrFNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrFNameTextBox.Name = "MbrFNameTextBox";
            MbrFNameTextBox.Size = new Size(246, 23);
            MbrFNameTextBox.TabIndex = 2;
            MbrFNameTextBox.TextChanged += MbrFNameTextBox_TextChanged;
            // 
            // MbrLNameTextBox
            // 
            MbrLNameTextBox.Location = new Point(220, 82);
            MbrLNameTextBox.Margin = new Padding(3, 2, 3, 2);
            MbrLNameTextBox.Name = "MbrLNameTextBox";
            MbrLNameTextBox.Size = new Size(246, 23);
            MbrLNameTextBox.TabIndex = 3;
            MbrLNameTextBox.TextChanged += MbrLNameTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
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
            tableLayoutPanel1.Controls.Add(MatchingMembersLabel, 0, 7);
            tableLayoutPanel1.Location = new Point(12, 38);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(732, 424);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // MembersDataGridView
            // 
            MembersDataGridView.AllowUserToAddRows = false;
            MembersDataGridView.AllowUserToDeleteRows = false;
            MembersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(MembersDataGridView, 3);
            MembersDataGridView.Location = new Point(3, 182);
            MembersDataGridView.Margin = new Padding(3, 2, 3, 2);
            MembersDataGridView.Name = "MembersDataGridView";
            MembersDataGridView.ReadOnly = true;
            MembersDataGridView.RowHeadersWidth = 51;
            MembersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersDataGridView.Size = new Size(727, 236);
            MembersDataGridView.TabIndex = 14;
            MembersDataGridView.CellClick += MembersDataGridView_CellClick;
            // 
            // ViewTransactionsButton
            // 
            ViewTransactionsButton.FlatStyle = FlatStyle.Popup;
            ViewTransactionsButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ViewTransactionsButton.Location = new Point(508, 130);
            ViewTransactionsButton.Margin = new Padding(3, 2, 3, 2);
            ViewTransactionsButton.Name = "ViewTransactionsButton";
            ViewTransactionsButton.Size = new Size(222, 22);
            ViewTransactionsButton.TabIndex = 16;
            ViewTransactionsButton.Text = "View Member Transactions";
            ViewTransactionsButton.UseVisualStyleBackColor = true;
            ViewTransactionsButton.Click += ViewTransactionsButton_Click;
            // 
            // UpdateMbrButton
            // 
            UpdateMbrButton.FlatStyle = FlatStyle.Popup;
            UpdateMbrButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            UpdateMbrButton.Location = new Point(508, 103);
            UpdateMbrButton.Margin = new Padding(3, 2, 3, 2);
            UpdateMbrButton.Name = "UpdateMbrButton";
            UpdateMbrButton.Size = new Size(222, 22);
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
            EnterMbrIDlabel.Size = new Size(102, 15);
            EnterMbrIDlabel.TabIndex = 0;
            EnterMbrIDlabel.Text = "Enter Member ID: ";
            // 
            // EnterMbrLNameLabel
            // 
            EnterMbrLNameLabel.AutoSize = true;
            EnterMbrLNameLabel.Location = new Point(3, 80);
            EnterMbrLNameLabel.Name = "EnterMbrLNameLabel";
            EnterMbrLNameLabel.Size = new Size(147, 15);
            EnterMbrLNameLabel.TabIndex = 1;
            EnterMbrLNameLabel.Text = "Enter Member Last Name: ";
            // 
            // EnterMbrFNameLabel
            // 
            EnterMbrFNameLabel.AutoSize = true;
            EnterMbrFNameLabel.Location = new Point(3, 54);
            EnterMbrFNameLabel.Name = "EnterMbrFNameLabel";
            EnterMbrFNameLabel.Size = new Size(148, 15);
            EnterMbrFNameLabel.TabIndex = 2;
            EnterMbrFNameLabel.Text = "Enter Member First Name: ";
            // 
            // EnterMbrPhoneNumLabel
            // 
            EnterMbrPhoneNumLabel.AutoSize = true;
            EnterMbrPhoneNumLabel.Location = new Point(3, 26);
            EnterMbrPhoneNumLabel.Name = "EnterMbrPhoneNumLabel";
            EnterMbrPhoneNumLabel.Size = new Size(172, 15);
            EnterMbrPhoneNumLabel.TabIndex = 3;
            EnterMbrPhoneNumLabel.Text = "Enter Member Phone Number: ";
            // 
            // ErrorLabel
            // 
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(508, 26);
            ErrorLabel.Name = "ErrorLabel";
            tableLayoutPanel1.SetRowSpan(ErrorLabel, 3);
            ErrorLabel.Size = new Size(222, 68);
            ErrorLabel.TabIndex = 5;
            // 
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(11, 10);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(522, 20);
            SearchInstructionsLabel.TabIndex = 11;
            SearchInstructionsLabel.Text = "Enter Member ID, Member Phone Number or Member First and Last Name.";
            // 
            // SearchForMemberUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SearchInstructionsLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchForMemberUserControl";
            Size = new Size(767, 479);
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
        private Button ViewTransactionsButton;
    }
}
