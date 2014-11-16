Public Class FindReplace

    Sub Find(ByVal forward As Boolean)
        Dim location As Integer
        Dim SC As StringComparison = StringComparison.CurrentCultureIgnoreCase
        If CHKcase.Checked Then SC = StringComparison.CurrentCulture

        If forward Then
            location = Main.TextBox1.SelectionStart + Main.TextBox1.SelectionLength
            If location >= Main.TextBox1.Text.Length Then location = Main.TextBox1.Text.Length
            Location = Main.TextBox1.Text.IndexOf(TXTsearch.Text, Location, SC)
        Else
            location = Main.TextBox1.SelectionStart
            If location > 0 Then location -= 1
            location = Main.TextBox1.Text.LastIndexOf(TXTsearch.Text, location, Main.TextBox1.SelectionStart, SC)
        End If

        If Location = -1 Then
            MsgBox("Cannot find """ & TXTsearch.Text & """", MsgBoxStyle.Information, "Notepad--")
        Else
            Main.TextBox1.SelectionStart = Location
            Main.TextBox1.SelectionLength = TXTsearch.Text.Length
        End If
    End Sub

    Sub Replace()
        Main.TextBox1.SelectedText = TXTreplace.Text
        Find(True)
    End Sub

    Sub ReplaceAll()
        Main.TextBox1.Text = Main.TextBox1.Text.Replace(TXTsearch.Text, TXTreplace.Text)
    End Sub

    Private Sub BTNcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNcancel.Click
        Me.Close()
    End Sub

    Private Sub BTNnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNnext.Click
        Find(True)
    End Sub

    Private Sub FindReplace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Main.TextBox1.SelectionLength > 0 Then TXTsearch.Text = Main.TextBox1.SelectedText
        TXTsearch.Select()
    End Sub

    Private Sub TXTsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTsearch.TextChanged
        BTNnext.Enabled = TXTsearch.Text.Length > 0
    End Sub

    Private Sub BTNprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNprev.Click
        Find(False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Replace()
    End Sub

    Private Sub BTNreplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNreplaceAll.Click
        ReplaceAll()
    End Sub
End Class