namespace ScholarshipClient.GUI
{
    partial class TextAreaPanel
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 12);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTextBox.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.contentTextBox.Location = new System.Drawing.Point(5, 29);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(426, 179);
            this.contentTextBox.TabIndex = 1;
            this.contentTextBox.TextChanged += new System.EventHandler(this.contentTextBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(3, 210);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 12);
            this.errorLabel.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(390, 210);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(41, 12);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "label1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker.Location = new System.Drawing.Point(298, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2015, 7, 7, 14, 44, 19, 894);
            // 
            // timeTitleLabel
            // 
            this.timeTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTitleLabel.AutoSize = true;
            this.timeTitleLabel.Location = new System.Drawing.Point(251, 9);
            this.timeTitleLabel.Name = "timeTitleLabel";
            this.timeTitleLabel.Size = new System.Drawing.Size(41, 12);
            this.timeTitleLabel.TabIndex = 5;
            this.timeTitleLabel.Text = "时间：";
            // 
            // TextAreaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeTitleLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "TextAreaPanel";
            this.Size = new System.Drawing.Size(434, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label timeTitleLabel;
    }
}
