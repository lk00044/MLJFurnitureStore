namespace cs6232_g4.View
{
    partial class UpdateMemberForm
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
            editMemberInfoUserControl1 = new UserControls.EditMemberInfoUserControl();
            SuspendLayout();
            // 
            // editMemberInfoUserControl1
            // 
            editMemberInfoUserControl1.Dock = DockStyle.Top;
            editMemberInfoUserControl1.Location = new Point(0, 0);
            editMemberInfoUserControl1.Name = "editMemberInfoUserControl1";
            editMemberInfoUserControl1.Size = new Size(1003, 769);
            editMemberInfoUserControl1.TabIndex = 0;
            // 
            // UpdateMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 615);
            Controls.Add(editMemberInfoUserControl1);
            Name = "UpdateMemberForm";
            Text = "Rent Me Furniture Rentals : : Update Member";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.EditMemberInfoUserControl editMemberInfoUserControl1;
    }
}