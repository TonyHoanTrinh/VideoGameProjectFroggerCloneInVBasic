<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlevel2toLevel3
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
        Me.lblScoreLvl2toLvl3 = New System.Windows.Forms.Label()
        Me.lblTransition2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.ForeColor = System.Drawing.Color.White
        Me.lblGreeting.Location = New System.Drawing.Point(207, 96)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(219, 26)
        Me.lblGreeting.TabIndex = 2
        Me.lblGreeting.Text = "Congratulations you completed the 2nd level." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With a score of "
        '
        'lblScoreLvl2toLvl3
        '
        Me.lblScoreLvl2toLvl3.AutoSize = True
        Me.lblScoreLvl2toLvl3.ForeColor = System.Drawing.Color.White
        Me.lblScoreLvl2toLvl3.Location = New System.Drawing.Point(290, 188)
        Me.lblScoreLvl2toLvl3.Name = "lblScoreLvl2toLvl3"
        Me.lblScoreLvl2toLvl3.Size = New System.Drawing.Size(39, 13)
        Me.lblScoreLvl2toLvl3.TabIndex = 3
        Me.lblScoreLvl2toLvl3.Text = "Label1"
        '
        'lblTransition2
        '
        Me.lblTransition2.AutoSize = True
        Me.lblTransition2.ForeColor = System.Drawing.Color.White
        Me.lblTransition2.Location = New System.Drawing.Point(207, 246)
        Me.lblTransition2.Name = "lblTransition2"
        Me.lblTransition2.Size = New System.Drawing.Size(202, 13)
        Me.lblTransition2.TabIndex = 4
        Me.lblTransition2.Text = "Press Enter to Continue to the Next Level"
        '
        'frmlevel2toLevel3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(619, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTransition2)
        Me.Controls.Add(Me.lblScoreLvl2toLvl3)
        Me.Controls.Add(Me.lblGreeting)
        Me.Name = "frmlevel2toLevel3"
        Me.Text = "Level 2 to Level 3 Transition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents lblScoreLvl2toLvl3 As System.Windows.Forms.Label
    Friend WithEvents lblTransition2 As System.Windows.Forms.Label
End Class
