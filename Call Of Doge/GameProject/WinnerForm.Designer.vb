<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinner
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
        Me.lblWinner = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblWowTwo = New System.Windows.Forms.Label
        Me.lblWowOne = New System.Windows.Forms.Label
        Me.lblWowThree = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(63, 40)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(514, 23)
        Me.lblWinner.TabIndex = 0
        Me.lblWinner.Text = "Winner"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(240, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 60)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblWowTwo
        '
        Me.lblWowTwo.AutoSize = True
        Me.lblWowTwo.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWowTwo.Location = New System.Drawing.Point(434, 178)
        Me.lblWowTwo.Name = "lblWowTwo"
        Me.lblWowTwo.Size = New System.Drawing.Size(94, 22)
        Me.lblWowTwo.TabIndex = 6
        Me.lblWowTwo.Text = "Winner"
        Me.lblWowTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWowOne
        '
        Me.lblWowOne.AutoSize = True
        Me.lblWowOne.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWowOne.Location = New System.Drawing.Point(63, 122)
        Me.lblWowOne.Name = "lblWowOne"
        Me.lblWowOne.Size = New System.Drawing.Size(94, 22)
        Me.lblWowOne.TabIndex = 7
        Me.lblWowOne.Text = "Winner"
        Me.lblWowOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWowThree
        '
        Me.lblWowThree.AutoSize = True
        Me.lblWowThree.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWowThree.Location = New System.Drawing.Point(124, 205)
        Me.lblWowThree.Name = "lblWowThree"
        Me.lblWowThree.Size = New System.Drawing.Size(94, 22)
        Me.lblWowThree.TabIndex = 8
        Me.lblWowThree.Text = "Winner"
        Me.lblWowThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 385)
        Me.Controls.Add(Me.lblWowThree)
        Me.Controls.Add(Me.lblWowOne)
        Me.Controls.Add(Me.lblWowTwo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWinner)
        Me.Name = "frmWinner"
        Me.Text = "The winner is..."
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWowTwo As System.Windows.Forms.Label
    Friend WithEvents lblWowOne As System.Windows.Forms.Label
    Friend WithEvents lblWowThree As System.Windows.Forms.Label
End Class
