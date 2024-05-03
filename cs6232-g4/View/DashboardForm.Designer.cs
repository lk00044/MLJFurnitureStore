using cs6232_g4.UserControls;

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
            SearchFurnitureTab = new TabPage();
            searchFurnitureUserControl = new UserControls.SearchFurnitureUserControl();
            LogOutLinkLabel = new LinkLabel();
            SearchTableLayoutPanel = new TableLayoutPanel();
            SearchFurnitureDataGridView = new DataGridView();
            RentalIDText = new DataGridViewTextBoxColumn();
            FurnitureGridText = new DataGridViewTextBoxColumn();
            CategoryGridText = new DataGridViewTextBoxColumn();
            StyleGridText = new DataGridViewTextBoxColumn();
            QuantityGridText = new DataGridViewTextBoxColumn();
            InfoGridText = new DataGridViewTextBoxColumn();
            AvailableGridText = new DataGridViewTextBoxColumn();
            SearchLabel = new Label();
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
            SearchFurnitureTab.SuspendLayout();
            SearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).BeginInit();
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
            // SearchTableLayoutPanel
            // 
            SearchTableLayoutPanel.ColumnCount = 3;
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4276733F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5723267F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            SearchTableLayoutPanel.Controls.Add(SearchFurnitureDataGridView, 0, 7);
            SearchTableLayoutPanel.Location = new Point(0, 0);
            SearchTableLayoutPanel.Name = "SearchTableLayoutPanel";
            SearchTableLayoutPanel.RowCount = 8;
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            SearchTableLayoutPanel.Size = new Size(200, 100);
            SearchTableLayoutPanel.TabIndex = 0;
            // 
            // SearchFurnitureDataGridView
            // 
            SearchFurnitureDataGridView.AllowUserToAddRows = false;
            SearchFurnitureDataGridView.AllowUserToDeleteRows = false;
            SearchFurnitureDataGridView.AllowUserToResizeColumns = false;
            SearchFurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchFurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchFurnitureDataGridView.Columns.AddRange(new DataGridViewColumn[] { RentalIDText, FurnitureGridText, CategoryGridText, StyleGridText, QuantityGridText, InfoGridText, AvailableGridText });
            SearchTableLayoutPanel.SetColumnSpan(SearchFurnitureDataGridView, 3);
            SearchFurnitureDataGridView.Dock = DockStyle.Fill;
            SearchFurnitureDataGridView.Location = new Point(4, 144);
            SearchFurnitureDataGridView.Margin = new Padding(4);
            SearchFurnitureDataGridView.MultiSelect = false;
            SearchFurnitureDataGridView.Name = "SearchFurnitureDataGridView";
            SearchFurnitureDataGridView.ReadOnly = true;
            SearchFurnitureDataGridView.RowHeadersWidth = 51;
            SearchFurnitureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchFurnitureDataGridView.Size = new Size(193, 12);
            SearchFurnitureDataGridView.TabIndex = 2;
            // 
            // RentalIDText
            // 
            RentalIDText.HeaderText = "Rental ID";
            RentalIDText.MinimumWidth = 6;
            RentalIDText.Name = "RentalIDText";
            RentalIDText.ReadOnly = true;
            // 
            // FurnitureGridText
            // 
            FurnitureGridText.HeaderText = "Furniture";
            FurnitureGridText.MinimumWidth = 6;
            FurnitureGridText.Name = "FurnitureGridText";
            FurnitureGridText.ReadOnly = true;
            // 
            // CategoryGridText
            // 
            CategoryGridText.HeaderText = "Category";
            CategoryGridText.MinimumWidth = 6;
            CategoryGridText.Name = "CategoryGridText";
            CategoryGridText.ReadOnly = true;
            // 
            // StyleGridText
            // 
            StyleGridText.HeaderText = "Style";
            StyleGridText.MinimumWidth = 6;
            StyleGridText.Name = "StyleGridText";
            StyleGridText.ReadOnly = true;
            // 
            // QuantityGridText
            // 
            QuantityGridText.HeaderText = "Quantity";
            QuantityGridText.MinimumWidth = 6;
            QuantityGridText.Name = "QuantityGridText";
            QuantityGridText.ReadOnly = true;
            // 
            // InfoGridText
            // 
            InfoGridText.HeaderText = "Info/Description";
            InfoGridText.MinimumWidth = 6;
            InfoGridText.Name = "InfoGridText";
            InfoGridText.ReadOnly = true;
            // 
            // AvailableGridText
            // 
            AvailableGridText.HeaderText = "Availability";
            AvailableGridText.MinimumWidth = 6;
            AvailableGridText.Name = "AvailableGridText";
            AvailableGridText.ReadOnly = true;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchLabel.Location = new Point(3, 0);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(1, 1);
            SearchLabel.TabIndex = 3;
            SearchLabel.Text = "Search Furniture";
            // 
            // MbrTransTabPage
            // 
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl);
            MbrTransTabPage.Location = new Point(4, 35);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(881, 677);
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
            // SearchFurnitureTab
            // 
            SearchFurnitureTab.Controls.Add(searchFurnitureUserControl);
            SearchFurnitureTab.Dock = DockStyle.Fill;
            SearchFurnitureTab.Location = new Point(4, 29);
            SearchFurnitureTab.Name = "SearchFurnitureTab";
            SearchFurnitureTab.Padding = new Padding(3);
            SearchFurnitureTab.Size = new Size(881, 683);
            SearchFurnitureTab.TabIndex = 4;
            SearchFurnitureTab.Text = "Furniture Search";
            SearchFurnitureTab.UseVisualStyleBackColor = true;
            // 
            // searchFurnitureUserControl
            // 
            searchFurnitureUserControl.Dock = DockStyle.Top;
            searchFurnitureUserControl.Location = new Point(3, 3);
            searchFurnitureUserControl.Name = "searchFurnitureUserControl";
            searchFurnitureUserControl.Size = new Size(875, 677);
            searchFurnitureUserControl.TabIndex = 1;
            // 
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Controls.Add(search4Member);
            Search4MbrTabPage.Location = new Point(4, 35);
            Search4MbrTabPage.Margin = new Padding(3, 4, 3, 4);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3);
            Search4MbrTabPage.Size = new Size(881, 677);
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
            search4Member.Size = new Size(875, 671);
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
            MainDBTabControl.Controls.Add(SearchFurnitureTab);
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
            indexToolStripMenuItem.Click += IndexToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(124, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
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
            SearchFurnitureTab.ResumeLayout(false);
            SearchTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).EndInit();
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
        private TabPage SearchFurnitureTab;
        private UserControls.SearchFurnitureUserControl searchFurnitureUserControl;
        private TableLayoutPanel SearchTableLayoutPanel;
        private DataGridView SearchFurnitureDataGridView;
        private DataGridViewTextBoxColumn RentalIDText;
        private DataGridViewTextBoxColumn FurnitureGridText;
        private DataGridViewTextBoxColumn CategoryGridText;
        private DataGridViewTextBoxColumn StyleGridText;
        private DataGridViewTextBoxColumn QuantityGridText;
        private DataGridViewTextBoxColumn InfoGridText;
        private DataGridViewTextBoxColumn AvailableGridText;
        private Label SearchLabel;
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