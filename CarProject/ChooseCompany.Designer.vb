<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMChooseCompany
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMChooseCompany))
        Me.LBLcompanyName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLavailable = New System.Windows.Forms.Label()
        Me.MoveCompanies = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSplashAppear = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSplashDisappear = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSplashStay = New System.Windows.Forms.Timer(Me.components)
        Me.PNLtitlebar = New System.Windows.Forms.Panel()
        Me.PICicon = New System.Windows.Forms.PictureBox()
        Me.PICminimize = New System.Windows.Forms.PictureBox()
        Me.LBLtitle = New System.Windows.Forms.Label()
        Me.PICclose = New System.Windows.Forms.PictureBox()
        Me.PICcompany5 = New System.Windows.Forms.PictureBox()
        Me.PICcompany1 = New System.Windows.Forms.PictureBox()
        Me.PICcompany4 = New System.Windows.Forms.PictureBox()
        Me.PICcompany2 = New System.Windows.Forms.PictureBox()
        Me.PICcompany3 = New System.Windows.Forms.PictureBox()
        Me.PICprev = New System.Windows.Forms.PictureBox()
        Me.PICnext = New System.Windows.Forms.PictureBox()
        Me.LBLaverageL = New System.Windows.Forms.Label()
        Me.LBLaverage = New System.Windows.Forms.Label()
        Me.PNLtitlebar.SuspendLayout()
        CType(Me.PICicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICminimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICcompany5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICcompany1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICcompany4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICcompany2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICcompany3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICprev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PICnext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLcompanyName
        '
        Me.LBLcompanyName.Font = New System.Drawing.Font("Segoe UI Light", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLcompanyName.ForeColor = System.Drawing.Color.White
        Me.LBLcompanyName.Location = New System.Drawing.Point(183, 579)
        Me.LBLcompanyName.Name = "LBLcompanyName"
        Me.LBLcompanyName.Size = New System.Drawing.Size(713, 107)
        Me.LBLcompanyName.TabIndex = 1
        Me.LBLcompanyName.Text = "Ferrari"
        Me.LBLcompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(239, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please choose a company (use your keyboard)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLavailable
        '
        Me.LBLavailable.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLavailable.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLavailable.Location = New System.Drawing.Point(12, 695)
        Me.LBLavailable.Name = "LBLavailable"
        Me.LBLavailable.Size = New System.Drawing.Size(737, 28)
        Me.LBLavailable.TabIndex = 7
        Me.LBLavailable.Text = "Available Cars: ..."
        Me.LBLavailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MoveCompanies
        '
        Me.MoveCompanies.Interval = 8
        '
        'TimerSplashStay
        '
        Me.TimerSplashStay.Interval = 3000
        '
        'PNLtitlebar
        '
        Me.PNLtitlebar.BackgroundImage = Global.CarProject.My.Resources.Resources.title_bar
        Me.PNLtitlebar.Controls.Add(Me.PICicon)
        Me.PNLtitlebar.Controls.Add(Me.PICminimize)
        Me.PNLtitlebar.Controls.Add(Me.LBLtitle)
        Me.PNLtitlebar.Controls.Add(Me.PICclose)
        Me.PNLtitlebar.Location = New System.Drawing.Point(0, 0)
        Me.PNLtitlebar.Name = "PNLtitlebar"
        Me.PNLtitlebar.Size = New System.Drawing.Size(1082, 32)
        Me.PNLtitlebar.TabIndex = 28
        '
        'PICicon
        '
        Me.PICicon.BackColor = System.Drawing.Color.Transparent
        Me.PICicon.Image = Global.CarProject.My.Resources.Resources.Ferrari
        Me.PICicon.Location = New System.Drawing.Point(4, 4)
        Me.PICicon.Name = "PICicon"
        Me.PICicon.Size = New System.Drawing.Size(24, 24)
        Me.PICicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PICicon.TabIndex = 14
        Me.PICicon.TabStop = False
        '
        'PICminimize
        '
        Me.PICminimize.BackColor = System.Drawing.Color.Transparent
        Me.PICminimize.Image = Global.CarProject.My.Resources.Resources.minimize
        Me.PICminimize.Location = New System.Drawing.Point(1021, 4)
        Me.PICminimize.Name = "PICminimize"
        Me.PICminimize.Size = New System.Drawing.Size(24, 24)
        Me.PICminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICminimize.TabIndex = 13
        Me.PICminimize.TabStop = False
        '
        'LBLtitle
        '
        Me.LBLtitle.AutoSize = True
        Me.LBLtitle.BackColor = System.Drawing.Color.Transparent
        Me.LBLtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtitle.ForeColor = System.Drawing.Color.White
        Me.LBLtitle.Location = New System.Drawing.Point(30, 5)
        Me.LBLtitle.Name = "LBLtitle"
        Me.LBLtitle.Size = New System.Drawing.Size(93, 21)
        Me.LBLtitle.TabIndex = 11
        Me.LBLtitle.Text = "Car Project"
        '
        'PICclose
        '
        Me.PICclose.BackColor = System.Drawing.Color.Transparent
        Me.PICclose.Image = Global.CarProject.My.Resources.Resources.close
        Me.PICclose.Location = New System.Drawing.Point(1050, 4)
        Me.PICclose.Name = "PICclose"
        Me.PICclose.Size = New System.Drawing.Size(24, 24)
        Me.PICclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICclose.TabIndex = 12
        Me.PICclose.TabStop = False
        '
        'PICcompany5
        '
        Me.PICcompany5.Location = New System.Drawing.Point(1017, 88)
        Me.PICcompany5.Name = "PICcompany5"
        Me.PICcompany5.Size = New System.Drawing.Size(550, 485)
        Me.PICcompany5.TabIndex = 9
        Me.PICcompany5.TabStop = False
        '
        'PICcompany1
        '
        Me.PICcompany1.Location = New System.Drawing.Point(-484, 88)
        Me.PICcompany1.Name = "PICcompany1"
        Me.PICcompany1.Size = New System.Drawing.Size(550, 485)
        Me.PICcompany1.TabIndex = 8
        Me.PICcompany1.TabStop = False
        '
        'PICcompany4
        '
        Me.PICcompany4.Image = Global.CarProject.My.Resources.Resources.Porsche
        Me.PICcompany4.Location = New System.Drawing.Point(958, 88)
        Me.PICcompany4.Name = "PICcompany4"
        Me.PICcompany4.Size = New System.Drawing.Size(550, 485)
        Me.PICcompany4.TabIndex = 6
        Me.PICcompany4.TabStop = False
        '
        'PICcompany2
        '
        Me.PICcompany2.Image = Global.CarProject.My.Resources.Resources.Smart
        Me.PICcompany2.Location = New System.Drawing.Point(-430, 88)
        Me.PICcompany2.Name = "PICcompany2"
        Me.PICcompany2.Size = New System.Drawing.Size(550, 485)
        Me.PICcompany2.TabIndex = 5
        Me.PICcompany2.TabStop = False
        '
        'PICcompany3
        '
        Me.PICcompany3.Image = Global.CarProject.My.Resources.Resources.Ferrari
        Me.PICcompany3.Location = New System.Drawing.Point(264, 88)
        Me.PICcompany3.Name = "PICcompany3"
        Me.PICcompany3.Size = New System.Drawing.Size(550, 485)
        Me.PICcompany3.TabIndex = 0
        Me.PICcompany3.TabStop = False
        '
        'PICprev
        '
        Me.PICprev.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PICprev.Image = Global.CarProject.My.Resources.Resources.prev
        Me.PICprev.Location = New System.Drawing.Point(218, 310)
        Me.PICprev.Name = "PICprev"
        Me.PICprev.Size = New System.Drawing.Size(40, 40)
        Me.PICprev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICprev.TabIndex = 3
        Me.PICprev.TabStop = False
        '
        'PICnext
        '
        Me.PICnext.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PICnext.Image = Global.CarProject.My.Resources.Resources._next
        Me.PICnext.Location = New System.Drawing.Point(820, 310)
        Me.PICnext.Name = "PICnext"
        Me.PICnext.Size = New System.Drawing.Size(40, 40)
        Me.PICnext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICnext.TabIndex = 2
        Me.PICnext.TabStop = False
        '
        'LBLaverageL
        '
        Me.LBLaverageL.AutoSize = True
        Me.LBLaverageL.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLaverageL.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLaverageL.Location = New System.Drawing.Point(817, 695)
        Me.LBLaverageL.Name = "LBLaverageL"
        Me.LBLaverageL.Size = New System.Drawing.Size(135, 28)
        Me.LBLaverageL.TabIndex = 29
        Me.LBLaverageL.Text = "Average Price:"
        Me.LBLaverageL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLaverage
        '
        Me.LBLaverage.Font = New System.Drawing.Font("Miriam Fixed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLaverage.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLaverage.Location = New System.Drawing.Point(948, 697)
        Me.LBLaverage.Name = "LBLaverage"
        Me.LBLaverage.Size = New System.Drawing.Size(118, 28)
        Me.LBLaverage.TabIndex = 30
        Me.LBLaverage.Text = "$152,234"
        Me.LBLaverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMChooseCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1078, 733)
        Me.Controls.Add(Me.LBLaverage)
        Me.Controls.Add(Me.LBLaverageL)
        Me.Controls.Add(Me.PNLtitlebar)
        Me.Controls.Add(Me.PICcompany4)
        Me.Controls.Add(Me.PICcompany2)
        Me.Controls.Add(Me.PICcompany3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PICprev)
        Me.Controls.Add(Me.PICnext)
        Me.Controls.Add(Me.LBLcompanyName)
        Me.Controls.Add(Me.LBLavailable)
        Me.Controls.Add(Me.PICcompany5)
        Me.Controls.Add(Me.PICcompany1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMChooseCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Project by Guillaume Labranche"
        Me.PNLtitlebar.ResumeLayout(False)
        Me.PNLtitlebar.PerformLayout()
        CType(Me.PICicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICminimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICcompany5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICcompany1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICcompany4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICcompany2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICcompany3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICprev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PICnext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PICcompany3 As System.Windows.Forms.PictureBox
    Friend WithEvents LBLcompanyName As System.Windows.Forms.Label
    Friend WithEvents PICnext As System.Windows.Forms.PictureBox
    Friend WithEvents PICprev As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PICcompany2 As System.Windows.Forms.PictureBox
    Friend WithEvents PICcompany4 As System.Windows.Forms.PictureBox
    Friend WithEvents LBLavailable As System.Windows.Forms.Label
    Friend WithEvents PICcompany1 As System.Windows.Forms.PictureBox
    Friend WithEvents PICcompany5 As System.Windows.Forms.PictureBox
    Friend WithEvents MoveCompanies As System.Windows.Forms.Timer
    Friend WithEvents LBLtitle As System.Windows.Forms.Label
    Friend WithEvents PICclose As System.Windows.Forms.PictureBox
    Friend WithEvents PICminimize As System.Windows.Forms.PictureBox
    Friend WithEvents TimerSplashAppear As System.Windows.Forms.Timer
    Friend WithEvents TimerSplashDisappear As System.Windows.Forms.Timer
    Friend WithEvents TimerSplashStay As System.Windows.Forms.Timer
    Friend WithEvents PNLtitlebar As System.Windows.Forms.Panel
    Friend WithEvents PICicon As System.Windows.Forms.PictureBox
    Friend WithEvents LBLaverageL As System.Windows.Forms.Label
    Friend WithEvents LBLaverage As System.Windows.Forms.Label

End Class
