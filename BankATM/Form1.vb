Public Class Form1

    Const INITIAL_PASSWORD As Integer = 12345
    Dim balance As Integer = 1000
    Const WITHDRAWAL_LIMIT As Integer = 375
    Const ROUND_TO As Integer = 5
    Const MAX_ATTEMPS As Integer = 3
    Const MAX_WITHDRAWALS As Integer = 5
    Dim BILLS() As Integer = {50, 20, 10, 5}

    Dim amountString As String = ""
    Dim passwordString As String = ""
    Dim displayChars() As Char
    Dim money(BILLS.Length) As Integer
    Dim mode As String
    Dim tickDisplay, attempts, withdrawals As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mode = "card"
        withdrawals = 0
        Display("Welcome to my ATM." & vbCrLf & "Please enter your bank card (click on it)")
    End Sub

    Sub DigitPress(ByVal digit As Integer)
        If TMRdisplay.Enabled Then Skip()
        If mode = "pin" Then
            If Len(LBLamount.Text) < 5 Then
                LBLamount.Text &= "*"
                passwordString &= digit
            End If
        ElseIf mode = "withdrawal" Then
            If Len(amountString) < 3 Then
                amountString &= digit

                LBLamount.Text = FormatCurrency(Val(amountString), 0)
            End If
        End If
    End Sub

    Sub DeletePress()
        If TMRdisplay.Enabled Then Skip()

        If mode = "pin" And passwordString <> "" Then
            passwordString = passwordString.Substring(0, Len(passwordString) - 1)
            LBLamount.Text = LBLamount.Text.Substring(0, Len(passwordString))
        ElseIf mode = "withdrawal" Then
            If amountString <> "" Then amountString = amountString.Substring(0, Len(amountString) - 1)
            LBLamount.Text = FormatCurrency(Val(amountString), 0)
        End If
    End Sub

    Sub EnterPress()
        If TMRdisplay.Enabled Then Skip()

        If mode = "pin" Then
            If Val(passwordString) = INITIAL_PASSWORD Then
                mode = "withdrawal"
                Display("Current balance: $" & balance & vbCrLf & "Withdrawals remaining: " & MAX_WITHDRAWALS - withdrawals & vbCrLf & "Type the amount of money you want to withdraw")
                LBLamount.Text = "$0"
            Else
                attempts += 1
                If attempts < MAX_ATTEMPS Then
                    passwordString = ""
                    Display("Wrong password." & vbCrLf & MAX_ATTEMPS - attempts & " attempt(s) remaining")
                Else
                    KickOut()
                End If
            End If
        ElseIf mode = "withdrawal" Then
            Dim amount = Math.Round(Val(amountString) / ROUND_TO) * 5
            If amount < ROUND_TO And Val(amountString) <> 0 Then
                Display("Stop being so cheap!" & vbCrLf & "Press Enter to continue...")
                LBLamount.Text = "$0"
            ElseIf amount > WITHDRAWAL_LIMIT Then
                Display("That's too much! Not more than $" & WITHDRAWAL_LIMIT & " please." & vbCrLf & "Press Enter to continue...")
                LBLamount.Text = "$0"
            ElseIf withdrawals >= MAX_WITHDRAWALS Then
                mode = "max_withdrawals"
                Display("Too many withdrawals." & vbCrLf & "Come back later.")
            ElseIf balance - amount < 0 Then
                Display("You don't have that money. Time to save up ;-)" & vbCrLf & "Press Enter to continue...")
                LBLamount.Text = "$0"
            ElseIf amount <> 0 Then
                mode = "info"
                Dim info As String = "$" & balance & " - $" & amount & " = $"
                balance -= amount
                info &= balance & vbCrLf
                For i As Integer = 0 To BILLS.Length - 1
                    money(i) = amount \ BILLS(i)
                    amount = amount Mod BILLS(i)
                    If money(i) > 0 Then info &= money(i) & " $" & BILLS(i) & " bill(s): $" & money(i) * BILLS(i) & vbCrLf
                Next
                Display(info & "Please pick up your money")
                withdrawals += 1
                TMRmoney.Start()
            Else
                Display("Current balance: $" & balance & vbCrLf & "Withdrawals remaining: " & MAX_WITHDRAWALS - withdrawals & vbCrLf & "Type the amount of money you want to withdraw")
                LBLamount.Text = "$0"
            End If
            amountString = ""
        End If
    End Sub

    Sub KickOut()
        PNLbuttons.Enabled = False
        mode = "wrong"
        Display("Ok that's enough..." & vbCrLf & "Now take your card and come back later.")
    End Sub

    Sub Display(ByVal message As String)
        LBLdisplay.Text = Nothing
        LBLamount.Text = Nothing

        displayChars = message.ToCharArray
        tickDisplay = 0
        TMRdisplay.Start()

        BTNskip.Visible = True
    End Sub

    Sub StopDisplay()
        TMRdisplay.Stop()
        BTNskip.Visible = False
        If mode = "wrong" Then TMRcardOUT.Start()
        If mode = "max_withdrawals" Then PICcard_Click()
    End Sub

    Sub Skip()
        StopDisplay()
        LBLdisplay.Text = displayChars
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.NumPad0 Or e.KeyCode = Keys.D0 Then
            DigitPress(0)
        ElseIf e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
            DigitPress(1)
        ElseIf e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
            DigitPress(2)
        ElseIf e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
            DigitPress(3)
        ElseIf e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4 Then
            DigitPress(4)
        ElseIf e.KeyCode = Keys.NumPad5 Or e.KeyCode = Keys.D5 Then
            DigitPress(5)
        ElseIf e.KeyCode = Keys.NumPad6 Or e.KeyCode = Keys.D6 Then
            DigitPress(6)
        ElseIf e.KeyCode = Keys.NumPad7 Or e.KeyCode = Keys.D7 Then
            DigitPress(7)
        ElseIf e.KeyCode = Keys.NumPad8 Or e.KeyCode = Keys.D8 Then
            DigitPress(8)
        ElseIf e.KeyCode = Keys.NumPad9 Or e.KeyCode = Keys.D9 Then
            DigitPress(9)
        ElseIf e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            DeletePress()
        ElseIf e.KeyCode = Keys.Enter Then
            EnterPress()
        End If
    End Sub

    Private Sub TMRdisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRdisplay.Tick
        LBLdisplay.Text &= displayChars(tickDisplay)
        tickDisplay += 1
        If tickDisplay = displayChars.Length Then StopDisplay()
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        DigitPress(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DigitPress(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DigitPress(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DigitPress(3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DigitPress(4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DigitPress(5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DigitPress(6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DigitPress(7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        DigitPress(8)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        DigitPress(9)
    End Sub

    Private Sub BTNdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNdelete.Click
        DeletePress()
    End Sub

    Private Sub BTNenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNenter.Click
        EnterPress()
    End Sub

    Private Sub PICcard_Click() Handles PICcard.Click
        If mode = "card" Then
            mode = "pin"
            TMRcardIN.Start()
            Display("Enter your 5-digit PIN." & vbCrLf & "3 attempt(s) remaining")
            PNLbuttons.Enabled = True
        ElseIf mode = "wrong" Then
            Me.Close()
        Else
            TMRcardOUT.Start()
            PNLbuttons.Enabled = False
            Display("Thank you for choosing this ATM." & vbCrLf & "Don't forget your card!")
            mode = "wrong"
        End If
    End Sub

    Private Sub BTNskip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNskip.Click
        Skip()
    End Sub

    Private Sub TMRcardIN_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRcardIN.Tick
        PICcard.Top -= 3
        If PICcard.Top <= 50 Then
            PICcard.Top = 50
            TMRcardIN.Stop()
        End If
    End Sub

    Private Sub TMRcardOUT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRcardOUT.Tick
        PICcard.Top += 3
        If PICcard.Top >= 181 Then
            PICcard.Top = 181
            TMRcardOUT.Stop()
        End If
    End Sub

    Private Sub TMRmoney_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRmoney.Tick
        Dim currBill As Integer = -1
        For i As Integer = 0 To BILLS.Length - 1
            If money(i) > 0 Then
                currBill = i
                Exit For
            End If
        Next
        PICbill.Top += 2

        If PICbill.Tag = "" And currBill >= 0 Then
            PICbill.Image = My.Resources.ResourceManager.GetObject("_" & BILLS(currBill).ToString)
            PICbill.Tag = "@"
        ElseIf PICbill.Tag = "" Then
            PICmoney.Cursor = Cursors.Hand
            TMRmoney.Stop()
            mode = "pickup"
        End If

        If PICbill.Top >= 401 Then
            PICmoney.Image = PICbill.Image 'put the new bill at bottom
            PICbill.Top = 310 'hide moving bill
            If currBill >= 0 Then
                money(currBill) -= 1
                PICbill.Tag = ""
            End If
        End If
    End Sub

    Private Sub PICmoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICmoney.Click
        If mode = "pickup" Then
            PICmoney.Image = Nothing
            PICmoney.Cursor = Cursors.Default

            mode = "withdrawal"
            EnterPress()
        End If
    End Sub
End Class