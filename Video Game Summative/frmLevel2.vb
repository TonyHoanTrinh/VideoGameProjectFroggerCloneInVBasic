Option Explicit On
Public Class frmLevel2
    'position variable to hold the position of the frog for collision checking..tt
    Dim Loc As Point
    'following boolean variables for the direction of the monster..tt
    Dim monster1Direction As Boolean = False
    Dim monster2Direction As Boolean = False
    Dim monster3Direction As Boolean = False
    Dim monster4Direction As Boolean = False
    Dim monster5Direction As Boolean = False
    Dim monster6Direction As Boolean = False
    Dim monster7Direction As Boolean = False
    Dim monster8Direction As Boolean = False
    Dim monster9Direction As Boolean = False
    'couunter2 variable holds the timer of the stage..tt
    Dim counter2 As Integer = 180
    'public score2 variable holds the user's score and allows it to be passed on to other forms later..tt
    Public score2 As Integer = 1800
    'lives2 variable to hold the lives the user has during the level 2 form..tt
    Dim lives2 As Integer = 3
    'frogs crossed 2 variable to hold the times the frog has crossed to the other side..tt
    Dim frogsCrossed2 As Integer = 0
    'sub for accessing the level 2 background music..tt
    Private Sub PlayBackgroundSoundFileLevel2()
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Vacation Wasteland - Slime Girls.wav", AudioPlayMode.BackgroundLoop)
        '"H:\Profile\Desktop\Music For Game\
    End Sub


    'allows for the movement of the frog shape and for the collision of the frog to the boundaries of the form..tt
    Private Sub frmLevel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'select case for the movement of the rectangle frog..tt
        Select Case e.KeyCode
            Case Keys.A
                If Not recFrog.Location.X - 40 < 0 Then
                    'if the frog is passed the border on the left , it sets the position of the frog back within the boundary..tt
                    Loc = New Point(recFrog.Location.X - 40, recFrog.Location.Y)
                    recFrog.Location = Loc
                End If
            Case Keys.D
                If Not recFrog.Location.X + 40 > Me.Width - recFrog.Width - 128 Then
                    'if the frog is passed the border on the right , it sets the position of the frog back within the boundary..tt
                    Loc = New Point(recFrog.Location.X + 40, recFrog.Location.Y)
                    recFrog.Location = Loc
                End If
            Case Keys.W
                If Not recFrog.Location.Y - 20 < 0 Then
                    'if the frog is passed the border on the top , it sets the position of the frog back within the boundary..tt
                    Loc = New Point(recFrog.Location.X, recFrog.Location.Y - 40)
                    recFrog.Location = Loc
                End If
            Case Keys.S
                If Not recFrog.Location.Y + 50 > Me.Height - recFrog.Height * 1.5 Then
                    'if the frog is passed the border on the bottom , it sets the position of the frog back within the boundary..tt
                    Loc = New Point(recFrog.Location.X, recFrog.Location.Y + 40)
                    recFrog.Location = Loc
                End If
        End Select
    End Sub

    Private Sub tmrForHorizontalMonsters_Tick(sender As Object, e As EventArgs) Handles tmrForHorizontalMonsters.Tick

        ' stuff for monster 1 
        If recMonster.Left <= 0 Then
            'if the monster passes the border on the left..tt
            monster1Direction = False
        ElseIf recMonster.Left > 580 Then
            'if the monster passes the border on the right..tt
            monster1Direction = True
        End If

        If monster1Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster.Left = recMonster.Left + 40
        ElseIf monster1Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster.Left = recMonster.Left - 40
        End If

        ' stuff for monster 2 
        If recMonster2.Left <= 0 Then
            'if the monster passes the border on the left..tt
            monster2Direction = False
        ElseIf recMonster2.Left > 580 Then
            'if the monster passes the border on the right..tt
            monster2Direction = True
        End If

        If monster2Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster2.Left = recMonster2.Left + 40
        ElseIf monster2Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster2.Left = recMonster2.Left - 40
        End If

        ' stuff for monster 3 
        If recMonster3.Left <= 0 Then
            'if the monster passes the border on the left..tt
            monster3Direction = False
        ElseIf recMonster3.Left > 580 Then
            'if the monster passes the border on the right..tt
            monster3Direction = True
        End If

        If monster3Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster3.Left = recMonster3.Left + 40
        ElseIf monster3Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster3.Left = recMonster3.Left - 40
        End If

        ' stuff for monster 4 
        If recMonster4.Left <= 0 Then
            'if the monster passes the border on the left..tt
            monster4Direction = False
        ElseIf recMonster4.Left > 580 Then
            'if the monster passes the border on the right..tt
            monster4Direction = True
        End If

        If monster4Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster4.Left = recMonster4.Left + 40
        ElseIf monster4Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster4.Left = recMonster4.Left - 40
        End If

        ' stuff for monster 5
        If recMonster5.Left <= 0 Then
            'if the monster passes the border on the left..tt
            monster5Direction = False
        ElseIf recMonster5.Left > 580 Then
            'if the monster passes the border on the right..tt
            monster5Direction = True
        End If

        If monster5Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster5.Left = recMonster5.Left + 40
        ElseIf monster5Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster5.Left = recMonster5.Left - 40
        End If

    End Sub

    Private Sub frmLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads it sets it so that the frog shape is above all the other shapes in the form..tt
        ShapeContainer1.Shapes.SetChildIndex(recFrog, 0)
        ShapeContainer1.Refresh()
        'calls in the background lvl 2 music sub to play the music..tt
        Call PlayBackgroundSoundFileLevel2()
        'assigns the name label in the form the name that the user entered on the main form
        lblName2.Text = frmName.nameOfUser
    End Sub

    Private Sub tmrCollisionChecker2_Tick(sender As Object, e As EventArgs) Handles tmrCollisionChecker2.Tick

        'if the frog collides with the shape and position of the 1st monster..tt
        If recFrog.Left <= recMonster.Left + 60 And recFrog.Left >= recMonster.Left - 40 Then
            If recFrog.Top <= recMonster.Top + 20 And recFrog.Top >= recMonster.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 2nd monster..tt
        If recFrog.Left <= recMonster2.Left + 60 And recFrog.Left >= recMonster2.Left - 40 Then
            If recFrog.Top <= recMonster2.Top + 20 And recFrog.Top >= recMonster2.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 3rd monster..tt
        If recFrog.Left <= recMonster3.Left + 60 And recFrog.Left >= recMonster3.Left - 40 Then
            If recFrog.Top <= recMonster3.Top + 20 And recFrog.Top >= recMonster3.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 4th monster..tt
        If recFrog.Left <= recMonster4.Left + 60 And recFrog.Left >= recMonster4.Left - 40 Then
            If recFrog.Top <= recMonster4.Top + 20 And recFrog.Top >= recMonster4.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 5th monster..tt
        If recFrog.Left <= recMonster5.Left + 60 And recFrog.Left >= recMonster5.Left - 40 Then
            If recFrog.Top <= recMonster5.Top + 20 And recFrog.Top >= recMonster5.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 6th monster..tt
        If recFrog.Left <= recMonster6.Left + 60 And recFrog.Left >= recMonster6.Left - 40 Then
            If recFrog.Top <= recMonster6.Top + 20 And recFrog.Top >= recMonster6.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 7th monster..tt
        If recFrog.Left <= recMonster7.Left + 60 And recFrog.Left >= recMonster7.Left - 40 Then
            If recFrog.Top <= recMonster7.Top + 20 And recFrog.Top >= recMonster7.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 8th monster..tt
        If recFrog.Left <= recMonster8.Left + 60 And recFrog.Left >= recMonster8.Left - 40 Then
            If recFrog.Top <= recMonster8.Top + 20 And recFrog.Top >= recMonster8.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 9th monster..tt
        If recFrog.Left <= recMonster9.Left + 60 And recFrog.Left >= recMonster9.Left - 40 Then
            If recFrog.Top <= recMonster9.Top + 20 And recFrog.Top >= recMonster9.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives2 = lives2 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'this condition will happen when the frog shape has passed to the other side of the screen..tt
        If recFrog.Top <= 30 Then
            'adds 1 to the frogs crossed variable..tt
            frogsCrossed2 = frogsCrossed2 + 1
            'assigsn the frogs crossed variable to the label numbe frogs crossed text..tt
            lblNumberFrogsCrossed.Text = frogsCrossed2
            'repositions the frog at the start of the level..tt
            recFrog.Location = New Point(296, 555)
            'if the total number of frogs crossed is equal to 3..tt
            If frogsCrossed2 = 3 Then
                'hides the level 1 form..tt
                Me.Hide()
                'goes into the level 1 to level 2 transition form..tt
                frmlevel2toLevel3.Show()
            End If
        End If

        'if the user's lives become 0 it will go into this condition..tt
        If lives2 = 0 Then
            'hides the level 2 form..tt
            Me.Hide()
            'opens the game over form..tt
            frmGameOver.Show()
        End If

        'following line assigns the lives label the value of lives variable..tt
        lblLives2.Text = lives2
    End Sub

    Private Sub tmrCountdown2_Tick(sender As Object, e As EventArgs) Handles tmrCountdown2.Tick
        'subs 1 every second to the counter variable..tt
        counter2 = counter2 - 1
        'sets the timer label text as the counter variable..tt
        lblTimer2.Text = counter2
        'every second it subtracts 10 from the score variable..tt
        score2 = score2 - 10
        'assigns the score variable to the label score text..tt
        lblScore2.Text = score2
    End Sub

    Private Sub tmrForVerticalMonsters_Tick(sender As Object, e As EventArgs) Handles tmrForVerticalMonsters.Tick
        ' stuff for monster 6
        If recMonster6.Top <= 0 Then
            'if the monster passes the border on the top..tt
            monster6Direction = False
        ElseIf recMonster6.Top > 580 Then
            'if the monster passes the border on the bottom..tt
            monster6Direction = True
        End If

        If monster6Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster6.Top = recMonster6.Top + 40
        ElseIf monster6Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster6.Top = recMonster6.Top - 40
        End If

        ' stuff for monster 7
        If recMonster7.Top <= 0 Then
            'if the monster passes the border on the top..tt
            monster7Direction = False
        ElseIf recMonster7.Top > 580 Then
            'if the monster passes the border on the bottom..tt
            monster7Direction = True
        End If

        If monster7Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster7.Top = recMonster7.Top + 40
        ElseIf monster5Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster7.Top = recMonster7.Top - 40
        End If

        ' stuff for monster 8
        If recMonster8.Top <= 0 Then
            'if the monster passes the border on the top..tt
            monster8Direction = False
        ElseIf recMonster8.Top > 580 Then
            'if the monster passes the border on the bottom..tt
            monster8Direction = True
        End If

        If monster8Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster8.Top = recMonster8.Top + 40
        ElseIf monster8Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster8.Top = recMonster8.Top - 40
        End If

        ' stuff for monster 9
        If recMonster9.Top <= 0 Then
            'if the monster passes the border on the top..tt
            monster9Direction = False
        ElseIf recMonster9.Top > 580 Then
            'if the monster passes the border on the bottom..tt
            monster9Direction = True
        End If

        If monster9Direction = False Then
            'adds 40 to the position of the monster..tt
            recMonster9.Top = recMonster9.Top + 40
        ElseIf monster9Direction = True Then
            'subtracts 40 to the position of the monster..tt
            recMonster9.Top = recMonster9.Top - 40
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'user clicks on this and it hides the level 2 form and goes into the form exit..tt
        Me.Hide()
        frmExit.Show()
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'user clicks on this and it hides the level 2 form and goes into the form main..tt
        Me.Hide()
        frmMain.Show()
    End Sub
End Class