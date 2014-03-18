using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Intro_To_Business_Project
{
    class Highligher
    {
        public int StartPos;

        public void updateSelect(RichTextBox rtb)
        {
            StartPos = rtb.SelectionStart;
        }
        public void DemoHighlight(RichTextBox rtb)
        {
            string token = "(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while)";
            Regex rgx = new Regex(token);
            MatchCollection mc = rgx.Matches(rtb.Text);
            
            foreach (Match mIndex in mc)
            {
                int startIndex = mIndex.Index;
                int endIndex = mIndex.Length;
                rtb.Select(startIndex, endIndex);
                rtb.SelectionColor = Color.Blue;
                //rtb.SelectionStart = StartPos;
                rtb.SelectionStart = StartPos;
                rtb.SelectionColor = Color.Black;
            }

        }

        /// <summary>
        /// Provides HTML-style syntax highlighting
        /// works in theory, not in practice
        /// </summary>
        /// <param name="rtb"></param>
        public void HTMLHighlight(RichTextBox rtb)
        {
            Regex rgx = new Regex("(<\\S*\\s\\S*>|<\\S*>)");     // Uncomment this later
            //Regex rgx = new Regex("(If|Next|Else)");
            foreach (Match index in rgx.Matches(rtb.Text))
            {
                rtb.Select(index.Index, index.Length);
                rtb.SelectionColor = Color.Blue;
                rtb.Select(index.Length + 1, index.Length + 1);
                rtb.SelectionColor = Color.Black;
            }
        }
    }
}
