Option Explicit On
Public Class frmlevel2toLevel3

    Private Sub frmLevel2toLevel3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'if the user presses enter..tt
        If e.KeyCode = Keys.Enter Then
            'hides the transition form..tt
            Me.Hide()
            'shows the level 3 form..tt
            frmLevel3.Show()
        End If
    End Sub

    Private Sub frmLevel2toLevel3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the score label as the level 2 score..tt
        lblScoreLvl2toLvl3.Text = frmLevel2.score2
    End Sub
End Class