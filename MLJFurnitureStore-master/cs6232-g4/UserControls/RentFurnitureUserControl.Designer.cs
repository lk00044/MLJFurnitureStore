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
            ((System.ComponentModel.ISupportInitialize)availableFurnitureGridView).BeginInit();
            SuspendLayout();
            // 
            // availableFurnitureLabel
            // 
            availableFurnitureLabel.AutoSize = true;
            availableFurnitureLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            availableFurnitureLabel.Location = new Point(333, 266);
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
            cartListView.Location = new Point(373, 36);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(367, 184);
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
            totalCostLabel.Location = new Point(508, 220);
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
            furnitureIdTextBox.KeyPress += FurnitureIdTextBox_KeyPress;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(109, 65);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 14;
            quantityTextBox.KeyPress += QuantityTextBox_KeyPress;
            // 
            // totalCostValue
            // 
            totalCostValue.AutoSize = true;
            totalCostValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            totalCostValue.ForeColor = Color.Green;
            totalCostValue.Location = new Point(588, 220);
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
            availableFurnitureGridView.Size = new Size(737, 165);
            availableFurnitureGridView.TabIndex = 16;
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
            memberIdTextBox.KeyPress += MemberIdTextBox_KeyPress;
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
            // resetOrderButton
            // 
            resetOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            resetOrderButton.Location = new Point(123, 252);
            resetOrderButton.Name = "resetOrderButton";
            resetOrderButton.Size = new Size(96, 23);
            resetOrderButton.TabIndex = 34;
            resetOrderButton.Text = "Reset Order";
            resetOrderButton.UseVisualStyleBackColor = true;
            resetOrderButton.Click += ResetOrderButton_Click;
            // 
            // dueDatePicker
            // 
            dueDatePicker.Location = new Point(109, 94);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(200, 23);
            dueDatePicker.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(531, 5);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 5;
            label3.Text = "Cart";
            // 
            // infoMessageLabel
            // 
            infoMessageLabel.AutoSize = true;
            infoMessageLabel.Font = new Font("Segoe UI", 10F);
            infoMessageLabel.ForeColor = Color.Red;
            infoMessageLabel.Location = new Point(113, 5);
            infoMessageLabel.Name = "infoMessageLabel";
            infoMessageLabel.Size = new Size(96, 19);
            infoMessageLabel.TabIndex = 36;
            infoMessageLabel.Text = "error message";
            // 
            // RentFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "RentFurnitureUserControl";
            Size = new Size(747, 464);
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
    }
}
