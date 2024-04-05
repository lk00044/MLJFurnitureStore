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
            MainDBTabControl.SuspendLayout();
            RegMbrTabPage.SuspendLayout();
            Search4MbrTabPage.SuspendLayout();
            EditMbrTabPage.SuspendLayout();
            MbrTransTabPage.SuspendLayout();
            SearchFurnitureTab.SuspendLayout();
            SearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).BeginInit();
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
            MainDBTabControl.Controls.Add(SearchFurnitureTab);
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
            EditMbrTabPage.Size = new Size(192, 67);
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
            MbrTransTabPage.Controls.Add(rentFurnitureUserControl1);
            MbrTransTabPage.Location = new Point(4, 29);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(192, 67);
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
            searchFurnitureUserControl.Dock = DockStyle.Fill;
            searchFurnitureUserControl.Location = new Point(3, 3);
            searchFurnitureUserControl.Name = "searchFurnitureUserControl";
            searchFurnitureUserControl.Size = new Size(875, 677);
            searchFurnitureUserControl.TabIndex = 1;
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
            SearchFurnitureTab.ResumeLayout(false);
            SearchTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).EndInit();
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
    }
}