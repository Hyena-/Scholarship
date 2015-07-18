using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScholarshipClient.GUI;

namespace ScholarshipClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool bolNum(string temp)
        {
            int tempInt = 0;
            try
            {
                tempInt = Convert.ToInt32(temp);
            }catch { }
            if (tempInt <= 0)
                return false;
            return true;
        }

        private void schoolTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = schoolTextBox.Text == "山东大学";
            if(schoolTextBox.Text == "")
            {
                schoolErrorLabel.Text = "不能为空！";
                schoolErrorLabel.Visible = true;
            }
            else if (!isValid)
            {
                schoolErrorLabel.Text = "学校应为山东大学！";
                schoolErrorLabel.Visible = true;
            }
            else
            {
                schoolErrorLabel.Visible = false;
            }
        }

        private void departmentComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (departmentComboBox.Text == "")
            {
                departmentErrorLabel.Text = "不能为空！";
                departmentErrorLabel.Visible = true;
            }
            else
                departmentErrorLabel.Visible = false;
        }

        private void studentIDTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(studentIDTextBox.Text, @"^[1-9]\d*$");
            if(studentIDTextBox.Text == "")
            {
                studentIDErrorLabel.Text = "不能为空！";
                studentIDErrorLabel.Visible = true;
            }
            else if (!isValid)
            {
                studentIDErrorLabel.Text = "学号每位为整数！";
                studentIDErrorLabel.Visible = true;
            }//if\
            else if (studentIDTextBox.TextLength != 12)
            {
                studentIDErrorLabel.Text = "学号长度为12位！";
                studentIDErrorLabel.Visible = true;
            }
            else if(studentIDTextBox.TextLength == 12 && isValid)
            {
                studentIDErrorLabel.Visible = false;
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool res = true;
            for (int i = 0; i < nameTextBox.TextLength; i++)
            {
                if ((int)nameTextBox.Text[i] < 127)
                    res = false;
            }
            if(nameTextBox.Text == "")
            {
                nameErrorLabel.Text = "不能为空！";
                nameErrorLabel.Visible = true;
            }
            else if (!res)
            {
                nameErrorLabel.Text = "姓名需为中文！";
                nameErrorLabel.Visible = true;
            }
            else
                nameErrorLabel.Visible = false;
        }

        private void sexComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (sexComboBox.Text == "")
            {
                sexErrorLabel.Text = "不能为空！";
                sexErrorLabel.Visible = true;
            }
            else
                sexErrorLabel.Visible = false;
        }

        private void birthdayYearComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(birthdayYearComboBox.Text == "" || birthdayMonthComboBox.Text == "")
            {
                birthdayErrorLabel.Text = "不能为空！";
                birthdayErrorLabel.Visible = true;
            }
            else
                birthdayErrorLabel.Visible = false;
        }

        private void birthdayMonthComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (birthdayYearComboBox.Text == "" || birthdayMonthComboBox.Text == "")
            {
                birthdayErrorLabel.Text = "不能为空！";
                birthdayErrorLabel.Visible = true;
            }
            else
                birthdayErrorLabel.Visible = false;
        }

        private void politicComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(politicComboBox.Text == "")
            {
                politicErrorLabel.Text = "不能为空！";
                politicErrorLabel.Visible = true;
            }
            else
                politicErrorLabel.Visible = false;
        }

        private void nationalComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (nationalComboBox.Text == "")
            {
                this.notionalErrorLabel.Text = "不能为空！";
                this.notionalErrorLabel.Visible = true;
            }
            else
                this.notionalErrorLabel.Visible = false;
        }

        private void enterYearComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (enterYearComboBox.Text == "" || enterMonthComboBox.Text == "")
            {
                enterTimeErrorLabel.Text = "不能为空！";
                enterTimeErrorLabel.Visible = true;
            }
            else
                enterTimeErrorLabel.Visible = false;
        }

        private void enterMonthComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (enterYearComboBox.Text == "" || enterMonthComboBox.Text == "")
            {
                enterTimeErrorLabel.Text = "不能为空！";
                enterTimeErrorLabel.Visible = true;
            }
            else
                enterTimeErrorLabel.Visible = false;
        }

        private void professionTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool res = true;
            for (int i = 0; i < professionTextBox.TextLength; i++)
            {
                if ((int)professionTextBox.Text[i] < 127)
                    res = false;
            }
            if(professionTextBox.Text == "")
            {
                professionErrorLabel.Text = "不能为空！";
                professionErrorLabel.Visible = true;
            }
            else if (!res)
            {
                professionErrorLabel.Text = "专业全称需为中文！";
                professionErrorLabel.Visible = true;
            }
            else
                professionErrorLabel.Visible = false;
        }

        private void yearsComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (yearsComboBox.Text == "")
            {
                yearsErrorLabel.Text = "不能为空！";
                yearsErrorLabel.Visible = true;
            }
            else
                yearsErrorLabel.Visible = false;
        }

        private void phoneTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(phoneTextBox.Text, @"^[1-9]\d*$");
            if (phoneTextBox.Text == "")
            {
                phoneErrorLabel.Text = "不能为空！";
                phoneErrorLabel.Visible = true;
            }
            else if (!isValid)
            {
                phoneErrorLabel.Text = "电话每位为整数！";
                phoneErrorLabel.Visible = true;
            }//if\
            else if (phoneTextBox.TextLength != 11)
            {
                phoneErrorLabel.Text = "电话长度为11位！";
                phoneErrorLabel.Visible = true;
            }
            else if (phoneTextBox.TextLength == 11 && isValid)
            {
                phoneErrorLabel.Visible = false;
            }
        }

        //身份证号18位
        private void IDTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                IDErrorLabel.Text = "不能为空！";
                IDErrorLabel.Visible = true;
            }
            else if (IDTextBox.TextLength != 18)
            {
                IDErrorLabel.Text = "身份证号需为18位！";
                IDErrorLabel.Visible = true;
            }
            else if (IDTextBox.Text.Substring(6, 6) != birthdayYearComboBox.Text + birthdayMonthComboBox.Text)
            {
                IDErrorLabel.Text = "出生年月不匹配！";
                IDErrorLabel.Visible = true;
            }
            else
                IDErrorLabel.Visible = false;
                /*1 3 0 8 2 4 1 9 9 4  0  8  0  1  0  0  3  X
                0 1 2 3 4 5 6 7 9 10 11 12 13 14 15 16 17 18*/

        }

        private void professionSumTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (professionSumTextBox.Text == "")
            {
                professionSumErrorLabel.Text = "不能为空！";
                professionSumErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(professionSumTextBox.Text) <= 0)
            {
                professionSumErrorLabel.Text = "需大于0！";
                professionSumErrorLabel.Visible = true;
            }
            else
                professionSumErrorLabel.Visible = false;
        }

        private void markPostionLabelTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (markPostionLabelTextBox.Text == "")
            {
                markPostionErrorLabel.Text = "不能为空！";
                markPostionErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(markPostionLabelTextBox.Text) <= 0 || Convert.ToInt32(markPostionLabelTextBox.Text) > Convert.ToInt32(professionSumTextBox.Text))
            {
                markPostionErrorLabel.Text = "超出范围！";
                markPostionErrorLabel.Visible = true;
            }
            else
                markPostionErrorLabel.Visible = false;
        }

        private void isEstimationComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (isEstimationComboBox.Text == "")
            {
                isEstimationErrorLabel.Text = "不能为空！";
                isEstimationErrorLabel.Visible = true;
            }
            else
                isEstimationErrorLabel.Visible = false;
        }

        private void estimationTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (estimationTextBox.Text == "")
            {
                estimationErrorLabel.Text = "不能为空！";
                estimationErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(estimationTextBox.Text) <= 0 || Convert.ToInt32(estimationTextBox.Text) > Convert.ToInt32(professionSumTextBox.Text))
            {
                estimationErrorLabel.Text = "超出范围！";
                estimationErrorLabel.Visible = true;
            }
            else
                estimationErrorLabel.Visible = false;
        }

        private void courseTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (courseTextBox.Text == "")
            {
                courseErrorLabel.Text = "不能为空！";
                courseErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(passTextBox.Text) <= 0)
            {
                courseErrorLabel.Text = "超出范围！";
                courseErrorLabel.Visible = true;
            }
            else
            {
                courseErrorLabel.Visible = false;
                passTextBox.Text = courseTextBox.Text;
            }
        }

        private void passTextBox_Validating(object sender, CancelEventArgs e)
        {
            //填入必修课数量后自动填充该栏与必修课数量相同
            if (passTextBox.Text == "")
            {
                courseErrorLabel.Text = "不能为空！";
                courseErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(passTextBox.Text) <= 0)
            {
                courseErrorLabel.Text = "超出范围！";
                courseErrorLabel.Visible = true;
            }
            else
            {
                courseErrorLabel.Visible = false;
            }
        }

    }
}
