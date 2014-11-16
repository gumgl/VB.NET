<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextFiles
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
        Me.BTNcreate = New System.Windows.Forms.Button()
        Me.BTNappend = New System.Windows.Forms.Button()
        Me.BTNread = New System.Windows.Forms.Button()
        Me.BTNtop50 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(13, 51)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(280, 225)
        Me.ListBox1.TabIndex = 0
        '
        'BTNcreate
        '
        Me.BTNcreate.Location = New System.Drawing.Point(13, 13)
        Me.BTNcreate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcreate.Name = "BTNcreate"
        Me.BTNcreate.Size = New System.Drawing.Size(88, 30)
        Me.BTNcreate.TabIndex = 1
        Me.BTNcreate.Text = "Create"
        Me.BTNcreate.UseVisualStyleBackColor = True
        '
        'BTNappend
        '
        Me.BTNappend.Location = New System.Drawing.Point(109, 13)
        Me.BTNappend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNappend.Name = "BTNappend"
        Me.BTNappend.Size = New System.Drawing.Size(88, 30)
        Me.BTNappend.TabIndex = 2
        Me.BTNappend.Text = "Append"
        Me.BTNappend.UseVisualStyleBackColor = True
        '
        'BTNread
        '
        Me.BTNread.Location = New System.Drawing.Point(205, 13)
        Me.BTNread.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNread.Name = "BTNread"
        Me.BTNread.Size = New System.Drawing.Size(88, 30)
        Me.BTNread.TabIndex = 3
        Me.BTNread.Text = "Read"
        Me.BTNread.UseVisualStyleBackColor = True
        '
        'BTNtop50
        '
        Me.BTNtop50.Location = New System.Drawing.Point(301, 13)
        Me.BTNtop50.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNtop50.Name = "BTNtop50"
        Me.BTNtop50.Size = New System.Drawing.Size(130, 263)
        Me.BTNtop50.TabIndex = 4
        Me.BTNtop50.Text = "Top 50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Billboard"
        Me.BTNtop50.UseVisualStyleBackColor = True
        '
        'TextFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 290)
        Me.Controls.Add(Me.BTNtop50)
        Me.Controls.Add(Me.BTNread)
        Me.Controls.Add(Me.BTNappend)
        Me.Controls.Add(Me.BTNcreate)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "TextFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Files by Guillaume L."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BTNcreate As System.Windows.Forms.Button
    Friend WithEvents BTNappend As System.Windows.Forms.Button
    Friend WithEvents BTNread As System.Windows.Forms.Button
    Friend WithEvents BTNtop50 As System.Windows.Forms.Button

End Class
