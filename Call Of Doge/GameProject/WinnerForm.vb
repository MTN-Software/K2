' Program:      Call of Doge
' Desc:         Deplete enemy health
' Programmer:   Thomas Maloney on December 6, 2013

Public Class frmWinner

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        My.Forms.frmMain.Close()
        Me.Close()
    End Sub


    Private Sub frmWinner_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        lblWinner.Text = strWinnerMessage
        If frmMain.prgPlayerHealth.Value <> 0 Then
            lblWowOne.Text = strWowMessage(0)
            lblWowTwo.Text = strWowMessage(1)
            lblWowThree.Text = strWowMessage(2)
        ElseIf frmMain.prgPlayerHealth.Value = 0 Then
            lblWowOne.Text = strWowMessage(3)
            lblWowTwo.Text = strWowMessage(4)
            lblWowThree.Text = strWowMessage(5)
        End If
    End Sub
End Class