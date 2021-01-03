Imports System.IO

Public Class BlockWeb
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()
    End Sub

    Private Sub block_Click(sender As Object, e As EventArgs) Handles block.Click
        Dim m As String = urlbox.Text
        Dim FILE_NAME As String = "C:\Windows\system32\drivers\etc\hosts"
        Dim aryText As String
        aryText = "127.0.0.1" & Space(4) & m
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
        objWriter.WriteLine(aryText)
        objWriter.Close()
        MsgBox(m & " Has been Blocked")
    End Sub

    Private Sub viewurl_Click(sender As Object, e As EventArgs) Handles viewurl.Click
        Dim s As String = My.Computer.FileSystem.ReadAllText("C:\Windows\system32\drivers\etc\hosts")
        MsgBox(s)
    End Sub

    Private Sub unblock_Click(sender As Object, e As EventArgs) Handles unblock.Click
        Dim m As String = urlbox.Text
        Dim FILE_NAME As String = "C:\Windows\system32\drivers\etc\hosts"
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(FILE_NAME).Replace("127.0.0.1" & Space(4) & m, "")
        My.Computer.FileSystem.WriteAllText(FILE_NAME, fileReader, False)
        MsgBox(m & " Has been UnBlocked")
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click
        Hide()
        MyMenu.Show()
    End Sub
End Class