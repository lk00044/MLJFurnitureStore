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
            DashboardTabControl = new TabControl();
            RegMbrTabPage = new TabPage();
            UpdateMbrTabPage = new TabPage();
            SearchMbrTabPage = new TabPage();
            UserNameLabel = new Label();
            NameLabel = new Label();
            DisplayNameLabel = new Label();
            DisplayUserNameLabel = new Label();
            DashboardTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardTabControl
            // 
            DashboardTabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DashboardTabControl.Appearance = TabAppearance.FlatButtons;
            DashboardTabControl.Controls.Add(RegMbrTabPage);
            DashboardTabControl.Controls.Add(UpdateMbrTabPage);
            DashboardTabControl.Controls.Add(SearchMbrTabPage);
            DashboardTabControl.Location = new Point(1, 57);
            DashboardTabControl.Name = "DashboardTabControl";
            DashboardTabControl.SelectedIndex = 0;
            DashboardTabControl.Size = new Size(938, 558);
            DashboardTabControl.TabIndex = 0;
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Location = new Point(4, 32);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3);
            RegMbrTabPage.Size = new Size(930, 522);
            RegMbrTabPage.TabIndex = 0;
            RegMbrTabPage.Text = "Register Member";
            RegMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateMbrTabPage
            // 
            UpdateMbrTabPage.Location = new Point(4, 32);
            UpdateMbrTabPage.Name = "UpdateMbrTabPage";
            UpdateMbrTabPage.Padding = new Padding(3);
            UpdateMbrTabPage.Size = new Size(930, 522);
            UpdateMbrTabPage.TabIndex = 1;
            UpdateMbrTabPage.Text = "Update Member";
            UpdateMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchMbrTabPage
            // 
            SearchMbrTabPage.Location = new Point(4, 32);
            SearchMbrTabPage.Name = "SearchMbrTabPage";
            SearchMbrTabPage.Size = new Size(930, 522);
            SearchMbrTabPage.TabIndex = 2;
            SearchMbrTabPage.Text = "Search For Member";
            SearchMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(712, 9);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(81, 20);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "UserName:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(516, 8);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // DisplayNameLabel
            // 
            DisplayNameLabel.Location = new Point(574, 3);
            DisplayNameLabel.Name = "DisplayNameLabel";
            DisplayNameLabel.Size = new Size(132, 25);
            DisplayNameLabel.TabIndex = 3;
            // 
            // DisplayUserNameLabel
            // 
            DisplayUserNameLabel.Location = new Point(799, 8);
            DisplayUserNameLabel.Name = "DisplayUserNameLabel";
            DisplayUserNameLabel.Size = new Size(132, 25);
            DisplayUserNameLabel.TabIndex = 4;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 613);
            Controls.Add(DisplayUserNameLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(DashboardTabControl);
            Name = "DashboardForm";
            Text = "Rent Me Furniture Rentals";
            DashboardTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl DashboardTabControl;
        private TabPage RegMbrTabPage;
        private TabPage UpdateMbrTabPage;
        private TabPage SearchMbrTabPage;
        private Label UserNameLabel;
        private Label NameLabel;
        private Label DisplayNameLabel;
        private Label DisplayUserNameLabel;
    }
}