using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Web_Studio
{
    public class FastColoredTab : TabControl
    {
        //public event EventHandler OnLoad;
        public FastColoredTextBox fastText;
        public FastColoredTab()
        {
            fastText = new FastColoredTextBox();
            this.fastText.Dock = DockStyle.Fill;
        }

         
    }
}
