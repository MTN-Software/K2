Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private strXPos As String
    Private strYPos As String
    Private intPicXCoord As Integer
    Private intPicYCoord As Integer
    REM 1 = Rect, 2 = Circle, 3 = Poly
    Private intShapeProvider As Integer
    Public intCoords() As Integer

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim dlgSave As DialogResult
        dlgSave = MessageBox.Show("Would you like to save any unsaved changes?", "MTN HTML Image Mapper - Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgSave = Windows.Forms.DialogResult.Yes Then
            'TODO: Save
        Else
            picImage.ImageLocation = "Images\Default.png"
        End If
    End Sub

    Private Sub btnOpenImg_Click(sender As Object, e As EventArgs) Handles btnOpenImg.Click
        Dim ofdImage As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        ofdImage.Title = "MTN HTML Image Mapper - Open Image"
        ofdImage.InitialDirectory = "C:\"
        ofdImage.Filter = "All Files (*.*)|*.*| JPEG (*.jpg) |*.jpg| PNG (*.png) |*.png"
        ofdImage.FilterIndex = 2
        ofdImage.RestoreDirectory = True

        If ofdImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = ofdImage.FileName
            picImage.Image = Image.FromFile(strFileName)
        End If

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim ofdHTML As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        ofdHTML.Title = "MTN HTML Image Mapper - Open Image Map"
        ofdHTML.InitialDirectory = "C:\"
        ofdHTML.Filter = "All Files (*.*)|*.*| HTML (*.htm)|*.htm*"
        ofdHTML.FilterIndex = 2
        ofdHTML.RestoreDirectory = True

        If ofdHTML.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = ofdHTML.FileName
        End If
    End Sub


    Private Sub btnRect_Click(sender As Object, e As EventArgs) Handles btnRect.Click
        intShapeProvider = 1
    End Sub

    Private Sub picImage_Click(sender As Object, e As MouseEventArgs) Handles picImage.Click
        Static Dim intClickCount As Integer = 0
        intClickCount += 1
        Try
            Select Case intShapeProvider
                Case 1
                    If intClickCount = 1 Then
                    ' This does not work, fix it!
                        intCoords.SetValue(e.X, 1)
                        intCoords.SetValue(e.Y, 2)
                    ElseIf intClickCount = 2 Then
                        intCoords.SetValue(e.X, 3)
                        intCoords.SetValue(e.Y, 4)
                    Else

                    End If

                Case 2
                    If intClickCount = 1 Then
                        intCoords.SetValue(e.X, 1)
                        intCoords.SetValue(e.Y, 2)
                    ElseIf intClickCount = 2 Then
                        intCoords.SetValue(e.X, 3)
                    End If

                Case 3
                    createPoly()
                Case Else
                    MessageBox.Show("Oops! You should click a button!", "Error", MessageBoxButtons.OK)
                    intClickCount = 0
            End Select

            If intClickCount > 2 Then
                intClickCount = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Something's screwy..." & vbNewLine & ex.Message, "oops")
        End Try
        

    End Sub

    Private Sub createPoly()

    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        intPicXCoord = picImage.Location.X - 12
        intPicYCoord = picImage.Location.Y - 52
    End Sub

    Private Sub _MouseHover(sender As Object, e As EventArgs) Handles Me.MouseMove, picImage.MouseMove, ToolStrip1.MouseMove, mnuStrip.MouseMove
        getMouseCoords()
    End Sub

    ''' <summary>
    ''' This might not be entirely correct
    ''' I think this will show your cursor's position
    ''' in respect to the screen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub getMouseCoords()
        Dim intPicXMouse As Integer
        Dim intPicYMouse As Integer
        intPicXMouse = MousePosition.X - 12
        intPicYMouse = MousePosition.Y - 52
        strXPos = MousePosition.X.ToString()
        strYPos = MousePosition.Y.ToString()
        lblMouseX.Text = "X: " & strXPos
        lblMouseY.Text = "Y: " & strYPos
        lblPicMousePosX.Text = "X w/ respect to img: " & intPicXMouse.ToString()
        lblPicMousePosY.Text = "Y w/ respect to img: " & intPicYMouse.ToString()
    End Sub

    Private Sub btnPoly_Click(sender As Object, e As EventArgs) Handles btnPoly.Click
        intShapeProvider = 3
    End Sub

    Private Sub btnCirc_Click(sender As Object, e As EventArgs) Handles btnCirc.Click
        intShapeProvider = 2
    End Sub

    Private Sub btnGenImageMap_Click(sender As Object, e As EventArgs) Handles btnGenImageMap.Click
        Dim strMapName As String = MsgBox("Map Name?", MsgBoxStyle.OkOnly, "MTN HTML Image Mapper - Generator")
        Dim strRectMap As String = "<map name="" " & strMapName & " "">" & _
                                   vbTab & "<area shape=""rect"" coords=""" & intCoords(1).ToString() & "," & intCoords(2).ToString() & "," & intCoords(3).ToString() & "," & intCoords(4).ToString() & """  href=""example.htm"" alt=""Something""/>" & _
                                   "</map>"
        MessageBox.Show(strRectMap, "MTN HTML Image Mapper - Code", MessageBoxButtons.OK)

    End Sub
End Class
