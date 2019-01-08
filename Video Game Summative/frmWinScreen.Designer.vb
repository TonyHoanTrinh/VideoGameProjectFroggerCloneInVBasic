<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinScreen
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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.cmdReturnToMainFromWin = New System.Windows.Forms.Button()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AccessibleDescription = ""
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.ForeColor = System.Drawing.Color.White
        Me.lblGreeting.Location = New System.Drawing.Point(192, 163)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(209, 75)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Congratulations!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You beat the game. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With a total score of "
        '
        'cmdReturnToMainFromWin
        '
        Me.cmdReturnToMainFromWin.BackColor = System.Drawing.Color.White
        Me.cmdReturnToMainFromWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturnToMainFromWin.Location = New System.Drawing.Point(197, 307)
        Me.cmdReturnToMainFromWin.Name = "cmdReturnToMainFromWin"
        Me.cmdReturnToMainFromWin.Size = New System.Drawing.Size(207, 72)
        Me.cmdReturnToMainFromWin.TabIndex = 1
        Me.cmdReturnToMainFromWin.Text = "Return To Main Screen"
        Me.cmdReturnToMainFromWin.UseVisualStyleBackColor = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.ForeColor = System.Drawing.Color.White
        Me.lblFinalScore.Location = New System.Drawing.Point(252, 261)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(77, 25)
        Me.lblFinalScore.TabIndex = 2
        Me.lblFinalScore.Text = "Label1"
        '
        'frmWinScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(607, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.cmdReturnToMainFromWin)
        Me.Controls.Add(Me.lblGreeting)
        Me.Name = "frmWinScreen"
        Me.Text = "Congratulations!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents cmdReturnToMainFromWin As System.Windows.Forms.Button
    Friend WithEvents lblFinalScore As System.Windows.Forms.Label
End Class
