namespace ScholarshipClient.GUI
{
    partial class StudentNumbersPanel
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
            this.contentTextBox.Location = new System.Drawing.Point(82, 3);
            // 
            // StudentNumbersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "StudentNumbersPanel";
            this.Size = new System.Drawing.Size(185, 39);
            this.Title = "专业总人数：";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
