namespace cs6232_g4.UserControls
{
    partial class FurnitureSearchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FurnitureSearchTableLayoutPanel = new TableLayoutPanel();
            FurnitureDataGridView = new DataGridView();
            SelectStyleLabel = new Label();
            SelectCategoryLabel = new Label();
            furnitureCategoriesComboBox = new ComboBox();
            SelectIDLabel = new Label();
            furnitureIDComboBox = new ComboBox();
            instructionsLabel = new Label();
            furnitureStyleComboBox = new ComboBox();
            InformationLabel = new Label();
            clearButton = new Button();
            FurnitureSearchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FurnitureSearchTableLayoutPanel
            // 
            FurnitureSearchTableLayoutPanel.ColumnCount = 4;
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.46729F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.53271F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            FurnitureSearchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216F));
            FurnitureSearchTableLayoutPanel.Controls.Add(FurnitureDataGridView, 0, 3);
            FurnitureSearchTableLayoutPanel.Controls.Add(SelectStyleLabel, 0, 2);
            FurnitureSearchTableLayoutPanel.Controls.Add(SelectCategoryLabel, 2, 1);
            FurnitureSearchTableLayoutPanel.Controls.Add(furnitureCategoriesComboBox, 3, 1);
            FurnitureSearchTableLayoutPanel.Controls.Add(SelectIDLabel, 0, 1);
            FurnitureSearchTableLayoutPanel.Controls.Add(furnitureIDComboBox, 1, 1);
            FurnitureSearchTableLayoutPanel.Controls.Add(instructionsLabel, 0, 0);
            FurnitureSearchTableLayoutPanel.Controls.Add(furnitureStyleComboBox, 1, 2);
            FurnitureSearchTableLayoutPanel.Controls.Add(InformationLabel, 2, 2);
            FurnitureSearchTableLayoutPanel.Controls.Add(clearButton, 3, 0);
            FurnitureSearchTableLayoutPanel.Dock = DockStyle.Top;
            FurnitureSearchTableLayoutPanel.Location = new Point(0, 0);
            FurnitureSearchTableLayoutPanel.Name = "FurnitureSearchTableLayoutPanel";
            FurnitureSearchTableLayoutPanel.RowCount = 4;
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5145645F));
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4854355F));
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 441F));
            FurnitureSearchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 319F));
            FurnitureSearchTableLayoutPanel.Size = new Size(793, 580);
            FurnitureSearchTableLayoutPanel.TabIndex = 1;
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.AllowUserToAddRows = false;
            FurnitureDataGridView.AllowUserToDeleteRows = false;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureSearchTableLayoutPanel.SetColumnSpan(FurnitureDataGridView, 4);
            FurnitureDataGridView.Dock = DockStyle.Fill;
            FurnitureDataGridView.Location = new Point(3, 141);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.ReadOnly = true;
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(787, 436);
            FurnitureDataGridView.TabIndex = 9;
            // 
            // SelectStyleLabel
            // 
            SelectStyleLabel.Location = new Point(3, 103);
            SelectStyleLabel.Name = "SelectStyleLabel";
            SelectStyleLabel.Size = new Size(187, 30);
            SelectStyleLabel.TabIndex = 5;
            SelectStyleLabel.Text = "Select Furniture Style:";
            // 
            // SelectCategoryLabel
            // 
            SelectCategoryLabel.Location = new Point(385, 51);
            SelectCategoryLabel.Name = "SelectCategoryLabel";
            SelectCategoryLabel.Size = new Size(188, 31);
            SelectCategoryLabel.TabIndex = 3;
            SelectCategoryLabel.Text = "Select Furniture Category:";
            // 
            // furnitureCategoriesComboBox
            // 
            furnitureCategoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoriesComboBox.FormattingEnabled = true;
            furnitureCategoriesComboBox.Location = new Point(579, 54);
            furnitureCategoriesComboBox.Name = "furnitureCategoriesComboBox";
            furnitureCategoriesComboBox.Size = new Size(204, 28);
            furnitureCategoriesComboBox.TabIndex = 3;
            furnitureCategoriesComboBox.SelectionChangeCommitted += furnitureCategoriesComboBox_SelectionChangeCommitted;
            // 
            // SelectIDLabel
            // 
            SelectIDLabel.Location = new Point(3, 51);
            SelectIDLabel.Name = "SelectIDLabel";
            SelectIDLabel.Size = new Size(187, 31);
            SelectIDLabel.TabIndex = 0;
            SelectIDLabel.Text = "Select Furniture ID:";
            // 
            // furnitureIDComboBox
            // 
            furnitureIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureIDComboBox.FormattingEnabled = true;
            furnitureIDComboBox.Location = new Point(196, 54);
            furnitureIDComboBox.Name = "furnitureIDComboBox";
            furnitureIDComboBox.Size = new Size(183, 28);
            furnitureIDComboBox.TabIndex = 1;
            furnitureIDComboBox.SelectionChangeCommitted += furnitureIDComboBox_SelectionChangeCommitted;
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            FurnitureSearchTableLayoutPanel.SetColumnSpan(instructionsLabel, 3);
            instructionsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            instructionsLabel.Location = new Point(3, 0);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(464, 25);
            instructionsLabel.TabIndex = 2;
            instructionsLabel.Text = "Select a furniture ID, category, or style to view furniture. ";
            // 
            // furnitureStyleComboBox
            // 
            furnitureStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureStyleComboBox.FormattingEnabled = true;
            furnitureStyleComboBox.Location = new Point(196, 106);
            furnitureStyleComboBox.Name = "furnitureStyleComboBox";
            furnitureStyleComboBox.Size = new Size(183, 28);
            furnitureStyleComboBox.TabIndex = 2;
            furnitureStyleComboBox.SelectionChangeCommitted += furnitureStyleComboBox_SelectionChangeCommitted;
            // 
            // InformationLabel
            // 
            FurnitureSearchTableLayoutPanel.SetColumnSpan(InformationLabel, 2);
            InformationLabel.ForeColor = Color.Red;
            InformationLabel.Location = new Point(385, 103);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(405, 30);
            InformationLabel.TabIndex = 8;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ImageAlign = ContentAlignment.TopRight;
            clearButton.Location = new Point(579, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(204, 29);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear Selection";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // FurnitureSearchUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FurnitureSearchTableLayoutPanel);
            Name = "FurnitureSearchUserControl";
            Size = new Size(793, 580);
            Load += FurnitureSearchUserControl_Load_1;
            FurnitureSearchTableLayoutPanel.ResumeLayout(false);
            FurnitureSearchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FurnitureSearchTableLayoutPanel;
        private Label SelectStyleLabel;
        private Label SelectCategoryLabel;
        private ComboBox furnitureCategoriesComboBox;
        private Label SelectIDLabel;
        private ComboBox furnitureIDComboBox;
        private Label instructionsLabel;
        private ComboBox furnitureStyleComboBox;
        private Label InformationLabel;
        private DataGridView FurnitureDataGridView;
        private Button clearButton;
    }
}
