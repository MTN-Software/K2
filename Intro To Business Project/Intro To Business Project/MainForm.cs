using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using FastColoredTextBoxNS;
using Intro_To_Business_Project;

namespace Intro_To_Business_Project
{
    
    public partial class frmMain : Form
    {
        //bool inTag;
        TreeNode tvNode;
        TreeNode tvRoot;
        int prog;
        string filter = "HTML (.htm)|*.htm*|CSS (.css)|*.css|XML (.xml)|*.xml|JavaScript (.js)|*.js|C Sharp (.cs)|*.cs|Visual Basic (.vb)|*.vb|PHP (.php)|*.php|SQL (.sql)|*.sql|All Files (*.*)|*.*";
        string[] fileType = { ".htm", ".css", ".xml", ".js", ".cs", ".vb", ".php", ".sql" };
        string openedFileName;
        enum progLang
        {
            CSharp = 0,
            VB,
            HTML,
            SQL,
            PHP,
            JS,
            CSS,
            XML
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Dear God this code is messy.  ~not anymore
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuNewFolder_Click(object sender, EventArgs e)
        {
            //tvNode.Nodes.Add("File");
            tvNode = tvRoot.Nodes.Add("folder");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tvRoot = this.treeProject.Nodes.Add("Root");
            txtCode.AutoIndent = true;
            txtCode.HighlightingRangeType = HighlightingRangeType.AllTextRange;
            openedFileName = string.Empty;
            //MessageBox.Show("hi");
            txtCode.Focus();
            //txtCode.Language = Language.HTML;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            string fileName = string.Empty;

            openf.Filter = filter;
            openf.FilterIndex = 1;
            openf.RestoreDirectory = true;
            openf.Multiselect = true;
            //openf.InitialDirectory = "C:";
            DialogResult dia;
            dia = openf.ShowDialog();
            if (dia == DialogResult.OK)
            {
                fileName = openf.FileName;
                System.IO.StreamReader openFile = new System.IO.StreamReader(fileName);
                openedFileName = fileName;
                txtCode.Text = openFile.ReadToEnd();
            }
            else
            {
                openedFileName = string.Empty;
            }

        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            // <Debug Code>
            //lblCurPos.Text =  "Cursor Position: " + txtCode.SelectionStart.ToString();
            //highlight.updateSelect(txtCode);
            // </Debug Code>
            
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            // <Debug Code>
            lblCurPos.Text = "Cursor Position: " + txtCode.SelectionStart.ToString();
            
            // </Debug Code>
            //curPosition = txtCode.Text.IndexOf(txtCode.SelectedText);
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            //curPosition = txtCode.s

        }

        private void txtCode_SelectionChanged(object sender, EventArgs e)
        {
            //txtCode.SelectionColor = Color.Black;
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            //highlight.HTMLHighlight(txtCode);
        }

        private void txtCode_Load(object sender, EventArgs e)
        {

        }

        private void mnuCss_Click(object sender, EventArgs e)
        {
            mnuJavascript.Checked = false;
            mnuHtml.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuCsharp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.CSS;
            setStyle();
        }

        private void mnuJavascript_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuCsharp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.JS;
            setStyle();
        }

        private void mnuXml_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuJavascript.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuCsharp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.XML;
            setStyle();
        }

        private void mnuHtml_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuJavascript.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuCsharp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.HTML;
            setStyle();
        }

        
        private void mnuVb_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuJavascript.Checked = false;
            mnuXml.Checked = false;
            mnuCsharp.Checked = false;
            mnuPhp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.VB;
            setStyle();
        }

        private void mnuCSharp_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuJavascript.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.CSharp;
            setStyle();
        }

        private void mnuPhp_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuJavascript.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuCsharp.Checked = false;
            mnuSql.Checked = false;
            prog = (int)progLang.PHP;
            setStyle();
        }

        private void mnuSql_Click(object sender, EventArgs e)
        {
            mnuCss.Checked = false;
            mnuHtml.Checked = false;
            mnuJavascript.Checked = false;
            mnuXml.Checked = false;
            mnuVb.Checked = false;
            mnuPhp.Checked = false;
            mnuCsharp.Checked = false;
            prog = (int)progLang.SQL;
            setStyle();
        }

        private void setStyle()
        {
            switch (prog)
            {
                case (int)progLang.CSharp:
                    txtCode.Language = Language.CSharp;
                    break;
                case (int)progLang.HTML:
                    txtCode.Language = Language.HTML;
                    break;
                case (int)progLang.JS:
                    txtCode.Language = Language.JS;
                    break;
                case (int)progLang.PHP:
                    txtCode.Language = Language.PHP;
                    break;
                case (int)progLang.SQL:
                    txtCode.Language = Language.SQL;
                    break;
                case (int)progLang.VB:
                    txtCode.Language = Language.VB;
                    break;
                case (int)progLang.XML:
                    txtCode.Language = Language.HTML;   // Placeholder
                    break;
                case (int)progLang.CSS:
                    //TODO
                    break;
                default:
                    break;
            }
            txtCode.Refresh();
        }
        private void SaveAs()
        {
            string fileName = string.Empty;
            string tempType = string.Empty;
            SaveFileDialog savef = new SaveFileDialog();

            savef.Filter = filter;
            
            savef.RestoreDirectory = true;

            switch (prog)
            {
                case (int)progLang.CSharp:
                    tempType = fileType[4];
                    savef.FilterIndex = 5;
                    break;
                case (int)progLang.HTML:
                    tempType = fileType[0];
                    savef.FilterIndex = 1;
                    break;
                case (int)progLang.JS:
                    tempType = fileType[3];
                    savef.FilterIndex = 4;
                    break;
                case (int)progLang.PHP:
                    tempType = fileType[6];
                    savef.FilterIndex = 7;
                    break;
                case (int)progLang.SQL:
                    tempType = fileType[7];
                    savef.FilterIndex = 8;
                    break;
                case (int)progLang.VB:
                    tempType = fileType[5];
                    savef.FilterIndex = 6;
                    break;
                case (int)progLang.XML:
                    tempType = fileType[2];
                    savef.FilterIndex = 3;
                    break;
                case (int)progLang.CSS:
                    tempType = fileType[1];
                    savef.FilterIndex = 2;
                    break;
                default:
                    tempType = ".txt";
                    savef.FilterIndex = 9;
                    break;
            }
            savef.ShowDialog();
            fileName = savef.FileName + tempType;
            System.IO.StreamWriter write = new System.IO.StreamWriter(fileName);
            write.WriteLine(txtCode.Text);
            write.Close();
        }

        private void save()
        {
            if (openedFileName != string.Empty)
            {
                System.IO.StreamWriter Save = new System.IO.StreamWriter(openedFileName);
                Save.WriteLine(txtCode.Text);
                Save.Close();
            }
            else
            {
                SaveAs();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            createNew();
        }

        private void createNew()
        {
            DialogResult dia;
            dia = MessageBox.Show("Save Changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
            if (dia == DialogResult.Yes)
            {
                save();
                txtCode.Text = string.Empty;
                openedFileName = string.Empty;
            }
            else if (dia == DialogResult.No)
            {
                txtCode.Text = string.Empty;
                openedFileName = string.Empty;
            }
            else
            {

            }
        }
    }
}

