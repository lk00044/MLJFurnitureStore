namespace cs6232_g4.View
{
    partial class ViewMbrTransactionHistoryForm
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
            components = new System.ComponentModel.Container();
            MemberIDLabel = new Label();
            MemberTransactionsDataGridView = new DataGridView();
            transactionDALBindingSource1 = new BindingSource(components);
            MemberNameLabel = new Label();
            transactionDALBindingSource = new BindingSource(components);
            TransHistTableLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            label2 = new Label();
            cartListView = new ListView();
            label3 = new Label();
            submitOrderButton = new Button();
            button1 = new Button();
            errorLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).BeginInit();
            TransHistTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(3, 0);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(181, 19);
            MemberIDLabel.TabIndex = 21;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // MemberTransactionsDataGridView
            // 
            MemberTransactionsDataGridView.AllowUserToAddRows = false;
            MemberTransactionsDataGridView.AllowUserToDeleteRows = false;
            MemberTransactionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            MemberTransactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransHistTableLayoutPanel.SetColumnSpan(MemberTransactionsDataGridView, 2);
            MemberTransactionsDataGridView.Dock = DockStyle.Fill;
            MemberTransactionsDataGridView.Location = new Point(3, 69);
            MemberTransactionsDataGridView.Margin = new Padding(3, 2, 3, 2);
            MemberTransactionsDataGridView.Name = "MemberTransactionsDataGridView";
            MemberTransactionsDataGridView.ReadOnly = true;
            MemberTransactionsDataGridView.RowHeadersWidth = 51;
            MemberTransactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberTransactionsDataGridView.Size = new Size(368, 204);
            MemberTransactionsDataGridView.TabIndex = 22;
            MemberTransactionsDataGridView.CellClick += MemberTransactionsDataGrid_CellClick;
            // 
            // transactionDALBindingSource1
            // 
            transactionDALBindingSource1.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberNameLabel.Location = new Point(3, 29);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(181, 22);
            MemberNameLabel.TabIndex = 24;
            MemberNameLabel.Text = "Member Name: ";
            MemberNameLabel.Click += MemberNameLabel_Click;
            // 
            // transactionDALBindingSource
            // 
            transactionDALBindingSource.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // TransHistTableLayoutPanel
            // 
            TransHistTableLayoutPanel.ColumnCount = 2;
            TransHistTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TransHistTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TransHistTableLayoutPanel.Controls.Add(MemberIDLabel, 0, 0);
            TransHistTableLayoutPanel.Controls.Add(MemberTransactionsDataGridView, 0, 2);
            TransHistTableLayoutPanel.Controls.Add(MemberNameLabel, 0, 1);
            TransHistTableLayoutPanel.Location = new Point(12, 42);
            TransHistTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            TransHistTableLayoutPanel.Name = "TransHistTableLayoutPanel";
            TransHistTableLayoutPanel.RowCount = 3;
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42.69663F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 57.30337F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 207F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TransHistTableLayoutPanel.Size = new Size(374, 275);
            TransHistTableLayoutPanel.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(468, 2);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 26;
            label1.Text = "Return Transaction";
            // 
            // quantityLabel
            // 
            quantityLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(450, 42);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(89, 19);
            quantityLabel.TabIndex = 28;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(545, 42);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7F);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(452, 23);
            label2.Name = "label2";
            label2.Size = new Size(193, 12);
            label2.TabIndex = 30;
            label2.Text = "please select item and quantity to return";
            // 
            // cartListView
            // 
            cartListView.Location = new Point(518, 104);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(161, 184);
            cartListView.TabIndex = 32;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(545, 80);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 31;
            label3.Text = "Return Cart";
            // 
            // submitOrderButton
            // 
            submitOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            submitOrderButton.Location = new Point(549, 294);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(96, 23);
            submitOrderButton.TabIndex = 34;
            submitOrderButton.Text = "Submit Return";
            submitOrderButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(405, 111);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 35;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddToCartButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 7F);
            errorLabel.Location = new Point(58, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 12);
            errorLabel.TabIndex = 36;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(405, 140);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 37;
            button2.Text = "Update ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(405, 169);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 38;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RemoveButton_Click;
            // 
            // ViewMbrTransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(770, 329);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(errorLabel);
            Controls.Add(button1);
            Controls.Add(submitOrderButton);
            Controls.Add(cartListView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(label1);
            Controls.Add(TransHistTableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewMbrTransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Transaction History";
            Load += ViewMbrTransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).EndInit();
            TransHistTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MemberIDLabel;
        private DataGridView MemberTransactionsDataGridView;
        private Label MemberNameLabel;
        private BindingSource transactionDALBindingSource;
        private BindingSource transactionDALBindingSource1;
        private TableLayoutPanel TransHistTableLayoutPanel;
        private Label label1;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Label label2;
        private ListView cartListView;
        private Label label3;
        private Button submitOrderButton;
        private Button button1;
        private Label errorLabel;
        private Button button2;
        private Button button3;
    }
}