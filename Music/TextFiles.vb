Imports System.IO

Public Class TextFiles

    Private Sub BTNcreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNcreate.Click
        Dim countFriends As Integer
        Dim OutFile As StreamWriter
        Dim name As String
        Dim age As Integer
        Dim address As String

        Dim FileName As String = InputBox("Enter the File Name", "File Name Needed")
        If FileName = "" Then FileName = "Untitled"
        OutFile = File.CreateText(FileName)

        countFriends = Val(InputBox("How many friends do you have?"))

        For count As Integer = 1 To countFriends
            MessageBox.Show("Get ready to enter data for friend " & count)
            name = InputBox("Enter your friend's name")
            age = Val(InputBox("Enter your friend's age"))
            address = InputBox("Enter your friend's address")

            OutFile.WriteLine(name & "/" & age & "/" & address)
        Next

        OutFile.Close()
    End Sub

    Private Sub BTNappend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNappend.Click
        Dim countFriends As Integer
        Dim name As String
        Dim age As Integer
        Dim address As String
        Dim OutFile As StreamWriter
        Dim IsValid As Boolean = False
        Dim FileName As String

        While IsValid = False
            FileName = InputBox("Enter the File Name", "File Name Needed")
            If File.Exists(FileName) Then
                OutFile = File.AppendText(FileName)
                IsValid = True

                Integer.TryParse(InputBox("How Many Friends Does Joey Have"), countFriends)
                For Count = 1 To countFriends
                    MessageBox.Show("Get ready to enter data for friend " & Count)
                    name = InputBox("Enter your friend's name")
                    age = Val(InputBox("Enter your friend's age"))
                    address = InputBox("Enter your friend's address")

                    OutFile.WriteLine(name & "/" & age & "/" & address)
                Next
                OutFile.Close()
            Else
                MessageBox.Show("File Does Not Exist")
            End If
        End While
    End Sub

    Private Sub BTNread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNread.Click
        ListBox1.Items.Clear()
        Dim InFile As StreamReader
        Dim IsValid As Boolean = False
        Dim FileName As String
        Dim Info() As String

        While IsValid = False
            FileName = InputBox("Enter the File Name", "File Name Needed")
            If File.Exists(FileName) Then
                InFile = File.OpenText(FileName)
                IsValid = True
                Try
                    Do While InFile.Peek <> -1
                        Info = InFile.ReadLine().Split(CChar("/"))
                        ListBox1.Items.Add(Info(0) & vbTab & Info(1) & vbTab & Info(2))
                    Loop
                    InFile.Close()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            Else
                MessageBox.Show("File Does Not Exist")
            End If
        End While
    End Sub

    Private Sub BTNtop50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNtop50.Click
        Top50.Show()
    End Sub
End Class
