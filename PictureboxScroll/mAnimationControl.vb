Module mAnimationControl
    'Usage:
    'create a collection of pictureboxes contained within one single parent (your form, a panel, a groupbox, etc. etc.)
    'you must first align your collection of pictureboxes using colAlign(collection) or else code will break. pictureboxes must be aligned
    'you should make sure all your pictureboxes are at max size before aligning, though, to avoid drawing pictureboxes ontop of eachother
    'use any sort of looping (do/for/while loop, or a timer, etc.) to constantly call colGlide and colResize on your collection
    'or use colAnimate, which is a combination of both colResize and colGlide

    Public iSpacer As Integer = 25 'Used for the spacing in gliding animation
    Public iTotalWidth As Integer

    Public Sub picResize(ByVal picObj As PictureBox, ByVal minSize As Size, ByVal maxSize As Size)
        Dim percentGrow As Single
        percentGrow = (picObj.Left + (picObj.Width / 2)) / (picObj.Parent.Width / 2)
        If percentGrow > 1 Then percentGrow = (percentGrow * -1) + 2
        picObj.Width = minSize.Width + ((maxSize.Width - minSize.Width) * percentGrow)
        picObj.Height = minSize.Height + ((maxSize.Height - minSize.Height) * percentGrow)
        picObj.Top = (picObj.Parent.Height / 2) - (picObj.Height / 2)
    End Sub

    Public Sub colResize(ByVal picCollection As Collection, ByVal minSize As Size, ByVal maxSize As Size)
        For Each picObj As PictureBox In picCollection
            picResize(picObj, minSize, maxSize)
        Next
    End Sub

    Public Sub colAlign(ByVal picCollection As Collection)
        For Each picObj As PictureBox In picCollection
            picObj.Left = iTotalWidth
            iTotalWidth += picObj.Width + iSpacer
        Next
    End Sub

    Public Sub colGlide(ByVal picCollection As Collection, ByVal iStep As Integer)
        For Each picObj As PictureBox In picCollection
            picObj.Left += iStep
            If picObj.Left > iTotalWidth Then
                picObj.Left = -picObj.Width
            ElseIf picObj.Left < -picObj.Width Then
                picObj.Left = iTotalWidth
            End If
        Next
    End Sub

    Public Sub colAnimate(ByVal picCollection As Collection, ByVal iStep As Integer, ByVal minSize As Size, ByVal maxSize As Size)
        colGlide(picCollection, iStep)
        colResize(picCollection, minSize, maxSize)
    End Sub
End Module
