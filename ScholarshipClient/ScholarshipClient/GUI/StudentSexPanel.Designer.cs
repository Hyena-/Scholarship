namespace ScholarshipClient.GUI
{
    partial class StudentSexPanel
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
            // contentComboBox
            // 
            this.contentComboBox.Location = new System.Drawing.Point(47, 3);
            this.contentComboBox.Size = new System.Drawing.Size(70, 20);
            this.contentComboBox.Text = "";
            // 
            // StudentSexPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContentWidth = 70;
            this.Name = "StudentSexPanel";
            this.Size = new System.Drawing.Size(120, 38);
            this.Title = "性别：";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
