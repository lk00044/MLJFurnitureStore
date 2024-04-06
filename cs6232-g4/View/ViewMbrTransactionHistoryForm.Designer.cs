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
            CloseButton = new Button();
            MemberTransactionsDataGridView = new DataGridView();
            transactionDALBindingSource1 = new BindingSource(components);
            MemberNameLabel = new Label();
            transactionDALBindingSource = new BindingSource(components);
            TransHistTableLayoutPanel = new TableLayoutPanel();
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
            MemberIDLabel.Size = new Size(341, 25);
            MemberIDLabel.TabIndex = 21;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Right;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ImageAlign = ContentAlignment.TopRight;
            CloseButton.Location = new Point(604, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(189, 32);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // MemberTransactionsDataGridView
            // 
            MemberTransactionsDataGridView.AllowUserToAddRows = false;
            MemberTransactionsDataGridView.AllowUserToDeleteRows = false;
            MemberTransactionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            MemberTransactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransHistTableLayoutPanel.SetColumnSpan(MemberTransactionsDataGridView, 2);
            MemberTransactionsDataGridView.Dock = DockStyle.Fill;
            MemberTransactionsDataGridView.Location = new Point(3, 92);
            MemberTransactionsDataGridView.Name = "MemberTransactionsDataGridView";
            MemberTransactionsDataGridView.ReadOnly = true;
            MemberTransactionsDataGridView.RowHeadersWidth = 51;
            MemberTransactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberTransactionsDataGridView.Size = new Size(790, 318);
            MemberTransactionsDataGridView.TabIndex = 22;
            // 
            // transactionDALBindingSource1
            // 
            transactionDALBindingSource1.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberNameLabel.Location = new Point(3, 38);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(341, 30);
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
            TransHistTableLayoutPanel.Controls.Add(CloseButton, 1, 0);
            TransHistTableLayoutPanel.Location = new Point(26, 29);
            TransHistTableLayoutPanel.Name = "TransHistTableLayoutPanel";
            TransHistTableLayoutPanel.RowCount = 3;
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 42.69663F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 57.30337F));
            TransHistTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 323F));
            TransHistTableLayoutPanel.Size = new Size(796, 413);
            TransHistTableLayoutPanel.TabIndex = 25;
            // 
            // ViewMbrTransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(848, 468);
            Controls.Add(TransHistTableLayoutPanel);
            Name = "ViewMbrTransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Transaction History";
            Load += ViewMbrTransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).EndInit();
            TransHistTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label MemberIDLabel;
        private Button CloseButton;
        private DataGridView MemberTransactionsDataGridView;
        private Label MemberNameLabel;
        private BindingSource transactionDALBindingSource;
        private BindingSource transactionDALBindingSource1;
        private TableLayoutPanel TransHistTableLayoutPanel;
    }
}