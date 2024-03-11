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
            MbrPhoneNumTextBox = new TextBox();
            MbrIDTextBox = new TextBox();
            MbrFNameTextBox = new TextBox();
            MbrLNameTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            NewDOBLabel = new Label();
            NewAddr1Label = new Label();
            NewFNameLabel = new Label();
            NewPhoneLabel = new Label();
            NewLNameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            NewStateLabel = new Label();
            NewZipLabel = new Label();
            NewGenderLabel = new Label();
            EnterNewMbrNameLabel = new Label();
            DisplayIDLabel = new Label();
            SearchInstructionsLabel = new Label();
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
            tableLayoutPanel1.Controls.Add(MbrPhoneNumTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(EnterMbrIDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMbrLNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(EnterMbrFNameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EnterMbrPhoneNumLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MbrIDTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(MbrFNameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MbrLNameTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(27, 72);
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
            FindMemberButton.FlatStyle = FlatStyle.Popup;
            FindMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FindMemberButton.Location = new Point(580, 3);
            FindMemberButton.Name = "FindMemberButton";
            FindMemberButton.Size = new Size(257, 26);
            FindMemberButton.TabIndex = 5;
            FindMemberButton.Text = "Find Member";
            FindMemberButton.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 328F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel2.Controls.Add(NewDOBLabel, 0, 9);
            tableLayoutPanel2.Controls.Add(NewAddr1Label, 0, 3);
            tableLayoutPanel2.Controls.Add(NewFNameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(NewPhoneLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(NewLNameLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 4);
            tableLayoutPanel2.Controls.Add(NewStateLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(NewZipLabel, 0, 7);
            tableLayoutPanel2.Controls.Add(NewGenderLabel, 0, 8);
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
            NewDOBLabel.Size = new Size(161, 20);
            NewDOBLabel.TabIndex = 19;
            NewDOBLabel.Text = "Member Date of Birth: ";
            // 
            // NewAddr1Label
            // 
            NewAddr1Label.AutoSize = true;
            NewAddr1Label.Location = new Point(3, 98);
            NewAddr1Label.Name = "NewAddr1Label";
            NewAddr1Label.Size = new Size(141, 20);
            NewAddr1Label.TabIndex = 8;
            NewAddr1Label.Text = "Member Address 1: ";
            // 
            // NewFNameLabel
            // 
            NewFNameLabel.AutoSize = true;
            NewFNameLabel.Location = new Point(3, 0);
            NewFNameLabel.Name = "NewFNameLabel";
            NewFNameLabel.Size = new Size(147, 20);
            NewFNameLabel.TabIndex = 2;
            NewFNameLabel.Text = "Member First Name: ";
            // 
            // NewPhoneLabel
            // 
            NewPhoneLabel.AutoSize = true;
            NewPhoneLabel.Location = new Point(3, 64);
            NewPhoneLabel.Name = "NewPhoneLabel";
            NewPhoneLabel.Size = new Size(175, 20);
            NewPhoneLabel.TabIndex = 3;
            NewPhoneLabel.Text = "Member Phone Number: ";
            // 
            // NewLNameLabel
            // 
            NewLNameLabel.AutoSize = true;
            NewLNameLabel.Location = new Point(3, 32);
            NewLNameLabel.Name = "NewLNameLabel";
            NewLNameLabel.Size = new Size(146, 20);
            NewLNameLabel.TabIndex = 1;
            NewLNameLabel.Text = "Member Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 171);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 9;
            label2.Text = "Member City: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 134);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 11;
            label1.Text = "Member Address 2:";
            // 
            // NewStateLabel
            // 
            NewStateLabel.AutoSize = true;
            NewStateLabel.Location = new Point(3, 213);
            NewStateLabel.Name = "NewStateLabel";
            NewStateLabel.Size = new Size(110, 20);
            NewStateLabel.TabIndex = 10;
            NewStateLabel.Text = "Member State: ";
            // 
            // NewZipLabel
            // 
            NewZipLabel.AutoSize = true;
            NewZipLabel.Location = new Point(3, 249);
            NewZipLabel.Name = "NewZipLabel";
            NewZipLabel.Size = new Size(98, 20);
            NewZipLabel.TabIndex = 17;
            NewZipLabel.Text = "Member Zip: ";
            // 
            // NewGenderLabel
            // 
            NewGenderLabel.AutoSize = true;
            NewGenderLabel.Location = new Point(3, 283);
            NewGenderLabel.Name = "NewGenderLabel";
            NewGenderLabel.Size = new Size(124, 20);
            NewGenderLabel.TabIndex = 18;
            NewGenderLabel.Text = "Member Gender: ";
            // 
            // EnterNewMbrNameLabel
            // 
            EnterNewMbrNameLabel.AutoSize = true;
            EnterNewMbrNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterNewMbrNameLabel.Location = new Point(27, 246);
            EnterNewMbrNameLabel.Name = "EnterNewMbrNameLabel";
            EnterNewMbrNameLabel.Size = new Size(106, 23);
            EnterNewMbrNameLabel.TabIndex = 0;
            EnterNewMbrNameLabel.Text = "Member ID: ";
            // 
            // DisplayIDLabel
            // 
            DisplayIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayIDLabel.Location = new Point(176, 248);
            DisplayIDLabel.Name = "DisplayIDLabel";
            DisplayIDLabel.Size = new Size(163, 25);
            DisplayIDLabel.TabIndex = 6;
            // 
            // SearchInstructionsLabel
            // 
            SearchInstructionsLabel.AutoSize = true;
            SearchInstructionsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchInstructionsLabel.Location = new Point(30, 33);
            SearchInstructionsLabel.Name = "SearchInstructionsLabel";
            SearchInstructionsLabel.Size = new Size(596, 25);
            SearchInstructionsLabel.TabIndex = 7;
            SearchInstructionsLabel.Text = "Enter Member ID, Member Phone Number or Member First and Last Name.";
            // 
            // SearchForMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchInstructionsLabel);
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
        private TextBox MbrPhoneNumTextBox;
        private TextBox MbrIDTextBox;
        private TextBox MbrFNameTextBox;
        private TextBox MbrLNameTextBox;
        private Button FindMemberButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NewFNameLabel;
        private Label NewPhoneLabel;
        private Label NewLNameLabel;
        private Label EnterNewMbrNameLabel;
        private Label NewAddr1Label;
        private Label NewStateLabel;
        private Label label2;
        private Label label1;
        private Label NewZipLabel;
        private Label DisplayIDLabel;
        private Label NewDOBLabel;
        private Label NewGenderLabel;
        private Label SearchInstructionsLabel;
    }
}
