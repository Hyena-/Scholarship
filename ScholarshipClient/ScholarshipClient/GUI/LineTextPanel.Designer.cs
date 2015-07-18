namespace ScholarshipClient.GUI
{
    partial class LineTextPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(2, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 12);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "title";
            this.titleLabel.SizeChanged += new System.EventHandler(this.titleLabel_SizeChanged);
            // 
            // contentTextBox
            // 
            this.contentTextBox.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.contentTextBox.Location = new System.Drawing.Point(44, 3);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(100, 21);
            this.contentTextBox.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(42, 27);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 12);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.SizeChanged += new System.EventHandler(this.errorLabel_SizeChanged);
            // 
            // LineTextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "LineTextPanel";
            this.Size = new System.Drawing.Size(147, 39);
            this.SizeChanged += new System.EventHandler(this.TextPanel_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
