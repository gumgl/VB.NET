Imports System.IO
Public Class Form1

    Dim FilePath As String = ""
    Dim fs As Boolean = False
    Dim oX, oY, oW, oH As Integer

    Private Sub TXTinput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTinput.TextChanged
        calc(True)
    End Sub

    Sub calc(ByVal justCalculate As Boolean)
        Dim length As Integer = Len(TXTinput.Text)

        If justCalculate = False Then
            If RADencrypt.Checked Or RADdecrypt.Checked Then
                TXTkey.Text = Nothing
                LBLkey.Visible = True
                TXTkey.Visible = True
                BTNencrypt.Visible = True
                CHKcode.Visible = True
                CodesToolStripMenuItem.Enabled = True
                CharactersToolStripMenuItem.Enabled = True
                If RADencrypt.Checked Then BTNencrypt.Text = "Encrypt"
                If RADdecrypt.Checked Then BTNencrypt.Text = "Decrypt"
                TXTkey.Focus()
            Else
                LBLkey.Visible = False
                TXTkey.Visible = False
                BTNencrypt.Visible = False
                CHKcode.Visible = False
                CodesToolStripMenuItem.Enabled = False
                CharactersToolStripMenuItem.Enabled = False
                TXTinput.Focus()
            End If
        End If

        If TXTinput.Text <> "" Then
            BTNsave.Enabled = True
            If RADlength.Checked Then
                TXTresult.Text = length
            ElseIf RADucase.Checked Then
                TXTresult.Text = TXTinput.Text.ToUpper()
            ElseIf RADlcase.Checked Then
                TXTresult.Text = TXTinput.Text.ToLower()
            ElseIf RADascii.Checked Then
                If length <= 1 Then
                    TXTresult.Text = Asc(TXTinput.Text)
                Else
                    TXTresult.Text = Asc(TXTinput.Text.Substring(0, 1))
                End If
            ElseIf RADchar.Checked And Val(TXTinput.Text) < 255 And Val(TXTinput.Text) > 1 Then
                TXTresult.Text = Chr(Val(TXTinput.Text))
            ElseIf RADmd5.Checked Then
                TXTresult.Text = md5(TXTinput.Text)
            ElseIf RADencrypt.Checked And Len(TXTkey.Text) > 0 Then
                TXTresult.Text = Vernam(False, TXTinput.Text, TXTkey.Text, CHKcode.Checked)
            ElseIf RADdecrypt.Checked And Len(TXTkey.Text) > 0 Then
                TXTresult.Text = Vernam(True, TXTinput.Text, TXTkey.Text, CHKcode.Checked)
            Else
                TXTresult.Text = "invalid input"
                BTNsave.Enabled = False
            End If
        Else
            TXTresult.Text = Nothing
            BTNsave.Enabled = False
        End If
    End Sub

    Private Sub RADchar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADchar.CheckedChanged
        calc(False)
        ResetActionsMenu()
        ASCIIToCharacterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADucase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADucase.CheckedChanged
        calc(False)
        ResetActionsMenu()
        UppercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADlcase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADlcase.CheckedChanged
        calc(False)
        ResetActionsMenu()
        LowercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADascii_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADascii.CheckedChanged
        calc(False)
        ResetActionsMenu()
        CharacterToASCIIToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADlength_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADlength.CheckedChanged
        calc(False)
        ResetActionsMenu()
        LengthToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADencrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADencrypt.CheckedChanged
        calc(False)
        ResetActionsMenu()
        EncryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADdecrypt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADdecrypt.CheckedChanged
        calc(False)
        ResetActionsMenu()
        DecryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Private Sub RADmd5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADmd5.CheckedChanged
        calc(False)
        ResetActionsMenu()
        MD5HashToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
    End Sub

    Function md5(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Private Function PadRight(ByVal input As String, ByVal length As Int32, ByVal padString As String) As String
        While input.Length < length
            input += padString
        End While

        Return input.Substring(0, length)
    End Function

    Private Function KeepOnlyDigits(ByVal str As String)
        Dim strarr() As Char = str.ToCharArray()
        Dim newstr As String = ""

        For i As Integer = 0 To Len(str) - 1
            If IsNumeric(strarr(i)) Then
                newstr += strarr(i)
            End If
        Next
        Return newstr
    End Function

    Private Function Vernam(ByVal decrypt As Boolean, ByVal message As String, ByVal key As String, Optional ByVal codes As Boolean = False) As String
        Dim msglen As Integer = Len(message)
        Dim keylen As Integer = Len(key)
        Dim hash As String = ""

        If codes Then
            If decrypt Then
                message = KeepOnlyDigits(message)
                msglen = Len(message)
                If msglen / 3 > Math.Floor(msglen / 3) Then message = message.Substring(0, msglen - msglen Mod 3)
                msglen = Len(message)
                Dim msgarr() As Char = message.ToCharArray()
                If keylen * 3 < msglen Then key = PadRight(key, msglen / 3, key)
                Dim keyarr() As Char = key.ToCharArray()
                For i As Integer = 0 To msglen / 3 - 1
                    hash &= Chr((255 + Val(message.Substring(i * 3, 3)) - Asc(keyarr(i))) Mod 255)
                Next
            Else
                Dim msgarr() As Char = message.ToCharArray()
                If keylen < msglen Then key = PadRight(key, msglen, key)
                Dim keyarr() As Char = key.ToCharArray()
                For i As Integer = 0 To msglen - 1
                    hash &= CStr((Asc(msgarr(i)) + Asc(keyarr(i))) Mod 255)
                    If i < msglen - 1 Then hash &= "-"
                Next
            End If
        Else
            Dim msgarr() As Char = message.ToCharArray()
            If keylen < msglen Then key = PadRight(key, msglen, key)
            Dim keyarr() As Char = key.ToCharArray()
            If decrypt Then
                For i As Integer = 0 To msglen - 1
                    hash &= Chr(((255 + Asc(msgarr(i)) - Asc(keyarr(i))) Mod 255))
                Next
            Else
                For i As Integer = 0 To msglen - 1
                    hash &= Chr((Asc(msgarr(i)) + Asc(keyarr(i))) Mod 255)
                Next
            End If
        End If

        Return hash
    End Function

    Private Sub TXTkey_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTkey.KeyUp
        If e.KeyCode = Keys.Enter Then
            calc(True)
            TXTkey.Text = Nothing
            TXTresult.Select()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        TXTinput.Focus()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        TXTresult.Focus()
    End Sub

    Private Sub BTNclearinput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNclearinput.Click
        TXTinput.Text = Nothing
        TXTinput.Focus()
    End Sub

    Private Sub BTNencrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNencrypt.Click
        calc(True)
        TXTkey.Text = Nothing
        TXTresult.Select()
    End Sub

    Private Sub LBLkey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLkey.Click
        TXTkey.Focus()
    End Sub

    Private Sub BTNhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNhelp.Click
        help()
    End Sub

    Private Sub BTNsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsave.Click
        SaveFile()
    End Sub

    Private Sub BTNopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNopen.Click
        OpenFile()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        help()
    End Sub

    Sub OpenFile()
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
        '   TXTinput.Text = sr.ReadToEnd
        '    sr.Close()
        '    RADdecrypt.Checked = True
        'End If
        Dim FileName As String
        'declaring filename that will be selected
        Dim sr As StreamReader
        'streamreader is used to read text
        Try
            With OpenFileDialog1
                'With statement is used to execute statements using a particular object, here,_
                'OpenFileDialog1
                .Filter = "Text files (*.txt)|*.txt"
                'setting filters so that Text files and All Files choice appears in the Files of Type box
                'in the dialog
                If .ShowDialog() = DialogResult.OK Then
                    'showDialog method makes the dialog box visible at run time
                    FileName = .FileName
                    sr = New StreamReader(.OpenFile)
                    'using streamreader to read the opened text file
                    TXTinput.Text = sr.ReadToEnd()
                    'displaying text from streamreader in richtextbox
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sr Is Nothing) Then
                sr.Close()
            End If
        End Try
        RADdecrypt.Checked = True
    End Sub

    Sub SaveFile()
        If TXTresult.Text <> "" Then
            Dim FileName As String
            'declaring filename that will be selected
            Dim sw As StreamWriter
            'streamwriter is used to write text
            Try
                With SaveFileDialog1
                    .FileName = FileName
                    .Filter = "Text files (*.txt)|*.txt"
                    If .ShowDialog() = DialogResult.OK Then
                        FileName = .FileName
                        sw = New StreamWriter(FileName)
                        'using streamwriter to write text from richtextbox and saving it
                        sw.Write(TXTresult.Text)
                        FilePath = FileName
                        BTNfolder.Enabled = True
                    End If
                End With
            Catch es As Exception
                MessageBox.Show(es.Message)
            Finally
                If Not (sw Is Nothing) Then
                    sw.Close()
                End If
            End Try
        End If
    End Sub

    Sub help()
        MsgBox("Confused?" & vbCrLf & "To encrypt a message using the Vernam Cipher," & vbCrLf & "you need to provide a message and a key." & vbCrLf & "The key should be kept secret." & vbCrLf & "Use it to encrypt and decrypt the message.", MsgBoxStyle.Information, "Encryption For Dummies")
    End Sub
    Private Sub Form1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileLoc As String In filePaths
                ' Code to read the contents of the text file
                If File.Exists(fileLoc) Then
                    Using tr As TextReader = New StreamReader(fileLoc)
                        TXTinput.Text = tr.ReadToEnd()
                    End Using
                End If
            Next(fileLoc)
        End If
        RADdecrypt.Checked = True
    End Sub

    Private Sub BTNfolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNfolder.Click
        Shell("C:\WINDOWS\explorer.exe /select," & FilePath, AppWinStyle.NormalFocus)
    End Sub

    Private Sub LengthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LengthToolStripMenuItem.Click
        RADlength.Checked = True
    End Sub

    Private Sub UppercaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UppercaseToolStripMenuItem.Click
        RADucase.Checked = True
    End Sub

    Private Sub LowercaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowercaseToolStripMenuItem.Click
        RADlcase.Checked = True
    End Sub

    Private Sub CharacterToASCIIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharacterToASCIIToolStripMenuItem.Click
        RADascii.Checked = True
    End Sub

    Private Sub ASCIIToCharacterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASCIIToCharacterToolStripMenuItem.Click
        RADchar.Checked = True
    End Sub

    Private Sub MD5HashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MD5HashToolStripMenuItem.Click
        RADmd5.Checked = True
    End Sub

    Private Sub EncryptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptToolStripMenuItem.Click
        RADencrypt.Checked = True
    End Sub

    Private Sub DecryptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptToolStripMenuItem.Click
        RADdecrypt.Checked = True
    End Sub

    Private Sub CharactersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CharactersToolStripMenuItem.Click
        CHKcode.Checked = False
    End Sub

    Private Sub UseASCIICodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodesToolStripMenuItem.Click
        CHKcode.Checked = True
    End Sub

    Private Sub CHKcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKcode.CheckedChanged
        If CHKcode.Checked Then
            CharactersToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            CodesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
        Else
            CharactersToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            CodesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        End If
    End Sub

    Sub ResetActionsMenu()
        LengthToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        UppercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        LowercaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        CharacterToASCIIToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        ASCIIToCharacterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        MD5HashToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        EncryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        DecryptToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click
        If fs Then ' Exit Full Screen
            Me.Width = oW
            Me.Height = oH
            Me.Left = oX
            Me.Top = oY
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.TopMost = False

            fs = False
        Else ' Go Full Screen
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

            oW = Me.Width
            oH = Me.Height
            oX = Me.Left
            oY = Me.Top

            Me.Left = 0
            Me.Top = 0
            Me.Width = Screen.PrimaryScreen.Bounds.Width
            Me.Height = Screen.PrimaryScreen.Bounds.Height
            Me.TopMost = True

            fs = True
        End If
    End Sub

    Private Sub ClearResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearResetToolStripMenuItem.Click
        TXTinput.Text = Nothing
        RADlength.Checked = True
        BTNfolder.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://gumgl.co.cc/")
    End Sub

    Private Sub CopyMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyMessageToolStripMenuItem.Click
        Clipboard.SetDataObject(TXTinput.Text)
    End Sub

    Private Sub PasteMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteMessageToolStripMenuItem.Click
        TXTinput.Text = Clipboard.GetDataObject().GetData(DataFormats.Text)
    End Sub

    Private Sub CopyResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyResultToolStripMenuItem.Click
        Clipboard.SetDataObject(TXTresult.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class