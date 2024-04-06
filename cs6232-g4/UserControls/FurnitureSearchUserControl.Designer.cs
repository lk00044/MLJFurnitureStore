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
            furnitureCategoriesComboBox = new ComboBox();
            FurnitureCategoryLabel = new Label();
            FurnitureDataGridView = new DataGridView();
            furnitureStyleComboBox = new ComboBox();
            styleLabel = new Label();
            furnitureIDComboBox = new ComboBox();
            FurnitureIDLabel = new Label();
            instructionsLlabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.61836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.38164F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel1.Controls.Add(furnitureCategoriesComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(FurnitureCategoryLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(FurnitureDataGridView, 0, 4);
            tableLayoutPanel1.Controls.Add(furnitureStyleComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(styleLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(furnitureIDComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(FurnitureIDLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(instructionsLlabel, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2195129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 387F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.Size = new Size(831, 530);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // furnitureCategoriesComboBox
            // 
            furnitureCategoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureCategoriesComboBox.FormattingEnabled = true;
            furnitureCategoriesComboBox.Location = new Point(198, 85);
            furnitureCategoriesComboBox.Name = "furnitureCategoriesComboBox";
            furnitureCategoriesComboBox.Size = new Size(217, 28);
            furnitureCategoriesComboBox.TabIndex = 3;
            furnitureCategoriesComboBox.SelectionChangeCommitted += furnitureCategoriesComboBox_SelectionChangeCommitted;
            // 
            // FurnitureCategoryLabel
            // 
            FurnitureCategoryLabel.Location = new Point(3, 82);
            FurnitureCategoryLabel.Name = "FurnitureCategoryLabel";
            FurnitureCategoryLabel.Size = new Size(189, 36);
            FurnitureCategoryLabel.TabIndex = 4;
            FurnitureCategoryLabel.Text = "Select Furniture Category: ";
            FurnitureCategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(FurnitureDataGridView, 4);
            FurnitureDataGridView.Dock = DockStyle.Fill;
            FurnitureDataGridView.Location = new Point(3, 145);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(825, 382);
            FurnitureDataGridView.TabIndex = 4;
            // 
            // furnitureStyleComboBox
            // 
            furnitureStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureStyleComboBox.FormattingEnabled = true;
            furnitureStyleComboBox.Location = new Point(602, 45);
            furnitureStyleComboBox.Name = "furnitureStyleComboBox";
            furnitureStyleComboBox.Size = new Size(226, 28);
            furnitureStyleComboBox.TabIndex = 2;
            furnitureStyleComboBox.SelectionChangeCommitted += furnitureStyleComboBox_SelectionChangeCommitted;
            // 
            // styleLabel
            // 
            styleLabel.Location = new Point(421, 42);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new Size(160, 40);
            styleLabel.TabIndex = 2;
            styleLabel.Text = "Select Furniture Style: ";
            styleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // furnitureIDComboBox
            // 
            furnitureIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            furnitureIDComboBox.FormattingEnabled = true;
            furnitureIDComboBox.Location = new Point(198, 45);
            furnitureIDComboBox.Name = "furnitureIDComboBox";
            furnitureIDComboBox.Size = new Size(217, 28);
            furnitureIDComboBox.TabIndex = 1;
            furnitureIDComboBox.SelectionChangeCommitted += furnitureIDComboBox_SelectionChangeCommitted;
            // 
            // FurnitureIDLabel
            // 
            FurnitureIDLabel.Location = new Point(3, 42);
            FurnitureIDLabel.Name = "FurnitureIDLabel";
            FurnitureIDLabel.Size = new Size(148, 40);
            FurnitureIDLabel.TabIndex = 0;
            FurnitureIDLabel.Text = "Select Furniture ID: ";
            FurnitureIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // instructionsLlabel
            // 
            tableLayoutPanel1.SetColumnSpan(instructionsLlabel, 4);
            instructionsLlabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            instructionsLlabel.Location = new Point(3, 0);
            instructionsLlabel.Name = "instructionsLlabel";
            instructionsLlabel.Size = new Size(825, 34);
            instructionsLlabel.TabIndex = 5;
            instructionsLlabel.Text = "Select a furniture ID, Style, or Category to view information about that piece of furniture.";
            // 
            // FurnitureSearchUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FurnitureSearchUserControl";
            Size = new Size(875, 593);
            Load += FurnitureSearchUserControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label FurnitureIDLabel;
        private ComboBox furnitureIDComboBox;
        private ComboBox furnitureStyleComboBox;
        private Label styleLabel;
        private ComboBox furnitureCategoriesComboBox;
        private Label FurnitureCategoryLabel;
        private DataGridView FurnitureDataGridView;
        private Label instructionsLlabel;
    }
}
