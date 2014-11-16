Public Class FRMquiz

    Const EASY As Integer = 20
    Const MEDIUM As Integer = 30
    Const HARD As Integer = 40

    Dim r As New Random(System.DateTime.Now.Millisecond)

    Dim count = EASY
    Dim alreadyCheated As Boolean = False
    Dim correct(4) As Integer
    Dim good(4) As Boolean
    Dim messages() As String = {"I pity you...",
                                "You suck badly...",
                                "Better luck next time!",
                                "Passing my quiz doesn't make you a genius.",
                                "80%... not bad.",
                                "Congratulations! You got a perfect grade!"}

    Private Sub FRMquiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLsuspensions.Text &= My.Settings.Suspensions
        If My.Settings.Suspensions > 0 Then LBLsuspensions.Visible = True
    End Sub

    Sub GenerateNumbers()
        Dim numbers(4, 1) As Integer
        For count1 = 0 To 4
            For count2 = 0 To 1
                numbers(count1, count2) = r.Next(0, count - 10 + 1)
            Next
            correct(count1) = numbers(count1, 0) * numbers(count1, 1)
        Next
        LBLnum11.Text = numbers(0, 0)
        LBLnum12.Text = numbers(0, 1)
        LBLnum21.Text = numbers(1, 0)
        LBLnum22.Text = numbers(1, 1)
        LBLnum31.Text = numbers(2, 0)
        LBLnum32.Text = numbers(2, 1)
        LBLnum41.Text = numbers(3, 0)
        LBLnum42.Text = numbers(3, 1)
        LBLnum51.Text = numbers(4, 0)
        LBLnum52.Text = numbers(4, 1)
        LBLcorrect1.Text = correct(0)
        LBLcorrect2.Text = correct(1)
        LBLcorrect3.Text = correct(2)
        LBLcorrect4.Text = correct(3)
        LBLcorrect5.Text = correct(4)
        LBLmessage.Text = "Press Enter or Tab to skip!" & vbCrLf & "Do not move your cursor out of the window."
        GRBaverage.Enabled = False
        GRBquiz.Visible = True
        TXTanswer1.Enabled = True
        TXTanswer2.Enabled = True
        TXTanswer3.Enabled = True
        TXTanswer4.Enabled = True
        TXTanswer5.Enabled = True
        TXTanswer1.Focus()
    End Sub

    Sub CheckAnswer(ByVal number As Integer, ByRef TXT As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (IsNumeric(TXT.Text) Or TXT.Text = "") And Val(TXT.Text) < (HARD - 10) * (HARD - 10) Then
            Dim MustStop = True
            If Val(TXT.Text) = correct(number) And IsNumeric(TXT.Text) Then
                TXT.Enabled = False
                good(number) = True
                TXT.BackColor = Color.LightGreen
            End If
            For Each i As Boolean In good
                If i = False Then MustStop = False
            Next
            If MustStop Then
                StopQuiz()
            ElseIf good(number) Or e.KeyCode = Keys.Enter Then
                Me.SelectNextControl(TXT, True, True, True, True)
                'FocusNext(number)
            End If
        Else
            TXT.Text = Nothing
        End If
    End Sub

    Sub FocusNext(ByVal number As Integer)
        For i = 0 To 4
            number = Next5(number)
            If good(number) = False Then
                Select Case number
                    Case 0
                        TXTanswer1.Focus()
                    Case 1
                        TXTanswer2.Focus()
                    Case 2
                        TXTanswer3.Focus()
                    Case 3
                        TXTanswer4.Focus()
                    Case 4
                        TXTanswer5.Focus()
                End Select
                Exit Sub
            End If
        Next
    End Sub

    Function Next5(ByVal number As Integer)
        If number = 4 Then Return 0
        Return number + 1
    End Function

    Sub StartQuiz()
        Reset()
        GenerateNumbers()
        TMRquiz.Start()
        BTNstart.Enabled = False
        BTNstart.ForeColor = Color.DimGray
        BTNstop.Enabled = True
        BTNstop.ForeColor = Color.Black
        TMRcursor.Start()
    End Sub

    Sub StopQuiz()
        TMRcursor.Stop()
        Dim sumBad As Integer = 0
        TMRquiz.Stop()

        If good(0) = False Then
            sumBad += 1
            TXTanswer1.BackColor = Color.LightCoral
            LBLcorrect1.Visible = True
        End If
        If good(1) = False Then
            sumBad += 1
            TXTanswer2.BackColor = Color.LightCoral
            LBLcorrect2.Visible = True
        End If
        If good(2) = False Then
            sumBad += 1
            TXTanswer3.BackColor = Color.LightCoral
            LBLcorrect3.Visible = True
        End If
        If good(3) = False Then
            sumBad += 1
            TXTanswer4.BackColor = Color.LightCoral
            LBLcorrect4.Visible = True
        End If
        If good(4) = False Then
            sumBad += 1
            TXTanswer5.BackColor = Color.LightCoral
            LBLcorrect5.Visible = True
        End If

        LBLaverage.Text = FormatPercent((5 - sumBad) / 5, 0)
        LBLmessage.Text = messages(5 - sumBad)

        GRBaverage.Enabled = True

        BTNstart.Enabled = True
        BTNstart.ForeColor = Color.Black
        BTNstop.Enabled = False
        BTNstop.ForeColor = Color.DimGray
    End Sub

    Sub Reset()
        StopQuiz()
        good = {False, False, False, False, False}
        LBLaverage.Text = Nothing
        LBLmessage.Text = "Select your program and press Start to begin the Quiz!"
        GRBquiz.Visible = False
        LBLnum11.Text = Nothing
        LBLnum12.Text = Nothing
        LBLnum21.Text = Nothing
        LBLnum22.Text = Nothing
        LBLnum31.Text = Nothing
        LBLnum32.Text = Nothing
        LBLnum41.Text = Nothing
        LBLnum42.Text = Nothing
        LBLnum51.Text = Nothing
        LBLnum52.Text = Nothing
        TXTanswer1.Text = Nothing
        TXTanswer2.Text = Nothing
        TXTanswer3.Text = Nothing
        TXTanswer4.Text = Nothing
        TXTanswer5.Text = Nothing
        TXTanswer1.Enabled = False
        TXTanswer2.Enabled = False
        TXTanswer3.Enabled = False
        TXTanswer4.Enabled = False
        TXTanswer5.Enabled = False
        TXTanswer1.BackColor = Color.White
        TXTanswer2.BackColor = Color.White
        TXTanswer3.BackColor = Color.White
        TXTanswer4.BackColor = Color.White
        TXTanswer5.BackColor = Color.White
        LBLtimeleft.ForeColor = Color.Black
        LBLcorrect1.Visible = False
        LBLcorrect2.Visible = False
        LBLcorrect3.Visible = False
        LBLcorrect4.Visible = False
        LBLcorrect5.Visible = False
        If RADeasy.Checked Then count = EASY
        If RADmedium.Checked Then count = MEDIUM
        If RADhard.Checked Then count = HARD
        LBLtimeleft.Text = count
    End Sub

    Private Sub RADeasy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADeasy.CheckedChanged
        Reset()
    End Sub

    Private Sub RADmedium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADmedium.CheckedChanged
        Reset()
    End Sub

    Private Sub RADhard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADhard.CheckedChanged
        Reset()
    End Sub

    Private Sub BTNstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNstart.Click
        StartQuiz()
    End Sub

    Private Sub BTNstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNstop.Click
        StopQuiz()
    End Sub

    Private Sub BTNreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNreset.Click
        RADeasy.Checked = True
        Reset()
    End Sub

    Private Sub BTNexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNexit.Click
        End
    End Sub

    Private Sub TXTanswer1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTanswer1.KeyUp
        CheckAnswer(0, TXTanswer1, e)
    End Sub

    Private Sub TXTanswer2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTanswer2.KeyUp
        CheckAnswer(1, TXTanswer2, e)
    End Sub

    Private Sub TXTanswer3_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTanswer3.KeyUp
        CheckAnswer(2, TXTanswer3, e)
    End Sub

    Private Sub TXTanswer4_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTanswer4.KeyUp
        CheckAnswer(3, TXTanswer4, e)
    End Sub

    Private Sub TXTanswer5_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTanswer5.KeyUp
        CheckAnswer(4, TXTanswer5, e)
    End Sub

    Private Sub TMRquiz_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRquiz.Tick
        count -= 1
        LBLtimeleft.Text = count
        If count = 5 Then LBLtimeleft.ForeColor = Color.DarkRed
        If count = 0 Then StopQuiz()
    End Sub

    Private Sub TMRcursor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRcursor.Tick
        CheckCursor()
    End Sub

    Sub CheckCursor()
        Dim MousePos As Point
        MousePos = Cursor.Position
        'MsgBox("X = " & MousePos.X & vbCrLf & "Y = " & MousePos.Y & vbCrLf & "Left: " & Me.Left & vbCrLf & "Top: " & Me.Top & vbCrLf & "Width: " & Me.Width & vbCrLf & "Height: " & Me.Height)
        If MousePos.X < Me.Left Or MousePos.X > Me.Left + Me.Width Or MousePos.Y < Me.Top Or MousePos.Y > Me.Top + Me.Height Then
            StopQuiz()
            LBLaverage.Text = "FAIL"
            LBLmessage.Text = "Cheating will not be tolerated! This is your last warning..."
            If alreadyCheated Then
                My.Settings.Suspensions += 1
                My.Settings.Save()
                LBLsuspensions.Text = "Number of suspensions to date: " & My.Settings.Suspensions
                LBLsuspensions.Visible = True
                MsgBox("This is your second time being caught cheating." & vbCrLf & "You are now suspended from the College." & vbCrLf & "Enjoy your vacations!", MsgBoxStyle.Critical, "No cheating!")
                End
            End If
            alreadyCheated = True
            MsgBox("You moved your cursor out of the form." & vbCrLf & "Please try again.", MsgBoxStyle.Exclamation, "No cheating!")
        End If
    End Sub
End Class
