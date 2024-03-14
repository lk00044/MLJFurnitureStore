namespace Logon
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
            UserIDLabel = new Label();
            NameLabel = new Label();
            DisplayNameLabel = new Label();
            DisplayUserIDLabel = new Label();
            MainDBTabControl = new TabControl();
            RegMbrTabPage = new TabPage();
            Search4MbrTabPage = new TabPage();
            EditMbrTabPage = new TabPage();
            MbrTransTabPage = new TabPage();
            MainDBTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Location = new Point(712, 9);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(81, 20);
            UserIDLabel.TabIndex = 1;
            UserIDLabel.Text = "UserName:";
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
            // DisplayUserIDLabel
            // 
            DisplayUserIDLabel.Location = new Point(799, 8);
            DisplayUserIDLabel.Name = "DisplayUserIDLabel";
            DisplayUserIDLabel.Size = new Size(132, 25);
            DisplayUserIDLabel.TabIndex = 4;
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
            // 
            // RegMbrTabPage
            // 
            RegMbrTabPage.Location = new Point(4, 29);
            RegMbrTabPage.Name = "RegMbrTabPage";
            RegMbrTabPage.Padding = new Padding(3);
            RegMbrTabPage.Size = new Size(881, 683);
            RegMbrTabPage.TabIndex = 0;
            RegMbrTabPage.Text = "Member Registration";
            RegMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // Search4MbrTabPage
            // 
            Search4MbrTabPage.Location = new Point(4, 29);
            Search4MbrTabPage.Name = "Search4MbrTabPage";
            Search4MbrTabPage.Padding = new Padding(3);
            Search4MbrTabPage.Size = new Size(881, 683);
            Search4MbrTabPage.TabIndex = 1;
            Search4MbrTabPage.Text = "Member Search";
            Search4MbrTabPage.UseVisualStyleBackColor = true;
            // 
            // EditMbrTabPage
            // 
            EditMbrTabPage.Location = new Point(4, 29);
            EditMbrTabPage.Name = "EditMbrTabPage";
            EditMbrTabPage.Size = new Size(881, 683);
            EditMbrTabPage.TabIndex = 2;
            EditMbrTabPage.Text = "Member Update";
            EditMbrTabPage.UseVisualStyleBackColor = true;
            // 
            // MbrTransTabPage
            // 
            MbrTransTabPage.Location = new Point(4, 29);
            MbrTransTabPage.Name = "MbrTransTabPage";
            MbrTransTabPage.Size = new Size(881, 683);
            MbrTransTabPage.TabIndex = 3;
            MbrTransTabPage.Text = "Member Transactions";
            MbrTransTabPage.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 793);
            Controls.Add(MainDBTabControl);
            Controls.Add(DisplayUserIDLabel);
            Controls.Add(DisplayNameLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserIDLabel);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Me Furniture Rentals";
            Load += DashboardForm_Load;
            MainDBTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UserIDLabel;
        private Label NameLabel;
        private Label DisplayNameLabel;
        private Label DisplayUserIDLabel;
        private TabControl MainDBTabControl;
        private TabPage RegMbrTabPage;
        private TabPage Search4MbrTabPage;
        private TabPage EditMbrTabPage;
        private TabPage MbrTransTabPage;
        private UserControls.SearchForMemberUserControl search4Member1;
    }
}