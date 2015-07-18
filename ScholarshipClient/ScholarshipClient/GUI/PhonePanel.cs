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
    public partial class PhonePanel : LineTextPanel
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
        public const int LENGTH_ERROR = 2;
        public const int NOTNUMBER_ERROR = 3;
        public const int UNKNOW_ERROR = 4;

        public const int DEFAULT_LENGTH = 11;       //默认长度

        public PhonePanel()
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
                else if (this.Content.Length != DEFAULT_LENGTH)
                {
                    this.hasError = true;
                    this.errorID = LENGTH_ERROR;
                }
                else
                {
                    this.hasError = false;
                    this.errorID = NO_ERROR;
                    char[] arr = this.Content.ToCharArray();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!char.IsDigit(arr[i]))
                        {
                            this.hasError = true;
                            this.errorID = NOTNUMBER_ERROR;
                            break;
                        }
                    }
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
            String res;
            switch (this.errorID)
            {
                case NO_ERROR:
                    res = "";
                    break;
                case CONTENT_NULL:
                    res = "内容不能为空！";
                    break;
                case LENGTH_ERROR:
                    res = "联系电话为" + DEFAULT_LENGTH + "位手机号！";
                    break;
                case NOTNUMBER_ERROR:
                    res = "联系电话必须为数字！";
                    break;
                case UNKNOW_ERROR:
                    res = "未知错误，请检查输入！";
                    break;
                default:
                    res = "";
                    break;
            }
            return res;
        }

        public String getPhoneString()
        {
            return "" + this.Content;
        }
    }
}
