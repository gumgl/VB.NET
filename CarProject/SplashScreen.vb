Public NotInheritable Class SplashScreen

    Dim totalTime As Single = 10
    Dim currStep As Integer = 0
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.MinimumSplashScreenDisplayTime = totalTime * 1000
        Timer1.Start()
    End Sub

    Protected Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
        My.Application.MinimumSplashScreenDisplayTime = totalTime * 1000
        Return Me.OnInitialize(commandLineArgs)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        currStep += 1
        If currStep <= 100 Then
            Me.Opacity = currStep
        ElseIf currStep = 150 Then
            PICtitle.Visible = True
        ElseIf currStep = 200 Then
            PICname.Visible = True
        ElseIf currStep = 250 Then
            PICyear.Visible = True
        End If
    End Sub
End Class
