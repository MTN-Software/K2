using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace FastColoredTab
{
    public partial class FastColoredTab: TabControl
    {
        public FastColoredTextBox fastText = new FastColoredTextBox();
        public FastColoredTab()
        {
            InitializeComponent();
            
            this.fastText.Dock = DockStyle.Fill;
        }
    }
}
