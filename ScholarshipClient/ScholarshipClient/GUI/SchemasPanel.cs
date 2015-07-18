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
    public partial class SchemasPanel : UserControl
    {
        private static String[] schemas = {"无",
                                         "优秀学生一等奖学金",
                                         "优秀学生二等奖学金",
                                         "优秀学生三等奖学金"};
        public List<Schema> Schemas
        {
            get {
                List <Schema> res = new List<Schema>();
                int len = 0;
                int sum = 4;
                if(this.nameComboBox1.Text != "无")
                {
                    Schema schema1 = new Schema(this.nameComboBox1.Text,this.timeComboBox1.Text,this.apartmentComboBox1.Text);
                    res.Add(schema1);
                    len++;
                }
                if (this.nameComboBox2.Text != "无")
                {
                    Schema schema2 = new Schema(this.nameComboBox2.Text, this.timeComboBox2.Text, this.apartmentComboBox2.Text);
                    res.Add(schema2);
                    len++;
                }
                if (this.nameComboBox3.Text != "无")
                {
                    Schema schema3 = new Schema(this.nameComboBox3.Text, this.timeComboBox3.Text, this.apartmentComboBox3.Text);
                    res.Add(schema3);
                    len++;
                }
                if (this.nameComboBox4.Text != "无")
                {
                    Schema schema4 = new Schema(this.nameComboBox4.Text, this.timeComboBox4.Text, this.apartmentComboBox4.Text);
                    res.Add(schema4);
                    len++;
                }
                for( ; len < sum ; len++)
                {
                    Schema schema = new Schema("无", "无", "无");
                    res.Add(schema);
                }
                return res;
            }
        }

        private List<String> schemas1;
        private List<String> schemas2;
        private List<String> schemas3;
        private List<String> schemas4;
        private List<String> dates1;
        private List<String> dates2;
        private List<String> dates3;
        private List<String> dates4;
        private List<String> apartments1;
        private List<String> apartments2;
        private List<String> apartments3;
        private List<String> apartments4;

        public SchemasPanel()
        {
            InitializeComponent();
            //this.timeComboBox1.DataSource = this.dates1;
            //this.dates2 = new List<string>();
            //this.dates3 = new List<string>();
            //this.dates4 = new List<string>();
           init();
        }
        private void init()
        {
            this.schemas1 = new List<string>();
            this.schemas2 = new List<string>();
            this.schemas3 = new List<string>();
            this.schemas4 = new List<string>();
            this.schemas1.AddRange(schemas);
            this.schemas2.AddRange(schemas);
            this.schemas3.AddRange(schemas);
            this.schemas4.AddRange(schemas);

            this.nameComboBox1.DataSource = schemas1;
            this.nameComboBox2.DataSource = schemas2;
            this.nameComboBox3.DataSource = schemas3;
            this.nameComboBox4.DataSource = schemas4;

            this.dates1 = new List<string>();
            this.dates2 = new List<string>();
            this.dates3 = new List<string>();
            this.dates4 = new List<string>();
            this.dates1 = getNullArray();
            this.dates2 = getNullArray();
            this.dates3 = getNullArray();
            this.dates4 = getNullArray();

            this.timeComboBox1.DataSource = this.dates1;
            this.timeComboBox2.DataSource = this.dates2;
            this.timeComboBox3.DataSource = this.dates3;
            this.timeComboBox4.DataSource = this.dates4;

            this.apartments1 = new List<string>();
            this.apartments2 = new List<string>();
            this.apartments3 = new List<string>();
            this.apartments4 = new List<string>();
            this.apartments1 = getNullArray();
            this.apartments2 = getNullArray();
            this.apartments3 = getNullArray();
            this.apartments4 = getNullArray();

            this.apartmentComboBox1.DataSource = this.apartments1;
            this.apartmentComboBox2.DataSource = this.apartments2;
            this.apartmentComboBox3.DataSource = this.apartments3;
            this.apartmentComboBox4.DataSource = this.apartments4;
            this.apartmentComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.apartmentComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.apartmentComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.apartmentComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private List<String> getNullArray()
        {
            List<String> resultList = new List<string>();
            resultList.Add("无");
            return resultList;
        }
        private List<String> getDateStringArray()
        {
            List<String> resultList = new List<string>();
            DateTime today = new DateTime(DateTime.Now.Year-3,9,1);
            while(today <= DateTime.Now)
            {
                if (today.Month < 10)
                {
                    resultList.Add(today.Year + ".0" + today.Month);
                }
                else
                {
                    resultList.Add(today.Year + "." + today.Month);
                }
                today = today.AddMonths(1);
            }
            return resultList;
        }

    }
}
