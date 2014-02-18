<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNamePrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNamePrompt))
        Me.txtHref = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblHref = New System.Windows.Forms.Label
        Me.lblMessage = New System.Windows.Forms.Label
        Me.btnCancle = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblAlt = New System.Windows.Forms.Label
        Me.txtAlt = New System.Windows.Forms.TextBox
        Me.btnFindFile = New System.Windows.Forms.Button
        Me.lblMapApp = New System.Windows.Forms.Label
        Me.txtMapApp = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtHref
        '
        Me.txtHref.Location = New System.Drawing.Point(150, 125)
        Me.txtHref.Name = "txtHref"
        Me.txtHref.Size = New System.Drawing.Size(178, 20)
        Me.txtHref.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(150, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(212, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblHref
        '
        Me.lblHref.AutoSize = True
        Me.lblHref.Location = New System.Drawing.Point(12, 128)
        Me.lblHref.Name = "lblHref"
        Me.lblHref.Size = New System.Drawing.Size(100, 13)
        Me.lblHref.TabIndex = 3
        Me.lblHref.Text = "Hypertext reference"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(128, 13)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Please enter the following"
        '
        'btnCancle
        '
        Me.btnCancle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancle.Location = New System.Drawing.Point(287, 212)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(75, 23)
        Me.btnCancle.TabIndex = 9
        Me.btnCancle.Text = "Cancel"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(206, 212)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblAlt
        '
        Me.lblAlt.AutoSize = True
        Me.lblAlt.Location = New System.Drawing.Point(12, 96)
        Me.lblAlt.Name = "lblAlt"
        Me.lblAlt.Size = New System.Drawing.Size(43, 13)
        Me.lblAlt.TabIndex = 1
        Me.lblAlt.Text = "Alt Text"
        '
        'txtAlt
        '
        Me.txtAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlt.Location = New System.Drawing.Point(150, 93)
        Me.txtAlt.Name = "txtAlt"
        Me.txtAlt.Size = New System.Drawing.Size(212, 20)
        Me.txtAlt.TabIndex = 2
        '
        'btnFindFile
        '
        Me.btnFindFile.Location = New System.Drawing.Point(330, 123)
        Me.btnFindFile.Name = "btnFindFile"
        Me.btnFindFile.Size = New System.Drawing.Size(32, 23)
        Me.btnFindFile.TabIndex = 5
        Me.btnFindFile.Text = "..."
        Me.btnFindFile.UseVisualStyleBackColor = True
        '
        'lblMapApp
        '
        Me.lblMapApp.AutoSize = True
        Me.lblMapApp.Location = New System.Drawing.Point(13, 160)
        Me.lblMapApp.Name = "lblMapApp"
        Me.lblMapApp.Size = New System.Drawing.Size(99, 13)
        Me.lblMapApp.TabIndex = 6
        Me.lblMapApp.Text = "Image to apply map"
        '
        'txtMapApp
        '
        Me.txtMapApp.Location = New System.Drawing.Point(150, 157)
        Me.txtMapApp.Name = "txtMapApp"
        Me.txtMapApp.Size = New System.Drawing.Size(212, 20)
        Me.txtMapApp.TabIndex = 7
        '
        'frmNamePrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 247)
        Me.Controls.Add(Me.txtMapApp)
        Me.Controls.Add(Me.lblMapApp)
        Me.Controls.Add(Me.btnFindFile)
        Me.Controls.Add(Me.txtAlt)
        Me.Controls.Add(Me.lblAlt)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancle)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblHref)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtHref)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNamePrompt"
        Me.Text = "MTN HTML Image Mapper - Prompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHref As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblHref As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblAlt As System.Windows.Forms.Label
    Friend WithEvents txtAlt As System.Windows.Forms.TextBox
    Friend WithEvents btnFindFile As System.Windows.Forms.Button
    Friend WithEvents lblMapApp As System.Windows.Forms.Label
    Friend WithEvents txtMapApp As System.Windows.Forms.TextBox
End Class
