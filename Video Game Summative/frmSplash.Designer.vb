<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.lblCoinInsert = New System.Windows.Forms.Label()
        Me.picCoin = New System.Windows.Forms.PictureBox()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCoinInsert
        '
        Me.lblCoinInsert.AutoSize = True
        Me.lblCoinInsert.BackColor = System.Drawing.Color.Black
        Me.lblCoinInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCoinInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinInsert.ForeColor = System.Drawing.Color.White
        Me.lblCoinInsert.Location = New System.Drawing.Point(150, 124)
        Me.lblCoinInsert.Name = "lblCoinInsert"
        Me.lblCoinInsert.Size = New System.Drawing.Size(410, 39)
        Me.lblCoinInsert.TabIndex = 0
        Me.lblCoinInsert.Text = "Press Enter to Insert Coin"
        '
        'picCoin
        '
        Me.picCoin.Image = CType(resources.GetObject("picCoin.Image"), System.Drawing.Image)
        Me.picCoin.Location = New System.Drawing.Point(313, 237)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(92, 92)
        Me.picCoin.TabIndex = 1
        Me.picCoin.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(726, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCoin)
        Me.Controls.Add(Me.lblCoinInsert)
        Me.Name = "frmSplash"
        Me.Text = "Frogger Dodger Splashscreen"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCoinInsert As System.Windows.Forms.Label
    Friend WithEvents picCoin As System.Windows.Forms.PictureBox
End Class
