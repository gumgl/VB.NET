Public Class Form1
    Dim picMaxSize As New Size(100, 100) 'Max dimensions for the picturebox
    Dim picMinSize As New Size(5, 5) 'Min dimensions for the picturebox
    Dim iStepSize As Integer = 3 'Step size for animation (lower=slow) used in all animating function calls
    Dim iMaxSpeed As Integer = 10 'Max speed of panel animation when mouse is at the edge (higher = faster)
    Dim iArrowSpeed As Integer = iStepSize 'Speed of animation using arrows (default speed) must be seperated to not interfere with advanced animation
    Dim cPictures As New Collection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next 'used to avoid anything but pictureboxes being added to the collection
        For Each objPic As PictureBox In Panel1.Controls
            cPictures.Add(objPic)
            objPic.Size = picMaxSize
        Next
        colAlign(cPictures) 'align the collection (MUST!)
        colResize(cPictures, picMinSize, picMaxSize) 'and resize it (optional. you can skip this step)

        lblInfo.Text = "Put your mouse over the two arrows at the top of the form to move the pictures left and right" & vbCrLf & _
            "Or, you can put your mouse on the panel directly and move the pictures slower or faster, and stop it from moving by hovering over a picture!"
    End Sub

    Private Sub timerAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerAnimate.Tick
        colAnimate(cPictures, iStepSize, picMinSize, picMaxSize)
    End Sub

    Private Sub lblLeft_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLeft.MouseEnter
        iStepSize = Math.Abs(iArrowSpeed) * -1
        timerAnimate.Start()
    End Sub

    Private Sub lblRight_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRight.MouseEnter, Panel1.MouseEnter
        If sender.GetType.FullName = "System.Windows.Forms.Label" Then iStepSize = Math.Abs(iArrowSpeed)
        timerAnimate.Start()
    End Sub

    Private Sub lblDirection_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLeft.MouseLeave, lblRight.MouseLeave, Panel1.MouseLeave
        timerAnimate.Stop()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        'More advanced animation
        iStepSize = Math.Floor(((e.X / (Panel1.Width / 2)) - 1) * iMaxSpeed)
    End Sub
End Class
