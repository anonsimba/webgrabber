Public Class urlparsing
    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub gobutton_Click(sender As Object, e As EventArgs) Handles gobutton.Click
        Dim url As String = urlbox.Text
        Dim uri As New Uri(url)
        Dim protocol As String = uri.Scheme     ' http
        Dim host As String = uri.Host           ' localhost
        Dim port As Integer = uri.Port           ' 8080
        Dim path As String = uri.AbsolutePath   ' /settings/settings.php
        Dim querystring As String = uri.Query   ' ?setting=layout&value=normal
        MsgBox("Protocol:" & protocol & vbCrLf & "Host:" & host & vbCrLf & "Port:" & port & vbCrLf & "Path" & path & vbCrLf & "Query String:" & querystring, MsgBoxStyle.Information, "URL Prsing")
    End Sub

    Private Sub mainmenu_Click(sender As Object, e As EventArgs) Handles mainmenu.Click
        Hide()
        MyMenu.Show()
    End Sub
End Class