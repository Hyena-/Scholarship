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
    public partial class ScoleRankPanel : LineTextPanel
    {
        public ScoleRankPanel()
        {
            InitializeComponent();
        }

        public int getScoleRank()
        {
            return Int16.Parse(this.Content.Trim());
        }
    }
}
