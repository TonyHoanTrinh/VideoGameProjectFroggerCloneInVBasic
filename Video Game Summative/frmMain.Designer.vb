<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblGame = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdInstructions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.BackColor = System.Drawing.Color.Black
        Me.lblGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.White
        Me.lblGame.Location = New System.Drawing.Point(371, 69)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(260, 39)
        Me.lblGame.TabIndex = 1
        Me.lblGame.Text = "Frogger Dodger"
        '
        'cmdStart
        '
        Me.cmdStart.BackColor = System.Drawing.Color.White
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(66, 163)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(228, 56)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "Start Game"
        Me.cmdStart.UseVisualStyleBackColor = False
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.White
        Me.cmdAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Location = New System.Drawing.Point(456, 252)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(228, 56)
        Me.cmdAbout.TabIndex = 3
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.White
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(456, 421)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(228, 56)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdInstructions
        '
        Me.cmdInstructions.BackColor = System.Drawing.Color.White
        Me.cmdInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInstructions.Location = New System.Drawing.Point(66, 329)
        Me.cmdInstructions.Name = "cmdInstructions"
        Me.cmdInstructions.Size = New System.Drawing.Size(228, 56)
        Me.cmdInstructions.TabIndex = 4
        Me.cmdInstructions.Text = "Instructions"
        Me.cmdInstructions.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(751, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdInstructions)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblGame)
        Me.Name = "frmMain"
        Me.Text = "Frogger Dodger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdInstructions As System.Windows.Forms.Button

End Class
