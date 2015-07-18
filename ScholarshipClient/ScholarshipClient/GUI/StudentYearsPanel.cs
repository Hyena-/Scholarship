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
    public partial class StudentYearsPanel : ComboBoxPanel
    {
        private static String[] StudentYearsArray = {"四"};
        public StudentYearsPanel()
        {
            InitializeComponent();
            List<String> years = new List<string>();
            years.AddRange(StudentYearsArray);
            this.DataSource = years;
        }

        public String getStudentYearsString()
        {
            return this.contentComboBox.SelectedItem.ToString();
        }
    }
}
