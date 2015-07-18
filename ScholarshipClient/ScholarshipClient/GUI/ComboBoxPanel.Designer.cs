namespace ScholarshipClient.GUI
{
    partial class ComboBoxPanel
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
            this.contentComboBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 12);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            this.titleLabel.SizeChanged += new System.EventHandler(this.titleLabel_SizeChanged);
            // 
            // contentComboBox
            // 
            this.contentComboBox.ForeColor = System.Drawing.Color.Black;
            this.contentComboBox.FormattingEnabled = true;
            this.contentComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contentComboBox.Location = new System.Drawing.Point(50, 3);
            this.contentComboBox.Name = "contentComboBox";
            this.contentComboBox.Size = new System.Drawing.Size(131, 20);
            this.contentComboBox.TabIndex = 2;
            this.contentComboBox.Text = "请从下列选项中选择";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(48, 26);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 12);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.SizeChanged += new System.EventHandler(this.errorLabel_SizeChanged);
            // 
            // ComboBoxPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.contentComboBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "ComboBoxPanel";
            this.Size = new System.Drawing.Size(184, 38);
            this.SizeChanged += new System.EventHandler(this.ComboBoxPanel_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.ComboBox contentComboBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
