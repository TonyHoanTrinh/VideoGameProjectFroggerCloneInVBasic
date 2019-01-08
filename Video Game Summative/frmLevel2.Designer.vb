<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpScore = New System.Windows.Forms.GroupBox()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.grpLives = New System.Windows.Forms.GroupBox()
        Me.lblLives2 = New System.Windows.Forms.Label()
        Me.grpTimer = New System.Windows.Forms.GroupBox()
        Me.lblTimer2 = New System.Windows.Forms.Label()
        Me.recShapeStart = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.recMonster9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recMonster = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFrog = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tmrForVerticalMonsters = New System.Windows.Forms.Timer(Me.components)
        Me.tmrForHorizontalMonsters = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCollisionChecker2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdown2 = New System.Windows.Forms.Timer(Me.components)
        Me.grpFrogsCrossed = New System.Windows.Forms.GroupBox()
        Me.lblNumberFrogsCrossed = New System.Windows.Forms.Label()
        Me.grpName2 = New System.Windows.Forms.GroupBox()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.mnuLevel2 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpScore.SuspendLayout()
        Me.grpLives.SuspendLayout()
        Me.grpTimer.SuspendLayout()
        Me.grpFrogsCrossed.SuspendLayout()
        Me.grpName2.SuspendLayout()
        Me.mnuLevel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpScore
        '
        Me.grpScore.BackColor = System.Drawing.Color.Transparent
        Me.grpScore.Controls.Add(Me.lblScore2)
        Me.grpScore.ForeColor = System.Drawing.Color.Black
        Me.grpScore.Location = New System.Drawing.Point(712, 46)
        Me.grpScore.Name = "grpScore"
        Me.grpScore.Size = New System.Drawing.Size(91, 75)
        Me.grpScore.TabIndex = 4
        Me.grpScore.TabStop = False
        Me.grpScore.Text = "Score"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Location = New System.Drawing.Point(17, 31)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(31, 13)
        Me.lblScore2.TabIndex = 1
        Me.lblScore2.Text = "1800"
        '
        'grpLives
        '
        Me.grpLives.Controls.Add(Me.lblLives2)
        Me.grpLives.ForeColor = System.Drawing.Color.Red
        Me.grpLives.Location = New System.Drawing.Point(712, 250)
        Me.grpLives.Name = "grpLives"
        Me.grpLives.Size = New System.Drawing.Size(91, 75)
        Me.grpLives.TabIndex = 5
        Me.grpLives.TabStop = False
        Me.grpLives.Text = "Lives"
        '
        'lblLives2
        '
        Me.lblLives2.AutoSize = True
        Me.lblLives2.Location = New System.Drawing.Point(17, 29)
        Me.lblLives2.Name = "lblLives2"
        Me.lblLives2.Size = New System.Drawing.Size(13, 13)
        Me.lblLives2.TabIndex = 0
        Me.lblLives2.Text = "3"
        '
        'grpTimer
        '
        Me.grpTimer.Controls.Add(Me.lblTimer2)
        Me.grpTimer.ForeColor = System.Drawing.Color.Fuchsia
        Me.grpTimer.Location = New System.Drawing.Point(712, 356)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(91, 72)
        Me.grpTimer.TabIndex = 6
        Me.grpTimer.TabStop = False
        Me.grpTimer.Text = "Time Left"
        '
        'lblTimer2
        '
        Me.lblTimer2.AutoSize = True
        Me.lblTimer2.Location = New System.Drawing.Point(17, 27)
        Me.lblTimer2.Name = "lblTimer2"
        Me.lblTimer2.Size = New System.Drawing.Size(25, 13)
        Me.lblTimer2.TabIndex = 0
        Me.lblTimer2.Text = "180"
        '
        'recShapeStart
        '
        Me.recShapeStart.BackColor = System.Drawing.Color.Transparent
        Me.recShapeStart.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recShapeStart.BorderColor = System.Drawing.Color.Black
        Me.recShapeStart.Location = New System.Drawing.Point(0, 553)
        Me.recShapeStart.Name = "recShapeStart"
        Me.recShapeStart.Size = New System.Drawing.Size(691, 36)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recMonster9, Me.recMonster8, Me.recMonster7, Me.recMonster6, Me.recMonster5, Me.recMonster4, Me.recMonster3, Me.recMonster2, Me.recMonster, Me.recFrog, Me.recShapeStart})
        Me.ShapeContainer1.Size = New System.Drawing.Size(824, 591)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'recMonster9
        '
        Me.recMonster9.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster9.Location = New System.Drawing.Point(52, 14)
        Me.recMonster9.Name = "recMonster9"
        Me.recMonster9.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster8
        '
        Me.recMonster8.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster8.Location = New System.Drawing.Point(584, 8)
        Me.recMonster8.Name = "recMonster8"
        Me.recMonster8.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster7
        '
        Me.recMonster7.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster7.Location = New System.Drawing.Point(214, 17)
        Me.recMonster7.Name = "recMonster7"
        Me.recMonster7.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster6
        '
        Me.recMonster6.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster6.Location = New System.Drawing.Point(439, 8)
        Me.recMonster6.Name = "recMonster6"
        Me.recMonster6.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster5
        '
        Me.recMonster5.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster5.Location = New System.Drawing.Point(32, 147)
        Me.recMonster5.Name = "recMonster5"
        Me.recMonster5.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster4
        '
        Me.recMonster4.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster4.Location = New System.Drawing.Point(616, 225)
        Me.recMonster4.Name = "recMonster4"
        Me.recMonster4.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster3
        '
        Me.recMonster3.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster3.Location = New System.Drawing.Point(35, 300)
        Me.recMonster3.Name = "recMonster3"
        Me.recMonster3.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster2
        '
        Me.recMonster2.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster2.Location = New System.Drawing.Point(615, 386)
        Me.recMonster2.Name = "recMonster2"
        Me.recMonster2.Size = New System.Drawing.Size(75, 35)
        '
        'recMonster
        '
        Me.recMonster.BackColor = System.Drawing.Color.DarkRed
        Me.recMonster.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recMonster.Location = New System.Drawing.Point(36, 447)
        Me.recMonster.Name = "recMonster"
        Me.recMonster.Size = New System.Drawing.Size(75, 35)
        '
        'recFrog
        '
        Me.recFrog.BackColor = System.Drawing.Color.Lime
        Me.recFrog.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFrog.Location = New System.Drawing.Point(328, 554)
        Me.recFrog.Name = "recFrog"
        Me.recFrog.Size = New System.Drawing.Size(33, 35)
        '
        'tmrForVerticalMonsters
        '
        Me.tmrForVerticalMonsters.Enabled = True
        '
        'tmrForHorizontalMonsters
        '
        Me.tmrForHorizontalMonsters.Enabled = True
        '
        'tmrCollisionChecker2
        '
        Me.tmrCollisionChecker2.Enabled = True
        '
        'tmrCountdown2
        '
        Me.tmrCountdown2.Enabled = True
        Me.tmrCountdown2.Interval = 1000
        '
        'grpFrogsCrossed
        '
        Me.grpFrogsCrossed.Controls.Add(Me.lblNumberFrogsCrossed)
        Me.grpFrogsCrossed.ForeColor = System.Drawing.Color.Lime
        Me.grpFrogsCrossed.Location = New System.Drawing.Point(712, 469)
        Me.grpFrogsCrossed.Name = "grpFrogsCrossed"
        Me.grpFrogsCrossed.Size = New System.Drawing.Size(91, 72)
        Me.grpFrogsCrossed.TabIndex = 8
        Me.grpFrogsCrossed.TabStop = False
        Me.grpFrogsCrossed.Text = "Frogs Crossed"
        '
        'lblNumberFrogsCrossed
        '
        Me.lblNumberFrogsCrossed.AutoSize = True
        Me.lblNumberFrogsCrossed.Location = New System.Drawing.Point(30, 32)
        Me.lblNumberFrogsCrossed.Name = "lblNumberFrogsCrossed"
        Me.lblNumberFrogsCrossed.Size = New System.Drawing.Size(13, 13)
        Me.lblNumberFrogsCrossed.TabIndex = 5
        Me.lblNumberFrogsCrossed.Text = "0"
        '
        'grpName2
        '
        Me.grpName2.BackColor = System.Drawing.Color.Transparent
        Me.grpName2.Controls.Add(Me.lblName2)
        Me.grpName2.ForeColor = System.Drawing.Color.Cyan
        Me.grpName2.Location = New System.Drawing.Point(712, 147)
        Me.grpName2.Name = "grpName2"
        Me.grpName2.Size = New System.Drawing.Size(91, 75)
        Me.grpName2.TabIndex = 9
        Me.grpName2.TabStop = False
        Me.grpName2.Text = "Name"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Location = New System.Drawing.Point(17, 31)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(31, 13)
        Me.lblName2.TabIndex = 1
        Me.lblName2.Text = "1800"
        '
        'mnuLevel2
        '
        Me.mnuLevel2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.mnuLevel2.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevel2.Name = "mnuLevel2"
        Me.mnuLevel2.Size = New System.Drawing.Size(824, 24)
        Me.mnuLevel2.TabIndex = 10
        Me.mnuLevel2.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back To Main Menu"
        '
        'frmLevel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpName2)
        Me.Controls.Add(Me.grpFrogsCrossed)
        Me.Controls.Add(Me.grpTimer)
        Me.Controls.Add(Me.grpLives)
        Me.Controls.Add(Me.grpScore)
        Me.Controls.Add(Me.mnuLevel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.mnuLevel2
        Me.Name = "frmLevel2"
        Me.Text = "Level 2: The Desert"
        Me.grpScore.ResumeLayout(False)
        Me.grpScore.PerformLayout()
        Me.grpLives.ResumeLayout(False)
        Me.grpLives.PerformLayout()
        Me.grpTimer.ResumeLayout(False)
        Me.grpTimer.PerformLayout()
        Me.grpFrogsCrossed.ResumeLayout(False)
        Me.grpFrogsCrossed.PerformLayout()
        Me.grpName2.ResumeLayout(False)
        Me.grpName2.PerformLayout()
        Me.mnuLevel2.ResumeLayout(False)
        Me.mnuLevel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpScore As System.Windows.Forms.GroupBox
    Friend WithEvents grpLives As System.Windows.Forms.GroupBox
    Friend WithEvents grpTimer As System.Windows.Forms.GroupBox
    Friend WithEvents recShapeStart As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents recFrog As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tmrForVerticalMonsters As System.Windows.Forms.Timer
    Friend WithEvents tmrForHorizontalMonsters As System.Windows.Forms.Timer
    Friend WithEvents tmrCollisionChecker2 As System.Windows.Forms.Timer
    Friend WithEvents tmrCountdown2 As System.Windows.Forms.Timer
    Friend WithEvents grpFrogsCrossed As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberFrogsCrossed As System.Windows.Forms.Label
    Friend WithEvents lblTimer2 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents grpName2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblLives2 As System.Windows.Forms.Label
    Friend WithEvents recMonster9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recMonster8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents mnuLevel2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
