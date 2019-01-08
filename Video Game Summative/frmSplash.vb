Option Explicit On
Public Class frmSplash
    'this sub allows the playing of the coin sound effect ..tt
    Private Sub PlayBackgroundSoundFile()
        'accesses the sound file on the desktop..tt
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Super Mario Bros.-Coin Sound Effect.wav", AudioPlayMode.WaitToComplete)
        'for normal use "H:\Profile\Desktop\Music For Game\Super Mario Bros.-Coin Sound Effect.wav..tt"
    End Sub

    Private Sub frmSplash_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'this condition happens if the user presses the enter button..tt
        If e.KeyCode = Keys.Enter Then
            'plays a coin sound effect..tt
            Call PlayBackgroundSoundFile()
            'hides the splash form and goes into the main form..tt
            Me.Hide()
            frmMain.Show()
        End If
    End Sub

End Class