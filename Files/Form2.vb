Imports System.IO

Public Class Form2



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNCREATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCREATE.Click
        Dim NumFriends As Integer
        Dim STRFriend As String
        Dim Age As Integer
        Dim Address As String
        Dim Count As Integer
        Dim FileName As String
        Dim FriendFile As StreamWriter

        FileName = InputBox("Enter File Name", "FileName Needed")
        FriendFile = File.CreateText(FileName & ".txt")

        Integer.TryParse(InputBox("How Many Friends Does Joey Have"), NumFriends)
        For Count = 1 To NumFriends
            MessageBox.Show("Get Ready To Enter Joey's Friends," & Count.ToString)
            STRFriend = InputBox("Enter Joey's Friend")
            Integer.TryParse(InputBox("Enter Joey's Friend's Age"), Age)
            Address = InputBox("Enter Address For Joey's Friend")
            FriendFile.WriteLine(STRFriend & "/" & Age & "/" & Address)
            'FriendFile.WriteLine(STRFriend)
            'FriendFile.WriteLine(Age)
            'FriendFile.WriteLine(Address)
        Next

        FriendFile.Close()

    End Sub

    Private Sub BTNSHOW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSHOW.Click
        Dim STRFriend(99) As String
        Dim Age(99) As Integer
        Dim Address(99) As String
        Dim FileName As String
        Dim FriendFile As StreamReader
        Dim Valid As Boolean = False
        Dim Record As String
        Dim Field() As String
        Dim X As Integer

        LSTFRIEND.Items.Clear()
        Do While Valid = False
            FileName = InputBox("Enter Joey's File", "Input Needed")
            If File.Exists(FileName) Then
                FriendFile = File.OpenText(FileName)
                Valid = True
                Try
                    Do While FriendFile.Peek <> -1
                        Record = FriendFile.ReadLine
                        Field = Record.Split(CChar("/"))
                        STRFriend(X) = Field(0)
                        Age(X) = Field(1)
                        Address(X) = Field(2)
                        LSTFRIEND.Items.Add(Field(0) & vbTab & Field(1) & vbTab & Field(2))
                        X += 1
                    Loop
                    FriendFile.Close()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                MsgBox("Cant Find File")
            End If
        Loop
    End Sub

    Private Sub BTNAPPEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAPPEND.Click
        Dim NumFriends As Integer
        Dim STRFriend As String
        Dim Age As Integer
        Dim Address As String
        Dim Count As Integer
        Dim FileName As String
        Dim FriendFile As StreamWriter
        Dim Valid As Boolean = False

        Do While Valid = False

            FileName = InputBox("Enter File Name")
            If File.Exists(FileName) Then
                FriendFile = File.AppendText(FileName)
                Valid = True


                Integer.TryParse(InputBox("How Many Friends Does Joey Have"), NumFriends)
                For Count = 1 To NumFriends
                    MessageBox.Show("Get Ready To Enter Joey's Friends," & Count.ToString)
                    STRFriend = InputBox("Enter Joey's Friend")
                    Integer.TryParse(InputBox("Enter Joey's Friend's Age"), Age)
                    Address = InputBox("Enter Address For Joey's Friend")
                    FriendFile.WriteLine(STRFriend & "/" & Age & "/" & Address)
                    'FriendFile.WriteLine(STRFriend)
                    'FriendFile.WriteLine(Age)
                    'FriendFile.WriteLine(Address)
                Next
                FriendFile.Close()
            Else
                MessageBox.Show("File Does Not Exist")
            End If
        Loop




    End Sub
End Class