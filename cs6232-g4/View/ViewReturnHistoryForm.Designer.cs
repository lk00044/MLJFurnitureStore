namespace cs6232_g4.View
{
    partial class ViewReturnHistoryForm
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
            ReturnHistLayoutPanel = new TableLayoutPanel();
            MemberIDLabel = new Label();
            ReturnsDataGridView = new DataGridView();
            MemberNameLabel = new Label();
            TransactionDALBindingSource = new BindingSource(components);
            infoMessageLabel = new Label();
            transactionDALBindingSource1 = new BindingSource(components);
            LineItemID = new DataGridViewTextBoxColumn();
            ReturnTransactionID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            FurnitureID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            FineOrRefund = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            ReturnHistLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionDALBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ReturnHistLayoutPanel
            // 
            ReturnHistLayoutPanel.ColumnCount = 2;
            ReturnHistLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnHistLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ReturnHistLayoutPanel.Controls.Add(MemberIDLabel, 0, 0);
            ReturnHistLayoutPanel.Controls.Add(ReturnsDataGridView, 0, 2);
            ReturnHistLayoutPanel.Controls.Add(MemberNameLabel, 0, 1);
            ReturnHistLayoutPanel.Location = new Point(14, 56);
            ReturnHistLayoutPanel.Name = "ReturnHistLayoutPanel";
            ReturnHistLayoutPanel.RowCount = 3;
            ReturnHistLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 34.83146F));
            ReturnHistLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 65.16854F));
            ReturnHistLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            ReturnHistLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ReturnHistLayoutPanel.Size = new Size(427, 414);
            ReturnHistLayoutPanel.TabIndex = 0;
            // 
            // MemberIDLabel
            // 
            MemberIDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberIDLabel.Location = new Point(3, 0);
            MemberIDLabel.Name = "MemberIDLabel";
            MemberIDLabel.Size = new Size(207, 25);
            MemberIDLabel.TabIndex = 26;
            MemberIDLabel.Text = "Member ID: ";
            // 
            // ReturnsDataGridView
            // 
            ReturnsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnsDataGridView.Columns.AddRange(new DataGridViewColumn[] { LineItemID, ReturnTransactionID, UserID, FurnitureID, Quantity, FineOrRefund, ReturnDate });
            ReturnHistLayoutPanel.SetColumnSpan(ReturnsDataGridView, 2);
            ReturnsDataGridView.Location = new Point(3, 83);
            ReturnsDataGridView.Name = "ReturnsDataGridView";
            ReturnsDataGridView.RowHeadersWidth = 51;
            ReturnsDataGridView.Size = new Size(421, 328);
            ReturnsDataGridView.TabIndex = 1;
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MemberNameLabel.Location = new Point(3, 28);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(207, 29);
            MemberNameLabel.TabIndex = 25;
            MemberNameLabel.Text = "Member Name: ";
            // 
            // TransactionDALBindingSource
            // 
            TransactionDALBindingSource.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // infoMessageLabel
            // 
            infoMessageLabel.AutoSize = true;
            infoMessageLabel.Font = new Font("Segoe UI Semibold", 7F);
            infoMessageLabel.Location = new Point(31, 22);
            infoMessageLabel.Name = "infoMessageLabel";
            infoMessageLabel.Size = new Size(0, 15);
            infoMessageLabel.TabIndex = 37;
            // 
            // transactionDALBindingSource1
            // 
            transactionDALBindingSource1.DataSource = typeof(Employees.DAL.TransactionDAL);
            // 
            // LineItemID
            // 
            LineItemID.DataPropertyName = "line_item_id";
            LineItemID.HeaderText = "Line Item ID";
            LineItemID.MinimumWidth = 6;
            LineItemID.Name = "LineItemID";
            LineItemID.Width = 125;
            // 
            // ReturnTransactionID
            // 
            ReturnTransactionID.DataPropertyName = "return_transaction_id";
            ReturnTransactionID.HeaderText = "Return Transaction ID";
            ReturnTransactionID.MinimumWidth = 6;
            ReturnTransactionID.Name = "ReturnTransactionID";
            ReturnTransactionID.Width = 125;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "member_id";
            UserID.HeaderText = "Member ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // FurnitureID
            // 
            FurnitureID.DataPropertyName = "furniture_id";
            FurnitureID.HeaderText = "Furniture ID";
            FurnitureID.MinimumWidth = 6;
            FurnitureID.Name = "FurnitureID";
            FurnitureID.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // FineOrRefund
            // 
            FineOrRefund.DataPropertyName = "fine_or_refund";
            FineOrRefund.HeaderText = "Fine or Refund";
            FineOrRefund.MinimumWidth = 6;
            FineOrRefund.Name = "FineOrRefund";
            FineOrRefund.Width = 125;
            // 
            // ReturnDate
            // 
            ReturnDate.DataPropertyName = "return_date";
            ReturnDate.HeaderText = "Return Date";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Width = 125;
            // 
            // ViewReturnHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 510);
            Controls.Add(infoMessageLabel);
            Controls.Add(ReturnHistLayoutPanel);
            Name = "ViewReturnHistoryForm";
            Text = "Return History";
            Load += ViewReturnHistory_Load;
            ReturnHistLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReturnsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransactionDALBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDALBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel ReturnHistLayoutPanel;
        private DataGridView ReturnsDataGridView;
        private BindingSource TransactionDALBindingSource;
        private Label MemberNameLabel;
        private Label MemberIDLabel;
        private Label infoMessageLabel;
        private BindingSource transactionDALBindingSource1;
        private DataGridViewTextBoxColumn LineItemID;
        private DataGridViewTextBoxColumn ReturnTransactionID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FurnitureID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn FineOrRefund;
        private DataGridViewTextBoxColumn ReturnDate;
    }
}