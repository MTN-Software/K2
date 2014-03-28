using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_Business_Project
{
    public class Snippets
    {
        public Snippets()
        {

        }

        public string[] CSharpSnippets =
        {
            "if(^)\n{\n}",                  // If() snippet
            "if(^)\n{\n}\nelse\n{\n}",      // If-Else snippet
            "for(^;;)\n{\n}",               // For loop snippet
            "while(^)\n{\n}",               // While loop snippet
            "do${\n^}while();",             // do while snippet
            "switch(^)\n{\n\tcase : break;\n}", // switch snippet
            "int",                          // int snippet
            "double",                       // double snippet
            "public ^()\n{\n}",              // class constructor 
            "checked\n{\n}",                // Checked
            "class ^\n{\n}",                 // class
            "public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()\n{\n\tthrow new %Exception%();\n\tyield return default(type);\n}", // iterator
            "MessageBox.Show(^);",
            "#region ^\n#endregion"

        };

        public string[] HTMLSnippets =
        {
            "<a ^></a>",
            "<abbr>^</abbr>",
            "<acronym>^</acronym>",
            "<address>^</address>",
            "<applet>^</applet>",
            "<area>^</area>",
            "<article>\n^\n</article>",
            "<aside>^</aside>",
            "<audio>^</audio>",
            "<base>^</base>",
            "<basefont>^</basefont>",
            "<b>^</b>",
            "<bdo>^</bdo>",
            "<bgsound>^</bgsound>",
            "<big>^</big>",
            "<blink>^</blink>"//,   Finish rest later
            //<blockquote><body><br><button><canvas><caption><center><cite><code><col><colgroup><command><datalist><dd><del><details><dfn><div><dl><dt><embed><em><fieldset><figcaption><figure><font><footer><form><frame><frameset><h1><h2><h3><h4><h5><h6><header><head><hgroup><hr><html><iframe><i><img><input><ins><isindex><kbd><keygen><label><legend><li><link><listing><map><mark><marquee><math><menu><meta><meter><nav><nextid><nobr><noembed><hoframes><noscript><object><ol><optgroup><option><output><param><plaintext><p><pre><progress><q><rp><rt><ruby><samp><script><section><select><small><source><spacer><span><s><strike><strong><style><sub><sup><summary><svg><table><tbody><td><textarea><tfoot><thead><th><time><title><tr><tt><ul><u><var><video>","<wbr>^</wbr>","<xmp>^</xmp>"  
        }
       
    }
}
