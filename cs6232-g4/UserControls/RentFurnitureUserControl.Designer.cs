namespace cs6232_g4.UserControls
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
            addItemButton = new Button();
            submitOrderButton = new Button();
            cartListView = new ListView();
            updateItemButton = new Button();
            totalCostLabel = new Label();
            furnitureIdTextBox = new TextBox();
            quantityTextBox = new TextBox();
            totalCostValue = new Label();
            availableFurnitureGridView = new DataGridView();
            dobLabel = new Label();
            memberIdTextBox = new TextBox();
            memberID = new Label();
            resetOrderButton = new Button();
            dueDatePicker = new DateTimePicker();
            label3 = new Label();
            infoMessageLabel = new Label();
            RemoveButton = new Button();
            noticeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)availableFurnitureGridView).BeginInit();
            SuspendLayout();
            // 
            // availableFurnitureLabel
            // 
            availableFurnitureLabel.AutoSize = true;
            availableFurnitureLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            availableFurnitureLabel.Location = new Point(3, 357);
            availableFurnitureLabel.Name = "availableFurnitureLabel";
            availableFurnitureLabel.Size = new Size(233, 35);
            availableFurnitureLabel.TabIndex = 0;
            availableFurnitureLabel.Text = "Furniture Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 2;
            label1.Text = "Furniture ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // addItemButton
            // 
            addItemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            addItemButton.Location = new Point(22, 175);
            addItemButton.Margin = new Padding(3, 4, 3, 4);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(86, 31);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += AddItemButton_Click;
            // 
            // submitOrderButton
            // 
            submitOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            submitOrderButton.Location = new Point(22, 309);
            submitOrderButton.Margin = new Padding(3, 4, 3, 4);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(110, 31);
            submitOrderButton.TabIndex = 7;
            submitOrderButton.Text = "Submit Order";
            submitOrderButton.UseVisualStyleBackColor = true;
            submitOrderButton.Click += SubmitOrderButton_Click;
            // 
            // cartListView
            // 
            cartListView.FullRowSelect = true;
            cartListView.Location = new Point(426, 48);
            cartListView.Margin = new Padding(3, 4, 3, 4);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(419, 244);
            cartListView.TabIndex = 9;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = System.Windows.Forms.View.Details;
            // 
            // updateItemButton
            // 
            updateItemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            updateItemButton.Location = new Point(114, 175);
            updateItemButton.Margin = new Padding(3, 4, 3, 4);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(98, 31);
            updateItemButton.TabIndex = 11;
            updateItemButton.Text = "Update Item";
            updateItemButton.UseVisualStyleBackColor = true;
            updateItemButton.Click += UpdateItemButton_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            totalCostLabel.Location = new Point(581, 293);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(87, 23);
            totalCostLabel.TabIndex = 12;
            totalCostLabel.Text = "Total Cost";
            // 
            // furnitureIdTextBox
            // 
            furnitureIdTextBox.Location = new Point(125, 48);
            furnitureIdTextBox.Margin = new Padding(3, 4, 3, 4);
            furnitureIdTextBox.Name = "furnitureIdTextBox";
            furnitureIdTextBox.Size = new Size(114, 27);
            furnitureIdTextBox.TabIndex = 13;
            furnitureIdTextBox.KeyPress += FurnitureIdTextBox_KeyPress;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(125, 87);
            quantityTextBox.Margin = new Padding(3, 4, 3, 4);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(114, 27);
            quantityTextBox.TabIndex = 14;
            quantityTextBox.KeyPress += QuantityTextBox_KeyPress;
            // 
            // totalCostValue
            // 
            totalCostValue.AutoSize = true;
            totalCostValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            totalCostValue.ForeColor = Color.Green;
            totalCostValue.Location = new Point(672, 293);
            totalCostValue.Name = "totalCostValue";
            totalCostValue.Size = new Size(50, 23);
            totalCostValue.TabIndex = 15;
            totalCostValue.Text = "$0.00";
            // 
            // availableFurnitureGridView
            // 
            availableFurnitureGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableFurnitureGridView.Location = new Point(3, 396);
            availableFurnitureGridView.Margin = new Padding(3, 4, 3, 4);
            availableFurnitureGridView.Name = "availableFurnitureGridView";
            availableFurnitureGridView.RowHeadersWidth = 51;
            availableFurnitureGridView.Size = new Size(842, 220);
            availableFurnitureGridView.TabIndex = 16;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            dobLabel.Location = new Point(22, 125);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(83, 23);
            dobLabel.TabIndex = 26;
            dobLabel.Text = "Due Date";
            // 
            // memberIdTextBox
            // 
            memberIdTextBox.Location = new Point(125, 265);
            memberIdTextBox.Margin = new Padding(3, 4, 3, 4);
            memberIdTextBox.Name = "memberIdTextBox";
            memberIdTextBox.Size = new Size(114, 27);
            memberIdTextBox.TabIndex = 33;
            memberIdTextBox.KeyPress += MemberIdTextBox_KeyPress;
            // 
            // memberID
            // 
            memberID.AutoSize = true;
            memberID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            memberID.Location = new Point(22, 264);
            memberID.Name = "memberID";
            memberID.Size = new Size(95, 23);
            memberID.TabIndex = 31;
            memberID.Text = "Member ID";
            // 
            // resetOrderButton
            // 
            resetOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            resetOrderButton.Location = new Point(141, 309);
            resetOrderButton.Margin = new Padding(3, 4, 3, 4);
            resetOrderButton.Name = "resetOrderButton";
            resetOrderButton.Size = new Size(110, 31);
            resetOrderButton.TabIndex = 34;
            resetOrderButton.Text = "Reset Order";
            resetOrderButton.UseVisualStyleBackColor = true;
            resetOrderButton.Click += ResetOrderButton_Click;
            // 
            // dueDatePicker
            // 
            dueDatePicker.Location = new Point(125, 125);
            dueDatePicker.Margin = new Padding(3, 4, 3, 4);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(228, 27);
            dueDatePicker.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(607, 7);
            label3.Name = "label3";
            label3.Size = new Size(63, 35);
            label3.TabIndex = 5;
            label3.Text = "Cart";
            // 
            // infoMessageLabel
            // 
            infoMessageLabel.AutoSize = true;
            infoMessageLabel.Font = new Font("Segoe UI", 10F);
            infoMessageLabel.ForeColor = Color.Red;
            infoMessageLabel.Location = new Point(129, 7);
            infoMessageLabel.Name = "infoMessageLabel";
            infoMessageLabel.Size = new Size(118, 23);
            infoMessageLabel.TabIndex = 36;
            infoMessageLabel.Text = "error message";
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            RemoveButton.Location = new Point(218, 175);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(111, 31);
            RemoveButton.TabIndex = 37;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // noticeLabel
            // 
            noticeLabel.AutoSize = true;
            noticeLabel.Location = new Point(531, 373);
            noticeLabel.Name = "noticeLabel";
            noticeLabel.Size = new Size(314, 20);
            noticeLabel.TabIndex = 38;
            noticeLabel.Text = "Inventory includes items currently out of stock.";
            // 
            // RentFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(noticeLabel);
            Controls.Add(RemoveButton);
            Controls.Add(infoMessageLabel);
            Controls.Add(dueDatePicker);
            Controls.Add(resetOrderButton);
            Controls.Add(memberIdTextBox);
            Controls.Add(memberID);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(availableFurnitureLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RentFurnitureUserControl";
            Size = new Size(854, 619);
            Load += RentFurnitureUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)availableFurnitureGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label availableFurnitureLabel;
        private Label label1;
        private Label label2;
        private Button addItemButton;
        private Button submitOrderButton;
        private ListView cartListView;
        private Button updateItemButton;
        private Label totalCostLabel;
        private TextBox furnitureIdTextBox;
        private TextBox quantityTextBox;
        private Label totalCostValue;
        private DataGridView availableFurnitureGridView;
        private Label dobLabel;
        private TextBox memberIdTextBox;
        private Label memberID;
        private Button resetOrderButton;
        private DateTimePicker dueDatePicker;
        private Label label3;
        private Label infoMessageLabel;
        private Button RemoveButton;
        private Label noticeLabel;
    }
}
