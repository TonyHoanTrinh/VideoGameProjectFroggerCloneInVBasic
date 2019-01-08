<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblExit = New System.Windows.Forms.Label()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Black
        Me.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.White
        Me.lblExit.Location = New System.Drawing.Point(106, 28)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(475, 338)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = resources.GetString("lblExit.Text")
        '
        'cmdReturn
        '
        Me.cmdReturn.BackColor = System.Drawing.Color.White
        Me.cmdReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.Location = New System.Drawing.Point(128, 403)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(401, 56)
        Me.cmdReturn.TabIndex = 4
        Me.cmdReturn.Text = "Return to Main Menu"
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(709, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdReturn)
        Me.Controls.Add(Me.lblExit)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
End Class
