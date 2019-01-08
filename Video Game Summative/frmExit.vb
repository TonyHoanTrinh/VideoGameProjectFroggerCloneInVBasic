Option Explicit On
Public Class frmExit
    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        'hides the exit form and goes into the main form..tt
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub cmdYes_Click(sender As Object, e As EventArgs) Handles cmdYes.Click
        'user clicks on yes and ends the program..tt
        End
    End Sub

End Class