using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarshipClient.GUI
{
    public partial class LineTextPanel : UserControl
    {

        public String Title
        {
            get { return titleLabel.Text; }
            set 
            {
                this.titleLabel.Text = value;
            }
        }
        public String Content
        {
            get { return this.contentTextBox.Text; }
            set 
            {
                this.contentTextBox.Text = value;
            }
        }
        public int ContentWidth
        {
            get { return this.contentTextBox.Size.Width; }
            set
            {
                this.contentTextBox.SetBounds(
                    this.contentTextBox.Location.X,
                    this.contentTextBox.Location.Y,
                    value,
                    this.contentTextBox.Size.Height);
            }
        }
        public String Error
        {
            get { return this.errorLabel.Text; }
            set 
            {
                this.errorLabel.Text = value;
            }
        }
      
        public LineTextPanel()
        {
            InitializeComponent();
        }

        private void errorLabel_SizeChanged(object sender, EventArgs e)
        {
            if(this.errorLabel.Size.Width < this.contentTextBox.Size.Width)
            {
                return;
            }
            else
            {
                this.errorLabel.SetBounds(
                    this.errorLabel.Location.X,
                    this.errorLabel.Location.Y,
                    this.contentTextBox.Size.Width,
                    this.errorLabel.Size.Height);
            }
        }

        private void titleLabel_SizeChanged(object sender, EventArgs e)
        {
            int x = this.titleLabel.Location.X + this.titleLabel.Size.Width + this.titleLabel.Padding.Right + this.contentTextBox.Margin.Left;
            int y = this.contentTextBox.Location.Y;
            int width = this.contentTextBox.Size.Width;
            int height = this.contentTextBox.Size.Height;
            this.contentTextBox.SetBounds(x, y, width, height);
            y = this.errorLabel.Location.Y;
            width = this.errorLabel.Size.Width;
            height = this.errorLabel.Size.Height;
            this.errorLabel.SetBounds(x, y, width, height);
        }

        private void TextPanel_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Size.Width - this.contentTextBox.Location.X - this.contentTextBox.Margin.Right;
            this.contentTextBox.SetBounds(
                this.contentTextBox.Location.X, 
                this.contentTextBox.Location.Y, 
                width, 
                this.contentTextBox.Size.Height);
        }
    }
}
