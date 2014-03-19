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
        public string HTMLToken, JavascriptToken, XMLToken, CSSToken;
        public void updateSelect(RichTextBox rtb)
        {
            StartPos = rtb.SelectionStart;
        }
        /// <summary>
        /// This method is for debugging purposes
        /// makes C esque syntax highlighting
        /// </summary>
        /// <param name="rtb"></param>
        public void DemoHighlight(RichTextBox rtb)
        {
            string token = "/(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while/)";
            Regex rgx = new Regex(token);
            MatchCollection mc = rgx.Matches(rtb.Text);
            
            foreach (Match mIndex in mc)
            {
                int startIndex = mIndex.Index;
                int endIndex = mIndex.Length;
                rtb.Select(startIndex, endIndex);
                rtb.SelectionColor = Color.Blue;
                rtb.SelectionStart = StartPos;
                rtb.SelectionStart += 1;
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
            //Regex rgx = new Regex("(<\\S*\\s\\S*>|<\\S*>)");     // Use this for XMLToken
            string token = HTMLToken;
            Regex rgx = new Regex(HTMLToken);
            MatchCollection mc = rgx.Matches(rtb.Text);
            foreach (Match index in mc)
            {
                int startIndex = index.Index;
                int endIndex = index.Length;
                rtb.Select(startIndex, endIndex);
                rtb.SelectionColor = Color.Blue;
                rtb.SelectionStart = StartPos;
                rtb.SelectionStart += 1;
                rtb.SelectionColor = Color.Black;
            }
        }

        #region highlight
        /// <summary>
        /// class initializer
        /// seems kind of out of place all the way down here.
        /// </summary>
        public Highligher()
        {
            HTMLToken = "(<.*a.*>|<.*abbr.*>|<.*acronym.*>|<.*address.*>|<.*applet.*>|<.*area.*>|<.*article.*>|<.*aside.*>|<.*audio.*>|<.*base.*>|<.*basefont.*>|<.*b.*>|<.*bdo.*>|<.*bgsound.*>|<.*big.*>|<.*blink.*>|<.*blockquote.*>|<.*body.*>|<.*br.*>|<.*button.*>|<.*canvas.*>|<.*caption.*>|<.*center.*>|<.*cite.*>|<.*code.*>|<.*col.*>|<.*colgroup.*>|<.*command.*>|<.*datalist.*>|<.*dd.*>|<.*del.*>|<.*details.*>|<.*dfn.*>|<.*div.*>|<.*dl.*>|<.*dt.*>|<.*embed.*>|<.*em.*>|<.*fieldset.*>|<.*figcaption.*>|<.*figure.*>|<.*font.*>|<.*footer.*>|<.*form.*>|<.*frame.*>|<.*frameset.*>|<.*h1.*>|<.*h2.*>|<.*h3.*>|<.*h4.*>|<.*h5.*>|<.*h6.*>|<.*header.*>|<.*head.*>|<.*hgroup.*>|<.*hr.*>|<.*html.*>|<.*iframe.*>|<.*i.*>|<.*img.*>|<.*input.*>|<.*ins.*>|<.*isindex.*>|<.*kbd.*>|<.*keygen.*>|<.*label.*>|<.*legend.*>|<.*li.*>|<.*link.*>|<.*listing.*>|<.*map.*>|<.*mark.*>|<.*marquee.*>|<.*math.*>|<.*menu.*>|<.*meta.*>|<.*meter.*>|<.*nav.*>|<.*nextid.*>|<.*nobr.*>|<.*noembed.*>|<.*hoframes.*>|<.*noscript.*>|<.*object.*>|<.*ol.*>|<.*optgroup.*>|<.*option.*>|<.*output.*>|<.*param.*>|<.*plaintext.*>|<.*p.*>|<.*pre.*>|<.*progress.*>|<.*q.*>|<.*rp.*>|<.*rt.*>|<.*ruby.*>|<.*samp.*>|<.*script.*>|<.*section.*>|<.*select.*>|<.*small.*>|<.*source.*>|<.*spacer.*>|<.*span.*>|<.*s.*>|<.*strike.*>|<.*strong.*>|<.*style.*>|<.*sub.*>|<.*sup.*>|<.*summary.*>|<.*svg.*>|<.*table.*>|<.*tbody.*>|<.*td.*>|<.*textarea.*>|<.*tfoot.*>|<.*thead.*>|<.*th.*>|<.*time.*>|<.*title.*>|<.*tr.*>|<.*tt.*>|<.*ul.*>|<.*u.*>|<.*var.*>|<.*video.*>|<.*wbr.*>|<.*xmp.*>)";  //Dear god, get me off this computer.
            XMLToken = "(<\\S*\\s\\S*>|<\\S*>)"; // why regex? why?
        }
        
        #endregion
    }
}
