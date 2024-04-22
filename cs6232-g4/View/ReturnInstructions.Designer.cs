namespace cs6232_g4.View
{
    partial class ReturnInstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnInstructionsForm));
            instructionsTableLayoutPanel = new TableLayoutPanel();
            instructionsHeaderLabel = new Label();
            label1 = new Label();
            CloseButton = new Button();
            instructionsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // instructionsTableLayoutPanel
            // 
            instructionsTableLayoutPanel.ColumnCount = 1;
            instructionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            instructionsTableLayoutPanel.Controls.Add(instructionsHeaderLabel, 0, 0);
            instructionsTableLayoutPanel.Controls.Add(label1, 0, 1);
            instructionsTableLayoutPanel.Controls.Add(CloseButton, 0, 2);
            instructionsTableLayoutPanel.Location = new Point(18, 18);
            instructionsTableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            instructionsTableLayoutPanel.Name = "instructionsTableLayoutPanel";
            instructionsTableLayoutPanel.Padding = new Padding(3, 2, 3, 2);
            instructionsTableLayoutPanel.RowCount = 3;
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8653851F));
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.13461F));
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            instructionsTableLayoutPanel.Size = new Size(499, 327);
            instructionsTableLayoutPanel.TabIndex = 0;
            // 
            // instructionsHeaderLabel
            // 
            instructionsHeaderLabel.BackColor = SystemColors.ControlLight;
            instructionsHeaderLabel.Dock = DockStyle.Fill;
            instructionsHeaderLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsHeaderLabel.Location = new Point(6, 2);
            instructionsHeaderLabel.Name = "instructionsHeaderLabel";
            instructionsHeaderLabel.Size = new Size(487, 45);
            instructionsHeaderLabel.TabIndex = 1;
            instructionsHeaderLabel.Text = "Return Instructions";
            // 
            // label1
            // 
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(487, 239);
            label1.TabIndex = 41;
            label1.Text = resources.GetString("label1.Text");
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Right;
            CloseButton.Location = new Point(375, 292);
            CloseButton.Margin = new Padding(3, 2, 3, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(118, 26);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReturnInstructionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 365);
            Controls.Add(instructionsTableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReturnInstructionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Instructions";
            instructionsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel instructionsTableLayoutPanel;
        private Label instructionsHeaderLabel;
        private Label label1;
        private Button CloseButton;
    }
}