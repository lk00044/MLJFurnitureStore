namespace Logon.View
{
    partial class LogOnForm
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
            UserIDInputLabel = new Label();
            PasswordInputLabel = new Label();
            UserIDInputTextBox = new TextBox();
            PasswordInputTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            PasswordErrorLabel = new Label();
            LogonButton = new Button();
            UserIDErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserIDInputLabel
            // 
            UserIDInputLabel.AutoSize = true;
            UserIDInputLabel.Location = new Point(3, 0);
            UserIDInputLabel.Name = "UserIDInputLabel";
            UserIDInputLabel.Size = new Size(127, 20);
            UserIDInputLabel.TabIndex = 1;
            UserIDInputLabel.Text = "Enter Your UserID:";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(3, 67);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(144, 20);
            PasswordInputLabel.TabIndex = 2;
            PasswordInputLabel.Text = "Enter Your Password:";
            // 
            // UserIDInputTextBox
            // 
            UserIDInputTextBox.Location = new Point(163, 3);
            UserIDInputTextBox.Name = "UserIDInputTextBox";
            UserIDInputTextBox.Size = new Size(180, 27);
            UserIDInputTextBox.TabIndex = 4;
            UserIDInputTextBox.Click += UserIDInputTextBox_Click;
            // 
            // PasswordInputTextBox
            // 
            PasswordInputTextBox.Location = new Point(163, 70);
            PasswordInputTextBox.Name = "PasswordInputTextBox";
            PasswordInputTextBox.Size = new Size(180, 27);
            PasswordInputTextBox.TabIndex = 5;
            PasswordInputTextBox.Click += PasswordInputTextBox_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8452721F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.1547279F));
            tableLayoutPanel1.Controls.Add(UserIDInputLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(UserIDInputTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(PasswordInputLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(PasswordInputTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(PasswordErrorLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(LogonButton, 1, 5);
            tableLayoutPanel1.Controls.Add(UserIDErrorLabel, 1, 1);
            tableLayoutPanel1.Location = new Point(41, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(349, 292);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.Location = new Point(163, 109);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(183, 41);
            PasswordErrorLabel.TabIndex = 6;
            // 
            // LogonButton
            // 
            LogonButton.Location = new Point(163, 242);
            LogonButton.Name = "LogonButton";
            LogonButton.Size = new Size(180, 41);
            LogonButton.TabIndex = 7;
            LogonButton.Text = "Log On";
            LogonButton.UseVisualStyleBackColor = true;
            LogonButton.Click += LogonButton_Click;
            // 
            // UserIDErrorLabel
            // 
            UserIDErrorLabel.Location = new Point(163, 35);
            UserIDErrorLabel.Name = "UserIDErrorLabel";
            UserIDErrorLabel.Size = new Size(180, 32);
            UserIDErrorLabel.TabIndex = 8;
            // 
            // LogOnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 367);
            Controls.Add(tableLayoutPanel1);
            Name = "LogOnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rent Me Furniture : Employee Logon";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label UserIDInputLabel;
        private Label PasswordInputLabel;
        private TextBox UserIDInputTextBox;
        private TextBox PasswordInputTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label PasswordErrorLabel;
        private Button LogonButton;
        private Label UserIDErrorLabel;
    }
}