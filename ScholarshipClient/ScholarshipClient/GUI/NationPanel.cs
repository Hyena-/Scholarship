﻿using System;
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
    public partial class NationPanel : ComboBoxPanel
    {
        public static String[] NationArray = {"汉","壮","满","回","苗","维吾尔","土家","彝",
                                          "蒙古","藏","布依","侗","瑶","朝鲜","白","哈尼",
                                          "哈萨克","黎","傣","畲","傈僳","仡佬","东乡","高山",
                                          "拉祜","水","佤","纳西","羌","土","仫佬","锡伯",
                                          "柯尔克孜","达斡尔","景颇","毛南","撒拉","布朗","塔吉克","阿昌",
                                          "普米","鄂温克","怒","京","基诺","德昂","保安","俄罗斯",
                                          "裕固","乌孜别克","门巴","鄂伦春","独龙","塔塔尔","赫哲","珞巴" };
        public NationPanel()
        {
            InitializeComponent();
            List<String> nations = new List<string>();
            nations.AddRange(NationArray);
            this.DataSource = nations;
        }

        public String getNationString()
        {
            return this.contentComboBox.Text;
        }
    }
}
