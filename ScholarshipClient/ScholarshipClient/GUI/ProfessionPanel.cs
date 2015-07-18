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
    public partial class ProfessionPanel : LineTextPanel
    {
        public ProfessionPanel()
        {
            InitializeComponent();
        }

        public String getProfessionString()
        {
            return this.Content.Trim();
        }
    }
}
