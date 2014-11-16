Imports System.IO

Public Class Main
    Const TITLE = "Notepad--"
    Dim FilePath As String = ""
    Dim FileName As String = FilePath
    Dim saved As Boolean = True
    Dim StringToPrint As String

    Sub UpdateTitle()
        If FileName = "" Then FileName = "Untitled"
        Me.Text = FileName & " - " & TITLE
    End Sub

    Sub ChooseFont()
        FontDialog1.Font = TextBox1.Font
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Sub ChooseColor()
        ColorDialog1.Color = TextBox1.ForeColor
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Sub Copy()
        ' Ensure that text is selected in the text box.   
        If TextBox1.SelectionLength > 0 Then
            ' Copy the selected text to the Clipboard.
            TextBox1.Copy()
        End If
    End Sub

    Sub Cut()
        ' Ensure that text is currently selected in the text box.   
        If TextBox1.SelectedText <> "" Then
            ' Cut the selected text in the control and paste it into the Clipboard.
            TextBox1.Cut()
        End If
    End Sub

    Sub Paste()
        ' Determine if there is any text in the Clipboard to paste into the text box.
        If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
            ' Paste current text in Clipboard into text box.
            TextBox1.Paste()
        End If
    End Sub

    Sub Delete()
        'Dim textBefore As String
        'Dim textAfter As String
        'Dim selectIndex As Integer = TextBox1.SelectionStart
        ' Ensure that text is currently selected in the text box.   
        'If TextBox1.SelectedText <> "" Then
        'textBefore = TextBox1.Text.Substring(0, TextBox1.SelectionStart)
        ' textAfter = TextBox1.Text.Substring(TextBox1.SelectionStart + TextBox1.SelectionLength, TextBox1.Text.Length - (TextBox1.SelectionStart + TextBox1.SelectionLength))
        '  TextBox1.Text = textBefore & textAfter
        '   TextBox1.SelectionStart = selectIndex
        'End If
        If TextBox1.SelectedText <> "" Then TextBox1.SelectedText = ""
    End Sub

    Sub Find()
        FindReplace.Show()
    End Sub

    Sub Undo()
        ' Determine if last operation can be undone in text box.   
        If TextBox1.CanUndo = True Then
            ' Undo the last operation.
            TextBox1.Undo()
            ' Clear the undo buffer to prevent last action from being redone.
            'TextBox1.ClearUndo()
        End If
    End Sub

    Sub SelectAll()
        TextBox1.SelectAll()
    End Sub

    Sub Open()
        Dim result As DialogResult
        Dim sr As StreamReader
        'streamreader is used to read text
        If saved = False Then
            result = MessageBox.Show("Do you want to save changes to " & FileName & "?", TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            Select Case result
                Case DialogResult.Yes
                    Save()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        Try
            With OpenFileDialog1
                'With statement is used to execute statements using a particular object, here,_
                'OpenFileDialog1
                .FileName = ""
                .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
                'setting filters so that Text files and All Files choice appears in the Files of Type box
                'in the dialog
                If .ShowDialog() = DialogResult.OK Then
                    'showDialog method makes the dialog box visible at run time
                    FilePath = .FileName
                    FileName = Path.GetFileName(FilePath)
                    sr = New StreamReader(.OpenFile)
                    'using streamreader to read the opened text file
                    TextBox1.Text = sr.ReadToEnd()
                    'displaying text from streamreader in richtextbox
                    UpdateTitle()
                    saved = True
                End If
            End With
        Catch es As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & es.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
    End Sub

    Sub SaveAs()
        Dim sw As StreamWriter
        'streamwriter is used to write text
        Try
            With SaveFileDialog1
                .FileName = FilePath
                .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    FilePath = .FileName
                    FileName = Path.GetFileName(FilePath)
                    sw = New StreamWriter(FilePath)
                    'using streamwriter to write text from richtextbox and saving it
                    sw.Write(TextBox1.Text)
                    UpdateTitle()
                    saved = True
                End If
            End With
        Catch es As Exception
            MessageBox.Show("Cannot write file to disk. Original error: " & es.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub

    Sub Save()
        If FilePath = "" Then
            SaveAs()
        Else
            Dim sw As StreamWriter
            'streamwriter is used to write text
            Try
                sw = New StreamWriter(FilePath)
                'using streamwriter to write text from richtextbox and saving it
                sw.Write(TextBox1.Text)
                saved = True
            Catch es As Exception
                MessageBox.Show("Cannot write file to disk. Original error: " & es.Message)
            Finally
                If Not (sw Is Nothing) Then
                    sw.Close()
                End If
            End Try
        End If
    End Sub

    Sub NewFile()
        Dim result As DialogResult
        If saved = False Then
            result = MessageBox.Show("Do you want to save changes to " & FileName & "?", TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            Select Case result
                Case DialogResult.Yes
                    Save()
                Case DialogResult.Cancel
                    Exit Sub
            End Select
        End If
        TextBox1.Text = ""
        saved = True
        FilePath = ""
        FileName = ""
        UpdateTitle()
    End Sub

    Sub About()
        MessageBox.Show("This notepad was developed by Guillaume Labranche on April 18th, 2011.", "About " & TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Top = 0
        TextBox1.Left = 0

        TextBox1.Font = My.Settings.Font
        TextBox1.ForeColor = My.Settings.Color
        MenuItemWordWrap.Checked = My.Settings.WordWrap
        TextBox1.WordWrap = My.Settings.WordWrap
        MenuItemStatusBar.Checked = My.Settings.StatusBar
        StatusBar1.Visible = My.Settings.StatusBar
        Me.Width = My.Settings.Width
        Me.Height = My.Settings.Height ' Resize after because in resizing, we display the correct textbox height depending on StatusBar1.Visible

        UpdateTitle()
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        If saved = False Then
            result = MessageBox.Show("Do you want to save changes to " & FileName & "?", TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            Select Case result
                Case DialogResult.Yes
                    Save()
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Width = Me.Width
        My.Settings.Height = Me.Height
        My.Settings.Font = TextBox1.Font
        My.Settings.Color = TextBox1.ForeColor
        My.Settings.WordWrap = TextBox1.WordWrap
        My.Settings.StatusBar = StatusBar1.Visible
        My.Settings.Save()
    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TextBox1.Width = Me.Width - 16
        TextBox1.Height = Me.Height - 58
        If StatusBar1.Visible Then TextBox1.Height -= 22
    End Sub

    Private Sub MenuItemFontStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFontStyle.Click
        ChooseFont()
    End Sub

    Private Sub MenuItemFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFontColor.Click
        ChooseColor()
    End Sub

    Private Sub MenuItemCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCut.Click
        Cut()
    End Sub

    Private Sub MenuItemCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCopy.Click
        Copy()
    End Sub

    Private Sub MenuItemPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPaste.Click
        Paste()
    End Sub

    Private Sub MenuItemDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDelete.Click
        Delete()
    End Sub

    Private Sub MenuItemUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemUndo.Click
        Undo()
    End Sub

    Private Sub MenuItemSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelectAll.Click
        SelectAll()
    End Sub

    Private Sub MenuItemWordWrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemWordWrap.Click
        MenuItemWordWrap.Checked = MenuItemWordWrap.Checked Xor True
        TextBox1.WordWrap = MenuItemWordWrap.Checked
    End Sub

    Private Sub MenuItemStatusBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemStatusBar.Click
        MenuItemStatusBar.Checked = MenuItemStatusBar.Checked Xor True
        StatusBar1.Visible = MenuItemStatusBar.Checked
        Main_Resize(sender, e)
    End Sub

    Private Sub MenuItemFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFind.Click
        Find()
    End Sub

    Private Sub MenuItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSave.Click
        Save()
    End Sub

    Private Sub MenuItemSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSaveAs.Click
        SaveAs()
    End Sub

    Private Sub MenuItemNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemNew.Click
        NewFile()
    End Sub

    Private Sub TextBox1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.SelectionChanged
        Dim index = TextBox1.SelectionStart
        Dim currentLine = TextBox1.GetLineFromCharIndex(index)
        Dim currentColumn = index - TextBox1.GetFirstCharIndexFromLine(currentLine)
        StatusBarPanel1.Text = "Ln " & currentLine + 1 & ", Col " & currentColumn + 1
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        saved = False
    End Sub

    Private Sub MenuItemOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOpen.Click
        Open()
    End Sub

    Private Sub MenuItemTimeDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTimeDate.Click
        Dim timeStamp As DateTime = TimeOfDay.Now()

        TextBox1.SelectedText = timeStamp.ToShortTimeString & " " & timeStamp.ToShortDateString
        TextBox1.Select(TextBox1.SelectionStart + TextBox1.SelectionLength, 0)
    End Sub

    Private Sub MenuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub MenuItemAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAbout.Click
        About()
    End Sub

    Private Sub MenuItemGoTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemGoTo.Click
        Dim line As String = InputBox("Line number:", "Go To Line", TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1)

        If Val(line) >= 1 And Val(line) <= TextBox1.GetLineFromCharIndex(TextBox1.MaxLength - 1) + 1 Then
            TextBox1.SelectionStart = TextBox1.GetFirstCharIndexFromLine(line - 1)
        ElseIf IsNumeric(line) Then
            If MessageBox.Show("The line number is beyong the total number of lines", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Retry Then
                MenuItemGoTo.PerformClick()
            End If
        End If
    End Sub

    Private Sub MenuItemPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPrint.Click
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            StringToPrint = TextBox1.Text
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim numChars As Integer

        Dim numLines As Integer

        Dim stringForPage As String

        Dim strFormat As New StringFormat()

        Dim PrintFont As Font

        PrintFont = TextBox1.Font

        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)

        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

        strFormat.Trimming = StringTrimming.Word

        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)

        stringForPage = StringToPrint.Substring(0, numChars)

        e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)

        If numChars < StringToPrint.Length Then

            StringToPrint = StringToPrint.Substring(numChars)

            e.HasMorePages = True

        Else

            e.HasMorePages = False

        End If

    End Sub
End Class