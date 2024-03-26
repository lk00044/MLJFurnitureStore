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
            cartLabel = new Label();
            addItemButton = new Button();
            submitOrderButton = new Button();
            dataGridView1 = new DataGridView();
            listView1 = new ListView();
            updateItemButton = new Button();
            totalCostLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            totalCostValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            addItemButton.Location = new Point(19, 97);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(75, 23);
            addItemButton.TabIndex = 6;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            // 
            // submitOrderButton
            // 
            submitOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            submitOrderButton.Location = new Point(471, 231);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(96, 23);
            submitOrderButton.TabIndex = 7;
            submitOrderButton.Text = "Submit Order";
            submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(638, 163);
            dataGridView1.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Location = new Point(426, 36);
            listView1.Name = "listView1";
            listView1.Size = new Size(199, 146);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // updateItemButton
            // 
            updateItemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            updateItemButton.Location = new Point(100, 97);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(86, 23);
            updateItemButton.TabIndex = 11;
            updateItemButton.Text = "Update Item";
            updateItemButton.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(109, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
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
            // RentFurnitureUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalCostValue);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(totalCostLabel);
            Controls.Add(updateItemButton);
            Controls.Add(listView1);
            Controls.Add(dataGridView1);
            Controls.Add(submitOrderButton);
            Controls.Add(addItemButton);
            Controls.Add(cartLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(availableFurnitureLabel);
            Name = "RentFurnitureUserControl";
            Size = new Size(644, 463);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private ListView listView1;
        private Button updateItemButton;
        private Label totalCostLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label totalCostValue;
    }
}
