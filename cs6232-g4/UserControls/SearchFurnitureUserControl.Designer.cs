namespace cs6232_g4.UserControls
{
    partial class SearchFurnitureUserControl : UserControl
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
            SearchLabel = new Label();
            FurnitureIDLabel = new Label();
            FurnitureComboBox = new ComboBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            StyleLabel = new Label();
            StyleComboBox = new ComboBox();
            SearchBtn = new Button();
            CancelBtn = new Button();
            FurnitureInfoLabel = new Label();
            SearchFurnitureDataGridView = new DataGridView();
            SearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SearchTableLayoutPanel
            // 
            SearchTableLayoutPanel.ColumnCount = 3;
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.541851F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0881042F));
            SearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            SearchTableLayoutPanel.Controls.Add(SearchFurnitureDataGridView, 0, 5);
            SearchTableLayoutPanel.Controls.Add(SearchLabel, 0, 0);
            SearchTableLayoutPanel.Controls.Add(FurnitureIDLabel, 0, 1);
            SearchTableLayoutPanel.Controls.Add(FurnitureComboBox, 1, 1);
            SearchTableLayoutPanel.Controls.Add(CategoryLabel, 0, 2);
            SearchTableLayoutPanel.Controls.Add(CategoryComboBox, 1, 2);
            SearchTableLayoutPanel.Controls.Add(StyleLabel, 0, 3);
            SearchTableLayoutPanel.Controls.Add(StyleComboBox, 1, 3);
            SearchTableLayoutPanel.Controls.Add(SearchBtn, 2, 1);
            SearchTableLayoutPanel.Controls.Add(CancelBtn, 2, 3);
            SearchTableLayoutPanel.Controls.Add(FurnitureInfoLabel, 0, 4);
            SearchTableLayoutPanel.Dock = DockStyle.Fill;
            SearchTableLayoutPanel.Location = new Point(0, 0);
            SearchTableLayoutPanel.Name = "SearchTableLayoutPanel";
            SearchTableLayoutPanel.RowCount = 6;
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.99815845F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.023941F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.392265F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5506444F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 4.41988945F));
            SearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 62.6151F));
            SearchTableLayoutPanel.Size = new Size(908, 543);
            SearchTableLayoutPanel.TabIndex = 1;
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
            // 
            // FurnitureIDLabel
            // 
            FurnitureIDLabel.AutoSize = true;
            FurnitureIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FurnitureIDLabel.Location = new Point(3, 38);
            FurnitureIDLabel.Name = "FurnitureIDLabel";
            FurnitureIDLabel.Size = new Size(89, 20);
            FurnitureIDLabel.TabIndex = 6;
            FurnitureIDLabel.Text = "Furniture ID:";
            // 
            // FurnitureComboBox
            // 
            FurnitureComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FurnitureComboBox.FormattingEnabled = true;
            FurnitureComboBox.Location = new Point(244, 41);
            FurnitureComboBox.Name = "FurnitureComboBox";
            FurnitureComboBox.Size = new Size(215, 28);
            FurnitureComboBox.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(3, 87);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 7;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(244, 90);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(215, 28);
            CategoryComboBox.TabIndex = 8;
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StyleLabel.Location = new Point(3, 138);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(44, 20);
            StyleLabel.TabIndex = 9;
            StyleLabel.Text = "Style:";
            // 
            // StyleComboBox
            // 
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(244, 141);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(215, 28);
            StyleComboBox.TabIndex = 10;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(608, 41);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(193, 39);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchButton_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.Location = new Point(608, 141);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(193, 35);
            CancelBtn.TabIndex = 12;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // FurnitureInfoLabel
            // 
            FurnitureInfoLabel.AutoSize = true;
            FurnitureInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureInfoLabel.Location = new Point(3, 179);
            FurnitureInfoLabel.Name = "FurnitureInfoLabel";
            FurnitureInfoLabel.Size = new Size(167, 20);
            FurnitureInfoLabel.TabIndex = 4;
            FurnitureInfoLabel.Text = "Furniture Information:";
            // 
            // SearchFurnitureDataGridView
            // 
            SearchFurnitureDataGridView.AllowUserToAddRows = false;
            SearchFurnitureDataGridView.AllowUserToDeleteRows = false;
            SearchFurnitureDataGridView.AllowUserToResizeColumns = false;
            SearchFurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchFurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchTableLayoutPanel.SetColumnSpan(SearchFurnitureDataGridView, 3);
            SearchFurnitureDataGridView.Dock = DockStyle.Fill;
            SearchFurnitureDataGridView.Location = new Point(4, 207);
            SearchFurnitureDataGridView.Margin = new Padding(4);
            SearchFurnitureDataGridView.MultiSelect = false;
            SearchFurnitureDataGridView.Name = "SearchFurnitureDataGridView";
            SearchFurnitureDataGridView.ReadOnly = true;
            SearchFurnitureDataGridView.RowHeadersWidth = 51;
            SearchFurnitureDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchFurnitureDataGridView.Size = new Size(900, 332);
            SearchFurnitureDataGridView.TabIndex = 13;
            // 
            // SearchFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchTableLayoutPanel);
            Name = "SearchFurnitureUserControl";
            Size = new Size(908, 543);
            SearchTableLayoutPanel.ResumeLayout(false);
            SearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchFurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel SearchTableLayoutPanel;
        private Label SearchLabel;
        private Label FurnitureInfoLabel;
        private ComboBox FurnitureComboBox;
        private Label FurnitureIDLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Label StyleLabel;
        private ComboBox StyleComboBox;
        private Button SearchBtn;
        private Button CancelBtn;
        private DataGridView SearchFurnitureDataGridView;
    }
}