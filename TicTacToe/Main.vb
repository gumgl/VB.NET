Imports System.IO

Structure Player
    Dim normal As Image
    Dim faded As Image
    Dim token As String
End Structure

Public Class FRMmain
    <System.STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New FRMmain)
    End Sub
    Dim players(1) As Player
    Dim wins(1) As Integer
    Dim currPlayer As Integer
    Dim startPlayer As Integer
    Dim timer As Integer
    Dim moves(9) As Integer
    Dim countMoves As Integer
    Dim maxMoves As Integer
    Dim gameEnded = False
    Dim opening = False
    Dim PICS(2, 2) As PictureBox
    Public blackReach = 126 'default: 186

    'SETTINGS (related to Options.vb)
    Public STGfirstPlayer As Integer = My.Settings.firstPlayer
    Public STGtimed As Boolean = My.Settings.timed
    Public STGundo As Boolean = My.Settings.undo
    Public STGredo As Boolean = My.Settings.redo

    Private Sub FRMtictactoe_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Xwins = wins(0)
        My.Settings.Owins = wins(1)
        My.Settings.firstPlayer = STGfirstPlayer
        My.Settings.undo = STGundo
        My.Settings.redo = STGredo
        My.Settings.bgcolor = PictureBox1.BackColor
        My.Settings.timed = STGtimed
        My.Settings.Save()
    End Sub

    Private Sub FRMtictactoe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PICS(0, 0) = PictureBox1
        PICS(0, 1) = PictureBox2
        PICS(0, 2) = PictureBox3
        PICS(1, 0) = PictureBox4
        PICS(1, 1) = PictureBox5
        PICS(1, 2) = PictureBox6
        PICS(2, 0) = PictureBox7
        PICS(2, 1) = PictureBox8
        PICS(2, 2) = PictureBox9

        Randomize()
        players(0).normal = My.Resources.X
        players(0).faded = My.Resources.X_dim
        players(0).token = "X"
        players(1).normal = My.Resources.O
        players(1).faded = My.Resources.O_dim
        players(1).token = "O"
        startPlayer = Math.Floor(Rnd() * 2)

        ClearGrid()
        countMoves = 1
        maxMoves = 1

        wins(0) = My.Settings.Xwins
        wins(1) = My.Settings.Owins

        ToolStripStatusLabelXwins.Text = "X wins: " & wins(0)
        ToolStripStatusLabelOwins.Text = "O wins: " & wins(1)

        ToolStripStatusLabelTimer.Visible = STGtimed
        MenuItemUndo.Visible = STGundo
        MenuItemRedo.Visible = STGredo

        MenuItem3.Visible = STGundo Or STGredo

        If PICS(0, 0).BackColor.R * 0.299 + PICS(0, 0).BackColor.G * 0.587 + PICS(0, 0).BackColor.B * 0.114 > blackReach Then
            PNLboard.BackColor = Color.Black
        Else
            PNLboard.BackColor = Color.White
        End If

        For Each pic In PICS
            pic.BackColor = My.Settings.bgcolor
        Next
    End Sub

    Sub ClearGrid()
        For Each pic In PICS
            pic.Image = Nothing
            pic.Tag = Nothing
            pic.Cursor = Cursors.Hand
        Next
        PNLtop.Visible = False
        PNLmiddleH.Visible = False
        PNLbottom.Visible = False
        PNLleft.Visible = False
        PNLmiddleV.Visible = False
        PNLright.Visible = False
        gameEnded = False
        countMoves = 1
        If STGfirstPlayer = 1 Then
            currPlayer = startPlayer
            SwitchPlayer()
        ElseIf STGfirstPlayer = 3 Then
            SwitchPlayer()
        ElseIf STGfirstPlayer = 4 Then
            currPlayer = Math.Floor(Rnd() * 2)
            SwitchPlayer()
        End If
        startPlayer = currPlayer
        MenuItemUndo.Enabled = False
        MenuItemRedo.Enabled = False
        MenuItemSave.Enabled = False
        timer = 0
        ToolStripStatusLabelTimer.Text = "Time: 0:00"
        If STGtimed Then
            TMRtime.Stop()
            TMRtime.Start()
        End If
    End Sub

    Sub SwitchPlayer()
        'MsgBox("Switching...")
        currPlayer = 1 - currPlayer
        ToolStripStatusLabelPlayer.Text = "Current Player: " & players(currPlayer).token
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PICclick(PictureBox1, 1)
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PICenter(PictureBox1)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PICleave(PictureBox1)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PICclick(PictureBox2, 2)
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PICenter(PictureBox2)
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PICleave(PictureBox2)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PICclick(PictureBox3, 3)
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PICenter(PictureBox3)
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PICleave(PictureBox3)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PICclick(PictureBox4, 4)
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PICenter(PictureBox4)
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PICleave(PictureBox4)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PICclick(PictureBox5, 5)
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PICenter(PictureBox5)
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PICleave(PictureBox5)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PICclick(PictureBox6, 6)
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PICenter(PictureBox6)
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PICleave(PictureBox6)
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PICclick(PictureBox7, 7)
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PICenter(PictureBox7)
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PICleave(PictureBox7)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PICclick(PictureBox8, 8)
    End Sub

    Private Sub PictureBox8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PICenter(PictureBox8)
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PICleave(PictureBox8)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PICclick(PictureBox9, 9)
    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PICenter(PictureBox9)
    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PICleave(PictureBox9)
    End Sub

    Private Sub TMRtime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRtime.Tick
        If gameEnded Then
            TMRtime.Stop()
        Else
            timer += 1
            Dim time As String = ""
            Dim seconds As Integer = timer Mod 60
            Dim minutes As Integer = timer \ 60

            'If minutes < 10 Then time &= "0"
            time &= minutes & ":"
            If seconds < 10 Then time &= "0"
            time &= seconds
            ToolStripStatusLabelTimer.Text = "Time: " & time
        End If
    End Sub

    Sub PICclick(ByRef picture As PictureBox, ByVal picID As Integer)
        If picture.Tag = Nothing And gameEnded = False Then
            If countMoves <= 9 Then moves(countMoves) = picID
            countMoves += 1
            If countMoves > maxMoves Then
                maxMoves = countMoves
                MenuItemRedo.Enabled = False
            End If
            picture.Image = players(currPlayer).normal
            picture.Tag = players(currPlayer).token
            picture.Cursor = Cursors.Default
            If countMoves > 1 Then
                MenuItemUndo.Enabled = True
                MenuItemSave.Enabled = True
            End If
            If CheckWinner(picID) Then
                MenuItemSave.Enabled = False
            Else
                SwitchPlayer()
            End If

        End If
    End Sub

    Sub PICenter(ByRef picture As PictureBox)
        If picture.Tag = Nothing And gameEnded = False Then
            picture.Image = players(currPlayer).faded
        End If
    End Sub

    Sub PICleave(ByRef picture As PictureBox)
        If picture.Tag = Nothing And gameEnded = False Then
            picture.Image = Nothing
        End If
    End Sub

    Private Sub BTNreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemNew.Click
        If gameEnded = False And countMoves > 1 Then
            If MsgBox("Are you sure you want to start a new Game?", MsgBoxStyle.OkCancel, "New Game") = vbOK Then ClearGrid()
        Else
            ClearGrid()
        End If
    End Sub

    Private Sub BTNundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemUndo.Click
        If STGundo Then
            countMoves -= 1
            SwitchPlayer()
            Select Case moves(countMoves)
                Case 1
                    PictureBox1.Image = Nothing
                    PictureBox1.Tag = Nothing
                    PictureBox1.Cursor = Cursors.Hand
                Case 2
                    PictureBox2.Image = Nothing
                    PictureBox2.Tag = Nothing
                    PictureBox2.Cursor = Cursors.Hand
                Case 3
                    PictureBox3.Image = Nothing
                    PictureBox3.Tag = Nothing
                    PictureBox3.Cursor = Cursors.Hand
                Case 4
                    PictureBox4.Image = Nothing
                    PictureBox4.Tag = Nothing
                    PictureBox4.Cursor = Cursors.Hand
                Case 5
                    PictureBox5.Image = Nothing
                    PictureBox5.Tag = Nothing
                    PictureBox5.Cursor = Cursors.Hand
                Case 6
                    PictureBox6.Image = Nothing
                    PictureBox6.Tag = Nothing
                    PictureBox6.Cursor = Cursors.Hand
                Case 7
                    PictureBox7.Image = Nothing
                    PictureBox7.Tag = Nothing
                    PictureBox7.Cursor = Cursors.Hand
                Case 8
                    PictureBox8.Image = Nothing
                    PictureBox8.Tag = Nothing
                    PictureBox8.Cursor = Cursors.Hand
                Case 9
                    PictureBox9.Image = Nothing
                    PictureBox9.Tag = Nothing
                    PictureBox9.Cursor = Cursors.Hand
            End Select
            If countMoves = 1 Then
                MenuItemUndo.Enabled = False
                MenuItemSave.Enabled = False
            End If
            MenuItemRedo.Enabled = True
        End If
    End Sub

    Private Sub BTNredo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRedo.Click
        If STGredo Or opening Then
            Select Case moves(countMoves)
                Case 1
                    PictureBox1.Image = players(currPlayer).normal
                    PictureBox1.Tag = players(currPlayer).token
                    PictureBox1.Cursor = Cursors.Default
                Case 2
                    PictureBox2.Image = players(currPlayer).normal
                    PictureBox2.Tag = players(currPlayer).token
                    PictureBox2.Cursor = Cursors.Default
                Case 3
                    PictureBox3.Image = players(currPlayer).normal
                    PictureBox3.Tag = players(currPlayer).token
                    PictureBox3.Cursor = Cursors.Default
                Case 4
                    PictureBox4.Image = players(currPlayer).normal
                    PictureBox4.Tag = players(currPlayer).token
                    PictureBox4.Cursor = Cursors.Default
                Case 5
                    PictureBox5.Image = players(currPlayer).normal
                    PictureBox5.Tag = players(currPlayer).token
                    PictureBox5.Cursor = Cursors.Default
                Case 6
                    PictureBox6.Image = players(currPlayer).normal
                    PictureBox6.Tag = players(currPlayer).token
                    PictureBox6.Cursor = Cursors.Default
                Case 7
                    PictureBox7.Image = players(currPlayer).normal
                    PictureBox7.Tag = players(currPlayer).token
                    PictureBox7.Cursor = Cursors.Default
                Case 8
                    PictureBox8.Image = players(currPlayer).normal
                    PictureBox8.Tag = players(currPlayer).token
                    PictureBox8.Cursor = Cursors.Default
                Case 9
                    PictureBox9.Image = players(currPlayer).normal
                    PictureBox9.Tag = players(currPlayer).token
                    PictureBox9.Cursor = Cursors.Default
            End Select
            countMoves += 1
            If CheckWinner(moves(countMoves)) = False Then SwitchPlayer()

            If countMoves = maxMoves Then MenuItemRedo.Enabled = False
            MenuItemUndo.Enabled = True
            MenuItemSave.Enabled = True
        End If
    End Sub

    Function CheckWinner(ByVal picID As Integer)
        'HORIZONTAL:
        If picID <= 3 Then
            If PictureBox1.Tag = PictureBox2.Tag And PictureBox1.Tag = PictureBox3.Tag And PictureBox1.Tag <> "" Then
                PNLtop.Visible = True
                Return Win(PictureBox1.Tag)
            End If
        ElseIf picID <= 6 Then
            If PictureBox4.Tag = PictureBox5.Tag And PictureBox4.Tag = PictureBox6.Tag And PictureBox4.Tag <> "" Then
                PNLmiddleH.Visible = True
                Return Win(PictureBox4.Tag)
            End If
        Else
            If PictureBox7.Tag = PictureBox8.Tag And PictureBox7.Tag = PictureBox9.Tag And PictureBox7.Tag <> "" Then
                PNLbottom.Visible = True
                Return Win(PictureBox7.Tag)
            End If
        End If
        'VERTICAL
        If picID Mod 3 = 1 Then
            If PictureBox1.Tag = PictureBox4.Tag And PictureBox1.Tag = PictureBox7.Tag And PictureBox1.Tag <> "" Then
                PNLleft.Visible = True
                Return Win(PictureBox1.Tag)
            End If
        ElseIf picID Mod 3 = 2 Then
            If PictureBox2.Tag = PictureBox5.Tag And PictureBox2.Tag = PictureBox8.Tag And PictureBox2.Tag <> "" Then
                PNLmiddleV.Visible = True
                Return Win(PictureBox2.Tag)
            End If
        Else
            If PictureBox3.Tag = PictureBox6.Tag And PictureBox3.Tag = PictureBox9.Tag And PictureBox3.Tag <> "" Then
                PNLright.Visible = True
                Return Win(PictureBox3.Tag)
            End If
        End If
        'DIAGONAL
        If picID Mod 2 = 1 Then
            If PictureBox1.Tag = PictureBox5.Tag And PictureBox1.Tag = PictureBox9.Tag And PictureBox1.Tag <> "" Then Return Win(PictureBox1.Tag)
            If PictureBox3.Tag = PictureBox5.Tag And PictureBox3.Tag = PictureBox7.Tag And PictureBox3.Tag <> "" Then Return Win(PictureBox3.Tag)
        End If

        If PictureBox1.Tag <> "" And PictureBox2.Tag <> "" And PictureBox3.Tag <> "" And PictureBox4.Tag <> "" And PictureBox5.Tag <> "" And PictureBox6.Tag <> "" And PictureBox7.Tag <> "" And PictureBox8.Tag <> "" And PictureBox9.Tag <> "" Then Return Tie()
        Return False
    End Function

    Function Win(ByVal token As String)
        TMRtime.Stop()
        Dim seconds As Integer = timer Mod 60
        Dim minutes As Integer = timer \ 60
        If token = players(currPlayer).token Then
            wins(currPlayer) += 1
        Else
            wins(1 - currPlayer) += 1
        End If
        ToolStripStatusLabelXwins.Text = "X wins: " & wins(0)
        ToolStripStatusLabelOwins.Text = "O wins: " & wins(1)
        MenuItemUndo.Enabled = False
        MenuItemRedo.Enabled = False

        If MsgBox(token & " won in " & minutes & " minute(s) and " & seconds & " second(s)" & vbCrLf & "Do you want to start a new game now?", MsgBoxStyle.YesNo, "End of game") = vbYes Then
            ClearGrid()
        Else
            gameEnded = True
            PictureBox1.Cursor = Cursors.Default
            PictureBox2.Cursor = Cursors.Default
            PictureBox3.Cursor = Cursors.Default
            PictureBox4.Cursor = Cursors.Default
            PictureBox5.Cursor = Cursors.Default
            PictureBox6.Cursor = Cursors.Default
            PictureBox7.Cursor = Cursors.Default
            PictureBox8.Cursor = Cursors.Default
            PictureBox9.Cursor = Cursors.Default
        End If
        Return True
    End Function

    Function Tie()
        gameEnded = True
        TMRtime.Stop()
        If MsgBox("Tie!" & vbCrLf & "Do you want to start a new game now?", MsgBoxStyle.YesNo, "End of game") = vbYes Then ClearGrid()
        Return True
    End Function

    Private Sub BTNreset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNreset.Click
        wins = {0, 0}
        ToolStripStatusLabelXwins.Text = "X wins: 0"
        ToolStripStatusLabelOwins.Text = "O wins: 0"
    End Sub

    Private Sub BTNexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub BTNoptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOptions.Click
        TMRtime.Stop()
        FRMoptions.ShowDialog()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        wins(0) += Math.Floor(Rnd() * 420)
        wins(1) += Math.Floor(Rnd() * 420)
        ToolStripStatusLabelXwins.Text = "X wins: " & wins(0)
        ToolStripStatusLabelOwins.Text = "O wins: " & wins(1)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        MsgBox("You need help for playing Tic Tac Toe?!", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub MenuItemSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSave.Click
        Dim FileName As String
        'declaring filename that will be selected
        Dim sw As StreamWriter
        'streamwriter is used to write text
        Try
            With SaveFileDialog1
                .FileName = FileName
                .Filter = "Tic Tac Toe SaveGame (*.ttt)|*.ttt"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                    sw = New StreamWriter(FileName)
                    'using streamwriter to write text from richtextbox and saving it
                    Dim output As String = startPlayer
                    For i As Integer = 1 To countMoves - 1
                        output &= moves(i)
                    Next
                    sw.Write(output)
                    'FilePath = FileName
                    'BTNfolder.Enabled = True
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (sw Is Nothing) Then
                sw.Close()
            End If
        End Try
    End Sub

    Private Sub MenuItemOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOpen.Click
        Dim FileName As String
        'declaring filename that will be selected
        Dim sr As StreamReader
        'streamreader is used to read text
        Try
            With OpenFileDialog1
                'With statement is used to execute statements using a particular object, here,_
                'OpenFileDialog1
                .Filter = "Tic Tac Toe SaveGame (*.ttt)|*.ttt"
                'setting filters so that Text files and All Files choice appears in the Files of Type box
                'in the dialog
                If .ShowDialog() = DialogResult.OK Then
                    'showDialog method makes the dialog box visible at run time
                    FileName = .FileName
                    sr = New StreamReader(.OpenFile)
                    'using streamreader to read the opened text file
                    If gameEnded = False And countMoves > 1 Then
                        If MsgBox("Are you sure you want to cancel the current game and load a new game?", MsgBoxStyle.OkCancel, "Load a New Game") = vbOK Then PlayFromFile(sr.ReadToEnd())
                    Else
                        PlayFromFile(sr.ReadToEnd())
                    End If
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
    End Sub

    Sub PlayFromFile(ByVal sequence As String)
        ClearGrid()
        startPlayer = Val(sequence.ToCharArray()(0))
        currPlayer = startPlayer
        Dim seqarr = sequence.Substring(1).ToCharArray
        For i As Integer = 0 To seqarr.Length - 1
            moves(i + 1) = Val(seqarr(i))
        Next
        countMoves = 1
        maxMoves = seqarr.Length + 1
        opening = True
        MenuItemRedo.Enabled = True
        For i As Integer = 0 To seqarr.Length - 1
            MenuItemRedo.PerformClick()
        Next
        opening = False
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class