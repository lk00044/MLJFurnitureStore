namespace cs6232_g4.View
{
    partial class LoginForm
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
            TableLayoutPanel = new TableLayoutPanel();
            LoginBox = new GroupBox();
            LblUsername = new Label();
            LblPassword = new Label();
            TextPassword = new TextBox();
            TextUsername = new TextBox();
            TableLayoutPanel.SuspendLayout();
            LoginBox.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(LoginBox, 0, 0);
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Size = new Size(621, 325);
            TableLayoutPanel.TabIndex = 1;
            // 
            // LoginBox
            // 
            LoginBox.Controls.Add(TextUsername);
            LoginBox.Controls.Add(TextPassword);
            LoginBox.Controls.Add(LblPassword);
            LoginBox.Controls.Add(LblUsername);
            LoginBox.Location = new Point(3, 3);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(615, 151);
            LoginBox.TabIndex = 0;
            LoginBox.TabStop = false;
            LoginBox.Text = "Login";
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 12F);
            LblUsername.Location = new Point(33, 45);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(99, 28);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "Username";
            LblUsername.Click += label1_Click_1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F);
            LblPassword.Location = new Point(33, 100);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(93, 28);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(182, 100);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(390, 27);
            TextPassword.TabIndex = 2;
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(182, 45);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(390, 27);
            TextUsername.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 327);
            Controls.Add(TableLayoutPanel);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            TableLayoutPanel.ResumeLayout(false);
            LoginBox.ResumeLayout(false);
            LoginBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel;
        private GroupBox LoginBox;
        private Label LblPassword;
        private Label LblUsername;
        private TextBox TextUsername;
        private TextBox TextPassword;
    }
}