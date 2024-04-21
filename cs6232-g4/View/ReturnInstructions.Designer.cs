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
            instructionsTableLayoutPanel.Location = new Point(21, 24);
            instructionsTableLayoutPanel.Name = "instructionsTableLayoutPanel";
            instructionsTableLayoutPanel.Padding = new Padding(3);
            instructionsTableLayoutPanel.RowCount = 3;
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8653851F));
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.13461F));
            instructionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instructionsTableLayoutPanel.Size = new Size(453, 265);
            instructionsTableLayoutPanel.TabIndex = 0;
            // 
            // instructionsHeaderLabel
            // 
            instructionsHeaderLabel.BackColor = SystemColors.ControlLight;
            instructionsHeaderLabel.Dock = DockStyle.Fill;
            instructionsHeaderLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instructionsHeaderLabel.Location = new Point(6, 3);
            instructionsHeaderLabel.Name = "instructionsHeaderLabel";
            instructionsHeaderLabel.Size = new Size(441, 33);
            instructionsHeaderLabel.TabIndex = 1;
            instructionsHeaderLabel.Text = "Rental Instructions";
            // 
            // label1
            // 
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(441, 165);
            label1.TabIndex = 41;
            label1.Text = resources.GetString("label1.Text");
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Right;
            CloseButton.Location = new Point(312, 219);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(135, 34);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReturnInstructionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 311);
            Controls.Add(instructionsTableLayoutPanel);
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