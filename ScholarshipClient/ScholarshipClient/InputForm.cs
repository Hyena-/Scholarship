using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office;
using Microsoft.Office.Interop.Word;
using ScholarshipClient.GUI;

namespace ScholarshipClient
{
    public partial class InputForm : Form
    {
        private int pageNow;
        public int PageNow
        {
            get { return pageNow; }
            set {
                switch(value)
                {
                    case 1:
                        this.beforePageButton.Enabled = false;
                        this.nextPageButton.Enabled = true;
                        this.basePanel.Visible = true;
                        this.studyPanel.Visible = false;
                        this.reasonPanel.Visible = false;
                        pageNow = value;
                        break;
                    case 2:
                        this.beforePageButton.Enabled = true;
                        this.nextPageButton.Enabled = true;
                        this.basePanel.Visible = false;
                        this.studyPanel.Visible = true;
                        this.reasonPanel.Visible = false;
                        pageNow = value;
                        break;
                    case 3:
                        this.beforePageButton.Enabled = true;
                        this.nextPageButton.Enabled = false;
                        this.basePanel.Visible = false;
                        this.studyPanel.Visible = false;
                        this.reasonPanel.Visible = true;
                        pageNow = value;
                        break;
                    default:
                        break;
                }
            }
        }

        public String StudentName
        {
            get { return this.studentNamePanel2.getNameString(); }
        }
        public String StudentID
        {
            get { return this.studentIDPanel2.getStudentIDString(); }
        }
        public String Academic
        {
            get { return this.academicPanel1.getAcademicString(); }
        }
        public String BirthDay
        { 
            get { return this.idCardPanel2.getBirthDayString(); }
        }
        public String Nation
        {
            get { return this.nationPanel1.getNationString(); }
        }
        public String EnrollTime
        {
            get { return this.studentIDPanel2.getEnrollString(); }
        }
        public String Sex
        {
            get { return this.studentSexPanel2.getSexString(); }
        }
        public String Policity
        {
            get { return this.studentPolicityPanel2.getStudentPolicityString(); }
        }
        public String Profession
        {
            get { return this.professionPanel1.getProfessionString(); }
        }
        public String Years
        {
            get { return this.studentYearsPanel1.getStudentYearsString(); }
        }
        public String Phone
        {
            get { return this.phonePanel2.getPhoneString(); }
        }
        public String Sum
        {
            get { return ""+this.studentNumbersPanel1.getStudentNumbers(); }
        }
        public String ScoleRank
        {
            get {return ""+this.scoleRankPanel1.getScoleRank();}
        }
        public String SyntheticRank
        {
            get {return "" + this.syntheticRankPanel1.getSyntheticRank();}
        }
        public String LessonNumber
        {
            get { return "" + this.lessonNumberPanel1.getLessonNumber(); }
        }
        public String ID
        {
            get { return "" + this.idCardPanel2.getIDString(); }
        }
        public List<Schema> Schemas
        {
            get { return this.schemasPanel1.Schemas; }
        }


        public InputForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            this.PageNow = 1;
            this.basePanel.Visible = true;
            this.studyPanel.Visible = false;
            this.reasonPanel.Visible = false;
        }

        private void beforePageButton_Click(object sender, EventArgs e)
        {
            this.PageNow = pageNow - 1;
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            this.PageNow = pageNow + 1;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //**********************************************
            //来自博客http://blog.csdn.net/fujie724
            //**********************************************
            object oMissing = System.Reflection.Missing.Value;
            //创建一个Word应用程序实例
            Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
            //设置为不可见
            oWord.Visible = true;
            //模板文件地址
            object oTemplate = "E:/VS-workspace/Scholarship/ScholarshipClient/ScholarshipClient/demo.dot";
            //以模板为基础生成文档
            Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);
            //声明书签数组
            object[] oBookMark = new object[61];
            //赋值书签名
            oBookMark[0] = "学年时间1";
            oBookMark[1] = "学年时间2";
            oBookMark[2] = "学院";
            oBookMark[3] = "学号";
            oBookMark[4] = "姓名";
            oBookMark[5] = "性别";
            oBookMark[6] = "出生年月";
            oBookMark[7] = "政治面貌";
            oBookMark[8] = "民族";
            oBookMark[9] = "入学时间";
            oBookMark[10] = "专业";
            oBookMark[11] = "学制";
            oBookMark[12] = "联系电话";
            oBookMark[13] = "总人数1";
            oBookMark[14] = "总人数2";
            oBookMark[15] = "成绩排名";
            oBookMark[16] = "综合排名";
            oBookMark[17] = "课程数";
            oBookMark[18] = "及格数";
            oBookMark[19] = "ID1";
            oBookMark[20] = "ID2";
            oBookMark[21] = "ID3";
            oBookMark[22] = "ID4";
            oBookMark[23] = "ID5";
            oBookMark[24] = "ID6";
            oBookMark[25] = "ID7";
            oBookMark[26] = "ID8";
            oBookMark[27] = "ID9";
            oBookMark[28] = "ID10";
            oBookMark[29] = "ID11";
            oBookMark[30] = "ID12";
            oBookMark[31] = "ID13";
            oBookMark[32] = "ID14";
            oBookMark[33] = "ID15";
            oBookMark[34] = "ID16";
            oBookMark[35] = "ID17";
            oBookMark[36] = "ID18";
            oBookMark[37] = "奖项名称1";
            oBookMark[38] = "奖项单位1";
            oBookMark[39] = "奖项日期1";
            oBookMark[40] = "奖项名称2";
            oBookMark[41] = "奖项单位2";
            oBookMark[42] = "奖项日期2";
            oBookMark[43] = "奖项名称3";
            oBookMark[44] = "奖项单位3";
            oBookMark[45] = "奖项日期3";
            oBookMark[46] = "奖项名称4";
            oBookMark[47] = "奖项单位4";
            oBookMark[48] = "奖项日期4";
            oBookMark[49] = "申请理由";
            oBookMark[50] = "申请年";
            oBookMark[51] = "申请月";
            oBookMark[52] = "申请日";
            oBookMark[53] = "推荐理由";
            oBookMark[54] = "推荐年";
            oBookMark[55] = "推荐月";
            oBookMark[56] = "推荐日";
            oBookMark[57] = "院系意见";
            oBookMark[58] = "院系年";
            oBookMark[59] = "院系月";
            oBookMark[60] = "院系日";

            //赋值任意数据到书签的位置
            oDoc.Bookmarks.get_Item(ref oBookMark[0]).Range.Text = "" + (System.DateTime.Now.Year-1);
            oDoc.Bookmarks.get_Item(ref oBookMark[1]).Range.Text = "" + System.DateTime.Now.Year;
            oDoc.Bookmarks.get_Item(ref oBookMark[2]).Range.Text = this.Academic;
            oDoc.Bookmarks.get_Item(ref oBookMark[3]).Range.Text = this.StudentID;
            oDoc.Bookmarks.get_Item(ref oBookMark[4]).Range.Text = this.StudentName;
            oDoc.Bookmarks.get_Item(ref oBookMark[5]).Range.Text = this.Sex;
            oDoc.Bookmarks.get_Item(ref oBookMark[6]).Range.Text = this.BirthDay;
            oDoc.Bookmarks.get_Item(ref oBookMark[7]).Range.Text = this.Policity;
            oDoc.Bookmarks.get_Item(ref oBookMark[8]).Range.Text = this.Nation;
            oDoc.Bookmarks.get_Item(ref oBookMark[9]).Range.Text = this.EnrollTime;
            oDoc.Bookmarks.get_Item(ref oBookMark[10]).Range.Text = this.Profession;
            oDoc.Bookmarks.get_Item(ref oBookMark[11]).Range.Text = this.Years;
            oDoc.Bookmarks.get_Item(ref oBookMark[12]).Range.Text = this.Phone;
            oDoc.Bookmarks.get_Item(ref oBookMark[13]).Range.Text = this.Sum;
            oDoc.Bookmarks.get_Item(ref oBookMark[14]).Range.Text = this.Sum;
            oDoc.Bookmarks.get_Item(ref oBookMark[15]).Range.Text = this.ScoleRank;
            oDoc.Bookmarks.get_Item(ref oBookMark[16]).Range.Text = this.SyntheticRank;
            oDoc.Bookmarks.get_Item(ref oBookMark[17]).Range.Text = this.LessonNumber;
            oDoc.Bookmarks.get_Item(ref oBookMark[18]).Range.Text = this.LessonNumber;
            //身份证
            oDoc.Bookmarks.get_Item(ref oBookMark[19]).Range.Text = "" + this.ID[0];
            oDoc.Bookmarks.get_Item(ref oBookMark[20]).Range.Text = "" + this.ID[1];
            oDoc.Bookmarks.get_Item(ref oBookMark[21]).Range.Text = "" + this.ID[2];
            oDoc.Bookmarks.get_Item(ref oBookMark[22]).Range.Text = "" + this.ID[3];
            oDoc.Bookmarks.get_Item(ref oBookMark[23]).Range.Text = "" + this.ID[4];
            oDoc.Bookmarks.get_Item(ref oBookMark[24]).Range.Text = "" + this.ID[5];
            oDoc.Bookmarks.get_Item(ref oBookMark[25]).Range.Text = "" + this.ID[6];
            oDoc.Bookmarks.get_Item(ref oBookMark[26]).Range.Text = "" + this.ID[7];
            oDoc.Bookmarks.get_Item(ref oBookMark[27]).Range.Text = "" + this.ID[8];
            oDoc.Bookmarks.get_Item(ref oBookMark[28]).Range.Text = "" + this.ID[9];
            oDoc.Bookmarks.get_Item(ref oBookMark[29]).Range.Text = "" + this.ID[10];
            oDoc.Bookmarks.get_Item(ref oBookMark[30]).Range.Text = "" + this.ID[11];
            oDoc.Bookmarks.get_Item(ref oBookMark[31]).Range.Text = "" + this.ID[12];
            oDoc.Bookmarks.get_Item(ref oBookMark[32]).Range.Text = "" + this.ID[13];
            oDoc.Bookmarks.get_Item(ref oBookMark[33]).Range.Text = "" + this.ID[14];
            oDoc.Bookmarks.get_Item(ref oBookMark[34]).Range.Text = "" + this.ID[15];
            oDoc.Bookmarks.get_Item(ref oBookMark[35]).Range.Text = "" + this.ID[16];
            oDoc.Bookmarks.get_Item(ref oBookMark[36]).Range.Text = "" + this.ID[17];
            //奖项
            List<Schema> schemas = this.Schemas;
            oDoc.Bookmarks.get_Item(ref oBookMark[37]).Range.Text = schemas[0].SchemasName;
            oDoc.Bookmarks.get_Item(ref oBookMark[38]).Range.Text = schemas[0].SchemasApartment;
            oDoc.Bookmarks.get_Item(ref oBookMark[39]).Range.Text = schemas[0].SchemasTime;
            oDoc.Bookmarks.get_Item(ref oBookMark[40]).Range.Text = schemas[1].SchemasName;
            oDoc.Bookmarks.get_Item(ref oBookMark[41]).Range.Text = schemas[1].SchemasApartment;
            oDoc.Bookmarks.get_Item(ref oBookMark[42]).Range.Text = schemas[1].SchemasTime;
            oDoc.Bookmarks.get_Item(ref oBookMark[43]).Range.Text = schemas[2].SchemasName;
            oDoc.Bookmarks.get_Item(ref oBookMark[44]).Range.Text = schemas[2].SchemasApartment;
            oDoc.Bookmarks.get_Item(ref oBookMark[45]).Range.Text = schemas[2].SchemasTime;
            oDoc.Bookmarks.get_Item(ref oBookMark[46]).Range.Text = schemas[3].SchemasName;
            oDoc.Bookmarks.get_Item(ref oBookMark[47]).Range.Text = schemas[3].SchemasApartment;
            oDoc.Bookmarks.get_Item(ref oBookMark[48]).Range.Text = schemas[3].SchemasTime;
            //理由
            oDoc.Bookmarks.get_Item(ref oBookMark[49]).Range.Text = this.textAreaPanel1.Content.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[50]).Range.Text = "" + this.textAreaPanel1.Date.Year;
            oDoc.Bookmarks.get_Item(ref oBookMark[51]).Range.Text = "" + this.textAreaPanel1.Date.Month;
            oDoc.Bookmarks.get_Item(ref oBookMark[52]).Range.Text = "" + this.textAreaPanel1.Date.Day;

            oDoc.Bookmarks.get_Item(ref oBookMark[53]).Range.Text = this.textAreaPanel2.Content.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[54]).Range.Text = "" + this.textAreaPanel2.Date.Year;
            oDoc.Bookmarks.get_Item(ref oBookMark[55]).Range.Text = "" + this.textAreaPanel2.Date.Month;
            oDoc.Bookmarks.get_Item(ref oBookMark[56]).Range.Text = "" + this.textAreaPanel2.Date.Day;

            oDoc.Bookmarks.get_Item(ref oBookMark[57]).Range.Text = this.textAreaPanel3.Content.Trim();
            oDoc.Bookmarks.get_Item(ref oBookMark[58]).Range.Text = "" + this.textAreaPanel3.Date.Year;
            oDoc.Bookmarks.get_Item(ref oBookMark[59]).Range.Text = "" + this.textAreaPanel3.Date.Month;
            oDoc.Bookmarks.get_Item(ref oBookMark[60]).Range.Text = "" + this.textAreaPanel3.Date.Day;

            /*//弹出保存文件对话框，保存生成的Word
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document(*.doc)|*.doc";
            sfd.DefaultExt = "Word Document(*.doc)|*.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                object filename = sfd.FileName;

                oDoc.SaveAs(ref filename, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
                oDoc.Close(ref oMissing, ref oMissing, ref oMissing);
                //关闭word
                oWord.Quit(ref oMissing, ref oMissing, ref oMissing);
            }
            */
        }
    }
}
