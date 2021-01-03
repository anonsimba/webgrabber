Imports System.IO
Imports System.Net

Public Class Downloadweb
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()
    End Sub

    Private Sub download_Click(sender As Object, e As EventArgs) Handles download.Click
        Dim request As WebRequest = WebRequest.Create(urldownload.Text)
        Using response As WebResponse = request.GetResponse()
            Using reader As New StreamReader(response.GetResponseStream())
                Dim html As String = reader.ReadToEnd()
                File.WriteAllText("test.html", html)
            End Using
        End Using
        MsgBox("Website Saved Successfully")
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click
        Hide()
        MyMenu.Show()
    End Sub
End Class