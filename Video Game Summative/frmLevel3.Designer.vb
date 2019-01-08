<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel3
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
        Me.grpTimer = New System.Windows.Forms.GroupBox()
        Me.lblTimer3 = New System.Windows.Forms.Label()
        Me.grpLives = New System.Windows.Forms.GroupBox()
        Me.lblLives3 = New System.Windows.Forms.Label()
        Me.grpScore = New System.Windows.Forms.GroupBox()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.recFrog = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.recLevel3Monster7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLevel3Monster = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLava = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.grpFrogsCrossed = New System.Windows.Forms.GroupBox()
        Me.lblNumberFrogsCrossed = New System.Windows.Forms.Label()
        Me.tmrForMonsters = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCollisionChecker3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdown3 = New System.Windows.Forms.Timer(Me.components)
        Me.grpName3 = New System.Windows.Forms.GroupBox()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.mnuLevel3 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpTimer.SuspendLayout()
        Me.grpLives.SuspendLayout()
        Me.grpScore.SuspendLayout()
        Me.grpFrogsCrossed.SuspendLayout()
        Me.grpName3.SuspendLayout()
        Me.mnuLevel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTimer
        '
        Me.grpTimer.Controls.Add(Me.lblTimer3)
        Me.grpTimer.ForeColor = System.Drawing.Color.Black
        Me.grpTimer.Location = New System.Drawing.Point(710, 345)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(91, 72)
        Me.grpTimer.TabIndex = 7
        Me.grpTimer.TabStop = False
        Me.grpTimer.Text = "Time Left"
        '
        'lblTimer3
        '
        Me.lblTimer3.AutoSize = True
        Me.lblTimer3.Location = New System.Drawing.Point(20, 36)
        Me.lblTimer3.Name = "lblTimer3"
        Me.lblTimer3.Size = New System.Drawing.Size(39, 13)
        Me.lblTimer3.TabIndex = 0
        Me.lblTimer3.Text = "Label1"
        '
        'grpLives
        '
        Me.grpLives.Controls.Add(Me.lblLives3)
        Me.grpLives.ForeColor = System.Drawing.Color.Black
        Me.grpLives.Location = New System.Drawing.Point(710, 222)
        Me.grpLives.Name = "grpLives"
        Me.grpLives.Size = New System.Drawing.Size(91, 75)
        Me.grpLives.TabIndex = 8
        Me.grpLives.TabStop = False
        Me.grpLives.Text = "Lives"
        '
        'lblLives3
        '
        Me.lblLives3.AutoSize = True
        Me.lblLives3.Location = New System.Drawing.Point(20, 29)
        Me.lblLives3.Name = "lblLives3"
        Me.lblLives3.Size = New System.Drawing.Size(39, 13)
        Me.lblLives3.TabIndex = 13
        Me.lblLives3.Text = "Label1"
        '
        'grpScore
        '
        Me.grpScore.BackColor = System.Drawing.Color.Transparent
        Me.grpScore.Controls.Add(Me.lblScore3)
        Me.grpScore.ForeColor = System.Drawing.Color.Black
        Me.grpScore.Location = New System.Drawing.Point(710, 29)
        Me.grpScore.Name = "grpScore"
        Me.grpScore.Size = New System.Drawing.Size(91, 75)
        Me.grpScore.TabIndex = 9
        Me.grpScore.TabStop = False
        Me.grpScore.Text = "Score"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Location = New System.Drawing.Point(20, 35)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(39, 13)
        Me.lblScore3.TabIndex = 12
        Me.lblScore3.Text = "Label1"
        '
        'recFrog
        '
        Me.recFrog.BackColor = System.Drawing.Color.Lime
        Me.recFrog.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFrog.Location = New System.Drawing.Point(357, 555)
        Me.recFrog.Name = "recFrog"
        Me.recFrog.Size = New System.Drawing.Size(33, 35)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recLevel3Monster7, Me.recLevel3Monster6, Me.recLevel3Monster5, Me.recLevel3Monster4, Me.recLevel3Monster3, Me.recLevel3Monster2, Me.recLevel3Monster, Me.recLava13, Me.recLava12, Me.recLava10, Me.recLava11, Me.recLava9, Me.recLava8, Me.recLava7, Me.recLava6, Me.recLava5, Me.recLava4, Me.recLava3, Me.recLava2, Me.recLava, Me.recFrog})
        Me.ShapeContainer2.Size = New System.Drawing.Size(824, 591)
        Me.ShapeContainer2.TabIndex = 10
        Me.ShapeContainer2.TabStop = False
        '
        'recLevel3Monster7
        '
        Me.recLevel3Monster7.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster7.Location = New System.Drawing.Point(602, 24)
        Me.recLevel3Monster7.Name = "recLevel3Monster7"
        Me.recLevel3Monster7.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster6
        '
        Me.recLevel3Monster6.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster6.Location = New System.Drawing.Point(11, 75)
        Me.recLevel3Monster6.Name = "recLevel3Monster6"
        Me.recLevel3Monster6.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster5
        '
        Me.recLevel3Monster5.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster5.Location = New System.Drawing.Point(597, 158)
        Me.recLevel3Monster5.Name = "recLevel3Monster5"
        Me.recLevel3Monster5.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster4
        '
        Me.recLevel3Monster4.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster4.Location = New System.Drawing.Point(12, 239)
        Me.recLevel3Monster4.Name = "recLevel3Monster4"
        Me.recLevel3Monster4.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster3
        '
        Me.recLevel3Monster3.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster3.Location = New System.Drawing.Point(597, 281)
        Me.recLevel3Monster3.Name = "recLevel3Monster3"
        Me.recLevel3Monster3.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster2
        '
        Me.recLevel3Monster2.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster2.Location = New System.Drawing.Point(13, 341)
        Me.recLevel3Monster2.Name = "recLevel3Monster2"
        Me.recLevel3Monster2.Size = New System.Drawing.Size(75, 35)
        '
        'recLevel3Monster
        '
        Me.recLevel3Monster.BackColor = System.Drawing.Color.DarkRed
        Me.recLevel3Monster.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLevel3Monster.Location = New System.Drawing.Point(596, 419)
        Me.recLevel3Monster.Name = "recLevel3Monster"
        Me.recLevel3Monster.Size = New System.Drawing.Size(75, 35)
        '
        'recLava13
        '
        Me.recLava13.BackColor = System.Drawing.Color.Red
        Me.recLava13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava13.Location = New System.Drawing.Point(1, 36)
        Me.recLava13.Name = "recLava13"
        Me.recLava13.Size = New System.Drawing.Size(287, 29)
        '
        'recLava12
        '
        Me.recLava12.BackColor = System.Drawing.Color.Red
        Me.recLava12.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava12.Location = New System.Drawing.Point(390, 30)
        Me.recLava12.Name = "recLava12"
        Me.recLava12.Size = New System.Drawing.Size(288, 29)
        '
        'recLava10
        '
        Me.recLava10.BackColor = System.Drawing.Color.Red
        Me.recLava10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava10.Location = New System.Drawing.Point(2, 120)
        Me.recLava10.Name = "recLava10"
        Me.recLava10.Size = New System.Drawing.Size(457, 29)
        '
        'recLava11
        '
        Me.recLava11.BackColor = System.Drawing.Color.Red
        Me.recLava11.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava11.Location = New System.Drawing.Point(534, 120)
        Me.recLava11.Name = "recLava11"
        Me.recLava11.Size = New System.Drawing.Size(139, 29)
        '
        'recLava9
        '
        Me.recLava9.BackColor = System.Drawing.Color.Red
        Me.recLava9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava9.Location = New System.Drawing.Point(392, 203)
        Me.recLava9.Name = "recLava9"
        Me.recLava9.Size = New System.Drawing.Size(280, 29)
        '
        'recLava8
        '
        Me.recLava8.BackColor = System.Drawing.Color.Red
        Me.recLava8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava8.Location = New System.Drawing.Point(0, 205)
        Me.recLava8.Name = "recLava8"
        Me.recLava8.Size = New System.Drawing.Size(297, 29)
        '
        'recLava7
        '
        Me.recLava7.BackColor = System.Drawing.Color.Red
        Me.recLava7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava7.Location = New System.Drawing.Point(429, 286)
        Me.recLava7.Name = "recLava7"
        Me.recLava7.Size = New System.Drawing.Size(247, 29)
        '
        'recLava6
        '
        Me.recLava6.BackColor = System.Drawing.Color.Red
        Me.recLava6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava6.Location = New System.Drawing.Point(0, 284)
        Me.recLava6.Name = "recLava6"
        Me.recLava6.Size = New System.Drawing.Size(333, 29)
        '
        'recLava5
        '
        Me.recLava5.BackColor = System.Drawing.Color.Red
        Me.recLava5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava5.Location = New System.Drawing.Point(601, 373)
        Me.recLava5.Name = "recLava5"
        Me.recLava5.Size = New System.Drawing.Size(74, 136)
        '
        'recLava4
        '
        Me.recLava4.BackColor = System.Drawing.Color.Red
        Me.recLava4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava4.Location = New System.Drawing.Point(449, 370)
        Me.recLava4.Name = "recLava4"
        Me.recLava4.Size = New System.Drawing.Size(74, 136)
        '
        'recLava3
        '
        Me.recLava3.BackColor = System.Drawing.Color.Red
        Me.recLava3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava3.Location = New System.Drawing.Point(301, 370)
        Me.recLava3.Name = "recLava3"
        Me.recLava3.Size = New System.Drawing.Size(74, 138)
        '
        'recLava2
        '
        Me.recLava2.BackColor = System.Drawing.Color.Red
        Me.recLava2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava2.Location = New System.Drawing.Point(155, 369)
        Me.recLava2.Name = "recLava2"
        Me.recLava2.Size = New System.Drawing.Size(74, 141)
        '
        'recLava
        '
        Me.recLava.BackColor = System.Drawing.Color.Red
        Me.recLava.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLava.Location = New System.Drawing.Point(9, 368)
        Me.recLava.Name = "recLava"
        Me.recLava.Size = New System.Drawing.Size(74, 144)
        '
        'grpFrogsCrossed
        '
        Me.grpFrogsCrossed.Controls.Add(Me.lblNumberFrogsCrossed)
        Me.grpFrogsCrossed.ForeColor = System.Drawing.Color.Black
        Me.grpFrogsCrossed.Location = New System.Drawing.Point(710, 457)
        Me.grpFrogsCrossed.Name = "grpFrogsCrossed"
        Me.grpFrogsCrossed.Size = New System.Drawing.Size(91, 72)
        Me.grpFrogsCrossed.TabIndex = 11
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
        'tmrForMonsters
        '
        Me.tmrForMonsters.Enabled = True
        '
        'tmrCollisionChecker3
        '
        Me.tmrCollisionChecker3.Enabled = True
        Me.tmrCollisionChecker3.Interval = 1
        '
        'tmrCountdown3
        '
        Me.tmrCountdown3.Enabled = True
        Me.tmrCountdown3.Interval = 1000
        '
        'grpName3
        '
        Me.grpName3.BackColor = System.Drawing.Color.Transparent
        Me.grpName3.Controls.Add(Me.lblName3)
        Me.grpName3.ForeColor = System.Drawing.Color.Black
        Me.grpName3.Location = New System.Drawing.Point(710, 119)
        Me.grpName3.Name = "grpName3"
        Me.grpName3.Size = New System.Drawing.Size(91, 75)
        Me.grpName3.TabIndex = 12
        Me.grpName3.TabStop = False
        Me.grpName3.Text = "Name"
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Location = New System.Drawing.Point(17, 31)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(31, 13)
        Me.lblName3.TabIndex = 1
        Me.lblName3.Text = "1800"
        '
        'mnuLevel3
        '
        Me.mnuLevel3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.mnuLevel3.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevel3.Name = "mnuLevel3"
        Me.mnuLevel3.Size = New System.Drawing.Size(824, 24)
        Me.mnuLevel3.TabIndex = 13
        Me.mnuLevel3.Text = "MenuStrip1"
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
        'frmLevel3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(824, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpName3)
        Me.Controls.Add(Me.grpFrogsCrossed)
        Me.Controls.Add(Me.grpScore)
        Me.Controls.Add(Me.grpLives)
        Me.Controls.Add(Me.grpTimer)
        Me.Controls.Add(Me.mnuLevel3)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.MainMenuStrip = Me.mnuLevel3
        Me.Name = "frmLevel3"
        Me.Text = "Level 3 : Trial by Fire"
        Me.grpTimer.ResumeLayout(False)
        Me.grpTimer.PerformLayout()
        Me.grpLives.ResumeLayout(False)
        Me.grpLives.PerformLayout()
        Me.grpScore.ResumeLayout(False)
        Me.grpScore.PerformLayout()
        Me.grpFrogsCrossed.ResumeLayout(False)
        Me.grpFrogsCrossed.PerformLayout()
        Me.grpName3.ResumeLayout(False)
        Me.grpName3.PerformLayout()
        Me.mnuLevel3.ResumeLayout(False)
        Me.mnuLevel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTimer As System.Windows.Forms.GroupBox
    Friend WithEvents grpLives As System.Windows.Forms.GroupBox
    Friend WithEvents grpScore As System.Windows.Forms.GroupBox
    Friend WithEvents recFrog As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents recLava13 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava12 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava11 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLava As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents grpFrogsCrossed As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberFrogsCrossed As System.Windows.Forms.Label
    Friend WithEvents recLevel3Monster7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLevel3Monster As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tmrForMonsters As System.Windows.Forms.Timer
    Friend WithEvents tmrCollisionChecker3 As System.Windows.Forms.Timer
    Friend WithEvents tmrCountdown3 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer3 As System.Windows.Forms.Label
    Friend WithEvents lblScore3 As System.Windows.Forms.Label
    Friend WithEvents grpName3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName3 As System.Windows.Forms.Label
    Friend WithEvents lblLives3 As System.Windows.Forms.Label
    Friend WithEvents mnuLevel3 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
