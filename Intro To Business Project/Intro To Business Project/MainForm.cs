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

namespace Intro_To_Business_Project
{
    public partial class frmMain : Form
    {
        bool inTag;
        TreeNode tvNode;
        TreeNode tvRoot;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Dear God this code is messy.
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtCode.Lines.Length; i++)
            {
                string text = txtCode.Lines[i];
                txtCode.Select(txtCode.GetFirstCharIndexFromLine(i), text.Length);
                //txtCode.SelectionColor = colorForLine(text);

                //txtCode.Select(txtCode.Text.Length, txtCode.Text.Length);

                if (txtCode.Text.Contains("<") & txtCode.Text.Contains(">"))
                {
                    if (!inTag)
                    {
                        txtCode.Select(text.IndexOf("<"), "<".Length);
                        txtCode.SelectionColor = Color.Red;
                        inTag = true;
                    }
                    else //if (inTag)
                    {
                        txtCode.Select(text.IndexOf("<") + 1, txtCode.Text.Length);
                        txtCode.SelectionColor = Color.Blue;
                        txtCode.Select(text.IndexOf(">"), ">".Length);
                        txtCode.SelectionColor = Color.Red;
                        inTag = false;
                    }
                    //txtCode.Select(txtCode.Text.IndexOf("<") + 1, txtCode.Text.Length);
                    //txtCode.SelectionColor = Color.Blue;

                }
                //else if (!txtCode.Lines.Contains("<"))
                //{
                //inTag = false;
                //}

                //else
                //{
                //txtCode.Select(txtCode.Text.Length, txtCode.Text.Length);
                //txtCode.SelectionColor = Color.Black;
                //}
                txtCode.Select(txtCode.Text.Length, txtCode.Text.Length);
            }
            //private Color colorForLine(string line)
            //{
            //    if(line.Contains("[INFO]"))
            //    {
            //        return Color.Green;
            //    }
            //    /*if(line.Contains("[ERROR]", StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        return Color.Red;
            //    } */

            //    return Color.Black;
            //}
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
            txtCode.Text = openf.OpenFile().ToString();
        }


    }
}

