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
            ReturnTitleLlabel = new Label();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            ReturnMessageLlabel = new Label();
            cartListView = new ListView();
            ReturnCartTitleLabel = new Label();
            submitOrderButton = new Button();
            AddToCartButton = new Button();
            infoMessageLabel = new Label();
            UpdateButton = new Button();
            RemoveButton = new Button();
            DataGridTitleLabel = new Label();
            menuStrip1 = new MenuStrip();
            returnInstructionsToolStripMenuItem = new ToolStripMenuItem();
            returnInstructionsToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).BeginInit();
            TransHistTableLayoutPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(3, 0);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(207, 25);
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
            MemberTransactionsDataGridView.Location = new Point(3, 78);
            MemberTransactionsDataGridView.Name = "MemberTransactionsDataGridView";
            MemberTransactionsDataGridView.ReadOnly = true;
            MemberTransactionsDataGridView.RowHeadersWidth = 51;
            MemberTransactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberTransactionsDataGridView.Size = new Size(421, 286);
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
            MemberNameLabel.Location = new Point(3, 40);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(207, 29);
            MemberNameLabel.TabIndex = 24;
            MemberNameLabel.Text = "Member Name: ";
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
            TransHistTableLayoutPanel.Location = new Point(20, 154);
            TransHistTableLayoutPanel.Name = "TransHistTableLayoutPanel";
            TransHistTableLayoutPanel.RowCount = 3;
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3333321F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.6666679F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 291F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            TransHistTableLayoutPanel.Size = new Size(427, 367);
            TransHistTableLayoutPanel.TabIndex = 25;
            // 
            // ReturnTitleLlabel
            // 
            ReturnTitleLlabel.AutoSize = true;
            ReturnTitleLlabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ReturnTitleLlabel.Location = new Point(641, 91);
            ReturnTitleLlabel.Name = "ReturnTitleLlabel";
            ReturnTitleLlabel.Size = new Size(180, 28);
            ReturnTitleLlabel.TabIndex = 26;
            ReturnTitleLlabel.Text = "Return Transaction";
            // 
            // quantityLabel
            // 
            quantityLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(617, 207);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(102, 25);
            quantityLabel.TabIndex = 28;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(716, 196);
            quantityTextBox.Margin = new Padding(3, 4, 3, 4);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(114, 27);
            quantityTextBox.TabIndex = 29;
            // 
            // ReturnMessageLlabel
            // 
            ReturnMessageLlabel.Font = new Font("Segoe UI Semibold", 7F);
            ReturnMessageLlabel.ForeColor = Color.Red;
            ReturnMessageLlabel.Location = new Point(617, 145);
            ReturnMessageLlabel.Name = "ReturnMessageLlabel";
            ReturnMessageLlabel.Size = new Size(226, 34);
            ReturnMessageLlabel.TabIndex = 30;
            ReturnMessageLlabel.Text = "Please select item and enter quantity to add item to the return cart.";
            // 
            // cartListView
            // 
            cartListView.Location = new Point(598, 273);
            cartListView.Margin = new Padding(3, 4, 3, 4);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(254, 244);
            cartListView.TabIndex = 32;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ReturnCartTitleLabel
            // 
            ReturnCartTitleLabel.AutoSize = true;
            ReturnCartTitleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ReturnCartTitleLabel.Location = new Point(664, 241);
            ReturnCartTitleLabel.Name = "ReturnCartTitleLabel";
            ReturnCartTitleLabel.Size = new Size(117, 28);
            ReturnCartTitleLabel.TabIndex = 31;
            ReturnCartTitleLabel.Text = "Return Cart";
            // 
            // submitOrderButton
            // 
            submitOrderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            submitOrderButton.Location = new Point(664, 548);
            submitOrderButton.Margin = new Padding(3, 4, 3, 4);
            submitOrderButton.Name = "submitOrderButton";
            submitOrderButton.Size = new Size(110, 31);
            submitOrderButton.TabIndex = 34;
            submitOrderButton.Text = "Submit Return";
            submitOrderButton.UseVisualStyleBackColor = true;
            submitOrderButton.Click += SubmitOrderButton_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            AddToCartButton.Location = new Point(469, 287);
            AddToCartButton.Margin = new Padding(3, 4, 3, 4);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(110, 31);
            AddToCartButton.TabIndex = 35;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // infoMessageLabel
            // 
            infoMessageLabel.Font = new Font("Segoe UI Semibold", 7F);
            infoMessageLabel.Location = new Point(598, 42);
            infoMessageLabel.Name = "infoMessageLabel";
            infoMessageLabel.Size = new Size(254, 30);
            infoMessageLabel.TabIndex = 36;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            UpdateButton.Location = new Point(469, 350);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(110, 31);
            UpdateButton.TabIndex = 37;
            UpdateButton.Text = "Update ";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            RemoveButton.Location = new Point(469, 419);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(110, 31);
            RemoveButton.TabIndex = 38;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // DataGridTitleLabel
            // 
            DataGridTitleLabel.AutoSize = true;
            DataGridTitleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DataGridTitleLabel.Location = new Point(23, 91);
            DataGridTitleLabel.Name = "DataGridTitleLabel";
            DataGridTitleLabel.Size = new Size(252, 28);
            DataGridTitleLabel.TabIndex = 39;
            DataGridTitleLabel.Text = "Return Transaction History";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { returnInstructionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(887, 28);
            menuStrip1.TabIndex = 41;
            menuStrip1.Text = "menuStrip1";
            // 
            // returnInstructionsToolStripMenuItem
            // 
            returnInstructionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { returnInstructionsToolStripMenuItem1, exitToolStripMenuItem });
            returnInstructionsToolStripMenuItem.Name = "returnInstructionsToolStripMenuItem";
            returnInstructionsToolStripMenuItem.Size = new Size(60, 24);
            returnInstructionsToolStripMenuItem.Text = "Menu";
            // 
            // returnInstructionsToolStripMenuItem1
            // 
            returnInstructionsToolStripMenuItem1.Name = "returnInstructionsToolStripMenuItem1";
            returnInstructionsToolStripMenuItem1.Size = new Size(224, 26);
            returnInstructionsToolStripMenuItem1.Text = "Return Instructions";
            returnInstructionsToolStripMenuItem1.Click += returnInstructionsToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ViewMbrTransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(887, 604);
            Controls.Add(DataGridTitleLabel);
            Controls.Add(RemoveButton);
            Controls.Add(UpdateButton);
            Controls.Add(infoMessageLabel);
            Controls.Add(AddToCartButton);
            Controls.Add(submitOrderButton);
            Controls.Add(cartListView);
            Controls.Add(ReturnCartTitleLabel);
            Controls.Add(ReturnMessageLlabel);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(ReturnTitleLlabel);
            Controls.Add(TransHistTableLayoutPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ViewMbrTransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Transaction History";
            Load += ViewMbrTransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).EndInit();
            TransHistTableLayoutPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label ReturnTitleLlabel;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Label ReturnMessageLlabel;
        private ListView cartListView;
        private Label ReturnCartTitleLabel;
        private Button submitOrderButton;
        private Button AddToCartButton;
        private Label infoMessageLabel;
        private Button UpdateButton;
        private Button RemoveButton;
        private Label DataGridTitleLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem returnInstructionsToolStripMenuItem;
        private ToolStripMenuItem returnInstructionsToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}