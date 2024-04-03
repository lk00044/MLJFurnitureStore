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
            rentFurnitureUserControl1 = new UserControls.RentFurnitureUserControl();
            Search4MbrTabPage = new TabPage();
            search4Member1 = new UserControls.SearchForMemberUserControl();
            RegMbrTabPage = new TabPage();
            memberRegistrationUserControl = new UserControls.MemberRegistrationUserControl();
            MainDBTabControl = new TabControl();
            ViewMbrTransHistTabPage = new TabPage();
            viewMbrTransactionHistory1 = new UserControls.ViewMbrTransactionHistory();
            MbrTransTabPage.SuspendLayout();
            Search4MbrTabPage.SuspendLayout();
            RegMbrTabPage.SuspendLayout();
            MainDBTabControl.SuspendLayout();
            ViewMbrTransHistTabPage.SuspendLayout();
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
            // MbrTransTabPage
            // 
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl1);
            MbrTransTabPage.Location = new Point(4, 30);
            MbrTransTabPage.Margin = new Padding(3, 2, 3, 2);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(770, 503);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // rentFurnitureUserControl1
            // 
            rentFurnitureUserControl1.Location = new Point(0, 5);
            rentFurnitureUserControl1.Margin = new Padding(3, 4, 3, 4);
            rentFurnitureUserControl1.Name = "rentFurnitureUserControl1";
            rentFurnitureUserControl1.Size = new Size(774, 501);
            rentFurnitureUserControl1.TabIndex = 0;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member1);
            Search4MbrTabPage.Location = new Point(4, 30);
            Search4MbrTabPage.Margin = new Padding(3, 2, 3, 2);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3, 2, 3, 2);
            Search4MbrTabPage.Size = new Size(770, 503);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Search & Update";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // search4Member1
            // 
            search4Member1.Dock = DockStyle.Fill;
            search4Member1.Location = new Point(3, 2);
            search4Member1.Margin = new Padding(3, 2, 3, 2);
            search4Member1.Name = "search4Member1";
            search4Member1.Size = new Size(764, 499);
            search4Member1.TabIndex = 0;
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Controls.Add(memberRegistrationUserControl);
            RegMbrTabPage.Location = new Point(4, 30);
            RegMbrTabPage.Margin = new Padding(3, 2, 3, 2);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3, 2, 3, 2);
            RegMbrTabPage.Size = new Size(770, 503);
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
            // MainDBTabControl
            // 
            MainDBTabControl.Controls.Add(RegMbrTabPage);
            MainDBTabControl.Controls.Add(Search4MbrTabPage);
            MainDBTabControl.Controls.Add(MbrTransTabPage);
            MainDBTabControl.Controls.Add(ViewMbrTransHistTabPage);
            MainDBTabControl.Dock = DockStyle.Bottom;
            MainDBTabControl.Location = new Point(0, 58);
            MainDBTabControl.Margin = new Padding(3, 2, 3, 2);
            MainDBTabControl.Name = "MainDBTabControl";
            MainDBTabControl.Padding = new Point(6, 6);
            MainDBTabControl.SelectedIndex = 0;
            MainDBTabControl.Size = new Size(778, 537);
            MainDBTabControl.TabIndex = 5;
            MainDBTabControl.SelectedIndexChanged += MainDBTabControl_SelectedIndexChanged;
            // 
            // ViewMbrTransHistTabPage
            // 
            ViewMbrTransHistTabPage.Controls.Add(viewMbrTransactionHistory1);
            ViewMbrTransHistTabPage.Location = new Point(4, 30);
            ViewMbrTransHistTabPage.Margin = new Padding(3, 2, 3, 2);
            ViewMbrTransHistTabPage.Name = "ViewMbrTransHistTabPage";
            ViewMbrTransHistTabPage.Padding = new Padding(3, 2, 3, 2);
            ViewMbrTransHistTabPage.Size = new Size(770, 503);
            ViewMbrTransHistTabPage.TabIndex = 4;
            ViewMbrTransHistTabPage.Text = "View Member Transaction History";
            ViewMbrTransHistTabPage.UseVisualStyleBackColor = true;
            // 
            // viewMbrTransactionHistory1
            // 
            viewMbrTransactionHistory1.Dock = DockStyle.Top;
            viewMbrTransactionHistory1.Location = new Point(3, 2);
            viewMbrTransactionHistory1.Margin = new Padding(3, 2, 3, 2);
            viewMbrTransactionHistory1.Name = "viewMbrTransactionHistory1";
            viewMbrTransactionHistory1.Size = new Size(764, 586);
            viewMbrTransactionHistory1.TabIndex = 0;
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
            FormClosing += DashboardForm_FormClosing;
            Load += DashboardForm_Load;
            MbrTransTabPage.ResumeLayout(false);
            Search4MbrTabPage.ResumeLayout(false);
            RegMbrTabPage.ResumeLayout(false);
            MainDBTabControl.ResumeLayout(false);
            ViewMbrTransHistTabPage.ResumeLayout(false);
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
        private UserControls.RentFurnitureUserControl rentFurnitureUserControl1;
        private TabPage Search4MbrTabPage;
        private UserControls.SearchForMemberUserControl search4Member1;
        private TabPage RegMbrTabPage;
        private UserControls.MemberRegistrationUserControl memberRegistrationUserControl;
        private TabControl MainDBTabControl;
        private TabPage ViewMbrTransHistTabPage;
        private UserControls.ViewMbrTransactionHistory viewMbrTransactionHistory1;
    }
}