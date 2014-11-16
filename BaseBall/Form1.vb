Public Class Form1
    Dim mtl(8) As Integer
    Dim ottawa(8) As Integer
    Dim inning As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLmtl.Text = Nothing
        LBLottawa.Text = Nothing
    End Sub

    Private Sub BTNnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNnext.Click
        If TXTmtl.Text = Nothing Then
            TXTmtl.Focus()
        ElseIf TXTottawa.Text = Nothing Then
            TXTottawa.Focus()
        Else
            calc()
        End If
    End Sub

    Private Sub BTNexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNexit.Click
        Me.Close()
    End Sub

    Private Sub TXTmtl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTmtl.GotFocus
        TXTmtl.Select(TXTmtl.Text.Length, 0)
    End Sub

    Private Sub TXTmtl_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTmtl.MouseDown
        TXTmtl.Select(TXTmtl.Text.Length, 0)
    End Sub

    Private Sub TXTottawa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTottawa.GotFocus
        TXTottawa.Select(TXTottawa.Text.Length, 0)
    End Sub

    Private Sub TXTottawa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TXTottawa.MouseDown
        TXTottawa.Select(TXTottawa.Text.Length, 0)
    End Sub

    Private Sub TXTmtl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTmtl.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTottawa.Focus()
            calc()
        End If
    End Sub

    Private Sub TXTottawa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTottawa.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXTmtl.Focus()
            calc()
        End If
    End Sub

    Sub calc()
        Dim sum As Integer = 0

        If TXTmtl.Text <> Nothing And TXTottawa.Text <> Nothing Then
            mtl(inning) = TXTmtl.Text
            ottawa(inning) = TXTottawa.Text
            TXTmtl.Text = Nothing
            TXTottawa.Text = Nothing
            LBLmtl.Text &= mtl(inning)
            LBLottawa.Text &= ottawa(inning)
            If mtl(inning) < 10 Then LBLmtl.Text &= " "
            If ottawa(inning) < 10 Then LBLottawa.Text &= " "
            LBLmtl.Text &= " "
            LBLottawa.Text &= " "

            inning += 1
            LBLinning.Text = inning + 1

            TXTmtl.Focus()
        End If

        If inning = 9 Then
            For Each n In mtl
                sum += n
            Next
            LBLmtl.Text &= sum
            sum = 0
            For Each n In ottawa
                sum += n
            Next
            LBLottawa.Text &= sum
            TXTmtl.Enabled = False
            TXTottawa.Enabled = False
            BTNnext.Enabled = False
            BTNexit.TabStop = True
            BTNexit.Focus()
        End If
    End Sub
End Class
