Public Structure Company
    Dim name As String
    Dim logo As Image
    Dim cars() As Car
End Structure

Public Structure Car
    Dim price As Single
    Dim name As String
    Dim picture As Image
End Structure

Public Class FRMChooseCompany

    Public companies(5) As Company
    Dim companyNames() As String = {"Ferrari", "Porsche", "Audi", "Renault", "Peugeot", "Smart"}
    Dim carNames(,) As String = New String(,) {{"Enzo", "California", "599", "458 Italia", "Superamerica", "F1"},
                                 {"997 Carrera", "Panamera", "Boxster", "Cayenne", "Cayman", "911 Carerra 4S"},
                                 {"A4", "A6", "A8", "Q7", "TT", "R8"},
                                 {"Mégane", "Kangoo", "Trafic", "Clio", "Espace", "Twingo"},
                                 {"207", "308 CC", "407", "508", "607", "Partner"}}
    Dim carResources(,) As String = New String(,) {{"Enzo", "California", "_599", "_458", "Superamerica", "F1"},
                                 {"_997_Carrera", "Panamera", "Boxster", "Cayenne", "Cayman", "_911_Carrera_4S"},
                                 {"A4", "A6", "A8", "Q7", "TT", "splashscreen_background"},
                                 {"Mégane", "Kangoo", "Trafic", "Clio", "Espace", "Twingo"},
                                 {"_207", "_308_CC", "_407", "_508", "_607", "Partner"}}

    Dim carPrices(,) As Single = New Single(,) {{670000, 192000, 256000, 221000, 320000, 25000000},
                                                {90100, 86600, 54900, 55300, 59200, 112200},
                                                {32300, 45200, 78050, 46250, 38300, 149000},
                                                {25700, 15000, 26800, 18000, 46800, 11100},
                                                {17600, 24700, 28300, 31100, 36300, 20300}}
    Public currPosition As Integer = 4

    Dim startPos As Integer = 264
    Dim stepLength As Integer = 694
    Dim addsub As Single
    Dim positions(4) As Single
    Dim displayed As Boolean

    Dim newPoint As New System.Drawing.Point()
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim OriginalTitle As String
    'Dim table1 As DataTable = New DataTable("companies")

    Private Sub ChooseCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PICicon.Image = Me.Icon.ToBitmap()
        OriginalTitle = LBLtitle.Text

        For count = 0 To 5
            companies(count).name = companyNames(count)
            companies(count).logo = My.Resources.ResourceManager.GetObject(companyNames(count))
            companies(count).cars = New Car(5) {}
            If count < 5 Then ' We don't want to put cars in last company
                For count2 = 0 To 5
                    companies(count).cars(count2).name = carNames(count, count2)
                    companies(count).cars(count2).price = carPrices(count, count2)
                    companies(count).cars(count2).picture = My.Resources.ResourceManager.GetObject(carResources(count, count2))
                Next
            End If
        Next
        chooseCompany()
        DisplayAvailable()
    End Sub

    Private Sub ChooseCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Up Then
            PrevCompany()
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.Down Then
            NextCompany()
        End If
        If e.KeyCode = Keys.Enter Then
            LaunchProgram()
        End If
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then
            End
        End If
    End Sub

    Private Sub PICprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICprev.Click
        PrevCompany()
    End Sub

    Private Sub PICprev_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICprev.MouseEnter
        PICprev.Image = My.Resources.prev_hover
    End Sub

    Private Sub PICprev_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICprev.MouseLeave
        PICprev.Image = My.Resources.prev
    End Sub

    Private Sub PICnext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICnext.MouseEnter
        PICnext.Image = My.Resources.next_hover
    End Sub

    Private Sub PICnext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICnext.MouseLeave
        PICnext.Image = My.Resources._next
    End Sub

    Private Sub PICnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICnext.Click
        NextCompany()
    End Sub
    Sub PrevCompany()
        If MoveCompanies.Enabled = False Then
            displayed = False
            currPosition = PrevPos(currPosition)
            PICprev.Visible = False
            PICnext.Visible = False
            MoveAll(stepLength)
        End If
    End Sub
    Sub NextCompany()
        If MoveCompanies.Enabled = False Then
            displayed = False
            currPosition = NextPos(currPosition)
            PICprev.Visible = False
            PICnext.Visible = False
            MoveAll(-1 * stepLength)
        End If
    End Sub

    Sub chooseCompany()
        PICprev.Visible = True
        PICnext.Visible = True

        PICcompany1.Image = companies(PrevPos(PrevPos(currPosition))).logo
        PICcompany2.Image = companies(PrevPos(currPosition)).logo

        LBLcompanyName.Text = companies(currPosition).name
        PICcompany3.Image = companies(currPosition).logo

        PICcompany4.Image = companies(NextPos(currPosition)).logo
        PICcompany5.Image = companies(NextPos(NextPos(currPosition))).logo

        PICcompany1.Left = startPos - (2 * stepLength)
        PICcompany2.Left = startPos - stepLength
        PICcompany3.Left = startPos
        PICcompany4.Left = startPos + stepLength
        PICcompany5.Left = startPos + (2 * stepLength)

        positions(0) = PICcompany1.Left
        positions(1) = PICcompany2.Left
        positions(2) = PICcompany3.Left
        positions(3) = PICcompany4.Left
        positions(4) = PICcompany5.Left
    End Sub

    Sub DisplayAvailable()
        displayed = True
        LBLcompanyName.Text = companies(currPosition).name
        SetTitle(companies(currPosition).name)
        Dim output As String = "Available Cars: "
        Dim average As Double = 0

        If currPosition = 5 Then
            output = "This company is unavailable."
        Else
            For count = 0 To 5
                output &= companies(currPosition).cars(count).name
                If count < 4 Then output &= ", "
                If count = 4 Then output &= " and "
                average += companies(currPosition).cars(count).price
            Next
            average /= 6
        End If

        If companies(currPosition).name = "Audi" Then
            PICicon.Image = My.Resources.Audi_small
            Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.Audi_small.GetHicon)
        Else
            PICicon.Image = companies(currPosition).logo
            Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.ResourceManager.GetObject(companies(currPosition).name).GetHicon)
        End If
        If average > 0 Then
            LBLaverageL.Show()
            LBLaverage.Show()
            LBLaverage.Text = FormatCurrency(average, 0)
        Else
            LBLaverageL.Hide()
            LBLaverage.Hide()
        End If
        LBLavailable.Text = output
    End Sub

    Function PrevPos(ByVal pos As Integer)
        pos -= 1
        If pos < 0 Then pos = 5
        Return pos
    End Function

    Function NextPos(ByVal pos As Integer)
        pos += 1
        If pos > 5 Then pos = 0
        Return pos
    End Function

    Private Sub PICcurrCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICcompany3.Click
        LaunchProgram()
    End Sub

    Private Sub LBLcompanyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLcompanyName.Click
        LaunchProgram()
    End Sub

    Sub LaunchProgram()
        If currPosition = 5 Then
            LBLavailable.Text = "Sorry, this company is not available. Please choose another one."
        Else
            FRMProgram.Show()
            Me.Hide()
            MoveCompanies.Stop()
            chooseCompany()
        End If
    End Sub

    Sub MoveAll(ByVal pixels As Integer)
        addsub = -1 ' going left
        If pixels > 0 Then addsub = 1 ' going right

        addsub *= 30
        MoveCompanies.Start()
    End Sub

    Private Sub MoveCompanies_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveCompanies.Tick
        addsub /= 1.04

        For count = 0 To 4
            positions(count) += addsub
        Next
        PICcompany1.Left = positions(0)
        PICcompany2.Left = positions(1)
        PICcompany3.Left = positions(2)
        PICcompany4.Left = positions(3)
        PICcompany5.Left = positions(4)

        If (PICcompany2.Left > startPos - stepLength / 2 Or PICcompany4.Left < startPos + stepLength / 2) And displayed = False Then
            DisplayAvailable()
        End If
        If PICcompany2.Left + addsub > startPos Or PICcompany4.Left + addsub < startPos Then
            MoveCompanies.Stop()
            chooseCompany()
        End If
    End Sub

    Sub SetTitle(ByVal title As String)
        title &= " - " & OriginalTitle
        LBLtitle.Text = title
        Me.Text = title
    End Sub

    Private Sub PNLtitlebar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNLtitlebar.MouseDown
        StartMoving()
    End Sub

    Private Sub PNLtitlebar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNLtitlebar.MouseMove
        MoveWindow(e)
    End Sub

    Private Sub LBLtitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBLtitle.MouseDown
        StartMoving()
    End Sub

    Private Sub LBLtitle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LBLtitle.MouseMove
        MoveWindow(e)
    End Sub

    Sub StartMoving()
        mouseX = Control.MousePosition.X - Me.Location.X
        mouseY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Sub MoveWindow(ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (mouseX)
            newPoint.Y = newPoint.Y - (mouseY)
            Me.Location = newPoint
        End If
    End Sub

    Private Sub PICminimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PICminimize_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICminimize.MouseEnter
        PICminimize.Image = My.Resources.minimize_hover
    End Sub

    Private Sub PICminimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICminimize.MouseLeave
        PICminimize.Image = My.Resources.minimize
    End Sub

    Private Sub PICclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICclose.Click
        End
    End Sub

    Private Sub PICclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICclose.MouseEnter
        PICclose.Image = My.Resources.close_hover
    End Sub

    Private Sub PICclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PICclose.MouseLeave
        PICclose.Image = My.Resources.close
    End Sub
End Class