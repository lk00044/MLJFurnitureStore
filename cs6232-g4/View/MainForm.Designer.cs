namespace cs6232_g4
{
    partial class MainForm
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
            memberRegistrationUserControl1 = new UserControls.MemberRegistrationUserControl();
            SuspendLayout();
            // 
            // memberRegistrationUserControl1
            // 
            memberRegistrationUserControl1.Location = new Point(0, 0);
            memberRegistrationUserControl1.Name = "memberRegistrationUserControl1";
            memberRegistrationUserControl1.Size = new Size(415, 650);
            memberRegistrationUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 685);
            Controls.Add(memberRegistrationUserControl1);
            Name = "MainForm";
            Text = "MLJ Furniture";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.MemberRegistrationUserControl memberRegistrationUserControl1;
    }
}