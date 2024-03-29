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
            TextUsername = new TextBox();
            TextPassword = new TextBox();
            LblPassword = new Label();
            LblUsername = new Label();
            BtnLogin = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            UserNameErrorlabel = new Label();
            PasswordErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(111, 3);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(202, 27);
            TextUsername.TabIndex = 1;
            TextUsername.Click += TextUsername_Click;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(111, 72);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '*';
            TextPassword.Size = new Size(202, 27);
            TextPassword.TabIndex = 2;
            TextPassword.Click += TextPassword_Click;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.Location = new Point(3, 69);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(80, 23);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            LblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsername.Location = new Point(3, 0);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(87, 23);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "Username";
            LblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(111, 144);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(202, 42);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += btnLogin_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4117661F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5882339F));
            tableLayoutPanel1.Controls.Add(LblUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(TextUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(LblPassword, 0, 2);
            tableLayoutPanel1.Controls.Add(TextPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(UserNameErrorlabel, 1, 1);
            tableLayoutPanel1.Controls.Add(PasswordErrorLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(BtnLogin, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.623188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.376812F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(316, 224);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // UserNameErrorlabel
            // 
            UserNameErrorlabel.Location = new Point(111, 37);
            UserNameErrorlabel.Name = "UserNameErrorlabel";
            UserNameErrorlabel.Size = new Size(202, 25);
            UserNameErrorlabel.TabIndex = 4;
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.Location = new Point(111, 110);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(202, 25);
            PasswordErrorLabel.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 270);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LblPassword;
        private Label LblUsername;
        private TextBox TextUsername;
        private TextBox TextPassword;
        private Button BtnLogin;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UserNameErrorlabel;
        private Label PasswordErrorLabel;
    }
}