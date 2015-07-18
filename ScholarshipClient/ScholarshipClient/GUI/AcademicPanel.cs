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
    public partial class AcademicPanel : ComboBoxPanel
    {
        private static String[] AcademicArray = {"法学院",
                                                 "翻译学院",
                                                 "韩国学院",
                                                 "海洋学院",
                                                 "机电与信息工程学院",
                                                 "空间科学与物理学院",
                                                 "商学院",
                                                 "数学与统计学院",
                                                 "文化传播学院",
                                                 "艺术学院"};
        private static String AcademicTopicString = "请选择学院";
        public AcademicPanel()
        {
            InitializeComponent();
            List<String> academics = new List<string>();
            academics.AddRange(AcademicArray);
            this.DataSource = academics;
            this.contentComboBox.MaxDropDownItems = 4;
        }

        public String getAcademicString()
        {
            return this.contentComboBox.SelectedItem.ToString();
        }

        private void contentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.getAcademicString());
        }
    }
}
