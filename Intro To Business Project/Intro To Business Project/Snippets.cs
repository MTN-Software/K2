using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

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
            "<blink>^</blink>",
            "<blockquote>^</blockquote>",
            "<body>^</body>",
            "<br />",
            "<button>^</button>",
            "<canvas>^</canvas>",
            "<caption>^</caption>",
            "<center>^</center>",
            "<cite>^</cite>",
            "<code>^</code>",
            "<col>^</col>",
            "<colgroup>^</colgroup>",
            "<command>^</command>",
            "<datalist>^</datalist>",
            "<dd>^</dd>",
            "<del>^</del>",
            "<details>^</details>",
            "<dfn>^</dfn>",
            "<div>^</div>",
            "<dl>^</dl>",
            "<dt>^</dt>",
            "<embed>^</embed>",
            "<em>^</em>",
            "<fieldset>^</fieldset>",
            "<figcaption>^</figcaption>",
            "<figure>^</figure>",
            "<font>^</font>",
            "<footer>^</footer>",
            "<form>^</form>",
            "<frame>^</frame>",
            "<frameset>^</frameset>",
            "<h1>^</h1>",
            "<h2>^</h2>",
            "<h3>^</h3>",
            "<h4>^</h4>",
            "<h5>^</h5>",
            "<h6>^</h6>",
            "<header>^</header>",
            "<head>^</head>",
            "<hgroup>^</hgroup>",
            "<hr />",
            "<html>^</html>",
            "<iframe>^</iframe>",
            "<i>^</i>",
            "<img>^</img>",
            "<input>^</input>",
            "<ins>^</ins>",
            "<isindex>^</isindex>",
            "<kbd>^</kbd>",
            "<keygen>^</keygen>",
            "<label>^</label>",
            "<legend>^</legend>",
            "<li>^</li>",
            "<link ^></link>",
            "<listing>^</listing>",
            "<map>^</map>",
            "<mark>^</mark>",
            "<marquee>^</marquee>",
            "<math>^</math>",
            "<menu>^</menu>",
            "<meta ^></meta>",
            "<meter>^</meter>",
            "<nav>^</nav>",
            "<nextid>^</nextid>",
            "<nobr>^</nobr>",
            "<noembed>^</noembed>",
            "<hoframes>^</hoframes>",
            "<noscript>^</noscript>",
            "<object>^</object>",
            "<ol>^</ol>",
            "<optgroup>^</optgroup>",
            "<option>^</option>",
            "<output>^</output>",
            "<param>^</param>",
            "<plaintext>^</plaintext>",
            "<p>^</p>",
            "<pre>^</pre>",
            "<progress>^</progress>",
            "<q>^</q>",
            "<rp>^</rp>",
            "<rt>^</rt>",
            "<ruby>^</ruby>",
            "<samp>^</samp>",
            "<script>^</script>",
            "<section>^</section>",
            "<select>^</select>",
            "<small>^</small>",
            "<source>^</source>",
            "<spacer>^</spacer>",
            "<span>^</span>",
            "<s>^</s>",
            "<strike>^</strike>",
            "<strong>^</strong>",
            "<style>^</style>",
            "<sub>^</sub>",
            "<sup>^</sup>",
            "<summary>^</summary>",
            "<svg>^</svg>",
            "<table>^</table>",
            "<tbody>^</tbody>",
            "<td>^</td>",
            "<textarea>^</textarea>",
            "<tfoot>^</tfoot>",
            "<thead>^</thead>",
            "<th>^</th>",
            "<time>^</time>",
            "<title>^</title>",
            "<tr>^</tr>",
            "<tt>^</tt>",
            "<ul>^</ul>",
            "<u>^</u>",
            "<var>^</var>",
            "<video>^</video>",
            "<wbr>^</wbr>",
            "<xmp>^</xmp>"  
        };

    }
}
