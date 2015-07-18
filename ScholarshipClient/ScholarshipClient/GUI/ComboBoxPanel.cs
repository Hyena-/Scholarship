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
    public partial class ComboBoxPanel : UserControl
    {
        public String Title
        {
            get { return titleLabel.Text; }
            set
            {
                this.titleLabel.Text = value;
            }
        }
        public ControlBindingsCollection DataBindings
        {
            get { return this.contentComboBox.DataBindings; }
        }
        public object DataSource
        {
            get { return this.contentComboBox.DataSource; }
            set { this.contentComboBox.DataSource = value; }
        }
        public int ContentWidth
        {
            get { return this.contentComboBox.Size.Width; }
            set
            {
                this.contentComboBox.SetBounds(
                    this.contentComboBox.Location.X,
                    this.contentComboBox.Location.Y,
                    value,
                    this.contentComboBox.Size.Height);
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
        public String Topic 
        {
            set { this.contentComboBox.Text = value; }
        }
        private Boolean editable;
        public Boolean Editable
        {
            get { return editable; }
            set
            {
                if(value)
                {
                    this.contentComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                }
                else
                {
                    this.contentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                editable = value;
            }
        }

        public ComboBoxPanel()
        {
            InitializeComponent();
            editable = false;
            this.contentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ComboBoxPanel_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Size.Width - this.contentComboBox.Location.X - this.contentComboBox.Margin.Right;
            this.contentComboBox.SetBounds(
                this.contentComboBox.Location.X,
                this.contentComboBox.Location.Y,
                width,
                this.contentComboBox.Size.Height);
        }

        private void titleLabel_SizeChanged(object sender, EventArgs e)
        {
            int x = this.titleLabel.Location.X + this.titleLabel.Size.Width + this.titleLabel.Padding.Right + this.contentComboBox.Margin.Left;
            int y = this.contentComboBox.Location.Y;
            int width = this.contentComboBox.Size.Width;
            int height = this.contentComboBox.Size.Height;
            this.contentComboBox.SetBounds(x, y, width, height);
            y = this.errorLabel.Location.Y;
            width = this.errorLabel.Size.Width;
            height = this.errorLabel.Size.Height;
            this.errorLabel.SetBounds(x, y, width, height);
        }

        private void errorLabel_SizeChanged(object sender, EventArgs e)
        {
            if (this.errorLabel.Size.Width < this.contentComboBox.Size.Width)
            {
                return;
            }
            else
            {
                this.errorLabel.SetBounds(
                    this.errorLabel.Location.X,
                    this.errorLabel.Location.Y,
                    this.contentComboBox.Size.Width,
                    this.errorLabel.Size.Height);
            }
        }
    }
}
