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
            TextUsername = new TextBox();
            TextPassword = new TextBox();
            LblPassword = new Label();
            LblUsername = new Label();
            BtnLogin = new Button();
            LblError = new Label();
            TableLayoutPanel.SuspendLayout();
            LoginBox.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 1;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(LoginBox, 0, 0);
            TableLayoutPanel.Controls.Add(BtnLogin, 0, 1);
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 2;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Size = new Size(659, 417);
            TableLayoutPanel.TabIndex = 1;
            // 
            // LoginBox
            // 
            LoginBox.Controls.Add(LblError);
            LoginBox.Controls.Add(TextUsername);
            LoginBox.Controls.Add(TextPassword);
            LoginBox.Controls.Add(LblPassword);
            LoginBox.Controls.Add(LblUsername);
            LoginBox.Dock = DockStyle.Fill;
            LoginBox.Location = new Point(3, 3);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(653, 202);
            LoginBox.TabIndex = 0;
            LoginBox.TabStop = false;
            LoginBox.Text = "Login";
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(182, 45);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(390, 27);
            TextUsername.TabIndex = 3;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(182, 100);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(390, 27);
            TextPassword.TabIndex = 2;
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
            LblPassword.TextAlign = ContentAlignment.MiddleCenter;
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
            LblUsername.TextAlign = ContentAlignment.MiddleCenter;
            LblUsername.Click += label1_Click_1;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI", 14F);
            BtnLogin.Location = new Point(3, 211);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(618, 70);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.Font = new Font("Segoe UI", 10F);
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(241, 155);
            LblError.Name = "LblError";
            LblError.Size = new Size(0, 23);
            LblError.TabIndex = 4;
            LblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 289);
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
        private Button BtnLogin;
        private Label LblError;
    }
}