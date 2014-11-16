Imports System.IO

Public Class Form1

    Dim DocumentName As String = String.Empty
    Dim Changed As Boolean = False

    Public Sub CLEARDOCUMENT()
        TXTDOCUMENT.Clear()
        DocumentName = String.Empty
        Changed = False
    End Sub

    Public Sub OPENDOCUMENT()
        Dim InputFile As StreamReader
        If OFDIALOG.ShowDialog = Windows.Forms.DialogResult.OK Then
            DocumentName = OFDIALOG.FileName
            InputFile = File.OpenText(DocumentName)
            TXTDOCUMENT.Text = InputFile.ReadToEnd
            InputFile.Close()
        End If
    End Sub

    Public Sub SAVEDOCUMENT()
        Dim OutputFile As StreamWriter
        OutputFile = File.CreateText(DocumentName)
        OutputFile.Write(TXTDOCUMENT.Text)
        OutputFile.Close()
        Changed = False
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUNew.Click
        If Changed = False Then
            If MessageBox.Show("Current Document Not Saved " &
                               "Are You Sure?", "Confirm", MessageBoxButtons.YesNo) _
                           = Windows.Forms.DialogResult.Yes Then
                CLEARDOCUMENT()
            End If
        Else
            CLEARDOCUMENT()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUSAVE.Click
        If DocumentName = String.Empty Then
            If SFDIALOG.ShowDialog = Windows.Forms.DialogResult.OK Then
                DocumentName = SFDIALOG.FileName
                SAVEDOCUMENT()
            End If
        Else
            SAVEDOCUMENT()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUOPEN.Click
        If Changed = True Then
            If MessageBox.Show("Current Document Not Saved " &
                              "Are You Sure?", "Confirm", MessageBoxButtons.YesNo) _
                          = Windows.Forms.DialogResult.Yes Then
                CLEARDOCUMENT()
                OPENDOCUMENT()
            End If
        Else
            CLEARDOCUMENT()
            OPENDOCUMENT()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUSAVEAS.Click
        If DocumentName = String.Empty Then
            If SFDIALOG.ShowDialog = Windows.Forms.DialogResult.OK Then
                DocumentName = SFDIALOG.FileName
                SAVEDOCUMENT()
            End If
        Else
            SAVEDOCUMENT()
        End If
    End Sub

    Private Sub MNUEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUEXIT.Click
        If Changed = True Then
            If MessageBox.Show("Current Document Not Saved " & _
                              "Discard", "Confirm", MessageBoxButtons.YesNo) _
                          = Windows.Forms.DialogResult.Yes Then
             
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Changed = False Then
            If MessageBox.Show("Current Document Not Saved " & _
                              "Discard", "Confirm", MessageBoxButtons.YesNo) _
                          = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    
    Private Sub PDPRINT_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDPRINT.PrintPage
        e.Graphics.DrawString(TXTDOCUMENT.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    Private Sub MNUPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNUPRINT.Click
        PDPRINT.Print()
    End Sub
End Class
