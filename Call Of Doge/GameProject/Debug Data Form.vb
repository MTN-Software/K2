Public Class frmDebug

    Private Sub TblGameBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDave.Click
        Me.Validate()
        Me.TblGameBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DogeSaveDataSet)

    End Sub

    Private Sub Debug_Data_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DogeSaveDataSet.tblGame' table. You can move, or remove it, as needed.
        Me.TblGameTableAdapter.Fill(Me.DogeSaveDataSet.tblGame)

    End Sub

    Private Sub saveFromDoge()



    End Sub
End Class