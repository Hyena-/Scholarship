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
    public partial class SyntheticRankPanel : LineTextPanel
    {
        public SyntheticRankPanel()
        {
            InitializeComponent();
        }

        public int getSyntheticRank()
        {
            return Int16.Parse(this.Content.Trim());
        }
    }
}
