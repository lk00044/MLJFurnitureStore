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
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).BeginInit();
            SuspendLayout();
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(15, 20);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(341, 25);
            MemberIDLabel.TabIndex = 21;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // CloseButton
            // 
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(673, 29);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(160, 35);
            CloseButton.TabIndex = 23;
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
            MemberTransactionsDataGridView.Location = new Point(17, 96);
            MemberTransactionsDataGridView.Name = "MemberTransactionsDataGridView";
            MemberTransactionsDataGridView.ReadOnly = true;
            MemberTransactionsDataGridView.RowHeadersWidth = 51;
            MemberTransactionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberTransactionsDataGridView.Size = new Size(808, 349);
            MemberTransactionsDataGridView.TabIndex = 22;
            // 
            // transactionDALBindingSource1
            // 
            transactionDALBindingSource1.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberNameLabel.Location = new Point(15, 53);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(341, 25);
            MemberNameLabel.TabIndex = 24;
            MemberNameLabel.Text = "Member Name: ";
            MemberNameLabel.Click += MemberNameLabel_Click;
            // 
            // transactionDALBindingSource
            // 
            transactionDALBindingSource.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // ViewMbrTransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(848, 468);
            Controls.Add(MemberNameLabel);
            Controls.Add(MemberIDLabel);
            Controls.Add(CloseButton);
            Controls.Add(MemberTransactionsDataGridView);
            Name = "ViewMbrTransactionHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Transaction History";
            Load += ViewMbrTransactionHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)MemberTransactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label MemberIDLabel;
        private Button CloseButton;
        private DataGridView MemberTransactionsDataGridView;
        private Label MemberNameLabel;
        private BindingSource transactionDALBindingSource;
        private BindingSource transactionDALBindingSource1;
    }
}