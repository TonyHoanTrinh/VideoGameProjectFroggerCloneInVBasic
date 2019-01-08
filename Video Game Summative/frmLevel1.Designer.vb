<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.recLilyPad3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLilyPad2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLog3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLog2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recCar5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recCar4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recCar3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recCar2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLilyPad = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recLog = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recWater = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recCar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recFrog = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.recShapeStart = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tmrForCars = New System.Windows.Forms.Timer(Me.components)
        Me.tmrForLogs = New System.Windows.Forms.Timer(Me.components)
        Me.tmrForLilyPads = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCollisionChecker = New System.Windows.Forms.Timer(Me.components)
        Me.grpScore = New System.Windows.Forms.GroupBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.grpTimer = New System.Windows.Forms.GroupBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.grpLives = New System.Windows.Forms.GroupBox()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.grpFrogsCrossed = New System.Windows.Forms.GroupBox()
        Me.lblNumberFrogsCrossed = New System.Windows.Forms.Label()
        Me.grpName1 = New System.Windows.Forms.GroupBox()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.tmrWaterChecker = New System.Windows.Forms.Timer(Me.components)
        Me.mnuLevel1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpScore.SuspendLayout()
        Me.grpTimer.SuspendLayout()
        Me.grpLives.SuspendLayout()
        Me.grpFrogsCrossed.SuspendLayout()
        Me.grpName1.SuspendLayout()
        Me.mnuLevel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.recLilyPad3, Me.recLilyPad2, Me.recLog3, Me.recLog2, Me.recCar5, Me.recCar4, Me.recCar3, Me.recCar2, Me.recLilyPad, Me.recLog, Me.recWater, Me.recCar, Me.recFrog, Me.RectangleShape1, Me.recShapeStart})
        Me.ShapeContainer1.Size = New System.Drawing.Size(824, 591)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'recLilyPad3
        '
        Me.recLilyPad3.BackColor = System.Drawing.Color.Lime
        Me.recLilyPad3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLilyPad3.Location = New System.Drawing.Point(593, 71)
        Me.recLilyPad3.Name = "recLilyPad3"
        Me.recLilyPad3.Size = New System.Drawing.Size(75, 34)
        '
        'recLilyPad2
        '
        Me.recLilyPad2.BackColor = System.Drawing.Color.Lime
        Me.recLilyPad2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLilyPad2.Location = New System.Drawing.Point(72, 151)
        Me.recLilyPad2.Name = "recLilyPad2"
        Me.recLilyPad2.Size = New System.Drawing.Size(75, 34)
        '
        'recLog3
        '
        Me.recLog3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recLog3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLog3.Location = New System.Drawing.Point(15, 19)
        Me.recLog3.Name = "recLog3"
        Me.recLog3.Size = New System.Drawing.Size(160, 34)
        '
        'recLog2
        '
        Me.recLog2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recLog2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLog2.Location = New System.Drawing.Point(519, 109)
        Me.recLog2.Name = "recLog2"
        Me.recLog2.Size = New System.Drawing.Size(160, 34)
        '
        'recCar5
        '
        Me.recCar5.BackColor = System.Drawing.Color.Gray
        Me.recCar5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCar5.Location = New System.Drawing.Point(308, 325)
        Me.recCar5.Name = "recCar5"
        Me.recCar5.Size = New System.Drawing.Size(75, 35)
        '
        'recCar4
        '
        Me.recCar4.BackColor = System.Drawing.Color.Gray
        Me.recCar4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCar4.Location = New System.Drawing.Point(18, 371)
        Me.recCar4.Name = "recCar4"
        Me.recCar4.Size = New System.Drawing.Size(74, 35)
        '
        'recCar3
        '
        Me.recCar3.BackColor = System.Drawing.Color.Gray
        Me.recCar3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCar3.Location = New System.Drawing.Point(421, 418)
        Me.recCar3.Name = "recCar3"
        Me.recCar3.Size = New System.Drawing.Size(75, 35)
        '
        'recCar2
        '
        Me.recCar2.BackColor = System.Drawing.Color.Gray
        Me.recCar2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCar2.Location = New System.Drawing.Point(175, 469)
        Me.recCar2.Name = "recCar2"
        Me.recCar2.Size = New System.Drawing.Size(75, 35)
        '
        'recLilyPad
        '
        Me.recLilyPad.BackColor = System.Drawing.Color.Lime
        Me.recLilyPad.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLilyPad.Location = New System.Drawing.Point(483, 223)
        Me.recLilyPad.Name = "recLilyPad"
        Me.recLilyPad.Size = New System.Drawing.Size(75, 34)
        '
        'recLog
        '
        Me.recLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recLog.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recLog.Location = New System.Drawing.Point(9, 190)
        Me.recLog.Name = "recLog"
        Me.recLog.Size = New System.Drawing.Size(160, 34)
        '
        'recWater
        '
        Me.recWater.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recWater.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recWater.Location = New System.Drawing.Point(-1, 0)
        Me.recWater.Name = "recWater"
        Me.recWater.Size = New System.Drawing.Size(693, 257)
        '
        'recCar
        '
        Me.recCar.BackColor = System.Drawing.Color.Gray
        Me.recCar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recCar.Location = New System.Drawing.Point(586, 514)
        Me.recCar.Name = "recCar"
        Me.recCar.Size = New System.Drawing.Size(75, 35)
        '
        'recFrog
        '
        Me.recFrog.BackColor = System.Drawing.Color.Lime
        Me.recFrog.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recFrog.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recFrog.Location = New System.Drawing.Point(346, 557)
        Me.recFrog.Name = "recFrog"
        Me.recFrog.Size = New System.Drawing.Size(33, 35)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 257)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(691, 62)
        '
        'recShapeStart
        '
        Me.recShapeStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.recShapeStart.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.recShapeStart.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.recShapeStart.Location = New System.Drawing.Point(0, 556)
        Me.recShapeStart.Name = "recShapeStart"
        Me.recShapeStart.Size = New System.Drawing.Size(691, 35)
        '
        'tmrForCars
        '
        Me.tmrForCars.Enabled = True
        Me.tmrForCars.Interval = 150
        '
        'tmrForLogs
        '
        Me.tmrForLogs.Enabled = True
        Me.tmrForLogs.Interval = 500
        '
        'tmrForLilyPads
        '
        Me.tmrForLilyPads.Enabled = True
        Me.tmrForLilyPads.Interval = 500
        '
        'tmrCollisionChecker
        '
        Me.tmrCollisionChecker.Enabled = True
        Me.tmrCollisionChecker.Interval = 1
        '
        'grpScore
        '
        Me.grpScore.BackColor = System.Drawing.Color.Transparent
        Me.grpScore.Controls.Add(Me.lblScore)
        Me.grpScore.ForeColor = System.Drawing.Color.White
        Me.grpScore.Location = New System.Drawing.Point(711, 19)
        Me.grpScore.Name = "grpScore"
        Me.grpScore.Size = New System.Drawing.Size(91, 75)
        Me.grpScore.TabIndex = 3
        Me.grpScore.TabStop = False
        Me.grpScore.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(30, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Score"
        '
        'grpTimer
        '
        Me.grpTimer.Controls.Add(Me.lblTimer)
        Me.grpTimer.ForeColor = System.Drawing.Color.Fuchsia
        Me.grpTimer.Location = New System.Drawing.Point(711, 321)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(91, 72)
        Me.grpTimer.TabIndex = 0
        Me.grpTimer.TabStop = False
        Me.grpTimer.Text = "Time Left"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(30, 32)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(25, 13)
        Me.lblTimer.TabIndex = 5
        Me.lblTimer.Text = "180"
        '
        'grpLives
        '
        Me.grpLives.Controls.Add(Me.lblLives)
        Me.grpLives.ForeColor = System.Drawing.Color.Red
        Me.grpLives.Location = New System.Drawing.Point(711, 223)
        Me.grpLives.Name = "grpLives"
        Me.grpLives.Size = New System.Drawing.Size(91, 75)
        Me.grpLives.TabIndex = 4
        Me.grpLives.TabStop = False
        Me.grpLives.Text = "Lives"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Location = New System.Drawing.Point(30, 37)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(13, 13)
        Me.lblLives.TabIndex = 6
        Me.lblLives.Text = "3"
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Enabled = True
        Me.tmrCountDown.Interval = 1000
        '
        'grpFrogsCrossed
        '
        Me.grpFrogsCrossed.Controls.Add(Me.lblNumberFrogsCrossed)
        Me.grpFrogsCrossed.ForeColor = System.Drawing.Color.Yellow
        Me.grpFrogsCrossed.Location = New System.Drawing.Point(711, 433)
        Me.grpFrogsCrossed.Name = "grpFrogsCrossed"
        Me.grpFrogsCrossed.Size = New System.Drawing.Size(91, 72)
        Me.grpFrogsCrossed.TabIndex = 5
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
        'grpName1
        '
        Me.grpName1.BackColor = System.Drawing.Color.Transparent
        Me.grpName1.Controls.Add(Me.lblName1)
        Me.grpName1.ForeColor = System.Drawing.Color.Cyan
        Me.grpName1.Location = New System.Drawing.Point(711, 122)
        Me.grpName1.Name = "grpName1"
        Me.grpName1.Size = New System.Drawing.Size(91, 75)
        Me.grpName1.TabIndex = 10
        Me.grpName1.TabStop = False
        Me.grpName1.Text = "Name"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Location = New System.Drawing.Point(17, 31)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(35, 13)
        Me.lblName1.TabIndex = 1
        Me.lblName1.Text = "Name"
        '
        'tmrWaterChecker
        '
        Me.tmrWaterChecker.Enabled = True
        Me.tmrWaterChecker.Interval = 750
        '
        'mnuLevel1
        '
        Me.mnuLevel1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.BackToMainToolStripMenuItem})
        Me.mnuLevel1.Location = New System.Drawing.Point(0, 0)
        Me.mnuLevel1.Name = "mnuLevel1"
        Me.mnuLevel1.Size = New System.Drawing.Size(824, 24)
        Me.mnuLevel1.TabIndex = 11
        Me.mnuLevel1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BackToMainToolStripMenuItem
        '
        Me.BackToMainToolStripMenuItem.Name = "BackToMainToolStripMenuItem"
        Me.BackToMainToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.BackToMainToolStripMenuItem.Text = "Back To Main Menu"
        '
        'frmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(824, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpName1)
        Me.Controls.Add(Me.grpFrogsCrossed)
        Me.Controls.Add(Me.grpTimer)
        Me.Controls.Add(Me.grpLives)
        Me.Controls.Add(Me.grpScore)
        Me.Controls.Add(Me.mnuLevel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.mnuLevel1
        Me.Name = "frmLevel1"
        Me.Text = "Level 1 : Kind Of Blue"
        Me.grpScore.ResumeLayout(False)
        Me.grpScore.PerformLayout()
        Me.grpTimer.ResumeLayout(False)
        Me.grpTimer.PerformLayout()
        Me.grpLives.ResumeLayout(False)
        Me.grpLives.PerformLayout()
        Me.grpFrogsCrossed.ResumeLayout(False)
        Me.grpFrogsCrossed.PerformLayout()
        Me.grpName1.ResumeLayout(False)
        Me.grpName1.PerformLayout()
        Me.mnuLevel1.ResumeLayout(False)
        Me.mnuLevel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents recFrog As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recShapeStart As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLilyPad As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLog As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recWater As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recCar As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tmrForCars As System.Windows.Forms.Timer
    Friend WithEvents tmrForLogs As System.Windows.Forms.Timer
    Friend WithEvents recCar5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recCar4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recCar3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recCar2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLilyPad3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLilyPad2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLog3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents recLog2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tmrForLilyPads As System.Windows.Forms.Timer
    Friend WithEvents tmrCollisionChecker As System.Windows.Forms.Timer
    Friend WithEvents grpScore As System.Windows.Forms.GroupBox
    Friend WithEvents grpTimer As System.Windows.Forms.GroupBox
    Friend WithEvents grpLives As System.Windows.Forms.GroupBox
    Friend WithEvents tmrCountDown As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents grpFrogsCrossed As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberFrogsCrossed As System.Windows.Forms.Label
    Friend WithEvents grpName1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblName1 As System.Windows.Forms.Label
    Friend WithEvents tmrWaterChecker As System.Windows.Forms.Timer
    Friend WithEvents mnuLevel1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
