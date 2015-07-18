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
    public partial class StudentIDPanel : LineTextPanel
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
        private int enrollYear;
        public int EnrollYear
        {
            get { return enrollYear; }
            set { enrollYear = EnrollYear; }
        }
        private int enrollMonth;
        public int EnrollMonth
        {
            get { return enrollMonth; }
            set { enrollMonth = value; }
        }

        public const int NO_ERROR = 0;
        public const int CONTENT_NULL = 1;         //内容为空的错误
        public const int LENGTH_ERROR = 2;         //长度不对
        public const int NOTNUMBER_ERROR = 3;      //不是数字串
        public const int UNKNOW_ERROR = 4;

        public const int DEFAULT_LENGTH = 12;         //正确的位数
        public const int DEFAULT_ENROLL_MONTH = 9;    //默认入学月份

        public StudentIDPanel()
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
                    res = "内容不能为空！";
                    break;
                case LENGTH_ERROR:
                    res = "学号应为" + DEFAULT_LENGTH + "位数字组成！";
                    break;
                case NOTNUMBER_ERROR:
                    res = "学号必须为数字！";
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

        private void contentTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                this.Content = this.Content.Trim();
                if("".Equals(this.Content))
                {
                    this.hasError = true;
                    this.errorID = CONTENT_NULL;
                }
                else if(this.Content.Length != DEFAULT_LENGTH)
                {
                    this.hasError = true;
                    this.errorID = LENGTH_ERROR;               
                }
                else
                {
                    this.hasError = false;
                    this.errorID = NO_ERROR;
                    char[] arr = this.Content.ToCharArray();
                    for(int i = 0 ; i < arr.Length; i++)
                    {
                        if(!char.IsDigit(arr[i]))
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
            this.Error = this.getErrorString();
            if(!hasError)
            {
                this.enrollYear = int.Parse(this.Content.Substring(0, 4));
                this.enrollMonth = DEFAULT_ENROLL_MONTH;
            }
        }

        public String getStudentIDString()
        {
            String res = "" + this.Content;
            return res;
        }

        public String getEnrollString()
        {
            String res = this.enrollYear + "年";
            if(this.enrollMonth < 10)
            {
                res += "0" + this.enrollMonth + "月";
            }
            else
            {
                res += this.enrollMonth + "月";
            }
            return res;
        }
    
    }
}
