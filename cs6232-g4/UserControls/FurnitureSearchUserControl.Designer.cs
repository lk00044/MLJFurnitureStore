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
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectStyleLabel = new Label();
            SelectCategoryLabel = new Label();
            furnitureCategoriesComboBox = new ComboBox();
            SelectIDLabel = new Label();
            furnitureIDComboBox = new ComboBox();
            instructionsLabel = new Label();
            FurnitureDataGridView = new DataGridView();
            furnitureStyleComboBox = new ComboBox();
            InformationLabel = new Label();
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
            tableLayoutPanel1.Controls.Add(SelectStyleLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(SelectCategoryLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(furnitureCategoriesComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(SelectIDLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(furnitureIDComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(instructionsLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(FurnitureDataGridView, 1, 3);
            tableLayoutPanel1.Controls.Add(furnitureStyleComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(InformationLabel, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4545441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 439F));
            tableLayoutPanel1.Size = new Size(867, 580);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // SelectStyleLabel
            // 
            SelectStyleLabel.Location = new Point(3, 99);
            SelectStyleLabel.Name = "SelectStyleLabel";
            SelectStyleLabel.Size = new Size(210, 30);
            SelectStyleLabel.TabIndex = 5;
            SelectStyleLabel.Text = "Select Furniture Style:";
            // 
            // SelectCategoryLabel
            // 
            SelectCategoryLabel.Location = new Point(439, 54);
            SelectCategoryLabel.Name = "SelectCategoryLabel";
            SelectCategoryLabel.Size = new Size(210, 31);
            SelectCategoryLabel.TabIndex = 3;
            SelectCategoryLabel.Text = "Select Furniture Category:";
            // 
            // furnitureCategoriesComboBox
            // 
            furnitureCategoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoriesComboBox.FormattingEnabled = true;
            furnitureCategoriesComboBox.Location = new Point(660, 57);
            furnitureCategoriesComboBox.Name = "furnitureCategoriesComboBox";
            furnitureCategoriesComboBox.Size = new Size(204, 28);
            furnitureCategoriesComboBox.TabIndex = 4;
            furnitureCategoriesComboBox.SelectionChangeCommitted += furnitureCategoriesComboBox_SelectionChangeCommitted;
            // 
            // SelectIDLabel
            // 
            SelectIDLabel.Location = new Point(3, 54);
            SelectIDLabel.Name = "SelectIDLabel";
            SelectIDLabel.Size = new Size(210, 31);
            SelectIDLabel.TabIndex = 0;
            SelectIDLabel.Text = "Select Furniture ID:";
            // 
            // furnitureIDComboBox
            // 
            furnitureIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureIDComboBox.FormattingEnabled = true;
            furnitureIDComboBox.Location = new Point(223, 57);
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
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.AllowUserToAddRows = false;
            FurnitureDataGridView.AllowUserToDeleteRows = false;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(FurnitureDataGridView, 4);
            FurnitureDataGridView.Dock = DockStyle.Fill;
            FurnitureDataGridView.Location = new Point(3, 144);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.ReadOnly = true;
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(861, 433);
            FurnitureDataGridView.TabIndex = 7;
            // 
            // furnitureStyleComboBox
            // 
            furnitureStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureStyleComboBox.FormattingEnabled = true;
            furnitureStyleComboBox.Location = new Point(223, 102);
            furnitureStyleComboBox.Name = "furnitureStyleComboBox";
            furnitureStyleComboBox.Size = new Size(206, 28);
            furnitureStyleComboBox.TabIndex = 6;
            furnitureStyleComboBox.SelectionChangeCommitted += furnitureStyleComboBox_SelectionChangeCommitted;
            // 
            // InformationLabel
            // 
            tableLayoutPanel1.SetColumnSpan(InformationLabel, 2);
            InformationLabel.ForeColor = Color.Red;
            InformationLabel.Location = new Point(439, 99);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(425, 30);
            InformationLabel.TabIndex = 8;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FurnitureSearchUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FurnitureSearchUserControl";
            Size = new Size(867, 580);
            Load += FurnitureSearchUserControl_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label SelectStyleLabel;
        private Label SelectCategoryLabel;
        private ComboBox furnitureCategoriesComboBox;
        private Label SelectIDLabel;
        private ComboBox furnitureIDComboBox;
        private Label instructionsLabel;
        private DataGridView FurnitureDataGridView;
        private ComboBox furnitureStyleComboBox;
        private Label InformationLabel;
    }
}
