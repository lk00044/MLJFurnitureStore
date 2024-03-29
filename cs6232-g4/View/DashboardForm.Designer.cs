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
            rentFurnitureUserControl1 = new UserControls.RentFurnitureUserControl();
            LogOutLinkLabel = new LinkLabel();
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
            UserNameLabel.Location = new Point(615, 9);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(81, 20);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "UserName:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(406, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(457, 9);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(160, 25);
            DisplayNameLabel.TabIndex = 3;
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Location = new Point(704, 9);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(88, 25);
            DisplayUserNameLabel.TabIndex = 4;
            // 
            // MainDBTabControl
            // 
            MainDBTabControl.Controls.Add(RegMbrTabPage);
            MainDBTabControl.Controls.Add(Search4MbrTabPage);
            MainDBTabControl.Controls.Add(EditMbrTabPage);
            MainDBTabControl.Controls.Add(MbrTransTabPage);
            MainDBTabControl.Dock = DockStyle.Bottom;
            MainDBTabControl.Location = new Point(0, 77);
            MainDBTabControl.Name = "MainDBTabControl";
            MainDBTabControl.SelectedIndex = 0;
            MainDBTabControl.Size = new Size(889, 716);
            MainDBTabControl.TabIndex = 5;
            MainDBTabControl.SelectedIndexChanged += MainDBTabControl_SelectedIndexChanged;
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Controls.Add(memberRegistrationUserControl);
            RegMbrTabPage.Location = new Point(4, 29);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3);
            RegMbrTabPage.Size = new Size(881, 683);
            RegMbrTabPage.TabIndex = 0;
            RegMbrTabPage.Text = "Member Registration";
            RegMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // memberRegistrationUserControl
            // 
            memberRegistrationUserControl.Location = new Point(3, 3);
            memberRegistrationUserControl.Margin = new Padding(3, 5, 3, 5);
            memberRegistrationUserControl.Name = "memberRegistrationUserControl";
            memberRegistrationUserControl.Size = new Size(875, 677);
            memberRegistrationUserControl.TabIndex = 6;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member1);
            Search4MbrTabPage.Location = new Point(4, 29);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3);
            Search4MbrTabPage.Size = new Size(192, 67);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Search";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // search4Member1
            // 
            search4Member1.Dock = DockStyle.Fill;
            search4Member1.Location = new Point(3, 3);
            search4Member1.Name = "search4Member1";
            search4Member1.Size = new Size(186, 61);
            search4Member1.TabIndex = 0;
            // 
            // EditMbrTabPage
            // 
            EditMbrTabPage.Controls.Add(editMemberInfoUserControl1);
            EditMbrTabPage.Location = new Point(4, 29);
            EditMbrTabPage.Name = "EditMbrTabPage";
            EditMbrTabPage.Size = new Size(881, 683);
            EditMbrTabPage.TabIndex = 2;
            EditMbrTabPage.Text = "Member Update";
            EditMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // editMemberInfoUserControl1
            // 
            editMemberInfoUserControl1.Location = new Point(0, 0);
            editMemberInfoUserControl1.Name = "editMemberInfoUserControl1";
            editMemberInfoUserControl1.Size = new Size(885, 684);
            editMemberInfoUserControl1.TabIndex = 0;
            // 
            // MbrTransTabPage
            // 
            MbrTransTabPage.Location = new Point(4, 29);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(192, 67);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // LogOutLinkLabel
            // 
            LogOutLinkLabel.AutoSize = true;
            LogOutLinkLabel.Location = new Point(806, 9);
            LogOutLinkLabel.Name = "LogOutLinkLabel";
            LogOutLinkLabel.Size = new Size(62, 20);
            LogOutLinkLabel.TabIndex = 6;
            LogOutLinkLabel.TabStop = true;
            LogOutLinkLabel.Text = "Log Out";
            LogOutLinkLabel.LinkClicked += LogOutLinkLabel_LinkClicked;
            // 
            // MbrTransTabPage
            // 
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl1);
            MbrTransTabPage.Location = new Point(4, 24);
            MbrTransTabPage.Margin = new Padding(3, 2, 3, 2);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(776, 509);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // rentFurnitureUserControl1
            // 
            rentFurnitureUserControl1.Location = new Point(0, 3);
            rentFurnitureUserControl1.Name = "rentFurnitureUserControl1";
            rentFurnitureUserControl1.Size = new Size(785, 465);
            rentFurnitureUserControl1.TabIndex = 6;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 793);
            Controls.Add(LogOutLinkLabel);
            Controls.Add(MainDBTabControl);
            Controls.Add(DisplayUserNameLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserNameLabel);
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
        private UserControls.RentFurnitureUserControl rentFurnitureUserControl1;
        private LinkLabel LogOutLinkLabel;
    }
}