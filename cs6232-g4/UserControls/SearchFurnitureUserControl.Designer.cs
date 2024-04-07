namespace cs6232_g4.UserControls
{
    partial class SearchFurnitureUserControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            FurnitureDataGridView = new DataGridView();
            SelectStyleLabel = new Label();
            SelectCategoryLabel = new Label();
            furnitureCategoriesComboBox = new ComboBox();
            SelectIDLabel = new Label();
            furnitureIDComboBox = new ComboBox();
            instructionsLabel = new Label();
            furnitureStyleComboBox = new ComboBox();
            InfoLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.46729F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.53271F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel1.Controls.Add(FurnitureDataGridView, 0, 4);
            tableLayoutPanel1.Controls.Add(SelectStyleLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(SelectCategoryLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(furnitureCategoriesComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(SelectIDLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(furnitureIDComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(instructionsLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(furnitureStyleComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(InfoLabel, 2, 2);
            tableLayoutPanel1.Location = new Point(16, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.608696F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.391304F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 423F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 439F));
            tableLayoutPanel1.Size = new Size(859, 570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.AllowUserToAddRows = false;
            FurnitureDataGridView.AllowUserToDeleteRows = false;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(FurnitureDataGridView, 4);
            FurnitureDataGridView.Dock = DockStyle.Fill;
            FurnitureDataGridView.Location = new Point(3, 149);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.ReadOnly = true;
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(853, 418);
            FurnitureDataGridView.TabIndex = 8;
            // 
            // SelectStyleLabel
            // 
            SelectStyleLabel.Location = new Point(3, 92);
            SelectStyleLabel.Name = "SelectStyleLabel";
            SelectStyleLabel.Size = new Size(210, 30);
            SelectStyleLabel.TabIndex = 5;
            SelectStyleLabel.Text = "Select Furniture Style:";
            // 
            // SelectCategoryLabel
            // 
            SelectCategoryLabel.Location = new Point(431, 53);
            SelectCategoryLabel.Name = "SelectCategoryLabel";
            SelectCategoryLabel.Size = new Size(210, 31);
            SelectCategoryLabel.TabIndex = 3;
            SelectCategoryLabel.Text = "Select Furniture Category:";
            // 
            // furnitureCategoriesComboBox
            // 
            furnitureCategoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoriesComboBox.FormattingEnabled = true;
            furnitureCategoriesComboBox.Location = new Point(652, 56);
            furnitureCategoriesComboBox.Name = "furnitureCategoriesComboBox";
            furnitureCategoriesComboBox.Size = new Size(204, 28);
            furnitureCategoriesComboBox.TabIndex = 4;
            furnitureCategoriesComboBox.SelectionChangeCommitted += furnitureCategoriesComboBox_SelectionChangeCommitted;
            // 
            // SelectIDLabel
            // 
            SelectIDLabel.Location = new Point(3, 53);
            SelectIDLabel.Name = "SelectIDLabel";
            SelectIDLabel.Size = new Size(210, 31);
            SelectIDLabel.TabIndex = 0;
            SelectIDLabel.Text = "Select Furniture ID:";
            // 
            // furnitureIDComboBox
            // 
            furnitureIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureIDComboBox.FormattingEnabled = true;
            furnitureIDComboBox.Location = new Point(219, 56);
            furnitureIDComboBox.Name = "furnitureIDComboBox";
            furnitureIDComboBox.Size = new Size(206, 28);
            furnitureIDComboBox.TabIndex = 1;
            furnitureIDComboBox.SelectionChangeCommitted += furnitureIDComboBox_SelectionChangeCommitted;
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(instructionsLabel, 4);
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
            furnitureStyleComboBox.Location = new Point(219, 95);
            furnitureStyleComboBox.Name = "furnitureStyleComboBox";
            furnitureStyleComboBox.Size = new Size(206, 28);
            furnitureStyleComboBox.TabIndex = 6;
            furnitureStyleComboBox.SelectionChangeCommitted += furnitureStyleComboBox_SelectionChangeCommitted;
            // 
            // InfoLabel
            // 
            tableLayoutPanel1.SetColumnSpan(InfoLabel, 2);
            InfoLabel.Location = new Point(431, 92);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(425, 31);
            InfoLabel.TabIndex = 9;
            InfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SearchFurnitureUserControl";
            Size = new Size(892, 612);
            Load += FurnitureSearchUserControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SelectIDLabel;
        private ComboBox furnitureIDComboBox;
        private Label SelectStyleLabel;
        private ComboBox furnitureStyleComboBox;
        private Label SelectCategoryLabel;
        private ComboBox furnitureCategoriesComboBox;
        private Label instructionsLabel;
        private DataGridView FurnitureDataGridView;
        private Label InfoLabel;
    }
}
