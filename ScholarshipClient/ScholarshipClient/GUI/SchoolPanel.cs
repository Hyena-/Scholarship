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
    public partial class SchoolPanel : LineTextPanel
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
        public const int CONTENT_ERROR = 2;        //内容不对的错误
        public const int UNKNOW_ERROR = 3;
        public const String School_Name = "山东大学（威海）";

        public SchoolPanel()
        {
            InitializeComponent();
            this.hasError = true;
            this.errorID = NO_ERROR;
        }

        private String getErrorString()
        {
            String res;
            switch (this.errorID)
            {
                case NO_ERROR:
                    res = "";
                    break;
                case CONTENT_NULL:
                    res = "内容不能为空";
                    break;
                case CONTENT_ERROR:
                    res = "内容有误，请输入“" + School_Name + "”";
                    break;
                case UNKNOW_ERROR:
                    res = "未知错误，请检查输入";
                    break;
                default:
                    res = "";
                    break;
            }
            return res;
        }

        private void contentTextBox_Validated(object sender, EventArgs e)
        {
            if (!School_Name.Equals(this.Content))
            {
                this.Content = this.Content.Trim();
                this.hasError = true;
                try
                {
                    String str = this.Content.Trim();
                    if ("".Equals(str))
                    {
                        this.errorID = CONTENT_NULL;
                    }
                    else
                    {
                        this.errorID = CONTENT_ERROR;
                        
                    }
                }
                catch
                {
                    this.errorID = UNKNOW_ERROR;
                }
            }
            else
            {
                this.hasError = false;
                this.errorID = NO_ERROR;
            }

            this.Error = getErrorString();
        }

        public String getSchoolString()
        {
            String res = "" + this.Content;
            return res;
        }
    }
}
