<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLmtl = New System.Windows.Forms.Label()
        Me.LBLottawa = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNnext = New System.Windows.Forms.Button()
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTmtl = New System.Windows.Forms.MaskedTextBox()
        Me.TXTottawa = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLinning = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Baseball Scoreboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(102, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1  2  3  4  5  6  7  8  9  Final"
        '
        'LBLmtl
        '
        Me.LBLmtl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLmtl.ForeColor = System.Drawing.Color.White
        Me.LBLmtl.Location = New System.Drawing.Point(6, 10)
        Me.LBLmtl.Name = "LBLmtl"
        Me.LBLmtl.Size = New System.Drawing.Size(297, 19)
        Me.LBLmtl.TabIndex = 2
        Me.LBLmtl.Text = "mtl"
        '
        'LBLottawa
        '
        Me.LBLottawa.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLottawa.ForeColor = System.Drawing.Color.White
        Me.LBLottawa.Location = New System.Drawing.Point(6, 43)
        Me.LBLottawa.Name = "LBLottawa"
        Me.LBLottawa.Size = New System.Drawing.Size(297, 19)
        Me.LBLottawa.TabIndex = 3
        Me.LBLottawa.Text = "ottawa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LBLmtl)
        Me.Panel1.Controls.Add(Me.LBLottawa)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(95, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 80)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(1, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Montreal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ottawa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(23, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ottawa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Montreal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNnext
        '
        Me.BTNnext.BackColor = System.Drawing.Color.Maroon
        Me.BTNnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNnext.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.BTNnext.FlatAppearance.BorderSize = 5
        Me.BTNnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNnext.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNnext.ForeColor = System.Drawing.Color.White
        Me.BTNnext.Location = New System.Drawing.Point(176, 215)
        Me.BTNnext.Name = "BTNnext"
        Me.BTNnext.Size = New System.Drawing.Size(84, 62)
        Me.BTNnext.TabIndex = 11
        Me.BTNnext.TabStop = False
        Me.BTNnext.Text = "Next Inning"
        Me.BTNnext.UseVisualStyleBackColor = False
        '
        'BTNexit
        '
        Me.BTNexit.BackColor = System.Drawing.Color.Maroon
        Me.BTNexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNexit.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.BTNexit.FlatAppearance.BorderSize = 5
        Me.BTNexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNexit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNexit.ForeColor = System.Drawing.Color.White
        Me.BTNexit.Location = New System.Drawing.Point(301, 215)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(84, 62)
        Me.BTNexit.TabIndex = 12
        Me.BTNexit.TabStop = False
        Me.BTNexit.Text = "GTFO"
        Me.BTNexit.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(46, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Montreal vs. Ottawa"
        '
        'TXTmtl
        '
        Me.TXTmtl.BeepOnError = True
        Me.TXTmtl.CausesValidation = False
        Me.TXTmtl.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTmtl.Location = New System.Drawing.Point(106, 220)
        Me.TXTmtl.Mask = "00"
        Me.TXTmtl.Name = "TXTmtl"
        Me.TXTmtl.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TXTmtl.Size = New System.Drawing.Size(46, 23)
        Me.TXTmtl.TabIndex = 1
        '
        'TXTottawa
        '
        Me.TXTottawa.BeepOnError = True
        Me.TXTottawa.CausesValidation = False
        Me.TXTottawa.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTottawa.Location = New System.Drawing.Point(106, 253)
        Me.TXTottawa.Mask = "00"
        Me.TXTottawa.Name = "TXTottawa"
        Me.TXTottawa.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TXTottawa.Size = New System.Drawing.Size(46, 23)
        Me.TXTottawa.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(301, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Inning #"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLinning
        '
        Me.LBLinning.AutoSize = True
        Me.LBLinning.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLinning.ForeColor = System.Drawing.Color.DarkGreen
        Me.LBLinning.Location = New System.Drawing.Point(383, 40)
        Me.LBLinning.Name = "LBLinning"
        Me.LBLinning.Size = New System.Drawing.Size(19, 21)
        Me.LBLinning.TabIndex = 15
        Me.LBLinning.Text = "1"
        Me.LBLinning.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.CancelButton = Me.BTNexit
        Me.ClientSize = New System.Drawing.Size(423, 289)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTottawa)
        Me.Controls.Add(Me.TXTmtl)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.BTNnext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLinning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scoreboard"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLmtl As System.Windows.Forms.Label
    Friend WithEvents LBLottawa As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNnext As System.Windows.Forms.Button
    Friend WithEvents BTNexit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTmtl As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TXTottawa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLinning As System.Windows.Forms.Label

End Class
