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
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSyntax = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXml = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJavascript = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCsharp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVb = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurPos = new System.Windows.Forms.ToolStripLabel();
            this.TreeNodeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ListViewLargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ListViewSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listProjDir = new System.Windows.Forms.TreeView();
            this.txtCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.imglistIcons = new System.Windows.Forms.ImageList(this.components);
            this.mnuStrip.SuspendLayout();
            this.mnuTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuStrip.Size = new System.Drawing.Size(1053, 35);
            this.mnuStrip.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.mnuFHelp,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 29);
            this.mnuFile.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // mnuFHelp
            // 
            this.mnuFHelp.Name = "mnuFHelp";
            this.mnuFHelp.Size = new System.Drawing.Size(178, 30);
            this.mnuFHelp.Text = "Help";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(178, 30);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSyntax});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(61, 29);
            this.mnuView.Text = "View";
            // 
            // mnuSyntax
            // 
            this.mnuSyntax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHtml,
            this.mnuXml,
            this.mnuJavascript,
            this.mnuCss,
            this.mnuSql,
            this.mnuPhp,
            this.mnuCsharp,
            this.mnuVb});
            this.mnuSyntax.Name = "mnuSyntax";
            this.mnuSyntax.Size = new System.Drawing.Size(136, 30);
            this.mnuSyntax.Text = "Syntax";
            // 
            // mnuHtml
            // 
            this.mnuHtml.CheckOnClick = true;
            this.mnuHtml.Name = "mnuHtml";
            this.mnuHtml.Size = new System.Drawing.Size(194, 30);
            this.mnuHtml.Text = "HTML/XHTML";
            this.mnuHtml.Click += new System.EventHandler(this.mnuHtml_Click);
            // 
            // mnuXml
            // 
            this.mnuXml.CheckOnClick = true;
            this.mnuXml.Name = "mnuXml";
            this.mnuXml.Size = new System.Drawing.Size(194, 30);
            this.mnuXml.Text = "XML";
            this.mnuXml.Click += new System.EventHandler(this.mnuXml_Click);
            // 
            // mnuJavascript
            // 
            this.mnuJavascript.CheckOnClick = true;
            this.mnuJavascript.Name = "mnuJavascript";
            this.mnuJavascript.Size = new System.Drawing.Size(194, 30);
            this.mnuJavascript.Text = "JavaScript";
            this.mnuJavascript.Click += new System.EventHandler(this.mnuJavascript_Click);
            // 
            // mnuCss
            // 
            this.mnuCss.CheckOnClick = true;
            this.mnuCss.Name = "mnuCss";
            this.mnuCss.Size = new System.Drawing.Size(194, 30);
            this.mnuCss.Text = "CSS";
            this.mnuCss.Click += new System.EventHandler(this.mnuCss_Click);
            // 
            // mnuSql
            // 
            this.mnuSql.CheckOnClick = true;
            this.mnuSql.Name = "mnuSql";
            this.mnuSql.Size = new System.Drawing.Size(194, 30);
            this.mnuSql.Text = "SQL";
            this.mnuSql.Click += new System.EventHandler(this.mnuSql_Click);
            // 
            // mnuPhp
            // 
            this.mnuPhp.CheckOnClick = true;
            this.mnuPhp.Name = "mnuPhp";
            this.mnuPhp.Size = new System.Drawing.Size(194, 30);
            this.mnuPhp.Text = "PHP";
            this.mnuPhp.Click += new System.EventHandler(this.mnuPhp_Click);
            // 
            // mnuCsharp
            // 
            this.mnuCsharp.CheckOnClick = true;
            this.mnuCsharp.Name = "mnuCsharp";
            this.mnuCsharp.Size = new System.Drawing.Size(194, 30);
            this.mnuCsharp.Text = "CSharp";
            this.mnuCsharp.Click += new System.EventHandler(this.mnuCSharp_Click);
            // 
            // mnuVb
            // 
            this.mnuVb.CheckOnClick = true;
            this.mnuVb.Name = "mnuVb";
            this.mnuVb.Size = new System.Drawing.Size(194, 30);
            this.mnuVb.Text = "VB";
            this.mnuVb.Click += new System.EventHandler(this.mnuVb_Click);
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
            this.mnuNewFolder,
            this.toolStripSeparator3,
            this.lblCurPos});
            this.mnuTools.Location = new System.Drawing.Point(0, 35);
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.mnuTools.Size = new System.Drawing.Size(1053, 32);
            this.mnuTools.TabIndex = 1;
            // 
            // mnuNew
            // 
            this.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuNew.Image")));
            this.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(23, 29);
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(23, 29);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(23, 29);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Image")));
            this.mnuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(23, 29);
            this.mnuPrint.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // mnuCut
            // 
            this.mnuCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuCut.Image")));
            this.mnuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(23, 29);
            this.mnuCut.Text = "C&ut";
            // 
            // mnuCopy
            // 
            this.mnuCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopy.Image")));
            this.mnuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(23, 29);
            this.mnuCopy.Text = "&Copy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuPaste.Image")));
            this.mnuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(23, 29);
            this.mnuPaste.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(23, 29);
            this.mnuHelp.Text = "He&lp";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // mnuNewFolder
            // 
            this.mnuNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("mnuNewFolder.Image")));
            this.mnuNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuNewFolder.Name = "mnuNewFolder";
            this.mnuNewFolder.Size = new System.Drawing.Size(106, 29);
            this.mnuNewFolder.Text = "New Folder";
            this.mnuNewFolder.Click += new System.EventHandler(this.mnuNewFolder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // lblCurPos
            // 
            this.lblCurPos.Name = "lblCurPos";
            this.lblCurPos.Size = new System.Drawing.Size(137, 29);
            this.lblCurPos.Text = "Cursor Position:";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listProjDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtCode);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 451);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 2;
            // 
            // listProjDir
            // 
            this.listProjDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProjDir.Location = new System.Drawing.Point(0, 0);
            this.listProjDir.Name = "listProjDir";
            this.listProjDir.Size = new System.Drawing.Size(351, 451);
            this.listProjDir.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.txtCode.BackBrush = null;
            this.txtCode.CharHeight = 22;
            this.txtCode.CharWidth = 12;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.IsReplaceMode = false;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCode.Size = new System.Drawing.Size(698, 451);
            this.txtCode.TabIndex = 0;
            this.txtCode.Zoom = 100;
            // 
            // imglistIcons
            // 
            this.imglistIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistIcons.ImageStream")));
            this.imglistIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistIcons.Images.SetKeyName(0, "138.ico");
            this.imglistIcons.Images.SetKeyName(1, "2882.ico");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 518);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnuTools);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "HTML Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.mnuTools.ResumeLayout(false);
            this.mnuTools.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
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
        internal System.Windows.Forms.ImageList TreeNodeImageList;
        internal System.Windows.Forms.ImageList ListViewLargeImageList;
        internal System.Windows.Forms.ImageList ListViewSmallImageList;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnuNewFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblCurPos;
        private System.Windows.Forms.ToolStripMenuItem mnuSql;
        private System.Windows.Forms.ToolStripMenuItem mnuPhp;
        private System.Windows.Forms.ToolStripMenuItem mnuCsharp;
        private System.Windows.Forms.ToolStripMenuItem mnuVb;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox txtCode;
        private System.Windows.Forms.TreeView listProjDir;
        private System.Windows.Forms.ImageList imglistIcons;
    }
}

