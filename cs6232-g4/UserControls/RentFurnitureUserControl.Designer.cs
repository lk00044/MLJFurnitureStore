﻿namespace cs6232_g4.UserControls
{
    partial class RentFurnitureUserControl
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
            availableFurnitureLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            cartLabel = new Label();
            addItemButton = new Button();
            submitOrderButton = new Button();
            cartListView = new ListView();
            updateItemButton = new Button();
            totalCostLabel = new Label();
            furnitureIdTextBox = new TextBox();
            quantityTextBox = new TextBox();
            totalCostValue = new Label();
            availableFurnitureGridView = new DataGridView();
            yearComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            dobLabel = new Label();
            memberIdTextBox = new TextBox();
            employeeIdTextBox = new TextBox();
            memberID = new Label();
            employeeID = new Label();
            ((System.ComponentModel.ISupportInitialize)availableFurnitureGridView).BeginInit();
            SuspendLayout();
            // 
            // availableFurnitureLabel
            // 
            availableFurnitureLabel.AutoSize = true;
            availableFurnitureLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            availableFurnitureLabel.Location = new Point(227, 266);
            availableFurnitureLabel.Name = "availableFurnitureLabel";
            availableFurnitureLabel.Size = new Size(186, 28);
            availableFurnitureLabel.TabIndex = 0;
            availableFurnitureLabel.Text = "Available Furniture";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 2;
            label1.Text = "Furniture ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            cartLabel.Location = new Point(488, 5);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(51, 28);
            cartLabel.TabIndex = 5;
            cartLabel.Text = "Cart";
            // 
            // addItemButton
            // 
            addItemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            addItemButton.Location = new Point(19, 131);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(75, 23);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += AddItemButton_Click;
            // 
            // submitOrderButton
            // 
            submitOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            submitOrderButton.Location = new Point(19, 252);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(96, 23);
            submitOrderButton.TabIndex = 7;
            submitOrderButton.Text = "Submit Order";
            submitOrderButton.UseVisualStyleBackColor = true;
            submitOrderButton.Click += SubmitOrderButton_Click;
            // 
            // cartListView
            // 
            cartListView.Location = new Point(426, 36);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(192, 161);
            cartListView.TabIndex = 9;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // updateItemButton
            // 
            updateItemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            updateItemButton.Location = new Point(100, 131);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(86, 23);
            updateItemButton.TabIndex = 11;
            updateItemButton.Text = "Update Item";
            updateItemButton.UseVisualStyleBackColor = true;
            updateItemButton.Click += UpdateItemButton_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            totalCostLabel.Location = new Point(426, 200);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(74, 19);
            totalCostLabel.TabIndex = 12;
            totalCostLabel.Text = "Total Cost";
            // 
            // furnitureIdTextBox
            // 
            furnitureIdTextBox.Location = new Point(109, 36);
            furnitureIdTextBox.Name = "furnitureIdTextBox";
            furnitureIdTextBox.Size = new Size(100, 23);
            furnitureIdTextBox.TabIndex = 13;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(109, 65);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 14;
            // 
            // totalCostValue
            // 
            totalCostValue.AutoSize = true;
            totalCostValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            totalCostValue.ForeColor = Color.Green;
            totalCostValue.Location = new Point(506, 200);
            totalCostValue.Name = "totalCostValue";
            totalCostValue.Size = new Size(44, 19);
            totalCostValue.TabIndex = 15;
            totalCostValue.Text = "$0.00";
            // 
            // availableFurnitureGridView
            // 
            availableFurnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableFurnitureGridView.Location = new Point(3, 297);
            availableFurnitureGridView.Name = "availableFurnitureGridView";
            availableFurnitureGridView.Size = new Size(638, 163);
            availableFurnitureGridView.TabIndex = 16;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100" });
            yearComboBox.Location = new Point(225, 94);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(86, 23);
            yearComboBox.TabIndex = 29;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new Point(167, 94);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(52, 23);
            dayComboBox.TabIndex = 28;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComboBox.Location = new Point(109, 94);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(52, 23);
            monthComboBox.TabIndex = 27;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            dobLabel.Location = new Point(19, 94);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(68, 19);
            dobLabel.TabIndex = 26;
            dobLabel.Text = "Due Date";
            // 
            // memberIdTextBox
            // 
            memberIdTextBox.Location = new Point(109, 219);
            memberIdTextBox.Name = "memberIdTextBox";
            memberIdTextBox.Size = new Size(100, 23);
            memberIdTextBox.TabIndex = 33;
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.Location = new Point(109, 190);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.Size = new Size(100, 23);
            employeeIdTextBox.TabIndex = 32;
            // 
            // memberID
            // 
            memberID.AutoSize = true;
            memberID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            memberID.Location = new Point(19, 218);
            memberID.Name = "memberID";
            memberID.Size = new Size(78, 19);
            memberID.TabIndex = 31;
            memberID.Text = "Member ID";
            // 
            // employeeID
            // 
            employeeID.AutoSize = true;
            employeeID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            employeeID.Location = new Point(19, 190);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(87, 19);
            employeeID.TabIndex = 30;
            employeeID.Text = "Employee ID";
            // 
            // RentFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(memberIdTextBox);
            Controls.Add(employeeIdTextBox);
            Controls.Add(memberID);
            Controls.Add(employeeID);
            Controls.Add(yearComboBox);
            Controls.Add(dayComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(dobLabel);
            Controls.Add(availableFurnitureGridView);
            Controls.Add(totalCostValue);
            Controls.Add(quantityTextBox);
            Controls.Add(furnitureIdTextBox);
            Controls.Add(totalCostLabel);
            Controls.Add(updateItemButton);
            Controls.Add(cartListView);
            Controls.Add(submitOrderButton);
            Controls.Add(addItemButton);
            Controls.Add(cartLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(availableFurnitureLabel);
            Name = "RentFurnitureUserControl";
            Size = new Size(644, 463);
            Load += RentFurnitureUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)availableFurnitureGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label availableFurnitureLabel;
        private Label label1;
        private Label label2;
        private Label cartLabel;
        private Button addItemButton;
        private Button submitOrderButton;
        private ListView cartListView;
        private Button updateItemButton;
        private Label totalCostLabel;
        private TextBox furnitureIdTextBox;
        private TextBox quantityTextBox;
        private Label totalCostValue;
        private DataGridView availableFurnitureGridView;
        private ComboBox yearComboBox;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
        private Label dobLabel;
        private TextBox memberIdTextBox;
        private TextBox employeeIdTextBox;
        private Label memberID;
        private Label employeeID;
    }
}