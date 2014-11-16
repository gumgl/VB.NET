<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Top50
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LBLthis = New System.Windows.Forms.Label()
        Me.LBLlast = New System.Windows.Forms.Label()
        Me.LBLmost = New System.Windows.Forms.Label()
        Me.LBLartist = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(13, 109)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 123)
        Me.ListBox1.TabIndex = 0
        '
        'LBLthis
        '
        Me.LBLthis.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBLthis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLthis.Location = New System.Drawing.Point(166, 109)
        Me.LBLthis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLthis.Name = "LBLthis"
        Me.LBLthis.Size = New System.Drawing.Size(58, 35)
        Me.LBLthis.TabIndex = 1
        Me.LBLthis.Text = "0"
        Me.LBLthis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLlast
        '
        Me.LBLlast.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBLlast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLlast.Location = New System.Drawing.Point(264, 109)
        Me.LBLlast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLlast.Name = "LBLlast"
        Me.LBLlast.Size = New System.Drawing.Size(58, 35)
        Me.LBLlast.TabIndex = 2
        Me.LBLlast.Text = "0"
        Me.LBLlast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLmost
        '
        Me.LBLmost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBLmost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLmost.Location = New System.Drawing.Point(353, 109)
        Me.LBLmost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLmost.Name = "LBLmost"
        Me.LBLmost.Size = New System.Drawing.Size(58, 35)
        Me.LBLmost.TabIndex = 3
        Me.LBLmost.Text = "0"
        Me.LBLmost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLartist
        '
        Me.LBLartist.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBLartist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLartist.Location = New System.Drawing.Point(264, 168)
        Me.LBLartist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLartist.Name = "LBLartist"
        Me.LBLartist.Size = New System.Drawing.Size(147, 35)
        Me.LBLartist.TabIndex = 4
        Me.LBLartist.Text = "0"
        Me.LBLartist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Top 50 Billboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Song Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "This Week:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Last Week:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Most Week:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 38)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Artist:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Singer:"
        '
        'Top50
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 245)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLartist)
        Me.Controls.Add(Me.LBLmost)
        Me.Controls.Add(Me.LBLlast)
        Me.Controls.Add(Me.LBLthis)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Top50"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Top 50 Billboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LBLthis As System.Windows.Forms.Label
    Friend WithEvents LBLlast As System.Windows.Forms.Label
    Friend WithEvents LBLmost As System.Windows.Forms.Label
    Friend WithEvents LBLartist As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
