Option Explicit On
Public Class frmInstructions

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        'if the user presses on the return button..tt
        'hides the current instructions form and goes back to the main form..tt
        Me.Hide()
        frmMain.Show()
    End Sub

End Class