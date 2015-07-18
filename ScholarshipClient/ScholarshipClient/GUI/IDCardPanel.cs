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
    public partial class IDCardPanel : LineTextPanel
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
        public const int CONTENT_ERROR = 2;        //内容格式的错误

        public IDCardPanel()
        {
            InitializeComponent();
            this.hasError = true;
            this.errorID = NO_ERROR;
        }

        public String getIDString()
        {
            return this.Content;
        }
        
        public String getBirthDayString()
        {
            return this.Content.Substring(6, 4) + "年" + this.Content.Substring(10, 2) + "月";
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
                    res = "请输入正确的身份证号码！";
                    break;
                default:
                    res = "";
                    break;
            }
            return res;
        }

        private void contentTextBox_Validated(object sender, EventArgs e)
        {
            this.Content = this.Content.Trim();
            if(this.Content == null || "".Equals(this.Content))
            {
                this.hasError = true;
                this.errorID = IDCardPanel.CONTENT_NULL;
            }
            else if(this.Content.Length != 18)
            {
                this.errorID = IDCardPanel.CONTENT_ERROR;
                this.hasError = true;
            }
            else
            {
                Char[] chars = this.Content.ToCharArray();
                int i;
                for(i = 0 ; i < this.Content.Length - 1; i++)
                {
                    if(Char.IsDigit(chars[i]))
                    {
                        continue;
                    }
                    else
                    {
                        this.hasError = true;
                        this.errorID = IDCardPanel.CONTENT_ERROR;
                        break;
                    }
                }
                if(i == this.Content.Length - 1)
                {
                    if(Char.IsDigit(chars[i]) || chars[i].Equals('X'))
                    {
                        this.errorID = IDCardPanel.NO_ERROR;
                        this.hasError = false;
                    }
                    else
                    {
                        this.errorID = IDCardPanel.CONTENT_ERROR;
                        this.hasError = true;
                    }
                }
            }
            this.Error = this.getErrorString();
        }


    }
}