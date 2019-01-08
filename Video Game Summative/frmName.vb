Option Explicit On
Public Class frmName
    'creates a public variable for the name of the user to be used for other forms as well..tt
    Public nameOfUser As String
    Private Sub cmdEnterYourName_Click(sender As Object, e As EventArgs) Handles cmdEnterYourName.Click
        If txtNameEnter.Text = "" Then
            'nothing..tt
            'dummy proofing in case user enters nothing..tt
            MsgBox("Please Enter your Name!")
        ElseIf IsNumeric(txtNameEnter.Text) = True Then
            'if the user enters numbers
            MsgBox("Please Enter an actual name please!")
            txtNameEnter.Text = ""
            txtNameEnter.Focus()
            txtNameEnter.Refresh()
        Else
            'if else , it will accept the answer and hide the name form and go straight into level 1 of the game..tt
            Me.Hide()
            frmLevel1.Show()
        End If
    End Sub

    Private Sub frmName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNameEnter.Focus()
    End Sub
End Class