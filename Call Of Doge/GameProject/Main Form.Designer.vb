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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tlbTools = New System.Windows.Forms.ToolStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripDropDownButton
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.tlbExit = New System.Windows.Forms.ToolStripMenuItem
        Me.tlbAbout = New System.Windows.Forms.ToolStripButton
        Me.mnuDifficulty = New System.Windows.Forms.ToolStripDropDownButton
        Me.mnuEasy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMedium = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDifficult = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDogeBirdOfShibe = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuX = New System.Windows.Forms.ToolStripLabel
        Me.mnuY = New System.Windows.Forms.ToolStripLabel
        Me.mnuRandomInt = New System.Windows.Forms.ToolStripLabel
        Me.mnuMyX = New System.Windows.Forms.ToolStripLabel
        Me.mnuMyY = New System.Windows.Forms.ToolStripLabel
        Me.picShibe = New System.Windows.Forms.PictureBox
        Me.lblGameTitle = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.picLeftBoundry = New System.Windows.Forms.PictureBox
        Me.picRightBoundry = New System.Windows.Forms.PictureBox
        Me.picGround = New System.Windows.Forms.PictureBox
        Me.picEnemySprite = New System.Windows.Forms.PictureBox
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picLaser = New System.Windows.Forms.PictureBox
        Me.picELasor = New System.Windows.Forms.PictureBox
        Me.prgPlayerHealth = New System.Windows.Forms.ProgressBar
        Me.prgEHealth = New System.Windows.Forms.ProgressBar
        Me.lblPlayerHealth = New System.Windows.Forms.Label
        Me.lblEHealth = New System.Windows.Forms.Label
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJump = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnNewSave = New System.Windows.Forms.Button
        Me.btnLoadSaved = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.DogeSaveDataSet = New GameProject.DogeSaveDataSet
        Me.TblGameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGameTableAdapter = New GameProject.DogeSaveDataSetTableAdapters.tblGameTableAdapter
        Me.tmrFall = New System.Windows.Forms.Timer(Me.components)
        Me.tlbTools.SuspendLayout()
        CType(Me.picShibe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBoundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemySprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picELasor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogeSaveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlbTools
        '
        Me.tlbTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.tlbAbout, Me.mnuDifficulty, Me.mnuX, Me.mnuY, Me.mnuRandomInt, Me.mnuMyX, Me.mnuMyY})
        Me.tlbTools.Location = New System.Drawing.Point(1, 1)
        Me.tlbTools.Name = "tlbTools"
        Me.tlbTools.Size = New System.Drawing.Size(1122, 25)
        Me.tlbTools.TabIndex = 0
        Me.tlbTools.Text = "ToolStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp, Me.tlbExit})
        Me.mnuFile.Image = CType(resources.GetObject("mnuFile.Image"), System.Drawing.Image)
        Me.mnuFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(38, 22)
        Me.mnuFile.Text = "&File"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelp.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelp.Text = "Help"
        '
        'tlbExit
        '
        Me.tlbExit.Name = "tlbExit"
        Me.tlbExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tlbExit.Size = New System.Drawing.Size(152, 22)
        Me.tlbExit.Text = "E&xit"
        '
        'tlbAbout
        '
        Me.tlbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlbAbout.Image = CType(resources.GetObject("tlbAbout.Image"), System.Drawing.Image)
        Me.tlbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbAbout.Name = "tlbAbout"
        Me.tlbAbout.Size = New System.Drawing.Size(44, 22)
        Me.tlbAbout.Text = "&About"
        '
        'mnuDifficulty
        '
        Me.mnuDifficulty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuDifficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEasy, Me.mnuMedium, Me.mnuDifficult, Me.mnuDogeBirdOfShibe})
        Me.mnuDifficulty.Image = CType(resources.GetObject("mnuDifficulty.Image"), System.Drawing.Image)
        Me.mnuDifficulty.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuDifficulty.Name = "mnuDifficulty"
        Me.mnuDifficulty.Size = New System.Drawing.Size(68, 22)
        Me.mnuDifficulty.Text = "Difficulty"
        '
        'mnuEasy
        '
        Me.mnuEasy.Name = "mnuEasy"
        Me.mnuEasy.Size = New System.Drawing.Size(172, 22)
        Me.mnuEasy.Text = "Easy"
        '
        'mnuMedium
        '
        Me.mnuMedium.Name = "mnuMedium"
        Me.mnuMedium.Size = New System.Drawing.Size(172, 22)
        Me.mnuMedium.Text = "Medium"
        '
        'mnuDifficult
        '
        Me.mnuDifficult.Name = "mnuDifficult"
        Me.mnuDifficult.Size = New System.Drawing.Size(172, 22)
        Me.mnuDifficult.Text = "Difficult"
        '
        'mnuDogeBirdOfShibe
        '
        Me.mnuDogeBirdOfShibe.Name = "mnuDogeBirdOfShibe"
        Me.mnuDogeBirdOfShibe.Size = New System.Drawing.Size(172, 22)
        Me.mnuDogeBirdOfShibe.Text = "Doge Bird of Shibe"
        '
        'mnuX
        '
        Me.mnuX.Name = "mnuX"
        Me.mnuX.Size = New System.Drawing.Size(26, 22)
        Me.mnuX.Text = "x = "
        '
        'mnuY
        '
        Me.mnuY.Name = "mnuY"
        Me.mnuY.Size = New System.Drawing.Size(27, 22)
        Me.mnuY.Text = "y = "
        '
        'mnuRandomInt
        '
        Me.mnuRandomInt.Name = "mnuRandomInt"
        Me.mnuRandomInt.Size = New System.Drawing.Size(72, 22)
        Me.mnuRandomInt.Text = "will shoot = "
        '
        'mnuMyX
        '
        Me.mnuMyX.Name = "mnuMyX"
        Me.mnuMyX.Size = New System.Drawing.Size(45, 22)
        Me.mnuMyX.Text = "My X ="
        '
        'mnuMyY
        '
        Me.mnuMyY.Name = "mnuMyY"
        Me.mnuMyY.Size = New System.Drawing.Size(48, 22)
        Me.mnuMyY.Text = "My Y = "
        '
        'picShibe
        '
        Me.picShibe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picShibe.Image = CType(resources.GetObject("picShibe.Image"), System.Drawing.Image)
        Me.picShibe.Location = New System.Drawing.Point(51, 492)
        Me.picShibe.Name = "picShibe"
        Me.picShibe.Size = New System.Drawing.Size(160, 128)
        Me.picShibe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShibe.TabIndex = 1
        Me.picShibe.TabStop = False
        '
        'lblGameTitle
        '
        Me.lblGameTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGameTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTitle.Location = New System.Drawing.Point(358, 102)
        Me.lblGameTitle.Name = "lblGameTitle"
        Me.lblGameTitle.Size = New System.Drawing.Size(432, 137)
        Me.lblGameTitle.TabIndex = 2
        Me.lblGameTitle.Text = "Call of Doge"
        Me.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.BorderSize = 3
        Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(492, 242)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(160, 60)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(492, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 60)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picLeftBoundry
        '
        Me.picLeftBoundry.BackColor = System.Drawing.Color.Transparent
        Me.picLeftBoundry.Location = New System.Drawing.Point(1, 29)
        Me.picLeftBoundry.Name = "picLeftBoundry"
        Me.picLeftBoundry.Size = New System.Drawing.Size(44, 639)
        Me.picLeftBoundry.TabIndex = 6
        Me.picLeftBoundry.TabStop = False
        '
        'picRightBoundry
        '
        Me.picRightBoundry.BackColor = System.Drawing.Color.Transparent
        Me.picRightBoundry.Location = New System.Drawing.Point(1079, 29)
        Me.picRightBoundry.Name = "picRightBoundry"
        Me.picRightBoundry.Size = New System.Drawing.Size(44, 639)
        Me.picRightBoundry.TabIndex = 7
        Me.picRightBoundry.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Gray
        Me.picGround.Location = New System.Drawing.Point(51, 618)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1022, 18)
        Me.picGround.TabIndex = 8
        Me.picGround.TabStop = False
        '
        'picEnemySprite
        '
        Me.picEnemySprite.BackgroundImage = Global.GameProject.My.Resources.Resources.callofDoge
        Me.picEnemySprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnemySprite.Location = New System.Drawing.Point(890, 492)
        Me.picEnemySprite.Name = "picEnemySprite"
        Me.picEnemySprite.Size = New System.Drawing.Size(183, 128)
        Me.picEnemySprite.TabIndex = 9
        Me.picEnemySprite.TabStop = False
        '
        'tmrGame
        '
        '
        'picLaser
        '
        Me.picLaser.Image = Global.GameProject.My.Resources.Resources.laser
        Me.picLaser.Location = New System.Drawing.Point(83, 374)
        Me.picLaser.Name = "picLaser"
        Me.picLaser.Size = New System.Drawing.Size(84, 32)
        Me.picLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaser.TabIndex = 5
        Me.picLaser.TabStop = False
        Me.picLaser.Visible = False
        '
        'picELasor
        '
        Me.picELasor.Image = Global.GameProject.My.Resources.Resources.laser
        Me.picELasor.Location = New System.Drawing.Point(51, 149)
        Me.picELasor.Name = "picELasor"
        Me.picELasor.Size = New System.Drawing.Size(84, 32)
        Me.picELasor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picELasor.TabIndex = 10
        Me.picELasor.TabStop = False
        Me.picELasor.Visible = False
        '
        'prgPlayerHealth
        '
        Me.prgPlayerHealth.Location = New System.Drawing.Point(51, 55)
        Me.prgPlayerHealth.Name = "prgPlayerHealth"
        Me.prgPlayerHealth.Size = New System.Drawing.Size(308, 23)
        Me.prgPlayerHealth.TabIndex = 11
        Me.prgPlayerHealth.Value = 100
        '
        'prgEHealth
        '
        Me.prgEHealth.Location = New System.Drawing.Point(765, 55)
        Me.prgEHealth.Name = "prgEHealth"
        Me.prgEHealth.Size = New System.Drawing.Size(308, 23)
        Me.prgEHealth.TabIndex = 12
        Me.prgEHealth.Value = 100
        '
        'lblPlayerHealth
        '
        Me.lblPlayerHealth.AutoSize = True
        Me.lblPlayerHealth.Location = New System.Drawing.Point(51, 39)
        Me.lblPlayerHealth.Name = "lblPlayerHealth"
        Me.lblPlayerHealth.Size = New System.Drawing.Size(67, 13)
        Me.lblPlayerHealth.TabIndex = 13
        Me.lblPlayerHealth.Text = "Doge Health"
        '
        'lblEHealth
        '
        Me.lblEHealth.AutoSize = True
        Me.lblEHealth.Location = New System.Drawing.Point(762, 39)
        Me.lblEHealth.Name = "lblEHealth"
        Me.lblEHealth.Size = New System.Drawing.Size(73, 13)
        Me.lblEHealth.TabIndex = 14
        Me.lblEHealth.Text = "Enemy Health"
        '
        'tmrShoot
        '
        Me.tmrShoot.Interval = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 3
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(492, 308)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 60)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLoad.FlatAppearance.BorderSize = 3
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(492, 374)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(160, 60)
        Me.btnLoad.TabIndex = 16
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnNewSave
        '
        Me.btnNewSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNewSave.FlatAppearance.BorderSize = 3
        Me.btnNewSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnNewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSave.Location = New System.Drawing.Point(864, 242)
        Me.btnNewSave.Name = "btnNewSave"
        Me.btnNewSave.Size = New System.Drawing.Size(209, 60)
        Me.btnNewSave.TabIndex = 17
        Me.btnNewSave.Text = "New Save"
        Me.btnNewSave.UseVisualStyleBackColor = False
        '
        'btnLoadSaved
        '
        Me.btnLoadSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoadSaved.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSaved.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLoadSaved.FlatAppearance.BorderSize = 3
        Me.btnLoadSaved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoadSaved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnLoadSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSaved.Location = New System.Drawing.Point(864, 308)
        Me.btnLoadSaved.Name = "btnLoadSaved"
        Me.btnLoadSaved.Size = New System.Drawing.Size(209, 60)
        Me.btnLoadSaved.TabIndex = 18
        Me.btnLoadSaved.Text = "Load Save"
        Me.btnLoadSaved.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBack.FlatAppearance.BorderSize = 3
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(864, 374)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(209, 60)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DogeSaveDataSet
        '
        Me.DogeSaveDataSet.DataSetName = "DogeSaveDataSet"
        Me.DogeSaveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGameBindingSource
        '
        Me.TblGameBindingSource.DataMember = "tblGame"
        Me.TblGameBindingSource.DataSource = Me.DogeSaveDataSet
        '
        'TblGameTableAdapter
        '
        Me.TblGameTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameProject.My.Resources.Resources.forestThree
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1124, 636)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLoadSaved)
        Me.Controls.Add(Me.btnNewSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblEHealth)
        Me.Controls.Add(Me.lblPlayerHealth)
        Me.Controls.Add(Me.prgEHealth)
        Me.Controls.Add(Me.prgPlayerHealth)
        Me.Controls.Add(Me.picELasor)
        Me.Controls.Add(Me.picEnemySprite)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picLaser)
        Me.Controls.Add(Me.picShibe)
        Me.Controls.Add(Me.picRightBoundry)
        Me.Controls.Add(Me.picLeftBoundry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblGameTitle)
        Me.Controls.Add(Me.tlbTools)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Call of Doge"
        Me.tlbTools.ResumeLayout(False)
        Me.tlbTools.PerformLayout()
        CType(Me.picShibe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBoundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemySprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picELasor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogeSaveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlbTools As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tlbExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlbAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents picShibe As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameTitle As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLeftBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBoundry As System.Windows.Forms.PictureBox
    Friend WithEvents picGround As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemySprite As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents picLaser As System.Windows.Forms.PictureBox
    Friend WithEvents picELasor As System.Windows.Forms.PictureBox
    Friend WithEvents prgPlayerHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents prgEHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPlayerHealth As System.Windows.Forms.Label
    Friend WithEvents lblEHealth As System.Windows.Forms.Label
    Friend WithEvents tmrShoot As System.Windows.Forms.Timer
    Friend WithEvents tmrJump As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnNewSave As System.Windows.Forms.Button
    Friend WithEvents btnLoadSaved As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DogeSaveDataSet As GameProject.DogeSaveDataSet
    Friend WithEvents TblGameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGameTableAdapter As GameProject.DogeSaveDataSetTableAdapters.tblGameTableAdapter
    Friend WithEvents tmrFall As System.Windows.Forms.Timer
    Friend WithEvents mnuX As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuY As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuRandomInt As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuMyX As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuMyY As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuDifficulty As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEasy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMedium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDifficult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDogeBirdOfShibe As System.Windows.Forms.ToolStripMenuItem

End Class
