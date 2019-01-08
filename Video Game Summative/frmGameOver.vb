Option Explicit On
Public Class frmGameOver

    Private Sub cmdReturnToMenu_Click(sender As Object, e As EventArgs) Handles cmdReturnToMenu.Click
        'user clicks on the return button..tt
        'hides the gameover form and goes to the main form..tt
        Me.Hide()
        frmMain.Show()
    End Sub

    'sub for playing the background music for the game over form..tt
    Private Sub PlayBackgroundSoundFileGameOver()
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Metroid (NES) Music - Title Theme.wav", AudioPlayMode.BackgroundLoop)
        '"H:\Profile\Desktop\Music For Game'
    End Sub

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls in the background music for the game over form..tt
        Call PlayBackgroundSoundFileGameOver()
    End Sub
End Class