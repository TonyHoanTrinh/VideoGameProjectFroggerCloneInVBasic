<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExit
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
        Me.lblExit = New System.Windows.Forms.Label()
        Me.cmdYes = New System.Windows.Forms.Button()
        Me.cmdNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Black
        Me.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.White
        Me.lblExit.Location = New System.Drawing.Point(173, 156)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(438, 35)
        Me.lblExit.TabIndex = 2
        Me.lblExit.Text = "Are you sure you want to exit?"
        '
        'cmdYes
        '
        Me.cmdYes.BackColor = System.Drawing.Color.White
        Me.cmdYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYes.Location = New System.Drawing.Point(80, 271)
        Me.cmdYes.Name = "cmdYes"
        Me.cmdYes.Size = New System.Drawing.Size(228, 56)
        Me.cmdYes.TabIndex = 3
        Me.cmdYes.Text = "Yes"
        Me.cmdYes.UseVisualStyleBackColor = False
        '
        'cmdNo
        '
        Me.cmdNo.BackColor = System.Drawing.Color.White
        Me.cmdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNo.Location = New System.Drawing.Point(435, 271)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(228, 56)
        Me.cmdNo.TabIndex = 4
        Me.cmdNo.Text = "No"
        Me.cmdNo.UseVisualStyleBackColor = False
        '
        'frmExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(770, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdNo)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.lblExit)
        Me.Name = "frmExit"
        Me.Text = "Exit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents cmdYes As System.Windows.Forms.Button
    Friend WithEvents cmdNo As System.Windows.Forms.Button
End Class
