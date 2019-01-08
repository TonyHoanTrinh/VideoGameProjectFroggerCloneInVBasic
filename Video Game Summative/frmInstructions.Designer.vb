<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.lblGame = New System.Windows.Forms.Label()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.lblTipesAndAdvice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGame
        '
        Me.lblGame.AutoSize = True
        Me.lblGame.BackColor = System.Drawing.Color.Black
        Me.lblGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame.ForeColor = System.Drawing.Color.White
        Me.lblGame.Location = New System.Drawing.Point(26, 41)
        Me.lblGame.Name = "lblGame"
        Me.lblGame.Size = New System.Drawing.Size(422, 194)
        Me.lblGame.TabIndex = 2
        Me.lblGame.Text = resources.GetString("lblGame.Text")
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.White
        Me.cmdReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.Location = New System.Drawing.Point(309, 405)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(401, 56)
        Me.cmdReturn.TabIndex = 3
        Me.cmdReturn.Text = "Return to Main Menu"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'lblTipesAndAdvice
        '
        Me.lblTipesAndAdvice.AutoSize = True
        Me.lblTipesAndAdvice.BackColor = System.Drawing.Color.Black
        Me.lblTipesAndAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipesAndAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipesAndAdvice.ForeColor = System.Drawing.Color.White
        Me.lblTipesAndAdvice.Location = New System.Drawing.Point(473, 41)
        Me.lblTipesAndAdvice.Name = "lblTipesAndAdvice"
        Me.lblTipesAndAdvice.Size = New System.Drawing.Size(514, 290)
        Me.lblTipesAndAdvice.TabIndex = 4
        Me.lblTipesAndAdvice.Text = resources.GetString("lblTipesAndAdvice.Text")
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1022, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTipesAndAdvice)
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.lblGame)
        Me.Name = "frmInstructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGame As System.Windows.Forms.Label
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents lblTipesAndAdvice As System.Windows.Forms.Label
End Class
