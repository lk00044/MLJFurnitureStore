namespace cs6232_g4.View
{
    partial class SearchFurnitureForm
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
            RentalIDLabel = new Label();
            RentalComboBox = new ComboBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            StyleLabel = new Label();
            StyleComboBox = new ComboBox();
            SearchBtn = new Button();
            CancelBtn = new Button();
            FurnitureInfoLabel = new Label();
            CloseBtn = new Button();
            UserLabel = new Label();
            LogoutLink = new LinkLabel();
            SearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTableLayoutPanel
            // 
            SearchTableLayoutPanel.ColumnCount = 3;
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4276733F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5723267F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 303F));
            SearchTableLayoutPanel.Controls.Add(SearchFurnitureDataGridView, 0, 7);
            SearchTableLayoutPanel.Controls.Add(SearchLabel, 0, 0);
            SearchTableLayoutPanel.Controls.Add(RentalIDLabel, 0, 1);
            SearchTableLayoutPanel.Controls.Add(RentalComboBox, 1, 1);
            SearchTableLayoutPanel.Controls.Add(CategoryLabel, 0, 2);
            SearchTableLayoutPanel.Controls.Add(CategoryComboBox, 1, 2);
            SearchTableLayoutPanel.Controls.Add(StyleLabel, 0, 3);
            SearchTableLayoutPanel.Controls.Add(StyleComboBox, 1, 3);
            SearchTableLayoutPanel.Controls.Add(SearchBtn, 0, 4);
            SearchTableLayoutPanel.Controls.Add(CancelBtn, 1, 4);
            SearchTableLayoutPanel.Controls.Add(FurnitureInfoLabel, 0, 5);
            SearchTableLayoutPanel.Controls.Add(UserLabel, 2, 0);
            SearchTableLayoutPanel.Controls.Add(CloseBtn, 2, 8);
            SearchTableLayoutPanel.Controls.Add(LogoutLink, 2, 1);
            SearchTableLayoutPanel.Dock = DockStyle.Fill;
            SearchTableLayoutPanel.Location = new Point(0, 0);
            SearchTableLayoutPanel.Name = "SearchTableLayoutPanel";
            SearchTableLayoutPanel.RowCount = 9;
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5517235F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4482765F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 197F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            SearchTableLayoutPanel.Size = new Size(908, 543);
            SearchTableLayoutPanel.TabIndex = 1;
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
            SearchFurnitureDataGridView.Location = new Point(4, 298);
            SearchFurnitureDataGridView.Margin = new Padding(4);
            SearchFurnitureDataGridView.MultiSelect = false;
            SearchFurnitureDataGridView.Name = "SearchFurnitureDataGridView";
            SearchFurnitureDataGridView.ReadOnly = true;
            SearchFurnitureDataGridView.RowHeadersWidth = 51;
            SearchFurnitureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchFurnitureDataGridView.Size = new Size(900, 189);
            SearchFurnitureDataGridView.TabIndex = 2;
            SearchFurnitureDataGridView.CellContentClick += SearchFurnitureDataGridView_CellContentClick;
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
            SearchLabel.Size = new Size(152, 25);
            SearchLabel.TabIndex = 3;
            SearchLabel.Text = "Search Furniture";
            SearchLabel.Click += label1_Click;
            // 
            // RentalIDLabel
            // 
            RentalIDLabel.AutoSize = true;
            RentalIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RentalIDLabel.Location = new Point(3, 36);
            RentalIDLabel.Name = "RentalIDLabel";
            RentalIDLabel.Size = new Size(73, 20);
            RentalIDLabel.TabIndex = 6;
            RentalIDLabel.Text = "Rental ID:";
            RentalIDLabel.Click += label1_Click_2;
            // 
            // RentalComboBox
            // 
            RentalComboBox.FormattingEnabled = true;
            RentalComboBox.Location = new Point(295, 39);
            RentalComboBox.Name = "RentalComboBox";
            RentalComboBox.Size = new Size(215, 28);
            RentalComboBox.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(3, 78);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 7;
            CategoryLabel.Text = "Category:";
            CategoryLabel.Click += label1_Click_3;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(295, 81);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(215, 28);
            CategoryComboBox.TabIndex = 8;
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StyleLabel.Location = new Point(3, 123);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(44, 20);
            StyleLabel.TabIndex = 9;
            StyleLabel.Text = "Style:";
            StyleLabel.Click += label2_Click;
            // 
            // StyleComboBox
            // 
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(295, 126);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(215, 28);
            StyleComboBox.TabIndex = 10;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(3, 174);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(193, 39);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += button1_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.Location = new Point(295, 174);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(193, 39);
            CancelBtn.TabIndex = 12;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // FurnitureInfoLabel
            // 
            FurnitureInfoLabel.AutoSize = true;
            FurnitureInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureInfoLabel.Location = new Point(3, 258);
            FurnitureInfoLabel.Name = "FurnitureInfoLabel";
            FurnitureInfoLabel.Size = new Size(167, 20);
            FurnitureInfoLabel.TabIndex = 4;
            FurnitureInfoLabel.Text = "Furniture Information:";
            FurnitureInfoLabel.Click += label1_Click_1;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.Location = new Point(691, 494);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(214, 39);
            CloseBtn.TabIndex = 13;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += button1_Click_1;
            // 
            // UserLabel
            // 
            UserLabel.Anchor = AnchorStyles.Right;
            UserLabel.AutoSize = true;
            UserLabel.ImageAlign = ContentAlignment.TopRight;
            UserLabel.Location = new Point(830, 8);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(75, 20);
            UserLabel.TabIndex = 14;
            UserLabel.Text = "Username";
            UserLabel.Click += UserLabel_Click;
            // 
            // LogoutLink
            // 
            LogoutLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogoutLink.AutoSize = true;
            LogoutLink.Location = new Point(849, 36);
            LogoutLink.Name = "LogoutLink";
            LogoutLink.Size = new Size(56, 20);
            LogoutLink.TabIndex = 15;
            LogoutLink.TabStop = true;
            LogoutLink.Text = "Logout";
            LogoutLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SearchFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 543);
            Controls.Add(SearchTableLayoutPanel);
            Name = "SearchFurnitureForm";
            Text = "Search Furniture";
            Load += SearchFurnitureForm_Load;
            SearchTableLayoutPanel.ResumeLayout(false);
            SearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel SearchTableLayoutPanel;
        private DataGridView SearchFurnitureDataGridView;
        private Label SearchLabel;
        private Label FurnitureInfoLabel;
        private ComboBox RentalComboBox;
        private Label RentalIDLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Label StyleLabel;
        private ComboBox StyleComboBox;
        private Button SearchBtn;
        private Button CancelBtn;
        private DataGridViewTextBoxColumn RentalIDText;
        private DataGridViewTextBoxColumn FurnitureGridText;
        private DataGridViewTextBoxColumn CategoryGridText;
        private DataGridViewTextBoxColumn StyleGridText;
        private DataGridViewTextBoxColumn QuantityGridText;
        private DataGridViewTextBoxColumn InfoGridText;
        private DataGridViewTextBoxColumn AvailableGridText;
        private Button CloseBtn;
        private Label UserLabel;
        private LinkLabel LogoutLink;
    }
}