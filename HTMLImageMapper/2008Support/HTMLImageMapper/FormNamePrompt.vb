Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Imports System.IO.Stream
Imports System.IO


Public Class frmNamePrompt

    Private Sub txtHref_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtHref.Click

    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnFindFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindFile.Click
        Dim ofdLink As OpenFileDialog = New OpenFileDialog()

        ofdLink.Title = "MTN HTML Image Mapper - Open HTML File"
        ofdLink.InitialDirectory = "C:\"
        ofdLink.Filter = "All Files (*.*)|*.*| HTML (*.htm)|*.htm*"
        ofdLink.FilterIndex = 2
        ofdLink.RestoreDirectory = True

        If ofdLink.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtHref.Text = ofdLink.FileName
        End If
    End Sub
End Class