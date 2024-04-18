namespace cs6232_g4.UserControls
{
    partial class AdminReportUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            InstructionsLabel = new Label();
            SelectEndDateLabel = new Label();
            SelectStartDatelabel = new Label();
            GetReportButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            InfoLabel = new Label();
            StartDateTimePicker = new DateTimePicker();
            ReportDataGridView = new DataGridView();
            EndDateTimePicker = new DateTimePicker();
            StartDateErrorLabel = new Label();
            EndDateErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.AutoSize = true;
            InstructionsLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InstructionsLabel.Location = new Point(13, 13);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(384, 25);
            InstructionsLabel.TabIndex = 13;
            InstructionsLabel.Text = "Select Start and End Dates to create the report.";
            // 
            // SelectEndDateLabel
            // 
            SelectEndDateLabel.AutoSize = true;
            SelectEndDateLabel.Location = new Point(3, 71);
            SelectEndDateLabel.Name = "SelectEndDateLabel";
            SelectEndDateLabel.Size = new Size(121, 20);
            SelectEndDateLabel.TabIndex = 3;
            SelectEndDateLabel.Text = "Select End Date: ";
            // 
            // SelectStartDatelabel
            // 
            SelectStartDatelabel.AutoSize = true;
            SelectStartDatelabel.Location = new Point(3, 0);
            SelectStartDatelabel.Name = "SelectStartDatelabel";
            SelectStartDatelabel.Size = new Size(127, 20);
            SelectStartDatelabel.TabIndex = 0;
            SelectStartDatelabel.Text = "Select Start Date: ";
            // 
            // GetReportButton
            // 
            GetReportButton.FlatStyle = FlatStyle.Popup;
            GetReportButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GetReportButton.Location = new Point(509, 3);
            GetReportButton.Name = "GetReportButton";
            GetReportButton.Size = new Size(325, 29);
            GetReportButton.TabIndex = 4;
            GetReportButton.Text = "Create Report";
            GetReportButton.UseVisualStyleBackColor = true;
            GetReportButton.Click += GetReportButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332F));
            tableLayoutPanel1.Controls.Add(InfoLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(GetReportButton, 2, 0);
            tableLayoutPanel1.Controls.Add(SelectStartDatelabel, 0, 0);
            tableLayoutPanel1.Controls.Add(StartDateTimePicker, 1, 0);
            tableLayoutPanel1.Controls.Add(ReportDataGridView, 1, 4);
            tableLayoutPanel1.Controls.Add(SelectEndDateLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(EndDateTimePicker, 1, 2);
            tableLayoutPanel1.Controls.Add(StartDateErrorLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(EndDateErrorLabel, 1, 3);
            tableLayoutPanel1.Location = new Point(13, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(837, 565);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // InfoLabel
            // 
            InfoLabel.Font = new Font("Segoe UI", 11F);
            InfoLabel.ForeColor = Color.Red;
            InfoLabel.Location = new Point(509, 107);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(326, 31);
            InfoLabel.TabIndex = 38;
            InfoLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Location = new Point(199, 3);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new Size(250, 27);
            StartDateTimePicker.TabIndex = 15;
            StartDateTimePicker.ValueChanged += StartDateTimePicker_ValueChanged;
            // 
            // ReportDataGridView
            // 
            ReportDataGridView.AllowUserToAddRows = false;
            ReportDataGridView.AllowUserToDeleteRows = false;
            ReportDataGridView.AllowUserToResizeRows = false;
            ReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ReportDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ReportDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(ReportDataGridView, 3);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReportDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ReportDataGridView.Dock = DockStyle.Fill;
            ReportDataGridView.Location = new Point(3, 156);
            ReportDataGridView.Name = "ReportDataGridView";
            ReportDataGridView.ReadOnly = true;
            ReportDataGridView.RowHeadersWidth = 51;
            ReportDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportDataGridView.Size = new Size(832, 406);
            ReportDataGridView.TabIndex = 17;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Location = new Point(199, 74);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(250, 27);
            EndDateTimePicker.TabIndex = 16;
            EndDateTimePicker.ValueChanged += EndDateTimePicker_ValueChanged;
            // 
            // StartDateErrorLabel
            // 
            StartDateErrorLabel.Location = new Point(199, 35);
            StartDateErrorLabel.Name = "StartDateErrorLabel";
            StartDateErrorLabel.Size = new Size(304, 36);
            StartDateErrorLabel.TabIndex = 18;
            // 
            // EndDateErrorLabel
            // 
            EndDateErrorLabel.Location = new Point(199, 107);
            EndDateErrorLabel.Name = "EndDateErrorLabel";
            EndDateErrorLabel.Size = new Size(304, 31);
            EndDateErrorLabel.TabIndex = 19;
            // 
            // AdminReportUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(InstructionsLabel);
            Name = "AdminReportUserControl";
            Size = new Size(861, 631);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InstructionsLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button GetReportButton;
        private Label SelectStartDatelabel;
        private Label SelectEndDateLabel;
        private DateTimePicker StartDateTimePicker;
        private DataGridView ReportDataGridView;
        private DateTimePicker EndDateTimePicker;
        private Label StartDateErrorLabel;
        private Label EndDateErrorLabel;
        public Label InfoLabel;
    }
}
