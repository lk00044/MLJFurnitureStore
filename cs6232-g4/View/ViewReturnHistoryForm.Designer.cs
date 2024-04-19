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
            ReturnHistLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionDALBindingSource).BeginInit();
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
    }
}