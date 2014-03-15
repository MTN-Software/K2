﻿namespace Intro_To_Business_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSyntax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJavascript = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripButton();
            this.mnuOpen = new System.Windows.Forms.ToolStripButton();
            this.mnuSave = new System.Windows.Forms.ToolStripButton();
            this.mnuPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripButton();
            this.mnuCopy = new System.Windows.Forms.ToolStripButton();
            this.mnuPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewFolder = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.treeProject = new System.Windows.Forms.TreeView();
            this.TreeNodeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ListViewLargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ListViewSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mnuStrip.SuspendLayout();
            this.mnuTools.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(702, 24);
            this.mnuStrip.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.mnuFHelp,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // mnuFHelp
            // 
            this.mnuFHelp.Name = "mnuFHelp";
            this.mnuFHelp.Size = new System.Drawing.Size(138, 22);
            this.mnuFHelp.Text = "Help";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(138, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSyntax});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            // 
            // mnuSyntax
            // 
            this.mnuSyntax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHtml,
            this.mnuXml,
            this.mnuJavascript,
            this.mnuCss});
            this.mnuSyntax.Name = "mnuSyntax";
            this.mnuSyntax.Size = new System.Drawing.Size(108, 22);
            this.mnuSyntax.Text = "Syntax";
            // 
            // mnuHtml
            // 
            this.mnuHtml.CheckOnClick = true;
            this.mnuHtml.Name = "mnuHtml";
            this.mnuHtml.Size = new System.Drawing.Size(152, 22);
            this.mnuHtml.Text = "HTML/XHTML";
            // 
            // mnuXml
            // 
            this.mnuXml.CheckOnClick = true;
            this.mnuXml.Name = "mnuXml";
            this.mnuXml.Size = new System.Drawing.Size(152, 22);
            this.mnuXml.Text = "XML";
            // 
            // mnuJavascript
            // 
            this.mnuJavascript.CheckOnClick = true;
            this.mnuJavascript.Name = "mnuJavascript";
            this.mnuJavascript.Size = new System.Drawing.Size(152, 22);
            this.mnuJavascript.Text = "JavaScript";
            // 
            // mnuCss
            // 
            this.mnuCss.CheckOnClick = true;
            this.mnuCss.Name = "mnuCss";
            this.mnuCss.Size = new System.Drawing.Size(152, 22);
            this.mnuCss.Text = "CSS";
            // 
            // mnuTools
            // 
            this.mnuTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuPrint,
            this.toolStripSeparator,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.toolStripSeparator1,
            this.mnuHelp,
            this.toolStripSeparator2,
            this.mnuNewFolder});
            this.mnuTools.Location = new System.Drawing.Point(0, 24);
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(702, 25);
            this.mnuTools.TabIndex = 1;
            // 
            // mnuNew
            // 
            this.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuNew.Image")));
            this.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(23, 22);
            this.mnuNew.Text = "&New";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(23, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(23, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Image")));
            this.mnuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(23, 22);
            this.mnuPrint.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuCut
            // 
            this.mnuCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuCut.Image")));
            this.mnuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(23, 22);
            this.mnuCut.Text = "C&ut";
            // 
            // mnuCopy
            // 
            this.mnuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopy.Image")));
            this.mnuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(23, 22);
            this.mnuCopy.Text = "&Copy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuPaste.Image")));
            this.mnuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(23, 22);
            this.mnuPaste.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(23, 22);
            this.mnuHelp.Text = "He&lp";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnuNewFolder
            // 
            this.mnuNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("mnuNewFolder.Image")));
            this.mnuNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNewFolder.Name = "mnuNewFolder";
            this.mnuNewFolder.Size = new System.Drawing.Size(71, 22);
            this.mnuNewFolder.Text = "New Folder";
            this.mnuNewFolder.Click += new System.EventHandler(this.mnuNewFolder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeProject, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 288);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtCode
            // 
            this.txtCode.AcceptsTab = true;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.EnableAutoDragDrop = true;
            this.txtCode.Location = new System.Drawing.Point(145, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.ShowSelectionMargin = true;
            this.txtCode.Size = new System.Drawing.Size(554, 282);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // treeProject
            // 
            this.treeProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProject.ImageIndex = 0;
            this.treeProject.ImageList = this.TreeNodeImageList;
            this.treeProject.LabelEdit = true;
            this.treeProject.Location = new System.Drawing.Point(3, 3);
            this.treeProject.Name = "treeProject";
            this.treeProject.SelectedImageIndex = 0;
            this.treeProject.ShowNodeToolTips = true;
            this.treeProject.Size = new System.Drawing.Size(136, 282);
            this.treeProject.TabIndex = 1;
            // 
            // TreeNodeImageList
            // 
            this.TreeNodeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeNodeImageList.ImageStream")));
            this.TreeNodeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder");
            this.TreeNodeImageList.Images.SetKeyName(1, "OpenFolder");
            // 
            // ListViewLargeImageList
            // 
            this.ListViewLargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListViewLargeImageList.ImageStream")));
            this.ListViewLargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ListViewLargeImageList.Images.SetKeyName(0, "Graph1");
            this.ListViewLargeImageList.Images.SetKeyName(1, "Graph2");
            this.ListViewLargeImageList.Images.SetKeyName(2, "Graph3");
            // 
            // ListViewSmallImageList
            // 
            this.ListViewSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListViewSmallImageList.ImageStream")));
            this.ListViewSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ListViewSmallImageList.Images.SetKeyName(0, "Graph1");
            this.ListViewSmallImageList.Images.SetKeyName(1, "Graph2");
            this.ListViewSmallImageList.Images.SetKeyName(2, "Graph3");
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(136, 257);
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(136, 282);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 337);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mnuTools);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmMain";
            this.Text = "HTML Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.mnuTools.ResumeLayout(false);
            this.mnuTools.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuSyntax;
        private System.Windows.Forms.ToolStripMenuItem mnuHtml;
        private System.Windows.Forms.ToolStripMenuItem mnuXml;
        private System.Windows.Forms.ToolStripMenuItem mnuJavascript;
        private System.Windows.Forms.ToolStripMenuItem mnuCss;
        private System.Windows.Forms.ToolStrip mnuTools;
        private System.Windows.Forms.ToolStripButton mnuNew;
        private System.Windows.Forms.ToolStripButton mnuOpen;
        private System.Windows.Forms.ToolStripButton mnuSave;
        private System.Windows.Forms.ToolStripButton mnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton mnuCut;
        private System.Windows.Forms.ToolStripButton mnuCopy;
        private System.Windows.Forms.ToolStripButton mnuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.TreeView treeProject;
        internal System.Windows.Forms.ImageList TreeNodeImageList;
        internal System.Windows.Forms.ImageList ListViewLargeImageList;
        internal System.Windows.Forms.ImageList ListViewSmallImageList;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnuNewFolder;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

