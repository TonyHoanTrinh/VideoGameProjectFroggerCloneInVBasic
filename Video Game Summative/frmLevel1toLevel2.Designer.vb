<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1toLevel2
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
        Me.lblScoreLvl1toLvl2 = New System.Windows.Forms.Label()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.lblTransition2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblScoreLvl1toLvl2
        '
        Me.lblScoreLvl1toLvl2.AutoSize = True
        Me.lblScoreLvl1toLvl2.ForeColor = System.Drawing.Color.White
        Me.lblScoreLvl1toLvl2.Location = New System.Drawing.Point(262, 154)
        Me.lblScoreLvl1toLvl2.Name = "lblScoreLvl1toLvl2"
        Me.lblScoreLvl1toLvl2.Size = New System.Drawing.Size(39, 13)
        Me.lblScoreLvl1toLvl2.TabIndex = 0
        Me.lblScoreLvl1toLvl2.Text = "Label1"
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.ForeColor = System.Drawing.Color.White
        Me.lblGreeting.Location = New System.Drawing.Point(180, 98)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(215, 26)
        Me.lblGreeting.TabIndex = 1
        Me.lblGreeting.Text = "Congratulations you completed the 1st level." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With a score of "
        '
        'lblTransition2
        '
        Me.lblTransition2.AutoSize = True
        Me.lblTransition2.BackColor = System.Drawing.Color.Black
        Me.lblTransition2.ForeColor = System.Drawing.Color.White
        Me.lblTransition2.Location = New System.Drawing.Point(180, 205)
        Me.lblTransition2.Name = "lblTransition2"
        Me.lblTransition2.Size = New System.Drawing.Size(202, 13)
        Me.lblTransition2.TabIndex = 2
        Me.lblTransition2.Text = "Press Enter to Continue to the Next Level"
        '
        'frmLevel1toLevel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(619, 389)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTransition2)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.lblScoreLvl1toLvl2)
        Me.Name = "frmLevel1toLevel2"
        Me.Text = "Level 1 to Level 2 Transition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScoreLvl1toLvl2 As System.Windows.Forms.Label
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents lblTransition2 As System.Windows.Forms.Label
End Class
