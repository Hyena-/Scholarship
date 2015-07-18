namespace ScholarshipClient.GUI
{
    partial class SchoolPanel
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
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(46, 3);
            this.contentTextBox.Size = new System.Drawing.Size(200, 21);
            this.contentTextBox.Text = "山东大学（威海）";
            this.contentTextBox.Validated += new System.EventHandler(this.contentTextBox_Validated);
            // 
            // SchoolPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Content = "山东大学（威海）";
            this.ContentWidth = 200;
            this.Name = "SchoolPanel";
            this.Size = new System.Drawing.Size(249, 39);
            this.Title = "学校：";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
