namespace cs6232_g4.View
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            navigationLabel = new Label();
            CloseBbutton = new Button();
            SuspendLayout();
            // 
            // navigationLabel
            // 
            navigationLabel.Location = new Point(12, 12);
            navigationLabel.Name = "navigationLabel";
            navigationLabel.Size = new Size(289, 261);
            navigationLabel.TabIndex = 0;
            navigationLabel.Text = resources.GetString("navigationLabel.Text");
            // 
            // CloseBbutton
            // 
            CloseBbutton.Location = new Point(193, 281);
            CloseBbutton.Name = "CloseBbutton";
            CloseBbutton.Size = new Size(94, 29);
            CloseBbutton.TabIndex = 1;
            CloseBbutton.Text = "Close";
            CloseBbutton.UseVisualStyleBackColor = true;
            CloseBbutton.Click += CloseBbutton_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 322);
            Controls.Add(CloseBbutton);
            Controls.Add(navigationLabel);
            Name = "IndexForm";
            Text = "App Navigation";
            ResumeLayout(false);
        }

        #endregion

        private Label navigationLabel;
        private Button CloseBbutton;
    }
}