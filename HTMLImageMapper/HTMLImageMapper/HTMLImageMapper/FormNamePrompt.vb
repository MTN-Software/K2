Public Class frmNamePrompt

    Private Sub txtHref_Click(sender As Object, e As EventArgs) Handles txtHref.Click
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class