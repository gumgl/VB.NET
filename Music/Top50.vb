Imports System.IO

Public Class Top50
    Structure Song
        Dim artist As String
        Dim title As String
        Dim most As Integer
        Dim last As Integer
        Dim this As Integer
    End Structure

    Public FileName As String
    Dim songs(49) As Song

    Private Sub Top50_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FileName As String = " "

        FileName = InputBox("Enter the File Name", "File Name Needed")
        While File.Exists(FileName) = False And FileName <> ""
            MessageBox.Show("File Not Found")
            FileName = InputBox("Enter the File Name", "File Name Needed")
        End While

        If File.Exists(FileName) Then
            Dim InFile As StreamReader = File.OpenText(FileName)
            Dim IsValid As Boolean = False
            Dim Info() As String
            Dim count As Integer = 0

            IsValid = True
            Try
                Do While InFile.Peek <> -1
                    Info = InFile.ReadLine().Split(CChar(","))
                    ListBox1.Items.Add(Info(3))

                    songs(count).this = Val(Info(0))
                    songs(count).last = Val(Info(1))
                    songs(count).artist = Info(2)
                    songs(count).title = Info(3)
                    songs(count).most = Val(Info(4))

                    count += 1
                Loop
                InFile.Close()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        Else
            Me.Close()
        End If
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        LBLartist.Text = songs(ListBox1.SelectedIndex).artist
        LBLthis.Text = songs(ListBox1.SelectedIndex).this
        LBLlast.Text = songs(ListBox1.SelectedIndex).last
        LBLmost.Text = songs(ListBox1.SelectedIndex).most
    End Sub
End Class