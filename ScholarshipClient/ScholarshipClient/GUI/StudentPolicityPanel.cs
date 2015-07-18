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
    public partial class StudentPolicityPanel : ComboBoxPanel
    {
        private static String[] StudentPolicityArray = { "群众", "共青团员", "中共预备党员", "中共党员" };
        public StudentPolicityPanel()
        {
            InitializeComponent();
            this.DataSource = StudentPolicityArray;
        }

        public String getStudentPolicityString()
        {
            return this.contentComboBox.SelectedItem.ToString();
        }
    }
}
