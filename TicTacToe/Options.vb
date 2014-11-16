Public Class FRMoptions

    Private Sub FRMoptions_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If FRMmain.STGtimed Then FRMmain.TMRtime.Start()
    End Sub

    Private Sub FRMoptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FRMmain.STGfirstPlayer = 1 Then
            RADalternate.Checked = True
        ElseIf FRMmain.STGfirstPlayer = 2 Then
            RADwinner.Checked = True
        ElseIf FRMmain.STGfirstPlayer = 3 Then
            RADloser.Checked = True
        Else
            RADrandom.Checked = True
        End If
        CHKtimed.Checked = FRMmain.STGtimed
        CHKundo.Checked = FRMmain.STGundo
        CHKredo.Checked = FRMmain.STGredo

        PNLbgcolor.BackColor = FRMmain.PictureBox1.BackColor
        If PNLbgcolor.BackColor.R * 0.299 + PNLbgcolor.BackColor.G * 0.587 + PNLbgcolor.BackColor.B * 0.114 > FRMmain.blackReach Then
            Panel1.BackColor = Color.Black
            Panel2.BackColor = Color.Black
            Panel3.BackColor = Color.Black
            Panel4.BackColor = Color.Black
        Else
            Panel1.BackColor = Color.White
            Panel2.BackColor = Color.White
            Panel3.BackColor = Color.White
            Panel4.BackColor = Color.White
        End If

        BTNok.Focus()
    End Sub

    Private Sub BTNok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNok.Click
        If RADalternate.Checked Then
            FRMmain.STGfirstPlayer = 1
        ElseIf RADwinner.Checked Then
            FRMmain.STGfirstPlayer = 2
        ElseIf RADloser.Checked Then
            FRMmain.STGfirstPlayer = 3
        Else
            FRMmain.STGfirstPlayer = 4
        End If
        FRMmain.STGtimed = CHKtimed.Checked
        FRMmain.ToolStripStatusLabelTimer.Visible = CHKtimed.Checked
        FRMmain.STGundo = CHKundo.Checked
        FRMmain.MenuItemUndo.Visible = CHKundo.Checked
        FRMmain.STGredo = CHKredo.Checked
        FRMmain.MenuItemRedo.Visible = CHKredo.Checked
        FRMmain.MenuItem3.Visible = CHKundo.Checked Or CHKredo.Checked

        FRMmain.PictureBox1.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox2.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox3.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox4.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox5.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox6.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox7.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox8.BackColor = PNLbgcolor.BackColor
        FRMmain.PictureBox9.BackColor = PNLbgcolor.BackColor

        If PNLbgcolor.BackColor.R * 0.299 + PNLbgcolor.BackColor.G * 0.587 + PNLbgcolor.BackColor.B * 0.114 > FRMmain.blackReach Then
            FRMmain.PNLboard.BackColor = Color.Black
        Else
            FRMmain.PNLboard.BackColor = Color.White
        End If

        Me.Close()
    End Sub

    Private Sub BTNcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNcancel.Click
        Me.Close()
    End Sub

    Private Sub CHKundo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKundo.CheckedChanged
        If CHKundo.Checked = False Then CHKredo.Checked = False
    End Sub

    Private Sub CHKredo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKredo.CheckedChanged
        If CHKredo.Checked Then CHKundo.Checked = True
    End Sub

    Private Sub BTNbgcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNbgcolor.Click
        If CLDbg.ShowDialog() = DialogResult.OK Then
            PNLbgcolor.BackColor = CLDbg.Color
            If PNLbgcolor.BackColor.R * 0.299 + PNLbgcolor.BackColor.G * 0.587 + PNLbgcolor.BackColor.B * 0.114 > FRMmain.blackReach Then
                Panel1.BackColor = Color.Black
                Panel2.BackColor = Color.Black
                Panel3.BackColor = Color.Black
                Panel4.BackColor = Color.Black
            Else
                Panel1.BackColor = Color.White
                Panel2.BackColor = Color.White
                Panel3.BackColor = Color.White
                Panel4.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub PNLbgcolor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PNLbgcolor.Click
        BTNbgcolor_Click(sender, e)
    End Sub

    Private Sub BTNresetBGcolor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNresetBGcolor.Click
        PNLbgcolor.BackColor = Color.White
        Panel1.BackColor = Color.Black
        Panel2.BackColor = Color.Black
        Panel3.BackColor = Color.Black
        Panel4.BackColor = Color.Black
    End Sub
End Class