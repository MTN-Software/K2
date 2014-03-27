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
using System.IO;
namespace Intro_To_Business_Project
{

    public partial class frmMain : Form
    {
        int prog;
        string filter = "HTML (.htm)|*.htm*|CSS (.css)|*.css|XML (.xml)|*.xml|JavaScript (.js)|*.js|C Sharp (.cs)|*.cs|Visual Basic (.vb)|*.vb|PHP (.php)|*.php|SQL (.sql)|*.sql|All Files (*.*)|*.*";
        string[] fileType = { ".htm", ".css", ".xml", ".js", ".cs", ".vb", ".php", ".sql" };
        string openedFileName;
        string projectDir;
        enum progLang
        {
            CSharp = 0, VB, HTML, SQL, PHP, JS, CSS, XML
        }
        public frmMain()
        {
            InitializeComponent();
            projectDir = null;
            checkProjectDirectory();
            PopulateTreeList(Environment.GetEnvironmentVariable("projDir", EnvironmentVariableTarget.User));
        }

        // Populate the Project Directory pane
        private void PopulateTreeList(string directory)
        {
            TreeNode rootNode;  // Create a node that will be the root of the project directory
            DirectoryInfo info = new DirectoryInfo(directory);  // Set info equal to the directory specified

            if (info.Exists)    // If the directory exists, do the following
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                listProjDir.Nodes.Add(rootNode);
            }
        }

        /// <summary>
        /// Loads the directories
        /// </summary>
        /// <param name="subDirs"></param>
        /// <param name="nodeToAddTo"></param>
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;         // Creates a treeNode
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                try
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);    // casts aNode as a TreeNode with a folder icon
                    aNode.Tag = subDir;
                    aNode.ImageKey = "folder";
                    subSubDirs = subDir.GetDirectories();   // sets subSubDirs equal to the array of directories in subDir
                    if (subSubDirs.Length != 0)     // if there are subdirectories, do this
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);   // add the node
                    GetFiles(subDir, aNode);    // add any files as a child node
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void GetFiles(DirectoryInfo subDirs, TreeNode nodeToAddTo)
        {

            //DirectoryInfo[] subSubDirs;
            DirectoryInfo dirInfo = subDirs;
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                TreeNode aFile = new TreeNode(file.Name, 1, 1);  // For Some reason, it won't change icons correctly;
                aFile.ImageKey = "file";
                aFile.Tag = file;
                //aFile.ImageKey = "file";
                nodeToAddTo.Nodes.Add(aFile);
            }
        }


        private bool checkProjectDirectory()
        {
            // set projectDir to the mydocuments directory
            projectDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            projectDir += @"\Web Studio\"; // then add this to projectDir
            // Check if the environmental variable "projDir" exists and if it does, set projectDir equal to it
            if (Environment.GetEnvironmentVariable("projDir", EnvironmentVariableTarget.User) != null)
            {
                projectDir = Environment.GetEnvironmentVariable("projDir", EnvironmentVariableTarget.User);
            }
            //MessageBox.Show(projectDir);  // Debug Code

            if (!Directory.Exists(projectDir))  // Check if the directory projectDir does not exist
            {
                // If so, ask if the user would like to create it
                DialogResult result = MessageBox.Show("Would you like to create a workspace in " + projectDir + " ?", "Missing Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)  // If the user would like to create it, create the directory, then set the environmental variable "projDir" equal to the directory
                {
                    Directory.CreateDirectory(projectDir);
                    Environment.SetEnvironmentVariable("projDir", projectDir, EnvironmentVariableTarget.User);  // The target just makes it so that the variable doesn't get cleared once the application closes
                    return true;
                }
                else  // If the user does not want to create it, ask if they want to in a different directory
                {
                    DialogResult diffDir = MessageBox.Show("Would you like to create a workspace in a different directory?", "Create Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (diffDir == DialogResult.Yes)    // If so, ask them what directory, then set "projDir" equal to that directory
                    {
                        FolderBrowserDialog folderDir = new FolderBrowserDialog();
                        folderDir.ShowNewFolderButton = true;
                        folderDir.Description = "Where do you want your workspace directory to be?";
                        folderDir.RootFolder = Environment.SpecialFolder.MyDocuments;
                        folderDir.ShowDialog();
                        string newDir = folderDir.SelectedPath + @"\Web Studio\";
                        Directory.CreateDirectory(newDir);
                        Environment.SetEnvironmentVariable("projDir", newDir, EnvironmentVariableTarget.User);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }

        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mnuNewFolder_Click(object sender, EventArgs e)
        {
            // TODO: Create a new folder
            //  --- Debug Code ---
            //tvNode.Nodes.Add("File");
            //tvNode = tvRoot.Nodes.Add("folder");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtCode.AutoIndent = true;
            txtCode.HighlightingRangeType = HighlightingRangeType.AllTextRange;
            openedFileName = string.Empty;
            txtCode.Focus();
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
                FileInfo file = new FileInfo(openf.FileName);
                string title = file.Name;
                tabPage1.Text = title;
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
            //lblCurPos.Text = "Cursor Position: " + txtCode.SelectionStart.ToString();
            // </Debug Code>
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {

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
            if (projectDir != null)
            {
                savef.InitialDirectory = projectDir;
            }
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

        private bool createNew()
        {
            DialogResult dia;
            dia = MessageBox.Show("Save Changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
            if (dia == DialogResult.Yes)
            {
                save();
                txtCode.Text = string.Empty;
                openedFileName = string.Empty;
                return true;
            }
            else if (dia == DialogResult.No)
            {
                txtCode.Text = string.Empty;
                openedFileName = string.Empty;
                return true;
            }
            else
            {
                return false;
            }
        }


        private void NewProject()
        {
            FolderBrowserDialog fDia = new FolderBrowserDialog();

            fDia.ShowNewFolderButton = true;
            fDia.ShowDialog();

            if (listProjDir == null)
            {
                fDia.RootFolder = Environment.SpecialFolder.MyComputer;
                //TODO: add code that loads the directory into treeview
                PopulateTreeList(fDia.SelectedPath);
            }
            else
            {
                if (createNew())
                {
                    fDia.RootFolder = Environment.SpecialFolder.MyComputer;
                    listProjDir.Nodes.Clear();
                    //TODO: add code that loads the directory into treeview
                    PopulateTreeList(fDia.SelectedPath);
                }
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void listProjDir_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    Point pt = listProjDir.PointToScreen(e.Location);
                    mnuNodeContextMenuStrip.Show(pt);
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void listProjDir_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}

