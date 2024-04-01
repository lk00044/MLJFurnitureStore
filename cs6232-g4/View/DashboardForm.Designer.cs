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
            MbrTransTabPage.Location = new Point(4, 35);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(881, 677);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // rentFurnitureUserControl1
            // 
            rentFurnitureUserControl1.Location = new Point(0, 7);
            rentFurnitureUserControl1.Margin = new Padding(3, 5, 3, 5);
            rentFurnitureUserControl1.Name = "rentFurnitureUserControl1";
            rentFurnitureUserControl1.Size = new Size(885, 668);
            rentFurnitureUserControl1.TabIndex = 0;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member1);
            Search4MbrTabPage.Location = new Point(4, 35);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3);
            Search4MbrTabPage.Size = new Size(881, 677);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Search & Update";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // search4Member1
            // 
            search4Member1.Dock = DockStyle.Fill;
            search4Member1.Location = new Point(3, 3);
            search4Member1.Name = "search4Member1";
            search4Member1.Size = new Size(875, 671);
            search4Member1.TabIndex = 0;
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
            memberRegistrationUserControl.TabIndex = 6;
            // 
            // MainDBTabControl
            // 
            MainDBTabControl.Controls.Add(RegMbrTabPage);
            MainDBTabControl.Controls.Add(Search4MbrTabPage);
            MainDBTabControl.Controls.Add(MbrTransTabPage);
            MainDBTabControl.Controls.Add(ViewMbrTransHistTabPage);
            MainDBTabControl.Dock = DockStyle.Bottom;
            MainDBTabControl.Location = new Point(0, 77);
            MainDBTabControl.Name = "MainDBTabControl";
            MainDBTabControl.Padding = new Point(6, 6);
            MainDBTabControl.SelectedIndex = 0;
            MainDBTabControl.Size = new Size(889, 716);
            MainDBTabControl.TabIndex = 5;
            MainDBTabControl.SelectedIndexChanged += MainDBTabControl_SelectedIndexChanged;
            // 
            // ViewMbrTransHistTabPage
            // 
            ViewMbrTransHistTabPage.Controls.Add(viewMbrTransactionHistory1);
            ViewMbrTransHistTabPage.Location = new Point(4, 35);
            ViewMbrTransHistTabPage.Name = "ViewMbrTransHistTabPage";
            ViewMbrTransHistTabPage.Padding = new Padding(3);
            ViewMbrTransHistTabPage.Size = new Size(881, 677);
            ViewMbrTransHistTabPage.TabIndex = 4;
            ViewMbrTransHistTabPage.Text = "View Member Transaction History";
            ViewMbrTransHistTabPage.UseVisualStyleBackColor = true;
            // 
            // viewMbrTransactionHistory1
            // 
            viewMbrTransactionHistory1.Dock = DockStyle.Top;
            viewMbrTransactionHistory1.Location = new Point(3, 3);
            viewMbrTransactionHistory1.Name = "viewMbrTransactionHistory1";
            viewMbrTransactionHistory1.Size = new Size(875, 782);
            viewMbrTransactionHistory1.TabIndex = 0;
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