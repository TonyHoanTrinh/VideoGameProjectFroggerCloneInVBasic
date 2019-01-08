Option Explicit On
Public Class frmLevel1
    'counter variable is used for the tmrCountdown..tt
    Dim counter As Integer = 180
    'following boolean variables are for the switch in direction of their movement in the level..tt
    Dim carDirection As Boolean = False
    Dim carDirection2 As Boolean = False
    Dim carDirection3 As Boolean = False
    Dim carDirection4 As Boolean = False
    Dim carDirection5 As Boolean = False
    Dim logDirection As Boolean = False
    Dim logDirection2 As Boolean = False
    Dim logDirection3 As Boolean = False
    Dim lilyDirection As Boolean = False
    Dim lilyDirection2 As Boolean = False
    Dim lilyDirection3 As Boolean = False
    'boolean variable to check if the user is in water or not..tt
    Dim waterSafe As Boolean = True
    Dim frogDirection As Boolean = False
    'public variable score to hold the score for the 1st level and for it be passed down in later forms..tt
    Public score As Integer = 1800

    'variable to hold the current position of the frog rectangle..tt
    Dim Loc As Point
    'lives variable to hold the user's lives at the beginning of the game..tt
    Dim lives As Integer = 3
    'frogsCrossed variable to hold the times the frog has crossed to the other side..tt
    Dim frogsCrossed As Integer = 0

    'sub to call in the background music for lvl 1..tt
    Private Sub PlayBackgroundSoundFileLevel1()
        My.Computer.Audio.Play("C:\Users\Anthony\Desktop\Music For Game\Anamanaguchi - Jetpack Blues.wav", AudioPlayMode.BackgroundLoop)
        'H:\Profile\Desktop\Music For Game\
    End Sub

    'sub for the movement of the frog shape and the collision of the frog to the sides of the form..tt
    Private Sub frmLevel1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub tmrForCars_Tick(sender As Object, e As EventArgs) Handles tmrForCars.Tick
        ' stuff for car 1..tt
        If recCar.Left <= 0 Then
            'if the car passes the border on the left..tt
            carDirection = False
        ElseIf recCar.Left > 580 Then
            'if the car passes the border on the right..tt
            carDirection = True
        End If

        If carDirection = False Then
            'adds 40 to the position of the car..tt
            recCar.Left = recCar.Left + 40
        ElseIf carDirection = True Then
            'subtracts 40 to the position of the car..tt
            recCar.Left = recCar.Left - 40
        End If

        ' stuff for car 2..tt
        If recCar2.Left <= 0 Then
            'if the car passes the border on the left..tt
            carDirection2 = False
        ElseIf recCar2.Left > 580 Then
            'if the car passes the border on the right..tt
            carDirection2 = True
        End If

        If carDirection2 = False Then
            'adds 40 to the position of the car..tt
            recCar2.Left = recCar2.Left + 40
        ElseIf carDirection2 = True Then
            'subtracts 40 to the position of the car..tt
            recCar2.Left = recCar2.Left - 40
        End If

        ' stuff for car 3..tt
        If recCar3.Left <= 0 Then
            'if the car passes the border on the left..tt
            carDirection3 = False
        ElseIf recCar3.Left > 580 Then
            'if the car passes the border on the right..tt
            carDirection3 = True
        End If

        If carDirection3 = False Then
            'adds 40 to the position of the car..tt
            recCar3.Left = recCar3.Left + 40
        ElseIf carDirection3 = True Then
            'subtracts 40 to the position of the car..tt
            recCar3.Left = recCar3.Left - 40
        End If

        ' stuff for car 4..tt
        If recCar4.Left <= 0 Then
            'if the car passes the border on the left..tt
            carDirection4 = False
        ElseIf recCar4.Left > 580 Then
            'if the car passes the border on the right..tt
            carDirection4 = True
        End If

        If carDirection4 = False Then
            'adds 40 to the position of the car..tt
            recCar4.Left = recCar4.Left + 40
        ElseIf carDirection4 = True Then
            'subtracts 40 to the position of the car..tt
            recCar4.Left = recCar4.Left - 40
        End If



        ' stuff for car 5..tt
        If recCar5.Left <= 0 Then
            'if the car passes the border on the left..tt
            carDirection5 = False
        ElseIf recCar5.Left > 580 Then
            'if the car passes the border on the right..tt
            carDirection5 = True
        End If

        If carDirection5 = False Then
            'adds 40 to the position of the car..tt
            recCar5.Left = recCar5.Left + 40
        ElseIf carDirection5 = True Then
            'subtracts 40 to the position of the car..tt
            recCar5.Left = recCar5.Left - 40
        End If


    End Sub

    Private Sub tmrForLogs_Tick(sender As Object, e As EventArgs) Handles tmrForLogs.Tick
        ' stuff for log 1 
        If recLog.Left <= 0 Then
            'if the log passes the border on the left..tt
            logDirection = False
        ElseIf recLog.Left > 490 Then
            'if the car passes the border on the right..tt
            logDirection = True
        End If

        If logDirection = False Then
            'adds 40 to the position of the log..tt
            recLog.Left = recLog.Left + 40
        ElseIf logDirection = True Then
            'subtracts 40 to the position of the log..tt
            recLog.Left = recLog.Left - 40
        End If

        ' stuff for log 2
        If recLog2.Left <= 0 Then
            'if the log passes the border on the left..tt
            logDirection2 = False
        ElseIf recLog2.Left > 490 Then
            'if the car passes the border on the right..tt
            logDirection2 = True
        End If

        If logDirection2 = False Then
            'adds 40 to the position of the log..tt
            recLog2.Left = recLog2.Left + 40
        ElseIf logDirection2 = True Then
            'subtracts 40 to the position of the log..tt
            recLog2.Left = recLog2.Left - 40
        End If

        ' stuff for log 3
        If recLog3.Left <= 0 Then
            'if the log passes the border on the left..tt
            logDirection3 = False
        ElseIf recLog3.Left > 490 Then
            'if the car passes the border on the right..tt
            logDirection3 = True
        End If


        If logDirection3 = False Then
            'adds 40 to the position of the log..tt
            recLog3.Left = recLog3.Left + 40
        ElseIf logDirection3 = True Then
            'subtracts 40 to the position of the log..tt
            recLog3.Left = recLog3.Left - 40
        End If
    End Sub

    Private Sub tmrForLilyPads_Tick(sender As Object, e As EventArgs) Handles tmrForLilyPads.Tick
        ' stuff for lilypad 1 
        If recLilyPad.Left <= 0 Then
            'if the lilypad passes the border on the left..tt
            lilyDirection = False
        ElseIf recLilyPad.Left > 580 Then
            'if the lilypad passes the border on the right..tt
            lilyDirection = True
        End If

        If lilyDirection = False Then
            'adds 40 to the position of the log..tt
            recLilyPad.Left = recLilyPad.Left + 40
        ElseIf lilyDirection = True Then
            'subtracts 40 to the position of the log..tt
            recLilyPad.Left = recLilyPad.Left - 40
        End If

        ' stuff for lilypad 2 
        If recLilyPad2.Left <= 0 Then
            'if the lilypad passes the border on the left..tt
            lilyDirection2 = False
        ElseIf recLilyPad2.Left > 580 Then
            'if the lilypad passes the border on the right..tt
            lilyDirection2 = True
        End If

        If lilyDirection2 = False Then
            'adds 40 to the position of the log..tt
            recLilyPad2.Left = recLilyPad2.Left + 40
        ElseIf lilyDirection2 = True Then
            'subtracts 40 to the position of the log..tt
            recLilyPad2.Left = recLilyPad2.Left - 40
        End If

        ' stuff for lilypad 3
        If recLilyPad3.Left <= 0 Then
            'if the lilypad passes the border on the left..tt
            lilyDirection3 = False
        ElseIf recLilyPad3.Left > 580 Then
            'if the lilypad passes the border on the right..tt
            lilyDirection3 = True
        End If

        If lilyDirection3 = False Then
            'adds 40 to the position of the log..tt
            recLilyPad3.Left = recLilyPad3.Left + 40
        ElseIf lilyDirection3 = True Then
            'subtracts 40 to the position of the log..tt
            recLilyPad3.Left = recLilyPad3.Left - 40
        End If
    End Sub

    Private Sub tmrCollisionChecker_Tick(sender As Object, e As EventArgs) Handles tmrCollisionChecker.Tick
        'if the frog collides with the shape and position of the 1st car..tt
        If recFrog.Left <= recCar.Left + 60 And recFrog.Left >= recCar.Left - 40 Then
            If recFrog.Top <= recCar.Top + 20 And recFrog.Top >= recCar.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives = lives - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)

            End If
        End If
        'if the frog collides with the shape and position of the 2nd car..tt

        If recFrog.Left <= recCar2.Left + 60 And recFrog.Left >= recCar2.Left - 40 Then
            If recFrog.Top <= recCar2.Top + 20 And recFrog.Top >= recCar2.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives = lives - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 3rd car..tt
        If recFrog.Left <= recCar3.Left + 60 And recFrog.Left >= recCar3.Left - 40 Then
            If recFrog.Top <= recCar3.Top + 20 And recFrog.Top >= recCar3.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives = lives - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 4th car..tt
        If recFrog.Left <= recCar4.Left + 60 And recFrog.Left >= recCar4.Left - 40 Then
            If recFrog.Top <= recCar4.Top + 20 And recFrog.Top >= recCar4.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives = lives - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'if the frog collides with the shape and position of the 5th car..tt
        If recFrog.Left <= recCar5.Left + 60 And recFrog.Left >= recCar5.Left - 40 Then
            If recFrog.Top <= recCar5.Top + 20 And recFrog.Top >= recCar5.Top - 20 Then
                'subtracts a life from the lives counter..tt
                lives = lives - 1
                'repositions the frog at the start of the level..tt
                recFrog.Location = New Point(296, 555)
            End If
        End If

        'this condition will happen when the frog shape has passed to the other side of the screen..tt
        If recFrog.Top <= 30 Then
            'adds 1 to the frogs crossed variable..tt
            frogsCrossed = frogsCrossed + 1
            'assigsn the frogs crossed variable to the label numbe frogs crossed text..tt
            lblNumberFrogsCrossed.Text = frogsCrossed
            'repositions the frog at the start of the level..tt
            recFrog.Location = New Point(296, 555)
            'if the total number of frogs crossed is equal to 3..tt
            If frogsCrossed = 3 Then
                'hides the level 1 form..tt
                Me.Hide()
                'goes into the level 1 to level 2 transition form..tt
                frmLevel1toLevel2.Show()
            End If
        End If

        'if the user's lives become 0 it will go into this condition..tt
        If lives = 0 Then
            'hides the level 1 form..tt
            Me.Hide()
            'opens the game over form..tt
            frmGameOver.Show()
        End If

        'following line assigns the lives label the value of lives variable..tt
        lblLives.Text = lives

        'this just makes sure that while the frog is under the water section that it is safe still..tt
        If recFrog.Location = New Point(296, 555) Then
            waterSafe = True
        End If
    End Sub


    Private Sub frmLevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when the form loads it sets it so that the frog shape is above all the other shapes in the form..tt
        ShapeContainer1.Shapes.SetChildIndex(recFrog, 0)
        ShapeContainer1.Refresh()
        'calls in the background lvl 1 music sub to play the music..tt
        Call PlayBackgroundSoundFileLevel1()
        'assigns the name label in the form the name that the user entered on the main form..tt
        lblName1.Text = frmName.nameOfUser
    End Sub

    Private Sub tmrCountDown_Tick(sender As Object, e As EventArgs) Handles tmrCountDown.Tick
        'subs 1 every second to the counter variable..tt
        counter = counter - 1
        'sets the timer label text as the counter variable..tt
        lblTimer.Text = counter
        'every second it subtracts 10 from the score variable..tt
        score = score - 10
        'assigns the score variable to the label score text..tt
        lblScore.Text = score
    End Sub

    Private Sub tmrWaterChecker_Tick(sender As Object, e As EventArgs) Handles tmrWaterChecker.Tick
        ' first if statement checks if the rec frog is within the water section..tt
        If recFrog.Top <= 240 Then
            'checks if the frog is within the boundary of the game as well..tt
            If recFrog.Left <= 694 And recFrog.Left >= 0 Then
                'if the frog is on the log 1 platform..tt
                If recFrog.Left <= recLog.Left + 150 And recFrog.Left >= recLog.Left Then
                    If recFrog.Top <= recLog.Top + 20 And recFrog.Top >= recLog.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                    'if the frog is on the lilypad platform..tt
                ElseIf recFrog.Left <= recLilyPad.Left + 60 And recFrog.Left >= recLilyPad.Left - 40 Then
                    If recFrog.Top <= recLilyPad.Top + 20 And recFrog.Top >= recLilyPad.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                    'if the frog is on the lilypad 2 platform..tt
                ElseIf recFrog.Left <= recLilyPad2.Left + 60 And recFrog.Left >= recLilyPad2.Left - 40 Then
                    If recFrog.Top <= recLilyPad2.Top + 20 And recFrog.Top >= recLilyPad2.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                    'if the frog is on the lilypad 3 platform..tt
                ElseIf recFrog.Left <= recLilyPad3.Left + 60 And recFrog.Left >= recLilyPad3.Left - 40 Then
                    If recFrog.Top <= recLilyPad3.Top + 20 And recFrog.Top >= recLilyPad3.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                    'if the frog is on the log 2 platform..tt
                ElseIf recFrog.Left <= recLog2.Left + 150 And recFrog.Left >= recLog2.Left Then
                    If recFrog.Top <= recLog2.Top + 20 And recFrog.Top >= recLog2.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                    'if the frog is on the log 3 platform..tt
                ElseIf recFrog.Left <= recLog3.Left + 150 And recFrog.Left >= recLog3.Left Then
                    If recFrog.Top <= recLog3.Top + 20 And recFrog.Top >= recLog3.Top - 20 Then
                        'sets the water safe variable as true..tt
                        waterSafe = True
                    End If
                Else
                    'if the frog is not on a platform and is in the water section it makes the boolean variable false..tt
                    waterSafe = False
                    End If

            End If
        End If

        'if the boolean variable water safe is false meaning they are in the water section and not on a safe platform..tt
        If waterSafe = False Then
            'subtracts a live from the lives counter 
            lives = lives - 1
            'sends the frog shape back to it's starting location 
            recFrog.Location = New Point(296, 555)
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'user clicks on this and it hides the level 1 form and goes into the form exit..tt
        Me.Hide()
        frmExit.Show()
    End Sub

    Private Sub BackToMainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainToolStripMenuItem.Click
        'user clicks on this and it hides the level 1 form and goes into the form main..tt
        Me.Hide()
        frmMain.Show()
    End Sub
End Class