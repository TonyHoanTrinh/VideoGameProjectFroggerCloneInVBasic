Option Explicit On
Public Class frmLevel1toLevel2

    Private Sub frmLevel1toLevel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'if the user presses enter..tt
        If e.KeyCode = Keys.Enter Then
            'hides the transition form..tt
            Me.Hide()
            'shows the level 2 form..tt
            frmLevel2.Show()
        End If
    End Sub

    Private Sub frmLevel1toLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the score label as the level 1 score..tt
        lblScoreLvl1toLvl2.Text = frmLevel1.score
    End Sub
End Class