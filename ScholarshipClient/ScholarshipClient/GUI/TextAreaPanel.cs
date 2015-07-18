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
    public partial class TextAreaPanel : UserControl
    {
        public String Content
        {
            get { return this.contentTextBox.Text; }
            set { this.contentTextBox.Text = value; }
        }

        public String Title
        {
            get { return this.titleLabel.Text; }
            set { this.titleLabel.Text = value; }
        }

        private int wordNumber;
        public int WordNumber
        {
            get { return wordNumber; }
            set
            {
                wordNumber = value;
                this.numberLabel.Text = nowNumber + "/" + wordNumber;
            }
        }
        private int nowNumber;
        public int NowNumber
        {
            get {
                return nowNumber; 
            }
            set
            {
                nowNumber = value;
                this.numberLabel.Text = nowNumber + "/" + wordNumber;
            }
        }
        public DateTime Date
        {
            get { return this.dateTimePicker.Value; }
            set { this.dateTimePicker.Value = value; }
        }
       
        public TextAreaPanel()
        {
            InitializeComponent();
        }

        private void contentTextBox_TextChanged(object sender, EventArgs e)
        {
            this.NowNumber = this.contentTextBox.TextLength;
        }
    }
}
