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
            LogOutLinkLabel = new LinkLabel();
            MbrTransTabPage = new TabPage();
            rentFurnitureUserControl = new UserControls.RentFurnitureUserControl();
            Search4MbrTabPage = new TabPage();
            search4Member = new UserControls.SearchForMemberUserControl();
            RegMbrTabPage = new TabPage();
            memberRegistrationUserControl = new UserControls.MemberRegistrationUserControl();
            MainDBTabControl = new TabControl();
            AdminReportTabPage = new TabPage();
            adminReportUserControl1 = new UserControls.AdminReportUserControl();
            mainMenuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            MbrTransTabPage.SuspendLayout();
            Search4MbrTabPage.SuspendLayout();
            RegMbrTabPage.SuspendLayout();
            MainDBTabControl.SuspendLayout();
            AdminReportTabPage.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(617, 28);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(81, 20);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "UserName:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(400, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(458, 28);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(160, 25);
            DisplayNameLabel.TabIndex = 3;
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Location = new Point(704, 28);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(88, 25);
            DisplayUserNameLabel.TabIndex = 4;
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
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl);
            MbrTransTabPage.Location = new Point(4, 35);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(192, 61);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Rental Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // rentFurnitureUserControl
            // 
            rentFurnitureUserControl.Location = new Point(0, 9);
            rentFurnitureUserControl.Margin = new Padding(3, 7, 3, 7);
            rentFurnitureUserControl.Name = "rentFurnitureUserControl";
            rentFurnitureUserControl.Size = new Size(1011, 891);
            rentFurnitureUserControl.TabIndex = 0;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member);
            Search4MbrTabPage.Location = new Point(4, 35);
            Search4MbrTabPage.Margin = new Padding(3, 4, 3, 4);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3);
            Search4MbrTabPage.Size = new Size(192, 61);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Transactions";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // search4Member
            // 
            search4Member.Dock = DockStyle.Fill;
            search4Member.Location = new Point(3, 3);
            search4Member.Margin = new Padding(3, 4, 3, 4);
            search4Member.Name = "search4Member";
            search4Member.Size = new Size(186, 55);
            search4Member.TabIndex = 0;
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Controls.Add(memberRegistrationUserControl);
            RegMbrTabPage.Location = new Point(4, 35);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3);
            RegMbrTabPage.Size = new Size(881, 677);
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
            memberRegistrationUserControl.TabIndex = 5;
            // 
            // MainDBTabControl
            // 
            MainDBTabControl.Controls.Add(RegMbrTabPage);
            MainDBTabControl.Controls.Add(Search4MbrTabPage);
            MainDBTabControl.Controls.Add(MbrTransTabPage);
            MainDBTabControl.Controls.Add(AdminReportTabPage);
            MainDBTabControl.Dock = DockStyle.Bottom;
            MainDBTabControl.Location = new Point(0, 77);
            MainDBTabControl.Name = "MainDBTabControl";
            MainDBTabControl.Padding = new Point(6, 6);
            MainDBTabControl.SelectedIndex = 0;
            MainDBTabControl.Size = new Size(889, 716);
            MainDBTabControl.TabIndex = 3;
            MainDBTabControl.SelectedIndexChanged += MainDBTabControl_SelectedIndexChanged;
            // 
            // AdminReportTabPage
            // 
            AdminReportTabPage.Controls.Add(adminReportUserControl1);
            AdminReportTabPage.Location = new Point(4, 35);
            AdminReportTabPage.Name = "AdminReportTabPage";
            AdminReportTabPage.Size = new Size(881, 677);
            AdminReportTabPage.TabIndex = 4;
            AdminReportTabPage.Text = "Admin Report";
            AdminReportTabPage.UseVisualStyleBackColor = true;
            // 
            // adminReportUserControl1
            // 
            adminReportUserControl1.Dock = DockStyle.Top;
            adminReportUserControl1.Location = new Point(0, 0);
            adminReportUserControl1.Name = "adminReportUserControl1";
            adminReportUserControl1.Size = new Size(881, 789);
            adminReportUserControl1.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(889, 28);
            mainMenuStrip.TabIndex = 7;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { indexToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(124, 26);
            indexToolStripMenuItem.Text = "Help";
            indexToolStripMenuItem.Click += indexToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(124, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Me Furniture Rentals";
            Load += DashboardForm_Load;
            MbrTransTabPage.ResumeLayout(false);
            Search4MbrTabPage.ResumeLayout(false);
            RegMbrTabPage.ResumeLayout(false);
            MainDBTabControl.ResumeLayout(false);
            AdminReportTabPage.ResumeLayout(false);
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UserNameLabel;
        private Label NameLabel;
        private Label DisplayNameLabel;
        private Label DisplayUserNameLabel;
        private LinkLabel LogOutLinkLabel;
        private TabPage MbrTransTabPage;
        private UserControls.RentFurnitureUserControl rentFurnitureUserControl;
        private TabPage Search4MbrTabPage;
        private UserControls.SearchForMemberUserControl search4Member;
        private TabPage RegMbrTabPage;
        private UserControls.MemberRegistrationUserControl memberRegistrationUserControl;
        private TabControl MainDBTabControl;
        private TabPage AdminReportTabPage;
        private UserControls.AdminReportUserControl adminReportUserControl1;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}