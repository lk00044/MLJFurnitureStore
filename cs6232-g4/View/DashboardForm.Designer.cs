namespace cs6232_g4
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameLabel = new Label();
            NameLabel = new Label();
            DisplayNameLabel = new Label();
            DisplayUserNameLabel = new Label();
            MainDBTabControl = new TabControl();
            RegMbrTabPage = new TabPage();
            memberRegistrationUserControl = new UserControls.MemberRegistrationUserControl();
            Search4MbrTabPage = new TabPage();
            search4Member1 = new UserControls.SearchForMemberUserControl();
            EditMbrTabPage = new TabPage();
            editMemberInfoUserControl1 = new UserControls.EditMemberInfoUserControl();
            MbrTransTabPage = new TabPage();
            LogOutLinkLabel = new LinkLabel();
            rentFurnitureUserControl1 = new UserControls.RentFurnitureUserControl();
            MainDBTabControl.SuspendLayout();
            RegMbrTabPage.SuspendLayout();
            Search4MbrTabPage.SuspendLayout();
            EditMbrTabPage.SuspendLayout();
            MbrTransTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(538, 7);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(65, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "UserName:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(355, 7);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(400, 7);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(140, 19);
            DisplayNameLabel.TabIndex = 3;
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Location = new Point(616, 7);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(77, 19);
            DisplayUserNameLabel.TabIndex = 4;
            // 
            // MainDBTabControl
            // 
            MainDBTabControl.Controls.Add(RegMbrTabPage);
            MainDBTabControl.Controls.Add(Search4MbrTabPage);
            MainDBTabControl.Controls.Add(EditMbrTabPage);
            MainDBTabControl.Controls.Add(MbrTransTabPage);
            MainDBTabControl.Dock = DockStyle.Bottom;
            MainDBTabControl.Location = new Point(0, 58);
            MainDBTabControl.Margin = new Padding(3, 2, 3, 2);
            MainDBTabControl.Name = "MainDBTabControl";
            MainDBTabControl.SelectedIndex = 0;
            MainDBTabControl.Size = new Size(778, 537);
            MainDBTabControl.TabIndex = 5;
            MainDBTabControl.SelectedIndexChanged += MainDBTabControl_SelectedIndexChanged;
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Controls.Add(memberRegistrationUserControl);
            RegMbrTabPage.Location = new Point(4, 24);
            RegMbrTabPage.Margin = new Padding(3, 2, 3, 2);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3, 2, 3, 2);
            RegMbrTabPage.Size = new Size(770, 509);
            RegMbrTabPage.TabIndex = 0;
            RegMbrTabPage.Text = "Member Registration";
            RegMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // memberRegistrationUserControl
            // 
            memberRegistrationUserControl.Location = new Point(3, 2);
            memberRegistrationUserControl.Margin = new Padding(3, 4, 3, 4);
            memberRegistrationUserControl.Name = "memberRegistrationUserControl";
            memberRegistrationUserControl.Size = new Size(766, 508);
            memberRegistrationUserControl.TabIndex = 6;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member1);
            Search4MbrTabPage.Location = new Point(4, 24);
            Search4MbrTabPage.Margin = new Padding(3, 2, 3, 2);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3, 2, 3, 2);
            Search4MbrTabPage.Size = new Size(192, 72);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Search";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // search4Member1
            // 
            search4Member1.Dock = DockStyle.Fill;
            search4Member1.Location = new Point(3, 2);
            search4Member1.Margin = new Padding(3, 2, 3, 2);
            search4Member1.Name = "search4Member1";
            search4Member1.Size = new Size(186, 68);
            search4Member1.TabIndex = 0;
            // 
            // EditMbrTabPage
            // 
            EditMbrTabPage.Controls.Add(editMemberInfoUserControl1);
            EditMbrTabPage.Location = new Point(4, 24);
            EditMbrTabPage.Margin = new Padding(3, 2, 3, 2);
            EditMbrTabPage.Name = "EditMbrTabPage";
            EditMbrTabPage.Size = new Size(192, 72);
            EditMbrTabPage.TabIndex = 2;
            EditMbrTabPage.Text = "Member Update";
            EditMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // editMemberInfoUserControl1
            // 
            editMemberInfoUserControl1.Location = new Point(0, 0);
            editMemberInfoUserControl1.Margin = new Padding(3, 2, 3, 2);
            editMemberInfoUserControl1.Name = "editMemberInfoUserControl1";
            editMemberInfoUserControl1.Size = new Size(774, 513);
            editMemberInfoUserControl1.TabIndex = 0;
            // 
            // MbrTransTabPage
            // 
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl1);
            MbrTransTabPage.Location = new Point(4, 24);
            MbrTransTabPage.Margin = new Padding(3, 2, 3, 2);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(770, 509);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.AutoSize = true;
            LogOutLinkLabel.Location = new Point(705, 7);
            LogOutLinkLabel.Name = "LogOutLinkLabel";
            LogOutLinkLabel.Size = new Size(50, 15);
            LogOutLinkLabel.TabIndex = 6;
            LogOutLinkLabel.TabStop = true;
            LogOutLinkLabel.Text = "Log Out";
            LogOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
            // 
            // rentFurnitureUserControl1
            // 
            rentFurnitureUserControl1.Location = new Point(0, 5);
            rentFurnitureUserControl1.Name = "rentFurnitureUserControl1";
            rentFurnitureUserControl1.Size = new Size(774, 501);
            rentFurnitureUserControl1.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 595);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(MainDBTabControl);
            Controls.Add(DisplayUserNameLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Me Furniture Rentals";
            Load += DashboardForm_Load;
            MainDBTabControl.ResumeLayout(false);
            RegMbrTabPage.ResumeLayout(false);
            Search4MbrTabPage.ResumeLayout(false);
            EditMbrTabPage.ResumeLayout(false);
            MbrTransTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UserNameLabel;
        private Label NameLabel;
        private Label DisplayNameLabel;
        private Label DisplayUserNameLabel;
        private TabControl MainDBTabControl;
        private TabPage RegMbrTabPage;
        private TabPage Search4MbrTabPage;
        private TabPage EditMbrTabPage;
        private TabPage MbrTransTabPage;
        private UserControls.SearchForMemberUserControl search4Member1;
        private UserControls.MemberRegistrationUserControl memberRegistrationUserControl;
        private UserControls.EditMemberInfoUserControl editMemberInfoUserControl1;
        private LinkLabel LogOutLinkLabel;
        private UserControls.RentFurnitureUserControl rentFurnitureUserControl1;
    }
}