Option Explicit On
Public Class frmLevel3
    'variable to hold the current position of the frog rectangle..tt
    Dim Loc As Point
    'counter variable is used for the tmrCountdown3..tt
    Dim counter3 As Integer = 180
    'public variable score to hold the score for the 3rd level and for it be passed down in later forms..tt
    Public score3 As Integer = 1800
    'lives variable to hold the user's lives at the beginning of the level.tt
    Dim lives3 As Integer = 3
    'frogsCrossed variable to hold the times the frog has crossed to the other side..tt
    Dim frogsCrossed3 As Integer = 0
    'following boolean variables are for the switch in direction of their movement in the level..tt
    Dim lvl3MonsterDirection As Boolean = False
    Dim lvl3Monster2Direction As Boolean = False
    Dim lvl3Monster3Direction As Boolean = False
    Dim lvl3Monster4Direction As Boolean = False
    Dim lvl3Monster5Direction As Boolean = False
    Dim lvl3Monster6Direction As Boolean = False
    Dim lvl3Monster7Direction As Boolean = False

    'sub to call in the background music for lvl 3..tt
    Private Sub PlayBackgroundSoundFileLevel3()
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Silver Surfer - Level 1 - Nes Music.wav", AudioPlayMode.BackgroundLoop)
        '"H:\Profile\Desktop\Music For Game\
    End Sub

    'sub for the movement of the frog shape and the collision of the frog to the sides of the form..tt
    Private Sub frmLevel3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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


    Private Sub frmLevel3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads it sets it so that the frog shape is above all the other shapes in the form..tt
        ShapeContainer2.Shapes.SetChildIndex(recFrog, 0)
        ShapeContainer2.Refresh()
        'calls in the background lvl 2 music sub to play the music..tt
        Call PlayBackgroundSoundFileLevel3()
        'assigns the name label in the form the name that the user entered on the main form..tt
        lblName3.Text = frmName.nameOfUser
    End Sub


    Private Sub tmrForMonsters_Tick(sender As Object, e As EventArgs) Handles tmrForMonsters.Tick
        ' stuff for monster 1..tt
        If recLevel3Monster.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3MonsterDirection = False
        ElseIf recLevel3Monster.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3MonsterDirection = True
        End If

        If lvl3MonsterDirection = False Then
            'adds 20 to the position of the monster.tt
            recLevel3Monster.Left = recLevel3Monster.Left + 20
        ElseIf lvl3MonsterDirection = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster.Left = recLevel3Monster.Left - 20
        End If

        ' stuff for monster 2 
        If recLevel3Monster2.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster2Direction = False
        ElseIf recLevel3Monster2.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster2Direction = True
        End If

        If lvl3Monster2Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster2.Left = recLevel3Monster2.Left + 20
        ElseIf lvl3Monster2Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster2.Left = recLevel3Monster2.Left - 20
        End If

        ' stuff for monster 3 
        If recLevel3Monster3.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster3Direction = False
        ElseIf recLevel3Monster3.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster3Direction = True
        End If

        If lvl3Monster3Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster3.Left = recLevel3Monster3.Left + 20
        ElseIf lvl3Monster3Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster3.Left = recLevel3Monster3.Left - 20
        End If

        ' stuff for monster 4
        If recLevel3Monster4.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster4Direction = False
        ElseIf recLevel3Monster4.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster4Direction = True
        End If

        If lvl3Monster4Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster4.Left = recLevel3Monster4.Left + 20
        ElseIf lvl3Monster4Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster4.Left = recLevel3Monster4.Left - 20
        End If

        ' stuff for monster 5
        If recLevel3Monster5.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster5Direction = False
        ElseIf recLevel3Monster5.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster5Direction = True
        End If

        If lvl3Monster5Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster5.Left = recLevel3Monster5.Left + 20
        ElseIf lvl3Monster5Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster5.Left = recLevel3Monster5.Left - 20
        End If

        ' stuff for monster 6
        If recLevel3Monster6.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster6Direction = False
        ElseIf recLevel3Monster6.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster6Direction = True
        End If

        If lvl3Monster6Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster6.Left = recLevel3Monster6.Left + 20
        ElseIf lvl3Monster6Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster6.Left = recLevel3Monster6.Left - 20
        End If

        ' stuff for monster 7 
        If recLevel3Monster7.Left <= 0 Then
            'if the monster passes the border on the left..tt
            lvl3Monster7Direction = False
        ElseIf recLevel3Monster7.Left > 580 Then
            'if the monster passes the border on the right..tt
            lvl3Monster7Direction = True
        End If

        If lvl3Monster7Direction = False Then
            'adds 20 to the position of the monster..tt
            recLevel3Monster7.Left = recLevel3Monster7.Left + 20
        ElseIf lvl3Monster7Direction = True Then
            'subtracts 20 to the position of the monster..tt
            recLevel3Monster7.Left = recLevel3Monster7.Left - 20
        End If
    End Sub

    Private Sub tmrCollisionChecker3_Tick(sender As Object, e As EventArgs) Handles tmrCollisionChecker3.Tick
        'if the frog collides with the shape and position of the 1st monster..tt
        If recFrog.Left <= recLevel3Monster.Left + 60 And recFrog.Left >= recLevel3Monster.Left - 40 Then
            If recFrog.Top <= recLevel3Monster.Top + 20 And recFrog.Top >= recLevel3Monster.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 2nd monster..tt
        If recFrog.Left <= recLevel3Monster2.Left + 60 And recFrog.Left >= recLevel3Monster2.Left - 40 Then
            If recFrog.Top <= recLevel3Monster2.Top + 20 And recFrog.Top >= recLevel3Monster2.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 3rd monster..tt
        If recFrog.Left <= recLevel3Monster3.Left + 60 And recFrog.Left >= recLevel3Monster3.Left - 40 Then
            If recFrog.Top <= recLevel3Monster3.Top + 20 And recFrog.Top >= recLevel3Monster3.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 4th monster..tt
        If recFrog.Left <= recLevel3Monster4.Left + 60 And recFrog.Left >= recLevel3Monster4.Left - 40 Then
            If recFrog.Top <= recLevel3Monster4.Top + 20 And recFrog.Top >= recLevel3Monster4.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 5th monster..tt
        If recFrog.Left <= recLevel3Monster5.Left + 60 And recFrog.Left >= recLevel3Monster5.Left - 40 Then
            If recFrog.Top <= recLevel3Monster5.Top + 20 And recFrog.Top >= recLevel3Monster5.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 6th monster..tt
        If recFrog.Left <= recLevel3Monster6.Left + 60 And recFrog.Left >= recLevel3Monster6.Left - 40 Then
            If recFrog.Top <= recLevel3Monster6.Top + 20 And recFrog.Top >= recLevel3Monster6.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If

        'if the frog collides with the shape and position of the 7th monster..tt
        If recFrog.Left <= recLevel3Monster7.Left + 60 And recFrog.Left >= recLevel3Monster7.Left - 40 Then
            If recFrog.Top <= recLevel3Monster7.Top + 20 And recFrog.Top >= recLevel3Monster7.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 1st lava pit..tt
        If recFrog.Left <= recLava.Left + 60 And recFrog.Left >= recLava.Left - 40 Then
            If recFrog.Top <= recLava.Top + 120 And recFrog.Top >= recLava.Top - 22 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 2nd lava pit..tt
        If recFrog.Left <= recLava2.Left + 60 And recFrog.Left >= recLava2.Left - 40 Then
            If recFrog.Top <= recLava2.Top + 120 And recFrog.Top >= recLava2.Top - 22 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 3rd lava pit..tt
        If recFrog.Left <= recLava3.Left + 60 And recFrog.Left >= recLava3.Left - 40 Then
            If recFrog.Top <= recLava3.Top + 120 And recFrog.Top >= recLava3.Top - 22 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 4th lava pit..tt
        If recFrog.Left <= recLava4.Left + 60 And recFrog.Left >= recLava4.Left - 40 Then
            If recFrog.Top <= recLava4.Top + 120 And recFrog.Top >= recLava4.Top - 22 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 5th lava pit..tt
        If recFrog.Left <= recLava5.Left + 60 And recFrog.Left >= recLava5.Left - 40 Then
            If recFrog.Top <= recLava5.Top + 120 And recFrog.Top >= recLava5.Top - 22 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 6tht lava pit..tt
        If recFrog.Left <= recLava6.Left + 330 And recFrog.Left >= recLava6.Left - 90 Then
            If recFrog.Top <= recLava6.Top + 15 And recFrog.Top >= recLava6.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 7th lava pit..tt
        If recFrog.Left <= recLava7.Left + 330 And recFrog.Left >= recLava7.Left - 20 Then
            If recFrog.Top <= recLava7.Top + 15 And recFrog.Top >= recLava7.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 8th lava pit..tt
        If recFrog.Left <= recLava8.Left + 310 And recFrog.Left >= recLava8.Left - 90 Then
            If recFrog.Top <= recLava8.Top + 15 And recFrog.Top >= recLava8.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 9th lava pit..tt
        If recFrog.Left <= recLava9.Left + 330 And recFrog.Left >= recLava9.Left - 20 Then
            If recFrog.Top <= recLava9.Top + 15 And recFrog.Top >= recLava9.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 10th lava pit..tt
        If recFrog.Left <= recLava10.Left + 420 And recFrog.Left >= recLava10.Left - 90 Then
            If recFrog.Top <= recLava10.Top + 15 And recFrog.Top >= recLava10.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 11th lava pit..tt
        If recFrog.Left <= recLava11.Left + 330 And recFrog.Left >= recLava11.Left - 20 Then
            If recFrog.Top <= recLava11.Top + 15 And recFrog.Top >= recLava11.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 12th lava pit..tt
        If recFrog.Left <= recLava12.Left + 330 And recFrog.Left >= recLava12.Left - 20 Then
            If recFrog.Top <= recLava12.Top + 15 And recFrog.Top >= recLava12.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 13th lava pit..tt
        If recFrog.Left <= recLava13.Left + 300 And recFrog.Left >= recLava13.Left - 90 Then
            If recFrog.Top <= recLava13.Top + 15 And recFrog.Top >= recLava13.Top - 15 Then
                'subtracts a life from the lives counter..tt
                lives3 = lives3 - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If



        'this condition will happen when the frog shape has passed to the other side of the screen..tt
        If recFrog.Top <= 30 Then
            'adds 1 to the frogs crossed variable..tt
            frogsCrossed3 = frogsCrossed3 + 1
            'assigsn the frogs crossed variable to the label numbe frogs crossed text..tt
            lblNumberFrogsCrossed.Text = frogsCrossed3
            'repositions the frog at the start of the level..tt
            recFrog.Location = New Point(296, 555)
            'if the total number of frogs crossed is equal to 3..tt
            If frogsCrossed3 = 3 Then
                'hides the level 1 form..tt
                Me.Hide()
                'goes into the level 1 to level 2 transition form..tt
                frmWinScreen.Show()
            End If
        End If

        'if the user's lives become 0 it will go into this condition..tt
        If lives3 = 0 Then
            'hides the level 3 form..tt
            Me.Hide()
            'opens the game over form..tt
            frmGameOver.Show()
        End If

        'following line assigns the lives label the value of lives variable..tt
        lblLives3.Text = lives3


    End Sub

    Private Sub tmrCountdown3_Tick(sender As Object, e As EventArgs) Handles tmrCountdown3.Tick
        'subs 1 every second to the counter variable..tt
        counter3 = counter3 - 1
        'sets the timer label text as the counter variable..tt
        lblTimer3.Text = counter3
        'every second it subtracts 10 from the score variable..tt
        score3 = score3 - 10
        'assigns the score variable to the label score text..tt
        lblScore3.Text = score3
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'user clicks on this and it hides the level 3 form and goes into the form exit..tt
        Me.Hide()
        frmExit.Show()
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'user clicks on this and it hides the level 3 form and goes into the form main..tt
        Me.Hide()
        frmMain.Show()
    End Sub
End Class