Imports System.IO

'======================================='
'Author:    Thomas Maloney              
'Date:      2/10/2014 - 2/17/2014       
'Program:   MTN HTML Image Mapper       
'======================================='

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private strXPos As String
    Private strYPos As String
    Private intPicXCoord As Integer
    Private intPicYCoord As Integer
    REM 1 = Rect, 2 = Circle, 3 = Poly
    Private intShapeProvider As Integer
    Public intCoords() As Integer
    Public strCoords(8) As String

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Dim dlgSave As DialogResult
        dlgSave = MessageBox.Show("Would you like to save any unsaved changes?", "MTN HTML Image Mapper - Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgSave = Windows.Forms.DialogResult.Yes Then
            'TODO: Save
        Else
            picImage.ImageLocation = "Images\Default.png"
        End If
    End Sub

    Private Sub btnOpenImg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpenImg.Click
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

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
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


    Private Sub btnRect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRect.Click
        intShapeProvider = 1
    End Sub

    Private Sub picImage_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picImage.Click
        Static Dim intClickCount As Integer = 1

        Try
            Select Case intShapeProvider
                Case 1
                    ReDim intCoords(4)
                    If intClickCount = 1 Then
                        'intCoords.SetValue(e.X, 0)
                        'intCoords.SetValue(e.Y, 1)
                        '<Debug Code>
                        'lblXOYO.Text = e.X.ToString() & ", " & e.Y.ToString()
                        '</Debug Code>
                        strCoords(0) = e.X.ToString()
                        strCoords(1) = e.Y.ToString()
                        intClickCount += 1
                    ElseIf intClickCount = 2 Then
                        'intCoords.SetValue(e.X, 2)
                        'intCoords.SetValue(e.Y, 3)
                        '<Debug Code>
                        'lblXTYT.Text = e.X.ToString() & ", " & e.Y.ToString()
                        '</Debug Code>
                        strCoords(2) = e.X.ToString()
                        strCoords(3) = e.Y.ToString()
                    Else
                        'intClickCount = 0
                    End If

                Case 2
                    If intClickCount = 1 Then
                        'intCoords.SetValue(e.X, 1)
                        'intCoords.SetValue(e.Y, 2)
                        strCoords(0) = e.X.ToString()
                        strCoords(1) = e.Y.ToString()
                        '<Debug Code>
                        'lblXOYO.Text = e.X.ToString() & ", " & e.Y.ToString()
                        '</Debug Code>
                        intClickCount += 1
                    ElseIf intClickCount = 2 Then
                        'intCoords.SetValue(e.X, 3)
                        strCoords(2) = e.X.ToString()

                        Dim intX As Integer
                        Dim intRadius As Integer
                        Integer.TryParse(strCoords(0), intX)
                        Integer.TryParse(strCoords(2), intRadius)   'Temp Storage
                        'If intRadius > intX, return (intRadius - intX) if intRadius < intX, return (intX - Radius)
                        intRadius = IIf(intRadius > intX, intRadius - intX, intX - intRadius)
                        '<Debug Code>
                        'lblXTYT.Text = e.X.ToString() & " radius: " & intRadius.ToString()
                        '</Debug Code>
                        strCoords(2) = intRadius.ToString()
                    Else
                        intClickCount = 1
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
            MessageBox.Show("Something went wrong..." & vbNewLine & ex.Message, "oops")
        End Try


    End Sub

    Private Sub createPoly()

    End Sub
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'intPicXCoord = picImage.Location.X - 12
        'intPicYCoord = picImage.Location.Y - 52
    End Sub

    Private Sub _MouseHover(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picImage.MouseMove
        lblMouseX.Text = "X: " & e.X.ToString()
        lblMouseY.Text = "Y: " & e.Y.ToString()

    End Sub


    Private Sub btnPoly_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPoly.Click
        intShapeProvider = 3
        MessageBox.Show("Polygons are not currently supported. However, if you think you can help, visit our github page!", "Sorry!", MessageBoxButtons.OK)
    End Sub

    Private Sub btnCirc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCirc.Click
        intShapeProvider = 2
    End Sub

    Private Sub btnGenImageMap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenImageMap.Click
        Dim strMapName As String
        Dim strHref As String
        Dim strAlt As String
        Dim strShapeMap As String
        Dim strImageApplication As String

        frmNamePrompt.ShowDialog()

        strHref = frmNamePrompt.txtHref.Text
        strMapName = frmNamePrompt.txtName.Text
        strAlt = frmNamePrompt.txtAlt.Text
        strImageApplication = frmNamePrompt.txtMapApp.Text

        If intShapeProvider = 1 Then
            strShapeMap = "<map name="" " & strMapName & " "">" & _
                           vbNewLine & vbTab & "<area shape=""rect"" coords=""" & strCoords(0) & "," & strCoords(1) & "," & strCoords(2) & "," & strCoords(3) & """  href=""" & strHref & """ alt=""" & strAlt & """/>" & _
                           vbNewLine & "</map>"
        ElseIf intShapeProvider = 2 Then
            strShapeMap = "<map name="" " & strMapName & " "">" & _
               vbNewLine & vbTab & "<area shape=""circle"" coords=""" & strCoords(0) & "," & strCoords(1) & "," & strCoords(2) & """  href=""" & strHref & """ alt=""" & strAlt & """/>" & _
               vbNewLine & "</map>"
        End If

        Dim dlgCopy As DialogResult = MessageBox.Show(strShapeMap & vbNewLine & "Pressing ok will set the above text to your clipboard", "MTN HTML Image Mapper - Code", MessageBoxButtons.OKCancel)

        If dlgCopy = Windows.Forms.DialogResult.OK Then
            My.Computer.Clipboard.SetText(strShapeMap)
        Else

        End If

        ''Write to file
        'Dim intPosToAdd As Integer = 0
        'Dim intLinePos As Integer = 0
        'Dim strToWrite As String
        'Dim result = New List(Of String)
        'Using reader = New StreamReader(strHref)
        '    Dim strLine As String = reader.ReadLine()
        '    Dim blnTake As Boolean = False
        '    Dim intCount As Integer = 0
        '    Do While strLine IsNot Nothing
        '        If strLine.Contains(strImageApplication) Then
        '            blnTake = True
        '            intPosToAdd = strLine.Length() - 2
        '            intLinePos = intCount
        '            Dim strTemp As String = strLine.Substring(0, intPosToAdd) & "usemap=" & Chr(34) & strMapName & Chr(34)
        '            strLine = strTemp & " /> "
        '            strToWrite = strLine
        '            'result.Add(strLine)
        '        End If
        '        If strLine.Contains(strImageApplication) = False Then
        '            blnTake = False
        '            'result.Add(strLine)
        '        End If
        '        If blnTake Then

        '        End If
        '        strLine = reader.ReadLine()
        '        intCount += 1
        '    Loop
        '    If reader.ReadToEnd() IsNot Nothing Then
        '        'My.Computer.Clipboard.SetText(strLine)
        '    Else
        '        MessageBox.Show("oops")
        '    End If

        'End Using

        'Using writer = New StreamWriter(strHref)

        '    writer.Write(strToWrite)
        '    writer.Close()
        'End Using

    End Sub

    Private Sub mnuAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAbout.Click
        frmAbout.Visible = True
    End Sub

End Class
