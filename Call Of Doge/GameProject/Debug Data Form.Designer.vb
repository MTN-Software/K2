<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebug))
        Me.DogeSaveDataSet = New GameProject.DogeSaveDataSet
        Me.TblGameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGameTableAdapter = New GameProject.DogeSaveDataSetTableAdapters.tblGameTableAdapter
        Me.TableAdapterManager = New GameProject.DogeSaveDataSetTableAdapters.TableAdapterManager
        Me.mnuBindNav = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.mnuAdd = New System.Windows.Forms.ToolStripButton
        Me.mnuCount = New System.Windows.Forms.ToolStripLabel
        Me.mnuDel = New System.Windows.Forms.ToolStripButton
        Me.mnuFist = New System.Windows.Forms.ToolStripButton
        Me.mnuPrev = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.mnuPosition = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuNext = New System.Windows.Forms.ToolStripButton
        Me.mnuLast = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuDave = New System.Windows.Forms.ToolStripButton
        Me.TblGameDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlayerYPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlayerXPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlayerHealth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEnemyHealth = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEnemyYPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEnemyXPos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIsFacingLeft = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DogeSaveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuBindNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBindNav.SuspendLayout()
        CType(Me.TblGameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGameTableAdapter = Me.TblGameTableAdapter
        Me.TableAdapterManager.UpdateOrder = GameProject.DogeSaveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'mnuBindNav
        '
        Me.mnuBindNav.AddNewItem = Me.mnuAdd
        Me.mnuBindNav.BindingSource = Me.TblGameBindingSource
        Me.mnuBindNav.CountItem = Me.mnuCount
        Me.mnuBindNav.DeleteItem = Me.mnuDel
        Me.mnuBindNav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFist, Me.mnuPrev, Me.BindingNavigatorSeparator, Me.mnuPosition, Me.mnuCount, Me.BindingNavigatorSeparator1, Me.mnuNext, Me.mnuLast, Me.BindingNavigatorSeparator2, Me.mnuAdd, Me.mnuDel, Me.mnuDave})
        Me.mnuBindNav.Location = New System.Drawing.Point(0, 0)
        Me.mnuBindNav.MoveFirstItem = Me.mnuFist
        Me.mnuBindNav.MoveLastItem = Me.mnuLast
        Me.mnuBindNav.MoveNextItem = Me.mnuNext
        Me.mnuBindNav.MovePreviousItem = Me.mnuPrev
        Me.mnuBindNav.Name = "mnuBindNav"
        Me.mnuBindNav.PositionItem = Me.mnuPosition
        Me.mnuBindNav.Size = New System.Drawing.Size(523, 25)
        Me.mnuBindNav.TabIndex = 0
        Me.mnuBindNav.Text = "BindingNavigator1"
        '
        'mnuAdd
        '
        Me.mnuAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuAdd.Image = CType(resources.GetObject("mnuAdd.Image"), System.Drawing.Image)
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.RightToLeftAutoMirrorImage = True
        Me.mnuAdd.Size = New System.Drawing.Size(23, 22)
        Me.mnuAdd.Text = "Add new"
        '
        'mnuCount
        '
        Me.mnuCount.Name = "mnuCount"
        Me.mnuCount.Size = New System.Drawing.Size(35, 22)
        Me.mnuCount.Text = "of {0}"
        Me.mnuCount.ToolTipText = "Total number of items"
        '
        'mnuDel
        '
        Me.mnuDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuDel.Image = CType(resources.GetObject("mnuDel.Image"), System.Drawing.Image)
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.RightToLeftAutoMirrorImage = True
        Me.mnuDel.Size = New System.Drawing.Size(23, 22)
        Me.mnuDel.Text = "Delete"
        '
        'mnuFist
        '
        Me.mnuFist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuFist.Image = CType(resources.GetObject("mnuFist.Image"), System.Drawing.Image)
        Me.mnuFist.Name = "mnuFist"
        Me.mnuFist.RightToLeftAutoMirrorImage = True
        Me.mnuFist.Size = New System.Drawing.Size(23, 22)
        Me.mnuFist.Text = "Move first"
        '
        'mnuPrev
        '
        Me.mnuPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuPrev.Image = CType(resources.GetObject("mnuPrev.Image"), System.Drawing.Image)
        Me.mnuPrev.Name = "mnuPrev"
        Me.mnuPrev.RightToLeftAutoMirrorImage = True
        Me.mnuPrev.Size = New System.Drawing.Size(23, 22)
        Me.mnuPrev.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'mnuPosition
        '
        Me.mnuPosition.AccessibleName = "Position"
        Me.mnuPosition.AutoSize = False
        Me.mnuPosition.Name = "mnuPosition"
        Me.mnuPosition.Size = New System.Drawing.Size(50, 23)
        Me.mnuPosition.Text = "0"
        Me.mnuPosition.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mnuNext
        '
        Me.mnuNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuNext.Image = CType(resources.GetObject("mnuNext.Image"), System.Drawing.Image)
        Me.mnuNext.Name = "mnuNext"
        Me.mnuNext.RightToLeftAutoMirrorImage = True
        Me.mnuNext.Size = New System.Drawing.Size(23, 22)
        Me.mnuNext.Text = "Move next"
        '
        'mnuLast
        '
        Me.mnuLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuLast.Image = CType(resources.GetObject("mnuLast.Image"), System.Drawing.Image)
        Me.mnuLast.Name = "mnuLast"
        Me.mnuLast.RightToLeftAutoMirrorImage = True
        Me.mnuLast.Size = New System.Drawing.Size(23, 22)
        Me.mnuLast.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'mnuDave
        '
        Me.mnuDave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuDave.Image = CType(resources.GetObject("mnuDave.Image"), System.Drawing.Image)
        Me.mnuDave.Name = "mnuDave"
        Me.mnuDave.Size = New System.Drawing.Size(23, 22)
        Me.mnuDave.Text = "Save Data"
        '
        'TblGameDataGridView
        '
        Me.TblGameDataGridView.AutoGenerateColumns = False
        Me.TblGameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.clmPlayerYPos, Me.clmPlayerXPos, Me.clmPlayerHealth, Me.clmEnemyHealth, Me.clmEnemyYPos, Me.clmEnemyXPos, Me.clmIsFacingLeft})
        Me.TblGameDataGridView.DataSource = Me.TblGameBindingSource
        Me.TblGameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGameDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.TblGameDataGridView.Name = "TblGameDataGridView"
        Me.TblGameDataGridView.Size = New System.Drawing.Size(523, 416)
        Me.TblGameDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'clmPlayerYPos
        '
        Me.clmPlayerYPos.DataPropertyName = "PlayerYPos"
        Me.clmPlayerYPos.HeaderText = "PlayerYPos"
        Me.clmPlayerYPos.Name = "clmPlayerYPos"
        '
        'clmPlayerXPos
        '
        Me.clmPlayerXPos.DataPropertyName = "PlayerXPos"
        Me.clmPlayerXPos.HeaderText = "PlayerXPos"
        Me.clmPlayerXPos.Name = "clmPlayerXPos"
        '
        'clmPlayerHealth
        '
        Me.clmPlayerHealth.DataPropertyName = "PlayerHealth"
        Me.clmPlayerHealth.HeaderText = "PlayerHealth"
        Me.clmPlayerHealth.Name = "clmPlayerHealth"
        '
        'clmEnemyHealth
        '
        Me.clmEnemyHealth.DataPropertyName = "EnemyHealth"
        Me.clmEnemyHealth.HeaderText = "EnemyHealth"
        Me.clmEnemyHealth.Name = "clmEnemyHealth"
        '
        'clmEnemyYPos
        '
        Me.clmEnemyYPos.DataPropertyName = "EnemyYPos"
        Me.clmEnemyYPos.HeaderText = "EnemyYPos"
        Me.clmEnemyYPos.Name = "clmEnemyYPos"
        '
        'clmEnemyXPos
        '
        Me.clmEnemyXPos.DataPropertyName = "EnemyXPos"
        Me.clmEnemyXPos.HeaderText = "EnemyXPos"
        Me.clmEnemyXPos.Name = "clmEnemyXPos"
        '
        'clmIsFacingLeft
        '
        Me.clmIsFacingLeft.DataPropertyName = "IsFacingLeft"
        Me.clmIsFacingLeft.HeaderText = "IsFacingLeft"
        Me.clmIsFacingLeft.Name = "clmIsFacingLeft"
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 441)
        Me.Controls.Add(Me.TblGameDataGridView)
        Me.Controls.Add(Me.mnuBindNav)
        Me.Name = "frmDebug"
        Me.Text = "Debug_Data_Form"
        CType(Me.DogeSaveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuBindNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuBindNav.ResumeLayout(False)
        Me.mnuBindNav.PerformLayout()
        CType(Me.TblGameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DogeSaveDataSet As GameProject.DogeSaveDataSet
    Friend WithEvents TblGameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGameTableAdapter As GameProject.DogeSaveDataSetTableAdapters.tblGameTableAdapter
    Friend WithEvents TableAdapterManager As GameProject.DogeSaveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents mnuBindNav As System.Windows.Forms.BindingNavigator
    Friend WithEvents mnuAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mnuDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuFist As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPosition As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDave As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblGameDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlayerYPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlayerXPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlayerHealth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEnemyHealth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEnemyYPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEnemyXPos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIsFacingLeft As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
