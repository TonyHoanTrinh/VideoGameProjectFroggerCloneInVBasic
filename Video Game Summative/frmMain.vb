Option Explicit On
Public Class frmMain
    'this sub allows the playing of the background song ..tt
    Private Sub PlayBackgroundSoundFileMainScreen()
        'accesses the sound file on the desktop..tt
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Anamanaguchi - Blackout City.wav", AudioPlayMode.BackgroundLoop)
        'for normal use "H:\Profile\Desktop\Music For Game\Anamanaguchi - Blackout City.wav"
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'user presses on the exit button and it hides the main form and goes into the exit form..tt
        Me.Hide()
        frmExit.Show()

    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        'user presses on the about button and it hides the main form and goes into the about form..tt
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        'user presses on the start button and it hides the main form and goes into the level 1 form..tt
        Me.Hide()
        frmName.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'calls in the background main screen music 
        Call PlayBackgroundSoundFileMainScreen()
    End Sub


    Private Sub cmdInstructions_Click(sender As Object, e As EventArgs) Handles cmdInstructions.Click
        'user clicks on instructions , hides main form and goes into the instrucitons form..tt
        Me.Hide()
        frmInstructions.Show()
    End Sub
End Class
