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
        static int curPosition;
        Highligher highlight = new Highligher();
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
            txtCode.Language = Language.HTML;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            string fileName = string.Empty;

            openf.Filter = "HTML (.htm)|*.htm*|CSS (.css)|*.css|XML (.xml)|*.xml|JavaScript (.js)|*.js|All Files (*.*)|*.*";
            openf.FilterIndex = 1;
            openf.Multiselect = true;
            openf.InitialDirectory = "C:";

            openf.ShowDialog();

            fileName = openf.FileName;
            System.IO.StreamReader openFile = new System.IO.StreamReader(fileName);

            txtCode.Text = openFile.ReadToEnd();
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
            txtCode.SelectionColor = Color.Black;
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            //highlight.HTMLHighlight(txtCode);
        }

        private void txtCode_Load(object sender, EventArgs e)
        {

        }


    }
}

