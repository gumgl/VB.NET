<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PICyear = New System.Windows.Forms.PictureBox()
        Me.PICname = New System.Windows.Forms.PictureBox()
        Me.PICtitle = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PICyear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICtitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'PICyear
        '
        Me.PICyear.Image = Global.CarProject.My.Resources.Resources.splashscreen_2011
        Me.PICyear.Location = New System.Drawing.Point(8, 463)
        Me.PICyear.Name = "PICyear"
        Me.PICyear.Size = New System.Drawing.Size(94, 40)
        Me.PICyear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICyear.TabIndex = 3
        Me.PICyear.TabStop = False
        '
        'PICname
        '
        Me.PICname.Image = Global.CarProject.My.Resources.Resources.splashscreen_by
        Me.PICname.Location = New System.Drawing.Point(398, 98)
        Me.PICname.Name = "PICname"
        Me.PICname.Size = New System.Drawing.Size(497, 48)
        Me.PICname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICname.TabIndex = 2
        Me.PICname.TabStop = False
        '
        'PICtitle
        '
        Me.PICtitle.Image = Global.CarProject.My.Resources.Resources.splashscreen_title
        Me.PICtitle.Location = New System.Drawing.Point(51, 38)
        Me.PICtitle.Name = "PICtitle"
        Me.PICtitle.Size = New System.Drawing.Size(330, 68)
        Me.PICtitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICtitle.TabIndex = 1
        Me.PICtitle.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarProject.My.Resources.Resources.splashscreen_background
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(900, 507)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.PICyear)
        Me.Controls.Add(Me.PICname)
        Me.Controls.Add(Me.PICtitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PICyear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICtitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PICtitle As System.Windows.Forms.PictureBox
    Friend WithEvents PICname As System.Windows.Forms.PictureBox
    Friend WithEvents PICyear As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
