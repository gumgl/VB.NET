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
        Me.TXTDOCUMENT = New System.Windows.Forms.TextBox()
        Me.MNUFILE = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUOPEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUSAVE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUSAVEAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUEXIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUPRINT = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFDIALOG = New System.Windows.Forms.OpenFileDialog()
        Me.SFDIALOG = New System.Windows.Forms.SaveFileDialog()
        Me.PDPRINT = New System.Drawing.Printing.PrintDocument()
        Me.MNUFILE.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTDOCUMENT
        '
        Me.TXTDOCUMENT.Location = New System.Drawing.Point(35, 43)
        Me.TXTDOCUMENT.Multiline = True
        Me.TXTDOCUMENT.Name = "TXTDOCUMENT"
        Me.TXTDOCUMENT.Size = New System.Drawing.Size(620, 378)
        Me.TXTDOCUMENT.TabIndex = 0
        '
        'MNUFILE
        '
        Me.MNUFILE.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MNUFILE.Location = New System.Drawing.Point(0, 0)
        Me.MNUFILE.Name = "MNUFILE"
        Me.MNUFILE.Size = New System.Drawing.Size(707, 24)
        Me.MNUFILE.TabIndex = 1
        Me.MNUFILE.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNUNew, Me.MNUOPEN, Me.MNUSAVE, Me.MNUSAVEAS, Me.MNUEXIT, Me.MNUPRINT})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MNUNew
        '
        Me.MNUNew.Name = "MNUNew"
        Me.MNUNew.Size = New System.Drawing.Size(114, 22)
        Me.MNUNew.Text = "New"
        '
        'MNUOPEN
        '
        Me.MNUOPEN.Name = "MNUOPEN"
        Me.MNUOPEN.Size = New System.Drawing.Size(114, 22)
        Me.MNUOPEN.Text = "Open"
        '
        'MNUSAVE
        '
        Me.MNUSAVE.Name = "MNUSAVE"
        Me.MNUSAVE.Size = New System.Drawing.Size(114, 22)
        Me.MNUSAVE.Text = "Save"
        '
        'MNUSAVEAS
        '
        Me.MNUSAVEAS.Name = "MNUSAVEAS"
        Me.MNUSAVEAS.Size = New System.Drawing.Size(114, 22)
        Me.MNUSAVEAS.Text = "Save As"
        '
        'MNUEXIT
        '
        Me.MNUEXIT.Name = "MNUEXIT"
        Me.MNUEXIT.Size = New System.Drawing.Size(114, 22)
        Me.MNUEXIT.Text = "Exit "
        '
        'MNUPRINT
        '
        Me.MNUPRINT.Name = "MNUPRINT"
        Me.MNUPRINT.Size = New System.Drawing.Size(152, 22)
        Me.MNUPRINT.Text = "Print"
        '
        'OFDIALOG
        '
        Me.OFDIALOG.FileName = "OpenFileDialog1"
        Me.OFDIALOG.Filter = "(*.txt)|*.txt"
        Me.OFDIALOG.InitialDirectory = "C:\Users\kevadr10\Desktop\Text"
        '
        'SFDIALOG
        '
        Me.SFDIALOG.Filter = "(*.txt)|*.txt"
        Me.SFDIALOG.InitialDirectory = "C:\Users\kevadr10\Desktop\Text"
        '
        'PDPRINT
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 548)
        Me.Controls.Add(Me.TXTDOCUMENT)
        Me.Controls.Add(Me.MNUFILE)
        Me.MainMenuStrip = Me.MNUFILE
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MNUFILE.ResumeLayout(False)
        Me.MNUFILE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTDOCUMENT As System.Windows.Forms.TextBox
    Friend WithEvents MNUFILE As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUOPEN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUSAVE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUSAVEAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUEXIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MNUPRINT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFDIALOG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFDIALOG As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PDPRINT As System.Drawing.Printing.PrintDocument

End Class
