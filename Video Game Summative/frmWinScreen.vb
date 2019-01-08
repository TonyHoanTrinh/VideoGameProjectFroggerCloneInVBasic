Option Explicit On
Public Class frmWinScreen

    'sub for calling in the background win screen music..tt
    Private Sub PlayBackgroundSoundFileWinSceen()
        My.Computer.Audio.Play("H:\Profile\Desktop\Music For Game\Kirby's Adventure (NES) Music - Title Theme.mp3", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub frmWinScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls in the sub that brings in the background win screen music..tt
        Call PlayBackgroundSoundFileWinSceen()
        'sets the final score label's text as all 3 scores combined..tt
        lblFinalScore.Text = frmLevel1.score + frmLevel2.score2 + frmLevel3.score3
    End Sub

    
    Private Sub cmdReturnToMainFromWin_Click(sender As Object, e As EventArgs) Handles cmdReturnToMainFromWin.Click
        'user clicks on the return button..tt
        'hides the win screen form and goes to main screen form..tt
        Me.Hide()
        frmMain.Show()
    End Sub
End Class