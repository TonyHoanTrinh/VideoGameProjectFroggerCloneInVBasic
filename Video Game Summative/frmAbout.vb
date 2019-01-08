Option Explicit On
Public Class frmAbout

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        'user clicks on the return button , hides the about form and goes back to the main form..tt
        Me.Hide()
        frmMain.Show()
    End Sub

End Class