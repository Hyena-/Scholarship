namespace ScholarshipClient.GUI
{
    partial class PhonePanel
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
            this.contentTextBox.Location = new System.Drawing.Point(70, 3);
            this.contentTextBox.Validated += new System.EventHandler(this.contentTextBox_Validated);
            // 
            // PhonePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PhonePanel";
            this.Size = new System.Drawing.Size(173, 39);
            this.Title = "联系电话：";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
