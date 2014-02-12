<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnRect = New System.Windows.Forms.Button()
        Me.btnCirc = New System.Windows.Forms.Button()
        Me.btnPoly = New System.Windows.Forms.Button()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseCoordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.btnGenImageMap = New System.Windows.Forms.Button()
        Me.btnOpenImg = New System.Windows.Forms.Button()
        Me.statStrip = New System.Windows.Forms.StatusStrip()
        Me.lblMouseX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMouseY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPicMousePosX = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPicMousePosY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRect
        '
        Me.btnRect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRect.Location = New System.Drawing.Point(505, 52)
        Me.btnRect.Name = "btnRect"
        Me.btnRect.Size = New System.Drawing.Size(75, 23)
        Me.btnRect.TabIndex = 0
        Me.btnRect.Text = "Rectangle"
        Me.btnRect.UseVisualStyleBackColor = True
        '
        'btnCirc
        '
        Me.btnCirc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCirc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCirc.Location = New System.Drawing.Point(505, 81)
        Me.btnCirc.Name = "btnCirc"
        Me.btnCirc.Size = New System.Drawing.Size(75, 23)
        Me.btnCirc.TabIndex = 1
        Me.btnCirc.Text = "Circle"
        Me.btnCirc.UseVisualStyleBackColor = True
        '
        'btnPoly
        '
        Me.btnPoly.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPoly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPoly.Location = New System.Drawing.Point(505, 110)
        Me.btnPoly.Name = "btnPoly"
        Me.btnPoly.Size = New System.Drawing.Size(75, 23)
        Me.btnPoly.TabIndex = 2
        Me.btnPoly.Text = "Polygon"
        Me.btnPoly.UseVisualStyleBackColor = True
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(592, 24)
        Me.mnuStrip.TabIndex = 3
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(107, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MouseCoordsToolStripMenuItem})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'MouseCoordsToolStripMenuItem
        '
        Me.MouseCoordsToolStripMenuItem.Name = "MouseCoordsToolStripMenuItem"
        Me.MouseCoordsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MouseCoordsToolStripMenuItem.Text = "Mouse Coords"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(505, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnOpen, Me.btnSave, Me.toolStripSeparator, Me.btnCopy, Me.toolStripSeparator1, Me.btnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(592, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "&New"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "&Open"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "&Copy"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnHelp
        '
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 22)
        Me.btnHelp.Text = "He&lp"
        '
        'picImage
        '
        Me.picImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage.Location = New System.Drawing.Point(12, 52)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(487, 265)
        Me.picImage.TabIndex = 6
        Me.picImage.TabStop = False
        '
        'btnGenImageMap
        '
        Me.btnGenImageMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenImageMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenImageMap.Location = New System.Drawing.Point(505, 168)
        Me.btnGenImageMap.Name = "btnGenImageMap"
        Me.btnGenImageMap.Size = New System.Drawing.Size(75, 23)
        Me.btnGenImageMap.TabIndex = 7
        Me.btnGenImageMap.Text = "Generate"
        Me.btnGenImageMap.UseVisualStyleBackColor = True
        '
        'btnOpenImg
        '
        Me.btnOpenImg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenImg.Location = New System.Drawing.Point(505, 139)
        Me.btnOpenImg.Name = "btnOpenImg"
        Me.btnOpenImg.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenImg.TabIndex = 8
        Me.btnOpenImg.Text = "Open Image"
        Me.btnOpenImg.UseVisualStyleBackColor = True
        '
        'statStrip
        '
        Me.statStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMouseX, Me.lblMouseY, Me.lblPicMousePosX, Me.lblPicMousePosY})
        Me.statStrip.Location = New System.Drawing.Point(0, 320)
        Me.statStrip.Name = "statStrip"
        Me.statStrip.Size = New System.Drawing.Size(592, 22)
        Me.statStrip.TabIndex = 9
        Me.statStrip.Text = "statStrip"
        '
        'lblMouseX
        '
        Me.lblMouseX.Name = "lblMouseX"
        Me.lblMouseX.Size = New System.Drawing.Size(0, 17)
        '
        'lblMouseY
        '
        Me.lblMouseY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblMouseY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblMouseY.Name = "lblMouseY"
        Me.lblMouseY.Size = New System.Drawing.Size(0, 17)
        '
        'lblPicMousePosX
        '
        Me.lblPicMousePosX.Name = "lblPicMousePosX"
        Me.lblPicMousePosX.Size = New System.Drawing.Size(0, 17)
        '
        'lblPicMousePosY
        '
        Me.lblPicMousePosY.Name = "lblPicMousePosY"
        Me.lblPicMousePosY.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 342)
        Me.Controls.Add(Me.statStrip)
        Me.Controls.Add(Me.btnOpenImg)
        Me.Controls.Add(Me.btnGenImageMap)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPoly)
        Me.Controls.Add(Me.btnCirc)
        Me.Controls.Add(Me.btnRect)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmMain"
        Me.Text = "MTN HTML Image Mapper"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statStrip.ResumeLayout(False)
        Me.statStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRect As System.Windows.Forms.Button
    Friend WithEvents btnCirc As System.Windows.Forms.Button
    Friend WithEvents btnPoly As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MouseCoordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGenImageMap As System.Windows.Forms.Button
    Friend WithEvents btnOpenImg As System.Windows.Forms.Button
    Friend WithEvents statStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblMouseX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMouseY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPicMousePosX As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPicMousePosY As System.Windows.Forms.ToolStripStatusLabel

End Class
