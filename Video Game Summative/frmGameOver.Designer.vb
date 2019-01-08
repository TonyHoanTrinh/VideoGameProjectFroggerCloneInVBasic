<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.cmdReturnToMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Black
        Me.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.White
        Me.lblGameOver.Location = New System.Drawing.Point(98, 175)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(202, 39)
        Me.lblGameOver.TabIndex = 2
        Me.lblGameOver.Text = "Game Over!"
        '
        'cmdReturnToMenu
        '
        Me.cmdReturnToMenu.BackColor = System.Drawing.Color.White
        Me.cmdReturnToMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturnToMenu.Location = New System.Drawing.Point(98, 312)
        Me.cmdReturnToMenu.Name = "cmdReturnToMenu"
        Me.cmdReturnToMenu.Size = New System.Drawing.Size(286, 56)
        Me.cmdReturnToMenu.TabIndex = 3
        Me.cmdReturnToMenu.Text = "Return to Menu"
        Me.cmdReturnToMenu.UseVisualStyleBackColor = False
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdReturnToMenu)
        Me.Controls.Add(Me.lblGameOver)
        Me.Name = "frmGameOver"
        Me.Text = "Game Over"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents cmdReturnToMenu As System.Windows.Forms.Button
End Class
