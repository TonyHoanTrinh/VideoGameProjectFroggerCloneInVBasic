<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.txtNameEnter = New System.Windows.Forms.TextBox()
        Me.lblAsksForUsername = New System.Windows.Forms.Label()
        Me.cmdEnterYourName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNameEnter
        '
        Me.txtNameEnter.Location = New System.Drawing.Point(262, 174)
        Me.txtNameEnter.Name = "txtNameEnter"
        Me.txtNameEnter.Size = New System.Drawing.Size(182, 20)
        Me.txtNameEnter.TabIndex = 1
        '
        'lblAsksForUsername
        '
        Me.lblAsksForUsername.AutoSize = True
        Me.lblAsksForUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsksForUsername.ForeColor = System.Drawing.Color.White
        Me.lblAsksForUsername.Location = New System.Drawing.Point(178, 90)
        Me.lblAsksForUsername.Name = "lblAsksForUsername"
        Me.lblAsksForUsername.Size = New System.Drawing.Size(334, 25)
        Me.lblAsksForUsername.TabIndex = 1
        Me.lblAsksForUsername.Text = "Please Enter Your Name to Begin"
        '
        'cmdEnterYourName
        '
        Me.cmdEnterYourName.BackColor = System.Drawing.Color.White
        Me.cmdEnterYourName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnterYourName.Location = New System.Drawing.Point(183, 250)
        Me.cmdEnterYourName.Name = "cmdEnterYourName"
        Me.cmdEnterYourName.Size = New System.Drawing.Size(329, 55)
        Me.cmdEnterYourName.TabIndex = 2
        Me.cmdEnterYourName.Text = "Enter Your Name"
        Me.cmdEnterYourName.UseVisualStyleBackColor = False
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(705, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdEnterYourName)
        Me.Controls.Add(Me.lblAsksForUsername)
        Me.Controls.Add(Me.txtNameEnter)
        Me.Name = "frmName"
        Me.Text = "Name Please!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNameEnter As System.Windows.Forms.TextBox
    Friend WithEvents lblAsksForUsername As System.Windows.Forms.Label
    Friend WithEvents cmdEnterYourName As System.Windows.Forms.Button
End Class
