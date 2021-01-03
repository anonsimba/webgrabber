Public Class MyMenu

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        Hide()
        Login.Show()
    End Sub

    Private Sub aboutbutton_Click(sender As Object, e As EventArgs) Handles aboutbutton.Click
        MsgBox("This is About Message")
    End Sub

    Private Sub helpbutton_Click(sender As Object, e As EventArgs) Handles helpbutton.Click
        MsgBox("This is Help Button")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Browser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Downloadweb.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        urlparsing.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        BlockWeb.Show()
    End Sub


End Class