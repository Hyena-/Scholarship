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
    public partial class StudentSexPanel : ComboBoxPanel
    {

        private static String[] StudentSexArray = { "男", "女" };

        public StudentSexPanel()
        {
            InitializeComponent();
            this.DataSource = StudentSexArray;
            this.contentComboBox.SelectedIndex = 0;
        }

        public String getSexString()
        {
            return this.contentComboBox.SelectedItem.ToString();
        }


    }
}
