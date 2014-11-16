<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BTNAPPEND = New System.Windows.Forms.Button()
        Me.BTNCREATE = New System.Windows.Forms.Button()
        Me.BTNSHOW = New System.Windows.Forms.Button()
        Me.LSTFRIEND = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BTNAPPEND
        '
        Me.BTNAPPEND.Location = New System.Drawing.Point(46, 189)
        Me.BTNAPPEND.Name = "BTNAPPEND"
        Me.BTNAPPEND.Size = New System.Drawing.Size(75, 23)
        Me.BTNAPPEND.TabIndex = 0
        Me.BTNAPPEND.Text = "Append"
        Me.BTNAPPEND.UseVisualStyleBackColor = True
        '
        'BTNCREATE
        '
        Me.BTNCREATE.Location = New System.Drawing.Point(46, 47)
        Me.BTNCREATE.Name = "BTNCREATE"
        Me.BTNCREATE.Size = New System.Drawing.Size(75, 23)
        Me.BTNCREATE.TabIndex = 1
        Me.BTNCREATE.Text = "Create"
        Me.BTNCREATE.UseVisualStyleBackColor = True
        '
        'BTNSHOW
        '
        Me.BTNSHOW.Location = New System.Drawing.Point(46, 337)
        Me.BTNSHOW.Name = "BTNSHOW"
        Me.BTNSHOW.Size = New System.Drawing.Size(75, 23)
        Me.BTNSHOW.TabIndex = 2
        Me.BTNSHOW.Text = "Show"
        Me.BTNSHOW.UseVisualStyleBackColor = True
        '
        'LSTFRIEND
        '
        Me.LSTFRIEND.FormattingEnabled = True
        Me.LSTFRIEND.Location = New System.Drawing.Point(170, 47)
        Me.LSTFRIEND.Name = "LSTFRIEND"
        Me.LSTFRIEND.Size = New System.Drawing.Size(325, 329)
        Me.LSTFRIEND.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 478)
        Me.Controls.Add(Me.LSTFRIEND)
        Me.Controls.Add(Me.BTNSHOW)
        Me.Controls.Add(Me.BTNCREATE)
        Me.Controls.Add(Me.BTNAPPEND)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNAPPEND As System.Windows.Forms.Button
    Friend WithEvents BTNCREATE As System.Windows.Forms.Button
    Friend WithEvents BTNSHOW As System.Windows.Forms.Button
    Friend WithEvents LSTFRIEND As System.Windows.Forms.ListBox
End Class
