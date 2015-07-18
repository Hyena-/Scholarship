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
    public partial class StudentNamePanel : LineTextPanel
    {
        private Boolean hasError;
        public Boolean HasError
        {
            get { return hasError; }
        }
        private int errorID;
        public int ErrorID
        {
            get { return errorID; }
            set { errorID = value; }
        }

        public const int NO_ERROR = 0;
        public const int CONTENT_NULL = 1;         //内容为空的错误
        public const int UNKNOW_ERROR = 2;

        public StudentNamePanel()
        {
            InitializeComponent();
            this.hasError = true;
            this.errorID = NO_ERROR;
        }

        private void contentTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                this.Content = this.Content.Trim();
                if ("".Equals(this.Content))
                {
                    this.hasError = true;
                    this.errorID = CONTENT_NULL;
                }
                else
                {
                    this.hasError = false;
                    this.errorID = NO_ERROR;
                }
            }
            catch
            {
                this.hasError = true;
                this.errorID = UNKNOW_ERROR;
            }
            this.Error = getErrorString();
        }

        private String getErrorString()
        {
            String res = "";
            switch(this.errorID)
            {
                case NO_ERROR:
                    res = "";
                    break;
                case CONTENT_NULL:
                    res = "请输入姓名！";
                    break;
                case UNKNOW_ERROR:
                    res = "未知错误，请核对内容！";
                    break;
                default:
                    res = "";
                    break;
            }
            return res;
        }

        public String getNameString()
        {
            String res = "" + this.Content;
            return res;
        }
    }
}
